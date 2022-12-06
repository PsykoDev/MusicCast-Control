#region

using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using MusicCast_Control.Config;
using YamahaReceiverLib;
using YamahaReceiverLib.System;
using YamahaReceiverLib.Zone;

#endregion

namespace MusicCast_Control;

public partial class Form1 : Form
{
    public static bool AddFormClosed = false;

    private BackgroundWorker? bg;

    private HttpClient client = new();

    private readonly ConfigBuild config = new();

    //
    // read the json settings file
    //
    private string[] inputs = new string[50];
    private string[] sound_program = new string[50];

    private readonly SystemConfig systemconfig = new();
    private YamahaAV yamahaAV = new();

    private readonly ZoneConfig zoneconfig = new();

    public Form1()
    {
        InitializeComponent();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        await config.InitializeAsync();
        await updatConfigIP();
        Setup();
    }

    private void Setup()
    {
        YamahaAV.ip = config.Config.IP;
        fetch_info();
        //backgroundUpdate();
    }

    private async Task updatConfigIP()
    {
        if (config.Config.IP == "IP")
        {
            //MessageBox.Show("");
            DialogResult result = MessageBox.Show("Please add you MusicCast ip in Config.json\nDo you want add new ip ? ", "", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        Form2 frm = new Form2();
                        frm.Show();
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
            }

            AddFormClosed = false;
        }
    }

    private void Read_input_list()
    {
        inputs = Regex.Replace(input_list, "[ \"\n\r\\[\\]\t]", "").Split(",");
        foreach (var data in inputs)
        {
            inputChange.Items.Add(data);
        }

        // Show the selected input on input list as default
        foreach (var input in inputs)
            if (currentInput == input.ToLower())
                inputChange.Text = input;
    }

    private void Read_sound_program_list()
    {
        sound_program = Regex.Replace(sound_program_list, "[ \"\n\r\\[\\]\t]", "").Split(",");
        foreach (var data in sound_program)
        {
            programSound.Items.Add(data);
        }

        // Show the selected input on input list as default
        foreach (var input in sound_program)
            if (currentSoundProgram == input.ToLower())
                programSound.Text = input;
    }



    //
    // get the amplifier status, device info and features
    //
    private async void fetch_info()
    {
        try
        {
            ip_address.Text = config.Config.IP;
            var statusjson = await zoneconfig.getStatus(ZoneConfig.zone.main);
            var deviceinfojson = await systemconfig.getDeviceInfo();
            var featuresjson = await systemconfig.getFeatures();
            var signalinfojson = await zoneconfig.getSignalInfo(ZoneConfig.zone.main);

            var status = JsonNode.Parse(statusjson);
            var deviceinfo = JsonNode.Parse(deviceinfojson);
            var features = JsonNode.Parse(featuresjson);
            var signalinfo = JsonNode.Parse(signalinfojson);
            input_list = Convert.ToString(features["zone"][0]["input_list"]);
            sound_program_list = Convert.ToString(features["zone"][0]["sound_program_list"]);

            // 
            // info fields
            // 
            // power and input on start
            info.Text = $"Power: {(string)status["power"]} Input: {(string)status["input"]} ({(string)status["input_text"]})";

            // device model
            center_text.Text = (string)deviceinfo["model_name"];

            // get the maximum, current volume and startup input source
            maxVol = Convert.ToString(status["max_volume"]);
            curVol = Convert.ToString(status["volume"]);
            currentInput = Convert.ToString(status["input"]);
            currentSoundProgram = Convert.ToString(status["sound_program"]);

            mute = (bool)status["mute"];
            PureDirect = (bool)status["pure_direct"];
            Enhancer = (bool)status["enhancer"];
            ExtraBass = (bool)status["extra_bass"];
            Adaptivedrc = (bool)status["adaptive_drc"];
            curDialLevel = int.Parse(Convert.ToString(status["dialogue_level"]));
            curBass = int.Parse(Convert.ToString(status["subwoofer_volume"]));
            tonetreble = int.Parse(Convert.ToString(status["tone_control"]["treble"]));
            tonebass = int.Parse(Convert.ToString(status["tone_control"]["bass"]));

            PureDirectLabel.Text = $"Pure Direct: {PureDirect}";
            EnhancerLabel.Text = $"Enhancer: {Enhancer}";
            AdaDRCLabel.Text = $"Adaptive drc: {Adaptivedrc}";
            ExtraBassLabel.Text = $"Extra Bass: {ExtraBass}";
            DialLevelLabel.Text = $"Dialogue Level: {curDialLevel}";
            BassLabel.Text = $"Bass Levl: {curBass}";
            ToneTrebleLabel.Text = $"Treble Level: {tonetreble}";
            ToneBassLabel.Text = $"Bass Level: {tonebass}";

            SignalInfoLabel.Text = $"format: {signalinfo["audio"]["format"]}\nfs: {signalinfo["audio"]["fs"]}";


            // volume
            if (mute)
                volume.Text = "muted";
            else
                volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";

            if (inputChange.Items.Count < 1)
            {
                Read_input_list();
            }

            if (programSound.Items.Count < 1)
            {
                Read_sound_program_list();
            }
        }

        catch (Exception ex)
        {
            center_text.Text = "No MusicCast";
        }
        finally
        {
            fetch_info();
        }
    }

