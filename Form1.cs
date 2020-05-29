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
        public static extern int auxGetNumDevs(int hMidiIn, int msg, int dw1, int dw2);

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)] 
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

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

        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetSystemTime(ref SYSTEMTIME time);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public static implicit operator System.Drawing.Point(POINT p)
            {
                return new System.Drawing.Point(p.X, p.Y);
            }

            public static implicit operator POINT(System.Drawing.Point p)
            {
                return new POINT(p.X, p.Y);
            }
        }

        //
        static public Bitmap bmp;
        //
        //
        Boolean flag_smarthome_port_open = false;
        Boolean flag_rgbtape_port_open = false;
        Boolean flag_rgb_off = false;
        //
        SmartHomeModel smartHomeModel = new SmartHomeModel();

        int flag_vlc_play = 0;
        byte vlc_volume = VlcConstants.DEFAULT_VOLUME;
        bool[] flag_rgb_state = new bool[24];
        Color[] rgb_sheduler_colors_array = new Color[24];
        //
        //
        Int16[] device_register = new Int16[10];
        string app_path = "d:\\";
        string SndComName2, RcvComName2, SndComName1, RcvComName1, SndComName3, RcvComName3;
        //
        //
        RegistryKey currentUserKey = Registry.CurrentUser;
        RegistryKey RegKey;
        FormPlayer form_player;
        GraphPane myPane;
        //
        //
        // Audio stream scan variables
        //
        //! Почистить константы! (некоторые возможно ненужны) также при остановке записи надо вызвать waveIn.Dispose( сейчас не так)
        static readonly double Fs = 42000; // Частота дискретизвции !В данной программе ТОЛЬКО целые числа
        static readonly double T = 1.0 / Fs; // Шаг дискретизации
        static int N; //Длина сигнала (точек)
        static readonly double Fn = Fs / 2;// Частота Найквиста

        // WaveIn - поток для записи
        WaveIn waveIn;
        WaveFileWriter writer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (form_player == null) form_player = new FormPlayer();
            
            ManageCheckGroupBox(checkBoxVlcGpioMask, grbHostSettings);
            ManageCheckGroupBox(checkBoxSheduler, groupBoxSheduler);
            RegKey = currentUserKey.CreateSubKey("Hatabisoft");

            comboBoxUsbDevicesList.Items.Clear();
            comboBoxUsbDevicesList.Items.AddRange(SerialPort.GetPortNames());
            tabControl.SelectedIndex = (int)RegKey.GetValue("TabIndex", 0);
            scanUsbDevices(); // SCAN My DEVICES
            scanAudioDevices(comboBoxDevices.SelectedIndex);
            //
            app_path = Path.GetFullPath(Application.ExecutablePath);
            app_path = Directory.GetParent(app_path).FullName + "\\";
            //
            INIManager manager = new INIManager(app_path + "smarthome.ini");
            string name = manager.GetPrivateString("PathSettings", "name");
            //
            maskedTextBoxLogFilePath.Text = manager.GetPrivateString("PathSettings", "LogFile");
            maskedTextBoxPlayListPath.Text = manager.GetPrivateString("PathSettings", "MainPlayList");
            maskedTextBoxFavoriteListPath.Text = manager.GetPrivateString("PathSettings", "FavoritePlayList");
            //
            // VLC tabPage
            //
            smartHomeModel.vlc_devices_mask = (int)RegKey.GetValue("VlcDevicesMaskPin", 0);
            VlcMaskIntToCheckboxes();
            //
            VlcLoadAndFillListBox(maskedTextBoxPlayListPath.Text, listBoxVlcPlaylistURLs, listBoxVlcPlaylistTitles);
            listBoxVlcPlaylistTitles.SelectedIndex = (int)RegKey.GetValue("PlayListSelected", 0);
            listBoxVlcPlaylistURLs.SelectedIndex = listBoxVlcPlaylistTitles.SelectedIndex;
            //
            VlcLoadAndFillListBox(maskedTextBoxFavoriteListPath.Text, listBoxVlcFavoriteURLs, listBoxVlcFavoriteTitles);
            listBoxVlcFavoriteTitles.SelectedIndex = (int)RegKey.GetValue("FavoriteListSelected", 0);
            listBoxVlcFavoriteURLs.SelectedIndex = listBoxVlcFavoriteTitles.SelectedIndex;
            //
            radioButtonMainVlcPlayList.Checked = Convert.ToBoolean(RegKey.GetValue("UsedPlayListForIRemore", "True"));
            radioButtonFavoriteVlcPlayList.Checked = !(radioButtonMainVlcPlayList.Checked);
            //
            checkBoxVlcGpioMask.Checked = Convert.ToBoolean(RegKey.GetValue("VlcDevicesMaskPinUsing", "False"));
            grbHostSettings.Enabled = checkBoxVlcGpioMask.Checked;
            checkVlcGpioMask();
            //
            checkBoxUseSlaveMonitor.Checked = Convert.ToBoolean(RegKey.GetValue("UseSlaveMonitor", "False"));
            if (Convert.ToBoolean(RegKey.GetValue("VlcStatus", "False"))) VlcPlaySelected(VlcConstants.CURRENT_ITEM);

            checkBoxRememberChVol.Checked = Convert.ToBoolean(RegKey.GetValue("VlcRememberChannelsVolume", false));
            vlc_volume = Convert.ToByte(RegKey.GetValue("VlcPlayerVolume", VlcConstants.DEFAULT_VOLUME));
            trackBarVlcVolume.Value = vlc_volume;
            //
            switch (Convert.ToBoolean(RegKey.GetValue("VlcPlayerMuted", "False")))
            {
                case true:
                    buttonMute.ImageIndex = 1;
                    if (form_player.getMute() != true) form_player.toggleMute();
                    break;
                case false:
                    buttonMute.ImageIndex = 0;
                    if (form_player.getMute() != false) form_player.toggleMute();
                    break;
            }
            //
            // RGB tabPage
            //
            comboBoxRgbSendString.SelectedIndex = (int)RegKey.GetValue("SendStringSelected", 0);
            checkBoxAmbilight.Checked = Convert.ToBoolean(RegKey.GetValue("UseAmbilight", "False"));

            if (checkBoxAmbilight.Checked) timerAmbilight.Start();

            for (int i = 0; i < 24; i++) SetButtonColors(i, RegKey.GetValue("RgbShedulerHour" + Convert.ToString(i), "FFFF00").ToString());
            checkBoxSheduler.Checked = Convert.ToBoolean(RegKey.GetValue("RgbUseSheduler", false));
            if (checkBoxSheduler.Checked) checkBoxSheduler_Click(sender, e);
            //
            // PostMan tabPage
            //
            comboBoxHttpMethod.SelectedIndex = Convert.ToByte(RegKey.GetValue("PostManCombo", 0));
            textBoxHttpMethod.Text = Convert.ToString(RegKey.GetValue("PostManSendTextField", "index.html"));
            //            buttonMute.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SendStringToDevice(RgbConstants.RGB_OFF_STRING, MainConstants.DEV_RGB_TAPE_ID);

            RegKey.SetValue("TabIndex", tabControl.SelectedIndex);
            RegKey.SetValue("VlcStatus", form_player.getVlcState().ToString());
            RegKey.SetValue("UsedPlayListForIRemore", radioButtonMainVlcPlayList.Checked.ToString());
            RegKey.SetValue("SendStringSelected", comboBoxRgbSendString.SelectedIndex);
            RegKey.SetValue("VlcPlayerVolume", form_player.getVolume());
            RegKey.SetValue("VlcPlayerMuted", form_player.getMute());
            RegKey.SetValue("VlcDevicesMaskPinUsing", checkBoxVlcGpioMask.Checked);
            RegKey.SetValue("UseAmbilight", checkBoxAmbilight.Checked);
            RegKey.SetValue("VlcDevicesMaskPin", smartHomeModel.vlc_devices_mask);
            RegKey.SetValue("PlayListSelected", listBoxVlcPlaylistTitles.SelectedIndex);
            RegKey.SetValue("FavoriteListSelected", listBoxVlcFavoriteTitles.SelectedIndex);
            RegKey.SetValue("UseSlaveMonitor", checkBoxUseSlaveMonitor.Checked);
            RegKey.SetValue("VlcRememberChannelsVolume", checkBoxRememberChVol.Checked);
            if (checkBoxVlcGpioMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_RESET_BITS_GPIO_STATUS, smartHomeModel.vlc_devices_mask, MainConstants.DEV_SMART_HOME_ID); // Monitor, Subwoofer

            RegKey.Close();
        }

        public void WriteLog(string str)
        {
            String temp_str = "[" + DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss") + "]" + str + "\n";
            richTextBox1.BeginInvoke((MethodInvoker)(() => this.richTextBox1.AppendText(temp_str)));
            //this.BeginInvoke((MethodInvoker)(() => this.richTextBox1.AppendText(temp_str)));
        }

        public void SendRegToDevice(byte reg_num, int data, byte dev_num)
        {
            String temp_str1 = Utils.IntToHexString(reg_num, 2);
            String temp_str2 = Utils.IntToHexString(data, 4);
            temp_str1 = "REG:" + temp_str1 + "=" + temp_str2;
            SendStringToDevice(temp_str1, dev_num);
        }

        public void SendStringToDevice(String str, byte dev_num)
        {
            switch (dev_num)
            {
                case MainConstants.DEV_SMART_HOME_ID:
                    if (serialPortSmartHome.IsOpen)
                    {
                        serialPortSmartHome.WriteLine(str);
                        WriteLog(SndComName1 + str);
                    }
                    break;
                case MainConstants.DEV_RGB_TAPE_ID:
                    if (serialPortRgbTape.IsOpen)
                    {
                        serialPortRgbTape.WriteLine(str);
                        WriteLog(SndComName2 + str);
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
                    if (serialPortSmartHome.IsOpen)
                    {
                        serialPortSmartHome.WriteLine(str);
                        if (str != RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING) WriteLog(SndComName1 + str);
                    }
                    break;
                case MainConstants.DEV_RGB_TAPE_ID:
                    if (serialPortRgbTape.IsOpen)
                    {
                        serialPortRgbTape.WriteLine(str);
                        if (str != RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING) WriteLog(SndComName2 + str);
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
                toolStripStatusLabelSmartHome.Text = "FAIL !";
                this.Invoke((MethodInvoker)delegate
                {
                    toolStripStatusLabelSmartHome.ForeColor = Color.Red;
                });
                flag_smarthome_port_open = false;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
        }

        private void scanUsbDevices() // SCAN My DEVICES
        {
            int device_counter = MainConstants.ZERO;
            WriteLog("Scanning all devices on com ports...");
            string[] ports = SerialPort.GetPortNames();

            comboBoxUsbDevicesList.Items.Clear();
            comboBoxUsbDevicesList.Items.AddRange(ports);
            // Search for SmartHome device
            if (comboBoxUsbDevicesList.Items.Count > 0)
            {
                while (device_counter < comboBoxUsbDevicesList.Items.Count)
                {
                    serialPortSmartHome.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    if (serialPortSmartHome.IsOpen == false) toolStripStatusLabel3.Text = serialPortSmartHome.PortName = ports[device_counter].ToString();
                    try
                    {
                        if (serialPortSmartHome.IsOpen == false)
                        {
                            serialPortSmartHome.Open();
                            SendStringToDevice("SMART_HOME", MainConstants.DEV_SMART_HOME_ID);
                            if (flag_smarthome_port_open == false) serialPortSmartHome.Close();
                        }
                    }
                    catch
                    {
                        flag_smarthome_port_open = false;
                        toolStripStatusLabelSmartHome.Text = "FAIL !";
                        this.Invoke((MethodInvoker)delegate
                        {
                            toolStripStatusLabelSmartHome.ForeColor = Color.Red;
                        });
                        serialPortSmartHome.Close();
                    }
                    device_counter++;
                }
            }
            // Search for RgbTape device
            device_counter = MainConstants.ZERO;
            if (comboBoxUsbDevicesList.Items.Count > 0)
            {
                while (device_counter < comboBoxUsbDevicesList.Items.Count)
                {
                    serialPortSmartHome.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    if (serialPortRgbTape.IsOpen == false) toolStripStatusLabel1.Text = serialPortRgbTape.PortName = ports[device_counter].ToString();
                    try
                    {
                        if (serialPortRgbTape.IsOpen == false)
                        {
                            serialPortRgbTape.Open();
                            SendStringToDevice("RGB_TAPE", MainConstants.DEV_RGB_TAPE_ID);
                            if (flag_rgbtape_port_open == false) serialPortRgbTape.Close();
                        }
                    }
                    catch
                    {
                        flag_rgbtape_port_open = false;
                        toolStripStatusLabelRgbTape.Text = "FAIL !";
                        serialPortRgbTape.Close();
                        //                        MessageBox.Show("Can't Open Port !!!");
                    }
                    device_counter++;
                }
            }
        }

        private void numericUpDown_EncoderValue(object sender, MouseEventArgs e)
        {
            if (sender == numericUpDownEncoder1) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_ENC1_COUNTER, Convert.ToInt32(Math.Round(numericUpDownEncoder1.Value, 0)), MainConstants.DEV_SMART_HOME_ID);
            else if (sender == numericUpDownEncoder0) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_ENC0_COUNTER, Convert.ToInt32(Math.Round(numericUpDownEncoder0.Value, 0)), MainConstants.DEV_SMART_HOME_ID);

            buttonSaveCfg.Enabled = true;
        }

        public void ProcessDeviceRegister(int reg_number)
        {
            switch (reg_number)
            {
                case SmartHomeDeviceConstants.REG_CMD_GPIO_STATUS: ProcessGpioStatusRegister(device_register[reg_number - 1]); break;
                case SmartHomeDeviceConstants.REG_CMD_ENC0_COUNTER: ProcessEncoderRegister(device_register[reg_number - 1]); break;
                case SmartHomeDeviceConstants.REG_CMD_GET_SENSORS: ProcessSensorRegister(device_register[reg_number - 1]); break;
            }
        }

        public void ProcessSensorRegister(int reg_data)
        {
            buttonSensor0.BackColor = (reg_data & 0x01) == 0x01 ? Color.Red : Color.Black;
            buttonSensor1.BackColor = (reg_data & 0x02) == 0x01 ? Color.Red : Color.Black;
            buttonSensor2.BackColor = (reg_data & 0x04) == 0x01 ? Color.Red : Color.Black;
            buttonSensor3.BackColor = (reg_data & 0x08) == 0x01 ? Color.Red : Color.Black;
            buttonSensor4.BackColor = (reg_data & 0x10) == 0x01 ? Color.Red : Color.Black;
            buttonSensor5.BackColor = (reg_data & 0x20) == 0x01 ? Color.Red : Color.Black;
            buttonSensor6.BackColor = (reg_data & 0x40) == 0x01 ? Color.Red : Color.Black;
            buttonSensor7.BackColor = (reg_data & 0x80) == 0x01 ? Color.Red : Color.Black;
        }

        public void ProcessEncoderRegister(int reg_data)
        {
            this.numericUpDownEncoder0.Invoke((MethodInvoker)delegate
            {
                numericUpDownEncoder0.Value = reg_data;
            });
        }

        public void ProcessGpioStatusRegister(int reg_data)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (((reg_data >> 7) & 0x01) == 1) checkBoxStatusPin7.Checked = true; else checkBoxStatusPin7.Checked = false;
                if (((reg_data >> 6) & 0x01) == 1) checkBoxStatusPin6.Checked = true; else checkBoxStatusPin6.Checked = false;
                if (((reg_data >> 5) & 0x01) == 1) checkBoxStatusPin5.Checked = true; else checkBoxStatusPin5.Checked = false;
                if (((reg_data >> 4) & 0x01) == 1) checkBoxStatusPin4.Checked = true; else checkBoxStatusPin4.Checked = false;
                if (((reg_data >> 3) & 0x01) == 1) checkBoxStatusPin3.Checked = true; else checkBoxStatusPin3.Checked = false;
                if (((reg_data >> 2) & 0x01) == 1) checkBoxStatusPin2.Checked = true; else checkBoxStatusPin2.Checked = false;
                if (((reg_data >> 1) & 0x01) == 1) checkBoxStatusPin1.Checked = true; else checkBoxStatusPin1.Checked = false;
                if ((reg_data & 0x01) == 1) checkBoxStatusPin0.Checked = true; else checkBoxStatusPin0.Checked = false;
            });
        }

        //
        // Parse incoming CONFIG values and set equalent properties in View objects on Form
        //
        public void ParsingSmartHomeConfigString(string[] words)
        {
            smartHomeModel.current_device_status = byte.Parse(words[1], System.Globalization.NumberStyles.HexNumber); // Current tm1638 ports status
            smartHomeModel.sleep_mode_mask = byte.Parse(words[2], System.Globalization.NumberStyles.HexNumber); // SleepMode mask
            smartHomeModel.hot_button_mask = byte.Parse(words[3], System.Globalization.NumberStyles.HexNumber); // Hot button mask
            smartHomeModel.smarthome_beep_setting = byte.Parse(words[7], System.Globalization.NumberStyles.HexNumber); // Beeps settings
            ProcessSensorRegister(byte.Parse(words[8], System.Globalization.NumberStyles.HexNumber));

            this.Invoke((MethodInvoker)delegate
            {
                numericUpDownEncoder0.Value = int.Parse(words[4], System.Globalization.NumberStyles.HexNumber); // People in room counter / encoder0
                numericUpDownEncoder1.Value = int.Parse(words[5], System.Globalization.NumberStyles.HexNumber); // People in out room counter / encoder1
                numericUpDownSleepModeTimeout.Value = int.Parse(words[6], System.Globalization.NumberStyles.HexNumber);  // words[3] Timeout for sleep mode

                if (((smartHomeModel.current_device_status >> 7) & 0x01) == 1) checkBoxStatusPin7.Checked = true; else checkBoxStatusPin7.Checked = false;
                if (((smartHomeModel.current_device_status >> 6) & 0x01) == 1) checkBoxStatusPin6.Checked = true; else checkBoxStatusPin6.Checked = false;
                if (((smartHomeModel.current_device_status >> 5) & 0x01) == 1) checkBoxStatusPin5.Checked = true; else checkBoxStatusPin5.Checked = false;
                if (((smartHomeModel.current_device_status >> 4) & 0x01) == 1) checkBoxStatusPin4.Checked = true; else checkBoxStatusPin4.Checked = false;
                if (((smartHomeModel.current_device_status >> 3) & 0x01) == 1) checkBoxStatusPin3.Checked = true; else checkBoxStatusPin3.Checked = false;
                if (((smartHomeModel.current_device_status >> 2) & 0x01) == 1) checkBoxStatusPin2.Checked = true; else checkBoxStatusPin2.Checked = false;
                if (((smartHomeModel.current_device_status >> 1) & 0x01) == 1) checkBoxStatusPin1.Checked = true; else checkBoxStatusPin1.Checked = false;
                if ((smartHomeModel.current_device_status & 0x01) == 1) checkBoxStatusPin0.Checked = true; else checkBoxStatusPin0.Checked = false;
                //
                // SleepMode Mask
                //
                if (((smartHomeModel.sleep_mode_mask >> 7) & 0x01) == 1) checkBoxSleepModeMaskPin8.Checked = true; else checkBoxSleepModeMaskPin8.Checked = false;
                if (((smartHomeModel.sleep_mode_mask >> 6) & 0x01) == 1) checkBoxSleepModeMaskPin7.Checked = true; else checkBoxSleepModeMaskPin7.Checked = false;
                if (((smartHomeModel.sleep_mode_mask >> 5) & 0x01) == 1) checkBoxSleepModeMaskPin6.Checked = true; else checkBoxSleepModeMaskPin6.Checked = false;
                if (((smartHomeModel.sleep_mode_mask >> 4) & 0x01) == 1) checkBoxSleepModeMaskPin5.Checked = true; else checkBoxSleepModeMaskPin5.Checked = false;
                if (((smartHomeModel.sleep_mode_mask >> 3) & 0x01) == 1) checkBoxSleepModeMaskPin4.Checked = true; else checkBoxSleepModeMaskPin4.Checked = false;
                if (((smartHomeModel.sleep_mode_mask >> 2) & 0x01) == 1) checkBoxSleepModeMaskPin3.Checked = true; else checkBoxSleepModeMaskPin3.Checked = false;
                if (((smartHomeModel.sleep_mode_mask >> 1) & 0x01) == 1) checkBoxSleepModeMaskPin2.Checked = true; else checkBoxSleepModeMaskPin2.Checked = false;
                if ((smartHomeModel.sleep_mode_mask & 0x01) == 1) checkBoxSleepModeMaskPin1.Checked = true; else checkBoxSleepModeMaskPin1.Checked = false;
                //
                // Hot button mask
                //
                checkBoxHotButtonMask1.Checked = (smartHomeModel.hot_button_mask & 0x01) == 0x01 ? true : false;
                checkBoxHotButtonMask2.Checked = ((smartHomeModel.smarthome_beep_setting & 0x02) >> 1) == 0x01 ? true : false;
                checkBoxHotButtonMask3.Checked = ((smartHomeModel.smarthome_beep_setting & 0x04) >> 2) == 0x01 ? true : false;
                checkBoxHotButtonMask4.Checked = ((smartHomeModel.smarthome_beep_setting & 0x08) >> 3) == 0x01 ? true : false;
                checkBoxHotButtonMask5.Checked = ((smartHomeModel.smarthome_beep_setting & 0x10) >> 4) == 0x01 ? true : false;
                checkBoxHotButtonMask6.Checked = ((smartHomeModel.smarthome_beep_setting & 0x20) >> 5) == 0x01 ? true : false;
                checkBoxHotButtonMask7.Checked = ((smartHomeModel.smarthome_beep_setting & 0x40) >> 6) == 0x01 ? true : false;
                checkBoxHotButtonMask8.Checked = ((smartHomeModel.smarthome_beep_setting & 0x80) >> 7) == 0x01 ? true : false;

                checkBoxBuzzerBit0.Checked = (smartHomeModel.smarthome_beep_setting & 0x01) == 0x01 ? true : false;
                checkBoxBuzzerBit1.Checked = ((smartHomeModel.smarthome_beep_setting & 0x02) >> 1) == 0x01 ? true : false;
                checkBoxBuzzerBit2.Checked = ((smartHomeModel.smarthome_beep_setting & 0x04) >> 2) == 0x01 ? true : false;
                checkBoxBuzzerBit3.Checked = ((smartHomeModel.smarthome_beep_setting & 0x08) >> 3) == 0x01 ? true : false;
                checkBoxBuzzerBit4.Checked = ((smartHomeModel.smarthome_beep_setting & 0x10) >> 4) == 0x01 ? true : false;
                checkBoxBuzzerBit5.Checked = ((smartHomeModel.smarthome_beep_setting & 0x20) >> 5) == 0x01 ? true : false;
                checkBoxBuzzerBit6.Checked = ((smartHomeModel.smarthome_beep_setting & 0x40) >> 6) == 0x01 ? true : false;
            });
            //
            this.panel1.Invoke((MethodInvoker)delegate { panel1.Enabled = true; });
            this.panel2.Invoke((MethodInvoker)delegate { panel2.Enabled = true; });
            this.panel3.Invoke((MethodInvoker)delegate { panel3.Enabled = true; });
            this.groupBox4.Invoke((MethodInvoker)delegate { groupBox4.Enabled = true; });
            this.groupBox6.Invoke((MethodInvoker)delegate { groupBox6.Enabled = true; });
        }

        private Boolean VlcLoadAndFillListBox(string file_path, ListBox listbox_urls, ListBox listbox_titles)
        {
            string s;
            try
            {
                using (StreamReader sr = File.OpenText(file_path))
                {
                    listbox_urls.Items.Clear();
                    listbox_titles.Items.Clear();
                    while ((s = sr.ReadLine()) != null)
                    {
                        int index = s.IndexOf(",");
                        if (index != -1)
                        {
                            String title = s.Substring(index, s.Length - index);
                            listbox_titles.Items.Add(title);
                            if ((s = sr.ReadLine()) != null)
                            {
                                index = s.IndexOf("http");
                                if (index != -1)
                                {
                                    listbox_urls.Items.Add(s);
                                    continue;
                                }
                                else
                                {
                                    index = s.IndexOf("rtmp");
                                    if (index != -1)
                                    {
                                        listbox_urls.Items.Add(s);
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
            if (checkBoxStatusPin0.Checked) smartHomeModel.current_device_status |= 0x01; else smartHomeModel.current_device_status &= 0xFE;
            if (checkBoxStatusPin1.Checked) smartHomeModel.current_device_status |= 0x02; else smartHomeModel.current_device_status &= 0xFD;
            if (checkBoxStatusPin2.Checked) smartHomeModel.current_device_status |= 0x04; else smartHomeModel.current_device_status &= 0xFB;
            if (checkBoxStatusPin3.Checked) smartHomeModel.current_device_status |= 0x08; else smartHomeModel.current_device_status &= 0xF7;
            if (checkBoxStatusPin4.Checked) smartHomeModel.current_device_status |= 0x10; else smartHomeModel.current_device_status &= 0xEF;
            if (checkBoxStatusPin5.Checked) smartHomeModel.current_device_status |= 0x20; else smartHomeModel.current_device_status &= 0xDF;
            if (checkBoxStatusPin6.Checked) smartHomeModel.current_device_status |= 0x40; else smartHomeModel.current_device_status &= 0xBF;
            if (checkBoxStatusPin7.Checked) smartHomeModel.current_device_status |= 0x80; else smartHomeModel.current_device_status &= 0x7F;

            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_GPIO_STATUS, smartHomeModel.current_device_status, MainConstants.DEV_SMART_HOME_ID);
        }

        private void checkBoxSleepModeMask_Click(object sender, EventArgs e)
        {
            if (checkBoxSleepModeMaskPin1.Checked) smartHomeModel.sleep_mode_mask |= 0x01; else smartHomeModel.sleep_mode_mask &= 0xFE;
            if (checkBoxSleepModeMaskPin2.Checked) smartHomeModel.sleep_mode_mask |= 0x02; else smartHomeModel.sleep_mode_mask &= 0xFD;
            if (checkBoxSleepModeMaskPin4.Checked) smartHomeModel.sleep_mode_mask |= 0x08; else smartHomeModel.sleep_mode_mask &= 0xF7;
            if (checkBoxSleepModeMaskPin5.Checked) smartHomeModel.sleep_mode_mask |= 0x10; else smartHomeModel.sleep_mode_mask &= 0xEF;
            if (checkBoxSleepModeMaskPin6.Checked) smartHomeModel.sleep_mode_mask |= 0x20; else smartHomeModel.sleep_mode_mask &= 0xDF;
            if (checkBoxSleepModeMaskPin7.Checked) smartHomeModel.sleep_mode_mask |= 0x40; else smartHomeModel.sleep_mode_mask &= 0xBF;
            if (checkBoxSleepModeMaskPin8.Checked) smartHomeModel.sleep_mode_mask |= 0x80; else smartHomeModel.sleep_mode_mask &= 0x7F;

            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SLEEP_MASK, smartHomeModel.sleep_mode_mask, MainConstants.DEV_SMART_HOME_ID); // REG4 - SleepMode mask
            buttonSaveSmartHomeCfg.Enabled = true;
        }

        private void checkBoxHotButtonMask_Click(object sender, EventArgs e)
        {
            if (checkBoxHotButtonMask1.Checked) smartHomeModel.hot_button_mask |= 0x01; else smartHomeModel.hot_button_mask &= 0xFE;
            if (checkBoxHotButtonMask2.Checked) smartHomeModel.hot_button_mask |= 0x02; else smartHomeModel.hot_button_mask &= 0xFD;
            if (checkBoxHotButtonMask3.Checked) smartHomeModel.hot_button_mask |= 0x04; else smartHomeModel.hot_button_mask &= 0xFB;
            if (checkBoxHotButtonMask4.Checked) smartHomeModel.hot_button_mask |= 0x08; else smartHomeModel.hot_button_mask &= 0xF7;
            if (checkBoxHotButtonMask5.Checked) smartHomeModel.hot_button_mask |= 0x10; else smartHomeModel.hot_button_mask &= 0xEF;
            if (checkBoxHotButtonMask6.Checked) smartHomeModel.hot_button_mask |= 0x20; else smartHomeModel.hot_button_mask &= 0xDF;
            if (checkBoxHotButtonMask7.Checked) smartHomeModel.hot_button_mask |= 0x40; else smartHomeModel.hot_button_mask &= 0xBF;
            if (checkBoxHotButtonMask8.Checked) smartHomeModel.hot_button_mask |= 0x80; else smartHomeModel.hot_button_mask &= 0x7F;

            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_HOT_BUTTON_MASK, smartHomeModel.hot_button_mask, MainConstants.DEV_SMART_HOME_ID);
            buttonSaveSmartHomeCfg.Enabled = true;
        }
        //
        // RGB controller events and commands implements
        //
        private void SetRgbTapeBlynkMode(object sender, EventArgs e)
        {
            Int32 value1 = Convert.ToInt32(numericUpDownChannelNumber.Value);
            SendStringToDevice(value1.ToString() + ".2." + string.Format("{0:000}", Convert.ToInt32(numericUpDownRgbFreq.Value)), MainConstants.DEV_RGB_TAPE_ID);
        }

        private void numericUpDownRgbFreq_ValueChanged(object sender, EventArgs e)
        {
            SetRgbTapeBlynkMode(sender, e);
        }

        private void btnSendRgbCommand(object sender, EventArgs e)
        {
            SendStringToDevice(comboBoxRgbSendString.Text, MainConstants.DEV_RGB_TAPE_ID);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SendStringToDevice(textBoxDataToSend.Text, MainConstants.DEV_RGB_TAPE_ID);
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {
            button3_Click_1(sender, e);
        }

        private void trackBarColor_Scroll(object sender, EventArgs e)
        {
            Int32 value = Convert.ToInt32(numericUpDownChannelNumber.Value);
            SendStringToDevice("CH" + value.ToString() + ":" + Utils.IntToHexString(trackBar1.Value, 2) + Utils.IntToHexString(trackBar2.Value, 2) + Utils.IntToHexString(trackBar3.Value, 2), MainConstants.DEV_RGB_TAPE_ID);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownChannelNumber.Enabled = false;
            String a;
            Int32 value1 = Convert.ToInt32(numericUpDownChannelNumber.Value);
            Int32 value2 = Convert.ToInt32(numericUpDownRgbFreq.Value);

            if (value2 < 100) a = "0"; else a = null;

            SendStringToDevice(value1.ToString() + ".1." + a + value2.ToString(), MainConstants.DEV_RGB_TAPE_ID);
            SendStringToDevice("CH" + value1.ToString(), MainConstants.DEV_RGB_TAPE_ID);
            numericUpDownChannelNumber.Enabled = true;
        }
        //
        // Parsing received data from port 1
        //
        private void serialPortSmartHomeDevice_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string indata;
            SerialPort sp = (SerialPort)sender;
            
            try {
                indata = sp.ReadExisting();
                WriteLog(RcvComName1 + indata);
            if (indata == "SMART_HOME")
            {
                flag_smarthome_port_open = true;
                toolStripStatusLabelSmartHome.Text = "SMART_HOME CONNECTED";
                this.Invoke((MethodInvoker)delegate
                {
                    toolStripStatusLabelSmartHome.ForeColor = Color.Green;
                });
                SndComName1 = serialPortSmartHome.PortName + MainConstants.SEND_STRING;
                RcvComName1 = serialPortSmartHome.PortName + MainConstants.RECEIVE_STRING;
                WriteLog("Found: SmartHome device on physical port 1.");
                ReadConstantFromSmarthomeDevice();
            }
            if (flag_smarthome_port_open)
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
                        device_register[byte.Parse(words[0]) - 1] = Int16.Parse(words[1], System.Globalization.NumberStyles.HexNumber);
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
        private void serialPortRgbTapeDevice_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            WriteLog(RcvComName2 + indata);
            if (indata == "RGB_TAPE")
            {
                flag_rgbtape_port_open = true;
                this.Invoke((MethodInvoker)delegate
                {
                    toolStripStatusLabelRgbTape.ForeColor = Color.Green;
                });
                toolStripStatusLabelRgbTape.Text = "RGB_TAPE CONNECTED";
                SndComName2 = serialPortRgbTape.PortName + MainConstants.SEND_STRING;
                RcvComName2 = serialPortRgbTape.PortName + MainConstants.RECEIVE_STRING;

                this.panel5.Invoke((MethodInvoker)delegate
                {
                    panel5.Enabled = true;
                });
                WriteLog("Found: RGB_Tape device on physical port 2.");
                WriteLog("Scanning family devices on com ports complete...\n---\nWork started.");

                SendStringToDevice(RgbConstants.RGB_NORMAL_STATE_STRING,MainConstants.DEV_RGB_TAPE_ID);

                this.labelUseAmbilight.Invoke((MethodInvoker)delegate
                {
                    labelUseAmbilight.Enabled = true;
                });
                this.checkBoxAmbilight.Invoke((MethodInvoker)delegate
                {
                    checkBoxAmbilight.Enabled = true;
                });
            }
            if (flag_rgbtape_port_open)
            {
                if ((indata.Substring(0, 2) == "CH") & (indata.Substring(3, 1) == ":"))
                {
                    this.trackBar1.Invoke((MethodInvoker)delegate
                    {
                        trackBar1.Value = int.Parse(indata.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    });
                    this.trackBar2.Invoke((MethodInvoker)delegate
                    {
                        trackBar2.Value = int.Parse(indata.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                    });
                    this.trackBar3.Invoke((MethodInvoker)delegate
                    {
                        trackBar3.Value = int.Parse(indata.Substring(8, 2), System.Globalization.NumberStyles.HexNumber);
                    });

                    //ProcessConfigRgbTapeValues(words);
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SendStringToDevice("SAVE_CFG",MainConstants.DEV_RGB_TAPE_ID);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret(); // scroll it automatically
            }
        }

        void scanAudioDevices(int selectedIndex)
        {
            MMDeviceEnumerator deviceEnum = new MMDeviceEnumerator();
            comboBoxDevices.DataSource = deviceEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToList();
            comboBoxRenderDevices.DataSource = deviceEnum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToList();

            foreach (MMDevice device in deviceEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.All))
            {
                Console.WriteLine("{0}, {1}", device.FriendlyName, device.State);
            }

        }

        private void VLC_events(object sender, EventArgs e)
        {
            form_player.Stop();// .playlist.play();
        }


        void IR_RemoteExecute(uint data)
        {
            switch (data)
            {
                case IRemoteConstants.TR_MUSIC:
                    break;
                case IRemoteConstants.TR_MUTE:
                    buttonMute_Click(new object(), new EventArgs());
                    break;
                case IRemoteConstants.TR_MODE:
                    this.radioButtonFavoriteVlcPlayList.Invoke((MethodInvoker)delegate
                    {
                        if (radioButtonMainVlcPlayList.Checked) radioButtonFavoriteVlcPlayList.Checked = true; else radioButtonMainVlcPlayList.Checked = true;
                    });
                    VlcPlaySelected(VlcConstants.CURRENT_ITEM);
                    break;
                case IRemoteConstants.TR_PHOTO:
                    if (flag_rgb_off == false)
                    {
                        SendStringToDevice(RgbConstants.RGB_OFF_STRING, MainConstants.DEV_RGB_TAPE_ID);
                        flag_rgb_off = true;
                    }
                    else
                    {
                        SendStringToDevice(RgbConstants.RGB_NORMAL_STATE_STRING, MainConstants.DEV_RGB_TAPE_ID);
                        flag_rgb_off = false;
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
                    if (checkBoxVlcGpioMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_RESET_BITS_GPIO_STATUS, smartHomeModel.vlc_devices_mask, MainConstants.DEV_SMART_HOME_ID);
                    form_player.Stop();
                    break;
                case IRemoteConstants.TR_VOL_UP:
                    VlcChangeVolume(VlcConstants.ADD);
                    break;
                case IRemoteConstants.TR_VOL_DOWN:
                    VlcChangeVolume(VlcConstants.DEC);
                    break;
                case IRemoteConstants.TR_PREV:
                    VlcPlaySelected(VlcConstants.PREVIOUS_ITEM);
                    break;

                case IRemoteConstants.TR_NEXT:
                    VlcPlaySelected(VlcConstants.NEXT_ITEM);
                    break;
            }
        }

        private void VlcPlaySelected(int direction)
        {
            ListBox listbox_urls;
            ListBox listbox_titles;
            Form1 mainForm = new Form1();

            if (!checkBoxUseSlaveMonitor.Checked)
            {
                form_player.setPoint(new Point(Convert.ToInt32(mainForm.Location.X + mainForm.Size.Width), Convert.ToInt32(mainForm.Location.Y)));
                if (checkBoxVlcGpioMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SET_BITS_GPIO_STATUS, smartHomeModel.vlc_devices_mask & (~VlcConstants.VLC_MONITOR_MASK),MainConstants.DEV_SMART_HOME_ID); // switch ON. only Subwoofer
            }
            else
            {
                form_player.setPoint(new Point(Convert.ToInt32(VlcConstants.VLC_LOCATION_X_SLAVE_MONITOR), Convert.ToInt32(mainForm.Location.Y)));
                if (checkBoxVlcGpioMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SET_BITS_GPIO_STATUS, smartHomeModel.vlc_devices_mask, MainConstants.DEV_SMART_HOME_ID); // switch ON. Monitor only
            }

            if (radioButtonMainVlcPlayList.Checked)
            {
                listbox_urls = listBoxVlcPlaylistURLs;
                listbox_titles = listBoxVlcPlaylistTitles;
            }
            else
            {
                listbox_urls = listBoxVlcFavoriteURLs;
                listbox_titles = listBoxVlcFavoriteTitles;
            }

            if (listbox_urls.SelectedIndex == -1) listbox_urls.SelectedIndex = 0;

            if (direction < 0)
            {
                if (listbox_urls.SelectedIndex > 0) listbox_urls.SelectedIndex--; else listbox_urls.SelectedIndex = listbox_urls.Items.Count - 1;
            }

            if (direction > 0)
            {
                if (listbox_urls.SelectedIndex < listbox_urls.Items.Count - 1) listbox_urls.SelectedIndex++; else listbox_urls.SelectedIndex = 0;
            }

            listbox_titles.SelectedIndex = listbox_urls.SelectedIndex;

            String str;
            if (radioButtonMainVlcPlayList.Checked) str = "VlcMainPlaylist_CH" + listBoxVlcPlaylistTitles.SelectedIndex;
            else str = "VlcFavoritePlaylist_CH" + listBoxVlcFavoriteTitles.SelectedIndex;

            if (checkBoxRememberChVol.Checked) vlc_volume = Convert.ToByte(RegKey.GetValue(str, VlcConstants.DEFAULT_VOLUME));
            else vlc_volume = VlcConstants.DEFAULT_VOLUME;

            form_player.Show();
            form_player.setListBox(listbox_urls);
            form_player.setFullScreen(checkBoxFullScreen.Checked);
            form_player.Play();
            trackBarVlcVolume.Value = vlc_volume;
            form_player.setVolume(vlc_volume);
        }

        private void VlcChangeVolume(int a)
        {

            String str;
            vlc_volume = (byte)form_player.getVolume();

            switch (a)
            {
                case VlcConstants.ADD:
                    if (vlc_volume < 255) vlc_volume++;
                    break;
                case VlcConstants.DEC:
                    if (vlc_volume > 0) vlc_volume--;
                    break;
            }

            if (radioButtonMainVlcPlayList.Checked)
            {
                //                this.Invoke((MethodInvoker)delegate
                //                {
                str = Convert.ToString(listBoxVlcPlaylistTitles.SelectedIndex);
                str = "VlcMainPlaylist_CH" + str;
                RegKey.SetValue(str, vlc_volume);
                //                });
            }
            else
            {
                str = Convert.ToString(listBoxVlcFavoriteTitles.SelectedIndex);
                str = "VlcFavoritePlaylist_CH" + str;
            }
            trackBarVlcVolume.Value = vlc_volume;
        }

        private void btnRescanDevices_Click(object sender, EventArgs e)
        {
            scanUsbDevices();
        }

        private void listBoxVlcPlayList_Click(object sender, EventArgs e)
        {
            listBoxVlcPlaylistURLs.SelectedIndex = listBoxVlcPlaylistTitles.SelectedIndex;
            radioButtonMainVlcPlayList.Checked = true;
        }

        private void listBoxVlcFavoriteList_Click(object sender, EventArgs e)
        {
            listBoxVlcFavoriteURLs.SelectedIndex = listBoxVlcFavoriteTitles.SelectedIndex;
            radioButtonFavoriteVlcPlayList.Checked = true;
        }

        private void buttonDeleteFromPlaylist_Click(object sender, EventArgs e)
        {
            if (listBoxVlcPlaylistTitles.SelectedIndex != -1)
            {
                int index = listBoxVlcPlaylistTitles.SelectedIndex;
                listBoxVlcPlaylistTitles.Items.RemoveAt(listBoxVlcPlaylistTitles.SelectedIndex);
                listBoxVlcPlaylistURLs.SelectedIndex = index;
                listBoxVlcPlaylistURLs.Items.RemoveAt(listBoxVlcPlaylistURLs.SelectedIndex);
            }
            else MessageBox.Show("Must select item !");
        }

        private void buttonOpenVlcPlayListDialog_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                VlcLoadAndFillListBox(openFileDialog1.FileName, listBoxVlcPlaylistURLs, listBoxVlcPlaylistTitles);
            }
        }

        private void saveVlcPlayList(string filename, ListBox listbox_titles, ListBox listbox_urls)
        {
            System.IO.File.Delete(filename);
            try
            {
                using (StreamWriter sr = new StreamWriter(filename, true, System.Text.Encoding.UTF8))
                {
                    sr.WriteLine("#EXTM3U https://hdbox.ws");
                    int index_listbox = 0;

                    while (index_listbox < listbox_titles.Items.Count)
                    {
                        sr.WriteLine(listbox_titles.Items[index_listbox]);
                        sr.WriteLine(listbox_urls.Items[index_listbox]);
                        index_listbox++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("exception !\n\n");
            }
        }

        private void buttonSendDataToDevice_Click(object sender, EventArgs e)
        {
            SendStringToDevice(textBoxDataToSend.Text, MainConstants.DEV_SMART_HOME_ID);
        }

        private void listBoxVlcPlaylistTitles_MouseDown(object sender, MouseEventArgs e)
        {
            добавитьToolStripMenuItem.Enabled = true;
        }

        private void contextMenuStripPlaylist_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ListBox listbox_playlist_titles = new ListBox();
            ListBox listbox_playlist_urls = new ListBox();
            string playlist_filename = "";

            this.Text = ((ListBox)((ContextMenuStrip)sender).SourceControl).Name.ToString() + e.ClickedItem.Text;

            switch (((ListBox)((ContextMenuStrip)sender).SourceControl).Name.ToString())
            {
                case VlcConstants.OBJECT_NAME_PLAYLIST:
                    listbox_playlist_titles = listBoxVlcPlaylistTitles;
                    listbox_playlist_urls = listBoxVlcPlaylistURLs;
                    playlist_filename = maskedTextBoxPlayListPath.Text;
                    break;
                case VlcConstants.OBJECT_NAME_FAVORITES:
                    listbox_playlist_titles = listBoxVlcFavoriteTitles;
                    listbox_playlist_urls = listBoxVlcFavoriteURLs;
                    playlist_filename = maskedTextBoxFavoriteListPath.Text;
                    break;
            }

            switch (e.ClickedItem.Text)
            {
                case VlcConstants.ACTION_DELETE:
                    if (listbox_playlist_titles.SelectedIndex != -1)
                    {
                        int index = listbox_playlist_titles.SelectedIndex;
                        listbox_playlist_titles.Items.RemoveAt(listbox_playlist_titles.SelectedIndex);
                        listbox_playlist_urls.SelectedIndex = index;
                        listbox_playlist_urls.Items.RemoveAt(listbox_playlist_urls.SelectedIndex);
                        saveVlcPlayList(playlist_filename, listbox_playlist_titles, listbox_playlist_urls);
                    }
                    else MessageBox.Show("Must select item !");
                    break;
                case VlcConstants.ACTION_SAVE:
                    saveVlcPlayList(playlist_filename, listbox_playlist_titles, listbox_playlist_urls);
                    break;
                case VlcConstants.ACTION_ADD_FAV:
                    listBoxVlcFavoriteTitles.Items.Add(listbox_playlist_titles.Items[listbox_playlist_titles.SelectedIndex]);
                    listBoxVlcFavoriteURLs.Items.Add(listbox_playlist_urls.Items[listbox_playlist_titles.SelectedIndex]);
                    break;
            }
        }

        private void buttonLogFilePath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "log files | *.log";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                maskedTextBoxLogFilePath.Text = saveFileDialog1.FileName;
                buttonSaveCfg.Enabled = true;
            }
        }

        private void buttonVlcPlayListPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "m3u files | *.m3u";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                maskedTextBoxPlayListPath.Text = openFileDialog1.FileName;
                buttonSaveCfg.Enabled = true;
            }
        }

        private void buttonVlcFavoriteListPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "m3u files | *.m3u";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                maskedTextBoxFavoriteListPath.Text = openFileDialog1.FileName;
                buttonSaveCfg.Enabled = true;
            }
        }

        private void buttonSaveCfg_Click_1(object sender, EventArgs e)
        {
            //Создание объекта, для работы с файлом
            INIManager manager = new INIManager(app_path + "smarthome.ini");
            //Получить значение по ключу name из секции main
            string name = manager.GetPrivateString("PathSettings", "name");

            buttonSaveCfg.Enabled = false;

            manager.WritePrivateString("PathSettings", "LogFile", maskedTextBoxLogFilePath.Text);
            manager.WritePrivateString("PathSettings", "MainPlayList", maskedTextBoxPlayListPath.Text);
            manager.WritePrivateString("PathSettings", "FavoritePlayList", maskedTextBoxFavoriteListPath.Text);
        }

        private void buttonVlcStop_Click(object sender, EventArgs e)
        {
            //axVLCPlugin21.playlist.stop();
            if (checkBoxVlcGpioMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_RESET_BITS_GPIO_STATUS, smartHomeModel.vlc_devices_mask, MainConstants.DEV_SMART_HOME_ID); // Monitor, Subwoofer
            form_player.Stop();
            form_player.Hide();
        }

        private void axVLCPlugin21_MediaPlayerLengthChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerLengthChangedEvent e)
        {
            richTextBoxVlcLog.BeginInvoke((MethodInvoker)(() => this.richTextBoxVlcLog.AppendText("[" + DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss") + "] MediaPlayerLengthChanged\n")));
        }

        private void axVLCPlugin21_MediaPlayerStopAsyncDone(object sender, EventArgs e)
        {
            richTextBoxVlcLog.BeginInvoke((MethodInvoker)(() => this.richTextBoxVlcLog.AppendText("[" + DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss") + "] MediaPlayerStopAsyncDone\n")));
        }

        private void axVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            //            axVLCPlugin21.playlist.stop();
            //            axVLCPlugin21.playlist.play();
            richTextBoxVlcLog.BeginInvoke((MethodInvoker)(() => this.richTextBoxVlcLog.AppendText("[" + DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss") + "] MediaPlayerEndReached\n")));
        }

        private void listBoxVlcPlaylistTitles_DoubleClick(object sender, EventArgs e)
        {
            radioButtonMainVlcPlayList.Checked = true;
            VlcPlaySelected(VlcConstants.CURRENT_ITEM);
        }

        private void listBoxVlcFavoriteTitles_DoubleClick(object sender, EventArgs e)
        {
            radioButtonFavoriteVlcPlayList.Checked = true;
            VlcPlaySelected(VlcConstants.CURRENT_ITEM);
        }

        private void GetAndSendColor()
        {
            POINT p;
            if (GetCursorPos(out p))
            {
                labelPixel.Text = Convert.ToString(p.X) + ";" + Convert.ToString(p.Y);
                IntPtr hDC = GetDC(IntPtr.Zero);
                p.X = MainConstants.AMBILIGHT_X;
                p.Y = MainConstants.AMBILIGHT_Y;
                uint pixel = GetPixel(hDC, p.X, p.Y);
                ReleaseDC(IntPtr.Zero, hDC);
                byte r = (byte)(pixel & 0x000000FF);
                byte g = (byte)((pixel & 0x0000FF00) >> 8);
                byte b = (byte)((pixel & 0x00FF0000) >> 16);
                SendStringToDevice("EFFECT_CONFIG:01.1.1.1." + r.ToString("X2") + "." + g.ToString("X2") + "." + b.ToString("X2") + ".00.00", MainConstants.DEV_RGB_TAPE_ID);
                labelRED.Text = r.ToString();
                labelGREEN.Text = g.ToString();
                labelBLUE.Text = b.ToString();
            }
        }

        private uint DominateColor()
        {
            uint color;
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            int canvas_x = resolution.Width;
            int canvas_y = resolution.Height;
            uint pixel;
            uint summa_r = 0;
            uint summa_g = 0;
            uint summa_b = 0;
            int x = 0;
            int y = 0;
            //            POINT p;
            IntPtr hDC = GetDC(IntPtr.Zero);
            for (x = canvas_x - 50; x < canvas_x; x++)
            {
                for (y = canvas_y - 100; y < canvas_y; y++)
                {
                    pixel = GetPixel(hDC, x, y);
                    summa_r += (byte)(pixel & 0x000000FF);
                    summa_g += (byte)((pixel & 0x0000FF00) >> 8);
                    summa_b += (byte)((pixel & 0x0000FF00) >> 16);
                }
            }
            ReleaseDC(IntPtr.Zero, hDC);
            labelX.Text = x.ToString();
            labelY.Text = y.ToString();
            summa_r = summa_r / 5000;
            summa_g = summa_g / 5000;
            summa_b = summa_b / 5000;
            color = summa_b << 16 | summa_g << 8 | summa_r;

            return (color);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DominateColor();
            //GetAndSendColor();
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            if (buttonMute.ImageIndex != 0) buttonMute.ImageIndex = 0; else buttonMute.ImageIndex = 1;

            form_player.toggleMute();
        }

        private void timerAmbilight_Tick(object sender, EventArgs e)
        {
            GetAndSendColor();
        }

        private void checkBoxAmbilight_Click(object sender, EventArgs e)
        {
            if (checkBoxAmbilight.Checked)
            {
                timerAmbilight.Start();

            }
            else
            {
                timerAmbilight.Stop();

            }
            buttonSaveCfg.Enabled = true;
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

        private void checkBoxVlcGpioMask_Click(object sender, EventArgs e)
        {
            grbHostSettings.Enabled = checkBoxVlcGpioMask.Checked;
            checkVlcGpioMask();
        }

        public void checkVlcGpioMask()
        {
            if (grbHostSettings.Enabled) checkBoxVlcGpioMask.ForeColor = SystemColors.ControlText;
            else checkBoxVlcGpioMask.ForeColor = SystemColors.ControlDark;
        }

        private void buttonPlayPause_Click(object sender, EventArgs e)
        {
            flag_vlc_play = (1 - flag_vlc_play);
            buttonPlayPause.ImageIndex = 2 + (flag_vlc_play);
        }

        private void VlcMaskPinsToInt(object sender, EventArgs e)
        {
            if (checkBoxVlcMaskPin0.Checked) smartHomeModel.vlc_devices_mask |= 0x01; else smartHomeModel.vlc_devices_mask &= 0xFE;
            if (checkBoxVlcMaskPin1.Checked) smartHomeModel.vlc_devices_mask |= 0x02; else smartHomeModel.vlc_devices_mask &= 0xFD;
            if (checkBoxVlcMaskPin2.Checked) smartHomeModel.vlc_devices_mask |= 0x04; else smartHomeModel.vlc_devices_mask &= 0xFB;
            if (checkBoxVlcMaskPin3.Checked) smartHomeModel.vlc_devices_mask |= 0x08; else smartHomeModel.vlc_devices_mask &= 0xF7;
            if (checkBoxVlcMaskPin4.Checked) smartHomeModel.vlc_devices_mask |= 0x10; else smartHomeModel.vlc_devices_mask &= 0xEF;
            if (checkBoxVlcMaskPin5.Checked) smartHomeModel.vlc_devices_mask |= 0x12; else smartHomeModel.vlc_devices_mask &= 0xDF;
            if (checkBoxVlcMaskPin6.Checked) smartHomeModel.vlc_devices_mask |= 0x14; else smartHomeModel.vlc_devices_mask &= 0xBF;
            if (checkBoxVlcMaskPin7.Checked) smartHomeModel.vlc_devices_mask |= 0x18; else smartHomeModel.vlc_devices_mask &= 0x7F;
        }

        private void VlcMaskIntToCheckboxes()
        {
            if ((smartHomeModel.vlc_devices_mask & 0x01) == 0x01) checkBoxVlcMaskPin0.Checked = true;
            if ((smartHomeModel.vlc_devices_mask & 0x02) == 0x02) checkBoxVlcMaskPin1.Checked = true;
            if ((smartHomeModel.vlc_devices_mask & 0x04) == 0x04) checkBoxVlcMaskPin2.Checked = true;
            if ((smartHomeModel.vlc_devices_mask & 0x08) == 0x08) checkBoxVlcMaskPin3.Checked = true;
            if ((smartHomeModel.vlc_devices_mask & 0x10) == 0x10) checkBoxVlcMaskPin4.Checked = true;
            if ((smartHomeModel.vlc_devices_mask & 0x20) == 0x20) checkBoxVlcMaskPin5.Checked = true;
            if ((smartHomeModel.vlc_devices_mask & 0x40) == 0x40) checkBoxVlcMaskPin6.Checked = true;
            if ((smartHomeModel.vlc_devices_mask & 0x80) == 0x80) checkBoxVlcMaskPin7.Checked = true;
        }

        private void trackBarVlcVolume_ValueChanged(object sender, EventArgs e)
        {
            String str;

            vlc_volume = (byte)trackBarVlcVolume.Value;
            form_player.setVolume(vlc_volume);

            if (checkBoxRememberChVol.Checked)
            {
                if (radioButtonMainVlcPlayList.Checked) str = "VlcMainPlaylist_CH" + listBoxVlcPlaylistTitles.SelectedIndex;
                else str = "VlcFavoritePlaylist_CH" + listBoxVlcFavoriteTitles.SelectedIndex;
            }
            else
            {
                str = "VlcPlayerVolume";
            }
            SendStringToDeviceBulk(RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING, MainConstants.DEV_RGB_TAPE_ID); // команда эффект для RGB контроллера (описание в /doc)
            System.Threading.Thread.Sleep(1);

            RegKey.SetValue(str, vlc_volume);
        }

        private void checkBoxUseSlaveMonitor_Click(object sender, EventArgs e)
        {
            //buttonSaveCfg.Enabled = true;
            if (form_player.getVlcState()) VlcPlaySelected(VlcConstants.CURRENT_ITEM);
            buttonSaveCfg_Click_1(sender, e);
        }

        private void buttonStartAudioStreamScan_Click(object sender, EventArgs e)
        {
            SendStringToDevice("0.1.000", MainConstants.DEV_RGB_TAPE_ID);
            buttonStopRecord.Enabled = true;
            buttonStartAudioStreamScan.Enabled = false;

            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                Console.WriteLine("Device {0}: {1}, {2} channels", waveInDevice, deviceInfo.ProductName, deviceInfo.Channels);
            }

            try
            {
                waveIn = new WaveIn();
                waveIn.DeviceNumber = comboBoxRenderDevices.SelectedIndex + 1; // Дефолтное устройство для записи (если оно имеется)
                waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable); // Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                waveIn.RecordingStopped += new EventHandler<StoppedEventArgs>(waveIn_RecordingStopped); // Прикрепляем обработчик завершения записи
                string outputFilename = "D:/demo.wav";
                waveIn.WaveFormat = new WaveFormat(44100, 1);
                writer = new WaveFileWriter(outputFilename, waveIn.WaveFormat);
                waveIn.StartRecording(); //Инициализируем объект WaveFileWriter, начало записи
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            // Setup the graph
            
            // Size the control to fill the form with a margin
            //SetSize();*/
            // эта часть не нужна программа узнает о прочитаном звуке с помощью событий.
        }

        //Окончание записи
        private void waveIn_RecordingStopped(object sender, EventArgs e)
        {
            buttonStopRecord.Enabled = false;
            buttonStartAudioStreamScan.Enabled = true;
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler(waveIn_RecordingStopped), sender, e);
            }
            else
            {
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;
                writer.Close();
                writer = null;
            }
        }

        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(waveIn_DataAvailable), sender, e);
            }
            else
            {
                //данные из буфера распределяем в массив чтобы в нем они были в формате ?PCM?
                byte[] buffer = e.Buffer;
                N = buffer.Length;
                int bytesRecorded = e.BytesRecorded;
                Complex[] sig = new Complex[bytesRecorded / 2];
                for (int i = 0, j = 0; i < e.BytesRecorded; i += 2, j++)
                {
                    short sample = (short)((buffer[i + 1] << 8) | buffer[i + 0]);
                    sig[j] = sample / 32768f;
                }

                //Transform.FourierForward(sig, FourierOptions.Matlab);
                // обнуляем спектр на небольших частотах (там постоянная составляющая и вообще много помех)
                for (int i = 0; i < 35 * sig.Length / Fn; i++)
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
                list1.Add(i*Fn/K, Complex.Abs(sig[i])/N*2);
            }

            String rgb_string = "CH0:";

            labelLowMax.Visible = labelMiddleMax.Visible = labelHighMax.Visible = false;

            int value = GetCalculateValueFromComplexValues((int)numericUpDownLowFreq.Value);
            if (value > 255)
            {
                value = 255;
                labelLowMax.Visible = true;
            }
            progressBarLowFreq.Value = value;
            String value_str = value.ToString("X2");
            textBoxLowFreq.Text = value_str;
            rgb_string += value_str;

            value = GetCalculateValueFromComplexValues((int)numericUpDownMiddleFreq.Value );
            if (value > 255)
            {
                value = 255;
                labelMiddleMax.Visible = true;
            }
            progressBarMiddleFreq.Value = value;
            value_str = value.ToString("X2");
            textBoxMiddleFreq.Text = value_str;
            rgb_string += value_str;

            value = GetCalculateValueFromComplexValues((int)numericUpDownHighFreq.Value);
            if (value > 255)
            {
                value = 255;
                labelHighMax.Visible = true;
            }
            progressBarHighFreq.Value = value;
            value_str = value.ToString("X2");
            textBoxHighFreq.Text = value_str;
            rgb_string += value_str;

            SendStringToDevice(rgb_string, MainConstants.DEV_RGB_TAPE_ID);

            // Generate a red curve 
            LineItem myCurve = myPane.AddCurve("", list1, Color.Red, SymbolType.None);
            // Set the Titles
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
                for (int i = (int)((check_freq - FREQ_ARRAY_LENGTH) * sig.Length / Fn); i < (int)((check_freq + FREQ_ARRAY_LENGTH) * sig.Length / Fn); i++)
                {
                    c = Complex.Abs((sig[i] / N * 2) * 10000000); // list1.Add(i*Fn/K, Complex.Abs(sig[i])/N*2);
                    summ += (int)c.Real;
                }
                summ /= FREQ_ARRAY_LENGTH;
                if (summ > 255) summ = 255;
                return ((int)summ);
            }
        }


        private void comboBoxHttpMethod_SelectedValueChanged(object sender, EventArgs e)
        {
            SendStringToDeviceBulk(RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING, MainConstants.DEV_RGB_TAPE_ID); // команда эффект для RGB контроллера (описание в /doc)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VlcPlaySelected(VlcConstants.CURRENT_ITEM);
        }

        private void checkBoxFullScreen_Click(object sender, EventArgs e)
        {
            RegKey.SetValue("VlcFullScreen", checkBoxFullScreen.Checked);
            VlcPlaySelected(VlcConstants.CURRENT_ITEM);
        }

        private void checkBoxSheduler_Click(object sender, EventArgs e)
        {
            groupBoxSheduler.Enabled = checkBoxSheduler.Checked;
            RegKey.SetValue("RgbUseSheduler", checkBoxSheduler.Checked);
            timerRgbSheduler.Enabled = groupBoxSheduler.Enabled;

            if (!timerAmbilight.Enabled) timerRgbSheduler.Start();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            int hour = 0;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (sender == buttonColor00) hour = 0;
                if (sender == buttonColor01) hour = 1;
                if (sender == buttonColor02) hour = 2;
                if (sender == buttonColor03) hour = 3;
                if (sender == buttonColor04) hour = 4;
                if (sender == buttonColor05) hour = 5;
                if (sender == buttonColor06) hour = 6;
                if (sender == buttonColor07) hour = 7;
                if (sender == buttonColor08) hour = 8;
                if (sender == buttonColor09) hour = 9;
                if (sender == buttonColor10) hour = 10;
                if (sender == buttonColor11) hour = 11;
                if (sender == buttonColor12) hour = 12;
                if (sender == buttonColor13) hour = 13;
                if (sender == buttonColor14) hour = 14;
                if (sender == buttonColor15) hour = 15;
                if (sender == buttonColor16) hour = 16;
                if (sender == buttonColor17) hour = 17;
                if (sender == buttonColor18) hour = 18;
                if (sender == buttonColor19) hour = 19;
                if (sender == buttonColor20) hour = 20;
                if (sender == buttonColor21) hour = 21;
                if (sender == buttonColor22) hour = 22;
                if (sender == buttonColor23) hour = 23;
            }
            Button button = (Button)sender;
            button.BackColor = colorDialog1.Color;
            rgb_sheduler_colors_array[hour] = colorDialog1.Color;
            flag_rgb_state[hour] = false;

            RegKey.SetValue("RgbShedulerHour" + Convert.ToString(hour), colorDialog1.Color.R.ToString("X2") + colorDialog1.Color.G.ToString("X2") + colorDialog1.Color.B.ToString("X2"));
        }

        private void colorArrayToButtons()
        {
        }

        private void timerRgbSheduler_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            if (!flag_rgb_state[hour])
            {
                string rgb_string = "EFFECT_CONFIG:01.1.1.1."; //FF.00.00.00.20";
                rgb_string += rgb_sheduler_colors_array[hour].R.ToString("X2") + ".";
                rgb_string += rgb_sheduler_colors_array[hour].G.ToString("X2") + ".";
                rgb_string += rgb_sheduler_colors_array[hour].B.ToString("X2") + ".";
                rgb_string += "70.00";
                SendStringToDevice(rgb_string, MainConstants.DEV_RGB_TAPE_ID);

                flag_rgb_state[hour] = true;
                if (hour > 0) flag_rgb_state[hour - 1] = false;
                else if (hour == 0) flag_rgb_state[23] = false;
            }
        }

        private void SetButtonColors(int button_num, string color_string)
        {
            byte red = byte.Parse(color_string.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte green = byte.Parse(color_string.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte blue = byte.Parse(color_string.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            rgb_sheduler_colors_array[button_num] = Color.FromArgb(255, red, green, blue);

            switch (button_num)
            {
                case 0: buttonColor00.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 1: buttonColor01.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 2: buttonColor02.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 3: buttonColor03.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 4: buttonColor04.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 5: buttonColor05.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 6: buttonColor06.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 7: buttonColor07.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 8: buttonColor08.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 9: buttonColor09.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 10: buttonColor10.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 11: buttonColor11.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 12: buttonColor12.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 13: buttonColor13.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 14: buttonColor14.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 15: buttonColor15.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 16: buttonColor16.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 17: buttonColor17.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 18: buttonColor18.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 19: buttonColor19.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 20: buttonColor20.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 21: buttonColor21.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 22: buttonColor22.BackColor = rgb_sheduler_colors_array[button_num]; break;
                case 23: buttonColor23.BackColor = rgb_sheduler_colors_array[button_num]; break;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRememberChVol_Click(object sender, EventArgs e)
        {
            buttonSaveCfg_Click_1(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonSaveSmartHomeCfg.Enabled = false;
            try
            {
                SendStringToDevice("SAVE_CFG1", MainConstants.DEV_SMART_HOME_ID);
            }
            catch
            {
                richTextBox1.Text = "COMx\n";
                toolStripStatusLabelRgbTape.Text = "FAIL !";
                flag_smarthome_port_open = false;
            }
        }

        private void checkBoxBuzzerBits_Click(object sender, EventArgs e)
        {
            if (checkBoxBuzzerBit0.Checked) smartHomeModel.smarthome_beep_setting |= 0x01; else smartHomeModel.smarthome_beep_setting &= 0xFE; // enc0
            if (checkBoxBuzzerBit1.Checked) smartHomeModel.smarthome_beep_setting |= 0x02; else smartHomeModel.smarthome_beep_setting &= 0xFD; // enc1
            if (checkBoxBuzzerBit2.Checked) smartHomeModel.smarthome_beep_setting |= 0x04; else smartHomeModel.smarthome_beep_setting &= 0xFB; // keyboard
            if (checkBoxBuzzerBit3.Checked) smartHomeModel.smarthome_beep_setting |= 0x08; else smartHomeModel.smarthome_beep_setting &= 0xF7; // remote
            if (checkBoxBuzzerBit4.Checked) smartHomeModel.smarthome_beep_setting |= 0x10; else smartHomeModel.smarthome_beep_setting &= 0xEF; // uart in
            if (checkBoxBuzzerBit5.Checked) smartHomeModel.smarthome_beep_setting |= 0x20; else smartHomeModel.smarthome_beep_setting &= 0xDF; // usb in
            if (checkBoxBuzzerBit6.Checked) smartHomeModel.smarthome_beep_setting |= 0x40; else smartHomeModel.smarthome_beep_setting &= 0xBF; // use door sensor
            buttonSaveSmartHomeCfg.Enabled = true;
            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SET_FLAGS, smartHomeModel.smarthome_beep_setting, MainConstants.DEV_SMART_HOME_ID);
        }

        private void checkBoxBuzzerBit0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonStopRecord_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("StopRecording");

            waveIn.StopRecording();
        }
    }
}