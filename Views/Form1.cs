using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;
using MathNet.Numerics.IntegralTransforms;

using System.Numerics;
using ZedGraph;
using NAudio;
using NAudio.Wave;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Linq.Expressions;
using SmartHome_v1.Models;
//using AForge.Vision.Motion;

namespace SmartHome_v1
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int AuxGetNumDevs(int hMidiIn, int msg, int dw1, int dw2);

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)] 
        private static extern int MciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);
        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hDC, int x, int y);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetSystemTime(ref SYSTEMTIME time);

        Boolean _smartHomePortOpenFlag = false;
        Boolean _rgbTapePortOpenFlag = false;
        Boolean _rgbOffFlag = false;
        Boolean _vlcFlag = false;
        //
        readonly SmartHomeModel _smartHomeModel = new SmartHomeModel();
        readonly RegistryKey _regKey = Registry.CurrentUser.CreateSubKey("Hatabisoft");
        readonly FormPlayer _formVlcPlayer;
        GraphPane myPane;

        int _VlcVolume = VlcConstants.DEFAULT_VOLUME;
        readonly bool[] _rgbStateFlag = new bool[24];
        readonly Color[] _rgbShedulerColorsArray = new Color[24];

        readonly Int16[] _deviceRegister = new Int16[10];
        string _appPath = "d:\\";
        string _sndComName2, _rcvComName2, _sndComName1, _rcvComName1;

        // Audio stream scan variables
        //! Почистить константы! (некоторые возможно ненужны) также при остановке записи надо вызвать waveIn.Dispose( сейчас не так)
        static readonly double _Fs = 42000; // Частота дискретизвции !В данной программе ТОЛЬКО целые числа
        static readonly double _T = 1.0 / _Fs; // Шаг дискретизации
        static int _N; //Длина сигнала (точек)
        static readonly double _Fn = _Fs / 2;// Частота Найквиста
        // WaveIn - поток для записи
        WaveIn _waveIn;
        WaveFileWriter _writer;

        private void SystemEvents_SessionEnded(object sender, SessionEndingEventArgs e)
        {
            //e.Cancel = true;
            SendStringToDevice(RgbConstants.RGB_OFF_STRING, MainConstants.DEV_RGB_TAPE_ID);
        }

        public Form1()
        {
            InitializeComponent();

            ManageCheckGroupBox(CHBOX_UsedGpioForVlcMask, GRBOX_VlcGpioSettings);
            ManageCheckGroupBox(CHBOX_Sheduler, gbSheduler);

            COMBOX_UsbDevicesList.Items.Clear();
            COMBOX_UsbDevicesList.Items.AddRange(SerialPort.GetPortNames());

            _formVlcPlayer = new FormPlayer();
            _formVlcPlayer.MyEvent += this.VlcStatusEvent; // Add event from FormPlayer class
        }

        public void VlcStatusEvent(string text) // Implement event routine... 
        {
            MessageBox.Show($"button clicked ! input data:{text}");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {            
            ScanUsbDevices(); // SCAN My DEVICES
            ScanAudioDevices(cbDevices.SelectedIndex);
            //
            _appPath = Path.GetFullPath(Application.ExecutablePath);
            _appPath = Directory.GetParent(_appPath).FullName + "\\";
            //
            INIManager manager = new INIManager(_appPath + "smarthome.ini");
//            string name = manager.GetPrivateString("PathSettings", "name");
            //
            MTB_LogFilePath.Text = manager.GetPrivateString("PathSettings", "LogFile");
            MTB_PlayListPath.Text = manager.GetPrivateString("PathSettings", "MainPlayList");
            MTB_FavoriteListPath.Text = manager.GetPrivateString("PathSettings", "FavoritePlayList");

            VlcMaskIntToCheckboxes();
            VlcLoadAndFillListBox(MTB_PlayListPath.Text, LISTB_VlcPlaylistURLs, LISTB_VlcPlaylistTitles);
            VlcLoadAndFillListBox(MTB_FavoriteListPath.Text, LISTB_VlcFavoriteURLs, LISTB_VlcFavoriteTitles);

            GetRegistrySettings();

            LISTB_VlcPlaylistURLs.SelectedIndex = LISTB_VlcPlaylistTitles.SelectedIndex;
            LISTB_VlcFavoriteURLs.SelectedIndex = LISTB_VlcFavoriteTitles.SelectedIndex;
            
            TXTBOX_VlcVolume.Value = _VlcVolume;
            RBTN_FavoriteVlcPlayList.Checked = !(RBTN_MainVlcPlayList.Checked);
            GRBOX_VlcGpioSettings.Enabled = CHBOX_UsedGpioForVlcMask.Checked;
            CheckVlcGpioMask();
            if (CHBOX_Ambilight.Checked) TMR_Ambilight.Start();
            if (CHBOX_Sheduler.Checked) CHB_Sheduler_Click(sender, e);
        }

        private void GetRegistrySettings()
        {
            tabControl.SelectedIndex = (int)_regKey.GetValue("TabIndex", 0);
            _smartHomeModel.vlcDevicesMask = (int)_regKey.GetValue("VlcDevicesMaskPin", 0);
            LISTB_VlcPlaylistTitles.SelectedIndex = (int)_regKey.GetValue("PlayListSelected", 0);
            LISTB_VlcFavoriteTitles.SelectedIndex = (int)_regKey.GetValue("FavoriteListSelected", 0);
            RBTN_MainVlcPlayList.Checked = Convert.ToBoolean(_regKey.GetValue("UsedPlayListForIRemore", "True"));
            CHBOX_UsedGpioForVlcMask.Checked = Convert.ToBoolean(_regKey.GetValue("VlcDevicesMaskPinUsing", "False"));
            CHBOX_UseSlaveMonitor.Checked = Convert.ToBoolean(_regKey.GetValue("UseSlaveMonitor", "False"));
            if (Convert.ToBoolean(_regKey.GetValue("VlcStatus", "False"))) VlcPlaySelected(VlcConstants.CURRENT_ITEM);
            CHBOX_RememberChVol.Checked = Convert.ToBoolean(_regKey.GetValue("VlcRememberChannelsVolume", false));
            _VlcVolume = Math.Abs(Convert.ToInt32(_regKey.GetValue("VlcPlayerVolume",VlcConstants.DEFAULT_VOLUME)));

            switch (Convert.ToBoolean(_regKey.GetValue("VlcPlayerMuted", "False")))
            {
                case true:
                    BTN_Mute.ImageIndex = 1;
                    if (_formVlcPlayer!=null && _formVlcPlayer.IsMute != true) _formVlcPlayer.SetMute();
                    break;
                case false:
                    BTN_Mute.ImageIndex = 0;
                    if (_formVlcPlayer != null && _formVlcPlayer.IsMute != false) _formVlcPlayer.SetMute();
                    break;
            }

            COMBOX_RgbSendString.SelectedIndex = (int)_regKey.GetValue("SendStringSelected", 0);
            CHBOX_Ambilight.Checked = Convert.ToBoolean(_regKey.GetValue("UseAmbilight", "False"));
            for (int i = 0; i < 24; i++) SetButtonColors(i, _regKey.GetValue("RgbShedulerHour" + Convert.ToString(i), "FFFF00").ToString());
            CHBOX_Sheduler.Checked = Convert.ToBoolean(_regKey.GetValue("RgbUseSheduler", false));
            COMBOX_HttpMethod.SelectedIndex = Convert.ToByte(_regKey.GetValue("PostManCombo", 0));
            TBOX_HttpMethod.Text = Convert.ToString(_regKey.GetValue("PostManSendTextField", "index.html"));
        }

        private void SaveRegistry()
        {
            _regKey.SetValue("TabIndex", tabControl.SelectedIndex);
            if (_formVlcPlayer != null)
            {
                _regKey.SetValue("VlcStatus", _formVlcPlayer.IsPlaying.ToString());
                _regKey.SetValue("VlcPlayerVolume", _formVlcPlayer.Volume);
                _regKey.SetValue("VlcPlayerMuted", _formVlcPlayer.IsMute);
            }
            _regKey.SetValue("UsedPlayListForIRemore", RBTN_MainVlcPlayList.Checked.ToString());
            _regKey.SetValue("SendStringSelected", COMBOX_RgbSendString.SelectedIndex);
            _regKey.SetValue("VlcDevicesMaskPinUsing", CHBOX_UsedGpioForVlcMask.Checked);
            _regKey.SetValue("UseAmbilight", CHBOX_Ambilight.Checked);
            _regKey.SetValue("VlcDevicesMaskPin", _smartHomeModel.vlcDevicesMask);
            _regKey.SetValue("PlayListSelected", LISTB_VlcPlaylistTitles.SelectedIndex);
            _regKey.SetValue("FavoriteListSelected", LISTB_VlcFavoriteTitles.SelectedIndex);
            _regKey.SetValue("UseSlaveMonitor", CHBOX_UseSlaveMonitor.Checked);
            _regKey.SetValue("VlcRememberChannelsVolume", CHBOX_RememberChVol.Checked);
            _regKey.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CHBOX_UsedGpioForVlcMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_RESET_BITS_GPIO_STATUS, _smartHomeModel.vlcDevicesMask, MainConstants.DEV_SMART_HOME_ID); // Monitor, Subwoofer
            SendStringToDevice(RgbConstants.RGB_OFF_STRING, MainConstants.DEV_RGB_TAPE_ID);

            SaveRegistry();
        }

        public void WriteLog(RichTextBox richTextBox, string str)
        {
//            string temp_str = $"[{DateTime.Now:dd MMMM yyyy | HH:mm:ss}]{str}\n";
//            rtbLogger.AppendText(temp_str);
        }

        public void SendRegToDevice(byte reg_num, int data, byte dev_num)
        {
            String temp_str1 = Utils.IntToHexString(reg_num, 2);
            String temp_str2 = Utils.IntToHexString(data, 4);
            temp_str1 = $"REG:{temp_str1}={temp_str2}";
            SendStringToDevice(temp_str1, dev_num);
        }
        public void SendStringToDevice(String str, byte dev_num)
        {
            switch (dev_num)
            {
                case MainConstants.DEV_SMART_HOME_ID:
                    if (SERIALPORT_SmartHome.IsOpen)
                    {
                        SERIALPORT_SmartHome.WriteLine(str);
                        WriteLog(RTBOX_Logger, _sndComName1 + str);
                    }
                    break;
                case MainConstants.DEV_RGB_TAPE_ID:
                    if (SERIALPORT_RgbTape.IsOpen)
                    {
                        SERIALPORT_RgbTape.WriteLine(str);
                        WriteLog(RTBOX_Logger, _sndComName2 + str);
                    }
                    break;
            }
            System.Threading.Thread.Sleep(MainConstants.PAUSE_FOR_USB_TRANSFER);
        }

        public void SendStringToDeviceBulk(String str, byte dev_num)
        {
            switch (dev_num)
            {
                case MainConstants.DEV_SMART_HOME_ID:
                    if (SERIALPORT_SmartHome.IsOpen)
                    {
                        SERIALPORT_SmartHome.WriteLine(str);
                        if (str != RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING) WriteLog(RTBOX_Logger, _sndComName1 + str);
                    }
                    break;
                case MainConstants.DEV_RGB_TAPE_ID:
                    if (SERIALPORT_RgbTape.IsOpen)
                    {
                        SERIALPORT_RgbTape.WriteLine(str);
                        if (str != RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING) WriteLog(RTBOX_Logger, _sndComName2 + str);
                    }
                    break;
            }
        }

        private void ReadConstantFromSmarthomeDevice() // from 1-st device (SmartHome)
        {
            try
            {
                SendStringToDevice("LOAD_CFG1", MainConstants.DEV_SMART_HOME_ID); // immediate <handshake> if device answer "CONFIG1:"
            }
            catch
            {
                TOOLSTRIP_StatusLabelSmartHome.Text = "FAIL !";
                this.Invoke((MethodInvoker)delegate
                {
                    TOOLSTRIP_StatusLabelSmartHome.ForeColor = Color.Red;
                });
                _smartHomePortOpenFlag = false;
            }
        }

        private void ScanUsbDevices() // SCAN My DEVICES
        {
            int deviceCounter = MainConstants.ZERO;
            WriteLog(RTBOX_Logger, "Scanning all devices on com ports...");
            string[] ports = SerialPort.GetPortNames();

            COMBOX_UsbDevicesList.Items.Clear();
            COMBOX_UsbDevicesList.Items.AddRange(ports);
            // Search for SmartHome device
            if (COMBOX_UsbDevicesList.Items.Count > 0)
            {
                while (deviceCounter < COMBOX_UsbDevicesList.Items.Count)
                {
                    if (SERIALPORT_SmartHome.IsOpen == false) toolStripStatusLabel3.Text = SERIALPORT_SmartHome.PortName = ports[deviceCounter].ToString();
                    try
                    {
                        if (SERIALPORT_SmartHome.IsOpen == false)
                        {
                            SERIALPORT_SmartHome.Open();
                            SendStringToDevice("SMART_HOME", MainConstants.DEV_SMART_HOME_ID);
                            if (_smartHomePortOpenFlag == false) SERIALPORT_SmartHome.Close();
                        }
                    }
                    catch
                    {
                        _smartHomePortOpenFlag = false;
                        TOOLSTRIP_StatusLabelSmartHome.Text = "FAIL !";
                        this.Invoke((MethodInvoker)delegate
                        {
                            TOOLSTRIP_StatusLabelSmartHome.ForeColor = Color.Red;
                        });
                        SERIALPORT_SmartHome.Close();
                    }
                    deviceCounter++;
                }
            }
            // Search for RgbTape device
            deviceCounter = MainConstants.ZERO;
            if (COMBOX_UsbDevicesList.Items.Count > 0)
            {
                while (deviceCounter < COMBOX_UsbDevicesList.Items.Count)
                {
                    if (SERIALPORT_RgbTape.IsOpen == false) toolStripStatusLabel1.Text = SERIALPORT_RgbTape.PortName = ports[deviceCounter].ToString();
                    try
                    {
                        if (SERIALPORT_RgbTape.IsOpen == false)
                        {
                            SERIALPORT_RgbTape.Open();
                            SendStringToDevice("RGB_TAPE", MainConstants.DEV_RGB_TAPE_ID);
                            if (_rgbTapePortOpenFlag == false) SERIALPORT_RgbTape.Close();
                        }
                    }
                    catch
                    {
                        _rgbTapePortOpenFlag = false;
                        tsStatusLabelRgbTape.Text = "FAIL !";
                        SERIALPORT_RgbTape.Close();
                        //                        MessageBox.Show("Can't Open Port !!!");
                    }
                    deviceCounter++;
                }
            }
        }

        private void NUD_Encoder_EncoderValue(object sender, MouseEventArgs e)
        {
            if (sender == NUD_Encoder1) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_ENC1_COUNTER, Convert.ToInt32(Math.Round(NUD_Encoder1.Value, 0)), MainConstants.DEV_SMART_HOME_ID);
            else if (sender == NUD_Encoder0) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_ENC0_COUNTER, Convert.ToInt32(Math.Round(NUD_Encoder0.Value, 0)), MainConstants.DEV_SMART_HOME_ID);

            BTN_SaveCfg.Enabled = true;
        }

        public void ProcessDeviceRegister(int regNumber)
        {
            switch (regNumber)
            {
                case SmartHomeDeviceConstants.REG_CMD_GPIO_STATUS: ProcessGpioStatusRegister(_deviceRegister[regNumber - 1]); break;
                case SmartHomeDeviceConstants.REG_CMD_ENC0_COUNTER: ProcessEncoderRegister(_deviceRegister[regNumber - 1]); break;
                case SmartHomeDeviceConstants.REG_CMD_GET_SENSORS: ProcessSensorRegister(_deviceRegister[regNumber - 1]); break;
            }
        }

        public void ProcessSensorRegister(int reg_data)
        {
            BTN_Sensor0.BackColor = (reg_data & 0x01) == 0x01 ? Color.Red : Color.Black;
            BTN_Sensor1.BackColor = (reg_data & 0x02) == 0x01 ? Color.Red : Color.Black;
            BTN_Sensor2.BackColor = (reg_data & 0x04) == 0x01 ? Color.Red : Color.Black;
            BTN_Sensor3.BackColor = (reg_data & 0x08) == 0x01 ? Color.Red : Color.Black;
            BTN_Sensor4.BackColor = (reg_data & 0x10) == 0x01 ? Color.Red : Color.Black;
            BTN_Sensor5.BackColor = (reg_data & 0x20) == 0x01 ? Color.Red : Color.Black;
            BTN_Sensor6.BackColor = (reg_data & 0x40) == 0x01 ? Color.Red : Color.Black;
            BTN_Sensor7.BackColor = (reg_data & 0x80) == 0x01 ? Color.Red : Color.Black;
        }

        public void ProcessEncoderRegister(int regData)
        {
            NUD_Encoder0.Invoke((MethodInvoker)delegate
            {
                NUD_Encoder0.Value = regData;
            });
        }

        public void ProcessGpioStatusRegister(int regData)
        {
            this.Invoke((MethodInvoker)delegate
            {
                CHBOX_StatusPin7.Checked = ((regData >> 7) & 0x01) == 1;
                CHBOX_StatusPin6.Checked = ((regData >> 6) & 0x01) == 1;
                CHBOX_StatusPin5.Checked = ((regData >> 5) & 0x01) == 1;
                CHBOX_StatusPin4.Checked = ((regData >> 4) & 0x01) == 1;
                CHBOX_StatusPin3.Checked = ((regData >> 3) & 0x01) == 1;
                CHBOX_StatusPin2.Checked = ((regData >> 2) & 0x01) == 1;
                CHBOX_StatusPin1.Checked = ((regData >> 1) & 0x01) == 1;
                CHBOX_StatusPin0.Checked = (regData & 0x01) == 1;
            });
        }

        //
        // Parse incoming CONFIG values and set equalent properties in View objects on Form
        //
        public void ParsingSmartHomeConfigString(string[] words)
        {
            _smartHomeModel.currentDeviceStatus = byte.Parse(words[1], System.Globalization.NumberStyles.HexNumber); // Current tm1638 ports status
            _smartHomeModel.sleepModeMask = byte.Parse(words[2], System.Globalization.NumberStyles.HexNumber); // SleepMode mask
            _smartHomeModel.hotButtonMask = byte.Parse(words[3], System.Globalization.NumberStyles.HexNumber); // Hot button mask
            _smartHomeModel.smartHomeBeepString = byte.Parse(words[7], System.Globalization.NumberStyles.HexNumber); // Beeps settings
            ProcessSensorRegister(byte.Parse(words[8], System.Globalization.NumberStyles.HexNumber));

            this.Invoke((MethodInvoker)delegate
            {
                NUD_Encoder0.Value = int.Parse(words[4], System.Globalization.NumberStyles.HexNumber); // People in room counter / encoder0
                NUD_Encoder1.Value = int.Parse(words[5], System.Globalization.NumberStyles.HexNumber); // People in out room counter / encoder1
                numericUpDownSleepModeTimeout.Value = int.Parse(words[6], System.Globalization.NumberStyles.HexNumber);  // words[3] Timeout for sleep mode

                CHBOX_StatusPin7.Checked = ((_smartHomeModel.currentDeviceStatus >> 7) & 0x01) == 1;
                CHBOX_StatusPin6.Checked = ((_smartHomeModel.currentDeviceStatus >> 6) & 0x01) == 1;
                CHBOX_StatusPin5.Checked = ((_smartHomeModel.currentDeviceStatus >> 5) & 0x01) == 1;
                CHBOX_StatusPin4.Checked = ((_smartHomeModel.currentDeviceStatus >> 4) & 0x01) == 1;
                CHBOX_StatusPin3.Checked = ((_smartHomeModel.currentDeviceStatus >> 3) & 0x01) == 1;
                CHBOX_StatusPin2.Checked = ((_smartHomeModel.currentDeviceStatus >> 2) & 0x01) == 1;
                CHBOX_StatusPin1.Checked = ((_smartHomeModel.currentDeviceStatus >> 1) & 0x01) == 1;
                CHBOX_StatusPin0.Checked = (_smartHomeModel.currentDeviceStatus & 0x01) == 1;
                //
                // SleepMode Mask
                //
                CHBOX_SleepModeMaskPin8.Checked = ((_smartHomeModel.sleepModeMask >> 7) & 0x01) == 1;
                CHBOX_SleepModeMaskPin7.Checked = ((_smartHomeModel.sleepModeMask >> 6) & 0x01) == 1;
                CHBOX_SleepModeMaskPin6.Checked = ((_smartHomeModel.sleepModeMask >> 5) & 0x01) == 1;
                CHBOX_SleepModeMaskPin5.Checked = ((_smartHomeModel.sleepModeMask >> 4) & 0x01) == 1;
                CHBOX_SleepModeMaskPin4.Checked = ((_smartHomeModel.sleepModeMask >> 3) & 0x01) == 1;
                CHBOX_SleepModeMaskPin3.Checked = ((_smartHomeModel.sleepModeMask >> 2) & 0x01) == 1;
                CHBOX_SleepModeMaskPin2.Checked = ((_smartHomeModel.sleepModeMask >> 1) & 0x01) == 1;
                CHBOX_SleepModeMaskPin1.Checked = (_smartHomeModel.sleepModeMask & 0x01) == 1;
                //
                // Hot button mask
                //
                CHBOX_HotButtonMask1.Checked = (_smartHomeModel.hotButtonMask & 0x01) == 0x01 ? true : false;
                CHBOX_HotButtonMask2.Checked = ((_smartHomeModel.smartHomeBeepString & 0x02) >> 1) == 0x01 ? true : false;
                CHBOX_HotButtonMask3.Checked = ((_smartHomeModel.smartHomeBeepString & 0x04) >> 2) == 0x01 ? true : false;
                CHBOX_HotButtonMask4.Checked = ((_smartHomeModel.smartHomeBeepString & 0x08) >> 3) == 0x01 ? true : false;
                CHBOX_HotButtonMask5.Checked = ((_smartHomeModel.smartHomeBeepString & 0x10) >> 4) == 0x01 ? true : false;
                CHBOX_HotButtonMask6.Checked = ((_smartHomeModel.smartHomeBeepString & 0x20) >> 5) == 0x01 ? true : false;
                CHBOX_HotButtonMask7.Checked = ((_smartHomeModel.smartHomeBeepString & 0x40) >> 6) == 0x01 ? true : false;
                CHBOX_HotButtonMask8.Checked = ((_smartHomeModel.smartHomeBeepString & 0x80) >> 7) == 0x01 ? true : false;

                CHBOX_BuzzerBit0.Checked = (_smartHomeModel.smartHomeBeepString & 0x01) == 0x01 ? true : false;
                CHBOX_BuzzerBit1.Checked = ((_smartHomeModel.smartHomeBeepString & 0x02) >> 1) == 0x01 ? true : false;
                CHBOX_BuzzerBit2.Checked = ((_smartHomeModel.smartHomeBeepString & 0x04) >> 2) == 0x01 ? true : false;
                CHBOX_BuzzerBit3.Checked = ((_smartHomeModel.smartHomeBeepString & 0x08) >> 3) == 0x01 ? true : false;
                CHBOX_BuzzerBit4.Checked = ((_smartHomeModel.smartHomeBeepString & 0x10) >> 4) == 0x01 ? true : false;
                CHBOX_BuzzerBit5.Checked = ((_smartHomeModel.smartHomeBeepString & 0x20) >> 5) == 0x01 ? true : false;
                CHBOX_BuzzerBit6.Checked = ((_smartHomeModel.smartHomeBeepString & 0x40) >> 6) == 0x01 ? true : false;
            });
            //
            panelSleepGpio.Invoke((MethodInvoker)delegate { panelSleepGpio.Enabled = true; });
            panelHotGpio.Invoke((MethodInvoker)delegate { panelHotGpio.Enabled = true; });
            panelCurrentGpio.Invoke((MethodInvoker)delegate { panelCurrentGpio.Enabled = true; });
            gbSensorsState.Invoke((MethodInvoker)delegate { gbSensorsState.Enabled = true; });
            gbRegisterValues.Invoke((MethodInvoker)delegate { gbRegisterValues.Enabled = true; });
        }

        private Boolean VlcLoadAndFillListBox(string filePath, ListBox lbUrls, ListBox lbTitles)
        {
            string tempString;
            try
            {
                using (StreamReader stream = File.OpenText(filePath))
                {
                    lbUrls.Items.Clear();
                    lbTitles.Items.Clear();
                    while ((tempString = stream.ReadLine()) != null)
                    {
                        int index = tempString.IndexOf(",");
                        if (index != -1)
                        {
                            String title = tempString.Substring(index, tempString.Length - index);
                            lbTitles.Items.Add(title);
                            if ((tempString = stream.ReadLine()) != null)
                            {
                                index = tempString.IndexOf("http");
                                if (index != -1)
                                {
                                    lbUrls.Items.Add(tempString);
                                    continue;
                                }
                                else
                                {
                                    index = tempString.IndexOf("rtmp");
                                    if (index != -1)
                                    {
                                        lbUrls.Items.Add(tempString);
                                    }
                                    else MessageBox.Show("not found !");
                                }
                            }
                        }
                    }
                }
                return (true);
            }
            catch
            {
                return (false); // MessageBox.Show("Stream Error !\n\n");
            }
        }

        private void ChangeCurrentDeviceStatus(object sender, EventArgs e)
        {
            if (CHBOX_StatusPin0.Checked) _smartHomeModel.currentDeviceStatus |= 0x01; else _smartHomeModel.currentDeviceStatus &= 0xFE;
            if (CHBOX_StatusPin1.Checked) _smartHomeModel.currentDeviceStatus |= 0x02; else _smartHomeModel.currentDeviceStatus &= 0xFD;
            if (CHBOX_StatusPin2.Checked) _smartHomeModel.currentDeviceStatus |= 0x04; else _smartHomeModel.currentDeviceStatus &= 0xFB;
            if (CHBOX_StatusPin3.Checked) _smartHomeModel.currentDeviceStatus |= 0x08; else _smartHomeModel.currentDeviceStatus &= 0xF7;
            if (CHBOX_StatusPin4.Checked) _smartHomeModel.currentDeviceStatus |= 0x10; else _smartHomeModel.currentDeviceStatus &= 0xEF;
            if (CHBOX_StatusPin5.Checked) _smartHomeModel.currentDeviceStatus |= 0x20; else _smartHomeModel.currentDeviceStatus &= 0xDF;
            if (CHBOX_StatusPin6.Checked) _smartHomeModel.currentDeviceStatus |= 0x40; else _smartHomeModel.currentDeviceStatus &= 0xBF;
            if (CHBOX_StatusPin7.Checked) _smartHomeModel.currentDeviceStatus |= 0x80; else _smartHomeModel.currentDeviceStatus &= 0x7F;

            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_GPIO_STATUS, _smartHomeModel.currentDeviceStatus, MainConstants.DEV_SMART_HOME_ID);
        }

        private void CHB_SleepModeMask_Click(object sender, EventArgs e)
        {
            if (CHBOX_SleepModeMaskPin1.Checked) _smartHomeModel.sleepModeMask |= 0x01; else _smartHomeModel.sleepModeMask &= 0xFE;
            if (CHBOX_SleepModeMaskPin2.Checked) _smartHomeModel.sleepModeMask |= 0x02; else _smartHomeModel.sleepModeMask &= 0xFD;
            if (CHBOX_SleepModeMaskPin4.Checked) _smartHomeModel.sleepModeMask |= 0x08; else _smartHomeModel.sleepModeMask &= 0xF7;
            if (CHBOX_SleepModeMaskPin5.Checked) _smartHomeModel.sleepModeMask |= 0x10; else _smartHomeModel.sleepModeMask &= 0xEF;
            if (CHBOX_SleepModeMaskPin6.Checked) _smartHomeModel.sleepModeMask |= 0x20; else _smartHomeModel.sleepModeMask &= 0xDF;
            if (CHBOX_SleepModeMaskPin7.Checked) _smartHomeModel.sleepModeMask |= 0x40; else _smartHomeModel.sleepModeMask &= 0xBF;
            if (CHBOX_SleepModeMaskPin8.Checked) _smartHomeModel.sleepModeMask |= 0x80; else _smartHomeModel.sleepModeMask &= 0x7F;

            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SLEEP_MASK, _smartHomeModel.sleepModeMask, MainConstants.DEV_SMART_HOME_ID); // REG4 - SleepMode mask
            buttonSaveSmartHomeCfg.Enabled = true;
        }

        private void CHB_HotButtonMask_Click(object sender, EventArgs e)
        {
            if (CHBOX_HotButtonMask1.Checked) _smartHomeModel.hotButtonMask |= 0x01; else _smartHomeModel.hotButtonMask &= 0xFE;
            if (CHBOX_HotButtonMask2.Checked) _smartHomeModel.hotButtonMask |= 0x02; else _smartHomeModel.hotButtonMask &= 0xFD;
            if (CHBOX_HotButtonMask3.Checked) _smartHomeModel.hotButtonMask |= 0x04; else _smartHomeModel.hotButtonMask &= 0xFB;
            if (CHBOX_HotButtonMask4.Checked) _smartHomeModel.hotButtonMask |= 0x08; else _smartHomeModel.hotButtonMask &= 0xF7;
            if (CHBOX_HotButtonMask5.Checked) _smartHomeModel.hotButtonMask |= 0x10; else _smartHomeModel.hotButtonMask &= 0xEF;
            if (CHBOX_HotButtonMask6.Checked) _smartHomeModel.hotButtonMask |= 0x20; else _smartHomeModel.hotButtonMask &= 0xDF;
            if (CHBOX_HotButtonMask7.Checked) _smartHomeModel.hotButtonMask |= 0x40; else _smartHomeModel.hotButtonMask &= 0xBF;
            if (CHBOX_HotButtonMask8.Checked) _smartHomeModel.hotButtonMask |= 0x80; else _smartHomeModel.hotButtonMask &= 0x7F;

            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_HOT_BUTTON_MASK, _smartHomeModel.hotButtonMask, MainConstants.DEV_SMART_HOME_ID);
            buttonSaveSmartHomeCfg.Enabled = true;
        }
        //
        // RGB controller events and commands implements
        //
        private void SetRgbTapeBlynkMode(object sender, EventArgs e)
        {
            Int32 value1 = Convert.ToInt32(nudChannelNumber.Value);
            SendStringToDevice($"{value1}.2.{$"{Convert.ToInt32(nudRgbFreq.Value):000}"}", MainConstants.DEV_RGB_TAPE_ID);
        }

        private void NU_RgbFreq_ValueChanged(object sender, EventArgs e)
        {
            SetRgbTapeBlynkMode(sender, e);
        }

        private void BTN_SendRgbCommand(object sender, EventArgs e)
        {
            SendStringToDevice(COMBOX_RgbSendString.Text, MainConstants.DEV_RGB_TAPE_ID);
        }

        private void TRB_Color_Scroll(object sender, EventArgs e)
        {
            Int32 value = Convert.ToInt32(nudChannelNumber.Value);
            SendStringToDevice($"CH{value}:{Utils.IntToHexString(tbRed.Value, 2)}{Utils.IntToHexString(tbGreen.Value, 2)}{Utils.IntToHexString(tbBlue.Value, 2)}", MainConstants.DEV_RGB_TAPE_ID);
        }

        private void NUD_3_ValueChanged(object sender, EventArgs e)
        {
            nudChannelNumber.Enabled = false;
            String a;
            Int32 value1 = Convert.ToInt32(nudChannelNumber.Value);
            Int32 value2 = Convert.ToInt32(nudRgbFreq.Value);

            if (value2 < 100) a = "0"; else a = null;

            SendStringToDevice($"{value1}.1.{a}{value2}", MainConstants.DEV_RGB_TAPE_ID);
            SendStringToDevice($"CH{value1}", MainConstants.DEV_RGB_TAPE_ID);
            nudChannelNumber.Enabled = true;
        }
        //
        // Parsing received data from port 1
        //
        private void SerialPortSmartHomeDevice_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string indata;
            SerialPort sp = (SerialPort)sender;
            
            try {
                indata = sp.ReadExisting();
                WriteLog(RTBOX_Logger, _rcvComName1 + indata);
            if (indata == "SMART_HOME")
            {
                _smartHomePortOpenFlag = true;
                TOOLSTRIP_StatusLabelSmartHome.Text = "SMART_HOME CONNECTED";
                this.Invoke((MethodInvoker)delegate
                {
                    TOOLSTRIP_StatusLabelSmartHome.ForeColor = Color.Green;
                });
                _sndComName1 = SERIALPORT_SmartHome.PortName + MainConstants.SEND_STRING;
                _rcvComName1 = SERIALPORT_SmartHome.PortName + MainConstants.RECEIVE_STRING;
                WriteLog(RTBOX_Logger, "Found: SmartHome device on physical port 1.");
                ReadConstantFromSmarthomeDevice();
            }
            if (_smartHomePortOpenFlag)
            {
                if (indata.IndexOf("CONFIG1:") > -1)
                {
                    string[] words = indata.Split(';');
                    ParsingSmartHomeConfigString(words);
                    if (byte.Parse(words[SmartHomeDeviceConstants.MENS_IN_ROOM_INDEX]) > 1)
                    {
                        SendStringToDevice(RgbConstants.RGB_MORE_MENS_STRING, MainConstants.DEV_RGB_TAPE_ID);
                    }
                }

                if (indata.IndexOf("WREG:") > -1)
                {
                    string[] words = indata.Split(':');
                    words = words[1].Split('=');
                    if (words[0] != null)
                    {
                        _deviceRegister[byte.Parse(words[0]) - 1] = Int16.Parse(words[1], System.Globalization.NumberStyles.HexNumber);
                        ProcessDeviceRegister(byte.Parse(words[0]));
                    }
                }
                if (indata.IndexOf("SLEEP_MODE") > -1) SendStringToDevice(RgbConstants.RGB_SLEEP_MODE_STRING, MainConstants.DEV_RGB_TAPE_ID);
                if (indata.IndexOf("NORMAL_MOD") > -1) SendStringToDevice(RgbConstants.RGB_NORMAL_STATE_STRING, MainConstants.DEV_RGB_TAPE_ID);
                if (indata.IndexOf("REMOTE:") > -1)
                {
                    uint data = uint.Parse(indata.Substring(9, indata.Length - 9), System.Globalization.NumberStyles.HexNumber);  //int.Parse("0xda5ad0b3", System.Globalization.NumberStyles.HexNumber);  // Timeout for sleep mode
                    IR_RemoteExecute(data);
                }
            }
            } catch {
            
            }
        }
        //
        // Parsing received data from port 2
        //
        private void SerialPortRgbTapeDevice_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            WriteLog(RTBOX_Logger, _rcvComName2 + indata);
            if (indata == "RGB_TAPE")
            {
                _rgbTapePortOpenFlag = true;
                this.Invoke((MethodInvoker)delegate
                {
                    tsStatusLabelRgbTape.ForeColor = Color.Green;
                });
                tsStatusLabelRgbTape.Text = "RGB_TAPE CONNECTED";
                _sndComName2 = SERIALPORT_RgbTape.PortName + MainConstants.SEND_STRING;
                _rcvComName2 = SERIALPORT_RgbTape.PortName + MainConstants.RECEIVE_STRING;

                this.panel5.Invoke((MethodInvoker)delegate
                {
                    panel5.Enabled = true;
                });
                WriteLog(RTBOX_Logger, "Found: RGB_Tape device on physical port 2.");
                WriteLog(RTBOX_Logger, "Scanning family devices on com ports complete...\n---\nWork started.");

                SendStringToDevice(RgbConstants.RGB_NORMAL_STATE_STRING,MainConstants.DEV_RGB_TAPE_ID);

//                this.labelUseAmbilight.Invoke((MethodInvoker)delegate
//                {
                    lblUseAmbilight.Enabled = true;
//                });
//                this.checkBoxAmbilight.Invoke((MethodInvoker)delegate
//                {
                    CHBOX_Ambilight.Enabled = true;
//                });
            }
            if (_rgbTapePortOpenFlag)
            {
                if ((indata.Substring(0, 2) == "CH") & (indata.Substring(3, 1) == ":"))
                {
                    this.tbRed.Invoke((MethodInvoker)delegate
                    {
                        tbRed.Value = int.Parse(indata.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    });
                    this.tbGreen.Invoke((MethodInvoker)delegate
                    {
                        tbGreen.Value = int.Parse(indata.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                    });
                    this.tbBlue.Invoke((MethodInvoker)delegate
                    {
                        tbBlue.Value = int.Parse(indata.Substring(8, 2), System.Globalization.NumberStyles.HexNumber);
                    });

                    //ProcessConfigRgbTapeValues(words);
                }
            }
        }

        private void BTN_SaveRgbCfg_Click(object sender, EventArgs e)
        {
            SendStringToDevice("SAVE_CFG",MainConstants.DEV_RGB_TAPE_ID);
        }

        private void RTB_Logger_TextChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                RTBOX_Logger.SelectionStart = RTBOX_Logger.Text.Length;
                RTBOX_Logger.ScrollToCaret(); // scroll it automatically
            }
        }

        private void ScanAudioDevices(int selectedIndex)
        {
            MMDeviceEnumerator deviceEnum = new MMDeviceEnumerator();
            cbDevices.DataSource = deviceEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToList();
            cbRenderDevices.DataSource = deviceEnum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToList();

            foreach (MMDevice device in deviceEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.All))
            {
                Console.WriteLine("{0}, {1}", device.FriendlyName, device.State);
            }

        }

        private void VLC_events(object sender, EventArgs e)
        {
            _formVlcPlayer.Stop();// .playlist.play();
        }


        void IR_RemoteExecute(uint data)
        {
            switch (data)
            {
                case IRemoteConstants.TR_MUSIC:
                    break;
                case IRemoteConstants.TR_MUTE:
                    BTN_Mute_Click(new object(), new EventArgs());
                    break;
                case IRemoteConstants.TR_MODE:
                    RBTN_FavoriteVlcPlayList.Invoke((MethodInvoker)delegate
                    {
                        if (RBTN_MainVlcPlayList.Checked) RBTN_FavoriteVlcPlayList.Checked = true; else RBTN_MainVlcPlayList.Checked = true;
                    });
                    VlcPlaySelected(VlcConstants.CURRENT_ITEM);
                    break;
                case IRemoteConstants.TR_PHOTO:
                    if (_rgbOffFlag == false)
                    {
                        SendStringToDevice(RgbConstants.RGB_OFF_STRING, MainConstants.DEV_RGB_TAPE_ID);
                        _rgbOffFlag = true;
                    }
                    else
                    {
                        SendStringToDevice(RgbConstants.RGB_NORMAL_STATE_STRING, MainConstants.DEV_RGB_TAPE_ID);
                        _rgbOffFlag = false;
                    }
                    break;
                case IRemoteConstants.TR_PAUSE_PLAY:
                    VlcPlaySelected(VlcConstants.CURRENT_ITEM);
                    break;
                case IRemoteConstants.TR_POWER_OFF:
                    SendStringToDevice(RgbConstants.RGB_OFF_STRING, MainConstants.DEV_RGB_TAPE_ID);
                    SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_GPIO_STATUS, MainConstants.ZERO, MainConstants.DEV_SMART_HOME_ID);
                    Process.Start("shutdown", "/h /f");
                    break;
                case IRemoteConstants.TR_STOP:
                    if (CHBOX_UsedGpioForVlcMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_RESET_BITS_GPIO_STATUS, _smartHomeModel.vlcDevicesMask, MainConstants.DEV_SMART_HOME_ID);
                    _formVlcPlayer.Stop();
                    break;
                case IRemoteConstants.TR_VOL_UP:
                    VlcChangeVolumeIrRemote(VlcConstants.ADD);
                    break;
                case IRemoteConstants.TR_VOL_DOWN:
                    VlcChangeVolumeIrRemote(VlcConstants.DEC);
                    break;
                case IRemoteConstants.TR_PREV:
                    VlcPlaySelected(VlcConstants.PREVIOUS_ITEM);
                    break;

                case IRemoteConstants.TR_NEXT:
                    VlcPlaySelected(VlcConstants.NEXT_ITEM);
                    break;
            }
        }

        private void VlcPlaySelected(int direction) // direction used for IR remote (next, prev)
        {
            ListBox lbUrls;
            ListBox lbTitles;
            Form1 mainForm = new Form1();

            if (!CHBOX_UseSlaveMonitor.Checked)
            {
                _formVlcPlayer.SetPoint(new Point(Convert.ToInt32(mainForm.Location.X + mainForm.Size.Width), Convert.ToInt32(mainForm.Location.Y)));
                if (CHBOX_UsedGpioForVlcMask.Checked)
                {
                    SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SET_BITS_GPIO_STATUS, _smartHomeModel.vlcDevicesMask & (~VlcConstants.VLC_MONITOR_MASK),MainConstants.DEV_SMART_HOME_ID); // switch ON. only Subwoofer
                }
            }
            else
            {
                _formVlcPlayer.SetPoint(new Point(Convert.ToInt32(VlcConstants.VLC_LOCATION_X_SLAVE_MONITOR), Convert.ToInt32(mainForm.Location.Y)));
                if (CHBOX_UsedGpioForVlcMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SET_BITS_GPIO_STATUS, _smartHomeModel.vlcDevicesMask, MainConstants.DEV_SMART_HOME_ID); // switch ON. Monitor only
            }

            if (RBTN_MainVlcPlayList.Checked)
            {
                lbUrls = LISTB_VlcPlaylistURLs;
                lbTitles = LISTB_VlcPlaylistTitles;
            }
            else
            {
                lbUrls = LISTB_VlcFavoriteURLs;
                lbTitles = LISTB_VlcFavoriteTitles;
            }

            if (lbUrls.SelectedIndex == -1) lbUrls.SelectedIndex = 0;

            if (direction < 0)
            {
                if (lbUrls.SelectedIndex > 0) lbUrls.SelectedIndex--; else lbUrls.SelectedIndex = lbUrls.Items.Count - 1;
            }
            else if (direction > 0)
                if (lbUrls.SelectedIndex < lbUrls.Items.Count - 1) lbUrls.SelectedIndex++;
                else lbUrls.SelectedIndex = 0;

            lbTitles.SelectedIndex = lbUrls.SelectedIndex;

            string str = RBTN_MainVlcPlayList.Checked
                ? "VlcMainPlaylist_CH" + LISTB_VlcPlaylistTitles.SelectedIndex
                : "VlcFavoritePlaylist_CH" + LISTB_VlcFavoriteTitles.SelectedIndex;
            
            _VlcVolume = CHBOX_RememberChVol.Checked ? Convert.ToByte(_regKey.GetValue(str, VlcConstants.DEFAULT_VOLUME)) : VlcConstants.DEFAULT_VOLUME;

            _formVlcPlayer.Show();
            _formVlcPlayer.SetListBox = lbUrls;
            _formVlcPlayer.Play();
            TXTBOX_VlcVolume.Value = _VlcVolume;
            _formVlcPlayer.SetVolume(_VlcVolume);
        }

        private void VlcChangeVolumeIrRemote(int a)
        {

            _VlcVolume = (byte)_formVlcPlayer.Volume;

            switch (a)
            {
                case VlcConstants.ADD:
                    if (_VlcVolume < 255) _VlcVolume++;
                    break;
                case VlcConstants.DEC:
                    if (_VlcVolume > 0) _VlcVolume--;
                    break;
            }

            if (RBTN_MainVlcPlayList.Checked)
            {
                _regKey.SetValue($"VlcMainPlaylist_CH{Convert.ToString(LISTB_VlcPlaylistTitles.SelectedIndex)}", _VlcVolume);
            }
            TXTBOX_VlcVolume.Value = _VlcVolume;
        }

        private void BTN_RescanDevices_Click(object sender, EventArgs e)
        {
            ScanUsbDevices();
        }

        private void LBOX_VlcPlayList_Click(object sender, EventArgs e)
        {
            LISTB_VlcPlaylistURLs.SelectedIndex = LISTB_VlcPlaylistTitles.SelectedIndex;
            RBTN_MainVlcPlayList.Checked = true;
        }

        private void LBOX_VlcFavoriteList_Click(object sender, EventArgs e)
        {
            LISTB_VlcFavoriteURLs.SelectedIndex = LISTB_VlcFavoriteTitles.SelectedIndex;
            RBTN_FavoriteVlcPlayList.Checked = true;
        }

        private void BTN_DeleteFromPlaylist_Click(object sender, EventArgs e)
        {
            if (LISTB_VlcPlaylistTitles.SelectedIndex != -1)
            {
                int index = LISTB_VlcPlaylistTitles.SelectedIndex;
                LISTB_VlcPlaylistTitles.Items.RemoveAt(LISTB_VlcPlaylistTitles.SelectedIndex);
                LISTB_VlcPlaylistURLs.SelectedIndex = index;
                LISTB_VlcPlaylistURLs.Items.RemoveAt(LISTB_VlcPlaylistURLs.SelectedIndex);
            }
            else MessageBox.Show("Must select item !");
        }

        private void BTN_OpenVlcPlayListDialog_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                VlcLoadAndFillListBox(openFileDialog1.FileName, LISTB_VlcPlaylistURLs, LISTB_VlcPlaylistTitles);
            }
        }

        private void SaveVlcPlayList(string filename, ListBox lbTitles, ListBox lbUrls)
        {
            System.IO.File.Delete(filename);
            try
            {
                using StreamWriter sr = new StreamWriter(filename, true, System.Text.Encoding.UTF8);
                sr.WriteLine("#EXTM3U https://hdbox.ws");
                int lbIndex = 0;

                while (lbIndex < lbTitles.Items.Count)
                {
                    sr.WriteLine(lbTitles.Items[lbIndex]);
                    sr.WriteLine(lbUrls.Items[lbIndex]);
                    lbIndex++;
                }
            }
            catch
            {
                MessageBox.Show("exception !\n\n");
            }
        }

        private void BTN_SendDataToDevice_Click(object sender, EventArgs e)
        {
            SendStringToDevice(tbDataToSend.Text, MainConstants.DEV_SMART_HOME_ID);
        }

        private void LBOX_VlcPlaylistTitles_MouseDown(object sender, MouseEventArgs e)
        {
            tsMenuItem.Enabled = true;
        }

        private void ContextMenuStripPlaylist_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ListBox lbPlaylistItems = new ListBox();
            ListBox lbPlaylistUrls = new ListBox();
            string playlistUrls = "";

            this.Text = ((ListBox)((ContextMenuStrip)sender).SourceControl).Name.ToString() + e.ClickedItem.Text;

            switch (((ListBox)((ContextMenuStrip)sender).SourceControl).Name.ToString())
            {
                case VlcConstants.OBJECT_NAME_PLAYLIST:
                    lbPlaylistItems = LISTB_VlcPlaylistTitles;
                    lbPlaylistUrls = LISTB_VlcPlaylistURLs;
                    playlistUrls = MTB_PlayListPath.Text;
                    break;
                case VlcConstants.OBJECT_NAME_FAVORITES:
                    lbPlaylistItems = LISTB_VlcFavoriteTitles;
                    lbPlaylistUrls = LISTB_VlcFavoriteURLs;
                    playlistUrls = MTB_FavoriteListPath.Text;
                    break;
            }

            switch (e.ClickedItem.Text)
            {
                case VlcConstants.ACTION_DELETE:
                    if (lbPlaylistItems.SelectedIndex != -1)
                    {
                        int index = lbPlaylistItems.SelectedIndex;
                        lbPlaylistItems.Items.RemoveAt(lbPlaylistItems.SelectedIndex);
                        lbPlaylistUrls.SelectedIndex = index;
                        lbPlaylistUrls.Items.RemoveAt(lbPlaylistUrls.SelectedIndex);
                        SaveVlcPlayList(playlistUrls, lbPlaylistItems, lbPlaylistUrls);
                    }
                    else MessageBox.Show("Must select item !");
                    break;
                case VlcConstants.ACTION_SAVE:
                    SaveVlcPlayList(playlistUrls, lbPlaylistItems, lbPlaylistUrls);
                    break;
                case VlcConstants.ACTION_ADD_FAV:
                    LISTB_VlcFavoriteTitles.Items.Add(lbPlaylistItems.Items[lbPlaylistItems.SelectedIndex]);
                    LISTB_VlcFavoriteURLs.Items.Add(lbPlaylistUrls.Items[lbPlaylistItems.SelectedIndex]);
                    break;
            }
        }

        private void BTN_LogFilePath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "log files | *.log";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MTB_LogFilePath.Text = saveFileDialog1.FileName;
                BTN_SaveCfg.Enabled = true;
            }
        }

        private void BTN_VlcPlayListPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "m3u files | *.m3u";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MTB_PlayListPath.Text = openFileDialog1.FileName;
                BTN_SaveCfg.Enabled = true;
            }
        }

        private void BTN_VlcFavoriteListPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "m3u files | *.m3u";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MTB_FavoriteListPath.Text = openFileDialog1.FileName;
                BTN_SaveCfg.Enabled = true;
            }
        }

        private void BTN_SaveCfg_Click_1(object sender, EventArgs e)
        {
            INIManager manager = new INIManager(_appPath + "smarthome.ini");

            BTN_SaveCfg.Enabled = false;
            manager.WritePrivateString("PathSettings", "LogFile", MTB_LogFilePath.Text);
            manager.WritePrivateString("PathSettings", "MainPlayList", MTB_PlayListPath.Text);
            manager.WritePrivateString("PathSettings", "FavoritePlayList", MTB_FavoriteListPath.Text);
        }

        private void BTN_VlcStop_Click(object sender, EventArgs e)
        {
            if (CHBOX_UsedGpioForVlcMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_RESET_BITS_GPIO_STATUS, _smartHomeModel.vlcDevicesMask, MainConstants.DEV_SMART_HOME_ID); // Monitor, Subwoofer
            _formVlcPlayer.Stop();
            _formVlcPlayer.Hide();
        }

        private void LBOX_VlcPlaylistTitles_DoubleClick(object sender, EventArgs e)
        {
            RBTN_MainVlcPlayList.Checked = true;
            VlcPlaySelected(VlcConstants.CURRENT_ITEM);
        }

        private void LBOX_VlcFavoriteTitles_DoubleClick(object sender, EventArgs e)
        {
            RBTN_FavoriteVlcPlayList.Checked = true;
            VlcPlaySelected(VlcConstants.CURRENT_ITEM);
        }

        private void GetAndSendColor()
        {
            if (GetCursorPos(out POINT p))
            {
                lblPixel.Text = $"{Convert.ToString(p.X)};{Convert.ToString(p.Y)}";
                IntPtr hDC = GetDC(IntPtr.Zero);
                p.X = MainConstants.AMBILIGHT_X;
                p.Y = MainConstants.AMBILIGHT_Y;
                uint pixel = GetPixel(hDC, p.X, p.Y);
                
                ReleaseDC(IntPtr.Zero, hDC);
                
                byte r = (byte)(pixel & 0x000000FF);
                byte g = (byte)((pixel & 0x0000FF00) >> 8);
                byte b = (byte)((pixel & 0x00FF0000) >> 16);
                
                SendStringToDevice($"EFFECT_CONFIG:01.1.1.1.{r:X2}.{g:X2}.{b:X2}.00.00", MainConstants.DEV_RGB_TAPE_ID);
                
                lblRED.Text = r.ToString();
                lblGREEN.Text = g.ToString();
                lblBLUE.Text = b.ToString();
            }
        }

        private uint DominateColor()
        {
            uint color;
            uint pixel;

            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            int canvasX = resolution.Width;
            int canvasY = resolution.Height;
            uint summaR = 0 , summaG = 0, summaB = 0;
            int x = 0, y = 0;
            //            POINT p;
            IntPtr hDC = GetDC(IntPtr.Zero);
            for (x = canvasX - 50; x < canvasX; x++)
            {
                for (y = canvasY - 100; y < canvasY; y++)
                {
                    pixel = GetPixel(hDC, x, y);
                    summaR += (byte)(pixel & 0x000000FF);
                    summaG += (byte)((pixel & 0x0000FF00) >> 8);
                    summaB += (byte)((pixel & 0x0000FF00) >> 16);
                }
            }
            ReleaseDC(IntPtr.Zero, hDC);
            labelX.Text = x.ToString();
            labelY.Text = y.ToString();
            summaR /= 5000;
            summaG /= 5000;
            summaB /= 5000;
            color = (summaB << 16) | summaG << 8 | summaR;

            return (color);
        }

        private void BTN18_Click(object sender, EventArgs e)
        {
            DominateColor();
            //GetAndSendColor();
        }

        private void BTN_Mute_Click(object sender, EventArgs e)
        {
            BTN_Mute.ImageIndex = BTN_Mute.ImageIndex != 0 ? 0 : 1;
            if (_formVlcPlayer !=null) _formVlcPlayer.SetMute();
        }

        private void TMR_Ambilight_Tick(object sender, EventArgs e)
        {
            GetAndSendColor();
        }

        private void CHB_Ambilight_Click(object sender, EventArgs e)
        {
            if (CHBOX_Ambilight.Checked)
            {
                TMR_Ambilight.Start();

            }
            else
            {
                TMR_Ambilight.Stop();

            }
            BTN_SaveCfg.Enabled = true;
        }

        private void ManageCheckGroupBox(CheckBox chk, GroupBox grp)
        {
            // Make sure the CheckBox isn't in the GroupBox.
            // This will only happen the first time.
            if (chk.Parent == grp)
            {
                // Reparent the CheckBox so it's not in the GroupBox.
                grp.Parent.Controls.Add(chk);

                // Adjust the CheckBox's location.
                chk.Location = new Point(
                    chk.Left + grp.Left,
                    chk.Top + grp.Top);

                // Move the CheckBox to the top of the stacking order.
                chk.BringToFront();
            }

            // Enable or disable the GroupBox.
            grp.Enabled = chk.Checked;
        }

        private void CHB_VlcGpioMask_Click(object sender, EventArgs e)
        {
            GRBOX_VlcGpioSettings.Enabled = CHBOX_UsedGpioForVlcMask.Checked;
            CheckVlcGpioMask();
        }

        public void CheckVlcGpioMask()
        {
            CHBOX_UsedGpioForVlcMask.ForeColor = GRBOX_VlcGpioSettings.Enabled ? SystemColors.ControlText : SystemColors.ControlDark;
        }

        private void BTN_PlayPause_Click(object sender, EventArgs e)
        {
            buttonPlayPause.ImageIndex = _vlcFlag == true ? 1 : 2;
        }

        private void VlcMaskPinsToInt(object sender, EventArgs e)
        {
            if (cbVlcMaskPin0.Checked) _smartHomeModel.vlcDevicesMask |= 0x01; else _smartHomeModel.vlcDevicesMask &= 0xFE;
            if (cbVlcMaskPin1.Checked) _smartHomeModel.vlcDevicesMask |= 0x02; else _smartHomeModel.vlcDevicesMask &= 0xFD;
            if (cbVlcMaskPin2.Checked) _smartHomeModel.vlcDevicesMask |= 0x04; else _smartHomeModel.vlcDevicesMask &= 0xFB;
            if (cbVlcMaskPin3.Checked) _smartHomeModel.vlcDevicesMask |= 0x08; else _smartHomeModel.vlcDevicesMask &= 0xF7;
            if (cbVlcMaskPin4.Checked) _smartHomeModel.vlcDevicesMask |= 0x10; else _smartHomeModel.vlcDevicesMask &= 0xEF;
            if (cbVlcMaskPin5.Checked) _smartHomeModel.vlcDevicesMask |= 0x12; else _smartHomeModel.vlcDevicesMask &= 0xDF;
            if (cbVlcMaskPin6.Checked) _smartHomeModel.vlcDevicesMask |= 0x14; else _smartHomeModel.vlcDevicesMask &= 0xBF;
            if (cbVlcMaskPin7.Checked) _smartHomeModel.vlcDevicesMask |= 0x18; else _smartHomeModel.vlcDevicesMask &= 0x7F;
        }

        private void VlcMaskIntToCheckboxes()
        {
            if ((_smartHomeModel.vlcDevicesMask & 0x01) == 0x01) cbVlcMaskPin0.Checked = true;
            if ((_smartHomeModel.vlcDevicesMask & 0x02) == 0x02) cbVlcMaskPin1.Checked = true;
            if ((_smartHomeModel.vlcDevicesMask & 0x04) == 0x04) cbVlcMaskPin2.Checked = true;
            if ((_smartHomeModel.vlcDevicesMask & 0x08) == 0x08) cbVlcMaskPin3.Checked = true;
            if ((_smartHomeModel.vlcDevicesMask & 0x10) == 0x10) cbVlcMaskPin4.Checked = true;
            if ((_smartHomeModel.vlcDevicesMask & 0x20) == 0x20) cbVlcMaskPin5.Checked = true;
            if ((_smartHomeModel.vlcDevicesMask & 0x40) == 0x40) cbVlcMaskPin6.Checked = true;
            if ((_smartHomeModel.vlcDevicesMask & 0x80) == 0x80) cbVlcMaskPin7.Checked = true;
        }

        private void TRBAR_VlcVolume_ValueChanged(object sender, EventArgs e)
        {
            String str;

            _VlcVolume = (byte)TXTBOX_VlcVolume.Value;
            if (_formVlcPlayer!=null) _formVlcPlayer.SetVolume(_VlcVolume);

            if (CHBOX_RememberChVol.Checked)
            {
                str = RBTN_MainVlcPlayList.Checked ? $"VlcMainPlaylist_CH{LISTB_VlcPlaylistTitles.SelectedIndex}" : $"VlcFavoritePlaylist_CH{LISTB_VlcFavoriteTitles.SelectedIndex}";
            }
            else
            {
                str = "VlcPlayerVolume";
            }
            SendStringToDeviceBulk(RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING, MainConstants.DEV_RGB_TAPE_ID); // команда эффект для RGB контроллера (описание в /doc)
            System.Threading.Thread.Sleep(1);

            _regKey.SetValue(str, _VlcVolume);
        }

        private void CHB_UseSlaveMonitor_Click(object sender, EventArgs e)
        {
            //buttonSaveCfg.Enabled = true;
            if (_formVlcPlayer!=null && _formVlcPlayer.IsPlaying) VlcPlaySelected(VlcConstants.CURRENT_ITEM);
            //buttonSaveCfg_Click_1(sender, e);
        }

        private void BTN_StartAudioStreamScan_Click(object sender, EventArgs e)
        {
            SendStringToDevice("0.1.000", MainConstants.DEV_RGB_TAPE_ID);
            btnStopRecord.Enabled = true;
            btnStartAudioStreamScan.Enabled = false;

            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                Console.WriteLine("Device {0}: {1}, {2} channels", waveInDevice, deviceInfo.ProductName, deviceInfo.Channels);
            }

            try
            {
                _waveIn = new WaveIn
                {
                    DeviceNumber = cbRenderDevices.SelectedIndex + 1 // Дефолтное устройство для записи (если оно имеется)
                };
                _waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(WaveIn_DataAvailable); // Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                _waveIn.RecordingStopped += new EventHandler<StoppedEventArgs>(WaveIn_RecordingStopped); // Прикрепляем обработчик завершения записи
                string outputFilename = "D:/demo.wav";
                _waveIn.WaveFormat = new WaveFormat(44100, 1);
                _writer = new WaveFileWriter(outputFilename, _waveIn.WaveFormat);
                _waveIn.StartRecording(); //Инициализируем объект WaveFileWriter, начало записи
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            // эта часть не нужна программа узнает о прочитаном звуке с помощью событий.
        }

        //Окончание записи
        private void WaveIn_RecordingStopped(object sender, EventArgs e)
        {
            btnStopRecord.Enabled = false;
            btnStartAudioStreamScan.Enabled = true;
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler(WaveIn_RecordingStopped), sender, e);
            }
            else
            {
                _waveIn.StopRecording();
            }
            _waveIn.Dispose();
            _waveIn = null;
            _writer.Close();
            _writer = null;
        }

        void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(WaveIn_DataAvailable), sender, e);
            }
            else
            {
                //данные из буфера распределяем в массив чтобы в нем они были в формате ?PCM?
                byte[] buffer = e.Buffer;
                _N = buffer.Length;
                int bytesRecorded = e.BytesRecorded;
                Complex[] sig = new Complex[bytesRecorded / 2];
                for (int i = 0, j = 0; i < e.BytesRecorded; i += 2, j++)
                {
                    short sample = (short)((buffer[i + 1] << 8) | buffer[i + 0]);
                    sig[j] = sample / 32768f;
                }
                //Transform.FourierForward(sig, FourierOptions.Matlab);
                // обнуляем спектр на небольших частотах (там постоянная составляющая и вообще много помех)
                for (int i = 0; i < 35 * sig.Length / _Fn; i++)
                {
                    sig[i] = 0;
                }
                CreateGraph(zedGraphControl1,sig);
            }
        }

                // Build the Chart
        private void CreateGraph(ZedGraphControl zgc, Complex[] sig)
        {
            // get a reference to the GraphPane
            myPane = zgc.GraphPane;
            myPane.CurveList.Clear();
            PointPairList list1 = new PointPairList();
            double K = sig.Length/2;

            for (int i = 0; i < K; i++)
            {
                list1.Add(i*_Fn/K, Complex.Abs(sig[i])/_N*2);
            }

            lblLowMax.Visible = lblMiddleMax.Visible = lblHighMax.Visible = false;

            int value1 = GetCalculateValueFromComplexValues((int)nudLowFreq.Value);
            if (value1 > 255)
            {
                value1 = 255;
                lblLowMax.Visible = true;
            }
            pbLowFreq.Value = value1;

            int value2 = GetCalculateValueFromComplexValues((int)nudMiddleFreq.Value );
            if (value2 > 255)
            {
                value2 = 255;
                lblMiddleMax.Visible = true;
            }
            pbMiddleFreq.Value = value2;

            int value3 = GetCalculateValueFromComplexValues((int)nudHighFreq.Value);
            if (value3 > 255)
            {
                value3 = 255;
                lblHighMax.Visible = true;
            }
            pbHighFreq.Value = value3;

            SendStringToDevice($"CH0:{value1:X2}{value2:X2}{value3:X2}", MainConstants.DEV_RGB_TAPE_ID);

            myPane.Title.Text = "Амплитудный спектр звука";
            myPane.XAxis.Title.Text = "Частота, Гц";
            myPane.YAxis.Title.Text = "";

            // Обновляем изображение и оси
            zgc.AxisChange();
            zgc.Invalidate();

            int GetCalculateValueFromComplexValues(int check_freq)
            {
                const int FREQ_ARRAY_LENGTH = 50;
                Int32 summ = 0;
                Complex c;
                //check_freq /= 100;
                for (int i = (int)((check_freq - FREQ_ARRAY_LENGTH) * sig.Length / _Fn); i < (int)((check_freq + FREQ_ARRAY_LENGTH) * sig.Length / _Fn); i++)
                {
                    c = Complex.Abs((sig[i] / _N * 2) * 10000000); // list1.Add(i*Fn/K, Complex.Abs(sig[i])/N*2);
                    summ += (int)c.Real;
                }
                summ /= FREQ_ARRAY_LENGTH;
                if (summ > 255) summ = 255;
                return ((int)summ);
            }
        }


        private void CB_HttpMethod_SelectedValueChanged(object sender, EventArgs e)
        {
            SendStringToDeviceBulk(RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING, MainConstants.DEV_RGB_TAPE_ID); // команда эффект для RGB контроллера (описание в /doc)
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            VlcPlaySelected(VlcConstants.CURRENT_ITEM);
        }

        private void CHB_FullScreen_Click(object sender, EventArgs e)
        {
            _formVlcPlayer.FullScreen = checkBoxFullScreen.Checked;
            _regKey.SetValue("VlcFullScreen", checkBoxFullScreen.Checked);
            if (_formVlcPlayer.IsPlaying) VlcPlaySelected(VlcConstants.CURRENT_ITEM);
        }

        private void CHB_Sheduler_Click(object sender, EventArgs e)
        {
            gbSheduler.Enabled = CHBOX_Sheduler.Checked;
            _regKey.SetValue("RgbUseSheduler", CHBOX_Sheduler.Checked);
            timerRgbSheduler.Enabled = gbSheduler.Enabled;

            if (!TMR_Ambilight.Enabled) timerRgbSheduler.Start();
        }

        private void BTN_Color_Click(object sender, EventArgs e)
        {
            int hour = 0;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (sender == BTN_Color00) hour = 0;
                if (sender == BTN_Color01) hour = 1;
                if (sender == BTN_Color02) hour = 2;
                if (sender == BTN_Color03) hour = 3;
                if (sender == BTN_Color04) hour = 4;
                if (sender == BTN_Color05) hour = 5;
                if (sender == BTN_Color06) hour = 6;
                if (sender == BTN_Color07) hour = 7;
                if (sender == BTN_Color08) hour = 8;
                if (sender == BTN_Color09) hour = 9;
                if (sender == BTN_Color10) hour = 10;
                if (sender == BTN_Color11) hour = 11;
                if (sender == BTN_Color12) hour = 12;
                if (sender == BTN_Color13) hour = 13;
                if (sender == BTN_Color14) hour = 14;
                if (sender == BTN_Color15) hour = 15;
                if (sender == BTN_Color16) hour = 16;
                if (sender == BTN_Color17) hour = 17;
                if (sender == BTN_Color18) hour = 18;
                if (sender == BTN_Color19) hour = 19;
                if (sender == BTN_Color20) hour = 20;
                if (sender == BTN_Color21) hour = 21;
                if (sender == btnColor22) hour = 22;
                if (sender == btnColor23) hour = 23;
            }
            Button button = (Button)sender;
            button.BackColor = colorDialog1.Color;
            _rgbShedulerColorsArray[hour] = colorDialog1.Color;
            _rgbStateFlag[hour] = false;

            _regKey.SetValue($"RgbShedulerHour{Convert.ToString(hour)}", $"{colorDialog1.Color.R:X2}{colorDialog1.Color.G:X2}{colorDialog1.Color.B:X2}");
        }

        private void TMR_RgbSheduler_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            if (!_rgbStateFlag[hour])
            {
                SendStringToDevice($"EFFECT_CONFIG:01.1.1.1.{_rgbShedulerColorsArray[hour].R:X2}.{_rgbShedulerColorsArray[hour].G:X2}.{_rgbShedulerColorsArray[hour].B:X2}.70.00", 
                    MainConstants.DEV_RGB_TAPE_ID);

                _rgbStateFlag[hour] = true;
                if (hour > 0) _rgbStateFlag[hour - 1] = false;
                else if (hour == 0) _rgbStateFlag[23] = false;
            }
        }

        private void SetButtonColors(int button_num, string color_string)
        {
            byte red = byte.Parse(color_string.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte green = byte.Parse(color_string.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte blue = byte.Parse(color_string.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            _rgbShedulerColorsArray[button_num] = Color.FromArgb(255, red, green, blue);

            switch (button_num)
            {
                case 0: BTN_Color00.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 1: BTN_Color01.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 2: BTN_Color02.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 3: BTN_Color03.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 4: BTN_Color04.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 5: BTN_Color05.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 6: BTN_Color06.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 7: BTN_Color07.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 8: BTN_Color08.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 9: BTN_Color09.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 10: BTN_Color10.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 11: BTN_Color11.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 12: BTN_Color12.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 13: BTN_Color13.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 14: BTN_Color14.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 15: BTN_Color15.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 16: BTN_Color16.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 17: BTN_Color17.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 18: BTN_Color18.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 19: BTN_Color19.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 20: BTN_Color20.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 21: BTN_Color21.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 22: btnColor22.BackColor = _rgbShedulerColorsArray[button_num]; break;
                case 23: btnColor23.BackColor = _rgbShedulerColorsArray[button_num]; break;
            }
        }

        private void CHB_RememberChVol_Click(object sender, EventArgs e)
        {
            BTN_SaveCfg_Click_1(sender, e);
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            buttonSaveSmartHomeCfg.Enabled = false;
            try
            {
                SendStringToDevice("SAVE_CFG1", MainConstants.DEV_SMART_HOME_ID);
            }
            catch
            {
                RTBOX_Logger.Text = "COMx\n";
                tsStatusLabelRgbTape.Text = "FAIL !";
                _smartHomePortOpenFlag = false;
            }
        }

        private void CHB_BuzzerBits_Click(object sender, EventArgs e)
        {
            if (CHBOX_BuzzerBit0.Checked) _smartHomeModel.smartHomeBeepString |= 0x01; else _smartHomeModel.smartHomeBeepString &= 0xFE; // enc0
            if (CHBOX_BuzzerBit1.Checked) _smartHomeModel.smartHomeBeepString |= 0x02; else _smartHomeModel.smartHomeBeepString &= 0xFD; // enc1
            if (CHBOX_BuzzerBit2.Checked) _smartHomeModel.smartHomeBeepString |= 0x04; else _smartHomeModel.smartHomeBeepString &= 0xFB; // keyboard
            if (CHBOX_BuzzerBit3.Checked) _smartHomeModel.smartHomeBeepString |= 0x08; else _smartHomeModel.smartHomeBeepString &= 0xF7; // remote
            if (CHBOX_BuzzerBit4.Checked) _smartHomeModel.smartHomeBeepString |= 0x10; else _smartHomeModel.smartHomeBeepString &= 0xEF; // uart in
            if (CHBOX_BuzzerBit5.Checked) _smartHomeModel.smartHomeBeepString |= 0x20; else _smartHomeModel.smartHomeBeepString &= 0xDF; // usb in
            if (CHBOX_BuzzerBit6.Checked) _smartHomeModel.smartHomeBeepString |= 0x40; else _smartHomeModel.smartHomeBeepString &= 0xBF; // use door sensor
            buttonSaveSmartHomeCfg.Enabled = true;
            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SET_FLAGS, _smartHomeModel.smartHomeBeepString, MainConstants.DEV_SMART_HOME_ID);
        }

        private void BTN_StopRecord_Click(object sender, EventArgs e)
        {
            _waveIn.StopRecording();
        }
    }
}