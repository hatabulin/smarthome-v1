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
        Boolean smartHomePortOpenFlag = false;
        Boolean rgbTapePortOpenFlag = false;
        Boolean rgbOffFlag = false;
        //
        SmartHomeModel smartHomeModel = new SmartHomeModel();

        int flag_vlc_play = 0;
        byte vlcVolume = VlcConstants.DEFAULT_VOLUME;
        bool[] rgbStateFlag = new bool[24];
        Color[] rgbShedulerColorsArray = new Color[24];
        //
        //
        Int16[] deviceRegister = new Int16[10];
        string app_path = "d:\\";
        string SndComName2, RcvComName2, SndComName1, RcvComName1, SndComName3, RcvComName3;
        //
        //
        RegistryKey RegKey = Registry.CurrentUser.CreateSubKey("Hatabisoft");
        FormPlayer formVlcPlayer;
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
            if (formVlcPlayer == null) formVlcPlayer = new FormPlayer();
            
            ManageCheckGroupBox(cbUsedGpioForVlcMask, grbVlcGpioSettings);
            ManageCheckGroupBox(cbSheduler, gbSheduler);

            cbUsbDevicesList.Items.Clear();
            cbUsbDevicesList.Items.AddRange(SerialPort.GetPortNames());
            scanUsbDevices(); // SCAN My DEVICES
            scanAudioDevices(cbDevices.SelectedIndex);
            //
            app_path = Path.GetFullPath(Application.ExecutablePath);
            app_path = Directory.GetParent(app_path).FullName + "\\";
            //
            INIManager manager = new INIManager(app_path + "smarthome.ini");
            string name = manager.GetPrivateString("PathSettings", "name");
            //
            mtbLogFilePath.Text = manager.GetPrivateString("PathSettings", "LogFile");
            mtbPlayListPath.Text = manager.GetPrivateString("PathSettings", "MainPlayList");
            mtbFavoriteListPath.Text = manager.GetPrivateString("PathSettings", "FavoritePlayList");

            GetRegistrySettings();
            VlcMaskIntToCheckboxes();
            VlcLoadAndFillListBox(mtbPlayListPath.Text, lbVlcPlaylistURLs, lbVlcPlaylistTitles);
            lbVlcPlaylistURLs.SelectedIndex = lbVlcPlaylistTitles.SelectedIndex;
            VlcLoadAndFillListBox(mtbFavoriteListPath.Text, lbVlcFavoriteURLs, lbVlcFavoriteTitles);
            lbVlcFavoriteURLs.SelectedIndex = lbVlcFavoriteTitles.SelectedIndex;
            rbFavoriteVlcPlayList.Checked = !(rbMainVlcPlayList.Checked);
            grbVlcGpioSettings.Enabled = cbUsedGpioForVlcMask.Checked;
            checkVlcGpioMask();
            tbVlcVolume.Value = vlcVolume;
            if (cbAmbilight.Checked) timerAmbilight.Start();
            if (cbSheduler.Checked) cbSheduler_Click(sender, e);
        }

        private void GetRegistrySettings()
        {
            tabControl.SelectedIndex = (int)RegKey.GetValue("TabIndex", 0);
            smartHomeModel.vlcDevicesMask = (int)RegKey.GetValue("VlcDevicesMaskPin", 0);
            lbVlcPlaylistTitles.SelectedIndex = (int)RegKey.GetValue("PlayListSelected", 0);
            lbVlcFavoriteTitles.SelectedIndex = (int)RegKey.GetValue("FavoriteListSelected", 0);
            rbMainVlcPlayList.Checked = Convert.ToBoolean(RegKey.GetValue("UsedPlayListForIRemore", "True"));
            cbUsedGpioForVlcMask.Checked = Convert.ToBoolean(RegKey.GetValue("VlcDevicesMaskPinUsing", "False"));
            cbUseSlaveMonitor.Checked = Convert.ToBoolean(RegKey.GetValue("UseSlaveMonitor", "False"));
            if (Convert.ToBoolean(RegKey.GetValue("VlcStatus", "False"))) VlcPlaySelected(VlcConstants.CURRENT_ITEM);
            cbRememberChVol.Checked = Convert.ToBoolean(RegKey.GetValue("VlcRememberChannelsVolume", false));
            vlcVolume = Convert.ToByte(RegKey.GetValue("VlcPlayerVolume", VlcConstants.DEFAULT_VOLUME));
            switch (Convert.ToBoolean(RegKey.GetValue("VlcPlayerMuted", "False")))
            {
                case true:
                    btnMute.ImageIndex = 1;
                    if (formVlcPlayer.getMute() != true) formVlcPlayer.toggleMute();
                    break;
                case false:
                    btnMute.ImageIndex = 0;
                    if (formVlcPlayer.getMute() != false) formVlcPlayer.toggleMute();
                    break;
            }
            cbRgbSendString.SelectedIndex = (int)RegKey.GetValue("SendStringSelected", 0);
            cbAmbilight.Checked = Convert.ToBoolean(RegKey.GetValue("UseAmbilight", "False"));
            for (int i = 0; i < 24; i++) SetButtonColors(i, RegKey.GetValue("RgbShedulerHour" + Convert.ToString(i), "FFFF00").ToString());
            cbSheduler.Checked = Convert.ToBoolean(RegKey.GetValue("RgbUseSheduler", false));
            comboBoxHttpMethod.SelectedIndex = Convert.ToByte(RegKey.GetValue("PostManCombo", 0));
            textBoxHttpMethod.Text = Convert.ToString(RegKey.GetValue("PostManSendTextField", "index.html"));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SendStringToDevice(RgbConstants.RGB_OFF_STRING, MainConstants.DEV_RGB_TAPE_ID);

            RegKey.SetValue("TabIndex", tabControl.SelectedIndex);
            RegKey.SetValue("VlcStatus", formVlcPlayer.getVlcState().ToString());
            RegKey.SetValue("UsedPlayListForIRemore", rbMainVlcPlayList.Checked.ToString());
            RegKey.SetValue("SendStringSelected", cbRgbSendString.SelectedIndex);
            RegKey.SetValue("VlcPlayerVolume", formVlcPlayer.getVolume());
            RegKey.SetValue("VlcPlayerMuted", formVlcPlayer.getMute());
            RegKey.SetValue("VlcDevicesMaskPinUsing", cbUsedGpioForVlcMask.Checked);
            RegKey.SetValue("UseAmbilight", cbAmbilight.Checked);
            RegKey.SetValue("VlcDevicesMaskPin", smartHomeModel.vlcDevicesMask);
            RegKey.SetValue("PlayListSelected", lbVlcPlaylistTitles.SelectedIndex);
            RegKey.SetValue("FavoriteListSelected", lbVlcFavoriteTitles.SelectedIndex);
            RegKey.SetValue("UseSlaveMonitor", cbUseSlaveMonitor.Checked);
            RegKey.SetValue("VlcRememberChannelsVolume", cbRememberChVol.Checked);
            if (cbUsedGpioForVlcMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_RESET_BITS_GPIO_STATUS, smartHomeModel.vlcDevicesMask, MainConstants.DEV_SMART_HOME_ID); // Monitor, Subwoofer

            RegKey.Close();
        }

        public void WriteLog(RichTextBox richTextBox, string str)
        {
            String temp_str = "[" + DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss") + "]" + str + "\n";
            rtbLogger.AppendText(temp_str);
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
                        WriteLog(rtbLogger, SndComName1 + str);
                    }
                    break;
                case MainConstants.DEV_RGB_TAPE_ID:
                    if (serialPortRgbTape.IsOpen)
                    {
                        serialPortRgbTape.WriteLine(str);
                        WriteLog(rtbLogger, SndComName2 + str);
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
                        if (str != RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING) WriteLog(rtbLogger, SndComName1 + str);
                    }
                    break;
                case MainConstants.DEV_RGB_TAPE_ID:
                    if (serialPortRgbTape.IsOpen)
                    {
                        serialPortRgbTape.WriteLine(str);
                        if (str != RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING) WriteLog(rtbLogger, SndComName2 + str);
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
                tsStatusLabelSmartHome.Text = "FAIL !";
                this.Invoke((MethodInvoker)delegate
                {
                    tsStatusLabelSmartHome.ForeColor = Color.Red;
                });
                smartHomePortOpenFlag = false;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
        }

        private void scanUsbDevices() // SCAN My DEVICES
        {
            int deviceCounter = MainConstants.ZERO;
            WriteLog(rtbLogger, "Scanning all devices on com ports...");
            string[] ports = SerialPort.GetPortNames();

            cbUsbDevicesList.Items.Clear();
            cbUsbDevicesList.Items.AddRange(ports);
            // Search for SmartHome device
            if (cbUsbDevicesList.Items.Count > 0)
            {
                while (deviceCounter < cbUsbDevicesList.Items.Count)
                {
                    serialPortSmartHome.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    if (serialPortSmartHome.IsOpen == false) toolStripStatusLabel3.Text = serialPortSmartHome.PortName = ports[deviceCounter].ToString();
                    try
                    {
                        if (serialPortSmartHome.IsOpen == false)
                        {
                            serialPortSmartHome.Open();
                            SendStringToDevice("SMART_HOME", MainConstants.DEV_SMART_HOME_ID);
                            if (smartHomePortOpenFlag == false) serialPortSmartHome.Close();
                        }
                    }
                    catch
                    {
                        smartHomePortOpenFlag = false;
                        tsStatusLabelSmartHome.Text = "FAIL !";
                        this.Invoke((MethodInvoker)delegate
                        {
                            tsStatusLabelSmartHome.ForeColor = Color.Red;
                        });
                        serialPortSmartHome.Close();
                    }
                    deviceCounter++;
                }
            }
            // Search for RgbTape device
            deviceCounter = MainConstants.ZERO;
            if (cbUsbDevicesList.Items.Count > 0)
            {
                while (deviceCounter < cbUsbDevicesList.Items.Count)
                {
                    serialPortSmartHome.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    if (serialPortRgbTape.IsOpen == false) toolStripStatusLabel1.Text = serialPortRgbTape.PortName = ports[deviceCounter].ToString();
                    try
                    {
                        if (serialPortRgbTape.IsOpen == false)
                        {
                            serialPortRgbTape.Open();
                            SendStringToDevice("RGB_TAPE", MainConstants.DEV_RGB_TAPE_ID);
                            if (rgbTapePortOpenFlag == false) serialPortRgbTape.Close();
                        }
                    }
                    catch
                    {
                        rgbTapePortOpenFlag = false;
                        tsStatusLabelRgbTape.Text = "FAIL !";
                        serialPortRgbTape.Close();
                        //                        MessageBox.Show("Can't Open Port !!!");
                    }
                    deviceCounter++;
                }
            }
        }

        private void numericUpDown_EncoderValue(object sender, MouseEventArgs e)
        {
            if (sender == nudEncoder1) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_ENC1_COUNTER, Convert.ToInt32(Math.Round(nudEncoder1.Value, 0)), MainConstants.DEV_SMART_HOME_ID);
            else if (sender == nudEncoder0) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_ENC0_COUNTER, Convert.ToInt32(Math.Round(nudEncoder0.Value, 0)), MainConstants.DEV_SMART_HOME_ID);

            btnSaveCfg.Enabled = true;
        }

        public void ProcessDeviceRegister(int regNumber)
        {
            switch (regNumber)
            {
                case SmartHomeDeviceConstants.REG_CMD_GPIO_STATUS: ProcessGpioStatusRegister(deviceRegister[regNumber - 1]); break;
                case SmartHomeDeviceConstants.REG_CMD_ENC0_COUNTER: ProcessEncoderRegister(deviceRegister[regNumber - 1]); break;
                case SmartHomeDeviceConstants.REG_CMD_GET_SENSORS: ProcessSensorRegister(deviceRegister[regNumber - 1]); break;
            }
        }

        public void ProcessSensorRegister(int reg_data)
        {
            btnSensor0.BackColor = (reg_data & 0x01) == 0x01 ? Color.Red : Color.Black;
            btnSensor1.BackColor = (reg_data & 0x02) == 0x01 ? Color.Red : Color.Black;
            btnSensor2.BackColor = (reg_data & 0x04) == 0x01 ? Color.Red : Color.Black;
            btnSensor3.BackColor = (reg_data & 0x08) == 0x01 ? Color.Red : Color.Black;
            btnSensor4.BackColor = (reg_data & 0x10) == 0x01 ? Color.Red : Color.Black;
            btnSensor5.BackColor = (reg_data & 0x20) == 0x01 ? Color.Red : Color.Black;
            btnSensor6.BackColor = (reg_data & 0x40) == 0x01 ? Color.Red : Color.Black;
            btnSensor7.BackColor = (reg_data & 0x80) == 0x01 ? Color.Red : Color.Black;
        }

        public void ProcessEncoderRegister(int regData)
        {
            this.nudEncoder0.Invoke((MethodInvoker)delegate
            {
                nudEncoder0.Value = regData;
            });
        }

        public void ProcessGpioStatusRegister(int regData)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (((regData >> 7) & 0x01) == 1) cbStatusPin7.Checked = true; else cbStatusPin7.Checked = false;
                if (((regData >> 6) & 0x01) == 1) cbStatusPin6.Checked = true; else cbStatusPin6.Checked = false;
                if (((regData >> 5) & 0x01) == 1) cbStatusPin5.Checked = true; else cbStatusPin5.Checked = false;
                if (((regData >> 4) & 0x01) == 1) cbStatusPin4.Checked = true; else cbStatusPin4.Checked = false;
                if (((regData >> 3) & 0x01) == 1) cbStatusPin3.Checked = true; else cbStatusPin3.Checked = false;
                if (((regData >> 2) & 0x01) == 1) cbStatusPin2.Checked = true; else cbStatusPin2.Checked = false;
                if (((regData >> 1) & 0x01) == 1) cbStatusPin1.Checked = true; else cbStatusPin1.Checked = false;
                if ((regData & 0x01) == 1) cbStatusPin0.Checked = true; else cbStatusPin0.Checked = false;
            });
        }

        //
        // Parse incoming CONFIG values and set equalent properties in View objects on Form
        //
        public void ParsingSmartHomeConfigString(string[] words)
        {
            smartHomeModel.currentDeviceStatus = byte.Parse(words[1], System.Globalization.NumberStyles.HexNumber); // Current tm1638 ports status
            smartHomeModel.sleepModeMask = byte.Parse(words[2], System.Globalization.NumberStyles.HexNumber); // SleepMode mask
            smartHomeModel.hotButtonMask = byte.Parse(words[3], System.Globalization.NumberStyles.HexNumber); // Hot button mask
            smartHomeModel.smartHomeBeepString = byte.Parse(words[7], System.Globalization.NumberStyles.HexNumber); // Beeps settings
            ProcessSensorRegister(byte.Parse(words[8], System.Globalization.NumberStyles.HexNumber));

            this.Invoke((MethodInvoker)delegate
            {
                nudEncoder0.Value = int.Parse(words[4], System.Globalization.NumberStyles.HexNumber); // People in room counter / encoder0
                nudEncoder1.Value = int.Parse(words[5], System.Globalization.NumberStyles.HexNumber); // People in out room counter / encoder1
                numericUpDownSleepModeTimeout.Value = int.Parse(words[6], System.Globalization.NumberStyles.HexNumber);  // words[3] Timeout for sleep mode

                if (((smartHomeModel.currentDeviceStatus >> 7) & 0x01) == 1) cbStatusPin7.Checked = true; else cbStatusPin7.Checked = false;
                if (((smartHomeModel.currentDeviceStatus >> 6) & 0x01) == 1) cbStatusPin6.Checked = true; else cbStatusPin6.Checked = false;
                if (((smartHomeModel.currentDeviceStatus >> 5) & 0x01) == 1) cbStatusPin5.Checked = true; else cbStatusPin5.Checked = false;
                if (((smartHomeModel.currentDeviceStatus >> 4) & 0x01) == 1) cbStatusPin4.Checked = true; else cbStatusPin4.Checked = false;
                if (((smartHomeModel.currentDeviceStatus >> 3) & 0x01) == 1) cbStatusPin3.Checked = true; else cbStatusPin3.Checked = false;
                if (((smartHomeModel.currentDeviceStatus >> 2) & 0x01) == 1) cbStatusPin2.Checked = true; else cbStatusPin2.Checked = false;
                if (((smartHomeModel.currentDeviceStatus >> 1) & 0x01) == 1) cbStatusPin1.Checked = true; else cbStatusPin1.Checked = false;
                if ((smartHomeModel.currentDeviceStatus & 0x01) == 1) cbStatusPin0.Checked = true; else cbStatusPin0.Checked = false;
                //
                // SleepMode Mask
                //
                if (((smartHomeModel.sleepModeMask >> 7) & 0x01) == 1) cbSleepModeMaskPin8.Checked = true; else cbSleepModeMaskPin8.Checked = false;
                if (((smartHomeModel.sleepModeMask >> 6) & 0x01) == 1) cbSleepModeMaskPin7.Checked = true; else cbSleepModeMaskPin7.Checked = false;
                if (((smartHomeModel.sleepModeMask >> 5) & 0x01) == 1) cbSleepModeMaskPin6.Checked = true; else cbSleepModeMaskPin6.Checked = false;
                if (((smartHomeModel.sleepModeMask >> 4) & 0x01) == 1) cbSleepModeMaskPin5.Checked = true; else cbSleepModeMaskPin5.Checked = false;
                if (((smartHomeModel.sleepModeMask >> 3) & 0x01) == 1) cbSleepModeMaskPin4.Checked = true; else cbSleepModeMaskPin4.Checked = false;
                if (((smartHomeModel.sleepModeMask >> 2) & 0x01) == 1) cbSleepModeMaskPin3.Checked = true; else cbSleepModeMaskPin3.Checked = false;
                if (((smartHomeModel.sleepModeMask >> 1) & 0x01) == 1) cbSleepModeMaskPin2.Checked = true; else cbSleepModeMaskPin2.Checked = false;
                if ((smartHomeModel.sleepModeMask & 0x01) == 1) cbSleepModeMaskPin1.Checked = true; else cbSleepModeMaskPin1.Checked = false;
                //
                // Hot button mask
                //
                cbHotButtonMask1.Checked = (smartHomeModel.hotButtonMask & 0x01) == 0x01 ? true : false;
                cbHotButtonMask2.Checked = ((smartHomeModel.smartHomeBeepString & 0x02) >> 1) == 0x01 ? true : false;
                cbHotButtonMask3.Checked = ((smartHomeModel.smartHomeBeepString & 0x04) >> 2) == 0x01 ? true : false;
                cbHotButtonMask4.Checked = ((smartHomeModel.smartHomeBeepString & 0x08) >> 3) == 0x01 ? true : false;
                cbHotButtonMask5.Checked = ((smartHomeModel.smartHomeBeepString & 0x10) >> 4) == 0x01 ? true : false;
                cbHotButtonMask6.Checked = ((smartHomeModel.smartHomeBeepString & 0x20) >> 5) == 0x01 ? true : false;
                cbHotButtonMask7.Checked = ((smartHomeModel.smartHomeBeepString & 0x40) >> 6) == 0x01 ? true : false;
                cbHotButtonMask8.Checked = ((smartHomeModel.smartHomeBeepString & 0x80) >> 7) == 0x01 ? true : false;

                cbBuzzerBit0.Checked = (smartHomeModel.smartHomeBeepString & 0x01) == 0x01 ? true : false;
                cbBuzzerBit1.Checked = ((smartHomeModel.smartHomeBeepString & 0x02) >> 1) == 0x01 ? true : false;
                cbBuzzerBit2.Checked = ((smartHomeModel.smartHomeBeepString & 0x04) >> 2) == 0x01 ? true : false;
                cbBuzzerBit3.Checked = ((smartHomeModel.smartHomeBeepString & 0x08) >> 3) == 0x01 ? true : false;
                cbBuzzerBit4.Checked = ((smartHomeModel.smartHomeBeepString & 0x10) >> 4) == 0x01 ? true : false;
                cbBuzzerBit5.Checked = ((smartHomeModel.smartHomeBeepString & 0x20) >> 5) == 0x01 ? true : false;
                cbBuzzerBit6.Checked = ((smartHomeModel.smartHomeBeepString & 0x40) >> 6) == 0x01 ? true : false;
            });
            //
            this.panelSleepGpio.Invoke((MethodInvoker)delegate { panelSleepGpio.Enabled = true; });
            this.panelHotGpio.Invoke((MethodInvoker)delegate { panelHotGpio.Enabled = true; });
            this.panelCurrentGpio.Invoke((MethodInvoker)delegate { panelCurrentGpio.Enabled = true; });
            this.gbSensorsState.Invoke((MethodInvoker)delegate { gbSensorsState.Enabled = true; });
            this.gbRegisterValues.Invoke((MethodInvoker)delegate { gbRegisterValues.Enabled = true; });
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
            if (cbStatusPin0.Checked) smartHomeModel.currentDeviceStatus |= 0x01; else smartHomeModel.currentDeviceStatus &= 0xFE;
            if (cbStatusPin1.Checked) smartHomeModel.currentDeviceStatus |= 0x02; else smartHomeModel.currentDeviceStatus &= 0xFD;
            if (cbStatusPin2.Checked) smartHomeModel.currentDeviceStatus |= 0x04; else smartHomeModel.currentDeviceStatus &= 0xFB;
            if (cbStatusPin3.Checked) smartHomeModel.currentDeviceStatus |= 0x08; else smartHomeModel.currentDeviceStatus &= 0xF7;
            if (cbStatusPin4.Checked) smartHomeModel.currentDeviceStatus |= 0x10; else smartHomeModel.currentDeviceStatus &= 0xEF;
            if (cbStatusPin5.Checked) smartHomeModel.currentDeviceStatus |= 0x20; else smartHomeModel.currentDeviceStatus &= 0xDF;
            if (cbStatusPin6.Checked) smartHomeModel.currentDeviceStatus |= 0x40; else smartHomeModel.currentDeviceStatus &= 0xBF;
            if (cbStatusPin7.Checked) smartHomeModel.currentDeviceStatus |= 0x80; else smartHomeModel.currentDeviceStatus &= 0x7F;

            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_GPIO_STATUS, smartHomeModel.currentDeviceStatus, MainConstants.DEV_SMART_HOME_ID);
        }

        private void checkBoxSleepModeMask_Click(object sender, EventArgs e)
        {
            if (cbSleepModeMaskPin1.Checked) smartHomeModel.sleepModeMask |= 0x01; else smartHomeModel.sleepModeMask &= 0xFE;
            if (cbSleepModeMaskPin2.Checked) smartHomeModel.sleepModeMask |= 0x02; else smartHomeModel.sleepModeMask &= 0xFD;
            if (cbSleepModeMaskPin4.Checked) smartHomeModel.sleepModeMask |= 0x08; else smartHomeModel.sleepModeMask &= 0xF7;
            if (cbSleepModeMaskPin5.Checked) smartHomeModel.sleepModeMask |= 0x10; else smartHomeModel.sleepModeMask &= 0xEF;
            if (cbSleepModeMaskPin6.Checked) smartHomeModel.sleepModeMask |= 0x20; else smartHomeModel.sleepModeMask &= 0xDF;
            if (cbSleepModeMaskPin7.Checked) smartHomeModel.sleepModeMask |= 0x40; else smartHomeModel.sleepModeMask &= 0xBF;
            if (cbSleepModeMaskPin8.Checked) smartHomeModel.sleepModeMask |= 0x80; else smartHomeModel.sleepModeMask &= 0x7F;

            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SLEEP_MASK, smartHomeModel.sleepModeMask, MainConstants.DEV_SMART_HOME_ID); // REG4 - SleepMode mask
            buttonSaveSmartHomeCfg.Enabled = true;
        }

        private void checkBoxHotButtonMask_Click(object sender, EventArgs e)
        {
            if (cbHotButtonMask1.Checked) smartHomeModel.hotButtonMask |= 0x01; else smartHomeModel.hotButtonMask &= 0xFE;
            if (cbHotButtonMask2.Checked) smartHomeModel.hotButtonMask |= 0x02; else smartHomeModel.hotButtonMask &= 0xFD;
            if (cbHotButtonMask3.Checked) smartHomeModel.hotButtonMask |= 0x04; else smartHomeModel.hotButtonMask &= 0xFB;
            if (cbHotButtonMask4.Checked) smartHomeModel.hotButtonMask |= 0x08; else smartHomeModel.hotButtonMask &= 0xF7;
            if (cbHotButtonMask5.Checked) smartHomeModel.hotButtonMask |= 0x10; else smartHomeModel.hotButtonMask &= 0xEF;
            if (cbHotButtonMask6.Checked) smartHomeModel.hotButtonMask |= 0x20; else smartHomeModel.hotButtonMask &= 0xDF;
            if (cbHotButtonMask7.Checked) smartHomeModel.hotButtonMask |= 0x40; else smartHomeModel.hotButtonMask &= 0xBF;
            if (cbHotButtonMask8.Checked) smartHomeModel.hotButtonMask |= 0x80; else smartHomeModel.hotButtonMask &= 0x7F;

            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_HOT_BUTTON_MASK, smartHomeModel.hotButtonMask, MainConstants.DEV_SMART_HOME_ID);
            buttonSaveSmartHomeCfg.Enabled = true;
        }
        //
        // RGB controller events and commands implements
        //
        private void SetRgbTapeBlynkMode(object sender, EventArgs e)
        {
            Int32 value1 = Convert.ToInt32(nudChannelNumber.Value);
            SendStringToDevice(value1.ToString() + ".2." + string.Format("{0:000}", Convert.ToInt32(nudRgbFreq.Value)), MainConstants.DEV_RGB_TAPE_ID);
        }

        private void numericUpDownRgbFreq_ValueChanged(object sender, EventArgs e)
        {
            SetRgbTapeBlynkMode(sender, e);
        }

        private void btnSendRgbCommand(object sender, EventArgs e)
        {
            SendStringToDevice(cbRgbSendString.Text, MainConstants.DEV_RGB_TAPE_ID);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SendStringToDevice(tbDataToSend.Text, MainConstants.DEV_RGB_TAPE_ID);
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {
            button3_Click_1(sender, e);
        }

        private void trackBarColor_Scroll(object sender, EventArgs e)
        {
            Int32 value = Convert.ToInt32(nudChannelNumber.Value);
            SendStringToDevice("CH" + value.ToString() + ":" + Utils.IntToHexString(tbRed.Value, 2) + Utils.IntToHexString(tbGreen.Value, 2) + Utils.IntToHexString(tbBlue.Value, 2), MainConstants.DEV_RGB_TAPE_ID);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            nudChannelNumber.Enabled = false;
            String a;
            Int32 value1 = Convert.ToInt32(nudChannelNumber.Value);
            Int32 value2 = Convert.ToInt32(nudRgbFreq.Value);

            if (value2 < 100) a = "0"; else a = null;

            SendStringToDevice(value1.ToString() + ".1." + a + value2.ToString(), MainConstants.DEV_RGB_TAPE_ID);
            SendStringToDevice("CH" + value1.ToString(), MainConstants.DEV_RGB_TAPE_ID);
            nudChannelNumber.Enabled = true;
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
                WriteLog(rtbLogger, RcvComName1 + indata);
            if (indata == "SMART_HOME")
            {
                smartHomePortOpenFlag = true;
                tsStatusLabelSmartHome.Text = "SMART_HOME CONNECTED";
                this.Invoke((MethodInvoker)delegate
                {
                    tsStatusLabelSmartHome.ForeColor = Color.Green;
                });
                SndComName1 = serialPortSmartHome.PortName + MainConstants.SEND_STRING;
                RcvComName1 = serialPortSmartHome.PortName + MainConstants.RECEIVE_STRING;
                WriteLog(rtbLogger, "Found: SmartHome device on physical port 1.");
                ReadConstantFromSmarthomeDevice();
            }
            if (smartHomePortOpenFlag)
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
                        deviceRegister[byte.Parse(words[0]) - 1] = Int16.Parse(words[1], System.Globalization.NumberStyles.HexNumber);
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
            WriteLog(rtbLogger, RcvComName2 + indata);
            if (indata == "RGB_TAPE")
            {
                rgbTapePortOpenFlag = true;
  //              this.Invoke((MethodInvoker)delegate
//                {
                    tsStatusLabelRgbTape.ForeColor = Color.Green;
//                });
                tsStatusLabelRgbTape.Text = "RGB_TAPE CONNECTED";
                SndComName2 = serialPortRgbTape.PortName + MainConstants.SEND_STRING;
                RcvComName2 = serialPortRgbTape.PortName + MainConstants.RECEIVE_STRING;

                this.panel5.Invoke((MethodInvoker)delegate
                {
                    panel5.Enabled = true;
                });
                WriteLog(rtbLogger, "Found: RGB_Tape device on physical port 2.");
                WriteLog(rtbLogger, "Scanning family devices on com ports complete...\n---\nWork started.");

                SendStringToDevice(RgbConstants.RGB_NORMAL_STATE_STRING,MainConstants.DEV_RGB_TAPE_ID);

//                this.labelUseAmbilight.Invoke((MethodInvoker)delegate
//                {
                    lblUseAmbilight.Enabled = true;
//                });
//                this.checkBoxAmbilight.Invoke((MethodInvoker)delegate
//                {
                    cbAmbilight.Enabled = true;
//                });
            }
            if (rgbTapePortOpenFlag)
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

        private void btnSaveRgbCfg_Click(object sender, EventArgs e)
        {
            SendStringToDevice("SAVE_CFG",MainConstants.DEV_RGB_TAPE_ID);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                rtbLogger.SelectionStart = rtbLogger.Text.Length;
                rtbLogger.ScrollToCaret(); // scroll it automatically
            }
        }

        void scanAudioDevices(int selectedIndex)
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
            formVlcPlayer.Stop();// .playlist.play();
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
                    this.rbFavoriteVlcPlayList.Invoke((MethodInvoker)delegate
                    {
                        if (rbMainVlcPlayList.Checked) rbFavoriteVlcPlayList.Checked = true; else rbMainVlcPlayList.Checked = true;
                    });
                    VlcPlaySelected(VlcConstants.CURRENT_ITEM);
                    break;
                case IRemoteConstants.TR_PHOTO:
                    if (rgbOffFlag == false)
                    {
                        SendStringToDevice(RgbConstants.RGB_OFF_STRING, MainConstants.DEV_RGB_TAPE_ID);
                        rgbOffFlag = true;
                    }
                    else
                    {
                        SendStringToDevice(RgbConstants.RGB_NORMAL_STATE_STRING, MainConstants.DEV_RGB_TAPE_ID);
                        rgbOffFlag = false;
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
                    if (cbUsedGpioForVlcMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_RESET_BITS_GPIO_STATUS, smartHomeModel.vlcDevicesMask, MainConstants.DEV_SMART_HOME_ID);
                    formVlcPlayer.Stop();
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
            ListBox lbUrls;
            ListBox lbTitles;
            Form1 mainForm = new Form1();

            if (!cbUseSlaveMonitor.Checked)
            {
                formVlcPlayer.setPoint(new Point(Convert.ToInt32(mainForm.Location.X + mainForm.Size.Width), Convert.ToInt32(mainForm.Location.Y)));
                if (cbUsedGpioForVlcMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SET_BITS_GPIO_STATUS, smartHomeModel.vlcDevicesMask & (~VlcConstants.VLC_MONITOR_MASK),MainConstants.DEV_SMART_HOME_ID); // switch ON. only Subwoofer
            }
            else
            {
                formVlcPlayer.setPoint(new Point(Convert.ToInt32(VlcConstants.VLC_LOCATION_X_SLAVE_MONITOR), Convert.ToInt32(mainForm.Location.Y)));
                if (cbUsedGpioForVlcMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SET_BITS_GPIO_STATUS, smartHomeModel.vlcDevicesMask, MainConstants.DEV_SMART_HOME_ID); // switch ON. Monitor only
            }

            if (rbMainVlcPlayList.Checked)
            {
                lbUrls = lbVlcPlaylistURLs;
                lbTitles = lbVlcPlaylistTitles;
            }
            else
            {
                lbUrls = lbVlcFavoriteURLs;
                lbTitles = lbVlcFavoriteTitles;
            }

            if (lbUrls.SelectedIndex == -1) lbUrls.SelectedIndex = 0;

            if (direction < 0)
            {
                if (lbUrls.SelectedIndex > 0) lbUrls.SelectedIndex--; else lbUrls.SelectedIndex = lbUrls.Items.Count - 1;
            }

            if (direction > 0)
            {
                if (lbUrls.SelectedIndex < lbUrls.Items.Count - 1) lbUrls.SelectedIndex++; else lbUrls.SelectedIndex = 0;
            }

            lbTitles.SelectedIndex = lbUrls.SelectedIndex;

            String str;
            if (rbMainVlcPlayList.Checked) str = "VlcMainPlaylist_CH" + lbVlcPlaylistTitles.SelectedIndex;
            else str = "VlcFavoritePlaylist_CH" + lbVlcFavoriteTitles.SelectedIndex;

            if (cbRememberChVol.Checked) vlcVolume = Convert.ToByte(RegKey.GetValue(str, VlcConstants.DEFAULT_VOLUME));
            else vlcVolume = VlcConstants.DEFAULT_VOLUME;

            formVlcPlayer.Show();
            formVlcPlayer.setListBox(lbUrls);
            formVlcPlayer.setFullScreen(checkBoxFullScreen.Checked);
            formVlcPlayer.Play();
            tbVlcVolume.Value = vlcVolume;
            formVlcPlayer.setVolume(vlcVolume);
        }

        private void VlcChangeVolume(int a)
        {

            String str;
            vlcVolume = (byte)formVlcPlayer.getVolume();

            switch (a)
            {
                case VlcConstants.ADD:
                    if (vlcVolume < 255) vlcVolume++;
                    break;
                case VlcConstants.DEC:
                    if (vlcVolume > 0) vlcVolume--;
                    break;
            }

            if (rbMainVlcPlayList.Checked)
            {
                //                this.Invoke((MethodInvoker)delegate
                //                {
                str = Convert.ToString(lbVlcPlaylistTitles.SelectedIndex);
                str = "VlcMainPlaylist_CH" + str;
                RegKey.SetValue(str, vlcVolume);
                //                });
            }
            else
            {
                str = Convert.ToString(lbVlcFavoriteTitles.SelectedIndex);
                str = "VlcFavoritePlaylist_CH" + str;
            }
            tbVlcVolume.Value = vlcVolume;
        }

        private void btnRescanDevices_Click(object sender, EventArgs e)
        {
            scanUsbDevices();
        }

        private void listBoxVlcPlayList_Click(object sender, EventArgs e)
        {
            lbVlcPlaylistURLs.SelectedIndex = lbVlcPlaylistTitles.SelectedIndex;
            rbMainVlcPlayList.Checked = true;
        }

        private void listBoxVlcFavoriteList_Click(object sender, EventArgs e)
        {
            lbVlcFavoriteURLs.SelectedIndex = lbVlcFavoriteTitles.SelectedIndex;
            rbFavoriteVlcPlayList.Checked = true;
        }

        private void buttonDeleteFromPlaylist_Click(object sender, EventArgs e)
        {
            if (lbVlcPlaylistTitles.SelectedIndex != -1)
            {
                int index = lbVlcPlaylistTitles.SelectedIndex;
                lbVlcPlaylistTitles.Items.RemoveAt(lbVlcPlaylistTitles.SelectedIndex);
                lbVlcPlaylistURLs.SelectedIndex = index;
                lbVlcPlaylistURLs.Items.RemoveAt(lbVlcPlaylistURLs.SelectedIndex);
            }
            else MessageBox.Show("Must select item !");
        }

        private void buttonOpenVlcPlayListDialog_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                VlcLoadAndFillListBox(openFileDialog1.FileName, lbVlcPlaylistURLs, lbVlcPlaylistTitles);
            }
        }

        private void saveVlcPlayList(string filename, ListBox lbTitles, ListBox lbUrls)
        {
            System.IO.File.Delete(filename);
            try
            {
                using (StreamWriter sr = new StreamWriter(filename, true, System.Text.Encoding.UTF8))
                {
                    sr.WriteLine("#EXTM3U https://hdbox.ws");
                    int lbIndex = 0;

                    while (lbIndex < lbTitles.Items.Count)
                    {
                        sr.WriteLine(lbTitles.Items[lbIndex]);
                        sr.WriteLine(lbUrls.Items[lbIndex]);
                        lbIndex++;
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
            SendStringToDevice(tbDataToSend.Text, MainConstants.DEV_SMART_HOME_ID);
        }

        private void listBoxVlcPlaylistTitles_MouseDown(object sender, MouseEventArgs e)
        {
            tsMenuItem.Enabled = true;
        }

        private void contextMenuStripPlaylist_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ListBox lbPlaylistItems = new ListBox();
            ListBox lbPlaylistUrls = new ListBox();
            string playlistUrls = "";

            this.Text = ((ListBox)((ContextMenuStrip)sender).SourceControl).Name.ToString() + e.ClickedItem.Text;

            switch (((ListBox)((ContextMenuStrip)sender).SourceControl).Name.ToString())
            {
                case VlcConstants.OBJECT_NAME_PLAYLIST:
                    lbPlaylistItems = lbVlcPlaylistTitles;
                    lbPlaylistUrls = lbVlcPlaylistURLs;
                    playlistUrls = mtbPlayListPath.Text;
                    break;
                case VlcConstants.OBJECT_NAME_FAVORITES:
                    lbPlaylistItems = lbVlcFavoriteTitles;
                    lbPlaylistUrls = lbVlcFavoriteURLs;
                    playlistUrls = mtbFavoriteListPath.Text;
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
                        saveVlcPlayList(playlistUrls, lbPlaylistItems, lbPlaylistUrls);
                    }
                    else MessageBox.Show("Must select item !");
                    break;
                case VlcConstants.ACTION_SAVE:
                    saveVlcPlayList(playlistUrls, lbPlaylistItems, lbPlaylistUrls);
                    break;
                case VlcConstants.ACTION_ADD_FAV:
                    lbVlcFavoriteTitles.Items.Add(lbPlaylistItems.Items[lbPlaylistItems.SelectedIndex]);
                    lbVlcFavoriteURLs.Items.Add(lbPlaylistUrls.Items[lbPlaylistItems.SelectedIndex]);
                    break;
            }
        }

        private void buttonLogFilePath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "log files | *.log";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mtbLogFilePath.Text = saveFileDialog1.FileName;
                btnSaveCfg.Enabled = true;
            }
        }

        private void buttonVlcPlayListPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "m3u files | *.m3u";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mtbPlayListPath.Text = openFileDialog1.FileName;
                btnSaveCfg.Enabled = true;
            }
        }

        private void buttonVlcFavoriteListPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "m3u files | *.m3u";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mtbFavoriteListPath.Text = openFileDialog1.FileName;
                btnSaveCfg.Enabled = true;
            }
        }

        private void buttonSaveCfg_Click_1(object sender, EventArgs e)
        {
            //Создание объекта, для работы с файлом
            INIManager manager = new INIManager(app_path + "smarthome.ini");
            //Получить значение по ключу name из секции main
//            string name = manager.GetPrivateString("PathSettings", "name");

            btnSaveCfg.Enabled = false;
            manager.WritePrivateString("PathSettings", "LogFile", mtbLogFilePath.Text);
            manager.WritePrivateString("PathSettings", "MainPlayList", mtbPlayListPath.Text);
            manager.WritePrivateString("PathSettings", "FavoritePlayList", mtbFavoriteListPath.Text);
        }

        private void buttonVlcStop_Click(object sender, EventArgs e)
        {
            //axVLCPlugin21.playlist.stop();
            if (cbUsedGpioForVlcMask.Checked) SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_RESET_BITS_GPIO_STATUS, smartHomeModel.vlcDevicesMask, MainConstants.DEV_SMART_HOME_ID); // Monitor, Subwoofer
            formVlcPlayer.Stop();
            formVlcPlayer.Hide();
        }

        private void axVLCPlugin21_MediaPlayerLengthChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerLengthChangedEvent e)
        {
            rtbVlcLog.BeginInvoke((MethodInvoker)(() => this.rtbVlcLog.AppendText("[" + DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss") + "] MediaPlayerLengthChanged\n")));
        }

        private void axVLCPlugin21_MediaPlayerStopAsyncDone(object sender, EventArgs e)
        {
            rtbVlcLog.BeginInvoke((MethodInvoker)(() => this.rtbVlcLog.AppendText("[" + DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss") + "] MediaPlayerStopAsyncDone\n")));
        }

        private void axVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            rtbVlcLog.BeginInvoke((MethodInvoker)(() => this.rtbVlcLog.AppendText("[" + DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss") + "] MediaPlayerEndReached\n")));
        }

        private void listBoxVlcPlaylistTitles_DoubleClick(object sender, EventArgs e)
        {
            rbMainVlcPlayList.Checked = true;
            VlcPlaySelected(VlcConstants.CURRENT_ITEM);
        }

        private void listBoxVlcFavoriteTitles_DoubleClick(object sender, EventArgs e)
        {
            rbFavoriteVlcPlayList.Checked = true;
            VlcPlaySelected(VlcConstants.CURRENT_ITEM);
        }

        private void GetAndSendColor()
        {
            POINT p;
            if (GetCursorPos(out p))
            {
                lblPixel.Text = Convert.ToString(p.X) + ";" + Convert.ToString(p.Y);
                IntPtr hDC = GetDC(IntPtr.Zero);
                p.X = MainConstants.AMBILIGHT_X;
                p.Y = MainConstants.AMBILIGHT_Y;
                uint pixel = GetPixel(hDC, p.X, p.Y);
                ReleaseDC(IntPtr.Zero, hDC);
                byte r = (byte)(pixel & 0x000000FF);
                byte g = (byte)((pixel & 0x0000FF00) >> 8);
                byte b = (byte)((pixel & 0x00FF0000) >> 16);
                SendStringToDevice("EFFECT_CONFIG:01.1.1.1." + r.ToString("X2") + "." + g.ToString("X2") + "." + b.ToString("X2") + ".00.00", MainConstants.DEV_RGB_TAPE_ID);
                lblRED.Text = r.ToString();
                lblGREEN.Text = g.ToString();
                lblBLUE.Text = b.ToString();
            }
        }

        private uint DominateColor()
        {
            uint color;
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            int canvasX = resolution.Width;
            int canvasY = resolution.Height;
            uint pixel;
            uint summaR = 0;
            uint summaG = 0;
            uint summaB = 0;
            int x = 0;
            int y = 0;
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
            summaR = summaR / 5000;
            summaG = summaG / 5000;
            summaB = summaB / 5000;
            color = summaB << 16 | summaG << 8 | summaR;

            return (color);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DominateColor();
            //GetAndSendColor();
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            if (btnMute.ImageIndex != 0) btnMute.ImageIndex = 0; else btnMute.ImageIndex = 1;

            formVlcPlayer.toggleMute();
        }

        private void timerAmbilight_Tick(object sender, EventArgs e)
        {
            GetAndSendColor();
        }

        private void checkBoxAmbilight_Click(object sender, EventArgs e)
        {
            if (cbAmbilight.Checked)
            {
                timerAmbilight.Start();

            }
            else
            {
                timerAmbilight.Stop();

            }
            btnSaveCfg.Enabled = true;
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
            grbVlcGpioSettings.Enabled = cbUsedGpioForVlcMask.Checked;
            checkVlcGpioMask();
        }

        public void checkVlcGpioMask()
        {
            if (grbVlcGpioSettings.Enabled) cbUsedGpioForVlcMask.ForeColor = SystemColors.ControlText;
            else cbUsedGpioForVlcMask.ForeColor = SystemColors.ControlDark;
        }

        private void buttonPlayPause_Click(object sender, EventArgs e)
        {
            flag_vlc_play = (1 - flag_vlc_play);
            buttonPlayPause.ImageIndex = 2 + (flag_vlc_play);
        }

        private void VlcMaskPinsToInt(object sender, EventArgs e)
        {
            if (cbVlcMaskPin0.Checked) smartHomeModel.vlcDevicesMask |= 0x01; else smartHomeModel.vlcDevicesMask &= 0xFE;
            if (cbVlcMaskPin1.Checked) smartHomeModel.vlcDevicesMask |= 0x02; else smartHomeModel.vlcDevicesMask &= 0xFD;
            if (cbVlcMaskPin2.Checked) smartHomeModel.vlcDevicesMask |= 0x04; else smartHomeModel.vlcDevicesMask &= 0xFB;
            if (cbVlcMaskPin3.Checked) smartHomeModel.vlcDevicesMask |= 0x08; else smartHomeModel.vlcDevicesMask &= 0xF7;
            if (cbVlcMaskPin4.Checked) smartHomeModel.vlcDevicesMask |= 0x10; else smartHomeModel.vlcDevicesMask &= 0xEF;
            if (cbVlcMaskPin5.Checked) smartHomeModel.vlcDevicesMask |= 0x12; else smartHomeModel.vlcDevicesMask &= 0xDF;
            if (cbVlcMaskPin6.Checked) smartHomeModel.vlcDevicesMask |= 0x14; else smartHomeModel.vlcDevicesMask &= 0xBF;
            if (cbVlcMaskPin7.Checked) smartHomeModel.vlcDevicesMask |= 0x18; else smartHomeModel.vlcDevicesMask &= 0x7F;
        }

        private void VlcMaskIntToCheckboxes()
        {
            if ((smartHomeModel.vlcDevicesMask & 0x01) == 0x01) cbVlcMaskPin0.Checked = true;
            if ((smartHomeModel.vlcDevicesMask & 0x02) == 0x02) cbVlcMaskPin1.Checked = true;
            if ((smartHomeModel.vlcDevicesMask & 0x04) == 0x04) cbVlcMaskPin2.Checked = true;
            if ((smartHomeModel.vlcDevicesMask & 0x08) == 0x08) cbVlcMaskPin3.Checked = true;
            if ((smartHomeModel.vlcDevicesMask & 0x10) == 0x10) cbVlcMaskPin4.Checked = true;
            if ((smartHomeModel.vlcDevicesMask & 0x20) == 0x20) cbVlcMaskPin5.Checked = true;
            if ((smartHomeModel.vlcDevicesMask & 0x40) == 0x40) cbVlcMaskPin6.Checked = true;
            if ((smartHomeModel.vlcDevicesMask & 0x80) == 0x80) cbVlcMaskPin7.Checked = true;
        }

        private void trackBarVlcVolume_ValueChanged(object sender, EventArgs e)
        {
            String str;

            vlcVolume = (byte)tbVlcVolume.Value;
            formVlcPlayer.setVolume(vlcVolume);

            if (cbRememberChVol.Checked)
            {
                if (rbMainVlcPlayList.Checked) str = "VlcMainPlaylist_CH" + lbVlcPlaylistTitles.SelectedIndex;
                else str = "VlcFavoritePlaylist_CH" + lbVlcFavoriteTitles.SelectedIndex;
            }
            else
            {
                str = "VlcPlayerVolume";
            }
            SendStringToDeviceBulk(RgbConstants.RGB_VLC_VOLUME_CHANGE_STRING, MainConstants.DEV_RGB_TAPE_ID); // команда эффект для RGB контроллера (описание в /doc)
            System.Threading.Thread.Sleep(1);

            RegKey.SetValue(str, vlcVolume);
        }

        private void checkBoxUseSlaveMonitor_Click(object sender, EventArgs e)
        {
            //buttonSaveCfg.Enabled = true;
            if (formVlcPlayer.getVlcState()) VlcPlaySelected(VlcConstants.CURRENT_ITEM);
            buttonSaveCfg_Click_1(sender, e);
        }

        private void buttonStartAudioStreamScan_Click(object sender, EventArgs e)
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
                waveIn = new WaveIn();
                waveIn.DeviceNumber = cbRenderDevices.SelectedIndex + 1; // Дефолтное устройство для записи (если оно имеется)
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
            btnStopRecord.Enabled = false;
            btnStartAudioStreamScan.Enabled = true;
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

            String rgbString = "CH0:";

            lblLowMax.Visible = lblMiddleMax.Visible = lblHighMax.Visible = false;

            int value = GetCalculateValueFromComplexValues((int)nudLowFreq.Value);
            if (value > 255)
            {
                value = 255;
                lblLowMax.Visible = true;
            }
            pbLowFreq.Value = value;
            String valueString = value.ToString("X2");
            tbLowFreq.Text = valueString;
            rgbString += valueString;

            value = GetCalculateValueFromComplexValues((int)nudMiddleFreq.Value );
            if (value > 255)
            {
                value = 255;
                lblMiddleMax.Visible = true;
            }
            pbMiddleFreq.Value = value;
            valueString = value.ToString("X2");
            tbMiddleFreq.Text = valueString;
            rgbString += valueString;

            value = GetCalculateValueFromComplexValues((int)nudHighFreq.Value);
            if (value > 255)
            {
                value = 255;
                lblHighMax.Visible = true;
            }
            pbHighFreq.Value = value;
            valueString = value.ToString("X2");
            textBoxHighFreq.Text = valueString;
            rgbString += valueString;

            SendStringToDevice(rgbString, MainConstants.DEV_RGB_TAPE_ID);

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

        private void cbSheduler_Click(object sender, EventArgs e)
        {
            gbSheduler.Enabled = cbSheduler.Checked;
            RegKey.SetValue("RgbUseSheduler", cbSheduler.Checked);
            timerRgbSheduler.Enabled = gbSheduler.Enabled;

            if (!timerAmbilight.Enabled) timerRgbSheduler.Start();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            int hour = 0;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (sender == btnColor00) hour = 0;
                if (sender == btnColor01) hour = 1;
                if (sender == btnColor02) hour = 2;
                if (sender == btnColor03) hour = 3;
                if (sender == btnColor04) hour = 4;
                if (sender == btnColor05) hour = 5;
                if (sender == btnColor06) hour = 6;
                if (sender == btnColor07) hour = 7;
                if (sender == btnColor08) hour = 8;
                if (sender == btnColor09) hour = 9;
                if (sender == btnColor10) hour = 10;
                if (sender == btnColor11) hour = 11;
                if (sender == btnColor12) hour = 12;
                if (sender == btnColor13) hour = 13;
                if (sender == btnColor14) hour = 14;
                if (sender == btnColor15) hour = 15;
                if (sender == btnColor16) hour = 16;
                if (sender == btnColor17) hour = 17;
                if (sender == btnColor18) hour = 18;
                if (sender == btnColor19) hour = 19;
                if (sender == btnColor20) hour = 20;
                if (sender == btnColor21) hour = 21;
                if (sender == btnColor22) hour = 22;
                if (sender == btnColor23) hour = 23;
            }
            Button button = (Button)sender;
            button.BackColor = colorDialog1.Color;
            rgbShedulerColorsArray[hour] = colorDialog1.Color;
            rgbStateFlag[hour] = false;

            RegKey.SetValue("RgbShedulerHour" + Convert.ToString(hour), colorDialog1.Color.R.ToString("X2") + colorDialog1.Color.G.ToString("X2") + colorDialog1.Color.B.ToString("X2"));
        }

        private void timerRgbSheduler_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            if (!rgbStateFlag[hour])
            {
                string rgbString = "EFFECT_CONFIG:01.1.1.1."; //FF.00.00.00.20";
                rgbString += rgbShedulerColorsArray[hour].R.ToString("X2") + ".";
                rgbString += rgbShedulerColorsArray[hour].G.ToString("X2") + ".";
                rgbString += rgbShedulerColorsArray[hour].B.ToString("X2") + ".";
                rgbString += "70.00";
                SendStringToDevice(rgbString, MainConstants.DEV_RGB_TAPE_ID);

                rgbStateFlag[hour] = true;
                if (hour > 0) rgbStateFlag[hour - 1] = false;
                else if (hour == 0) rgbStateFlag[23] = false;
            }
        }

        private void SetButtonColors(int button_num, string color_string)
        {
            byte red = byte.Parse(color_string.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte green = byte.Parse(color_string.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte blue = byte.Parse(color_string.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            rgbShedulerColorsArray[button_num] = Color.FromArgb(255, red, green, blue);

            switch (button_num)
            {
                case 0: btnColor00.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 1: btnColor01.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 2: btnColor02.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 3: btnColor03.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 4: btnColor04.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 5: btnColor05.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 6: btnColor06.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 7: btnColor07.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 8: btnColor08.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 9: btnColor09.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 10: btnColor10.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 11: btnColor11.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 12: btnColor12.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 13: btnColor13.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 14: btnColor14.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 15: btnColor15.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 16: btnColor16.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 17: btnColor17.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 18: btnColor18.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 19: btnColor19.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 20: btnColor20.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 21: btnColor21.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 22: btnColor22.BackColor = rgbShedulerColorsArray[button_num]; break;
                case 23: btnColor23.BackColor = rgbShedulerColorsArray[button_num]; break;
            }
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
                rtbLogger.Text = "COMx\n";
                tsStatusLabelRgbTape.Text = "FAIL !";
                smartHomePortOpenFlag = false;
            }
        }

        private void checkBoxBuzzerBits_Click(object sender, EventArgs e)
        {
            if (cbBuzzerBit0.Checked) smartHomeModel.smartHomeBeepString |= 0x01; else smartHomeModel.smartHomeBeepString &= 0xFE; // enc0
            if (cbBuzzerBit1.Checked) smartHomeModel.smartHomeBeepString |= 0x02; else smartHomeModel.smartHomeBeepString &= 0xFD; // enc1
            if (cbBuzzerBit2.Checked) smartHomeModel.smartHomeBeepString |= 0x04; else smartHomeModel.smartHomeBeepString &= 0xFB; // keyboard
            if (cbBuzzerBit3.Checked) smartHomeModel.smartHomeBeepString |= 0x08; else smartHomeModel.smartHomeBeepString &= 0xF7; // remote
            if (cbBuzzerBit4.Checked) smartHomeModel.smartHomeBeepString |= 0x10; else smartHomeModel.smartHomeBeepString &= 0xEF; // uart in
            if (cbBuzzerBit5.Checked) smartHomeModel.smartHomeBeepString |= 0x20; else smartHomeModel.smartHomeBeepString &= 0xDF; // usb in
            if (cbBuzzerBit6.Checked) smartHomeModel.smartHomeBeepString |= 0x40; else smartHomeModel.smartHomeBeepString &= 0xBF; // use door sensor
            buttonSaveSmartHomeCfg.Enabled = true;
            SendRegToDevice(SmartHomeDeviceConstants.REG_CMD_SET_FLAGS, smartHomeModel.smartHomeBeepString, MainConstants.DEV_SMART_HOME_ID);
        }

        private void buttonStopRecord_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("StopRecording");

            waveIn.StopRecording();
        }
    }
}