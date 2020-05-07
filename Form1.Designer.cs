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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPortSmartHome = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxUsbDevicesList = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSmartHome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRgbTape = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStripPlaylist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownSleepModeTimeout = new System.Windows.Forms.NumericUpDown();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSmartHome = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownEncoder1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEncoder0 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxBuzzerBit6 = new System.Windows.Forms.CheckBox();
            this.checkBoxBuzzerBit4 = new System.Windows.Forms.CheckBox();
            this.checkBoxBuzzerBit5 = new System.Windows.Forms.CheckBox();
            this.checkBoxBuzzerBit3 = new System.Windows.Forms.CheckBox();
            this.checkBoxBuzzerBit2 = new System.Windows.Forms.CheckBox();
            this.checkBoxBuzzerBit1 = new System.Windows.Forms.CheckBox();
            this.checkBoxBuzzerBit0 = new System.Windows.Forms.CheckBox();
            this.buttonSaveSmartHomeCfg = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSensor7 = new System.Windows.Forms.Button();
            this.buttonSensor6 = new System.Windows.Forms.Button();
            this.buttonSensor5 = new System.Windows.Forms.Button();
            this.buttonSensor4 = new System.Windows.Forms.Button();
            this.buttonSensor3 = new System.Windows.Forms.Button();
            this.buttonSensor2 = new System.Windows.Forms.Button();
            this.buttonSensor1 = new System.Windows.Forms.Button();
            this.buttonSensor0 = new System.Windows.Forms.Button();
            this.buttonSendDataToDevice = new System.Windows.Forms.Button();
            this.textBoxDataToSend = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxStatusPin7 = new System.Windows.Forms.CheckBox();
            this.checkBoxStatusPin0 = new System.Windows.Forms.CheckBox();
            this.checkBoxStatusPin6 = new System.Windows.Forms.CheckBox();
            this.checkBoxStatusPin1 = new System.Windows.Forms.CheckBox();
            this.checkBoxStatusPin5 = new System.Windows.Forms.CheckBox();
            this.checkBoxStatusPin2 = new System.Windows.Forms.CheckBox();
            this.checkBoxStatusPin4 = new System.Windows.Forms.CheckBox();
            this.checkBoxStatusPin3 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxHotButtonMask8 = new System.Windows.Forms.CheckBox();
            this.checkBoxHotButtonMask1 = new System.Windows.Forms.CheckBox();
            this.checkBoxHotButtonMask7 = new System.Windows.Forms.CheckBox();
            this.checkBoxHotButtonMask2 = new System.Windows.Forms.CheckBox();
            this.checkBoxHotButtonMask6 = new System.Windows.Forms.CheckBox();
            this.checkBoxHotButtonMask3 = new System.Windows.Forms.CheckBox();
            this.checkBoxHotButtonMask5 = new System.Windows.Forms.CheckBox();
            this.checkBoxHotButtonMask4 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSleepModeMaskPin8 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxSleepModeMaskPin1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSleepModeMaskPin7 = new System.Windows.Forms.CheckBox();
            this.checkBoxSleepModeMaskPin2 = new System.Windows.Forms.CheckBox();
            this.checkBoxSleepModeMaskPin6 = new System.Windows.Forms.CheckBox();
            this.checkBoxSleepModeMaskPin3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSleepModeMaskPin5 = new System.Windows.Forms.CheckBox();
            this.checkBoxSleepModeMaskPin4 = new System.Windows.Forms.CheckBox();
            this.tabPageRGB = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelBLUE = new System.Windows.Forms.Label();
            this.checkBoxAmbilight = new System.Windows.Forms.CheckBox();
            this.groupBoxSheduler = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.buttonColor15 = new System.Windows.Forms.Button();
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
            this.buttonColor12 = new System.Windows.Forms.Button();
            this.buttonColor13 = new System.Windows.Forms.Button();
            this.buttonColor14 = new System.Windows.Forms.Button();
            this.buttonColor16 = new System.Windows.Forms.Button();
            this.buttonColor17 = new System.Windows.Forms.Button();
            this.buttonColor18 = new System.Windows.Forms.Button();
            this.buttonColor19 = new System.Windows.Forms.Button();
            this.buttonColor20 = new System.Windows.Forms.Button();
            this.buttonColor21 = new System.Windows.Forms.Button();
            this.buttonColor22 = new System.Windows.Forms.Button();
            this.buttonColor23 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.buttonColor03 = new System.Windows.Forms.Button();
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
            this.buttonColor00 = new System.Windows.Forms.Button();
            this.buttonColor01 = new System.Windows.Forms.Button();
            this.buttonColor02 = new System.Windows.Forms.Button();
            this.buttonColor04 = new System.Windows.Forms.Button();
            this.buttonColor05 = new System.Windows.Forms.Button();
            this.buttonColor06 = new System.Windows.Forms.Button();
            this.buttonColor07 = new System.Windows.Forms.Button();
            this.buttonColor08 = new System.Windows.Forms.Button();
            this.buttonColor09 = new System.Windows.Forms.Button();
            this.buttonColor10 = new System.Windows.Forms.Button();
            this.buttonColor11 = new System.Windows.Forms.Button();
            this.checkBoxSheduler = new System.Windows.Forms.CheckBox();
            this.button18 = new System.Windows.Forms.Button();
            this.labelGREEN = new System.Windows.Forms.Label();
            this.comboBoxRgbSendString = new System.Windows.Forms.ComboBox();
            this.labelRED = new System.Windows.Forms.Label();
            this.labelUseAmbilight = new System.Windows.Forms.Label();
            this.labelPixel = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.numericUpDownChannelNumber = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button16 = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.numericUpDownRgbFreq = new System.Windows.Forms.NumericUpDown();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tabPageVLC = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxFullScreen = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxRememberChVol = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxPlayListPath = new System.Windows.Forms.MaskedTextBox();
            this.grbHostSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxVlcMaskPin1 = new System.Windows.Forms.CheckBox();
            this.checkBoxVlcMaskPin7 = new System.Windows.Forms.CheckBox();
            this.checkBoxVlcMaskPin0 = new System.Windows.Forms.CheckBox();
            this.checkBoxVlcGpioMask = new System.Windows.Forms.CheckBox();
            this.checkBoxVlcMaskPin6 = new System.Windows.Forms.CheckBox();
            this.checkBoxVlcMaskPin2 = new System.Windows.Forms.CheckBox();
            this.checkBoxVlcMaskPin5 = new System.Windows.Forms.CheckBox();
            this.checkBoxVlcMaskPin3 = new System.Windows.Forms.CheckBox();
            this.checkBoxVlcMaskPin4 = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxFavoriteListPath = new System.Windows.Forms.MaskedTextBox();
            this.buttonVlcFavoriteListPath = new System.Windows.Forms.Button();
            this.buttonVlcPlayListPath = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.checkBoxUseSlaveMonitor = new System.Windows.Forms.CheckBox();
            this.radioButtonMainVlcPlayList = new System.Windows.Forms.RadioButton();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonSaveCfg = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.trackBarVlcVolume = new System.Windows.Forms.TrackBar();
            this.buttonVlcStop = new System.Windows.Forms.Button();
            this.richTextBoxVlcLog = new System.Windows.Forms.RichTextBox();
            this.radioButtonFavoriteVlcPlayList = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.listBoxVlcPlaylistURLs = new System.Windows.Forms.ListBox();
            this.listBoxVlcFavoriteURLs = new System.Windows.Forms.ListBox();
            this.listBoxVlcFavoriteTitles = new System.Windows.Forms.ListBox();
            this.listBoxVlcPlaylistTitles = new System.Windows.Forms.ListBox();
            this.tabPageAudio = new System.Windows.Forms.TabPage();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.numericUpDownHighFreq = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMiddleFreq = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLowFreq = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxHighFreq = new System.Windows.Forms.TextBox();
            this.textBoxMiddleFreq = new System.Windows.Forms.TextBox();
            this.textBoxLowFreq = new System.Windows.Forms.TextBox();
            this.buttonStopRecord = new System.Windows.Forms.Button();
            this.buttonStartAudioStreamScan = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxRenderDevices = new System.Windows.Forms.ComboBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.tabPageLogger = new System.Windows.Forms.TabPage();
            this.maskedTextBoxLogFilePath = new System.Windows.Forms.MaskedTextBox();
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
            this.comboBoxHttpMethod = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxHttpMethod = new System.Windows.Forms.TextBox();
            this.tabPageCAM = new System.Windows.Forms.TabPage();
            this.btnRescanDevices = new System.Windows.Forms.Button();
            this.serialPortRgbTape = new System.IO.Ports.SerialPort(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.serialPortScales = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerAmbilight = new System.Windows.Forms.Timer(this.components);
            this.timerRgbSheduler = new System.Windows.Forms.Timer(this.components);
            this.progressBarLowFreq = new System.Windows.Forms.ProgressBar();
            this.labelLowMax = new System.Windows.Forms.Label();
            this.labelMiddleMax = new System.Windows.Forms.Label();
            this.labelHighMax = new System.Windows.Forms.Label();
            this.progressBarMiddleFreq = new System.Windows.Forms.ProgressBar();
            this.progressBarHighFreq = new System.Windows.Forms.ProgressBar();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSleepModeTimeout)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageSmartHome.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEncoder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEncoder0)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageRGB.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBoxSheduler.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChannelNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRgbFreq)).BeginInit();
            this.tabPageVLC.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbHostSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVlcVolume)).BeginInit();
            this.tabPageAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiddleFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowFreq)).BeginInit();
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
            // serialPortSmartHome
            // 
            this.serialPortSmartHome.BaudRate = 115200;
            this.serialPortSmartHome.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortSmartHomeDevice_DataReceived);
            // 
            // comboBoxUsbDevicesList
            // 
            this.comboBoxUsbDevicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUsbDevicesList.FormattingEnabled = true;
            this.comboBoxUsbDevicesList.Location = new System.Drawing.Point(6, 28);
            this.comboBoxUsbDevicesList.Name = "comboBoxUsbDevicesList";
            this.comboBoxUsbDevicesList.Size = new System.Drawing.Size(97, 24);
            this.comboBoxUsbDevicesList.TabIndex = 5;
            this.comboBoxUsbDevicesList.Text = "<select>";
            this.comboBoxUsbDevicesList.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(743, 256);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelSmartHome,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabelRgbTape,
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
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(43, 22);
            this.toolStripStatusLabel3.Text = "COMx:";
            // 
            // toolStripStatusLabelSmartHome
            // 
            this.toolStripStatusLabelSmartHome.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelSmartHome.Name = "toolStripStatusLabelSmartHome";
            this.toolStripStatusLabelSmartHome.Size = new System.Drawing.Size(52, 22);
            this.toolStripStatusLabelSmartHome.Text = "OFFLINE";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Navy;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripStatusLabel1.Text = "COMx:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabelRgbTape
            // 
            this.toolStripStatusLabelRgbTape.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelRgbTape.Name = "toolStripStatusLabelRgbTape";
            this.toolStripStatusLabelRgbTape.Size = new System.Drawing.Size(52, 22);
            this.toolStripStatusLabelRgbTape.Text = "OFFLINE";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.ForeColor = System.Drawing.Color.Navy;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(43, 22);
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
            this.добавитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.contextMenuStripPlaylist.Name = "contextMenuStripPlaylist";
            this.contextMenuStripPlaylist.Size = new System.Drawing.Size(200, 70);
            this.contextMenuStripPlaylist.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripPlaylist_ItemClicked);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Enabled = false;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить в избранные";
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
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageSmartHome
            // 
            this.tabPageSmartHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageSmartHome.Controls.Add(this.groupBox7);
            this.tabPageSmartHome.Controls.Add(this.groupBox6);
            this.tabPageSmartHome.Controls.Add(this.groupBox5);
            this.tabPageSmartHome.Controls.Add(this.buttonSaveSmartHomeCfg);
            this.tabPageSmartHome.Controls.Add(this.groupBox4);
            this.tabPageSmartHome.Controls.Add(this.buttonSendDataToDevice);
            this.tabPageSmartHome.Controls.Add(this.textBoxDataToSend);
            this.tabPageSmartHome.Controls.Add(this.panel3);
            this.tabPageSmartHome.Controls.Add(this.panel2);
            this.tabPageSmartHome.Controls.Add(this.panel1);
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.numericUpDownEncoder1);
            this.groupBox6.Controls.Add(this.numericUpDownEncoder0);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.numericUpDownSleepModeTimeout);
            this.groupBox6.Location = new System.Drawing.Point(344, 199);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(304, 59);
            this.groupBox6.TabIndex = 51;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Состояние регистров данных";
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
            // numericUpDownEncoder1
            // 
            this.numericUpDownEncoder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownEncoder1.Location = new System.Drawing.Point(145, 23);
            this.numericUpDownEncoder1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownEncoder1.Name = "numericUpDownEncoder1";
            this.numericUpDownEncoder1.Size = new System.Drawing.Size(36, 23);
            this.numericUpDownEncoder1.TabIndex = 42;
            this.numericUpDownEncoder1.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownEncoder1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numericUpDown_EncoderValue);
            this.numericUpDownEncoder1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDown_EncoderValue);
            // 
            // numericUpDownEncoder0
            // 
            this.numericUpDownEncoder0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownEncoder0.Location = new System.Drawing.Point(50, 23);
            this.numericUpDownEncoder0.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownEncoder0.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownEncoder0.Name = "numericUpDownEncoder0";
            this.numericUpDownEncoder0.Size = new System.Drawing.Size(36, 23);
            this.numericUpDownEncoder0.TabIndex = 41;
            this.numericUpDownEncoder0.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownEncoder0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numericUpDown_EncoderValue);
            this.numericUpDownEncoder0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDown_EncoderValue);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxBuzzerBit6);
            this.groupBox5.Controls.Add(this.checkBoxBuzzerBit4);
            this.groupBox5.Controls.Add(this.checkBoxBuzzerBit5);
            this.groupBox5.Controls.Add(this.checkBoxBuzzerBit3);
            this.groupBox5.Controls.Add(this.checkBoxBuzzerBit2);
            this.groupBox5.Controls.Add(this.checkBoxBuzzerBit1);
            this.groupBox5.Controls.Add(this.checkBoxBuzzerBit0);
            this.groupBox5.Location = new System.Drawing.Point(5, 258);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(333, 66);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Настройка буззера";
            // 
            // checkBoxBuzzerBit6
            // 
            this.checkBoxBuzzerBit6.AutoSize = true;
            this.checkBoxBuzzerBit6.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxBuzzerBit6.Location = new System.Drawing.Point(291, 21);
            this.checkBoxBuzzerBit6.Name = "checkBoxBuzzerBit6";
            this.checkBoxBuzzerBit6.Size = new System.Drawing.Size(51, 34);
            this.checkBoxBuzzerBit6.TabIndex = 6;
            this.checkBoxBuzzerBit6.Text = "дверь";
            this.checkBoxBuzzerBit6.UseVisualStyleBackColor = true;
            this.checkBoxBuzzerBit6.Click += new System.EventHandler(this.checkBoxBuzzerBits_Click);
            // 
            // checkBoxBuzzerBit4
            // 
            this.checkBoxBuzzerBit4.AutoSize = true;
            this.checkBoxBuzzerBit4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxBuzzerBit4.Location = new System.Drawing.Point(191, 21);
            this.checkBoxBuzzerBit4.Name = "checkBoxBuzzerBit4";
            this.checkBoxBuzzerBit4.Size = new System.Drawing.Size(34, 34);
            this.checkBoxBuzzerBit4.TabIndex = 5;
            this.checkBoxBuzzerBit4.Text = "uart";
            this.checkBoxBuzzerBit4.UseVisualStyleBackColor = true;
            this.checkBoxBuzzerBit4.Click += new System.EventHandler(this.checkBoxBuzzerBits_Click);
            // 
            // checkBoxBuzzerBit5
            // 
            this.checkBoxBuzzerBit5.AutoSize = true;
            this.checkBoxBuzzerBit5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxBuzzerBit5.Location = new System.Drawing.Point(243, 21);
            this.checkBoxBuzzerBit5.Name = "checkBoxBuzzerBit5";
            this.checkBoxBuzzerBit5.Size = new System.Drawing.Size(34, 34);
            this.checkBoxBuzzerBit5.TabIndex = 4;
            this.checkBoxBuzzerBit5.Text = "usb";
            this.checkBoxBuzzerBit5.UseVisualStyleBackColor = true;
            this.checkBoxBuzzerBit5.Click += new System.EventHandler(this.checkBoxBuzzerBits_Click);
            // 
            // checkBoxBuzzerBit3
            // 
            this.checkBoxBuzzerBit3.AutoSize = true;
            this.checkBoxBuzzerBit3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxBuzzerBit3.Location = new System.Drawing.Point(126, 21);
            this.checkBoxBuzzerBit3.Name = "checkBoxBuzzerBit3";
            this.checkBoxBuzzerBit3.Size = new System.Drawing.Size(71, 34);
            this.checkBoxBuzzerBit3.TabIndex = 3;
            this.checkBoxBuzzerBit3.Text = "пульт ДУ";
            this.checkBoxBuzzerBit3.UseVisualStyleBackColor = true;
            this.checkBoxBuzzerBit3.Click += new System.EventHandler(this.checkBoxBuzzerBits_Click);
            // 
            // checkBoxBuzzerBit2
            // 
            this.checkBoxBuzzerBit2.AutoSize = true;
            this.checkBoxBuzzerBit2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxBuzzerBit2.Location = new System.Drawing.Point(86, 21);
            this.checkBoxBuzzerBit2.Name = "checkBoxBuzzerBit2";
            this.checkBoxBuzzerBit2.Size = new System.Drawing.Size(58, 34);
            this.checkBoxBuzzerBit2.TabIndex = 2;
            this.checkBoxBuzzerBit2.Text = "кнопки";
            this.checkBoxBuzzerBit2.UseVisualStyleBackColor = true;
            this.checkBoxBuzzerBit2.Click += new System.EventHandler(this.checkBoxBuzzerBits_Click);
            // 
            // checkBoxBuzzerBit1
            // 
            this.checkBoxBuzzerBit1.AutoSize = true;
            this.checkBoxBuzzerBit1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxBuzzerBit1.Location = new System.Drawing.Point(49, 21);
            this.checkBoxBuzzerBit1.Name = "checkBoxBuzzerBit1";
            this.checkBoxBuzzerBit1.Size = new System.Drawing.Size(45, 34);
            this.checkBoxBuzzerBit1.TabIndex = 1;
            this.checkBoxBuzzerBit1.Text = "энк.1";
            this.checkBoxBuzzerBit1.UseVisualStyleBackColor = true;
            this.checkBoxBuzzerBit1.Click += new System.EventHandler(this.checkBoxBuzzerBits_Click);
            // 
            // checkBoxBuzzerBit0
            // 
            this.checkBoxBuzzerBit0.AutoSize = true;
            this.checkBoxBuzzerBit0.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxBuzzerBit0.Location = new System.Drawing.Point(6, 21);
            this.checkBoxBuzzerBit0.Name = "checkBoxBuzzerBit0";
            this.checkBoxBuzzerBit0.Size = new System.Drawing.Size(45, 34);
            this.checkBoxBuzzerBit0.TabIndex = 0;
            this.checkBoxBuzzerBit0.Text = "энк.0";
            this.checkBoxBuzzerBit0.UseVisualStyleBackColor = true;
            this.checkBoxBuzzerBit0.Click += new System.EventHandler(this.checkBoxBuzzerBits_Click);
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
            this.buttonSaveSmartHomeCfg.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.buttonSensor7);
            this.groupBox4.Controls.Add(this.buttonSensor6);
            this.groupBox4.Controls.Add(this.buttonSensor5);
            this.groupBox4.Controls.Add(this.buttonSensor4);
            this.groupBox4.Controls.Add(this.buttonSensor3);
            this.groupBox4.Controls.Add(this.buttonSensor2);
            this.groupBox4.Controls.Add(this.buttonSensor1);
            this.groupBox4.Controls.Add(this.buttonSensor0);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(5, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 59);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Состояние датчиков";
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
            // buttonSensor7
            // 
            this.buttonSensor7.AutoSize = true;
            this.buttonSensor7.BackColor = System.Drawing.Color.Black;
            this.buttonSensor7.Location = new System.Drawing.Point(295, 33);
            this.buttonSensor7.Name = "buttonSensor7";
            this.buttonSensor7.Size = new System.Drawing.Size(20, 20);
            this.buttonSensor7.TabIndex = 7;
            this.buttonSensor7.UseVisualStyleBackColor = false;
            // 
            // buttonSensor6
            // 
            this.buttonSensor6.AutoSize = true;
            this.buttonSensor6.BackColor = System.Drawing.Color.Black;
            this.buttonSensor6.Location = new System.Drawing.Point(252, 33);
            this.buttonSensor6.Name = "buttonSensor6";
            this.buttonSensor6.Size = new System.Drawing.Size(20, 20);
            this.buttonSensor6.TabIndex = 6;
            this.buttonSensor6.UseVisualStyleBackColor = false;
            // 
            // buttonSensor5
            // 
            this.buttonSensor5.AutoSize = true;
            this.buttonSensor5.BackColor = System.Drawing.Color.Black;
            this.buttonSensor5.Location = new System.Drawing.Point(207, 33);
            this.buttonSensor5.Name = "buttonSensor5";
            this.buttonSensor5.Size = new System.Drawing.Size(20, 20);
            this.buttonSensor5.TabIndex = 5;
            this.buttonSensor5.UseVisualStyleBackColor = false;
            // 
            // buttonSensor4
            // 
            this.buttonSensor4.AutoSize = true;
            this.buttonSensor4.BackColor = System.Drawing.Color.Black;
            this.buttonSensor4.Location = new System.Drawing.Point(165, 33);
            this.buttonSensor4.Name = "buttonSensor4";
            this.buttonSensor4.Size = new System.Drawing.Size(20, 20);
            this.buttonSensor4.TabIndex = 4;
            this.buttonSensor4.UseVisualStyleBackColor = false;
            // 
            // buttonSensor3
            // 
            this.buttonSensor3.AutoSize = true;
            this.buttonSensor3.BackColor = System.Drawing.Color.Black;
            this.buttonSensor3.Location = new System.Drawing.Point(125, 33);
            this.buttonSensor3.Name = "buttonSensor3";
            this.buttonSensor3.Size = new System.Drawing.Size(20, 20);
            this.buttonSensor3.TabIndex = 3;
            this.buttonSensor3.UseVisualStyleBackColor = false;
            // 
            // buttonSensor2
            // 
            this.buttonSensor2.AutoSize = true;
            this.buttonSensor2.BackColor = System.Drawing.Color.Black;
            this.buttonSensor2.Location = new System.Drawing.Point(85, 33);
            this.buttonSensor2.Name = "buttonSensor2";
            this.buttonSensor2.Size = new System.Drawing.Size(20, 20);
            this.buttonSensor2.TabIndex = 2;
            this.buttonSensor2.UseVisualStyleBackColor = false;
            // 
            // buttonSensor1
            // 
            this.buttonSensor1.AutoSize = true;
            this.buttonSensor1.BackColor = System.Drawing.Color.Black;
            this.buttonSensor1.Location = new System.Drawing.Point(49, 33);
            this.buttonSensor1.Name = "buttonSensor1";
            this.buttonSensor1.Size = new System.Drawing.Size(20, 20);
            this.buttonSensor1.TabIndex = 1;
            this.buttonSensor1.UseVisualStyleBackColor = false;
            // 
            // buttonSensor0
            // 
            this.buttonSensor0.AutoSize = true;
            this.buttonSensor0.BackColor = System.Drawing.Color.Black;
            this.buttonSensor0.Location = new System.Drawing.Point(9, 33);
            this.buttonSensor0.Name = "buttonSensor0";
            this.buttonSensor0.Size = new System.Drawing.Size(20, 20);
            this.buttonSensor0.TabIndex = 0;
            this.buttonSensor0.UseVisualStyleBackColor = false;
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
            this.buttonSendDataToDevice.Click += new System.EventHandler(this.buttonSendDataToDevice_Click);
            // 
            // textBoxDataToSend
            // 
            this.textBoxDataToSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxDataToSend.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDataToSend.Location = new System.Drawing.Point(462, 294);
            this.textBoxDataToSend.Name = "textBoxDataToSend";
            this.textBoxDataToSend.Size = new System.Drawing.Size(155, 22);
            this.textBoxDataToSend.TabIndex = 45;
            this.textBoxDataToSend.Text = "REG:01";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.checkBoxStatusPin7);
            this.panel3.Controls.Add(this.checkBoxStatusPin0);
            this.panel3.Controls.Add(this.checkBoxStatusPin6);
            this.panel3.Controls.Add(this.checkBoxStatusPin1);
            this.panel3.Controls.Add(this.checkBoxStatusPin5);
            this.panel3.Controls.Add(this.checkBoxStatusPin2);
            this.panel3.Controls.Add(this.checkBoxStatusPin4);
            this.panel3.Controls.Add(this.checkBoxStatusPin3);
            this.panel3.Enabled = false;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 188);
            this.panel3.TabIndex = 37;
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
            // checkBoxStatusPin7
            // 
            this.checkBoxStatusPin7.AutoSize = true;
            this.checkBoxStatusPin7.Enabled = false;
            this.checkBoxStatusPin7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxStatusPin7.Location = new System.Drawing.Point(9, 165);
            this.checkBoxStatusPin7.Name = "checkBoxStatusPin7";
            this.checkBoxStatusPin7.Size = new System.Drawing.Size(75, 20);
            this.checkBoxStatusPin7.TabIndex = 35;
            this.checkBoxStatusPin7.Text = "резерв";
            this.checkBoxStatusPin7.UseVisualStyleBackColor = true;
            this.checkBoxStatusPin7.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // checkBoxStatusPin0
            // 
            this.checkBoxStatusPin0.AutoSize = true;
            this.checkBoxStatusPin0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxStatusPin0.Location = new System.Drawing.Point(9, 25);
            this.checkBoxStatusPin0.Name = "checkBoxStatusPin0";
            this.checkBoxStatusPin0.Size = new System.Drawing.Size(115, 20);
            this.checkBoxStatusPin0.TabIndex = 28;
            this.checkBoxStatusPin0.Text = "Верхний свет";
            this.checkBoxStatusPin0.UseVisualStyleBackColor = true;
            this.checkBoxStatusPin0.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // checkBoxStatusPin6
            // 
            this.checkBoxStatusPin6.AutoSize = true;
            this.checkBoxStatusPin6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxStatusPin6.Location = new System.Drawing.Point(9, 145);
            this.checkBoxStatusPin6.Name = "checkBoxStatusPin6";
            this.checkBoxStatusPin6.Size = new System.Drawing.Size(75, 20);
            this.checkBoxStatusPin6.TabIndex = 34;
            this.checkBoxStatusPin6.Text = "резерв";
            this.checkBoxStatusPin6.UseVisualStyleBackColor = true;
            this.checkBoxStatusPin6.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // checkBoxStatusPin1
            // 
            this.checkBoxStatusPin1.AutoSize = true;
            this.checkBoxStatusPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxStatusPin1.Location = new System.Drawing.Point(9, 45);
            this.checkBoxStatusPin1.Name = "checkBoxStatusPin1";
            this.checkBoxStatusPin1.Size = new System.Drawing.Size(149, 20);
            this.checkBoxStatusPin1.TabIndex = 29;
            this.checkBoxStatusPin1.Text = "Настольная лампа";
            this.checkBoxStatusPin1.UseVisualStyleBackColor = true;
            this.checkBoxStatusPin1.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // checkBoxStatusPin5
            // 
            this.checkBoxStatusPin5.AutoSize = true;
            this.checkBoxStatusPin5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxStatusPin5.Location = new System.Drawing.Point(9, 125);
            this.checkBoxStatusPin5.Name = "checkBoxStatusPin5";
            this.checkBoxStatusPin5.Size = new System.Drawing.Size(75, 20);
            this.checkBoxStatusPin5.TabIndex = 33;
            this.checkBoxStatusPin5.Text = "резерв";
            this.checkBoxStatusPin5.UseVisualStyleBackColor = true;
            this.checkBoxStatusPin5.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // checkBoxStatusPin2
            // 
            this.checkBoxStatusPin2.AutoSize = true;
            this.checkBoxStatusPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxStatusPin2.Location = new System.Drawing.Point(9, 65);
            this.checkBoxStatusPin2.Name = "checkBoxStatusPin2";
            this.checkBoxStatusPin2.Size = new System.Drawing.Size(83, 20);
            this.checkBoxStatusPin2.TabIndex = 30;
            this.checkBoxStatusPin2.Text = "Ресивер";
            this.checkBoxStatusPin2.UseVisualStyleBackColor = true;
            this.checkBoxStatusPin2.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // checkBoxStatusPin4
            // 
            this.checkBoxStatusPin4.AutoSize = true;
            this.checkBoxStatusPin4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxStatusPin4.Location = new System.Drawing.Point(9, 105);
            this.checkBoxStatusPin4.Name = "checkBoxStatusPin4";
            this.checkBoxStatusPin4.Size = new System.Drawing.Size(84, 20);
            this.checkBoxStatusPin4.TabIndex = 32;
            this.checkBoxStatusPin4.Text = "Принтер";
            this.checkBoxStatusPin4.UseVisualStyleBackColor = true;
            this.checkBoxStatusPin4.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // checkBoxStatusPin3
            // 
            this.checkBoxStatusPin3.AutoSize = true;
            this.checkBoxStatusPin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxStatusPin3.Location = new System.Drawing.Point(9, 85);
            this.checkBoxStatusPin3.Name = "checkBoxStatusPin3";
            this.checkBoxStatusPin3.Size = new System.Drawing.Size(139, 20);
            this.checkBoxStatusPin3.TabIndex = 31;
            this.checkBoxStatusPin3.Text = "Монитор для VLC";
            this.checkBoxStatusPin3.UseVisualStyleBackColor = true;
            this.checkBoxStatusPin3.Click += new System.EventHandler(this.ChangeCurrentDeviceStatus);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.checkBoxHotButtonMask8);
            this.panel2.Controls.Add(this.checkBoxHotButtonMask1);
            this.panel2.Controls.Add(this.checkBoxHotButtonMask7);
            this.panel2.Controls.Add(this.checkBoxHotButtonMask2);
            this.panel2.Controls.Add(this.checkBoxHotButtonMask6);
            this.panel2.Controls.Add(this.checkBoxHotButtonMask3);
            this.panel2.Controls.Add(this.checkBoxHotButtonMask5);
            this.panel2.Controls.Add(this.checkBoxHotButtonMask4);
            this.panel2.Enabled = false;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(357, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 188);
            this.panel2.TabIndex = 37;
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
            // checkBoxHotButtonMask8
            // 
            this.checkBoxHotButtonMask8.AutoSize = true;
            this.checkBoxHotButtonMask8.Enabled = false;
            this.checkBoxHotButtonMask8.Location = new System.Drawing.Point(9, 165);
            this.checkBoxHotButtonMask8.Name = "checkBoxHotButtonMask8";
            this.checkBoxHotButtonMask8.Size = new System.Drawing.Size(71, 20);
            this.checkBoxHotButtonMask8.TabIndex = 35;
            this.checkBoxHotButtonMask8.Text = "unused";
            this.checkBoxHotButtonMask8.UseVisualStyleBackColor = true;
            this.checkBoxHotButtonMask8.Click += new System.EventHandler(this.checkBoxHotButtonMask_Click);
            // 
            // checkBoxHotButtonMask1
            // 
            this.checkBoxHotButtonMask1.AutoSize = true;
            this.checkBoxHotButtonMask1.Location = new System.Drawing.Point(9, 25);
            this.checkBoxHotButtonMask1.Name = "checkBoxHotButtonMask1";
            this.checkBoxHotButtonMask1.Size = new System.Drawing.Size(83, 20);
            this.checkBoxHotButtonMask1.TabIndex = 28;
            this.checkBoxHotButtonMask1.Text = "Top Light";
            this.checkBoxHotButtonMask1.UseVisualStyleBackColor = true;
            this.checkBoxHotButtonMask1.Click += new System.EventHandler(this.checkBoxHotButtonMask_Click);
            // 
            // checkBoxHotButtonMask7
            // 
            this.checkBoxHotButtonMask7.AutoSize = true;
            this.checkBoxHotButtonMask7.Location = new System.Drawing.Point(9, 145);
            this.checkBoxHotButtonMask7.Name = "checkBoxHotButtonMask7";
            this.checkBoxHotButtonMask7.Size = new System.Drawing.Size(71, 20);
            this.checkBoxHotButtonMask7.TabIndex = 34;
            this.checkBoxHotButtonMask7.Text = "unused";
            this.checkBoxHotButtonMask7.UseVisualStyleBackColor = true;
            this.checkBoxHotButtonMask7.Click += new System.EventHandler(this.checkBoxHotButtonMask_Click);
            // 
            // checkBoxHotButtonMask2
            // 
            this.checkBoxHotButtonMask2.AutoSize = true;
            this.checkBoxHotButtonMask2.Location = new System.Drawing.Point(9, 45);
            this.checkBoxHotButtonMask2.Name = "checkBoxHotButtonMask2";
            this.checkBoxHotButtonMask2.Size = new System.Drawing.Size(100, 20);
            this.checkBoxHotButtonMask2.TabIndex = 29;
            this.checkBoxHotButtonMask2.Text = "Table Lamp";
            this.checkBoxHotButtonMask2.UseVisualStyleBackColor = true;
            this.checkBoxHotButtonMask2.Click += new System.EventHandler(this.checkBoxHotButtonMask_Click);
            // 
            // checkBoxHotButtonMask6
            // 
            this.checkBoxHotButtonMask6.AutoSize = true;
            this.checkBoxHotButtonMask6.Location = new System.Drawing.Point(9, 125);
            this.checkBoxHotButtonMask6.Name = "checkBoxHotButtonMask6";
            this.checkBoxHotButtonMask6.Size = new System.Drawing.Size(71, 20);
            this.checkBoxHotButtonMask6.TabIndex = 33;
            this.checkBoxHotButtonMask6.Text = "unused";
            this.checkBoxHotButtonMask6.UseVisualStyleBackColor = true;
            this.checkBoxHotButtonMask6.Click += new System.EventHandler(this.checkBoxHotButtonMask_Click);
            // 
            // checkBoxHotButtonMask3
            // 
            this.checkBoxHotButtonMask3.AutoSize = true;
            this.checkBoxHotButtonMask3.Location = new System.Drawing.Point(9, 65);
            this.checkBoxHotButtonMask3.Name = "checkBoxHotButtonMask3";
            this.checkBoxHotButtonMask3.Size = new System.Drawing.Size(79, 20);
            this.checkBoxHotButtonMask3.TabIndex = 30;
            this.checkBoxHotButtonMask3.Text = "Subwoof";
            this.checkBoxHotButtonMask3.UseVisualStyleBackColor = true;
            this.checkBoxHotButtonMask3.Click += new System.EventHandler(this.checkBoxHotButtonMask_Click);
            // 
            // checkBoxHotButtonMask5
            // 
            this.checkBoxHotButtonMask5.AutoSize = true;
            this.checkBoxHotButtonMask5.Location = new System.Drawing.Point(9, 105);
            this.checkBoxHotButtonMask5.Name = "checkBoxHotButtonMask5";
            this.checkBoxHotButtonMask5.Size = new System.Drawing.Size(92, 20);
            this.checkBoxHotButtonMask5.TabIndex = 32;
            this.checkBoxHotButtonMask5.Text = "TV monitor";
            this.checkBoxHotButtonMask5.UseVisualStyleBackColor = true;
            this.checkBoxHotButtonMask5.Click += new System.EventHandler(this.checkBoxHotButtonMask_Click);
            // 
            // checkBoxHotButtonMask4
            // 
            this.checkBoxHotButtonMask4.AutoSize = true;
            this.checkBoxHotButtonMask4.Location = new System.Drawing.Point(9, 85);
            this.checkBoxHotButtonMask4.Name = "checkBoxHotButtonMask4";
            this.checkBoxHotButtonMask4.Size = new System.Drawing.Size(65, 20);
            this.checkBoxHotButtonMask4.TabIndex = 31;
            this.checkBoxHotButtonMask4.Text = "Printer";
            this.checkBoxHotButtonMask4.UseVisualStyleBackColor = true;
            this.checkBoxHotButtonMask4.Click += new System.EventHandler(this.checkBoxHotButtonMask_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBoxSleepModeMaskPin8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkBoxSleepModeMaskPin1);
            this.panel1.Controls.Add(this.checkBoxSleepModeMaskPin7);
            this.panel1.Controls.Add(this.checkBoxSleepModeMaskPin2);
            this.panel1.Controls.Add(this.checkBoxSleepModeMaskPin6);
            this.panel1.Controls.Add(this.checkBoxSleepModeMaskPin3);
            this.panel1.Controls.Add(this.checkBoxSleepModeMaskPin5);
            this.panel1.Controls.Add(this.checkBoxSleepModeMaskPin4);
            this.panel1.Enabled = false;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(161, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 188);
            this.panel1.TabIndex = 36;
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
            // checkBoxSleepModeMaskPin8
            // 
            this.checkBoxSleepModeMaskPin8.Enabled = false;
            this.checkBoxSleepModeMaskPin8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSleepModeMaskPin8.Location = new System.Drawing.Point(9, 165);
            this.checkBoxSleepModeMaskPin8.Name = "checkBoxSleepModeMaskPin8";
            this.checkBoxSleepModeMaskPin8.Size = new System.Drawing.Size(146, 20);
            this.checkBoxSleepModeMaskPin8.TabIndex = 35;
            this.checkBoxSleepModeMaskPin8.Text = "резерв";
            this.checkBoxSleepModeMaskPin8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSleepModeMaskPin8.UseVisualStyleBackColor = true;
            this.checkBoxSleepModeMaskPin8.Click += new System.EventHandler(this.checkBoxSleepModeMask_Click);
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
            // checkBoxSleepModeMaskPin1
            // 
            this.checkBoxSleepModeMaskPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSleepModeMaskPin1.Location = new System.Drawing.Point(9, 25);
            this.checkBoxSleepModeMaskPin1.Name = "checkBoxSleepModeMaskPin1";
            this.checkBoxSleepModeMaskPin1.Size = new System.Drawing.Size(146, 20);
            this.checkBoxSleepModeMaskPin1.TabIndex = 28;
            this.checkBoxSleepModeMaskPin1.Text = "Верхний свет";
            this.checkBoxSleepModeMaskPin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSleepModeMaskPin1.UseVisualStyleBackColor = true;
            this.checkBoxSleepModeMaskPin1.Click += new System.EventHandler(this.checkBoxSleepModeMask_Click);
            // 
            // checkBoxSleepModeMaskPin7
            // 
            this.checkBoxSleepModeMaskPin7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSleepModeMaskPin7.Location = new System.Drawing.Point(9, 145);
            this.checkBoxSleepModeMaskPin7.Name = "checkBoxSleepModeMaskPin7";
            this.checkBoxSleepModeMaskPin7.Size = new System.Drawing.Size(146, 20);
            this.checkBoxSleepModeMaskPin7.TabIndex = 34;
            this.checkBoxSleepModeMaskPin7.Text = "резерв";
            this.checkBoxSleepModeMaskPin7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSleepModeMaskPin7.UseVisualStyleBackColor = true;
            this.checkBoxSleepModeMaskPin7.Click += new System.EventHandler(this.checkBoxSleepModeMask_Click);
            // 
            // checkBoxSleepModeMaskPin2
            // 
            this.checkBoxSleepModeMaskPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSleepModeMaskPin2.Location = new System.Drawing.Point(9, 45);
            this.checkBoxSleepModeMaskPin2.Name = "checkBoxSleepModeMaskPin2";
            this.checkBoxSleepModeMaskPin2.Size = new System.Drawing.Size(146, 20);
            this.checkBoxSleepModeMaskPin2.TabIndex = 29;
            this.checkBoxSleepModeMaskPin2.Text = "Настольная лампа";
            this.checkBoxSleepModeMaskPin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSleepModeMaskPin2.UseVisualStyleBackColor = true;
            this.checkBoxSleepModeMaskPin2.Click += new System.EventHandler(this.checkBoxSleepModeMask_Click);
            // 
            // checkBoxSleepModeMaskPin6
            // 
            this.checkBoxSleepModeMaskPin6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSleepModeMaskPin6.Location = new System.Drawing.Point(9, 125);
            this.checkBoxSleepModeMaskPin6.Name = "checkBoxSleepModeMaskPin6";
            this.checkBoxSleepModeMaskPin6.Size = new System.Drawing.Size(146, 20);
            this.checkBoxSleepModeMaskPin6.TabIndex = 33;
            this.checkBoxSleepModeMaskPin6.Text = "резерв";
            this.checkBoxSleepModeMaskPin6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSleepModeMaskPin6.UseVisualStyleBackColor = true;
            this.checkBoxSleepModeMaskPin6.Click += new System.EventHandler(this.checkBoxSleepModeMask_Click);
            // 
            // checkBoxSleepModeMaskPin3
            // 
            this.checkBoxSleepModeMaskPin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSleepModeMaskPin3.Location = new System.Drawing.Point(9, 65);
            this.checkBoxSleepModeMaskPin3.Name = "checkBoxSleepModeMaskPin3";
            this.checkBoxSleepModeMaskPin3.Size = new System.Drawing.Size(146, 20);
            this.checkBoxSleepModeMaskPin3.TabIndex = 30;
            this.checkBoxSleepModeMaskPin3.Text = "Ресивер";
            this.checkBoxSleepModeMaskPin3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSleepModeMaskPin3.UseVisualStyleBackColor = true;
            this.checkBoxSleepModeMaskPin3.Click += new System.EventHandler(this.checkBoxSleepModeMask_Click);
            // 
            // checkBoxSleepModeMaskPin5
            // 
            this.checkBoxSleepModeMaskPin5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSleepModeMaskPin5.Location = new System.Drawing.Point(9, 105);
            this.checkBoxSleepModeMaskPin5.Name = "checkBoxSleepModeMaskPin5";
            this.checkBoxSleepModeMaskPin5.Size = new System.Drawing.Size(146, 20);
            this.checkBoxSleepModeMaskPin5.TabIndex = 32;
            this.checkBoxSleepModeMaskPin5.Text = "Принтер";
            this.checkBoxSleepModeMaskPin5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSleepModeMaskPin5.UseVisualStyleBackColor = true;
            this.checkBoxSleepModeMaskPin5.Click += new System.EventHandler(this.checkBoxSleepModeMask_Click);
            // 
            // checkBoxSleepModeMaskPin4
            // 
            this.checkBoxSleepModeMaskPin4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSleepModeMaskPin4.Location = new System.Drawing.Point(9, 85);
            this.checkBoxSleepModeMaskPin4.Name = "checkBoxSleepModeMaskPin4";
            this.checkBoxSleepModeMaskPin4.Size = new System.Drawing.Size(146, 20);
            this.checkBoxSleepModeMaskPin4.TabIndex = 31;
            this.checkBoxSleepModeMaskPin4.Text = "Монитор для VLC";
            this.checkBoxSleepModeMaskPin4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSleepModeMaskPin4.UseVisualStyleBackColor = true;
            this.checkBoxSleepModeMaskPin4.Click += new System.EventHandler(this.checkBoxSleepModeMask_Click);
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
            this.panel5.Controls.Add(this.labelBLUE);
            this.panel5.Controls.Add(this.checkBoxAmbilight);
            this.panel5.Controls.Add(this.groupBoxSheduler);
            this.panel5.Controls.Add(this.button18);
            this.panel5.Controls.Add(this.labelGREEN);
            this.panel5.Controls.Add(this.comboBoxRgbSendString);
            this.panel5.Controls.Add(this.labelRED);
            this.panel5.Controls.Add(this.labelUseAmbilight);
            this.panel5.Controls.Add(this.labelPixel);
            this.panel5.Controls.Add(this.button19);
            this.panel5.Controls.Add(this.numericUpDownChannelNumber);
            this.panel5.Controls.Add(this.trackBar1);
            this.panel5.Controls.Add(this.button16);
            this.panel5.Controls.Add(this.trackBar2);
            this.panel5.Controls.Add(this.trackBar3);
            this.panel5.Controls.Add(this.numericUpDownRgbFreq);
            this.panel5.Controls.Add(this.button13);
            this.panel5.Controls.Add(this.button12);
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
            // labelBLUE
            // 
            this.labelBLUE.AutoSize = true;
            this.labelBLUE.Location = new System.Drawing.Point(374, 273);
            this.labelBLUE.Name = "labelBLUE";
            this.labelBLUE.Size = new System.Drawing.Size(15, 16);
            this.labelBLUE.TabIndex = 50;
            this.labelBLUE.Text = "0";
            // 
            // checkBoxAmbilight
            // 
            this.checkBoxAmbilight.AutoSize = true;
            this.checkBoxAmbilight.Enabled = false;
            this.checkBoxAmbilight.Location = new System.Drawing.Point(517, 10);
            this.checkBoxAmbilight.Name = "checkBoxAmbilight";
            this.checkBoxAmbilight.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAmbilight.TabIndex = 56;
            this.checkBoxAmbilight.UseVisualStyleBackColor = true;
            this.checkBoxAmbilight.Click += new System.EventHandler(this.checkBoxAmbilight_Click);
            // 
            // groupBoxSheduler
            // 
            this.groupBoxSheduler.Controls.Add(this.button4);
            this.groupBoxSheduler.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxSheduler.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxSheduler.Controls.Add(this.checkBoxSheduler);
            this.groupBoxSheduler.Enabled = false;
            this.groupBoxSheduler.Location = new System.Drawing.Point(278, 34);
            this.groupBoxSheduler.Name = "groupBoxSheduler";
            this.groupBoxSheduler.Size = new System.Drawing.Size(459, 181);
            this.groupBoxSheduler.TabIndex = 67;
            this.groupBoxSheduler.TabStop = false;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button4.Location = new System.Drawing.Point(388, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 24);
            this.button4.TabIndex = 49;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Controls.Add(this.buttonColor15, 4, 1);
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
            this.tableLayoutPanel2.Controls.Add(this.buttonColor12, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonColor13, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonColor14, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonColor16, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonColor17, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonColor18, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonColor19, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonColor20, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonColor21, 10, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonColor22, 11, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonColor23, 12, 1);
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
            // buttonColor15
            // 
            this.buttonColor15.AutoSize = true;
            this.buttonColor15.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonColor15.Location = new System.Drawing.Point(196, 29);
            this.buttonColor15.Name = "buttonColor15";
            this.buttonColor15.Size = new System.Drawing.Size(22, 20);
            this.buttonColor15.TabIndex = 48;
            this.buttonColor15.UseVisualStyleBackColor = false;
            this.buttonColor15.Click += new System.EventHandler(this.buttonColor_Click);
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
            // buttonColor12
            // 
            this.buttonColor12.AutoSize = true;
            this.buttonColor12.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor12.Location = new System.Drawing.Point(112, 29);
            this.buttonColor12.Name = "buttonColor12";
            this.buttonColor12.Size = new System.Drawing.Size(22, 20);
            this.buttonColor12.TabIndex = 2;
            this.buttonColor12.UseVisualStyleBackColor = false;
            this.buttonColor12.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor13
            // 
            this.buttonColor13.AutoSize = true;
            this.buttonColor13.BackColor = System.Drawing.Color.Sienna;
            this.buttonColor13.Location = new System.Drawing.Point(140, 29);
            this.buttonColor13.Name = "buttonColor13";
            this.buttonColor13.Size = new System.Drawing.Size(22, 20);
            this.buttonColor13.TabIndex = 14;
            this.buttonColor13.UseVisualStyleBackColor = false;
            this.buttonColor13.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor14
            // 
            this.buttonColor14.AutoSize = true;
            this.buttonColor14.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonColor14.Location = new System.Drawing.Point(168, 29);
            this.buttonColor14.Name = "buttonColor14";
            this.buttonColor14.Size = new System.Drawing.Size(22, 20);
            this.buttonColor14.TabIndex = 15;
            this.buttonColor14.UseVisualStyleBackColor = false;
            this.buttonColor14.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor16
            // 
            this.buttonColor16.AutoSize = true;
            this.buttonColor16.BackColor = System.Drawing.Color.Red;
            this.buttonColor16.Location = new System.Drawing.Point(224, 29);
            this.buttonColor16.Name = "buttonColor16";
            this.buttonColor16.Size = new System.Drawing.Size(22, 20);
            this.buttonColor16.TabIndex = 49;
            this.buttonColor16.UseVisualStyleBackColor = false;
            this.buttonColor16.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor17
            // 
            this.buttonColor17.AutoSize = true;
            this.buttonColor17.BackColor = System.Drawing.Color.Magenta;
            this.buttonColor17.Location = new System.Drawing.Point(252, 29);
            this.buttonColor17.Name = "buttonColor17";
            this.buttonColor17.Size = new System.Drawing.Size(22, 20);
            this.buttonColor17.TabIndex = 50;
            this.buttonColor17.UseVisualStyleBackColor = false;
            this.buttonColor17.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor18
            // 
            this.buttonColor18.AutoSize = true;
            this.buttonColor18.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonColor18.Location = new System.Drawing.Point(280, 29);
            this.buttonColor18.Name = "buttonColor18";
            this.buttonColor18.Size = new System.Drawing.Size(22, 20);
            this.buttonColor18.TabIndex = 51;
            this.buttonColor18.UseVisualStyleBackColor = false;
            this.buttonColor18.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor19
            // 
            this.buttonColor19.AutoSize = true;
            this.buttonColor19.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor19.Location = new System.Drawing.Point(308, 29);
            this.buttonColor19.Name = "buttonColor19";
            this.buttonColor19.Size = new System.Drawing.Size(22, 20);
            this.buttonColor19.TabIndex = 52;
            this.buttonColor19.UseVisualStyleBackColor = false;
            this.buttonColor19.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor20
            // 
            this.buttonColor20.AutoSize = true;
            this.buttonColor20.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor20.Location = new System.Drawing.Point(336, 29);
            this.buttonColor20.Name = "buttonColor20";
            this.buttonColor20.Size = new System.Drawing.Size(22, 20);
            this.buttonColor20.TabIndex = 53;
            this.buttonColor20.UseVisualStyleBackColor = false;
            this.buttonColor20.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor21
            // 
            this.buttonColor21.AutoSize = true;
            this.buttonColor21.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor21.Location = new System.Drawing.Point(364, 29);
            this.buttonColor21.Name = "buttonColor21";
            this.buttonColor21.Size = new System.Drawing.Size(22, 20);
            this.buttonColor21.TabIndex = 54;
            this.buttonColor21.UseVisualStyleBackColor = false;
            this.buttonColor21.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor22
            // 
            this.buttonColor22.AutoSize = true;
            this.buttonColor22.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor22.Location = new System.Drawing.Point(392, 29);
            this.buttonColor22.Name = "buttonColor22";
            this.buttonColor22.Size = new System.Drawing.Size(22, 20);
            this.buttonColor22.TabIndex = 55;
            this.buttonColor22.UseVisualStyleBackColor = false;
            this.buttonColor22.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor23
            // 
            this.buttonColor23.AutoSize = true;
            this.buttonColor23.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor23.Location = new System.Drawing.Point(420, 29);
            this.buttonColor23.Name = "buttonColor23";
            this.buttonColor23.Size = new System.Drawing.Size(22, 20);
            this.buttonColor23.TabIndex = 56;
            this.buttonColor23.UseVisualStyleBackColor = false;
            this.buttonColor23.Click += new System.EventHandler(this.buttonColor_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.buttonColor03, 4, 1);
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
            this.tableLayoutPanel1.Controls.Add(this.buttonColor00, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor01, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor02, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor04, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor05, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor06, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor07, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor08, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor09, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor10, 11, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor11, 12, 1);
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
            // buttonColor03
            // 
            this.buttonColor03.AutoSize = true;
            this.buttonColor03.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonColor03.Location = new System.Drawing.Point(196, 29);
            this.buttonColor03.Name = "buttonColor03";
            this.buttonColor03.Size = new System.Drawing.Size(22, 20);
            this.buttonColor03.TabIndex = 48;
            this.buttonColor03.UseVisualStyleBackColor = false;
            this.buttonColor03.Click += new System.EventHandler(this.buttonColor_Click);
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
            // buttonColor00
            // 
            this.buttonColor00.AutoSize = true;
            this.buttonColor00.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor00.Location = new System.Drawing.Point(112, 29);
            this.buttonColor00.Name = "buttonColor00";
            this.buttonColor00.Size = new System.Drawing.Size(22, 20);
            this.buttonColor00.TabIndex = 2;
            this.buttonColor00.UseVisualStyleBackColor = false;
            this.buttonColor00.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor01
            // 
            this.buttonColor01.AutoSize = true;
            this.buttonColor01.BackColor = System.Drawing.Color.Sienna;
            this.buttonColor01.Location = new System.Drawing.Point(140, 29);
            this.buttonColor01.Name = "buttonColor01";
            this.buttonColor01.Size = new System.Drawing.Size(22, 20);
            this.buttonColor01.TabIndex = 14;
            this.buttonColor01.UseVisualStyleBackColor = false;
            this.buttonColor01.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor02
            // 
            this.buttonColor02.AutoSize = true;
            this.buttonColor02.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonColor02.Location = new System.Drawing.Point(168, 29);
            this.buttonColor02.Name = "buttonColor02";
            this.buttonColor02.Size = new System.Drawing.Size(22, 20);
            this.buttonColor02.TabIndex = 15;
            this.buttonColor02.UseVisualStyleBackColor = false;
            this.buttonColor02.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor04
            // 
            this.buttonColor04.AutoSize = true;
            this.buttonColor04.BackColor = System.Drawing.Color.Red;
            this.buttonColor04.Location = new System.Drawing.Point(224, 29);
            this.buttonColor04.Name = "buttonColor04";
            this.buttonColor04.Size = new System.Drawing.Size(22, 20);
            this.buttonColor04.TabIndex = 49;
            this.buttonColor04.UseVisualStyleBackColor = false;
            this.buttonColor04.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor05
            // 
            this.buttonColor05.AutoSize = true;
            this.buttonColor05.BackColor = System.Drawing.Color.Magenta;
            this.buttonColor05.Location = new System.Drawing.Point(252, 29);
            this.buttonColor05.Name = "buttonColor05";
            this.buttonColor05.Size = new System.Drawing.Size(22, 20);
            this.buttonColor05.TabIndex = 50;
            this.buttonColor05.UseVisualStyleBackColor = false;
            this.buttonColor05.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor06
            // 
            this.buttonColor06.AutoSize = true;
            this.buttonColor06.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonColor06.Location = new System.Drawing.Point(280, 29);
            this.buttonColor06.Name = "buttonColor06";
            this.buttonColor06.Size = new System.Drawing.Size(22, 20);
            this.buttonColor06.TabIndex = 51;
            this.buttonColor06.UseVisualStyleBackColor = false;
            this.buttonColor06.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor07
            // 
            this.buttonColor07.AutoSize = true;
            this.buttonColor07.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor07.Location = new System.Drawing.Point(308, 29);
            this.buttonColor07.Name = "buttonColor07";
            this.buttonColor07.Size = new System.Drawing.Size(22, 20);
            this.buttonColor07.TabIndex = 52;
            this.buttonColor07.UseVisualStyleBackColor = false;
            this.buttonColor07.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor08
            // 
            this.buttonColor08.AutoSize = true;
            this.buttonColor08.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor08.Location = new System.Drawing.Point(336, 29);
            this.buttonColor08.Name = "buttonColor08";
            this.buttonColor08.Size = new System.Drawing.Size(22, 20);
            this.buttonColor08.TabIndex = 53;
            this.buttonColor08.UseVisualStyleBackColor = false;
            this.buttonColor08.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor09
            // 
            this.buttonColor09.AutoSize = true;
            this.buttonColor09.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor09.Location = new System.Drawing.Point(364, 29);
            this.buttonColor09.Name = "buttonColor09";
            this.buttonColor09.Size = new System.Drawing.Size(22, 20);
            this.buttonColor09.TabIndex = 54;
            this.buttonColor09.UseVisualStyleBackColor = false;
            this.buttonColor09.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor10
            // 
            this.buttonColor10.AutoSize = true;
            this.buttonColor10.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor10.Location = new System.Drawing.Point(392, 29);
            this.buttonColor10.Name = "buttonColor10";
            this.buttonColor10.Size = new System.Drawing.Size(22, 20);
            this.buttonColor10.TabIndex = 55;
            this.buttonColor10.UseVisualStyleBackColor = false;
            this.buttonColor10.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor11
            // 
            this.buttonColor11.AutoSize = true;
            this.buttonColor11.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonColor11.Location = new System.Drawing.Point(420, 29);
            this.buttonColor11.Name = "buttonColor11";
            this.buttonColor11.Size = new System.Drawing.Size(22, 20);
            this.buttonColor11.TabIndex = 56;
            this.buttonColor11.UseVisualStyleBackColor = false;
            this.buttonColor11.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // checkBoxSheduler
            // 
            this.checkBoxSheduler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSheduler.AutoSize = true;
            this.checkBoxSheduler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSheduler.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBoxSheduler.Location = new System.Drawing.Point(-2, 0);
            this.checkBoxSheduler.Name = "checkBoxSheduler";
            this.checkBoxSheduler.Size = new System.Drawing.Size(106, 20);
            this.checkBoxSheduler.TabIndex = 46;
            this.checkBoxSheduler.Text = "Расписание";
            this.checkBoxSheduler.UseVisualStyleBackColor = true;
            this.checkBoxSheduler.Click += new System.EventHandler(this.checkBoxSheduler_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(6, 156);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(241, 23);
            this.button18.TabIndex = 11;
            this.button18.Text = "Цвет с рабочего стола";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // labelGREEN
            // 
            this.labelGREEN.AutoSize = true;
            this.labelGREEN.Location = new System.Drawing.Point(345, 273);
            this.labelGREEN.Name = "labelGREEN";
            this.labelGREEN.Size = new System.Drawing.Size(15, 16);
            this.labelGREEN.TabIndex = 49;
            this.labelGREEN.Text = "0";
            // 
            // comboBoxRgbSendString
            // 
            this.comboBoxRgbSendString.FormattingEnabled = true;
            this.comboBoxRgbSendString.Items.AddRange(new object[] {
            "EFFECT_CONFIG:01.1.1.1.00.00.00.00.00",
            "EFFECT_CONFIG:02.1.1.1.FF.00.00.10.80",
            "0.1.111"});
            this.comboBoxRgbSendString.Location = new System.Drawing.Point(6, 235);
            this.comboBoxRgbSendString.Name = "comboBoxRgbSendString";
            this.comboBoxRgbSendString.Size = new System.Drawing.Size(209, 24);
            this.comboBoxRgbSendString.TabIndex = 51;
            // 
            // labelRED
            // 
            this.labelRED.AutoSize = true;
            this.labelRED.Location = new System.Drawing.Point(315, 273);
            this.labelRED.Name = "labelRED";
            this.labelRED.Size = new System.Drawing.Size(15, 16);
            this.labelRED.TabIndex = 48;
            this.labelRED.Text = "0";
            // 
            // labelUseAmbilight
            // 
            this.labelUseAmbilight.AutoSize = true;
            this.labelUseAmbilight.Enabled = false;
            this.labelUseAmbilight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUseAmbilight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelUseAmbilight.Location = new System.Drawing.Point(339, 8);
            this.labelUseAmbilight.Name = "labelUseAmbilight";
            this.labelUseAmbilight.Size = new System.Drawing.Size(214, 17);
            this.labelUseAmbilight.TabIndex = 55;
            this.labelUseAmbilight.Text = "Поддержка функции \"Ambilight\"";
            this.toolTip1.SetToolTip(this.labelUseAmbilight, "Необходим RGB контроллер");
            // 
            // labelPixel
            // 
            this.labelPixel.AutoSize = true;
            this.labelPixel.Location = new System.Drawing.Point(393, 273);
            this.labelPixel.Name = "labelPixel";
            this.labelPixel.Size = new System.Drawing.Size(28, 16);
            this.labelPixel.TabIndex = 47;
            this.labelPixel.Text = "text";
            // 
            // button19
            // 
            this.button19.ForeColor = System.Drawing.Color.Red;
            this.button19.Location = new System.Drawing.Point(3, 273);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(61, 23);
            this.button19.TabIndex = 12;
            this.button19.Text = "SaveCFG";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // numericUpDownChannelNumber
            // 
            this.numericUpDownChannelNumber.Location = new System.Drawing.Point(199, 181);
            this.numericUpDownChannelNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownChannelNumber.Name = "numericUpDownChannelNumber";
            this.numericUpDownChannelNumber.Size = new System.Drawing.Size(48, 22);
            this.numericUpDownChannelNumber.TabIndex = 5;
            this.numericUpDownChannelNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numericUpDownChannelNumber, "Номер цвета (0..2)");
            this.numericUpDownChannelNumber.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 3);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(272, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBarColor_Scroll);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(221, 235);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(48, 23);
            this.button16.TabIndex = 46;
            this.button16.Text = "Send";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnSendRgbCommand);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(0, 54);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(272, 45);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBarColor_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(3, 105);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(269, 45);
            this.trackBar3.TabIndex = 8;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBarColor_Scroll);
            // 
            // numericUpDownRgbFreq
            // 
            this.numericUpDownRgbFreq.Location = new System.Drawing.Point(145, 181);
            this.numericUpDownRgbFreq.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRgbFreq.Name = "numericUpDownRgbFreq";
            this.numericUpDownRgbFreq.Size = new System.Drawing.Size(48, 22);
            this.numericUpDownRgbFreq.TabIndex = 6;
            this.numericUpDownRgbFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownRgbFreq.Value = new decimal(new int[] {
            111,
            0,
            0,
            0});
            this.numericUpDownRgbFreq.ValueChanged += new System.EventHandler(this.numericUpDownRgbFreq_ValueChanged);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(76, 181);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(63, 23);
            this.button13.TabIndex = 2;
            this.button13.Text = "Blynk";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.SetRgbTapeBlynkMode);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 182);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "Normal";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // tabPageVLC
            // 
            this.tabPageVLC.Controls.Add(this.button1);
            this.tabPageVLC.Controls.Add(this.groupBox3);
            this.tabPageVLC.Controls.Add(this.radioButtonMainVlcPlayList);
            this.tabPageVLC.Controls.Add(this.buttonPlayPause);
            this.tabPageVLC.Controls.Add(this.buttonSaveCfg);
            this.tabPageVLC.Controls.Add(this.buttonMute);
            this.tabPageVLC.Controls.Add(this.trackBarVlcVolume);
            this.tabPageVLC.Controls.Add(this.buttonVlcStop);
            this.tabPageVLC.Controls.Add(this.richTextBoxVlcLog);
            this.tabPageVLC.Controls.Add(this.radioButtonFavoriteVlcPlayList);
            this.tabPageVLC.Controls.Add(this.label20);
            this.tabPageVLC.Controls.Add(this.listBoxVlcPlaylistURLs);
            this.tabPageVLC.Controls.Add(this.listBoxVlcFavoriteURLs);
            this.tabPageVLC.Controls.Add(this.listBoxVlcFavoriteTitles);
            this.tabPageVLC.Controls.Add(this.listBoxVlcPlaylistTitles);
            this.tabPageVLC.Location = new System.Drawing.Point(4, 25);
            this.tabPageVLC.Name = "tabPageVLC";
            this.tabPageVLC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVLC.Size = new System.Drawing.Size(777, 329);
            this.tabPageVLC.TabIndex = 2;
            this.tabPageVLC.Text = "VLC";
            this.tabPageVLC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(361, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 20);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxFullScreen);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.checkBoxRememberChVol);
            this.groupBox3.Controls.Add(this.maskedTextBoxPlayListPath);
            this.groupBox3.Controls.Add(this.grbHostSettings);
            this.groupBox3.Controls.Add(this.maskedTextBoxFavoriteListPath);
            this.groupBox3.Controls.Add(this.buttonVlcFavoriteListPath);
            this.groupBox3.Controls.Add(this.buttonVlcPlayListPath);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.checkBoxUseSlaveMonitor);
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
            this.checkBoxFullScreen.Click += new System.EventHandler(this.checkBoxFullScreen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(28, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "На весь экран";
            // 
            // checkBoxRememberChVol
            // 
            this.checkBoxRememberChVol.AutoSize = true;
            this.checkBoxRememberChVol.Location = new System.Drawing.Point(7, 92);
            this.checkBoxRememberChVol.Name = "checkBoxRememberChVol";
            this.checkBoxRememberChVol.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRememberChVol.TabIndex = 70;
            this.checkBoxRememberChVol.UseVisualStyleBackColor = true;
            this.checkBoxRememberChVol.Click += new System.EventHandler(this.checkBoxRememberChVol_Click);
            // 
            // maskedTextBoxPlayListPath
            // 
            this.maskedTextBoxPlayListPath.Location = new System.Drawing.Point(154, 21);
            this.maskedTextBoxPlayListPath.Name = "maskedTextBoxPlayListPath";
            this.maskedTextBoxPlayListPath.Size = new System.Drawing.Size(237, 22);
            this.maskedTextBoxPlayListPath.TabIndex = 32;
            // 
            // grbHostSettings
            // 
            this.grbHostSettings.Controls.Add(this.checkBoxVlcMaskPin1);
            this.grbHostSettings.Controls.Add(this.checkBoxVlcMaskPin7);
            this.grbHostSettings.Controls.Add(this.checkBoxVlcMaskPin0);
            this.grbHostSettings.Controls.Add(this.checkBoxVlcGpioMask);
            this.grbHostSettings.Controls.Add(this.checkBoxVlcMaskPin6);
            this.grbHostSettings.Controls.Add(this.checkBoxVlcMaskPin2);
            this.grbHostSettings.Controls.Add(this.checkBoxVlcMaskPin5);
            this.grbHostSettings.Controls.Add(this.checkBoxVlcMaskPin3);
            this.grbHostSettings.Controls.Add(this.checkBoxVlcMaskPin4);
            this.grbHostSettings.Enabled = false;
            this.grbHostSettings.Location = new System.Drawing.Point(11, 133);
            this.grbHostSettings.Name = "grbHostSettings";
            this.grbHostSettings.Size = new System.Drawing.Size(298, 57);
            this.grbHostSettings.TabIndex = 66;
            this.grbHostSettings.TabStop = false;
            // 
            // checkBoxVlcMaskPin1
            // 
            this.checkBoxVlcMaskPin1.AutoSize = true;
            this.checkBoxVlcMaskPin1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxVlcMaskPin1.FlatAppearance.BorderSize = 2;
            this.checkBoxVlcMaskPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVlcMaskPin1.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxVlcMaskPin1.Location = new System.Drawing.Point(227, 19);
            this.checkBoxVlcMaskPin1.Name = "checkBoxVlcMaskPin1";
            this.checkBoxVlcMaskPin1.Size = new System.Drawing.Size(39, 31);
            this.checkBoxVlcMaskPin1.TabIndex = 59;
            this.checkBoxVlcMaskPin1.Text = "PIN1";
            this.checkBoxVlcMaskPin1.UseVisualStyleBackColor = true;
            this.checkBoxVlcMaskPin1.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // checkBoxVlcMaskPin7
            // 
            this.checkBoxVlcMaskPin7.AutoSize = true;
            this.checkBoxVlcMaskPin7.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxVlcMaskPin7.FlatAppearance.BorderSize = 2;
            this.checkBoxVlcMaskPin7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVlcMaskPin7.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxVlcMaskPin7.Location = new System.Drawing.Point(2, 19);
            this.checkBoxVlcMaskPin7.Name = "checkBoxVlcMaskPin7";
            this.checkBoxVlcMaskPin7.Size = new System.Drawing.Size(39, 31);
            this.checkBoxVlcMaskPin7.TabIndex = 65;
            this.checkBoxVlcMaskPin7.Text = "PIN7";
            this.checkBoxVlcMaskPin7.UseVisualStyleBackColor = true;
            this.checkBoxVlcMaskPin7.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // checkBoxVlcMaskPin0
            // 
            this.checkBoxVlcMaskPin0.AutoSize = true;
            this.checkBoxVlcMaskPin0.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxVlcMaskPin0.FlatAppearance.BorderSize = 2;
            this.checkBoxVlcMaskPin0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVlcMaskPin0.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxVlcMaskPin0.Location = new System.Drawing.Point(264, 19);
            this.checkBoxVlcMaskPin0.Name = "checkBoxVlcMaskPin0";
            this.checkBoxVlcMaskPin0.Size = new System.Drawing.Size(39, 31);
            this.checkBoxVlcMaskPin0.TabIndex = 58;
            this.checkBoxVlcMaskPin0.Text = "PIN0";
            this.checkBoxVlcMaskPin0.UseVisualStyleBackColor = true;
            this.checkBoxVlcMaskPin0.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // checkBoxVlcGpioMask
            // 
            this.checkBoxVlcGpioMask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxVlcGpioMask.AutoSize = true;
            this.checkBoxVlcGpioMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVlcGpioMask.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBoxVlcGpioMask.Location = new System.Drawing.Point(-4, 0);
            this.checkBoxVlcGpioMask.Name = "checkBoxVlcGpioMask";
            this.checkBoxVlcGpioMask.Size = new System.Drawing.Size(296, 20);
            this.checkBoxVlcGpioMask.TabIndex = 46;
            this.checkBoxVlcGpioMask.Text = "Используемые порты платы \"SmartHome\"";
            this.checkBoxVlcGpioMask.UseVisualStyleBackColor = true;
            this.checkBoxVlcGpioMask.Click += new System.EventHandler(this.checkBoxVlcGpioMask_Click);
            // 
            // checkBoxVlcMaskPin6
            // 
            this.checkBoxVlcMaskPin6.AutoSize = true;
            this.checkBoxVlcMaskPin6.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxVlcMaskPin6.FlatAppearance.BorderSize = 2;
            this.checkBoxVlcMaskPin6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVlcMaskPin6.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxVlcMaskPin6.Location = new System.Drawing.Point(42, 19);
            this.checkBoxVlcMaskPin6.Name = "checkBoxVlcMaskPin6";
            this.checkBoxVlcMaskPin6.Size = new System.Drawing.Size(39, 31);
            this.checkBoxVlcMaskPin6.TabIndex = 64;
            this.checkBoxVlcMaskPin6.Text = "PIN6";
            this.checkBoxVlcMaskPin6.UseVisualStyleBackColor = true;
            this.checkBoxVlcMaskPin6.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // checkBoxVlcMaskPin2
            // 
            this.checkBoxVlcMaskPin2.AutoSize = true;
            this.checkBoxVlcMaskPin2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxVlcMaskPin2.FlatAppearance.BorderSize = 2;
            this.checkBoxVlcMaskPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVlcMaskPin2.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxVlcMaskPin2.Location = new System.Drawing.Point(190, 19);
            this.checkBoxVlcMaskPin2.Name = "checkBoxVlcMaskPin2";
            this.checkBoxVlcMaskPin2.Size = new System.Drawing.Size(39, 31);
            this.checkBoxVlcMaskPin2.TabIndex = 60;
            this.checkBoxVlcMaskPin2.Text = "PIN2";
            this.checkBoxVlcMaskPin2.UseVisualStyleBackColor = true;
            this.checkBoxVlcMaskPin2.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // checkBoxVlcMaskPin5
            // 
            this.checkBoxVlcMaskPin5.AutoSize = true;
            this.checkBoxVlcMaskPin5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxVlcMaskPin5.FlatAppearance.BorderSize = 2;
            this.checkBoxVlcMaskPin5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVlcMaskPin5.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxVlcMaskPin5.Location = new System.Drawing.Point(79, 19);
            this.checkBoxVlcMaskPin5.Name = "checkBoxVlcMaskPin5";
            this.checkBoxVlcMaskPin5.Size = new System.Drawing.Size(39, 31);
            this.checkBoxVlcMaskPin5.TabIndex = 63;
            this.checkBoxVlcMaskPin5.Text = "PIN5";
            this.checkBoxVlcMaskPin5.UseVisualStyleBackColor = true;
            this.checkBoxVlcMaskPin5.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // checkBoxVlcMaskPin3
            // 
            this.checkBoxVlcMaskPin3.AutoSize = true;
            this.checkBoxVlcMaskPin3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxVlcMaskPin3.FlatAppearance.BorderSize = 2;
            this.checkBoxVlcMaskPin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVlcMaskPin3.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxVlcMaskPin3.Location = new System.Drawing.Point(153, 19);
            this.checkBoxVlcMaskPin3.Name = "checkBoxVlcMaskPin3";
            this.checkBoxVlcMaskPin3.Size = new System.Drawing.Size(39, 31);
            this.checkBoxVlcMaskPin3.TabIndex = 61;
            this.checkBoxVlcMaskPin3.Text = "PIN3";
            this.checkBoxVlcMaskPin3.UseVisualStyleBackColor = true;
            this.checkBoxVlcMaskPin3.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // checkBoxVlcMaskPin4
            // 
            this.checkBoxVlcMaskPin4.AutoSize = true;
            this.checkBoxVlcMaskPin4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxVlcMaskPin4.FlatAppearance.BorderSize = 2;
            this.checkBoxVlcMaskPin4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVlcMaskPin4.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxVlcMaskPin4.Location = new System.Drawing.Point(116, 19);
            this.checkBoxVlcMaskPin4.Name = "checkBoxVlcMaskPin4";
            this.checkBoxVlcMaskPin4.Size = new System.Drawing.Size(39, 31);
            this.checkBoxVlcMaskPin4.TabIndex = 62;
            this.checkBoxVlcMaskPin4.Text = "PIN4";
            this.checkBoxVlcMaskPin4.UseVisualStyleBackColor = true;
            this.checkBoxVlcMaskPin4.Click += new System.EventHandler(this.VlcMaskPinsToInt);
            // 
            // maskedTextBoxFavoriteListPath
            // 
            this.maskedTextBoxFavoriteListPath.Location = new System.Drawing.Point(154, 45);
            this.maskedTextBoxFavoriteListPath.Name = "maskedTextBoxFavoriteListPath";
            this.maskedTextBoxFavoriteListPath.Size = new System.Drawing.Size(237, 22);
            this.maskedTextBoxFavoriteListPath.TabIndex = 36;
            // 
            // buttonVlcFavoriteListPath
            // 
            this.buttonVlcFavoriteListPath.Location = new System.Drawing.Point(397, 46);
            this.buttonVlcFavoriteListPath.Name = "buttonVlcFavoriteListPath";
            this.buttonVlcFavoriteListPath.Size = new System.Drawing.Size(23, 23);
            this.buttonVlcFavoriteListPath.TabIndex = 35;
            this.buttonVlcFavoriteListPath.Text = "...";
            this.buttonVlcFavoriteListPath.UseVisualStyleBackColor = true;
            this.buttonVlcFavoriteListPath.Click += new System.EventHandler(this.buttonVlcFavoriteListPath_Click);
            // 
            // buttonVlcPlayListPath
            // 
            this.buttonVlcPlayListPath.Location = new System.Drawing.Point(397, 20);
            this.buttonVlcPlayListPath.Name = "buttonVlcPlayListPath";
            this.buttonVlcPlayListPath.Size = new System.Drawing.Size(23, 23);
            this.buttonVlcPlayListPath.TabIndex = 38;
            this.buttonVlcPlayListPath.Text = "...";
            this.buttonVlcPlayListPath.UseVisualStyleBackColor = true;
            this.buttonVlcPlayListPath.Click += new System.EventHandler(this.buttonVlcPlayListPath_Click);
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
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(28, 89);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(266, 17);
            this.label25.TabIndex = 69;
            this.label25.Text = "Запоминать громкость каждого канала";
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
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(28, 70);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(210, 17);
            this.label24.TabIndex = 67;
            this.label24.Text = "Использовать второй монитор";
            // 
            // checkBoxUseSlaveMonitor
            // 
            this.checkBoxUseSlaveMonitor.AutoSize = true;
            this.checkBoxUseSlaveMonitor.Location = new System.Drawing.Point(7, 72);
            this.checkBoxUseSlaveMonitor.Name = "checkBoxUseSlaveMonitor";
            this.checkBoxUseSlaveMonitor.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUseSlaveMonitor.TabIndex = 68;
            this.checkBoxUseSlaveMonitor.UseVisualStyleBackColor = true;
            this.checkBoxUseSlaveMonitor.Click += new System.EventHandler(this.checkBoxUseSlaveMonitor_Click);
            // 
            // radioButtonMainVlcPlayList
            // 
            this.radioButtonMainVlcPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonMainVlcPlayList.Location = new System.Drawing.Point(6, 8);
            this.radioButtonMainVlcPlayList.Name = "radioButtonMainVlcPlayList";
            this.radioButtonMainVlcPlayList.Size = new System.Drawing.Size(148, 20);
            this.radioButtonMainVlcPlayList.TabIndex = 55;
            this.radioButtonMainVlcPlayList.Text = "Список всех каналов";
            this.radioButtonMainVlcPlayList.UseVisualStyleBackColor = true;
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
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
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
            // buttonSaveCfg
            // 
            this.buttonSaveCfg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSaveCfg.Enabled = false;
            this.buttonSaveCfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonSaveCfg.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveCfg.Image")));
            this.buttonSaveCfg.Location = new System.Drawing.Point(730, 301);
            this.buttonSaveCfg.Name = "buttonSaveCfg";
            this.buttonSaveCfg.Size = new System.Drawing.Size(35, 25);
            this.buttonSaveCfg.TabIndex = 30;
            this.buttonSaveCfg.UseVisualStyleBackColor = true;
            this.buttonSaveCfg.Click += new System.EventHandler(this.buttonSaveCfg_Click_1);
            // 
            // buttonMute
            // 
            this.buttonMute.ImageIndex = 1;
            this.buttonMute.ImageList = this.imageList1;
            this.buttonMute.Location = new System.Drawing.Point(701, 10);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(45, 20);
            this.buttonMute.TabIndex = 53;
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // trackBarVlcVolume
            // 
            this.trackBarVlcVolume.Location = new System.Drawing.Point(519, 8);
            this.trackBarVlcVolume.Maximum = 255;
            this.trackBarVlcVolume.Name = "trackBarVlcVolume";
            this.trackBarVlcVolume.Size = new System.Drawing.Size(176, 45);
            this.trackBarVlcVolume.TabIndex = 50;
            this.trackBarVlcVolume.ValueChanged += new System.EventHandler(this.trackBarVlcVolume_ValueChanged);
            // 
            // buttonVlcStop
            // 
            this.buttonVlcStop.Image = global::SmartHome_v1.Properties.Resources.baseline_stop_black_18dp;
            this.buttonVlcStop.Location = new System.Drawing.Point(467, 10);
            this.buttonVlcStop.Name = "buttonVlcStop";
            this.buttonVlcStop.Size = new System.Drawing.Size(46, 20);
            this.buttonVlcStop.TabIndex = 49;
            this.buttonVlcStop.UseVisualStyleBackColor = true;
            this.buttonVlcStop.Click += new System.EventHandler(this.buttonVlcStop_Click);
            // 
            // richTextBoxVlcLog
            // 
            this.richTextBoxVlcLog.Location = new System.Drawing.Point(339, 240);
            this.richTextBoxVlcLog.Name = "richTextBoxVlcLog";
            this.richTextBoxVlcLog.Size = new System.Drawing.Size(426, 58);
            this.richTextBoxVlcLog.TabIndex = 48;
            this.richTextBoxVlcLog.Text = "";
            // 
            // radioButtonFavoriteVlcPlayList
            // 
            this.radioButtonFavoriteVlcPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonFavoriteVlcPlayList.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonFavoriteVlcPlayList.Image")));
            this.radioButtonFavoriteVlcPlayList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonFavoriteVlcPlayList.Location = new System.Drawing.Point(164, 8);
            this.radioButtonFavoriteVlcPlayList.Name = "radioButtonFavoriteVlcPlayList";
            this.radioButtonFavoriteVlcPlayList.Size = new System.Drawing.Size(146, 24);
            this.radioButtonFavoriteVlcPlayList.TabIndex = 47;
            this.radioButtonFavoriteVlcPlayList.Text = "Избранные";
            this.radioButtonFavoriteVlcPlayList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButtonFavoriteVlcPlayList.UseVisualStyleBackColor = true;
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
            // listBoxVlcPlaylistURLs
            // 
            this.listBoxVlcPlaylistURLs.FormattingEnabled = true;
            this.listBoxVlcPlaylistURLs.ItemHeight = 16;
            this.listBoxVlcPlaylistURLs.Location = new System.Drawing.Point(13, 215);
            this.listBoxVlcPlaylistURLs.Name = "listBoxVlcPlaylistURLs";
            this.listBoxVlcPlaylistURLs.Size = new System.Drawing.Size(126, 52);
            this.listBoxVlcPlaylistURLs.TabIndex = 27;
            this.listBoxVlcPlaylistURLs.Visible = false;
            // 
            // listBoxVlcFavoriteURLs
            // 
            this.listBoxVlcFavoriteURLs.FormattingEnabled = true;
            this.listBoxVlcFavoriteURLs.ItemHeight = 16;
            this.listBoxVlcFavoriteURLs.Location = new System.Drawing.Point(172, 215);
            this.listBoxVlcFavoriteURLs.Name = "listBoxVlcFavoriteURLs";
            this.listBoxVlcFavoriteURLs.Size = new System.Drawing.Size(124, 52);
            this.listBoxVlcFavoriteURLs.TabIndex = 42;
            this.listBoxVlcFavoriteURLs.Visible = false;
            // 
            // listBoxVlcFavoriteTitles
            // 
            this.listBoxVlcFavoriteTitles.ContextMenuStrip = this.contextMenuStripPlaylist;
            this.listBoxVlcFavoriteTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxVlcFavoriteTitles.FormattingEnabled = true;
            this.listBoxVlcFavoriteTitles.ItemHeight = 20;
            this.listBoxVlcFavoriteTitles.Location = new System.Drawing.Point(160, 34);
            this.listBoxVlcFavoriteTitles.Name = "listBoxVlcFavoriteTitles";
            this.listBoxVlcFavoriteTitles.Size = new System.Drawing.Size(150, 284);
            this.listBoxVlcFavoriteTitles.TabIndex = 36;
            this.listBoxVlcFavoriteTitles.Click += new System.EventHandler(this.listBoxVlcFavoriteList_Click);
            this.listBoxVlcFavoriteTitles.DoubleClick += new System.EventHandler(this.listBoxVlcFavoriteTitles_DoubleClick);
            // 
            // listBoxVlcPlaylistTitles
            // 
            this.listBoxVlcPlaylistTitles.ContextMenuStrip = this.contextMenuStripPlaylist;
            this.listBoxVlcPlaylistTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxVlcPlaylistTitles.FormattingEnabled = true;
            this.listBoxVlcPlaylistTitles.ItemHeight = 20;
            this.listBoxVlcPlaylistTitles.Location = new System.Drawing.Point(4, 34);
            this.listBoxVlcPlaylistTitles.Name = "listBoxVlcPlaylistTitles";
            this.listBoxVlcPlaylistTitles.Size = new System.Drawing.Size(150, 284);
            this.listBoxVlcPlaylistTitles.TabIndex = 35;
            this.listBoxVlcPlaylistTitles.Click += new System.EventHandler(this.listBoxVlcPlayList_Click);
            this.listBoxVlcPlaylistTitles.DoubleClick += new System.EventHandler(this.listBoxVlcPlaylistTitles_DoubleClick);
            this.listBoxVlcPlaylistTitles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxVlcPlaylistTitles_MouseDown);
            // 
            // tabPageAudio
            // 
            this.tabPageAudio.Controls.Add(this.progressBarHighFreq);
            this.tabPageAudio.Controls.Add(this.progressBarMiddleFreq);
            this.tabPageAudio.Controls.Add(this.labelHighMax);
            this.tabPageAudio.Controls.Add(this.labelMiddleMax);
            this.tabPageAudio.Controls.Add(this.labelLowMax);
            this.tabPageAudio.Controls.Add(this.progressBarLowFreq);
            this.tabPageAudio.Controls.Add(this.label44);
            this.tabPageAudio.Controls.Add(this.label43);
            this.tabPageAudio.Controls.Add(this.label42);
            this.tabPageAudio.Controls.Add(this.label41);
            this.tabPageAudio.Controls.Add(this.label40);
            this.tabPageAudio.Controls.Add(this.numericUpDownHighFreq);
            this.tabPageAudio.Controls.Add(this.numericUpDownMiddleFreq);
            this.tabPageAudio.Controls.Add(this.numericUpDownLowFreq);
            this.tabPageAudio.Controls.Add(this.label39);
            this.tabPageAudio.Controls.Add(this.label31);
            this.tabPageAudio.Controls.Add(this.label30);
            this.tabPageAudio.Controls.Add(this.label23);
            this.tabPageAudio.Controls.Add(this.textBoxHighFreq);
            this.tabPageAudio.Controls.Add(this.textBoxMiddleFreq);
            this.tabPageAudio.Controls.Add(this.textBoxLowFreq);
            this.tabPageAudio.Controls.Add(this.buttonStopRecord);
            this.tabPageAudio.Controls.Add(this.buttonStartAudioStreamScan);
            this.tabPageAudio.Controls.Add(this.zedGraphControl1);
            this.tabPageAudio.Controls.Add(this.label22);
            this.tabPageAudio.Controls.Add(this.label13);
            this.tabPageAudio.Controls.Add(this.comboBoxRenderDevices);
            this.tabPageAudio.Controls.Add(this.comboBoxDevices);
            this.tabPageAudio.Location = new System.Drawing.Point(4, 25);
            this.tabPageAudio.Name = "tabPageAudio";
            this.tabPageAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAudio.Size = new System.Drawing.Size(777, 329);
            this.tabPageAudio.TabIndex = 8;
            this.tabPageAudio.Text = "Audio tools";
            this.tabPageAudio.UseVisualStyleBackColor = true;
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
            // numericUpDownHighFreq
            // 
            this.numericUpDownHighFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownHighFreq.Location = new System.Drawing.Point(82, 173);
            this.numericUpDownHighFreq.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownHighFreq.Maximum = new decimal(new int[] {
            22000,
            0,
            0,
            0});
            this.numericUpDownHighFreq.Name = "numericUpDownHighFreq";
            this.numericUpDownHighFreq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownHighFreq.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownHighFreq.TabIndex = 50;
            this.numericUpDownHighFreq.Value = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            // 
            // numericUpDownMiddleFreq
            // 
            this.numericUpDownMiddleFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownMiddleFreq.Location = new System.Drawing.Point(82, 147);
            this.numericUpDownMiddleFreq.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownMiddleFreq.Maximum = new decimal(new int[] {
            22000,
            0,
            0,
            0});
            this.numericUpDownMiddleFreq.Name = "numericUpDownMiddleFreq";
            this.numericUpDownMiddleFreq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownMiddleFreq.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownMiddleFreq.TabIndex = 49;
            this.numericUpDownMiddleFreq.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDownLowFreq
            // 
            this.numericUpDownLowFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownLowFreq.Location = new System.Drawing.Point(82, 123);
            this.numericUpDownLowFreq.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownLowFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownLowFreq.Name = "numericUpDownLowFreq";
            this.numericUpDownLowFreq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownLowFreq.Size = new System.Drawing.Size(63, 23);
            this.numericUpDownLowFreq.TabIndex = 48;
            this.numericUpDownLowFreq.Value = new decimal(new int[] {
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
            // textBoxMiddleFreq
            // 
            this.textBoxMiddleFreq.Location = new System.Drawing.Point(238, 147);
            this.textBoxMiddleFreq.Name = "textBoxMiddleFreq";
            this.textBoxMiddleFreq.Size = new System.Drawing.Size(69, 22);
            this.textBoxMiddleFreq.TabIndex = 41;
            // 
            // textBoxLowFreq
            // 
            this.textBoxLowFreq.Location = new System.Drawing.Point(238, 119);
            this.textBoxLowFreq.Name = "textBoxLowFreq";
            this.textBoxLowFreq.Size = new System.Drawing.Size(69, 22);
            this.textBoxLowFreq.TabIndex = 40;
            // 
            // buttonStopRecord
            // 
            this.buttonStopRecord.Enabled = false;
            this.buttonStopRecord.Location = new System.Drawing.Point(373, 282);
            this.buttonStopRecord.Name = "buttonStopRecord";
            this.buttonStopRecord.Size = new System.Drawing.Size(60, 23);
            this.buttonStopRecord.TabIndex = 37;
            this.buttonStopRecord.Text = "Стоп";
            this.buttonStopRecord.UseVisualStyleBackColor = true;
            this.buttonStopRecord.Click += new System.EventHandler(this.buttonStopRecord_Click);
            // 
            // buttonStartAudioStreamScan
            // 
            this.buttonStartAudioStreamScan.Location = new System.Drawing.Point(309, 282);
            this.buttonStartAudioStreamScan.Name = "buttonStartAudioStreamScan";
            this.buttonStartAudioStreamScan.Size = new System.Drawing.Size(58, 23);
            this.buttonStartAudioStreamScan.TabIndex = 36;
            this.buttonStartAudioStreamScan.Text = "Запись";
            this.buttonStartAudioStreamScan.UseVisualStyleBackColor = true;
            this.buttonStartAudioStreamScan.Click += new System.EventHandler(this.buttonStartAudioStreamScan_Click);
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
            // comboBoxRenderDevices
            // 
            this.comboBoxRenderDevices.FormattingEnabled = true;
            this.comboBoxRenderDevices.Location = new System.Drawing.Point(70, 37);
            this.comboBoxRenderDevices.Name = "comboBoxRenderDevices";
            this.comboBoxRenderDevices.Size = new System.Drawing.Size(237, 24);
            this.comboBoxRenderDevices.TabIndex = 31;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(70, 10);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(237, 24);
            this.comboBoxDevices.TabIndex = 30;
            // 
            // tabPageLogger
            // 
            this.tabPageLogger.Controls.Add(this.maskedTextBoxLogFilePath);
            this.tabPageLogger.Controls.Add(this.buttonLogFilePath);
            this.tabPageLogger.Controls.Add(this.checkBox25);
            this.tabPageLogger.Controls.Add(this.label11);
            this.tabPageLogger.Controls.Add(this.richTextBox1);
            this.tabPageLogger.Controls.Add(this.comboBoxUsbDevicesList);
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
            // maskedTextBoxLogFilePath
            // 
            this.maskedTextBoxLogFilePath.Location = new System.Drawing.Point(161, 268);
            this.maskedTextBoxLogFilePath.Name = "maskedTextBoxLogFilePath";
            this.maskedTextBoxLogFilePath.Size = new System.Drawing.Size(311, 22);
            this.maskedTextBoxLogFilePath.TabIndex = 29;
            // 
            // buttonLogFilePath
            // 
            this.buttonLogFilePath.Location = new System.Drawing.Point(478, 266);
            this.buttonLogFilePath.Name = "buttonLogFilePath";
            this.buttonLogFilePath.Size = new System.Drawing.Size(23, 23);
            this.buttonLogFilePath.TabIndex = 26;
            this.buttonLogFilePath.Text = "...";
            this.buttonLogFilePath.UseVisualStyleBackColor = true;
            this.buttonLogFilePath.Click += new System.EventHandler(this.buttonLogFilePath_Click);
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
            this.button21.Click += new System.EventHandler(this.button21_Click);
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
            chartArea2.AxisX.Title = "Time, H";
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.Title = "Weight";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(9, 55);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
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
            this.groupBox1.Controls.Add(this.comboBoxHttpMethod);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBoxHttpMethod);
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
            // comboBoxHttpMethod
            // 
            this.comboBoxHttpMethod.FormattingEnabled = true;
            this.comboBoxHttpMethod.Items.AddRange(new object[] {
            "GET /",
            "POST /"});
            this.comboBoxHttpMethod.Location = new System.Drawing.Point(12, 19);
            this.comboBoxHttpMethod.Name = "comboBoxHttpMethod";
            this.comboBoxHttpMethod.Size = new System.Drawing.Size(64, 24);
            this.comboBoxHttpMethod.TabIndex = 4;
            this.comboBoxHttpMethod.SelectedValueChanged += new System.EventHandler(this.comboBoxHttpMethod_SelectedValueChanged);
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
            // textBoxHttpMethod
            // 
            this.textBoxHttpMethod.Location = new System.Drawing.Point(82, 19);
            this.textBoxHttpMethod.MaxLength = 3;
            this.textBoxHttpMethod.Name = "textBoxHttpMethod";
            this.textBoxHttpMethod.Size = new System.Drawing.Size(43, 22);
            this.textBoxHttpMethod.TabIndex = 0;
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
            this.btnRescanDevices.Click += new System.EventHandler(this.btnRescanDevices_Click);
            // 
            // serialPortRgbTape
            // 
            this.serialPortRgbTape.BaudRate = 115200;
            this.serialPortRgbTape.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRgbTapeDevice_DataReceived);
            // 
            // serialPortScales
            // 
            this.serialPortScales.BaudRate = 115200;
            this.serialPortScales.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortScales_DataReceived);
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
            // timerAmbilight
            // 
            this.timerAmbilight.Interval = 1000;
            this.timerAmbilight.Tick += new System.EventHandler(this.timerAmbilight_Tick);
            // 
            // timerRgbSheduler
            // 
            this.timerRgbSheduler.Interval = 30000;
            this.timerRgbSheduler.Tick += new System.EventHandler(this.timerRgbSheduler_Tick);
            // 
            // progressBarLowFreq
            // 
            this.progressBarLowFreq.Location = new System.Drawing.Point(119, 240);
            this.progressBarLowFreq.Maximum = 255;
            this.progressBarLowFreq.Name = "progressBarLowFreq";
            this.progressBarLowFreq.Size = new System.Drawing.Size(100, 16);
            this.progressBarLowFreq.TabIndex = 56;
            this.progressBarLowFreq.Value = 255;
            // 
            // labelLowMax
            // 
            this.labelLowMax.AutoSize = true;
            this.labelLowMax.BackColor = System.Drawing.Color.Red;
            this.labelLowMax.Location = new System.Drawing.Point(225, 240);
            this.labelLowMax.Name = "labelLowMax";
            this.labelLowMax.Size = new System.Drawing.Size(36, 16);
            this.labelLowMax.TabIndex = 57;
            this.labelLowMax.Text = "MAX";
            this.labelLowMax.Visible = false;
            // 
            // labelMiddleMax
            // 
            this.labelMiddleMax.AutoSize = true;
            this.labelMiddleMax.BackColor = System.Drawing.Color.Red;
            this.labelMiddleMax.Location = new System.Drawing.Point(225, 260);
            this.labelMiddleMax.Name = "labelMiddleMax";
            this.labelMiddleMax.Size = new System.Drawing.Size(36, 16);
            this.labelMiddleMax.TabIndex = 58;
            this.labelMiddleMax.Text = "MAX";
            this.labelMiddleMax.Visible = false;
            // 
            // labelHighMax
            // 
            this.labelHighMax.AutoSize = true;
            this.labelHighMax.BackColor = System.Drawing.Color.Red;
            this.labelHighMax.Location = new System.Drawing.Point(225, 280);
            this.labelHighMax.Name = "labelHighMax";
            this.labelHighMax.Size = new System.Drawing.Size(36, 16);
            this.labelHighMax.TabIndex = 59;
            this.labelHighMax.Text = "MAX";
            this.labelHighMax.Visible = false;
            // 
            // progressBarMiddleFreq
            // 
            this.progressBarMiddleFreq.Location = new System.Drawing.Point(119, 260);
            this.progressBarMiddleFreq.Maximum = 255;
            this.progressBarMiddleFreq.Name = "progressBarMiddleFreq";
            this.progressBarMiddleFreq.Size = new System.Drawing.Size(100, 16);
            this.progressBarMiddleFreq.TabIndex = 60;
            this.progressBarMiddleFreq.Value = 128;
            // 
            // progressBarHighFreq
            // 
            this.progressBarHighFreq.Location = new System.Drawing.Point(119, 280);
            this.progressBarHighFreq.Maximum = 255;
            this.progressBarHighFreq.Name = "progressBarHighFreq";
            this.progressBarHighFreq.Size = new System.Drawing.Size(100, 16);
            this.progressBarHighFreq.TabIndex = 61;
            this.progressBarHighFreq.Value = 20;
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
            this.Text = "Smart Home v.1.0 (Build: 031119)";
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEncoder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEncoder0)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageRGB.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBoxSheduler.ResumeLayout(false);
            this.groupBoxSheduler.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChannelNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRgbFreq)).EndInit();
            this.tabPageVLC.ResumeLayout(false);
            this.tabPageVLC.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbHostSettings.ResumeLayout(false);
            this.grbHostSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVlcVolume)).EndInit();
            this.tabPageAudio.ResumeLayout(false);
            this.tabPageAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiddleFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowFreq)).EndInit();
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

        private System.IO.Ports.SerialPort serialPortSmartHome;
        private System.Windows.Forms.ComboBox comboBoxUsbDevicesList;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRgbTape;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSmartHome;
        private System.Windows.Forms.TabPage tabPageLogger;
        private System.Windows.Forms.TabPage tabPageVLC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxSleepModeMaskPin8;
        private System.Windows.Forms.CheckBox checkBoxSleepModeMaskPin7;
        private System.Windows.Forms.CheckBox checkBoxSleepModeMaskPin6;
        private System.Windows.Forms.CheckBox checkBoxSleepModeMaskPin5;
        private System.Windows.Forms.CheckBox checkBoxSleepModeMaskPin4;
        private System.Windows.Forms.CheckBox checkBoxSleepModeMaskPin3;
        private System.Windows.Forms.CheckBox checkBoxSleepModeMaskPin2;
        private System.Windows.Forms.CheckBox checkBoxSleepModeMaskPin1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxHotButtonMask8;
        private System.Windows.Forms.CheckBox checkBoxHotButtonMask1;
        private System.Windows.Forms.CheckBox checkBoxHotButtonMask7;
        private System.Windows.Forms.CheckBox checkBoxHotButtonMask2;
        private System.Windows.Forms.CheckBox checkBoxHotButtonMask6;
        private System.Windows.Forms.CheckBox checkBoxHotButtonMask3;
        private System.Windows.Forms.CheckBox checkBoxHotButtonMask5;
        private System.Windows.Forms.CheckBox checkBoxHotButtonMask4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxStatusPin7;
        private System.Windows.Forms.CheckBox checkBoxStatusPin0;
        private System.Windows.Forms.CheckBox checkBoxStatusPin6;
        private System.Windows.Forms.CheckBox checkBoxStatusPin1;
        private System.Windows.Forms.CheckBox checkBoxStatusPin5;
        private System.Windows.Forms.CheckBox checkBoxStatusPin2;
        private System.Windows.Forms.CheckBox checkBoxStatusPin4;
        private System.Windows.Forms.CheckBox checkBoxStatusPin3;
        private System.Windows.Forms.NumericUpDown numericUpDownSleepModeTimeout;
        private System.Windows.Forms.TabPage tabPageESP8266;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownEncoder0;
        private System.IO.Ports.SerialPort serialPortRgbTape;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSmartHome;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ListBox listBoxVlcPlaylistURLs;
        private System.Windows.Forms.TabPage tabPageRGB;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.NumericUpDown numericUpDownChannelNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownRgbFreq;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabPage tabPageScales;
        private System.IO.Ports.SerialPort serialPortScales;
        private System.Windows.Forms.Button buttonSendDataToDevice;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBoxDataToSend;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.NumericUpDown numericUpDownEncoder1;
        private System.Windows.Forms.Button buttonLogFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLogFilePath;
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
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.ListBox listBoxVlcPlaylistTitles;
        private System.Windows.Forms.Button btnRescanDevices;
        private System.Windows.Forms.ListBox listBoxVlcFavoriteTitles;
        private System.Windows.Forms.ListBox listBoxVlcFavoriteURLs;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonSaveCfg;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonVlcPlayListPath;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFavoriteListPath;
        private System.Windows.Forms.Button buttonVlcFavoriteListPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlayListPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPlaylist;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonFavoriteVlcPlayList;
        private System.Windows.Forms.RichTextBox richTextBoxVlcLog;
        private System.Windows.Forms.Button buttonVlcStop;
        private System.Windows.Forms.ComboBox comboBoxRenderDevices;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPixel;
        private System.Windows.Forms.Label labelBLUE;
        private System.Windows.Forms.Label labelGREEN;
        private System.Windows.Forms.Label labelRED;
        private System.Windows.Forms.ComboBox comboBoxRgbSendString;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxVlcGpioMask;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TrackBar trackBarVlcVolume;
        private System.Windows.Forms.CheckBox checkBoxAmbilight;
        private System.Windows.Forms.Label labelUseAmbilight;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerAmbilight;
        private System.Windows.Forms.CheckBox checkBoxVlcMaskPin1;
        private System.Windows.Forms.CheckBox checkBoxVlcMaskPin0;
        private System.Windows.Forms.CheckBox checkBoxVlcMaskPin2;
        private System.Windows.Forms.CheckBox checkBoxVlcMaskPin3;
        private System.Windows.Forms.CheckBox checkBoxVlcMaskPin4;
        private System.Windows.Forms.CheckBox checkBoxVlcMaskPin7;
        private System.Windows.Forms.CheckBox checkBoxVlcMaskPin6;
        private System.Windows.Forms.CheckBox checkBoxVlcMaskPin5;
        private System.Windows.Forms.GroupBox grbHostSettings;
        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.CheckBox checkBoxUseSlaveMonitor;
        private System.Windows.Forms.Label label24;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.RadioButton radioButtonMainVlcPlayList;
        private System.Windows.Forms.CheckBox checkBoxRememberChVol;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button buttonStartAudioStreamScan;
        private System.Windows.Forms.TabPage tabPagePostMan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxHttpMethod;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxHttpMethod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStopRecord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxFullScreen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxSheduler;
        private System.Windows.Forms.CheckBox checkBoxSheduler;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonColor00;
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
        private System.Windows.Forms.Button buttonColor03;
        private System.Windows.Forms.Button buttonColor01;
        private System.Windows.Forms.Button buttonColor02;
        private System.Windows.Forms.Button buttonColor04;
        private System.Windows.Forms.Button buttonColor05;
        private System.Windows.Forms.Button buttonColor06;
        private System.Windows.Forms.Button buttonColor07;
        private System.Windows.Forms.Button buttonColor08;
        private System.Windows.Forms.Button buttonColor09;
        private System.Windows.Forms.Button buttonColor10;
        private System.Windows.Forms.Button buttonColor11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonColor15;
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
        private System.Windows.Forms.Button buttonColor12;
        private System.Windows.Forms.Button buttonColor13;
        private System.Windows.Forms.Button buttonColor14;
        private System.Windows.Forms.Button buttonColor16;
        private System.Windows.Forms.Button buttonColor17;
        private System.Windows.Forms.Button buttonColor18;
        private System.Windows.Forms.Button buttonColor19;
        private System.Windows.Forms.Button buttonColor20;
        private System.Windows.Forms.Button buttonColor21;
        private System.Windows.Forms.Button buttonColor22;
        private System.Windows.Forms.Button buttonColor23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Timer timerRgbSheduler;
        private System.Windows.Forms.TabPage tabPageCAM;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSensor7;
        private System.Windows.Forms.Button buttonSensor6;
        private System.Windows.Forms.Button buttonSensor5;
        private System.Windows.Forms.Button buttonSensor4;
        private System.Windows.Forms.Button buttonSensor3;
        private System.Windows.Forms.Button buttonSensor2;
        private System.Windows.Forms.Button buttonSensor1;
        private System.Windows.Forms.Button buttonSensor0;
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxBuzzerBit6;
        private System.Windows.Forms.CheckBox checkBoxBuzzerBit4;
        private System.Windows.Forms.CheckBox checkBoxBuzzerBit5;
        private System.Windows.Forms.CheckBox checkBoxBuzzerBit3;
        private System.Windows.Forms.CheckBox checkBoxBuzzerBit2;
        private System.Windows.Forms.CheckBox checkBoxBuzzerBit1;
        private System.Windows.Forms.CheckBox checkBoxBuzzerBit0;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxLowFreq;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown numericUpDownHighFreq;
        private System.Windows.Forms.NumericUpDown numericUpDownMiddleFreq;
        private System.Windows.Forms.NumericUpDown numericUpDownLowFreq;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxHighFreq;
        private System.Windows.Forms.TextBox textBoxMiddleFreq;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ProgressBar progressBarLowFreq;
        private System.Windows.Forms.Label labelLowMax;
        private System.Windows.Forms.Label labelHighMax;
        private System.Windows.Forms.Label labelMiddleMax;
        private System.Windows.Forms.ProgressBar progressBarHighFreq;
        private System.Windows.Forms.ProgressBar progressBarMiddleFreq;
    }
}

