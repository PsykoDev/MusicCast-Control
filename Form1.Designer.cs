

namespace MusicCast_Control
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.power_button = new System.Windows.Forms.Button();
            this.cypyright = new System.Windows.Forms.Label();
            this.inputChange = new System.Windows.Forms.ComboBox();
            this.info = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.center_text = new System.Windows.Forms.Label();
            this.ip_address = new System.Windows.Forms.Label();
            this.mute_button = new System.Windows.Forms.Button();
            this.volumedown_button = new System.Windows.Forms.Button();
            this.volumeup_button = new System.Windows.Forms.Button();
            this.BassLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExtreBassToggle = new System.Windows.Forms.Button();
            this.AdaptativeDRCToggle = new System.Windows.Forms.Button();
            this.EnhancerToggle = new System.Windows.Forms.Button();
            this.PureDirectToggle = new System.Windows.Forms.Button();
            this.PureDirectLabel = new System.Windows.Forms.Label();
            this.EnhancerLabel = new System.Windows.Forms.Label();
            this.AdaDRCLabel = new System.Windows.Forms.Label();
            this.ExtraBassLabel = new System.Windows.Forms.Label();
            this.SignalInfoLabel = new System.Windows.Forms.Label();
            this.DiallvlDown = new System.Windows.Forms.Button();
            this.DiallvlUp = new System.Windows.Forms.Button();
            this.DialLevelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToneBassDown = new System.Windows.Forms.Button();
            this.ToneBassUp = new System.Windows.Forms.Button();
            this.ToneBassLabel = new System.Windows.Forms.Label();
            this.ToneTrebleDown = new System.Windows.Forms.Button();
            this.ToneTrebleUp = new System.Windows.Forms.Button();
            this.ToneTrebleLabel = new System.Windows.Forms.Label();
            this.programSound = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // power_button
            // 
            this.power_button.AutoSize = true;
            this.power_button.BackgroundImage = global::MusicCast_Control.Properties.Resources.power;
            this.power_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.power_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.power_button.ForeColor = System.Drawing.Color.Fuchsia;
            this.power_button.Location = new System.Drawing.Point(326, -1);
            this.power_button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.power_button.Name = "power_button";
            this.power_button.Size = new System.Drawing.Size(32, 24);
            this.power_button.TabIndex = 6;
            this.power_button.UseVisualStyleBackColor = true;
            this.power_button.Click += new System.EventHandler(this.power_button_Click);
            // 
            // cypyright
            // 
            this.cypyright.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cypyright.Location = new System.Drawing.Point(201, 389);
            this.cypyright.Margin = new System.Windows.Forms.Padding(0);
            this.cypyright.Name = "cypyright";
            this.cypyright.Size = new System.Drawing.Size(159, 13);
            this.cypyright.TabIndex = 7;
            this.cypyright.Text = "MusicCast Control 0.0.3";
            this.cypyright.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // inputChange
            // 
            this.inputChange.BackColor = System.Drawing.Color.Black;
            this.inputChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputChange.ForeColor = System.Drawing.Color.White;
            this.inputChange.FormattingEnabled = true;
            this.inputChange.Location = new System.Drawing.Point(42, 88);
            this.inputChange.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputChange.Name = "inputChange";
            this.inputChange.Size = new System.Drawing.Size(132, 23);
            this.inputChange.TabIndex = 11;
            this.inputChange.SelectedIndexChanged += new System.EventHandler(this.inputChange_SelectedIndexChanged);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(-2, -1);
            this.info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.info.MinimumSize = new System.Drawing.Size(59, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(111, 13);
            this.info.TabIndex = 12;
            this.info.Text = "Power: na; Input: na";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.volume.Location = new System.Drawing.Point(149, 62);
            this.volume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.volume.MinimumSize = new System.Drawing.Size(62, 0);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(62, 19);
            this.volume.TabIndex = 14;
            this.volume.Text = "--.- dB";
            this.volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // center_text
            // 
            this.center_text.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.center_text.Location = new System.Drawing.Point(80, 27);
            this.center_text.Name = "center_text";
            this.center_text.Size = new System.Drawing.Size(200, 29);
            this.center_text.TabIndex = 15;
            this.center_text.Text = "Connecting";
            this.center_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.center_text.Click += new System.EventHandler(this.center_text_Click);
            // 
            // ip_address
            // 
            this.ip_address.AutoSize = true;
            this.ip_address.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ip_address.Location = new System.Drawing.Point(5, 389);
            this.ip_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(40, 13);
            this.ip_address.TabIndex = 17;
            this.ip_address.Text = "0.0.0.0";
            // 
            // mute_button
            // 
            this.mute_button.AutoSize = true;
            this.mute_button.BackgroundImage = global::MusicCast_Control.Properties.Resources.volmute;
            this.mute_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mute_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mute_button.ForeColor = System.Drawing.Color.Red;
            this.mute_button.Location = new System.Drawing.Point(298, 1);
            this.mute_button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mute_button.Name = "mute_button";
            this.mute_button.Size = new System.Drawing.Size(28, 21);
            this.mute_button.TabIndex = 18;
            this.mute_button.UseVisualStyleBackColor = true;
            this.mute_button.Click += new System.EventHandler(this.mute_button_Click);
            // 
            // volumedown_button
            // 
            this.volumedown_button.AutoSize = true;
            this.volumedown_button.BackgroundImage = global::MusicCast_Control.Properties.Resources.voldown;
            this.volumedown_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumedown_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volumedown_button.ForeColor = System.Drawing.Color.Green;
            this.volumedown_button.Location = new System.Drawing.Point(114, 61);
            this.volumedown_button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.volumedown_button.Name = "volumedown_button";
            this.volumedown_button.Size = new System.Drawing.Size(28, 21);
            this.volumedown_button.TabIndex = 19;
            this.volumedown_button.UseVisualStyleBackColor = true;
            this.volumedown_button.Click += new System.EventHandler(this.volumedown_button_Click);
            // 
            // volumeup_button
            // 
            this.volumeup_button.AutoSize = true;
            this.volumeup_button.BackgroundImage = global::MusicCast_Control.Properties.Resources.volup;
            this.volumeup_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeup_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volumeup_button.ForeColor = System.Drawing.Color.LawnGreen;
            this.volumeup_button.Location = new System.Drawing.Point(218, 61);
            this.volumeup_button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.volumeup_button.Name = "volumeup_button";
            this.volumeup_button.Size = new System.Drawing.Size(28, 21);
            this.volumeup_button.TabIndex = 20;
            this.volumeup_button.UseVisualStyleBackColor = true;
            this.volumeup_button.Click += new System.EventHandler(this.volumeup_button_Click);
            // 
            // BassLabel
            // 
            this.BassLabel.AutoSize = true;
            this.BassLabel.Location = new System.Drawing.Point(75, 256);
            this.BassLabel.Name = "BassLabel";
            this.BassLabel.Size = new System.Drawing.Size(60, 15);
            this.BassLabel.TabIndex = 21;
            this.BassLabel.Text = "Bass Level";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = global::MusicCast_Control.Properties.Resources.volup;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(42, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 21);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BassUp_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = global::MusicCast_Control.Properties.Resources.voldown;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(5, 253);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 21);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BassDown_Click);
            // 
            // ExtreBassToggle
            // 
            this.ExtreBassToggle.BackgroundImage = global::MusicCast_Control.Properties.Resources.power;
            this.ExtreBassToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExtreBassToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExtreBassToggle.Location = new System.Drawing.Point(1, 214);
            this.ExtreBassToggle.Name = "ExtreBassToggle";
            this.ExtreBassToggle.Size = new System.Drawing.Size(25, 25);
            this.ExtreBassToggle.TabIndex = 26;
            this.ExtreBassToggle.UseVisualStyleBackColor = true;
            this.ExtreBassToggle.Click += new System.EventHandler(this.ExtreBassToggle_Click);
            // 
            // AdaptativeDRCToggle
            // 
            this.AdaptativeDRCToggle.BackgroundImage = global::MusicCast_Control.Properties.Resources.power;
            this.AdaptativeDRCToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdaptativeDRCToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdaptativeDRCToggle.Location = new System.Drawing.Point(1, 183);
            this.AdaptativeDRCToggle.Name = "AdaptativeDRCToggle";
            this.AdaptativeDRCToggle.Size = new System.Drawing.Size(25, 25);
            this.AdaptativeDRCToggle.TabIndex = 27;
            this.AdaptativeDRCToggle.UseVisualStyleBackColor = true;
            this.AdaptativeDRCToggle.Click += new System.EventHandler(this.AdaptativeDRCToggle_Click);
            // 
            // EnhancerToggle
            // 
            this.EnhancerToggle.BackgroundImage = global::MusicCast_Control.Properties.Resources.power;
            this.EnhancerToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnhancerToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnhancerToggle.Location = new System.Drawing.Point(1, 152);
            this.EnhancerToggle.Name = "EnhancerToggle";
            this.EnhancerToggle.Size = new System.Drawing.Size(25, 25);
            this.EnhancerToggle.TabIndex = 28;
            this.EnhancerToggle.UseVisualStyleBackColor = true;
            this.EnhancerToggle.Click += new System.EventHandler(this.EnhancerToggle_Click);
            // 
            // PureDirectToggle
            // 
            this.PureDirectToggle.BackgroundImage = global::MusicCast_Control.Properties.Resources.power;
            this.PureDirectToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PureDirectToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PureDirectToggle.Location = new System.Drawing.Point(1, 121);
            this.PureDirectToggle.Name = "PureDirectToggle";
            this.PureDirectToggle.Size = new System.Drawing.Size(25, 25);
            this.PureDirectToggle.TabIndex = 29;
            this.PureDirectToggle.UseVisualStyleBackColor = true;
            this.PureDirectToggle.Click += new System.EventHandler(this.PureDirectToggle_Click);
            // 
            // PureDirectLabel
            // 
            this.PureDirectLabel.AutoSize = true;
            this.PureDirectLabel.Location = new System.Drawing.Point(71, 126);
            this.PureDirectLabel.Name = "PureDirectLabel";
            this.PureDirectLabel.Size = new System.Drawing.Size(38, 15);
            this.PureDirectLabel.TabIndex = 30;
            this.PureDirectLabel.Text = "label1";
            // 
            // EnhancerLabel
            // 
            this.EnhancerLabel.AutoSize = true;
            this.EnhancerLabel.Location = new System.Drawing.Point(71, 157);
            this.EnhancerLabel.Name = "EnhancerLabel";
            this.EnhancerLabel.Size = new System.Drawing.Size(38, 15);
            this.EnhancerLabel.TabIndex = 31;
            this.EnhancerLabel.Text = "label2";
            // 
            // AdaDRCLabel
            // 
            this.AdaDRCLabel.AutoSize = true;
            this.AdaDRCLabel.Location = new System.Drawing.Point(70, 188);
            this.AdaDRCLabel.Name = "AdaDRCLabel";
            this.AdaDRCLabel.Size = new System.Drawing.Size(38, 15);
            this.AdaDRCLabel.TabIndex = 32;
            this.AdaDRCLabel.Text = "label3";
            // 
            // ExtraBassLabel
            // 
            this.ExtraBassLabel.AutoSize = true;
            this.ExtraBassLabel.Location = new System.Drawing.Point(70, 219);
            this.ExtraBassLabel.Name = "ExtraBassLabel";
            this.ExtraBassLabel.Size = new System.Drawing.Size(38, 15);
            this.ExtraBassLabel.TabIndex = 33;
            this.ExtraBassLabel.Text = "label4";
            // 
            // SignalInfoLabel
            // 
            this.SignalInfoLabel.Location = new System.Drawing.Point(190, 331);
            this.SignalInfoLabel.Name = "SignalInfoLabel";
            this.SignalInfoLabel.Size = new System.Drawing.Size(179, 56);
            this.SignalInfoLabel.TabIndex = 34;
            // 
            // DiallvlDown
            // 
            this.DiallvlDown.AutoSize = true;
            this.DiallvlDown.BackgroundImage = global::MusicCast_Control.Properties.Resources.voldown;
            this.DiallvlDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DiallvlDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DiallvlDown.ForeColor = System.Drawing.Color.Green;
            this.DiallvlDown.Location = new System.Drawing.Point(5, 280);
            this.DiallvlDown.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DiallvlDown.Name = "DiallvlDown";
            this.DiallvlDown.Size = new System.Drawing.Size(28, 21);
            this.DiallvlDown.TabIndex = 37;
            this.DiallvlDown.UseVisualStyleBackColor = true;
            this.DiallvlDown.Click += new System.EventHandler(this.DiallvlDown_Click);
            // 
            // DiallvlUp
            // 
            this.DiallvlUp.AutoSize = true;
            this.DiallvlUp.BackgroundImage = global::MusicCast_Control.Properties.Resources.volup;
            this.DiallvlUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DiallvlUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DiallvlUp.ForeColor = System.Drawing.Color.LawnGreen;
            this.DiallvlUp.Location = new System.Drawing.Point(42, 280);
            this.DiallvlUp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DiallvlUp.Name = "DiallvlUp";
            this.DiallvlUp.Size = new System.Drawing.Size(28, 21);
            this.DiallvlUp.TabIndex = 36;
            this.DiallvlUp.UseVisualStyleBackColor = true;
            this.DiallvlUp.Click += new System.EventHandler(this.DiallvlUp_Click);
            // 
            // DialLevelLabel
            // 
            this.DialLevelLabel.AutoSize = true;
            this.DialLevelLabel.Location = new System.Drawing.Point(75, 283);
            this.DialLevelLabel.Name = "DialLevelLabel";
            this.DialLevelLabel.Size = new System.Drawing.Size(84, 15);
            this.DialLevelLabel.TabIndex = 35;
            this.DialLevelLabel.Text = "Dialogue Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tone Control";
            // 
            // ToneBassDown
            // 
            this.ToneBassDown.AutoSize = true;
            this.ToneBassDown.BackgroundImage = global::MusicCast_Control.Properties.Resources.voldown;
            this.ToneBassDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToneBassDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToneBassDown.ForeColor = System.Drawing.Color.Green;
            this.ToneBassDown.Location = new System.Drawing.Point(10, 355);
            this.ToneBassDown.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ToneBassDown.Name = "ToneBassDown";
            this.ToneBassDown.Size = new System.Drawing.Size(28, 21);
            this.ToneBassDown.TabIndex = 44;
            this.ToneBassDown.UseVisualStyleBackColor = true;
            this.ToneBassDown.Click += new System.EventHandler(this.ToneBassDown_Click);
            // 
            // ToneBassUp
            // 
            this.ToneBassUp.AutoSize = true;
            this.ToneBassUp.BackgroundImage = global::MusicCast_Control.Properties.Resources.volup;
            this.ToneBassUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToneBassUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToneBassUp.ForeColor = System.Drawing.Color.LawnGreen;
            this.ToneBassUp.Location = new System.Drawing.Point(47, 355);
            this.ToneBassUp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ToneBassUp.Name = "ToneBassUp";
            this.ToneBassUp.Size = new System.Drawing.Size(28, 21);
            this.ToneBassUp.TabIndex = 43;
            this.ToneBassUp.UseVisualStyleBackColor = true;
            this.ToneBassUp.Click += new System.EventHandler(this.ToneBassUp_Click);
            // 
            // ToneBassLabel
            // 
            this.ToneBassLabel.AutoSize = true;
            this.ToneBassLabel.Location = new System.Drawing.Point(80, 358);
            this.ToneBassLabel.Name = "ToneBassLabel";
            this.ToneBassLabel.Size = new System.Drawing.Size(61, 15);
            this.ToneBassLabel.TabIndex = 42;
            this.ToneBassLabel.Text = "Tone Bass:";
            // 
            // ToneTrebleDown
            // 
            this.ToneTrebleDown.AutoSize = true;
            this.ToneTrebleDown.BackgroundImage = global::MusicCast_Control.Properties.Resources.voldown;
            this.ToneTrebleDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToneTrebleDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToneTrebleDown.ForeColor = System.Drawing.Color.Green;
            this.ToneTrebleDown.Location = new System.Drawing.Point(10, 328);
            this.ToneTrebleDown.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ToneTrebleDown.Name = "ToneTrebleDown";
            this.ToneTrebleDown.Size = new System.Drawing.Size(28, 21);
            this.ToneTrebleDown.TabIndex = 41;
            this.ToneTrebleDown.UseVisualStyleBackColor = true;
            this.ToneTrebleDown.Click += new System.EventHandler(this.ToneTrebleDown_Click);
            // 
            // ToneTrebleUp
            // 
            this.ToneTrebleUp.AutoSize = true;
            this.ToneTrebleUp.BackgroundImage = global::MusicCast_Control.Properties.Resources.volup;
            this.ToneTrebleUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToneTrebleUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToneTrebleUp.ForeColor = System.Drawing.Color.LawnGreen;
            this.ToneTrebleUp.Location = new System.Drawing.Point(47, 328);
            this.ToneTrebleUp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ToneTrebleUp.Name = "ToneTrebleUp";
            this.ToneTrebleUp.Size = new System.Drawing.Size(28, 21);
            this.ToneTrebleUp.TabIndex = 40;
            this.ToneTrebleUp.UseVisualStyleBackColor = true;
            this.ToneTrebleUp.Click += new System.EventHandler(this.ToneTrebleUp_Click);
            // 
            // ToneTrebleLabel
            // 
            this.ToneTrebleLabel.AutoSize = true;
            this.ToneTrebleLabel.Location = new System.Drawing.Point(80, 331);
            this.ToneTrebleLabel.Name = "ToneTrebleLabel";
            this.ToneTrebleLabel.Size = new System.Drawing.Size(69, 15);
            this.ToneTrebleLabel.TabIndex = 39;
            this.ToneTrebleLabel.Text = "Tone Treble:";
            // 
            // programSound
            // 
            this.programSound.BackColor = System.Drawing.Color.Black;
            this.programSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programSound.ForeColor = System.Drawing.Color.White;
            this.programSound.FormattingEnabled = true;
            this.programSound.Location = new System.Drawing.Point(178, 88);
            this.programSound.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.programSound.Name = "programSound";
            this.programSound.Size = new System.Drawing.Size(132, 23);
            this.programSound.TabIndex = 45;
            this.programSound.SelectedIndexChanged += new System.EventHandler(this.programSound_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 402);
            this.Controls.Add(this.programSound);
            this.Controls.Add(this.ToneBassDown);
            this.Controls.Add(this.ToneBassUp);
            this.Controls.Add(this.ToneBassLabel);
            this.Controls.Add(this.ToneTrebleDown);
            this.Controls.Add(this.ToneTrebleUp);
            this.Controls.Add(this.ToneTrebleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiallvlDown);
            this.Controls.Add(this.DiallvlUp);
            this.Controls.Add(this.DialLevelLabel);
            this.Controls.Add(this.SignalInfoLabel);
            this.Controls.Add(this.ExtraBassLabel);
            this.Controls.Add(this.AdaDRCLabel);
            this.Controls.Add(this.EnhancerLabel);
            this.Controls.Add(this.PureDirectLabel);
            this.Controls.Add(this.PureDirectToggle);
            this.Controls.Add(this.EnhancerToggle);
            this.Controls.Add(this.AdaptativeDRCToggle);
            this.Controls.Add(this.ExtreBassToggle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BassLabel);
            this.Controls.Add(this.volumeup_button);
            this.Controls.Add(this.volumedown_button);
            this.Controls.Add(this.mute_button);
            this.Controls.Add(this.ip_address);
            this.Controls.Add(this.center_text);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.info);
            this.Controls.Add(this.inputChange);
            this.Controls.Add(this.cypyright);
            this.Controls.Add(this.power_button);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MusicCast Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private Button power_button;
        private Label info;
        private string maxVol;
        private string curVol;
        private Label cypyright;
        private string mcip;
        private ComboBox inputChange;
        private Label volume;
        private string currentInput;
        private string currentSoundProgram;
        private Label center_text;
        private string input_list;
        private string sound_program_list;
        private Label ip_address;
        private Button mute_button;
        private bool mute;
        private Button volumedown_button;
        private Button volumeup_button;
        private Label BassLabel;
        private Button button1;
        private Button button2;
        private Button ExtreBassToggle;
        private Button AdaptativeDRCToggle;
        private Button EnhancerToggle;
        private Button PureDirectToggle;
        private bool PureDirect;
        private bool Enhancer;
        private bool ExtraBass;
        private bool Adaptivedrc;
        // extra bass level
        private int maxBass = 12;
        private int minBass = -12;
        private int curBass;
        //dial level
        private int maxDialLevel = 3;
        private int minDialLevel = 0;
        private int curDialLevel;
        // Tone level
        private int tonetreblemax = 12;
        private int tonetreblemin = -12;
        private int tonetreble;
        private int tonebassmax = 12;
        private int tonebassmin = -12;
        private int tonebass;
        private Label PureDirectLabel;
        private Label EnhancerLabel;
        private Label AdaDRCLabel;
        private Label ExtraBassLabel;
        private Label SignalInfoLabel;
        private Button DiallvlDown;
        private Button DiallvlUp;
        private Label DialLevelLabel;
        private Label label1;
        private Button ToneBassDown;
        private Button ToneBassUp;
        private Label ToneBassLabel;
        private Button ToneTrebleDown;
        private Button ToneTrebleUp;
        private Label ToneTrebleLabel;
        private ComboBox programSound;
    }
}