    //
    // labels, buttons etc functionality
    //
    private async void power_button_Click(object sender, EventArgs e)
    {
        // power toggle

        var powerToggle = await zoneconfig.setPower(ZoneConfig.zone.main);
    }

    private async void volumedown_button_Click(object sender, EventArgs e)
    {
        // volume -
        if (Convert.ToInt32(curVol) > 0)
        {
            var setVol = Convert.ToInt32(curVol) - 1;

            var incVol = await zoneconfig.setVolume(ZoneConfig.zone.main, setVol);
            curVol = Convert.ToString(setVol);
            mute = false;
            updateVolume();
        }
    }

    private async void volumeup_button_Click(object sender, EventArgs e)
    {
        // volume +
        if (Convert.ToInt32(curVol) < Convert.ToInt32(maxVol))
        {
            var setVol = Convert.ToInt32(curVol) + 1;

            var incVol = await zoneconfig.setVolume(ZoneConfig.zone.main, setVol);
            curVol = Convert.ToString(setVol);
            mute = false;
            updateVolume();
        }
    }

    private async void mute_button_Click(object sender, EventArgs e)
    {
        if (!mute)
        {
            var muteVol = await zoneconfig.setMute(ZoneConfig.zone.main, "true");
            mute = true;
            volume.Text = "muted";
        }
        else
        {
            var muteVol = await zoneconfig.setMute(ZoneConfig.zone.main, "false");
            updateVolume();
            mute = false;
        }
    }

    private async void button2_Click(object sender, EventArgs e)
    {
        // volume -
        if (Convert.ToInt32(curVol) > 0)
        {
            var setVol = Convert.ToInt32(curVol) - 1;

            var incVol = await zoneconfig.setVolume(ZoneConfig.zone.main, setVol);
            curVol = Convert.ToString(setVol);
            updateVolume();
        }
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        // volume +
        if (Convert.ToInt32(curVol) < Convert.ToInt32(maxVol))
        {
            var setVol = Convert.ToInt32(curVol) + 1;

            var incVol = await zoneconfig.setVolume(ZoneConfig.zone.main, setVol);
            curVol = Convert.ToString(setVol);
            updateVolume();
        }
    }

    private async void updateVolume()
    {
        var statusjson = await zoneconfig.getStatus(ZoneConfig.zone.main);
        var status = JsonNode.Parse(statusjson);
        volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";
    }

    private async void inputChange_SelectedIndexChanged(object sender, EventArgs e)
    {
        ActiveControl = null; // prevent focus after selection to make it prettier
      
      
        // check which input is selected, convert it to lowercase in case and switch to it
        var selectedInput = ((string)inputChange.SelectedItem).ToLower();
        if (currentInput != selectedInput)
        {
            await zoneconfig.setInput(ZoneConfig.zone.main,input: selectedInput);
            currentInput = selectedInput;
        }
    }

    private async void programSound_SelectedIndexChanged(object sender, EventArgs e)
    {
        ActiveControl = null;

        var selectedInput = ((string)programSound.SelectedItem).ToLower();
        if (currentSoundProgram != selectedInput)
        {
            await zoneconfig.setSoundProgram(ZoneConfig.zone.main, selectedInput);
            currentSoundProgram = selectedInput;
        }
    }

    private void center_text_Click(object sender, EventArgs e)
    {
        if (center_text.Text != "Not connected")
            MessageBox.Show(
                center_text.Text + "\nList of supported inputs\n" + Regex.Replace(input_list, "[\\[\\]]", "").Replace("\"", "").Replace(",", ""),"Input list");
    }

