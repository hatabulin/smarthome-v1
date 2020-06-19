namespace SmartHome_v1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SERIALPORT_SmartHome = new System.IO.Ports.SerialPort(this.components);
            this.COMBOX_UsbDevicesList = new System.Windows.Forms.ComboBox();
            this.RTBOX_Logger = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TOOLSTRIP_StatusLabelSmartHome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatusLabelRgbTape = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStripPlaylist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownSleepModeTimeout = new System.Windows.Forms.NumericUpDown();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSmartHome = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbRegisterValues = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_Encoder1 = new System.Windows.Forms.NumericUpDown();
            this.NUD_Encoder0 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbBuzzerSettings = new System.Windows.Forms.GroupBox();
            this.CHBOX_BuzzerBit6 = new System.Windows.Forms.CheckBox();
            this.CHBOX_BuzzerBit4 = new System.Windows.Forms.CheckBox();
            this.CHBOX_BuzzerBit5 = new System.Windows.Forms.CheckBox();
            this.CHBOX_BuzzerBit3 = new System.Windows.Forms.CheckBox();
            this.CHBOX_BuzzerBit2 = new System.Windows.Forms.CheckBox();
            this.CHBOX_BuzzerBit1 = new System.Windows.Forms.CheckBox();
            this.CHBOX_BuzzerBit0 = new System.Windows.Forms.CheckBox();
            this.buttonSaveSmartHomeCfg = new System.Windows.Forms.Button();
            this.gbSensorsState = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BTN_Sensor7 = new System.Windows.Forms.Button();
            this.BTN_Sensor6 = new System.Windows.Forms.Button();
            this.BTN_Sensor5 = new System.Windows.Forms.Button();
            this.BTN_Sensor4 = new System.Windows.Forms.Button();
            this.BTN_Sensor3 = new System.Windows.Forms.Button();
            this.BTN_Sensor2 = new System.Windows.Forms.Button();
            this.BTN_Sensor1 = new System.Windows.Forms.Button();
            this.BTN_Sensor0 = new System.Windows.Forms.Button();
            this.buttonSendDataToDevice = new System.Windows.Forms.Button();
            this.tbDataToSend = new System.Windows.Forms.TextBox();
            this.panelCurrentGpio = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CHBOX_StatusPin7 = new System.Windows.Forms.CheckBox();
            this.CHBOX_StatusPin0 = new System.Windows.Forms.CheckBox();
            this.CHBOX_StatusPin6 = new System.Windows.Forms.CheckBox();
            this.CHBOX_StatusPin1 = new System.Windows.Forms.CheckBox();
            this.CHBOX_StatusPin5 = new System.Windows.Forms.CheckBox();
            this.CHBOX_StatusPin2 = new System.Windows.Forms.CheckBox();
            this.CHBOX_StatusPin4 = new System.Windows.Forms.CheckBox();
            this.CHBOX_StatusPin3 = new System.Windows.Forms.CheckBox();
            this.panelHotGpio = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CHBOX_HotButtonMask8 = new System.Windows.Forms.CheckBox();
            this.CHBOX_HotButtonMask1 = new System.Windows.Forms.CheckBox();
            this.CHBOX_HotButtonMask7 = new System.Windows.Forms.CheckBox();
            this.CHBOX_HotButtonMask2 = new System.Windows.Forms.CheckBox();
            this.CHBOX_HotButtonMask6 = new System.Windows.Forms.CheckBox();
            this.CHBOX_HotButtonMask3 = new System.Windows.Forms.CheckBox();
            this.CHBOX_HotButtonMask5 = new System.Windows.Forms.CheckBox();
            this.CHBOX_HotButtonMask4 = new System.Windows.Forms.CheckBox();
            this.panelSleepGpio = new System.Windows.Forms.Panel();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.CHBOX_SleepModeMaskPin8 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CHBOX_SleepModeMaskPin1 = new System.Windows.Forms.CheckBox();
            this.CHBOX_SleepModeMaskPin7 = new System.Windows.Forms.CheckBox();
            this.CHBOX_SleepModeMaskPin2 = new System.Windows.Forms.CheckBox();
            this.CHBOX_SleepModeMaskPin6 = new System.Windows.Forms.CheckBox();
            this.CHBOX_SleepModeMaskPin3 = new System.Windows.Forms.CheckBox();
            this.CHBOX_SleepModeMaskPin5 = new System.Windows.Forms.CheckBox();
            this.CHBOX_SleepModeMaskPin4 = new System.Windows.Forms.CheckBox();
            this.tabPageRGB = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.lblBLUE = new System.Windows.Forms.Label();
            this.CHBOX_Ambilight = new System.Windows.Forms.CheckBox();
            this.gbSheduler = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.BTN_Color15 = new System.Windows.Forms.Button();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.BTN_Color12 = new System.Windows.Forms.Button();
            this.BTN_Color13 = new System.Windows.Forms.Button();
            this.BTN_Color14 = new System.Windows.Forms.Button();
            this.BTN_Color16 = new System.Windows.Forms.Button();
            this.BTN_Color17 = new System.Windows.Forms.Button();
            this.BTN_Color18 = new System.Windows.Forms.Button();
            this.BTN_Color19 = new System.Windows.Forms.Button();
            this.BTN_Color20 = new System.Windows.Forms.Button();
            this.BTN_Color21 = new System.Windows.Forms.Button();
            this.btnColor22 = new System.Windows.Forms.Button();
            this.btnColor23 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.BTN_Color03 = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BTN_Color00 = new System.Windows.Forms.Button();
            this.BTN_Color01 = new System.Windows.Forms.Button();
            this.BTN_Color02 = new System.Windows.Forms.Button();
            this.BTN_Color04 = new System.Windows.Forms.Button();
            this.BTN_Color05 = new System.Windows.Forms.Button();
            this.BTN_Color06 = new System.Windows.Forms.Button();
            this.BTN_Color07 = new System.Windows.Forms.Button();
            this.BTN_Color08 = new System.Windows.Forms.Button();
            this.BTN_Color09 = new System.Windows.Forms.Button();
            this.BTN_Color10 = new System.Windows.Forms.Button();
            this.BTN_Color11 = new System.Windows.Forms.Button();
            this.CHBOX_Sheduler = new System.Windows.Forms.CheckBox();
            this.btnGetDesktopColor = new System.Windows.Forms.Button();
            this.lblGREEN = new System.Windows.Forms.Label();
            this.COMBOX_RgbSendString = new System.Windows.Forms.ComboBox();
            this.lblRED = new System.Windows.Forms.Label();
            this.lblUseAmbilight = new System.Windows.Forms.Label();
            this.lblPixel = new System.Windows.Forms.Label();
            this.btnSaveRgbCfg = new System.Windows.Forms.Button();
            this.nudChannelNumber = new System.Windows.Forms.NumericUpDown();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.nudRgbFreq = new System.Windows.Forms.NumericUpDown();
            this.btnBlynkMode = new System.Windows.Forms.Button();
            this.btnNormalMode = new System.Windows.Forms.Button();
            this.tabPageVLC = new System.Windows.Forms.TabPage();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxFullScreen = new System.Windows.Forms.CheckBox();
            this.lblFullScreen = new System.Windows.Forms.Label();
            this.CHBOX_RememberChVol = new System.Windows.Forms.CheckBox();
            this.MTB_PlayListPath = new System.Windows.Forms.MaskedTextBox();
            this.GRBOX_VlcGpioSettings = new System.Windows.Forms.GroupBox();
            this.cbVlcMaskPin1 = new System.Windows.Forms.CheckBox();
            this.cbVlcMaskPin7 = new System.Windows.Forms.CheckBox();
            this.cbVlcMaskPin0 = new System.Windows.Forms.CheckBox();
            this.CHBOX_UsedGpioForVlcMask = new System.Windows.Forms.CheckBox();
            this.cbVlcMaskPin6 = new System.Windows.Forms.CheckBox();
            this.cbVlcMaskPin2 = new System.Windows.Forms.CheckBox();
            this.cbVlcMaskPin5 = new System.Windows.Forms.CheckBox();
            this.cbVlcMaskPin3 = new System.Windows.Forms.CheckBox();
            this.cbVlcMaskPin4 = new System.Windows.Forms.CheckBox();
            this.MTB_FavoriteListPath = new System.Windows.Forms.MaskedTextBox();
            this.buttonVlcFavoriteListPath = new System.Windows.Forms.Button();
            this.buttonVlcPlayListPath = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRememberVolumes = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblUseSlaveMonitor = new System.Windows.Forms.Label();
            this.CHBOX_UseSlaveMonitor = new System.Windows.Forms.CheckBox();
            this.RBTN_MainVlcPlayList = new System.Windows.Forms.RadioButton();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BTN_Mute = new System.Windows.Forms.Button();
            this.TXTBOX_VlcVolume = new System.Windows.Forms.TrackBar();
            this.buttonVlcStop = new System.Windows.Forms.Button();
            this.rtbVlcLog = new System.Windows.Forms.RichTextBox();
            this.RBTN_FavoriteVlcPlayList = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.LBOX_VlcPlaylistURLs = new System.Windows.Forms.ListBox();
            this.LBOX_VlcFavoriteURLs = new System.Windows.Forms.ListBox();
            this.LISTB_VlcFavoriteTitles = new System.Windows.Forms.ListBox();
            this.LISTB_VlcPlaylistTitles = new System.Windows.Forms.ListBox();
            this.tabPageAudio = new System.Windows.Forms.TabPage();
            this.pbHighFreq = new System.Windows.Forms.ProgressBar();
            this.pbMiddleFreq = new System.Windows.Forms.ProgressBar();
            this.lblHighMax = new System.Windows.Forms.Label();
            this.lblMiddleMax = new System.Windows.Forms.Label();
            this.lblLowMax = new System.Windows.Forms.Label();
            this.pbLowFreq = new System.Windows.Forms.ProgressBar();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.nudHighFreq = new System.Windows.Forms.NumericUpDown();
            this.nudMiddleFreq = new System.Windows.Forms.NumericUpDown();
            this.nudLowFreq = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxHighFreq = new System.Windows.Forms.TextBox();
            this.tbMiddleFreq = new System.Windows.Forms.TextBox();
            this.tbLowFreq = new System.Windows.Forms.TextBox();
            this.btnStopRecord = new System.Windows.Forms.Button();
            this.btnStartAudioStreamScan = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbRenderDevices = new System.Windows.Forms.ComboBox();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.tabPageLogger = new System.Windows.Forms.TabPage();
            this.MTB_LogFilePath = new System.Windows.Forms.MaskedTextBox();
            this.buttonLogFilePath = new System.Windows.Forms.Button();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabPageESP8266 = new System.Windows.Forms.TabPage();
            this.tabPageScales = new System.Windows.Forms.TabPage();
            this.button21 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button10 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPagePostMan = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.COMBOX_HttpMethod = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.TBOX_HttpMethod = new System.Windows.Forms.TextBox();
            this.tabPageCAM = new System.Windows.Forms.TabPage();
            this.btnRescanDevices = new System.Windows.Forms.Button();
            this.SERIALPORT_RgbTape = new System.IO.Ports.SerialPort(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.serialPortScales = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TMR_Ambilight = new System.Windows.Forms.Timer(this.components);
            this.timerRgbSheduler = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSleepModeTimeout)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageSmartHome.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbRegisterValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Encoder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Encoder0)).BeginInit();
            this.gbBuzzerSettings.SuspendLayout();
            this.gbSensorsState.SuspendLayout();
            this.panelCurrentGpio.SuspendLayout();
            this.panelHotGpio.SuspendLayout();
            this.panelSleepGpio.SuspendLayout();
            this.tabPageRGB.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbSheduler.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChannelNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbFreq)).BeginInit();
            this.tabPageVLC.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GRBOX_VlcGpioSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTBOX_VlcVolume)).BeginInit();
            this.tabPageAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiddleFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowFreq)).BeginInit();
            this.tabPageLogger.SuspendLayout();
            this.tabPageScales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            this.tabPagePostMan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SERIALPORT_SmartHome
            // 
            this.SERIALPORT_SmartHome.BaudRate = 115200;
            this.SERIALPORT_SmartHome.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortSmartHomeDevice_DataReceived);
            // 
            // COMBOX_UsbDevicesList
            // 
            this.COMBOX_UsbDevicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.COMBOX_UsbDevicesList.FormattingEnabled = true;
            this.COMBOX_UsbDevicesList.Location = new System.Drawing.Point(6, 28);
            this.COMBOX_UsbDevicesList.Name = "COMBOX_UsbDevicesList";
            this.COMBOX_UsbDevicesList.Size = new System.Drawing.Size(97, 24);
            this.COMBOX_UsbDevicesList.TabIndex = 5;
            this.COMBOX_UsbDevicesList.Text = "<select>";
            this.COMBOX_UsbDevicesList.Visible = false;
            // 
            // RTBOX_Logger
            // 
            this.RTBOX_Logger.Location = new System.Drawing.Point(3, 6);
            this.RTBOX_Logger.Name = "RTBOX_Logger";
            this.RTBOX_Logger.Size = new System.Drawing.Size(743, 256);
            this.RTBOX_Logger.TabIndex = 7;
            this.RTBOX_Logger.Text = "";
            this.RTBOX_Logger.TextChanged += new System.EventHandler(this.RTB_Logger_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel3,
            this.TOOLSTRIP_StatusLabelSmartHome,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.tsStatusLabelRgbTape,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 368);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 27);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 21);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Navy;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(44, 22);
            this.toolStripStatusLabel3.Text = "COMx:";
            // 
            // TOOLSTRIP_StatusLabelSmartHome
            // 
            this.TOOLSTRIP_StatusLabelSmartHome.ForeColor = System.Drawing.Color.Red;
            this.TOOLSTRIP_StatusLabelSmartHome.Name = "TOOLSTRIP_StatusLabelSmartHome";
            this.TOOLSTRIP_StatusLabelSmartHome.Size = new System.Drawing.Size(52, 22);
            this.TOOLSTRIP_StatusLabelSmartHome.Text = "OFFLINE";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Navy;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripStatusLabel1.Text = "COMx:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 22);
            // 
            // tsStatusLabelRgbTape
            // 
            this.tsStatusLabelRgbTape.ForeColor = System.Drawing.Color.Red;
            this.tsStatusLabelRgbTape.Name = "tsStatusLabelRgbTape";
            this.tsStatusLabelRgbTape.Size = new System.Drawing.Size(52, 22);
            this.tsStatusLabelRgbTape.Text = "OFFLINE";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.ForeColor = System.Drawing.Color.Navy;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(44, 22);
            this.toolStripStatusLabel6.Text = "COMx:";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(52, 22);
            this.toolStripStatusLabel7.Text = "OFFLINE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(91, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Device answer:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStripPlaylist
            // 
            this.contextMenuStripPlaylist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.tsMenuItem,
            this.сохранитьToolStripMenuItem});
            this.contextMenuStripPlaylist.Name = "contextMenuStripPlaylist";
            this.contextMenuStripPlaylist.Size = new System.Drawing.Size(200, 70);
            this.contextMenuStripPlaylist.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStripPlaylist_ItemClicked);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // tsMenuItem
            // 
            this.tsMenuItem.Enabled = false;
            this.tsMenuItem.Name = "tsMenuItem";
            this.tsMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tsMenuItem.Text = "Добавить в избранные";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // numericUpDownSleepModeTimeout
            // 
            this.numericUpDownSleepModeTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSleepModeTimeout.Location = new System.Drawing.Point(258, 24);
            this.numericUpDownSleepModeTimeout.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownSleepModeTimeout.Name = "numericUpDownSleepModeTimeout";
            this.numericUpDownSleepModeTimeout.Size = new System.Drawing.Size(35, 22);
            this.numericUpDownSleepModeTimeout.TabIndex = 24;
            this.numericUpDownSleepModeTimeout.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSmartHome);
            this.tabControl.Controls.Add(this.tabPageRGB);
            this.tabControl.Controls.Add(this.tabPageVLC);
            this.tabControl.Controls.Add(this.tabPageAudio);
            this.tabControl.Controls.Add(this.tabPageLogger);
            this.tabControl.Controls.Add(this.tabPageESP8266);
            this.tabControl.Controls.Add(this.tabPageScales);
            this.tabControl.Controls.Add(this.tabPagePostMan);
            this.tabControl.Controls.Add(this.tabPageCAM);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControl.Location = new System.Drawing.Point(8, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(785, 358);
            this.tabControl.TabIndex = 25;
            // 
            // tabPageSmartHome
            // 
            this.tabPageSmartHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageSmartHome.Controls.Add(this.groupBox7);
            this.tabPageSmartHome.Controls.Add(this.gbRegisterValues);
            this.tabPageSmartHome.Controls.Add(this.gbBuzzerSettings);
            this.tabPageSmartHome.Controls.Add(this.buttonSaveSmartHomeCfg);
            this.tabPageSmartHome.Controls.Add(this.gbSensorsState);
            this.tabPageSmartHome.Controls.Add(this.buttonSendDataToDevice);
            this.tabPageSmartHome.Controls.Add(this.tbDataToSend);
            this.tabPageSmartHome.Controls.Add(this.panelCurrentGpio);
            this.tabPageSmartHome.Controls.Add(this.panelHotGpio);
            this.tabPageSmartHome.Controls.Add(this.panelSleepGpio);
            this.tabPageSmartHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageSmartHome.Location = new System.Drawing.Point(4, 25);
            this.tabPageSmartHome.Name = "tabPageSmartHome";
            this.tabPageSmartHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSmartHome.Size = new System.Drawing.Size(777, 329);
            this.tabPageSmartHome.TabIndex = 0;
            this.tabPageSmartHome.Text = "SmartHome device";
            this.tabPageSmartHome.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox);
            this.groupBox7.Controls.Add(this.checkBox11);
            this.groupBox7.Controls.Add(this.checkBox1);
            this.groupBox7.Location = new System.Drawing.Point(513, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(259, 144);
            this.groupBox7.TabIndex = 53;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // checkBox
            // 
            this.checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox.Enabled = false;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBox.Location = new System.Drawing.Point(6, 14);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(244, 48);
            this.checkBox.TabIndex = 45;
            this.checkBox.Text = "Запоминать состояние при аварийном отключении";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBox11.Location = new System.Drawing.Point(6, 89);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(213, 20);
            this.checkBox11.TabIndex = 52;
            this.checkBox11.Text = "Использовать датчик двери";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBox1.Location = new System.Drawing.Point(6, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 20);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = "Спящий режим";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gbRegisterValues
            // 
            this.gbRegisterValues.Controls.Add(this.label4);
            this.gbRegisterValues.Controls.Add(this.NUD_Encoder1);
            this.gbRegisterValues.Controls.Add(this.NUD_Encoder0);
            this.gbRegisterValues.Controls.Add(this.label3);
            this.gbRegisterValues.Controls.Add(this.label9);
            this.gbRegisterValues.Controls.Add(this.numericUpDownSleepModeTimeout);
            this.gbRegisterValues.Location = new System.Drawing.Point(344, 199);
            this.gbRegisterValues.Name = "gbRegisterValues";
            this.gbRegisterValues.Size = new System.Drawing.Size(304, 59);
            this.gbRegisterValues.TabIndex = 51;
            this.gbRegisterValues.TabStop = false;
            this.gbRegisterValues.Text = "Состояние регистров данных";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(98, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "энк.1";
            // 
            // NUD_Encoder1
            // 
            this.NUD_Encoder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NUD_Encoder1.Location = new System.Drawing.Point(145, 23);
            this.NUD_Encoder1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_Encoder1.Name = "NUD_Encoder1";
            this.NUD_Encoder1.Size = new System.Drawing.Size(36, 23);
            this.NUD_Encoder1.TabIndex = 42;
            this.NUD_Encoder1.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_Encoder1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_Encoder_EncoderValue);
            this.NUD_Encoder1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NUD_Encoder_EncoderValue);
            // 
            // NUD_Encoder0
            // 
            this.NUD_Encoder0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NUD_Encoder0.Location = new System.Drawing.Point(50, 23);
            this.NUD_Encoder0.Margin = new System.Windows.Forms.Padding(0);
            this.NUD_Encoder0.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_Encoder0.Name = "NUD_Encoder0";
            this.NUD_Encoder0.Size = new System.Drawing.Size(36, 23);
            this.NUD_Encoder0.TabIndex = 41;
            this.NUD_Encoder0.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_Encoder0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_Encoder_EncoderValue);
            this.NUD_Encoder0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NUD_Encoder_EncoderValue);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(187, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Таймаут";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "энк.0";
            // 
            // gbBuzzerSettings
            // 
            this.gbBuzzerSettings.Controls.Add(this.CHBOX_BuzzerBit6);
            this.gbBuzzerSettings.Controls.Add(this.CHBOX_BuzzerBit4);
            this.gbBuzzerSettings.Controls.Add(this.CHBOX_BuzzerBit5);
            this.gbBuzzerSettings.Controls.Add(this.CHBOX_BuzzerBit3);
            this.gbBuzzerSettings.Controls.Add(this.CHBOX_BuzzerBit2);
            this.gbBuzzerSettings.Controls.Add(this.CHBOX_BuzzerBit1);
            this.gbBuzzerSettings.Controls.Add(this.CHBOX_BuzzerBit0);
            this.gbBuzzerSettings.Location = new System.Drawing.Point(5, 258);
            this.gbBuzzerSettings.Name = "gbBuzzerSettings";
            this.gbBuzzerSettings.Size = new System.Drawing.Size(333, 66);
            this.gbBuzzerSettings.TabIndex = 50;
            this.gbBuzzerSettings.TabStop = false;
            this.gbBuzzerSettings.Text = "Настройка буззера";
            // 
            // CHBOX_BuzzerBit6
            // 
            this.CHBOX_BuzzerBit6.AutoSize = true;
            this.CHBOX_BuzzerBit6.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CHBOX_BuzzerBit6.Location = new System.Drawing.Point(291, 21);
            this.CHBOX_BuzzerBit6.Name = "CHBOX_BuzzerBit6";
            this.CHBOX_BuzzerBit6.Size = new System.Drawing.Size(51, 34);
            this.CHBOX_BuzzerBit6.TabIndex = 6;
            this.CHBOX_BuzzerBit6.Text = "дверь";
            this.CHBOX_BuzzerBit6.UseVisualStyleBackColor = true;
            this.CHBOX_BuzzerBit6.Click += new System.EventHandler(this.CHB_BuzzerBits_Click);
            // 
            // CHBOX_BuzzerBit4
            // 
            this.CHBOX_BuzzerBit4.AutoSize = true;
            this.CHBOX_BuzzerBit4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CHBOX_BuzzerBit4.Location = new System.Drawing.Point(191, 21);
            this.CHBOX_BuzzerBit4.Name = "CHBOX_BuzzerBit4";
            this.CHBOX_BuzzerBit4.Size = new System.Drawing.Size(34, 34);
            this.CHBOX_BuzzerBit4.TabIndex = 5;
            this.CHBOX_BuzzerBit4.Text = "uart";
            this.CHBOX_BuzzerBit4.UseVisualStyleBackColor = true;
            this.CHBOX_BuzzerBit4.Click += new System.EventHandler(this.CHB_BuzzerBits_Click);
            // 
            // CHBOX_BuzzerBit5
            // 
            this.CHBOX_BuzzerBit5.AutoSize = true;
            this.CHBOX_BuzzerBit5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CHBOX_BuzzerBit5.Location = new System.Drawing.Point(243, 21);
            this.CHBOX_BuzzerBit5.Name = "CHBOX_BuzzerBit5";
            this.CHBOX_BuzzerBit5.Size = new System.Drawing.Size(34, 34);
            this.CHBOX_BuzzerBit5.TabIndex = 4;
            this.CHBOX_BuzzerBit5.Text = "usb";
            this.CHBOX_BuzzerBit5.UseVisualStyleBackColor = true;
            this.CHBOX_BuzzerBit5.Click += new System.EventHandler(this.CHB_BuzzerBits_Click);
            // 
            // CHBOX_BuzzerBit3
            // 
            this.CHBOX_BuzzerBit3.AutoSize = true;
            this.CHBOX_BuzzerBit3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CHBOX_BuzzerBit3.Location = new System.Drawing.Point(126, 21);
            this.CHBOX_BuzzerBit3.Name = "CHBOX_BuzzerBit3";
            this.CHBOX_BuzzerBit3.Size = new System.Drawing.Size(71, 34);
            this.CHBOX_BuzzerBit3.TabIndex = 3;
            this.CHBOX_BuzzerBit3.Text = "пульт ДУ";
            this.CHBOX_BuzzerBit3.UseVisualStyleBackColor = true;
            this.CHBOX_BuzzerBit3.Click += new System.EventHandler(this.CHB_BuzzerBits_Click);
            // 
            // CHBOX_BuzzerBit2
            // 
            this.CHBOX_BuzzerBit2.AutoSize = true;
            this.CHBOX_BuzzerBit2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CHBOX_BuzzerBit2.Location = new System.Drawing.Point(86, 21);
            this.CHBOX_BuzzerBit2.Name = "CHBOX_BuzzerBit2";
            this.CHBOX_BuzzerBit2.Size = new System.Drawing.Size(58, 34);
            this.CHBOX_BuzzerBit2.TabIndex = 2;
            this.CHBOX_BuzzerBit2.Text = "кнопки";
            this.CHBOX_BuzzerBit2.UseVisualStyleBackColor = true;
            this.CHBOX_BuzzerBit2.Click += new System.EventHandler(this.CHB_BuzzerBits_Click);
            // 
            // CHBOX_BuzzerBit1
            // 
            this.CHBOX_BuzzerBit1.AutoSize = true;
            this.CHBOX_BuzzerBit1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CHBOX_BuzzerBit1.Location = new System.Drawing.Point(49, 21);
            this.CHBOX_BuzzerBit1.Name = "CHBOX_BuzzerBit1";
            this.CHBOX_BuzzerBit1.Size = new System.Drawing.Size(45, 34);
            this.CHBOX_BuzzerBit1.TabIndex = 1;
            this.CHBOX_BuzzerBit1.Text = "энк.1";
            this.CHBOX_BuzzerBit1.UseVisualStyleBackColor = true;
            this.CHBOX_BuzzerBit1.Click += new System.EventHandler(this.CHB_BuzzerBits_Click);
            // 
            // CHBOX_BuzzerBit0
            // 
            this.CHBOX_BuzzerBit0.AutoSize = true;
            this.CHBOX_BuzzerBit0.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CHBOX_BuzzerBit0.Location = new System.Drawing.Point(6, 21);
            this.CHBOX_BuzzerBit0.Name = "CHBOX_BuzzerBit0";
            this.CHBOX_BuzzerBit0.Size = new System.Drawing.Size(45, 34);
            this.CHBOX_BuzzerBit0.TabIndex = 0;
            this.CHBOX_BuzzerBit0.Text = "энк.0";
            this.CHBOX_BuzzerBit0.UseVisualStyleBackColor = true;
            this.CHBOX_BuzzerBit0.Click += new System.EventHandler(this.CHB_BuzzerBits_Click);
            // 
            // buttonSaveSmartHomeCfg
            // 
            this.buttonSaveSmartHomeCfg.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonSaveSmartHomeCfg.AutoSize = true;
            this.buttonSaveSmartHomeCfg.Enabled = false;
            this.buttonSaveSmartHomeCfg.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSmartHomeCfg.Image")));
            this.buttonSaveSmartHomeCfg.Location = new System.Drawing.Point(714, 299);
            this.buttonSaveSmartHomeCfg.Name = "buttonSaveSmartHomeCfg";
            this.buttonSaveSmartHomeCfg.Size = new System.Drawing.Size(35, 25);
            this.buttonSaveSmartHomeCfg.TabIndex = 49;
            this.buttonSaveSmartHomeCfg.UseVisualStyleBackColor = true;
            this.buttonSaveSmartHomeCfg.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // gbSensorsState
            // 
            this.gbSensorsState.Controls.Add(this.label38);
            this.gbSensorsState.Controls.Add(this.label37);
            this.gbSensorsState.Controls.Add(this.label36);
            this.gbSensorsState.Controls.Add(this.label35);
            this.gbSensorsState.Controls.Add(this.label34);
            this.gbSensorsState.Controls.Add(this.label33);
            this.gbSensorsState.Controls.Add(this.label32);
            this.gbSensorsState.Controls.Add(this.label10);
            this.gbSensorsState.Controls.Add(this.BTN_Sensor7);
            this.gbSensorsState.Controls.Add(this.BTN_Sensor6);
            this.gbSensorsState.Controls.Add(this.BTN_Sensor5);
            this.gbSensorsState.Controls.Add(this.BTN_Sensor4);
            this.gbSensorsState.Controls.Add(this.BTN_Sensor3);
            this.gbSensorsState.Controls.Add(this.BTN_Sensor2);
            this.gbSensorsState.Controls.Add(this.BTN_Sensor1);
            this.gbSensorsState.Controls.Add(this.BTN_Sensor0);
            this.gbSensorsState.Enabled = false;
            this.gbSensorsState.Location = new System.Drawing.Point(5, 199);
            this.gbSensorsState.Name = "gbSensorsState";
            this.gbSensorsState.Size = new System.Drawing.Size(333, 59);
            this.gbSensorsState.TabIndex = 48;
            this.gbSensorsState.TabStop = false;
            this.gbSensorsState.Text = "Состояние датчиков";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label38.Location = new System.Drawing.Point(292, 18);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(33, 16);
            this.label38.TabIndex = 33;
            this.label38.Text = "Вх.7";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label37.Location = new System.Drawing.Point(249, 18);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(33, 16);
            this.label37.TabIndex = 32;
            this.label37.Text = "Вх.6";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label36.Location = new System.Drawing.Point(198, 18);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(33, 16);
            this.label36.TabIndex = 31;
            this.label36.Text = "Вх.5";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label35.Location = new System.Drawing.Point(162, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(33, 16);
            this.label35.TabIndex = 30;
            this.label35.Text = "Вх.4";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label34.Location = new System.Drawing.Point(122, 18);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(33, 16);
            this.label34.TabIndex = 29;
            this.label34.Text = "Вх.3";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label33.Location = new System.Drawing.Point(82, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(33, 16);
            this.label33.TabIndex = 28;
            this.label33.Text = "Вх.2";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(46, 18);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(33, 16);
            this.label32.TabIndex = 27;
            this.label32.Text = "Вх.1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Вх.0";
            // 
            // BTN_Sensor7
            // 
            this.BTN_Sensor7.AutoSize = true;
            this.BTN_Sensor7.BackColor = System.Drawing.Color.Black;
            this.BTN_Sensor7.Location = new System.Drawing.Point(295, 33);
            this.BTN_Sensor7.Name = "BTN_Sensor7";
            this.BTN_Sensor7.Size = new System.Drawing.Size(20, 20);
            this.BTN_Sensor7.TabIndex = 7;
            this.BTN_Sensor7.UseVisualStyleBackColor = false;
            // 
            // BTN_Sensor6
            // 
            this.BTN_Sensor6.AutoSize = true;
            this.BTN_Sensor6.BackColor = System.Drawing.Color.Black;
            this.BTN_Sensor6.Location = new System.Drawing.Point(252, 33);
            this.BTN_Sensor6.Name = "BTN_Sensor6";
            this.BTN_Sensor6.Size = new System.Drawing.Size(20, 20);
            this.BTN_Sensor6.TabIndex = 6;
            this.BTN_Sensor6.UseVisualStyleBackColor = false;
            // 
            // BTN_Sensor5
            // 
            this.BTN_Sensor5.AutoSize = true;
            this.BTN_Sensor5.BackColor = System.Drawing.Color.Black;
            this.BTN_Sensor5.Location = new System.Drawing.Point(207, 33);
            this.BTN_Sensor5.Name = "BTN_Sensor5";
            this.BTN_Sensor5.Size = new System.Drawing.Size(20, 20);
            this.BTN_Sensor5.TabIndex = 5;
            this.BTN_Sensor5.UseVisualStyleBackColor = false;
            // 
            // BTN_Sensor4
            // 
            this.BTN_Sensor4.AutoSize = true;
            this.BTN_Sensor4.BackColor = System.Drawing.Color.Black;
            this.BTN_Sensor4.Location = new System.Drawing.Point(165, 33);
            this.BTN_Sensor4.Name = "BTN_Sensor4";
            this.BTN_Sensor4.Size = new System.Drawing.Size(20, 20);
            this.BTN_Sensor4.TabIndex = 4;
            this.BTN_Sensor4.UseVisualStyleBackColor = false;
            // 
            // BTN_Sensor3
            // 
            this.BTN_Sensor3.AutoSize = true;
            this.BTN_Sensor3.BackColor = System.Drawing.Color.Black;
            this.BTN_Sensor3.Location = new System.Drawing.Point(125, 33);
            this.BTN_Sensor3.Name = "BTN_Sensor3";
            this.BTN_Sensor3.Size = new System.Drawing.Size(20, 20);
            this.BTN_Sensor3.TabIndex = 3;
            this.BTN_Sensor3.UseVisualStyleBackColor = false;
            // 
            // BTN_Sensor2
            // 
            this.BTN_Sensor2.AutoSize = true;
            this.BTN_Sensor2.BackColor = System.Drawing.Color.Black;
            this.BTN_Sensor2.Location = new System.Drawing.Point(85, 33);
            this.BTN_Sensor2.Name = "BTN_Sensor2";
            this.BTN_Sensor2.Size = new System.Drawing.Size(20, 20);
            this.BTN_Sensor2.TabIndex = 2;
            this.BTN_Sensor2.UseVisualStyleBackColor = false;
            // 
            // BTN_Sensor1
            // 
            this.BTN_Sensor1.AutoSize = true;
            this.BTN_Sensor1.BackColor = System.Drawing.Color.Black;
            this.BTN_Sensor1.Location = new System.Drawing.Point(49, 33);
            this.BTN_Sensor1.Name = "BTN_Sensor1";
            this.BTN_Sensor1.Size = new System.Drawing.Size(20, 20);
            this.BTN_Sensor1.TabIndex = 1;
            this.BTN_Sensor1.UseVisualStyleBackColor = false;
            // 
            // BTN_Sensor0
            // 
            this.BTN_Sensor0.AutoSize = true;
            this.BTN_Sensor0.BackColor = System.Drawing.Color.Black;
            this.BTN_Sensor0.Location = new System.Drawing.Point(9, 33);
            this.BTN_Sensor0.Name = "BTN_Sensor0";
            this.BTN_Sensor0.Size = new System.Drawing.Size(20, 20);
            this.BTN_Sensor0.TabIndex = 0;
            this.BTN_Sensor0.UseVisualStyleBackColor = false;
            // 
            // buttonSendDataToDevice
            // 
            this.buttonSendDataToDevice.AutoSize = true;
            this.buttonSendDataToDevice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSendDataToDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonSendDataToDevice.Location = new System.Drawing.Point(618, 292);
            this.buttonSendDataToDevice.Name = "buttonSendDataToDevice";
            this.buttonSendDataToDevice.Size = new System.Drawing.Size(50, 26);
            this.buttonSendDataToDevice.TabIndex = 45;
            this.buttonSendDataToDevice.Text = "Send";
            this.buttonSendDataToDevice.UseVisualStyleBackColor = true;
            this.buttonSendDataToDevice.Click += new System.EventHandler(this.BTN_SendDataToDevice_Click);
            // 
            // tbDataToSend
            // 
            this.tbDataToSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbDataToSend.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbDataToSend.Location = new System.Drawing.Point(462, 294);
            this.tbDataToSend.Name = "tbDataToSend";
            this.tbDataToSend.Size = new System.Drawing.Size(155, 22);
            this.tbDataToSend.TabIndex = 45;
            this.tbDataToSend.Text = "REG:01";
            // 
            // panelCurrentGpio
            // 
            this.panelCurrentGpio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentGpio.Controls.Add(this.label8);
            this.panelCurrentGpio.Controls.Add(this.CHBOX_StatusPin7);
            this.panelCurrentGpio.Controls.Add(this.CHBOX_StatusPin0);
            this.panelCurrentGpio.Controls.Add(this.CHBOX_StatusPin6);
            this.panelCurrentGpio.Controls.Add(this.CHBOX_StatusPin1);
            this.panelCurrentGpio.Controls.Add(this.CHBOX_StatusPin5);
            this.panelCurrentGpio.Controls.Add(this.CHBOX_StatusPin2);
            this.panelCurrentGpio.Controls.Add(this.CHBOX_StatusPin4);
            this.panelCurrentGpio.Controls.Add(this.CHBOX_StatusPin3);
            this.panelCurrentGpio.Enabled = false;
            this.panelCurrentGpio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelCurrentGpio.Location = new System.Drawing.Point(5, 5);
            this.panelCurrentGpio.Name = "panelCurrentGpio";
            this.panelCurrentGpio.Size = new System.Drawing.Size(150, 188);
            this.panelCurrentGpio.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Текущее состояние";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHBOX_StatusPin7
            // 
            this.CHBOX_StatusPin7.AutoSize = true;
            this.CHBOX_StatusPin7.Enabled = false;
            this.CHBOX_StatusPin7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_StatusPin7.Location = new System.Drawing.Point(9, 165);
            this.CHBOX_StatusPin7.Name = "CHBOX_StatusPin7";
            this.CHBOX_StatusPin7.Size = new System.Drawing.Size(75, 20);
            this.CHBOX_StatusPin7.TabIndex = 35;
            this.CHBOX_StatusPin7.Text = "резерв";
            this.CHBOX_StatusPin7.UseVisualStyleBackColor = true;
            this.CHBOX_StatusPin7.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // CHBOX_StatusPin0
            // 
            this.CHBOX_StatusPin0.AutoSize = true;
            this.CHBOX_StatusPin0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_StatusPin0.Location = new System.Drawing.Point(9, 25);
            this.CHBOX_StatusPin0.Name = "CHBOX_StatusPin0";
            this.CHBOX_StatusPin0.Size = new System.Drawing.Size(115, 20);
            this.CHBOX_StatusPin0.TabIndex = 28;
            this.CHBOX_StatusPin0.Text = "Верхний свет";
            this.CHBOX_StatusPin0.UseVisualStyleBackColor = true;
            this.CHBOX_StatusPin0.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // CHBOX_StatusPin6
            // 
            this.CHBOX_StatusPin6.AutoSize = true;
            this.CHBOX_StatusPin6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_StatusPin6.Location = new System.Drawing.Point(9, 145);
            this.CHBOX_StatusPin6.Name = "CHBOX_StatusPin6";
            this.CHBOX_StatusPin6.Size = new System.Drawing.Size(75, 20);
            this.CHBOX_StatusPin6.TabIndex = 34;
            this.CHBOX_StatusPin6.Text = "резерв";
            this.CHBOX_StatusPin6.UseVisualStyleBackColor = true;
            this.CHBOX_StatusPin6.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // CHBOX_StatusPin1
            // 
            this.CHBOX_StatusPin1.AutoSize = true;
            this.CHBOX_StatusPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_StatusPin1.Location = new System.Drawing.Point(9, 45);
            this.CHBOX_StatusPin1.Name = "CHBOX_StatusPin1";
            this.CHBOX_StatusPin1.Size = new System.Drawing.Size(149, 20);
            this.CHBOX_StatusPin1.TabIndex = 29;
            this.CHBOX_StatusPin1.Text = "Настольная лампа";
            this.CHBOX_StatusPin1.UseVisualStyleBackColor = true;
            this.CHBOX_StatusPin1.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // CHBOX_StatusPin5
            // 
            this.CHBOX_StatusPin5.AutoSize = true;
            this.CHBOX_StatusPin5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_StatusPin5.Location = new System.Drawing.Point(9, 125);
            this.CHBOX_StatusPin5.Name = "CHBOX_StatusPin5";
            this.CHBOX_StatusPin5.Size = new System.Drawing.Size(75, 20);
            this.CHBOX_StatusPin5.TabIndex = 33;
            this.CHBOX_StatusPin5.Text = "резерв";
            this.CHBOX_StatusPin5.UseVisualStyleBackColor = true;
            this.CHBOX_StatusPin5.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // CHBOX_StatusPin2
            // 
            this.CHBOX_StatusPin2.AutoSize = true;
            this.CHBOX_StatusPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_StatusPin2.Location = new System.Drawing.Point(9, 65);
            this.CHBOX_StatusPin2.Name = "CHBOX_StatusPin2";
            this.CHBOX_StatusPin2.Size = new System.Drawing.Size(83, 20);
            this.CHBOX_StatusPin2.TabIndex = 30;
            this.CHBOX_StatusPin2.Text = "Ресивер";
            this.CHBOX_StatusPin2.UseVisualStyleBackColor = true;
            this.CHBOX_StatusPin2.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // CHBOX_StatusPin4
            // 
            this.CHBOX_StatusPin4.AutoSize = true;
            this.CHBOX_StatusPin4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_StatusPin4.Location = new System.Drawing.Point(9, 105);
            this.CHBOX_StatusPin4.Name = "CHBOX_StatusPin4";
            this.CHBOX_StatusPin4.Size = new System.Drawing.Size(84, 20);
            this.CHBOX_StatusPin4.TabIndex = 32;
            this.CHBOX_StatusPin4.Text = "Принтер";
            this.CHBOX_StatusPin4.UseVisualStyleBackColor = true;
            this.CHBOX_StatusPin4.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // CHBOX_StatusPin3
            // 
            this.CHBOX_StatusPin3.AutoSize = true;
            this.CHBOX_StatusPin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_StatusPin3.Location = new System.Drawing.Point(9, 85);
            this.CHBOX_StatusPin3.Name = "CHBOX_StatusPin3";
            this.CHBOX_StatusPin3.Size = new System.Drawing.Size(139, 20);
            this.CHBOX_StatusPin3.TabIndex = 31;
            this.CHBOX_StatusPin3.Text = "Монитор для VLC";
            this.CHBOX_StatusPin3.UseVisualStyleBackColor = true;
            this.CHBOX_StatusPin3.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // panelHotGpio
            // 
            this.panelHotGpio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHotGpio.Controls.Add(this.label6);
            this.panelHotGpio.Controls.Add(this.CHBOX_HotButtonMask8);
            this.panelHotGpio.Controls.Add(this.CHBOX_HotButtonMask1);
            this.panelHotGpio.Controls.Add(this.CHBOX_HotButtonMask7);
            this.panelHotGpio.Controls.Add(this.CHBOX_HotButtonMask2);
            this.panelHotGpio.Controls.Add(this.CHBOX_HotButtonMask6);
            this.panelHotGpio.Controls.Add(this.CHBOX_HotButtonMask3);
            this.panelHotGpio.Controls.Add(this.CHBOX_HotButtonMask5);
            this.panelHotGpio.Controls.Add(this.CHBOX_HotButtonMask4);
            this.panelHotGpio.Enabled = false;
            this.panelHotGpio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelHotGpio.Location = new System.Drawing.Point(357, 5);
            this.panelHotGpio.Name = "panelHotGpio";
            this.panelHotGpio.Size = new System.Drawing.Size(150, 188);
            this.panelHotGpio.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(-1, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "\"Горячая\" кнопка";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHBOX_HotButtonMask8
            // 
            this.CHBOX_HotButtonMask8.AutoSize = true;
            this.CHBOX_HotButtonMask8.Enabled = false;
            this.CHBOX_HotButtonMask8.Location = new System.Drawing.Point(9, 165);
            this.CHBOX_HotButtonMask8.Name = "CHBOX_HotButtonMask8";
            this.CHBOX_HotButtonMask8.Size = new System.Drawing.Size(71, 20);
            this.CHBOX_HotButtonMask8.TabIndex = 35;
            this.CHBOX_HotButtonMask8.Text = "unused";
            this.CHBOX_HotButtonMask8.UseVisualStyleBackColor = true;
            this.CHBOX_HotButtonMask8.Click += new System.EventHandler(this.CHB_HotButtonMask_Click);
            // 
            // CHBOX_HotButtonMask1
            // 
            this.CHBOX_HotButtonMask1.AutoSize = true;
            this.CHBOX_HotButtonMask1.Location = new System.Drawing.Point(9, 25);
            this.CHBOX_HotButtonMask1.Name = "CHBOX_HotButtonMask1";
            this.CHBOX_HotButtonMask1.Size = new System.Drawing.Size(83, 20);
            this.CHBOX_HotButtonMask1.TabIndex = 28;
            this.CHBOX_HotButtonMask1.Text = "Top Light";
            this.CHBOX_HotButtonMask1.UseVisualStyleBackColor = true;
            this.CHBOX_HotButtonMask1.Click += new System.EventHandler(this.CHB_HotButtonMask_Click);
            // 
            // CHBOX_HotButtonMask7
            // 
            this.CHBOX_HotButtonMask7.AutoSize = true;
            this.CHBOX_HotButtonMask7.Location = new System.Drawing.Point(9, 145);
            this.CHBOX_HotButtonMask7.Name = "CHBOX_HotButtonMask7";
            this.CHBOX_HotButtonMask7.Size = new System.Drawing.Size(71, 20);
            this.CHBOX_HotButtonMask7.TabIndex = 34;
            this.CHBOX_HotButtonMask7.Text = "unused";
            this.CHBOX_HotButtonMask7.UseVisualStyleBackColor = true;
            this.CHBOX_HotButtonMask7.Click += new System.EventHandler(this.CHB_HotButtonMask_Click);
            // 
            // CHBOX_HotButtonMask2
            // 
            this.CHBOX_HotButtonMask2.AutoSize = true;
            this.CHBOX_HotButtonMask2.Location = new System.Drawing.Point(9, 45);
            this.CHBOX_HotButtonMask2.Name = "CHBOX_HotButtonMask2";
            this.CHBOX_HotButtonMask2.Size = new System.Drawing.Size(100, 20);
            this.CHBOX_HotButtonMask2.TabIndex = 29;
            this.CHBOX_HotButtonMask2.Text = "Table Lamp";
            this.CHBOX_HotButtonMask2.UseVisualStyleBackColor = true;
            this.CHBOX_HotButtonMask2.Click += new System.EventHandler(this.CHB_HotButtonMask_Click);
            // 
            // CHBOX_HotButtonMask6
            // 
            this.CHBOX_HotButtonMask6.AutoSize = true;
            this.CHBOX_HotButtonMask6.Location = new System.Drawing.Point(9, 125);
            this.CHBOX_HotButtonMask6.Name = "CHBOX_HotButtonMask6";
            this.CHBOX_HotButtonMask6.Size = new System.Drawing.Size(71, 20);
            this.CHBOX_HotButtonMask6.TabIndex = 33;
            this.CHBOX_HotButtonMask6.Text = "unused";
            this.CHBOX_HotButtonMask6.UseVisualStyleBackColor = true;
            this.CHBOX_HotButtonMask6.Click += new System.EventHandler(this.CHB_HotButtonMask_Click);
            // 
            // CHBOX_HotButtonMask3
            // 
            this.CHBOX_HotButtonMask3.AutoSize = true;
            this.CHBOX_HotButtonMask3.Location = new System.Drawing.Point(9, 65);
            this.CHBOX_HotButtonMask3.Name = "CHBOX_HotButtonMask3";
            this.CHBOX_HotButtonMask3.Size = new System.Drawing.Size(79, 20);
            this.CHBOX_HotButtonMask3.TabIndex = 30;
            this.CHBOX_HotButtonMask3.Text = "Subwoof";
            this.CHBOX_HotButtonMask3.UseVisualStyleBackColor = true;
            this.CHBOX_HotButtonMask3.Click += new System.EventHandler(this.CHB_HotButtonMask_Click);
            // 
            // CHBOX_HotButtonMask5
            // 
            this.CHBOX_HotButtonMask5.AutoSize = true;
            this.CHBOX_HotButtonMask5.Location = new System.Drawing.Point(9, 105);
            this.CHBOX_HotButtonMask5.Name = "CHBOX_HotButtonMask5";
            this.CHBOX_HotButtonMask5.Size = new System.Drawing.Size(92, 20);
            this.CHBOX_HotButtonMask5.TabIndex = 32;
            this.CHBOX_HotButtonMask5.Text = "TV monitor";
            this.CHBOX_HotButtonMask5.UseVisualStyleBackColor = true;
            this.CHBOX_HotButtonMask5.Click += new System.EventHandler(this.CHB_HotButtonMask_Click);
            // 
            // CHBOX_HotButtonMask4
            // 
            this.CHBOX_HotButtonMask4.AutoSize = true;
            this.CHBOX_HotButtonMask4.Location = new System.Drawing.Point(9, 85);
            this.CHBOX_HotButtonMask4.Name = "CHBOX_HotButtonMask4";
            this.CHBOX_HotButtonMask4.Size = new System.Drawing.Size(65, 20);
            this.CHBOX_HotButtonMask4.TabIndex = 31;
            this.CHBOX_HotButtonMask4.Text = "Printer";
            this.CHBOX_HotButtonMask4.UseVisualStyleBackColor = true;
            this.CHBOX_HotButtonMask4.Click += new System.EventHandler(this.CHB_HotButtonMask_Click);
            // 
            // panelSleepGpio
            // 
            this.panelSleepGpio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSleepGpio.Controls.Add(this.checkBox10);
            this.panelSleepGpio.Controls.Add(this.checkBox9);
            this.panelSleepGpio.Controls.Add(this.checkBox8);
            this.panelSleepGpio.Controls.Add(this.checkBox7);
            this.panelSleepGpio.Controls.Add(this.checkBox6);
            this.panelSleepGpio.Controls.Add(this.checkBox5);
            this.panelSleepGpio.Controls.Add(this.checkBox4);
            this.panelSleepGpio.Controls.Add(this.checkBox3);
            this.panelSleepGpio.Controls.Add(this.CHBOX_SleepModeMaskPin8);
            this.panelSleepGpio.Controls.Add(this.label7);
            this.panelSleepGpio.Controls.Add(this.CHBOX_SleepModeMaskPin1);
            this.panelSleepGpio.Controls.Add(this.CHBOX_SleepModeMaskPin7);
            this.panelSleepGpio.Controls.Add(this.CHBOX_SleepModeMaskPin2);
            this.panelSleepGpio.Controls.Add(this.CHBOX_SleepModeMaskPin6);
            this.panelSleepGpio.Controls.Add(this.CHBOX_SleepModeMaskPin3);
            this.panelSleepGpio.Controls.Add(this.CHBOX_SleepModeMaskPin5);
            this.panelSleepGpio.Controls.Add(this.CHBOX_SleepModeMaskPin4);
            this.panelSleepGpio.Enabled = false;
            this.panelSleepGpio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelSleepGpio.Location = new System.Drawing.Point(161, 5);
            this.panelSleepGpio.Name = "panelSleepGpio";
            this.panelSleepGpio.Size = new System.Drawing.Size(190, 188);
            this.panelSleepGpio.TabIndex = 36;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(161, 168);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 43;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(161, 148);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 42;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(161, 129);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 41;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(161, 109);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 40;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(161, 89);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 39;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(161, 68);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 38;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(161, 48);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 37;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(161, 28);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 36;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // CHBOX_SleepModeMaskPin8
            // 
            this.CHBOX_SleepModeMaskPin8.Enabled = false;
            this.CHBOX_SleepModeMaskPin8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_SleepModeMaskPin8.Location = new System.Drawing.Point(9, 165);
            this.CHBOX_SleepModeMaskPin8.Name = "CHBOX_SleepModeMaskPin8";
            this.CHBOX_SleepModeMaskPin8.Size = new System.Drawing.Size(146, 20);
            this.CHBOX_SleepModeMaskPin8.TabIndex = 35;
            this.CHBOX_SleepModeMaskPin8.Text = "резерв";
            this.CHBOX_SleepModeMaskPin8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHBOX_SleepModeMaskPin8.UseVisualStyleBackColor = true;
            this.CHBOX_SleepModeMaskPin8.Click += new System.EventHandler(this.CHB_SleepModeMask_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(19, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Спящий режим";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHBOX_SleepModeMaskPin1
            // 
            this.CHBOX_SleepModeMaskPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_SleepModeMaskPin1.Location = new System.Drawing.Point(9, 25);
            this.CHBOX_SleepModeMaskPin1.Name = "CHBOX_SleepModeMaskPin1";
            this.CHBOX_SleepModeMaskPin1.Size = new System.Drawing.Size(146, 20);
            this.CHBOX_SleepModeMaskPin1.TabIndex = 28;
            this.CHBOX_SleepModeMaskPin1.Text = "Верхний свет";
            this.CHBOX_SleepModeMaskPin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHBOX_SleepModeMaskPin1.UseVisualStyleBackColor = true;
            this.CHBOX_SleepModeMaskPin1.Click += new System.EventHandler(this.CHB_SleepModeMask_Click);
            // 
            // CHBOX_SleepModeMaskPin7
            // 
            this.CHBOX_SleepModeMaskPin7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_SleepModeMaskPin7.Location = new System.Drawing.Point(9, 145);
            this.CHBOX_SleepModeMaskPin7.Name = "CHBOX_SleepModeMaskPin7";
            this.CHBOX_SleepModeMaskPin7.Size = new System.Drawing.Size(146, 20);
            this.CHBOX_SleepModeMaskPin7.TabIndex = 34;
            this.CHBOX_SleepModeMaskPin7.Text = "резерв";
            this.CHBOX_SleepModeMaskPin7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHBOX_SleepModeMaskPin7.UseVisualStyleBackColor = true;
            this.CHBOX_SleepModeMaskPin7.Click += new System.EventHandler(this.CHB_SleepModeMask_Click);
            // 
            // CHBOX_SleepModeMaskPin2
            // 
            this.CHBOX_SleepModeMaskPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_SleepModeMaskPin2.Location = new System.Drawing.Point(9, 45);
            this.CHBOX_SleepModeMaskPin2.Name = "CHBOX_SleepModeMaskPin2";
            this.CHBOX_SleepModeMaskPin2.Size = new System.Drawing.Size(146, 20);
            this.CHBOX_SleepModeMaskPin2.TabIndex = 29;
            this.CHBOX_SleepModeMaskPin2.Text = "Настольная лампа";
            this.CHBOX_SleepModeMaskPin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHBOX_SleepModeMaskPin2.UseVisualStyleBackColor = true;
            this.CHBOX_SleepModeMaskPin2.Click += new System.EventHandler(this.CHB_SleepModeMask_Click);
            // 
            // CHBOX_SleepModeMaskPin6
            // 
            this.CHBOX_SleepModeMaskPin6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_SleepModeMaskPin6.Location = new System.Drawing.Point(9, 125);
            this.CHBOX_SleepModeMaskPin6.Name = "CHBOX_SleepModeMaskPin6";
            this.CHBOX_SleepModeMaskPin6.Size = new System.Drawing.Size(146, 20);
            this.CHBOX_SleepModeMaskPin6.TabIndex = 33;
            this.CHBOX_SleepModeMaskPin6.Text = "резерв";
            this.CHBOX_SleepModeMaskPin6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHBOX_SleepModeMaskPin6.UseVisualStyleBackColor = true;
            this.CHBOX_SleepModeMaskPin6.Click += new System.EventHandler(this.CHB_SleepModeMask_Click);
            // 
            // CHBOX_SleepModeMaskPin3
            // 
            this.CHBOX_SleepModeMaskPin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_SleepModeMaskPin3.Location = new System.Drawing.Point(9, 65);
            this.CHBOX_SleepModeMaskPin3.Name = "CHBOX_SleepModeMaskPin3";
            this.CHBOX_SleepModeMaskPin3.Size = new System.Drawing.Size(146, 20);
            this.CHBOX_SleepModeMaskPin3.TabIndex = 30;
            this.CHBOX_SleepModeMaskPin3.Text = "Ресивер";
            this.CHBOX_SleepModeMaskPin3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHBOX_SleepModeMaskPin3.UseVisualStyleBackColor = true;
            this.CHBOX_SleepModeMaskPin3.Click += new System.EventHandler(this.CHB_SleepModeMask_Click);
            // 
            // CHBOX_SleepModeMaskPin5
            // 
            this.CHBOX_SleepModeMaskPin5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_SleepModeMaskPin5.Location = new System.Drawing.Point(9, 105);
            this.CHBOX_SleepModeMaskPin5.Name = "CHBOX_SleepModeMaskPin5";
            this.CHBOX_SleepModeMaskPin5.Size = new System.Drawing.Size(146, 20);
            this.CHBOX_SleepModeMaskPin5.TabIndex = 32;
            this.CHBOX_SleepModeMaskPin5.Text = "Принтер";
            this.CHBOX_SleepModeMaskPin5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHBOX_SleepModeMaskPin5.UseVisualStyleBackColor = true;
            this.CHBOX_SleepModeMaskPin5.Click += new System.EventHandler(this.CHB_SleepModeMask_Click);
            // 
            // CHBOX_SleepModeMaskPin4
            // 
            this.CHBOX_SleepModeMaskPin4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHBOX_SleepModeMaskPin4.Location = new System.Drawing.Point(9, 85);
            this.CHBOX_SleepModeMaskPin4.Name = "CHBOX_SleepModeMaskPin4";
            this.CHBOX_SleepModeMaskPin4.Size = new System.Drawing.Size(146, 20);
            this.CHBOX_SleepModeMaskPin4.TabIndex = 31;
            this.CHBOX_SleepModeMaskPin4.Text = "Монитор для VLC";
            this.CHBOX_SleepModeMaskPin4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHBOX_SleepModeMaskPin4.UseVisualStyleBackColor = true;
            this.CHBOX_SleepModeMaskPin4.Click += new System.EventHandler(this.CHB_SleepModeMask_Click);
            // 
            // tabPageRGB
            // 
            this.tabPageRGB.Controls.Add(this.panel5);
            this.tabPageRGB.Location = new System.Drawing.Point(4, 25);
            this.tabPageRGB.Name = "tabPageRGB";
            this.tabPageRGB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRGB.Size = new System.Drawing.Size(777, 329);
            this.tabPageRGB.TabIndex = 5;
            this.tabPageRGB.Text = "RGB-Tape";
            this.tabPageRGB.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelY);
            this.panel5.Controls.Add(this.labelX);
            this.panel5.Controls.Add(this.lblBLUE);
            this.panel5.Controls.Add(this.CHBOX_Ambilight);
            this.panel5.Controls.Add(this.gbSheduler);
            this.panel5.Controls.Add(this.btnGetDesktopColor);
            this.panel5.Controls.Add(this.lblGREEN);
            this.panel5.Controls.Add(this.COMBOX_RgbSendString);
            this.panel5.Controls.Add(this.lblRED);
            this.panel5.Controls.Add(this.lblUseAmbilight);
            this.panel5.Controls.Add(this.lblPixel);
            this.panel5.Controls.Add(this.btnSaveRgbCfg);
            this.panel5.Controls.Add(this.nudChannelNumber);
            this.panel5.Controls.Add(this.tbRed);
            this.panel5.Controls.Add(this.btnSendCmd);
            this.panel5.Controls.Add(this.tbGreen);
            this.panel5.Controls.Add(this.tbBlue);
            this.panel5.Controls.Add(this.nudRgbFreq);
            this.panel5.Controls.Add(this.btnBlynkMode);
            this.panel5.Controls.Add(this.btnNormalMode);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(740, 299);
            this.panel5.TabIndex = 9;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(353, 238);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(36, 16);
            this.labelY.TabIndex = 69;
            this.labelY.Text = "0000";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(305, 238);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(36, 16);
            this.labelX.TabIndex = 68;
            this.labelX.Text = "0000";
            // 
            // lblBLUE
            // 
            this.lblBLUE.AutoSize = true;
            this.lblBLUE.Location = new System.Drawing.Point(374, 273);
            this.lblBLUE.Name = "lblBLUE";
            this.lblBLUE.Size = new System.Drawing.Size(15, 16);
            this.lblBLUE.TabIndex = 50;
            this.lblBLUE.Text = "0";
            // 
            // CHBOX_Ambilight
            // 
            this.CHBOX_Ambilight.AutoSize = true;
            this.CHBOX_Ambilight.Enabled = false;
            this.CHBOX_Ambilight.Location = new System.Drawing.Point(517, 10);
            this.CHBOX_Ambilight.Name = "CHBOX_Ambilight";
            this.CHBOX_Ambilight.Size = new System.Drawing.Size(15, 14);
            this.CHBOX_Ambilight.TabIndex = 56;
            this.CHBOX_Ambilight.UseVisualStyleBackColor = true;
            this.CHBOX_Ambilight.Click += new System.EventHandler(this.CHB_Ambilight_Click);
            // 
            // gbSheduler
            // 
            this.gbSheduler.Controls.Add(this.tableLayoutPanel2);
            this.gbSheduler.Controls.Add(this.tableLayoutPanel1);
            this.gbSheduler.Controls.Add(this.CHBOX_Sheduler);
            this.gbSheduler.Enabled = false;
            this.gbSheduler.Location = new System.Drawing.Point(278, 34);
            this.gbSheduler.Name = "gbSheduler";
            this.gbSheduler.Size = new System.Drawing.Size(459, 181);
            this.gbSheduler.TabIndex = 67;
            this.gbSheduler.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 13;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label29, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Color15, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox20, 12, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox21, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox22, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox23, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox24, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox25, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox26, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox27, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox28, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox29, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox30, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox31, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Color12, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Color13, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Color14, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Color16, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Color17, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Color18, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Color19, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Color20, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Color21, 10, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnColor22, 11, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnColor23, 12, 1);
            this.tableLayoutPanel2.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(447, 52);
            this.tableLayoutPanel2.TabIndex = 48;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(34, 31);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 16);
            this.label29.TabIndex = 62;
            this.label29.Text = "Цвет";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTN_Color15
            // 
            this.BTN_Color15.AutoSize = true;
            this.BTN_Color15.BackColor = System.Drawing.Color.OrangeRed;
            this.BTN_Color15.Location = new System.Drawing.Point(196, 29);
            this.BTN_Color15.Name = "BTN_Color15";
            this.BTN_Color15.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color15.TabIndex = 48;
            this.BTN_Color15.UseVisualStyleBackColor = false;
            this.BTN_Color15.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // textBox20
            // 
            this.textBox20.Enabled = false;
            this.textBox20.Location = new System.Drawing.Point(420, 3);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(24, 22);
            this.textBox20.TabIndex = 13;
            this.textBox20.Text = "23";
            // 
            // textBox21
            // 
            this.textBox21.Enabled = false;
            this.textBox21.Location = new System.Drawing.Point(392, 3);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(22, 22);
            this.textBox21.TabIndex = 12;
            this.textBox21.Text = "22";
            // 
            // textBox22
            // 
            this.textBox22.Enabled = false;
            this.textBox22.Location = new System.Drawing.Point(364, 3);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(22, 22);
            this.textBox22.TabIndex = 11;
            this.textBox22.Text = "21";
            // 
            // textBox23
            // 
            this.textBox23.Enabled = false;
            this.textBox23.Location = new System.Drawing.Point(336, 3);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(22, 22);
            this.textBox23.TabIndex = 10;
            this.textBox23.Text = "20";
            // 
            // textBox24
            // 
            this.textBox24.Enabled = false;
            this.textBox24.Location = new System.Drawing.Point(308, 3);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(22, 22);
            this.textBox24.TabIndex = 9;
            this.textBox24.Text = "19";
            // 
            // textBox25
            // 
            this.textBox25.Enabled = false;
            this.textBox25.Location = new System.Drawing.Point(280, 3);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(22, 22);
            this.textBox25.TabIndex = 8;
            this.textBox25.Text = "18";
            // 
            // textBox26
            // 
            this.textBox26.Enabled = false;
            this.textBox26.Location = new System.Drawing.Point(252, 3);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(22, 22);
            this.textBox26.TabIndex = 7;
            this.textBox26.Text = "17";
            // 
            // textBox27
            // 
            this.textBox27.Enabled = false;
            this.textBox27.Location = new System.Drawing.Point(224, 3);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(22, 22);
            this.textBox27.TabIndex = 6;
            this.textBox27.Text = "16";
            // 
            // textBox28
            // 
            this.textBox28.Enabled = false;
            this.textBox28.Location = new System.Drawing.Point(196, 3);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(22, 22);
            this.textBox28.TabIndex = 5;
            this.textBox28.Text = "15";
            // 
            // textBox29
            // 
            this.textBox29.Enabled = false;
            this.textBox29.Location = new System.Drawing.Point(168, 3);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(22, 22);
            this.textBox29.TabIndex = 4;
            this.textBox29.Text = "14";
            // 
            // textBox30
            // 
            this.textBox30.Enabled = false;
            this.textBox30.Location = new System.Drawing.Point(140, 3);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(22, 22);
            this.textBox30.TabIndex = 3;
            this.textBox30.Text = "13";
            // 
            // textBox31
            // 
            this.textBox31.Enabled = false;
            this.textBox31.Location = new System.Drawing.Point(112, 3);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(22, 22);
            this.textBox31.TabIndex = 1;
            this.textBox31.Text = "12";
            // 
            // BTN_Color12
            // 
            this.BTN_Color12.AutoSize = true;
            this.BTN_Color12.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Color12.Location = new System.Drawing.Point(112, 29);
            this.BTN_Color12.Name = "BTN_Color12";
            this.BTN_Color12.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color12.TabIndex = 2;
            this.BTN_Color12.UseVisualStyleBackColor = false;
            this.BTN_Color12.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color13
            // 
            this.BTN_Color13.AutoSize = true;
            this.BTN_Color13.BackColor = System.Drawing.Color.Sienna;
            this.BTN_Color13.Location = new System.Drawing.Point(140, 29);
            this.BTN_Color13.Name = "BTN_Color13";
            this.BTN_Color13.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color13.TabIndex = 14;
            this.BTN_Color13.UseVisualStyleBackColor = false;
            this.BTN_Color13.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color14
            // 
            this.BTN_Color14.AutoSize = true;
            this.BTN_Color14.BackColor = System.Drawing.Color.SkyBlue;
            this.BTN_Color14.Location = new System.Drawing.Point(168, 29);
            this.BTN_Color14.Name = "BTN_Color14";
            this.BTN_Color14.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color14.TabIndex = 15;
            this.BTN_Color14.UseVisualStyleBackColor = false;
            this.BTN_Color14.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color16
            // 
            this.BTN_Color16.AutoSize = true;
            this.BTN_Color16.BackColor = System.Drawing.Color.Red;
            this.BTN_Color16.Location = new System.Drawing.Point(224, 29);
            this.BTN_Color16.Name = "BTN_Color16";
            this.BTN_Color16.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color16.TabIndex = 49;
            this.BTN_Color16.UseVisualStyleBackColor = false;
            this.BTN_Color16.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color17
            // 
            this.BTN_Color17.AutoSize = true;
            this.BTN_Color17.BackColor = System.Drawing.Color.Magenta;
            this.BTN_Color17.Location = new System.Drawing.Point(252, 29);
            this.BTN_Color17.Name = "BTN_Color17";
            this.BTN_Color17.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color17.TabIndex = 50;
            this.BTN_Color17.UseVisualStyleBackColor = false;
            this.BTN_Color17.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color18
            // 
            this.BTN_Color18.AutoSize = true;
            this.BTN_Color18.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_Color18.Location = new System.Drawing.Point(280, 29);
            this.BTN_Color18.Name = "BTN_Color18";
            this.BTN_Color18.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color18.TabIndex = 51;
            this.BTN_Color18.UseVisualStyleBackColor = false;
            this.BTN_Color18.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color19
            // 
            this.BTN_Color19.AutoSize = true;
            this.BTN_Color19.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Color19.Location = new System.Drawing.Point(308, 29);
            this.BTN_Color19.Name = "BTN_Color19";
            this.BTN_Color19.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color19.TabIndex = 52;
            this.BTN_Color19.UseVisualStyleBackColor = false;
            this.BTN_Color19.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color20
            // 
            this.BTN_Color20.AutoSize = true;
            this.BTN_Color20.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Color20.Location = new System.Drawing.Point(336, 29);
            this.BTN_Color20.Name = "BTN_Color20";
            this.BTN_Color20.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color20.TabIndex = 53;
            this.BTN_Color20.UseVisualStyleBackColor = false;
            this.BTN_Color20.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color21
            // 
            this.BTN_Color21.AutoSize = true;
            this.BTN_Color21.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Color21.Location = new System.Drawing.Point(364, 29);
            this.BTN_Color21.Name = "BTN_Color21";
            this.BTN_Color21.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color21.TabIndex = 54;
            this.BTN_Color21.UseVisualStyleBackColor = false;
            this.BTN_Color21.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // btnColor22
            // 
            this.btnColor22.AutoSize = true;
            this.btnColor22.BackColor = System.Drawing.Color.SeaGreen;
            this.btnColor22.Location = new System.Drawing.Point(392, 29);
            this.btnColor22.Name = "btnColor22";
            this.btnColor22.Size = new System.Drawing.Size(22, 20);
            this.btnColor22.TabIndex = 55;
            this.btnColor22.UseVisualStyleBackColor = false;
            this.btnColor22.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // btnColor23
            // 
            this.btnColor23.AutoSize = true;
            this.btnColor23.BackColor = System.Drawing.Color.SeaGreen;
            this.btnColor23.Location = new System.Drawing.Point(420, 29);
            this.btnColor23.Name = "btnColor23";
            this.btnColor23.Size = new System.Drawing.Size(22, 20);
            this.btnColor23.TabIndex = 56;
            this.btnColor23.UseVisualStyleBackColor = false;
            this.btnColor23.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(20, 5);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(69, 16);
            this.label28.TabIndex = 61;
            this.label28.Text = "Время (Ч)";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label27, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color03, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox15, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox14, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox13, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox12, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox11, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color00, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color01, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color02, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color04, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color05, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color06, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color07, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color08, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color09, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color10, 11, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Color11, 12, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 52);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(34, 31);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 16);
            this.label27.TabIndex = 61;
            this.label27.Text = "Цвет";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 16);
            this.label26.TabIndex = 60;
            this.label26.Text = "Время (Ч)";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTN_Color03
            // 
            this.BTN_Color03.AutoSize = true;
            this.BTN_Color03.BackColor = System.Drawing.Color.OrangeRed;
            this.BTN_Color03.Location = new System.Drawing.Point(196, 29);
            this.BTN_Color03.Name = "BTN_Color03";
            this.BTN_Color03.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color03.TabIndex = 48;
            this.BTN_Color03.UseVisualStyleBackColor = false;
            this.BTN_Color03.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // textBox15
            // 
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(420, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(24, 22);
            this.textBox15.TabIndex = 13;
            this.textBox15.Text = "11";
            // 
            // textBox14
            // 
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(392, 3);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(22, 22);
            this.textBox14.TabIndex = 12;
            this.textBox14.Text = "10";
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(364, 3);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(22, 22);
            this.textBox13.TabIndex = 11;
            this.textBox13.Text = "09";
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(336, 3);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(22, 22);
            this.textBox12.TabIndex = 10;
            this.textBox12.Text = "08";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(308, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(22, 22);
            this.textBox11.TabIndex = 9;
            this.textBox11.Text = "07";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(280, 3);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(22, 22);
            this.textBox10.TabIndex = 8;
            this.textBox10.Text = "06";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(252, 3);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(22, 22);
            this.textBox9.TabIndex = 7;
            this.textBox9.Text = "05";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(224, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(22, 22);
            this.textBox8.TabIndex = 6;
            this.textBox8.Text = "04";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(196, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(22, 22);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "03";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(168, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(22, 22);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "02";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(140, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(22, 22);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "01";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(112, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(22, 22);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "00";
            // 
            // BTN_Color00
            // 
            this.BTN_Color00.AutoSize = true;
            this.BTN_Color00.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Color00.Location = new System.Drawing.Point(112, 29);
            this.BTN_Color00.Name = "BTN_Color00";
            this.BTN_Color00.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color00.TabIndex = 2;
            this.BTN_Color00.UseVisualStyleBackColor = false;
            this.BTN_Color00.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color01
            // 
            this.BTN_Color01.AutoSize = true;
            this.BTN_Color01.BackColor = System.Drawing.Color.Sienna;
            this.BTN_Color01.Location = new System.Drawing.Point(140, 29);
            this.BTN_Color01.Name = "BTN_Color01";
            this.BTN_Color01.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color01.TabIndex = 14;
            this.BTN_Color01.UseVisualStyleBackColor = false;
            this.BTN_Color01.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color02
            // 
            this.BTN_Color02.AutoSize = true;
            this.BTN_Color02.BackColor = System.Drawing.Color.SkyBlue;
            this.BTN_Color02.Location = new System.Drawing.Point(168, 29);
            this.BTN_Color02.Name = "BTN_Color02";
            this.BTN_Color02.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color02.TabIndex = 15;
            this.BTN_Color02.UseVisualStyleBackColor = false;
            this.BTN_Color02.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color04
            // 
            this.BTN_Color04.AutoSize = true;
            this.BTN_Color04.BackColor = System.Drawing.Color.Red;
            this.BTN_Color04.Location = new System.Drawing.Point(224, 29);
            this.BTN_Color04.Name = "BTN_Color04";
            this.BTN_Color04.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color04.TabIndex = 49;
            this.BTN_Color04.UseVisualStyleBackColor = false;
            this.BTN_Color04.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color05
            // 
            this.BTN_Color05.AutoSize = true;
            this.BTN_Color05.BackColor = System.Drawing.Color.Magenta;
            this.BTN_Color05.Location = new System.Drawing.Point(252, 29);
            this.BTN_Color05.Name = "BTN_Color05";
            this.BTN_Color05.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color05.TabIndex = 50;
            this.BTN_Color05.UseVisualStyleBackColor = false;
            this.BTN_Color05.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color06
            // 
            this.BTN_Color06.AutoSize = true;
            this.BTN_Color06.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_Color06.Location = new System.Drawing.Point(280, 29);
            this.BTN_Color06.Name = "BTN_Color06";
            this.BTN_Color06.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color06.TabIndex = 51;
            this.BTN_Color06.UseVisualStyleBackColor = false;
            this.BTN_Color06.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color07
            // 
            this.BTN_Color07.AutoSize = true;
            this.BTN_Color07.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Color07.Location = new System.Drawing.Point(308, 29);
            this.BTN_Color07.Name = "BTN_Color07";
            this.BTN_Color07.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color07.TabIndex = 52;
            this.BTN_Color07.UseVisualStyleBackColor = false;
            this.BTN_Color07.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color08
            // 
            this.BTN_Color08.AutoSize = true;
            this.BTN_Color08.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Color08.Location = new System.Drawing.Point(336, 29);
            this.BTN_Color08.Name = "BTN_Color08";
            this.BTN_Color08.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color08.TabIndex = 53;
            this.BTN_Color08.UseVisualStyleBackColor = false;
            this.BTN_Color08.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color09
            // 
            this.BTN_Color09.AutoSize = true;
            this.BTN_Color09.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Color09.Location = new System.Drawing.Point(364, 29);
            this.BTN_Color09.Name = "BTN_Color09";
            this.BTN_Color09.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color09.TabIndex = 54;
            this.BTN_Color09.UseVisualStyleBackColor = false;
            this.BTN_Color09.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color10
            // 
            this.BTN_Color10.AutoSize = true;
            this.BTN_Color10.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Color10.Location = new System.Drawing.Point(392, 29);
            this.BTN_Color10.Name = "BTN_Color10";
            this.BTN_Color10.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color10.TabIndex = 55;
            this.BTN_Color10.UseVisualStyleBackColor = false;
            this.BTN_Color10.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color11
            // 
            this.BTN_Color11.AutoSize = true;
            this.BTN_Color11.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Color11.Location = new System.Drawing.Point(420, 29);
            this.BTN_Color11.Name = "BTN_Color11";
            this.BTN_Color11.Size = new System.Drawing.Size(22, 20);
            this.BTN_Color11.TabIndex = 56;
            this.BTN_Color11.UseVisualStyleBackColor = false;
            this.BTN_Color11.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // CHBOX_Sheduler
            // 
            this.CHBOX_Sheduler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CHBOX_Sheduler.AutoSize = true;
            this.CHBOX_Sheduler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBOX_Sheduler.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CHBOX_Sheduler.Location = new System.Drawing.Point(-2, 0);
            this.CHBOX_Sheduler.Name = "CHBOX_Sheduler";
            this.CHBOX_Sheduler.Size = new System.Drawing.Size(106, 20);
            this.CHBOX_Sheduler.TabIndex = 46;
            this.CHBOX_Sheduler.Text = "Расписание";
            this.CHBOX_Sheduler.UseVisualStyleBackColor = true;
            this.CHBOX_Sheduler.Click += new System.EventHandler(this.CHB_Sheduler_Click);
            // 
            // btnGetDesktopColor
            // 
            this.btnGetDesktopColor.Location = new System.Drawing.Point(6, 156);
            this.btnGetDesktopColor.Name = "btnGetDesktopColor";
            this.btnGetDesktopColor.Size = new System.Drawing.Size(241, 23);
            this.btnGetDesktopColor.TabIndex = 11;
            this.btnGetDesktopColor.Text = "Цвет с рабочего стола";
            this.btnGetDesktopColor.UseVisualStyleBackColor = true;
            this.btnGetDesktopColor.Click += new System.EventHandler(this.BTN18_Click);
            // 
            // lblGREEN
            // 
            this.lblGREEN.AutoSize = true;
            this.lblGREEN.Location = new System.Drawing.Point(345, 273);
            this.lblGREEN.Name = "lblGREEN";
            this.lblGREEN.Size = new System.Drawing.Size(15, 16);
            this.lblGREEN.TabIndex = 49;
            this.lblGREEN.Text = "0";
            // 
            // COMBOX_RgbSendString
            // 
            this.COMBOX_RgbSendString.FormattingEnabled = true;
            this.COMBOX_RgbSendString.Items.AddRange(new object[] {
            "EFFECT_CONFIG:01.1.1.1.00.00.00.00.00",
            "EFFECT_CONFIG:02.1.1.1.FF.00.00.10.80",
            "0.1.111"});
            this.COMBOX_RgbSendString.Location = new System.Drawing.Point(6, 235);
            this.COMBOX_RgbSendString.Name = "COMBOX_RgbSendString";
            this.COMBOX_RgbSendString.Size = new System.Drawing.Size(209, 24);
            this.COMBOX_RgbSendString.TabIndex = 51;
            // 
            // lblRED
            // 
            this.lblRED.AutoSize = true;
            this.lblRED.Location = new System.Drawing.Point(315, 273);
            this.lblRED.Name = "lblRED";
            this.lblRED.Size = new System.Drawing.Size(15, 16);
            this.lblRED.TabIndex = 48;
            this.lblRED.Text = "0";
            // 
            // lblUseAmbilight
            // 
            this.lblUseAmbilight.AutoSize = true;
            this.lblUseAmbilight.Enabled = false;
            this.lblUseAmbilight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUseAmbilight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUseAmbilight.Location = new System.Drawing.Point(339, 8);
            this.lblUseAmbilight.Name = "lblUseAmbilight";
            this.lblUseAmbilight.Size = new System.Drawing.Size(214, 17);
            this.lblUseAmbilight.TabIndex = 55;
            this.lblUseAmbilight.Text = "Поддержка функции \"Ambilight\"";
            this.toolTip1.SetToolTip(this.lblUseAmbilight, "Необходим RGB контроллер");
            // 
            // lblPixel
            // 
            this.lblPixel.AutoSize = true;
            this.lblPixel.Location = new System.Drawing.Point(393, 273);
            this.lblPixel.Name = "lblPixel";
            this.lblPixel.Size = new System.Drawing.Size(28, 16);
            this.lblPixel.TabIndex = 47;
            this.lblPixel.Text = "text";
            // 
            // btnSaveRgbCfg
            // 
            this.btnSaveRgbCfg.ForeColor = System.Drawing.Color.Red;
            this.btnSaveRgbCfg.Location = new System.Drawing.Point(3, 273);
            this.btnSaveRgbCfg.Name = "btnSaveRgbCfg";
            this.btnSaveRgbCfg.Size = new System.Drawing.Size(61, 23);
            this.btnSaveRgbCfg.TabIndex = 12;
            this.btnSaveRgbCfg.Text = "SaveCFG";
            this.btnSaveRgbCfg.UseVisualStyleBackColor = true;
            this.btnSaveRgbCfg.Click += new System.EventHandler(this.BTN_SaveRgbCfg_Click);
            // 
            // nudChannelNumber
            // 
            this.nudChannelNumber.Location = new System.Drawing.Point(199, 181);
            this.nudChannelNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudChannelNumber.Name = "nudChannelNumber";
            this.nudChannelNumber.Size = new System.Drawing.Size(48, 22);
            this.nudChannelNumber.TabIndex = 5;
            this.nudChannelNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudChannelNumber, "Номер цвета (0..2)");
            this.nudChannelNumber.ValueChanged += new System.EventHandler(this.NUD_3_ValueChanged);
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(0, 3);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(272, 45);
            this.tbRed.TabIndex = 0;
            this.tbRed.Scroll += new System.EventHandler(this.TRB_Color_Scroll);
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Location = new System.Drawing.Point(221, 235);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(48, 23);
            this.btnSendCmd.TabIndex = 46;
            this.btnSendCmd.Text = "Send";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.BTN_SendRgbCommand);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(0, 54);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(272, 45);
            this.tbGreen.TabIndex = 7;
            this.tbGreen.Scroll += new System.EventHandler(this.TRB_Color_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(3, 105);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(269, 45);
            this.tbBlue.TabIndex = 8;
            this.tbBlue.Scroll += new System.EventHandler(this.TRB_Color_Scroll);
            // 
            // nudRgbFreq
            // 
            this.nudRgbFreq.Location = new System.Drawing.Point(145, 181);
            this.nudRgbFreq.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbFreq.Name = "nudRgbFreq";
            this.nudRgbFreq.Size = new System.Drawing.Size(48, 22);
            this.nudRgbFreq.TabIndex = 6;
            this.nudRgbFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRgbFreq.Value = new decimal(new int[] {
            111,
            0,
            0,
            0});
            this.nudRgbFreq.ValueChanged += new System.EventHandler(this.NU_RgbFreq_ValueChanged);
            // 
            // btnBlynkMode
            // 
            this.btnBlynkMode.Location = new System.Drawing.Point(76, 181);
            this.btnBlynkMode.Name = "btnBlynkMode";
            this.btnBlynkMode.Size = new System.Drawing.Size(63, 23);
            this.btnBlynkMode.TabIndex = 2;
            this.btnBlynkMode.Text = "Blynk";
            this.btnBlynkMode.UseVisualStyleBackColor = true;
            this.btnBlynkMode.Click += new System.EventHandler(this.SetRgbTapeBlynkMode);
            // 
            // btnNormalMode
            // 
            this.btnNormalMode.Location = new System.Drawing.Point(6, 182);
            this.btnNormalMode.Name = "btnNormalMode";
            this.btnNormalMode.Size = new System.Drawing.Size(64, 23);
            this.btnNormalMode.TabIndex = 1;
            this.btnNormalMode.Text = "Normal";
            this.btnNormalMode.UseVisualStyleBackColor = true;
            // 
            // tabPageVLC
            // 
            this.tabPageVLC.Controls.Add(this.btnPlay);
            this.tabPageVLC.Controls.Add(this.groupBox3);
            this.tabPageVLC.Controls.Add(this.RBTN_MainVlcPlayList);
            this.tabPageVLC.Controls.Add(this.buttonPlayPause);
            this.tabPageVLC.Controls.Add(this.BTN_Mute);
            this.tabPageVLC.Controls.Add(this.TXTBOX_VlcVolume);
            this.tabPageVLC.Controls.Add(this.buttonVlcStop);
            this.tabPageVLC.Controls.Add(this.rtbVlcLog);
            this.tabPageVLC.Controls.Add(this.RBTN_FavoriteVlcPlayList);
            this.tabPageVLC.Controls.Add(this.label20);
            this.tabPageVLC.Controls.Add(this.LBOX_VlcPlaylistURLs);
            this.tabPageVLC.Controls.Add(this.LBOX_VlcFavoriteURLs);
            this.tabPageVLC.Controls.Add(this.LISTB_VlcFavoriteTitles);
            this.tabPageVLC.Controls.Add(this.LISTB_VlcPlaylistTitles);
            this.tabPageVLC.Location = new System.Drawing.Point(4, 25);
            this.tabPageVLC.Name = "tabPageVLC";
            this.tabPageVLC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVLC.Size = new System.Drawing.Size(777, 329);
            this.tabPageVLC.TabIndex = 2;
            this.tabPageVLC.Text = "VLC";
            this.tabPageVLC.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(361, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(46, 20);
            this.btnPlay.TabIndex = 56;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxFullScreen);
            this.groupBox3.Controls.Add(this.lblFullScreen);
            this.groupBox3.Controls.Add(this.CHBOX_RememberChVol);
            this.groupBox3.Controls.Add(this.MTB_PlayListPath);
            this.groupBox3.Controls.Add(this.GRBOX_VlcGpioSettings);
            this.groupBox3.Controls.Add(this.MTB_FavoriteListPath);
            this.groupBox3.Controls.Add(this.buttonVlcFavoriteListPath);
            this.groupBox3.Controls.Add(this.buttonVlcPlayListPath);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblRememberVolumes);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.lblUseSlaveMonitor);
            this.groupBox3.Controls.Add(this.CHBOX_UseSlaveMonitor);
            this.groupBox3.Location = new System.Drawing.Point(339, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 198);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки";
            // 
            // checkBoxFullScreen
            // 
            this.checkBoxFullScreen.AutoSize = true;
            this.checkBoxFullScreen.Location = new System.Drawing.Point(7, 112);
            this.checkBoxFullScreen.Name = "checkBoxFullScreen";
            this.checkBoxFullScreen.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFullScreen.TabIndex = 72;
            this.checkBoxFullScreen.UseVisualStyleBackColor = true;
            this.checkBoxFullScreen.Click += new System.EventHandler(this.CHB_FullScreen_Click);
            // 
            // lblFullScreen
            // 
            this.lblFullScreen.AutoSize = true;
            this.lblFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFullScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFullScreen.Location = new System.Drawing.Point(28, 110);
            this.lblFullScreen.Name = "lblFullScreen";
            this.lblFullScreen.Size = new System.Drawing.Size(101, 17);
            this.lblFullScreen.TabIndex = 71;
            this.lblFullScreen.Text = "На весь экран";
            // 
            // CHBOX_RememberChVol
            // 
            this.CHBOX_RememberChVol.AutoSize = true;
            this.CHBOX_RememberChVol.Location = new System.Drawing.Point(7, 92);
            this.CHBOX_RememberChVol.Name = "CHBOX_RememberChVol";
            this.CHBOX_RememberChVol.Size = new System.Drawing.Size(15, 14);
            this.CHBOX_RememberChVol.TabIndex = 70;
            this.CHBOX_RememberChVol.UseVisualStyleBackColor = true;
            // 
            // MTB_PlayListPath
            // 
            this.MTB_PlayListPath.Location = new System.Drawing.Point(154, 21);
            this.MTB_PlayListPath.Name = "MTB_PlayListPath";
            this.MTB_PlayListPath.Size = new System.Drawing.Size(237, 22);
            this.MTB_PlayListPath.TabIndex = 32;
            // 
            // GRBOX_VlcGpioSettings
            // 
            this.GRBOX_VlcGpioSettings.Controls.Add(this.cbVlcMaskPin1);
            this.GRBOX_VlcGpioSettings.Controls.Add(this.cbVlcMaskPin7);
            this.GRBOX_VlcGpioSettings.Controls.Add(this.cbVlcMaskPin0);
            this.GRBOX_VlcGpioSettings.Controls.Add(this.CHBOX_UsedGpioForVlcMask);
            this.GRBOX_VlcGpioSettings.Controls.Add(this.cbVlcMaskPin6);
            this.GRBOX_VlcGpioSettings.Controls.Add(this.cbVlcMaskPin2);
            this.GRBOX_VlcGpioSettings.Controls.Add(this.cbVlcMaskPin5);
            this.GRBOX_VlcGpioSettings.Controls.Add(this.cbVlcMaskPin3);
            this.GRBOX_VlcGpioSettings.Controls.Add(this.cbVlcMaskPin4);
            this.GRBOX_VlcGpioSettings.Enabled = false;
            this.GRBOX_VlcGpioSettings.Location = new System.Drawing.Point(11, 133);
            this.GRBOX_VlcGpioSettings.Name = "GRBOX_VlcGpioSettings";
            this.GRBOX_VlcGpioSettings.Size = new System.Drawing.Size(298, 57);
            this.GRBOX_VlcGpioSettings.TabIndex = 66;
            this.GRBOX_VlcGpioSettings.TabStop = false;
            // 
            // cbVlcMaskPin1
            // 
            this.cbVlcMaskPin1.AutoSize = true;
            this.cbVlcMaskPin1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbVlcMaskPin1.FlatAppearance.BorderSize = 2;
            this.cbVlcMaskPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVlcMaskPin1.ForeColor = System.Drawing.Color.Crimson;
            this.cbVlcMaskPin1.Location = new System.Drawing.Point(227, 19);
            this.cbVlcMaskPin1.Name = "cbVlcMaskPin1";
            this.cbVlcMaskPin1.Size = new System.Drawing.Size(39, 31);
            this.cbVlcMaskPin1.TabIndex = 59;
            this.cbVlcMaskPin1.Text = "PIN1";
            this.cbVlcMaskPin1.UseVisualStyleBackColor = true;
            this.cbVlcMaskPin1.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // cbVlcMaskPin7
            // 
            this.cbVlcMaskPin7.AutoSize = true;
            this.cbVlcMaskPin7.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbVlcMaskPin7.FlatAppearance.BorderSize = 2;
            this.cbVlcMaskPin7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVlcMaskPin7.ForeColor = System.Drawing.Color.Crimson;
            this.cbVlcMaskPin7.Location = new System.Drawing.Point(2, 19);
            this.cbVlcMaskPin7.Name = "cbVlcMaskPin7";
            this.cbVlcMaskPin7.Size = new System.Drawing.Size(39, 31);
            this.cbVlcMaskPin7.TabIndex = 65;
            this.cbVlcMaskPin7.Text = "PIN7";
            this.cbVlcMaskPin7.UseVisualStyleBackColor = true;
            this.cbVlcMaskPin7.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // cbVlcMaskPin0
            // 
            this.cbVlcMaskPin0.AutoSize = true;
            this.cbVlcMaskPin0.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbVlcMaskPin0.FlatAppearance.BorderSize = 2;
            this.cbVlcMaskPin0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVlcMaskPin0.ForeColor = System.Drawing.Color.Crimson;
            this.cbVlcMaskPin0.Location = new System.Drawing.Point(264, 19);
            this.cbVlcMaskPin0.Name = "cbVlcMaskPin0";
            this.cbVlcMaskPin0.Size = new System.Drawing.Size(39, 31);
            this.cbVlcMaskPin0.TabIndex = 58;
            this.cbVlcMaskPin0.Text = "PIN0";
            this.cbVlcMaskPin0.UseVisualStyleBackColor = true;
            this.cbVlcMaskPin0.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // CHBOX_UsedGpioForVlcMask
            // 
            this.CHBOX_UsedGpioForVlcMask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CHBOX_UsedGpioForVlcMask.AutoSize = true;
            this.CHBOX_UsedGpioForVlcMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBOX_UsedGpioForVlcMask.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CHBOX_UsedGpioForVlcMask.Location = new System.Drawing.Point(-4, 0);
            this.CHBOX_UsedGpioForVlcMask.Name = "CHBOX_UsedGpioForVlcMask";
            this.CHBOX_UsedGpioForVlcMask.Size = new System.Drawing.Size(296, 20);
            this.CHBOX_UsedGpioForVlcMask.TabIndex = 46;
            this.CHBOX_UsedGpioForVlcMask.Text = "Используемые порты платы \"SmartHome\"";
            this.CHBOX_UsedGpioForVlcMask.UseVisualStyleBackColor = true;
            this.CHBOX_UsedGpioForVlcMask.Click += new System.EventHandler(this.CHB_VlcGpioMask_Click);
            // 
            // cbVlcMaskPin6
            // 
            this.cbVlcMaskPin6.AutoSize = true;
            this.cbVlcMaskPin6.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbVlcMaskPin6.FlatAppearance.BorderSize = 2;
            this.cbVlcMaskPin6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVlcMaskPin6.ForeColor = System.Drawing.Color.Crimson;
            this.cbVlcMaskPin6.Location = new System.Drawing.Point(42, 19);
            this.cbVlcMaskPin6.Name = "cbVlcMaskPin6";
            this.cbVlcMaskPin6.Size = new System.Drawing.Size(39, 31);
            this.cbVlcMaskPin6.TabIndex = 64;
            this.cbVlcMaskPin6.Text = "PIN6";
            this.cbVlcMaskPin6.UseVisualStyleBackColor = true;
            this.cbVlcMaskPin6.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // cbVlcMaskPin2
            // 
            this.cbVlcMaskPin2.AutoSize = true;
            this.cbVlcMaskPin2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbVlcMaskPin2.FlatAppearance.BorderSize = 2;
            this.cbVlcMaskPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVlcMaskPin2.ForeColor = System.Drawing.Color.Crimson;
            this.cbVlcMaskPin2.Location = new System.Drawing.Point(190, 19);
            this.cbVlcMaskPin2.Name = "cbVlcMaskPin2";
            this.cbVlcMaskPin2.Size = new System.Drawing.Size(39, 31);
            this.cbVlcMaskPin2.TabIndex = 60;
            this.cbVlcMaskPin2.Text = "PIN2";
            this.cbVlcMaskPin2.UseVisualStyleBackColor = true;
            this.cbVlcMaskPin2.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // cbVlcMaskPin5
            // 
            this.cbVlcMaskPin5.AutoSize = true;
            this.cbVlcMaskPin5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbVlcMaskPin5.FlatAppearance.BorderSize = 2;
            this.cbVlcMaskPin5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVlcMaskPin5.ForeColor = System.Drawing.Color.Crimson;
            this.cbVlcMaskPin5.Location = new System.Drawing.Point(79, 19);
            this.cbVlcMaskPin5.Name = "cbVlcMaskPin5";
            this.cbVlcMaskPin5.Size = new System.Drawing.Size(39, 31);
            this.cbVlcMaskPin5.TabIndex = 63;
            this.cbVlcMaskPin5.Text = "PIN5";
            this.cbVlcMaskPin5.UseVisualStyleBackColor = true;
            this.cbVlcMaskPin5.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // cbVlcMaskPin3
            // 
            this.cbVlcMaskPin3.AutoSize = true;
            this.cbVlcMaskPin3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbVlcMaskPin3.FlatAppearance.BorderSize = 2;
            this.cbVlcMaskPin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVlcMaskPin3.ForeColor = System.Drawing.Color.Crimson;
            this.cbVlcMaskPin3.Location = new System.Drawing.Point(153, 19);
            this.cbVlcMaskPin3.Name = "cbVlcMaskPin3";
            this.cbVlcMaskPin3.Size = new System.Drawing.Size(39, 31);
            this.cbVlcMaskPin3.TabIndex = 61;
            this.cbVlcMaskPin3.Text = "PIN3";
            this.cbVlcMaskPin3.UseVisualStyleBackColor = true;
            this.cbVlcMaskPin3.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // cbVlcMaskPin4
            // 
            this.cbVlcMaskPin4.AutoSize = true;
            this.cbVlcMaskPin4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbVlcMaskPin4.FlatAppearance.BorderSize = 2;
            this.cbVlcMaskPin4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVlcMaskPin4.ForeColor = System.Drawing.Color.Crimson;
            this.cbVlcMaskPin4.Location = new System.Drawing.Point(116, 19);
            this.cbVlcMaskPin4.Name = "cbVlcMaskPin4";
            this.cbVlcMaskPin4.Size = new System.Drawing.Size(39, 31);
            this.cbVlcMaskPin4.TabIndex = 62;
            this.cbVlcMaskPin4.Text = "PIN4";
            this.cbVlcMaskPin4.UseVisualStyleBackColor = true;
            this.cbVlcMaskPin4.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // MTB_FavoriteListPath
            // 
            this.MTB_FavoriteListPath.Location = new System.Drawing.Point(154, 45);
            this.MTB_FavoriteListPath.Name = "MTB_FavoriteListPath";
            this.MTB_FavoriteListPath.Size = new System.Drawing.Size(237, 22);
            this.MTB_FavoriteListPath.TabIndex = 36;
            // 
            // buttonVlcFavoriteListPath
            // 
            this.buttonVlcFavoriteListPath.Location = new System.Drawing.Point(397, 46);
            this.buttonVlcFavoriteListPath.Name = "buttonVlcFavoriteListPath";
            this.buttonVlcFavoriteListPath.Size = new System.Drawing.Size(23, 23);
            this.buttonVlcFavoriteListPath.TabIndex = 35;
            this.buttonVlcFavoriteListPath.Text = "...";
            this.buttonVlcFavoriteListPath.UseVisualStyleBackColor = true;
            this.buttonVlcFavoriteListPath.Click += new System.EventHandler(this.BTN_VlcFavoriteListPath_Click);
            // 
            // buttonVlcPlayListPath
            // 
            this.buttonVlcPlayListPath.Location = new System.Drawing.Point(397, 20);
            this.buttonVlcPlayListPath.Name = "buttonVlcPlayListPath";
            this.buttonVlcPlayListPath.Size = new System.Drawing.Size(23, 23);
            this.buttonVlcPlayListPath.TabIndex = 38;
            this.buttonVlcPlayListPath.Text = "...";
            this.buttonVlcPlayListPath.UseVisualStyleBackColor = true;
            this.buttonVlcPlayListPath.Click += new System.EventHandler(this.BTN_VlcPlayListPath_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Основной плейлист";
            // 
            // lblRememberVolumes
            // 
            this.lblRememberVolumes.AutoSize = true;
            this.lblRememberVolumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRememberVolumes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRememberVolumes.Location = new System.Drawing.Point(28, 89);
            this.lblRememberVolumes.Name = "lblRememberVolumes";
            this.lblRememberVolumes.Size = new System.Drawing.Size(266, 17);
            this.lblRememberVolumes.TabIndex = 69;
            this.lblRememberVolumes.Text = "Запоминать громкость каждого канала";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(1, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 17);
            this.label21.TabIndex = 37;
            this.label21.Text = "Плейлист избранных";
            // 
            // lblUseSlaveMonitor
            // 
            this.lblUseSlaveMonitor.AutoSize = true;
            this.lblUseSlaveMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUseSlaveMonitor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUseSlaveMonitor.Location = new System.Drawing.Point(28, 70);
            this.lblUseSlaveMonitor.Name = "lblUseSlaveMonitor";
            this.lblUseSlaveMonitor.Size = new System.Drawing.Size(210, 17);
            this.lblUseSlaveMonitor.TabIndex = 67;
            this.lblUseSlaveMonitor.Text = "Использовать второй монитор";
            // 
            // CHBOX_UseSlaveMonitor
            // 
            this.CHBOX_UseSlaveMonitor.AutoSize = true;
            this.CHBOX_UseSlaveMonitor.Location = new System.Drawing.Point(7, 72);
            this.CHBOX_UseSlaveMonitor.Name = "CHBOX_UseSlaveMonitor";
            this.CHBOX_UseSlaveMonitor.Size = new System.Drawing.Size(15, 14);
            this.CHBOX_UseSlaveMonitor.TabIndex = 68;
            this.CHBOX_UseSlaveMonitor.UseVisualStyleBackColor = true;
            this.CHBOX_UseSlaveMonitor.Click += new System.EventHandler(this.CHB_UseSlaveMonitor_Click);
            // 
            // RBTN_MainVlcPlayList
            // 
            this.RBTN_MainVlcPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RBTN_MainVlcPlayList.Location = new System.Drawing.Point(6, 8);
            this.RBTN_MainVlcPlayList.Name = "RBTN_MainVlcPlayList";
            this.RBTN_MainVlcPlayList.Size = new System.Drawing.Size(148, 20);
            this.RBTN_MainVlcPlayList.TabIndex = 55;
            this.RBTN_MainVlcPlayList.Text = "Список всех каналов";
            this.RBTN_MainVlcPlayList.UseVisualStyleBackColor = true;
            this.RBTN_MainVlcPlayList.CheckedChanged += new System.EventHandler(this.RBTN_MainVlcPlayList_CheckedChanged);
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.ImageIndex = 2;
            this.buttonPlayPause.ImageList = this.imageList1;
            this.buttonPlayPause.Location = new System.Drawing.Point(415, 10);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(46, 20);
            this.buttonPlayPause.TabIndex = 54;
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "baseline_volume_up_black_18dp.png");
            this.imageList1.Images.SetKeyName(1, "baseline_volume_off_black_18dp.png");
            this.imageList1.Images.SetKeyName(2, "outline_pause_black_18dp.png");
            this.imageList1.Images.SetKeyName(3, "twotone_play_arrow_black_18dp.png");
            // 
            // BTN_Mute
            // 
            this.BTN_Mute.ImageIndex = 1;
            this.BTN_Mute.ImageList = this.imageList1;
            this.BTN_Mute.Location = new System.Drawing.Point(701, 10);
            this.BTN_Mute.Name = "BTN_Mute";
            this.BTN_Mute.Size = new System.Drawing.Size(45, 20);
            this.BTN_Mute.TabIndex = 53;
            this.BTN_Mute.UseVisualStyleBackColor = true;
            this.BTN_Mute.Click += new System.EventHandler(this.BTN_Mute_Click);
            // 
            // TXTBOX_VlcVolume
            // 
            this.TXTBOX_VlcVolume.Location = new System.Drawing.Point(519, 8);
            this.TXTBOX_VlcVolume.Maximum = 255;
            this.TXTBOX_VlcVolume.Name = "TXTBOX_VlcVolume";
            this.TXTBOX_VlcVolume.Size = new System.Drawing.Size(176, 45);
            this.TXTBOX_VlcVolume.TabIndex = 50;
            this.TXTBOX_VlcVolume.ValueChanged += new System.EventHandler(this.TRBAR_VlcVolume_ValueChanged);
            // 
            // buttonVlcStop
            // 
            this.buttonVlcStop.Image = global::SmartHome_v1.Properties.Resources.baseline_stop_black_18dp;
            this.buttonVlcStop.Location = new System.Drawing.Point(467, 10);
            this.buttonVlcStop.Name = "buttonVlcStop";
            this.buttonVlcStop.Size = new System.Drawing.Size(46, 20);
            this.buttonVlcStop.TabIndex = 49;
            this.buttonVlcStop.UseVisualStyleBackColor = true;
            this.buttonVlcStop.Click += new System.EventHandler(this.BTN_VlcStop_Click);
            // 
            // rtbVlcLog
            // 
            this.rtbVlcLog.Location = new System.Drawing.Point(339, 240);
            this.rtbVlcLog.Name = "rtbVlcLog";
            this.rtbVlcLog.Size = new System.Drawing.Size(426, 58);
            this.rtbVlcLog.TabIndex = 48;
            this.rtbVlcLog.Text = "";
            // 
            // RBTN_FavoriteVlcPlayList
            // 
            this.RBTN_FavoriteVlcPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RBTN_FavoriteVlcPlayList.Image = ((System.Drawing.Image)(resources.GetObject("RBTN_FavoriteVlcPlayList.Image")));
            this.RBTN_FavoriteVlcPlayList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBTN_FavoriteVlcPlayList.Location = new System.Drawing.Point(164, 8);
            this.RBTN_FavoriteVlcPlayList.Name = "RBTN_FavoriteVlcPlayList";
            this.RBTN_FavoriteVlcPlayList.Size = new System.Drawing.Size(146, 24);
            this.RBTN_FavoriteVlcPlayList.TabIndex = 47;
            this.RBTN_FavoriteVlcPlayList.Text = "Избранные";
            this.RBTN_FavoriteVlcPlayList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RBTN_FavoriteVlcPlayList.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Coral;
            this.label20.Location = new System.Drawing.Point(590, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 16);
            this.label20.TabIndex = 43;
            // 
            // LBOX_VlcPlaylistURLs
            // 
            this.LBOX_VlcPlaylistURLs.FormattingEnabled = true;
            this.LBOX_VlcPlaylistURLs.ItemHeight = 16;
            this.LBOX_VlcPlaylistURLs.Location = new System.Drawing.Point(13, 215);
            this.LBOX_VlcPlaylistURLs.Name = "LBOX_VlcPlaylistURLs";
            this.LBOX_VlcPlaylistURLs.Size = new System.Drawing.Size(126, 52);
            this.LBOX_VlcPlaylistURLs.TabIndex = 27;
            this.LBOX_VlcPlaylistURLs.Visible = false;
            // 
            // LBOX_VlcFavoriteURLs
            // 
            this.LBOX_VlcFavoriteURLs.FormattingEnabled = true;
            this.LBOX_VlcFavoriteURLs.ItemHeight = 16;
            this.LBOX_VlcFavoriteURLs.Location = new System.Drawing.Point(172, 215);
            this.LBOX_VlcFavoriteURLs.Name = "LBOX_VlcFavoriteURLs";
            this.LBOX_VlcFavoriteURLs.Size = new System.Drawing.Size(124, 52);
            this.LBOX_VlcFavoriteURLs.TabIndex = 42;
            this.LBOX_VlcFavoriteURLs.Visible = false;
            // 
            // LISTB_VlcFavoriteTitles
            // 
            this.LISTB_VlcFavoriteTitles.ContextMenuStrip = this.contextMenuStripPlaylist;
            this.LISTB_VlcFavoriteTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LISTB_VlcFavoriteTitles.FormattingEnabled = true;
            this.LISTB_VlcFavoriteTitles.ItemHeight = 20;
            this.LISTB_VlcFavoriteTitles.Location = new System.Drawing.Point(160, 34);
            this.LISTB_VlcFavoriteTitles.Name = "LISTB_VlcFavoriteTitles";
            this.LISTB_VlcFavoriteTitles.Size = new System.Drawing.Size(150, 284);
            this.LISTB_VlcFavoriteTitles.TabIndex = 36;
            this.LISTB_VlcFavoriteTitles.Click += new System.EventHandler(this.LBOX_VlcFavoriteList_Click);
            this.LISTB_VlcFavoriteTitles.DoubleClick += new System.EventHandler(this.LBOX_VlcFavoriteTitles_DoubleClick);
            // 
            // LISTB_VlcPlaylistTitles
            // 
            this.LISTB_VlcPlaylistTitles.ContextMenuStrip = this.contextMenuStripPlaylist;
            this.LISTB_VlcPlaylistTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LISTB_VlcPlaylistTitles.FormattingEnabled = true;
            this.LISTB_VlcPlaylistTitles.ItemHeight = 20;
            this.LISTB_VlcPlaylistTitles.Location = new System.Drawing.Point(4, 34);
            this.LISTB_VlcPlaylistTitles.Name = "LISTB_VlcPlaylistTitles";
            this.LISTB_VlcPlaylistTitles.Size = new System.Drawing.Size(150, 284);
            this.LISTB_VlcPlaylistTitles.TabIndex = 35;
            this.LISTB_VlcPlaylistTitles.Click += new System.EventHandler(this.LBOX_VlcPlayList_Click);
            this.LISTB_VlcPlaylistTitles.DoubleClick += new System.EventHandler(this.LBOX_VlcPlaylistTitles_DoubleClick);
            this.LISTB_VlcPlaylistTitles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LBOX_VlcPlaylistTitles_MouseDown);
            // 
            // tabPageAudio
            // 
            this.tabPageAudio.Controls.Add(this.pbHighFreq);
            this.tabPageAudio.Controls.Add(this.pbMiddleFreq);
            this.tabPageAudio.Controls.Add(this.lblHighMax);
            this.tabPageAudio.Controls.Add(this.lblMiddleMax);
            this.tabPageAudio.Controls.Add(this.lblLowMax);
            this.tabPageAudio.Controls.Add(this.pbLowFreq);
            this.tabPageAudio.Controls.Add(this.label44);
            this.tabPageAudio.Controls.Add(this.label43);
            this.tabPageAudio.Controls.Add(this.label42);
            this.tabPageAudio.Controls.Add(this.label41);
            this.tabPageAudio.Controls.Add(this.label40);
            this.tabPageAudio.Controls.Add(this.nudHighFreq);
            this.tabPageAudio.Controls.Add(this.nudMiddleFreq);
            this.tabPageAudio.Controls.Add(this.nudLowFreq);
            this.tabPageAudio.Controls.Add(this.label39);
            this.tabPageAudio.Controls.Add(this.label31);
            this.tabPageAudio.Controls.Add(this.label30);
            this.tabPageAudio.Controls.Add(this.label23);
            this.tabPageAudio.Controls.Add(this.textBoxHighFreq);
            this.tabPageAudio.Controls.Add(this.tbMiddleFreq);
            this.tabPageAudio.Controls.Add(this.tbLowFreq);
            this.tabPageAudio.Controls.Add(this.btnStopRecord);
            this.tabPageAudio.Controls.Add(this.btnStartAudioStreamScan);
            this.tabPageAudio.Controls.Add(this.zedGraphControl1);
            this.tabPageAudio.Controls.Add(this.label22);
            this.tabPageAudio.Controls.Add(this.label13);
            this.tabPageAudio.Controls.Add(this.cbRenderDevices);
            this.tabPageAudio.Controls.Add(this.cbDevices);
            this.tabPageAudio.Location = new System.Drawing.Point(4, 25);
            this.tabPageAudio.Name = "tabPageAudio";
            this.tabPageAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAudio.Size = new System.Drawing.Size(777, 329);
            this.tabPageAudio.TabIndex = 8;
            this.tabPageAudio.Text = "Audio tools";
            this.tabPageAudio.UseVisualStyleBackColor = true;
            // 
            // pbHighFreq
            // 
            this.pbHighFreq.Location = new System.Drawing.Point(119, 280);
            this.pbHighFreq.Maximum = 255;
            this.pbHighFreq.Name = "pbHighFreq";
            this.pbHighFreq.Size = new System.Drawing.Size(100, 16);
            this.pbHighFreq.TabIndex = 61;
            this.pbHighFreq.Value = 20;
            // 
            // pbMiddleFreq
            // 
            this.pbMiddleFreq.Location = new System.Drawing.Point(119, 260);
            this.pbMiddleFreq.Maximum = 255;
            this.pbMiddleFreq.Name = "pbMiddleFreq";
            this.pbMiddleFreq.Size = new System.Drawing.Size(100, 16);
            this.pbMiddleFreq.TabIndex = 60;
            this.pbMiddleFreq.Value = 128;
            // 
            // lblHighMax
            // 
            this.lblHighMax.AutoSize = true;
            this.lblHighMax.BackColor = System.Drawing.Color.Red;
            this.lblHighMax.Location = new System.Drawing.Point(225, 280);
            this.lblHighMax.Name = "lblHighMax";
            this.lblHighMax.Size = new System.Drawing.Size(36, 16);
            this.lblHighMax.TabIndex = 59;
            this.lblHighMax.Text = "MAX";
            this.lblHighMax.Visible = false;
            // 
            // lblMiddleMax
            // 
            this.lblMiddleMax.AutoSize = true;
            this.lblMiddleMax.BackColor = System.Drawing.Color.Red;
            this.lblMiddleMax.Location = new System.Drawing.Point(225, 260);
            this.lblMiddleMax.Name = "lblMiddleMax";
            this.lblMiddleMax.Size = new System.Drawing.Size(36, 16);
            this.lblMiddleMax.TabIndex = 58;
            this.lblMiddleMax.Text = "MAX";
            this.lblMiddleMax.Visible = false;
            // 
            // lblLowMax
            // 
            this.lblLowMax.AutoSize = true;
            this.lblLowMax.BackColor = System.Drawing.Color.Red;
            this.lblLowMax.Location = new System.Drawing.Point(225, 240);
            this.lblLowMax.Name = "lblLowMax";
            this.lblLowMax.Size = new System.Drawing.Size(36, 16);
            this.lblLowMax.TabIndex = 57;
            this.lblLowMax.Text = "MAX";
            this.lblLowMax.Visible = false;
            // 
            // pbLowFreq
            // 
            this.pbLowFreq.Location = new System.Drawing.Point(119, 240);
            this.pbLowFreq.Maximum = 255;
            this.pbLowFreq.Name = "pbLowFreq";
            this.pbLowFreq.Size = new System.Drawing.Size(100, 16);
            this.pbLowFreq.TabIndex = 56;
            this.pbLowFreq.Value = 255;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.Color.Blue;
            this.label44.Location = new System.Drawing.Point(182, 123);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(43, 16);
            this.label44.TabIndex = 55;
            this.label44.Text = "BLUE";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.Color.Green;
            this.label43.Location = new System.Drawing.Point(182, 150);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(56, 16);
            this.label43.TabIndex = 54;
            this.label43.Text = "GREEN";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.Color.Red;
            this.label42.Location = new System.Drawing.Point(182, 178);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(37, 16);
            this.label42.TabIndex = 53;
            this.label42.Text = "RED";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(148, 175);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(28, 16);
            this.label41.TabIndex = 52;
            this.label41.Text = "Hz)";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(148, 149);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(28, 16);
            this.label40.TabIndex = 51;
            this.label40.Text = "Hz)";
            // 
            // nudHighFreq
            // 
            this.nudHighFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudHighFreq.Location = new System.Drawing.Point(82, 173);
            this.nudHighFreq.Margin = new System.Windows.Forms.Padding(0);
            this.nudHighFreq.Maximum = new decimal(new int[] {
            22000,
            0,
            0,
            0});
            this.nudHighFreq.Name = "nudHighFreq";
            this.nudHighFreq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudHighFreq.Size = new System.Drawing.Size(62, 23);
            this.nudHighFreq.TabIndex = 50;
            this.nudHighFreq.Value = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            // 
            // nudMiddleFreq
            // 
            this.nudMiddleFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudMiddleFreq.Location = new System.Drawing.Point(82, 147);
            this.nudMiddleFreq.Margin = new System.Windows.Forms.Padding(0);
            this.nudMiddleFreq.Maximum = new decimal(new int[] {
            22000,
            0,
            0,
            0});
            this.nudMiddleFreq.Name = "nudMiddleFreq";
            this.nudMiddleFreq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudMiddleFreq.Size = new System.Drawing.Size(62, 23);
            this.nudMiddleFreq.TabIndex = 49;
            this.nudMiddleFreq.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudLowFreq
            // 
            this.nudLowFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudLowFreq.Location = new System.Drawing.Point(82, 123);
            this.nudLowFreq.Margin = new System.Windows.Forms.Padding(0);
            this.nudLowFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLowFreq.Name = "nudLowFreq";
            this.nudLowFreq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudLowFreq.Size = new System.Drawing.Size(63, 23);
            this.nudLowFreq.TabIndex = 48;
            this.nudLowFreq.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(148, 125);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(28, 16);
            this.label39.TabIndex = 46;
            this.label39.Text = "Hz)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 175);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(62, 16);
            this.label31.TabIndex = 45;
            this.label31.Text = "High freq";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 150);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 16);
            this.label30.TabIndex = 44;
            this.label30.Text = "Middle freq";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 125);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 16);
            this.label23.TabIndex = 43;
            this.label23.Text = "Low freq";
            // 
            // textBoxHighFreq
            // 
            this.textBoxHighFreq.Location = new System.Drawing.Point(238, 175);
            this.textBoxHighFreq.Name = "textBoxHighFreq";
            this.textBoxHighFreq.Size = new System.Drawing.Size(69, 22);
            this.textBoxHighFreq.TabIndex = 42;
            // 
            // tbMiddleFreq
            // 
            this.tbMiddleFreq.Location = new System.Drawing.Point(238, 147);
            this.tbMiddleFreq.Name = "tbMiddleFreq";
            this.tbMiddleFreq.Size = new System.Drawing.Size(69, 22);
            this.tbMiddleFreq.TabIndex = 41;
            // 
            // tbLowFreq
            // 
            this.tbLowFreq.Location = new System.Drawing.Point(238, 119);
            this.tbLowFreq.Name = "tbLowFreq";
            this.tbLowFreq.Size = new System.Drawing.Size(69, 22);
            this.tbLowFreq.TabIndex = 40;
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.Enabled = false;
            this.btnStopRecord.Location = new System.Drawing.Point(373, 282);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(60, 23);
            this.btnStopRecord.TabIndex = 37;
            this.btnStopRecord.Text = "Стоп";
            this.btnStopRecord.UseVisualStyleBackColor = true;
            this.btnStopRecord.Click += new System.EventHandler(this.BTN_StopRecord_Click);
            // 
            // btnStartAudioStreamScan
            // 
            this.btnStartAudioStreamScan.Location = new System.Drawing.Point(309, 282);
            this.btnStartAudioStreamScan.Name = "btnStartAudioStreamScan";
            this.btnStartAudioStreamScan.Size = new System.Drawing.Size(58, 23);
            this.btnStartAudioStreamScan.TabIndex = 36;
            this.btnStartAudioStreamScan.Text = "Запись";
            this.btnStartAudioStreamScan.UseVisualStyleBackColor = true;
            this.btnStartAudioStreamScan.Click += new System.EventHandler(this.BTN_StartAudioStreamScan_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(328, 10);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(437, 266);
            this.zedGraphControl1.TabIndex = 35;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 16);
            this.label22.TabIndex = 33;
            this.label22.Text = "Output";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Input";
            // 
            // cbRenderDevices
            // 
            this.cbRenderDevices.FormattingEnabled = true;
            this.cbRenderDevices.Location = new System.Drawing.Point(70, 37);
            this.cbRenderDevices.Name = "cbRenderDevices";
            this.cbRenderDevices.Size = new System.Drawing.Size(237, 24);
            this.cbRenderDevices.TabIndex = 31;
            // 
            // cbDevices
            // 
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(70, 10);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(237, 24);
            this.cbDevices.TabIndex = 30;
            // 
            // tabPageLogger
            // 
            this.tabPageLogger.Controls.Add(this.MTB_LogFilePath);
            this.tabPageLogger.Controls.Add(this.buttonLogFilePath);
            this.tabPageLogger.Controls.Add(this.checkBox25);
            this.tabPageLogger.Controls.Add(this.label11);
            this.tabPageLogger.Controls.Add(this.RTBOX_Logger);
            this.tabPageLogger.Controls.Add(this.COMBOX_UsbDevicesList);
            this.tabPageLogger.Controls.Add(this.label1);
            this.tabPageLogger.Controls.Add(this.checkBox2);
            this.tabPageLogger.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogger.Name = "tabPageLogger";
            this.tabPageLogger.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogger.Size = new System.Drawing.Size(777, 329);
            this.tabPageLogger.TabIndex = 1;
            this.tabPageLogger.Text = "Debug/Logger";
            this.tabPageLogger.UseVisualStyleBackColor = true;
            // 
            // MTB_LogFilePath
            // 
            this.MTB_LogFilePath.Location = new System.Drawing.Point(161, 268);
            this.MTB_LogFilePath.Name = "MTB_LogFilePath";
            this.MTB_LogFilePath.Size = new System.Drawing.Size(311, 22);
            this.MTB_LogFilePath.TabIndex = 29;
            // 
            // buttonLogFilePath
            // 
            this.buttonLogFilePath.Location = new System.Drawing.Point(478, 266);
            this.buttonLogFilePath.Name = "buttonLogFilePath";
            this.buttonLogFilePath.Size = new System.Drawing.Size(23, 23);
            this.buttonLogFilePath.TabIndex = 26;
            this.buttonLogFilePath.Text = "...";
            this.buttonLogFilePath.UseVisualStyleBackColor = true;
            this.buttonLogFilePath.Click += new System.EventHandler(this.BTN_LogFilePath_Click);
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Checked = true;
            this.checkBox25.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox25.Location = new System.Drawing.Point(655, 268);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(107, 20);
            this.checkBox25.TabIndex = 16;
            this.checkBox25.Text = "Auto scrolling";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(4, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Log file path";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox2.Location = new System.Drawing.Point(66, 271);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 20);
            this.checkBox2.TabIndex = 43;
            this.checkBox2.Text = "(check if use)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // tabPageESP8266
            // 
            this.tabPageESP8266.Location = new System.Drawing.Point(4, 25);
            this.tabPageESP8266.Name = "tabPageESP8266";
            this.tabPageESP8266.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageESP8266.Size = new System.Drawing.Size(777, 329);
            this.tabPageESP8266.TabIndex = 4;
            this.tabPageESP8266.Text = "esp8266 CFG";
            this.tabPageESP8266.UseVisualStyleBackColor = true;
            // 
            // tabPageScales
            // 
            this.tabPageScales.Controls.Add(this.button21);
            this.tabPageScales.Controls.Add(this.textBox3);
            this.tabPageScales.Controls.Add(this.chart1);
            this.tabPageScales.Controls.Add(this.button10);
            this.tabPageScales.Controls.Add(this.panel8);
            this.tabPageScales.Controls.Add(this.panel7);
            this.tabPageScales.Controls.Add(this.label14);
            this.tabPageScales.Controls.Add(this.checkBox26);
            this.tabPageScales.Controls.Add(this.richTextBox2);
            this.tabPageScales.Location = new System.Drawing.Point(4, 25);
            this.tabPageScales.Name = "tabPageScales";
            this.tabPageScales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScales.Size = new System.Drawing.Size(777, 329);
            this.tabPageScales.TabIndex = 6;
            this.tabPageScales.Text = "Weight control";
            this.tabPageScales.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(238, 6);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(31, 23);
            this.button21.TabIndex = 41;
            this.button21.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 40;
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Time, H";
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Title = "Weight";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(9, 55);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(368, 164);
            this.chart1.TabIndex = 39;
            this.chart1.Text = "chart1";
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.Color.Green;
            this.button10.Location = new System.Drawing.Point(411, 30);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 23);
            this.button10.TabIndex = 38;
            this.button10.Text = "InitGraph";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.AccessibleName = "";
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.numericUpDown9);
            this.panel8.Controls.Add(this.numericUpDown8);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.checkBox28);
            this.panel8.Location = new System.Drawing.Point(423, 79);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(149, 185);
            this.panel8.TabIndex = 37;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(6, 71);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown9.TabIndex = 41;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(6, 47);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown8.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(64, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 40;
            this.label19.Text = "tare weight 2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(64, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 16);
            this.label18.TabIndex = 39;
            this.label18.Text = "tare weight 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(3, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 15);
            this.label16.TabIndex = 36;
            this.label16.Text = "device settings:";
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Checked = true;
            this.checkBox28.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox28.Location = new System.Drawing.Point(6, 24);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(124, 20);
            this.checkBox28.TabIndex = 34;
            this.checkBox28.Text = "- auto tare mode";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.AccessibleName = "";
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.numericUpDown7);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Location = new System.Drawing.Point(578, 79);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(129, 185);
            this.panel7.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "time refresh";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(70, 21);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown7.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "shell settings:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(6, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "Current weight:";
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Checked = true;
            this.checkBox26.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox26.Location = new System.Drawing.Point(6, 258);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(107, 20);
            this.checkBox26.TabIndex = 17;
            this.checkBox26.Text = "Auto scrolling";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 32);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(387, 223);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // tabPagePostMan
            // 
            this.tabPagePostMan.Controls.Add(this.groupBox1);
            this.tabPagePostMan.Location = new System.Drawing.Point(4, 25);
            this.tabPagePostMan.Name = "tabPagePostMan";
            this.tabPagePostMan.Size = new System.Drawing.Size(777, 329);
            this.tabPagePostMan.TabIndex = 9;
            this.tabPagePostMan.Text = "PostMan";
            this.tabPagePostMan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.COMBOX_HttpMethod);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.TBOX_HttpMethod);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Консоль";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 205);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ответ";
            // 
            // COMBOX_HttpMethod
            // 
            this.COMBOX_HttpMethod.FormattingEnabled = true;
            this.COMBOX_HttpMethod.Items.AddRange(new object[] {
            "GET /",
            "POST /"});
            this.COMBOX_HttpMethod.Location = new System.Drawing.Point(12, 19);
            this.COMBOX_HttpMethod.Name = "COMBOX_HttpMethod";
            this.COMBOX_HttpMethod.Size = new System.Drawing.Size(64, 24);
            this.COMBOX_HttpMethod.TabIndex = 4;
            this.COMBOX_HttpMethod.SelectedValueChanged += new System.EventHandler(this.CB_HttpMethod_SelectedValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Отправить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TBOX_HttpMethod
            // 
            this.TBOX_HttpMethod.Location = new System.Drawing.Point(82, 19);
            this.TBOX_HttpMethod.MaxLength = 3;
            this.TBOX_HttpMethod.Name = "TBOX_HttpMethod";
            this.TBOX_HttpMethod.Size = new System.Drawing.Size(43, 22);
            this.TBOX_HttpMethod.TabIndex = 0;
            // 
            // tabPageCAM
            // 
            this.tabPageCAM.Location = new System.Drawing.Point(4, 25);
            this.tabPageCAM.Name = "tabPageCAM";
            this.tabPageCAM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCAM.Size = new System.Drawing.Size(777, 329);
            this.tabPageCAM.TabIndex = 10;
            this.tabPageCAM.Text = "VideoCAM";
            this.tabPageCAM.UseVisualStyleBackColor = true;
            // 
            // btnRescanDevices
            // 
            this.btnRescanDevices.AutoSize = true;
            this.btnRescanDevices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRescanDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRescanDevices.Location = new System.Drawing.Point(710, 368);
            this.btnRescanDevices.Name = "btnRescanDevices";
            this.btnRescanDevices.Size = new System.Drawing.Size(67, 26);
            this.btnRescanDevices.TabIndex = 46;
            this.btnRescanDevices.Text = "ReScan";
            this.btnRescanDevices.UseVisualStyleBackColor = true;
            this.btnRescanDevices.Click += new System.EventHandler(this.BTN_RescanDevices_Click);
            // 
            // SERIALPORT_RgbTape
            // 
            this.SERIALPORT_RgbTape.BaudRate = 115200;
            this.SERIALPORT_RgbTape.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortRgbTapeDevice_DataReceived);
            // 
            // serialPortScales
            // 
            this.serialPortScales.BaudRate = 115200;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "СписочеГ";
            // 
            // TMR_Ambilight
            // 
            this.TMR_Ambilight.Interval = 1000;
            this.TMR_Ambilight.Tick += new System.EventHandler(this.TMR_Ambilight_Tick);
            // 
            // timerRgbSheduler
            // 
            this.timerRgbSheduler.Interval = 30000;
            this.timerRgbSheduler.Tick += new System.EventHandler(this.TMR_RgbSheduler_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 395);
            this.Controls.Add(this.btnRescanDevices);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Smart Home v.1.0 (Build: 040620)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSleepModeTimeout)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageSmartHome.ResumeLayout(false);
            this.tabPageSmartHome.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gbRegisterValues.ResumeLayout(false);
            this.gbRegisterValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Encoder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Encoder0)).EndInit();
            this.gbBuzzerSettings.ResumeLayout(false);
            this.gbBuzzerSettings.PerformLayout();
            this.gbSensorsState.ResumeLayout(false);
            this.gbSensorsState.PerformLayout();
            this.panelCurrentGpio.ResumeLayout(false);
            this.panelCurrentGpio.PerformLayout();
            this.panelHotGpio.ResumeLayout(false);
            this.panelHotGpio.PerformLayout();
            this.panelSleepGpio.ResumeLayout(false);
            this.panelSleepGpio.PerformLayout();
            this.tabPageRGB.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbSheduler.ResumeLayout(false);
            this.gbSheduler.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChannelNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbFreq)).EndInit();
            this.tabPageVLC.ResumeLayout(false);
            this.tabPageVLC.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GRBOX_VlcGpioSettings.ResumeLayout(false);
            this.GRBOX_VlcGpioSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTBOX_VlcVolume)).EndInit();
            this.tabPageAudio.ResumeLayout(false);
            this.tabPageAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiddleFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowFreq)).EndInit();
            this.tabPageLogger.ResumeLayout(false);
            this.tabPageLogger.PerformLayout();
            this.tabPageScales.ResumeLayout(false);
            this.tabPageScales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            this.tabPagePostMan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SERIALPORT_SmartHome;
        private System.Windows.Forms.ComboBox COMBOX_UsbDevicesList;
        private System.Windows.Forms.RichTextBox RTBOX_Logger;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabelRgbTape;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSmartHome;
        private System.Windows.Forms.TabPage tabPageLogger;
        private System.Windows.Forms.TabPage tabPageVLC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CHBOX_SleepModeMaskPin8;
        private System.Windows.Forms.CheckBox CHBOX_SleepModeMaskPin7;
        private System.Windows.Forms.CheckBox CHBOX_SleepModeMaskPin6;
        private System.Windows.Forms.CheckBox CHBOX_SleepModeMaskPin5;
        private System.Windows.Forms.CheckBox CHBOX_SleepModeMaskPin4;
        private System.Windows.Forms.CheckBox CHBOX_SleepModeMaskPin3;
        private System.Windows.Forms.CheckBox CHBOX_SleepModeMaskPin2;
        private System.Windows.Forms.CheckBox CHBOX_SleepModeMaskPin1;
        private System.Windows.Forms.Panel panelSleepGpio;
        private System.Windows.Forms.Panel panelHotGpio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CHBOX_HotButtonMask8;
        private System.Windows.Forms.CheckBox CHBOX_HotButtonMask1;
        private System.Windows.Forms.CheckBox CHBOX_HotButtonMask7;
        private System.Windows.Forms.CheckBox CHBOX_HotButtonMask2;
        private System.Windows.Forms.CheckBox CHBOX_HotButtonMask6;
        private System.Windows.Forms.CheckBox CHBOX_HotButtonMask3;
        private System.Windows.Forms.CheckBox CHBOX_HotButtonMask5;
        private System.Windows.Forms.CheckBox CHBOX_HotButtonMask4;
        private System.Windows.Forms.Panel panelCurrentGpio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CHBOX_StatusPin7;
        private System.Windows.Forms.CheckBox CHBOX_StatusPin0;
        private System.Windows.Forms.CheckBox CHBOX_StatusPin6;
        private System.Windows.Forms.CheckBox CHBOX_StatusPin1;
        private System.Windows.Forms.CheckBox CHBOX_StatusPin5;
        private System.Windows.Forms.CheckBox CHBOX_StatusPin2;
        private System.Windows.Forms.CheckBox CHBOX_StatusPin4;
        private System.Windows.Forms.CheckBox CHBOX_StatusPin3;
        private System.Windows.Forms.NumericUpDown numericUpDownSleepModeTimeout;
        private System.Windows.Forms.TabPage tabPageESP8266;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NUD_Encoder0;
        private System.IO.Ports.SerialPort SERIALPORT_RgbTape;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel TOOLSTRIP_StatusLabelSmartHome;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.TabPage tabPageRGB;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.Button btnNormalMode;
        private System.Windows.Forms.Button btnBlynkMode;
        private System.Windows.Forms.NumericUpDown nudChannelNumber;
        private System.Windows.Forms.NumericUpDown nudRgbFreq;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabPage tabPageScales;
        private System.IO.Ports.SerialPort serialPortScales;
        private System.Windows.Forms.Button buttonSendDataToDevice;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.TextBox tbDataToSend;
        private System.Windows.Forms.Button btnGetDesktopColor;
        private System.Windows.Forms.Button btnSaveRgbCfg;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.NumericUpDown NUD_Encoder1;
        private System.Windows.Forms.Button buttonLogFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.MaskedTextBox MTB_LogFilePath;
        private System.Windows.Forms.TabPage tabPageAudio;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.ComboBox cbDevices;
        private System.Windows.Forms.ListBox LISTB_VlcPlaylistTitles;
        private System.Windows.Forms.Button btnRescanDevices;
        private System.Windows.Forms.ListBox LISTB_VlcFavoriteTitles;
        private System.Windows.Forms.ListBox LBOX_VlcFavoriteURLs;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonVlcPlayListPath;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox MTB_FavoriteListPath;
        private System.Windows.Forms.Button buttonVlcFavoriteListPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox MTB_PlayListPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPlaylist;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.RadioButton RBTN_FavoriteVlcPlayList;
        private System.Windows.Forms.RichTextBox rtbVlcLog;
        private System.Windows.Forms.Button buttonVlcStop;
        private System.Windows.Forms.ComboBox cbRenderDevices;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPixel;
        private System.Windows.Forms.Label lblBLUE;
        private System.Windows.Forms.Label lblGREEN;
        private System.Windows.Forms.Label lblRED;
        private System.Windows.Forms.ComboBox COMBOX_RgbSendString;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox CHBOX_UsedGpioForVlcMask;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TrackBar TXTBOX_VlcVolume;
        private System.Windows.Forms.CheckBox CHBOX_Ambilight;
        private System.Windows.Forms.Label lblUseAmbilight;
        private System.Windows.Forms.Button BTN_Mute;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer TMR_Ambilight;
        private System.Windows.Forms.CheckBox cbVlcMaskPin1;
        private System.Windows.Forms.CheckBox cbVlcMaskPin0;
        private System.Windows.Forms.CheckBox cbVlcMaskPin2;
        private System.Windows.Forms.CheckBox cbVlcMaskPin3;
        private System.Windows.Forms.CheckBox cbVlcMaskPin4;
        private System.Windows.Forms.CheckBox cbVlcMaskPin7;
        private System.Windows.Forms.CheckBox cbVlcMaskPin6;
        private System.Windows.Forms.CheckBox cbVlcMaskPin5;
        private System.Windows.Forms.GroupBox GRBOX_VlcGpioSettings;
        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.CheckBox CHBOX_UseSlaveMonitor;
        private System.Windows.Forms.Label lblUseSlaveMonitor;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.RadioButton RBTN_MainVlcPlayList;
        private System.Windows.Forms.CheckBox CHBOX_RememberChVol;
        private System.Windows.Forms.Label lblRememberVolumes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnStartAudioStreamScan;
        private System.Windows.Forms.TabPage tabPagePostMan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox COMBOX_HttpMethod;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TBOX_HttpMethod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStopRecord;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox checkBoxFullScreen;
        private System.Windows.Forms.Label lblFullScreen;
        private System.Windows.Forms.GroupBox gbSheduler;
        private System.Windows.Forms.CheckBox CHBOX_Sheduler;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button BTN_Color00;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button BTN_Color03;
        private System.Windows.Forms.Button BTN_Color01;
        private System.Windows.Forms.Button BTN_Color02;
        private System.Windows.Forms.Button BTN_Color04;
        private System.Windows.Forms.Button BTN_Color05;
        private System.Windows.Forms.Button BTN_Color06;
        private System.Windows.Forms.Button BTN_Color07;
        private System.Windows.Forms.Button BTN_Color08;
        private System.Windows.Forms.Button BTN_Color09;
        private System.Windows.Forms.Button BTN_Color10;
        private System.Windows.Forms.Button BTN_Color11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BTN_Color15;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Button BTN_Color12;
        private System.Windows.Forms.Button BTN_Color13;
        private System.Windows.Forms.Button BTN_Color14;
        private System.Windows.Forms.Button BTN_Color16;
        private System.Windows.Forms.Button BTN_Color17;
        private System.Windows.Forms.Button BTN_Color18;
        private System.Windows.Forms.Button BTN_Color19;
        private System.Windows.Forms.Button BTN_Color20;
        private System.Windows.Forms.Button BTN_Color21;
        private System.Windows.Forms.Button btnColor22;
        private System.Windows.Forms.Button btnColor23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Timer timerRgbSheduler;
        private System.Windows.Forms.TabPage tabPageCAM;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbSensorsState;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTN_Sensor7;
        private System.Windows.Forms.Button BTN_Sensor6;
        private System.Windows.Forms.Button BTN_Sensor5;
        private System.Windows.Forms.Button BTN_Sensor4;
        private System.Windows.Forms.Button BTN_Sensor3;
        private System.Windows.Forms.Button BTN_Sensor2;
        private System.Windows.Forms.Button BTN_Sensor1;
        private System.Windows.Forms.Button BTN_Sensor0;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button buttonSaveSmartHomeCfg;
        private System.Windows.Forms.GroupBox gbBuzzerSettings;
        private System.Windows.Forms.CheckBox CHBOX_BuzzerBit6;
        private System.Windows.Forms.CheckBox CHBOX_BuzzerBit4;
        private System.Windows.Forms.CheckBox CHBOX_BuzzerBit5;
        private System.Windows.Forms.CheckBox CHBOX_BuzzerBit3;
        private System.Windows.Forms.CheckBox CHBOX_BuzzerBit2;
        private System.Windows.Forms.CheckBox CHBOX_BuzzerBit1;
        private System.Windows.Forms.CheckBox CHBOX_BuzzerBit0;
        private System.Windows.Forms.GroupBox gbRegisterValues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbLowFreq;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown nudHighFreq;
        private System.Windows.Forms.NumericUpDown nudMiddleFreq;
        private System.Windows.Forms.NumericUpDown nudLowFreq;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxHighFreq;
        private System.Windows.Forms.TextBox tbMiddleFreq;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ProgressBar pbLowFreq;
        private System.Windows.Forms.Label lblLowMax;
        private System.Windows.Forms.Label lblHighMax;
        private System.Windows.Forms.Label lblMiddleMax;
        private System.Windows.Forms.ProgressBar pbHighFreq;
        private System.Windows.Forms.ProgressBar pbMiddleFreq;
        private System.Windows.Forms.ListBox LBOX_VlcPlaylistURLs;
    }
}

