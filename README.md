# MusicCast Control

A simple Windows GUI to control your Yamaha MusicCast amplifier.<br />
Should work with all MusicCast devices with API support enabled.<br />
![image](https://user-images.githubusercontent.com/45910905/205984903-d89765c6-66ce-4fb8-9556-02839adbd232.png)



## Features

* Power
* Volume
* Mute
* Customize inputs
* Customize Sound Program
* Pure direct toggle
* Enhancer toggle
* Adaptive DRC toggle
* Extra Bass toggle
* Bass Level 
* Dialogue Level
* Tone Control Treble + Bass 

## Usage

Set your amplifier's IP address and wanted input devices to Config.json.<br />
You can get a list of your amplifier's supported inputs by clicking the model name.<br />

Complete input device list:<br />
> **cd / tuner / multi_ch / phono / hdmi1 / hdmi2 / hdmi3 / hdmi4 / hdmi5 / hdmi6 / hdmi7 /**<br />
> **hdmi8 / hdmi / av1 / av2 / av3 / av4 / av5 / av6 / av7 / v_aux / aux1 / aux2 / aux / audio1 /**<br />
> **audio2 / audio3 / audio4 / audio_cd / audio / optical1 / optical2 / optical / coaxial1 / coaxial2 /**<br />
> **coaxial / digital1 / digital2 / digital / line1 / line2 / line3 / line_cd / analog / tv / bd_dvd /**<br />
> **usb_dac / usb / bluetooth / server / net_radio / rhapsody / napster / pandora / siriusxm /**<br />
> **spotify / juke / airplay / radiko / qobuz / mc_link / main_sync / none**

Note that you can use capitalized letters when adding devices.

Complete Sound Program list:<br />
> **munich / vienna / chamber / cellar_club / roxy_theatre / bottom_line / sports / action_game / roleplaying_game /**<br />
> **music_video / standard / spectacle / sci-fi / adventure / drama / mono_movie / 2ch_stereo / all_ch_stereo /**<br />
> **surr_decoder / straight /**<br />

## TODO

The plan is to add some of the additional controls that the official mobile application has. Including subwoofer,
balance and playback control.