    private void backgroundUpdate()
    {
        bg = new BackgroundWorker();
        bg.DoWork += (obj, ea) => updateFieldsLoop();
        bg.RunWorkerAsync();
    }

    private async void updateFieldsLoop()
    {
        while (true)
        {
            var statusjson = await zoneconfig.getStatus(ZoneConfig.zone.main);
            var status = JsonNode.Parse(statusjson);
            info.Text = $"Power: {(string)status["power"]} Input: {(string)status["input"]} ({(string)status["input_text"]})";
            if (mute)
                volume.Text = "muted";
            else
                volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";
            Thread.Sleep(1000);
        }
    }

    private void BassUp_Click(object sender, EventArgs e)
    {
        if (curBass >= minBass || curBass <= maxBass)
        {
            curBass = curBass + 1;
            zoneconfig.setSubwooferVolume(ZoneConfig.zone.main, curBass);
        }
    }

    private void BassDown_Click(object sender, EventArgs e)
    {
        if (curBass >= minBass || curBass <= maxBass)
        {
            curBass = curBass - 1;
            zoneconfig.setSubwooferVolume(ZoneConfig.zone.main, curBass);
        }
    }

    private void PureDirectToggle_Click(object sender, EventArgs e)
    {
        if (!PureDirect)
            zoneconfig.setPureDirect(ZoneConfig.zone.main, "true");
        else
            zoneconfig.setPureDirect(ZoneConfig.zone.main, "false");
        PureDirectLabel.Text = $"Pure Direct: {PureDirect}";
    }

    private void EnhancerToggle_Click(object sender, EventArgs e)
    {
        if (!Enhancer)
            zoneconfig.setEnhancer(ZoneConfig.zone.main, "true");
        else
            zoneconfig.setEnhancer(ZoneConfig.zone.main, "false");
        EnhancerLabel.Text = $"Enhancer: {Enhancer}";
    }

    private void AdaptativeDRCToggle_Click(object sender, EventArgs e)
    {
        if (!Adaptivedrc)
            zoneconfig.setAdaptiveDrc(ZoneConfig.zone.main, "true");
        else
            zoneconfig.setAdaptiveDrc(ZoneConfig.zone.main, "false");
        AdaDRCLabel.Text = $"Adaptive drc: {Adaptivedrc}";
    }

    private void ExtreBassToggle_Click(object sender, EventArgs e)
    {
        if (!ExtraBass)
            zoneconfig.setExtraBass(ZoneConfig.zone.main, "true");
        else
            zoneconfig.setExtraBass(ZoneConfig.zone.main, "false");
        ExtraBassLabel.Text = $"Extra Bass: {ExtraBass}";
    }

    private void DiallvlUp_Click(object sender, EventArgs e)
    {
        if (curDialLevel >= minDialLevel || curDialLevel <= maxDialLevel)
        {
            curDialLevel = curDialLevel + 1;
            zoneconfig.setDialogueLevel(ZoneConfig.zone.main, curDialLevel);
        }
    }

    private void DiallvlDown_Click(object sender, EventArgs e)
    {
        if (curDialLevel >= minDialLevel || curDialLevel <= maxDialLevel)
        {
            curDialLevel = curDialLevel - 1;
            zoneconfig.setDialogueLevel(ZoneConfig.zone.main, curDialLevel);
        }
    }

    private void ToneTrebleUp_Click(object sender, EventArgs e)
    {
        if (tonetreble >= tonetreblemin || tonetreble <= tonetreblemax)
        {
            tonetreble = tonetreble + 1;
            zoneconfig.setToneControl(ZoneConfig.zone.main, tonetreble, null);
        }
    }

    private void ToneTrebleDown_Click(object sender, EventArgs e)
    {
        if (tonetreble >= tonetreblemin || tonetreble <= tonetreblemax)
        {
            tonetreble = tonetreble - 1;
            zoneconfig.setToneControl(ZoneConfig.zone.main, tonetreble, null);
        }
    }

    private void ToneBassUp_Click(object sender, EventArgs e)
    {
        if (tonebass >= tonebassmin || tonebass <= tonebassmax)
        {
            tonebass = tonebass + 1;
            zoneconfig.setToneControl(ZoneConfig.zone.main, null, tonebass);
        }
    }

    private void ToneBassDown_Click(object sender, EventArgs e)
    {
        if (tonebass >= tonebassmin || tonebass <= tonebassmax)
        {
            tonebass = tonebass - 1;
            zoneconfig.setToneControl(ZoneConfig.zone.main, null, tonebass);
        }
    }


}