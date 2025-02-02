namespace UcV1Simulateur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialogSave = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelfilter = new System.Windows.Forms.Panel();
            this.checkedListBoxFilter = new System.Windows.Forms.CheckedListBox();
            this.panel_nbfile = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFrameRaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nbframe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFichier = new System.Windows.Forms.Panel();
            this.checkBoxValue = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.buttonSaveRTB = new System.Windows.Forms.Button();
            this.checkBox_Log_Scroll = new System.Windows.Forms.CheckBox();
            this.buttonFolderSave = new System.Windows.Forms.Button();
            this.buttonRazLog = new System.Windows.Forms.Button();
            this.checkBox_Save = new System.Windows.Forms.CheckBox();
            this.panel_serial = new System.Windows.Forms.Panel();
            this.buttonSerialConnect = new System.Windows.Forms.Button();
            this.labelParity = new System.Windows.Forms.Label();
            this.buttonPort = new System.Windows.Forms.Button();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.labelDatabits = new System.Windows.Forms.Label();
            this.comboBoxStop = new System.Windows.Forms.ComboBox();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.comboBoxDatabits = new System.Windows.Forms.ComboBox();
            this.labelStop = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.panelFrameView = new System.Windows.Forms.Panel();
            this.richTextBoxFrame = new System.Windows.Forms.RichTextBox();
            this.panelData = new System.Windows.Forms.Panel();
            this.groupBoxKeyboard = new System.Windows.Forms.GroupBox();
            this.numericUpDownTempOrder = new System.Windows.Forms.NumericUpDown();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonTempup = new System.Windows.Forms.Button();
            this.buttonCircpump = new System.Windows.Forms.Button();
            this.buttonCmdBlower = new System.Windows.Forms.Button();
            this.buttonCmdPump2 = new System.Windows.Forms.Button();
            this.buttonCmdPump1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOutTimer = new System.Windows.Forms.RadioButton();
            this.radioButtonOutLigthOn2 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButtonOutLigthOn1 = new System.Windows.Forms.RadioButton();
            this.radioButtonOutLigthOff = new System.Windows.Forms.RadioButton();
            this.buttonLightSpeed = new System.Windows.Forms.Button();
            this.trackBarLigthSpeed = new System.Windows.Forms.TrackBar();
            this.trackBarLigthPower = new System.Windows.Forms.TrackBar();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.numericUpDownColorB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColorG = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColorR = new System.Windows.Forms.NumericUpDown();
            this.buttonLighton = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxStatusCircMode = new System.Windows.Forms.TextBox();
            this.textBoxLightMode = new System.Windows.Forms.TextBox();
            this.textBoxStatusFilter2 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelOrderCrc = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelOrderLength = new System.Windows.Forms.Label();
            this.labelOrderType = new System.Windows.Forms.Label();
            this.textBoxOrderCommand = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.textBoxOrderData = new System.Windows.Forms.TextBox();
            this.textBoxorderChannel = new System.Windows.Forms.TextBox();
            this.textBoxLightCycle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxStatusYear = new System.Windows.Forms.TextBox();
            this.textBoxLightBrightnes = new System.Windows.Forms.TextBox();
            this.textBoxStatusClearray = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxStatusTemp = new System.Windows.Forms.TextBox();
            this.textBoxLightB = new System.Windows.Forms.TextBox();
            this.textBoxStatusSettemp = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxStatusHeat = new System.Windows.Forms.TextBox();
            this.textBoxLightG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLightR = new System.Windows.Forms.TextBox();
            this.textBoxStatusCircul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStatusBlower = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStatusPump2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStatusPump1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStatusMonth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStatusDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStatusMinut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStatusHour = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonOrderYear = new System.Windows.Forms.Button();
            this.textBoxOrderYear = new System.Windows.Forms.TextBox();
            this.buttonOrderUnitTemp = new System.Windows.Forms.Button();
            this.comboBoxOrderUnitTemp = new System.Windows.Forms.ComboBox();
            this.checkBoxAllFrame = new System.Windows.Forms.CheckBox();
            this.comboBoxOrderFilter2 = new System.Windows.Forms.ComboBox();
            this.buttonOrderFilter2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelfilter.SuspendLayout();
            this.panel_nbfile.SuspendLayout();
            this.panelFichier.SuspendLayout();
            this.panel_serial.SuspendLayout();
            this.panelFrameView.SuspendLayout();
            this.panelData.SuspendLayout();
            this.groupBoxKeyboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLigthSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLigthPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorR)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialogSave
            // 
            this.folderBrowserDialogSave.Description = "Choisir le dossier de stockage des fichiers";
            this.folderBrowserDialogSave.SelectedPath = "folderBrowserDialogSave.SelectedPath";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxAllFrame);
            this.splitContainer1.Panel1.Controls.Add(this.panelfilter);
            this.splitContainer1.Panel1.Controls.Add(this.panel_nbfile);
            this.splitContainer1.Panel1.Controls.Add(this.panelFichier);
            this.splitContainer1.Panel1.Controls.Add(this.panel_serial);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelFrameView);
            this.splitContainer1.Panel2.Controls.Add(this.panelData);
            this.splitContainer1.Size = new System.Drawing.Size(1171, 606);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 34;
            // 
            // panelfilter
            // 
            this.panelfilter.Controls.Add(this.checkedListBoxFilter);
            this.panelfilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelfilter.Location = new System.Drawing.Point(0, 294);
            this.panelfilter.Name = "panelfilter";
            this.panelfilter.Size = new System.Drawing.Size(246, 198);
            this.panelfilter.TabIndex = 34;
            // 
            // checkedListBoxFilter
            // 
            this.checkedListBoxFilter.CheckOnClick = true;
            this.checkedListBoxFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBoxFilter.FormattingEnabled = true;
            this.checkedListBoxFilter.Items.AddRange(new object[] {
            "0x00",
            "0x01",
            "0x02",
            "0x03",
            "0x04",
            "0x05",
            "0x06",
            "0x07",
            "0x08",
            "0x09",
            "0xC1",
            "0xC2",
            "0xC3",
            "0xC4",
            "0xC5",
            "0xC6",
            "0xC7",
            "0xC8",
            "0xC9",
            "0xCA",
            "0xCB",
            "0xCC",
            "0xCD",
            "0xCE",
            "0xCF"});
            this.checkedListBoxFilter.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxFilter.MultiColumn = true;
            this.checkedListBoxFilter.Name = "checkedListBoxFilter";
            this.checkedListBoxFilter.Size = new System.Drawing.Size(246, 199);
            this.checkedListBoxFilter.TabIndex = 0;
            this.checkedListBoxFilter.ThreeDCheckBoxes = true;
            this.checkedListBoxFilter.SelectedValueChanged += new System.EventHandler(this.checkedListBoxFilter_SelectedValueChanged);
            // 
            // panel_nbfile
            // 
            this.panel_nbfile.Controls.Add(this.panel2);
            this.panel_nbfile.Controls.Add(this.buttonFrameRaz);
            this.panel_nbfile.Controls.Add(this.label1);
            this.panel_nbfile.Controls.Add(this.label_nbframe);
            this.panel_nbfile.Controls.Add(this.panel1);
            this.panel_nbfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_nbfile.Location = new System.Drawing.Point(0, 269);
            this.panel_nbfile.Name = "panel_nbfile";
            this.panel_nbfile.Size = new System.Drawing.Size(246, 25);
            this.panel_nbfile.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 25);
            this.panel2.TabIndex = 16;
            // 
            // buttonFrameRaz
            // 
            this.buttonFrameRaz.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFrameRaz.Location = new System.Drawing.Point(168, 0);
            this.buttonFrameRaz.Name = "buttonFrameRaz";
            this.buttonFrameRaz.Size = new System.Drawing.Size(62, 25);
            this.buttonFrameRaz.TabIndex = 14;
            this.buttonFrameRaz.Text = "RAZ";
            this.buttonFrameRaz.UseVisualStyleBackColor = true;
            this.buttonFrameRaz.Click += new System.EventHandler(this.buttonFrameRaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nb frame";
            // 
            // label_nbframe
            // 
            this.label_nbframe.AutoSize = true;
            this.label_nbframe.Location = new System.Drawing.Point(54, 4);
            this.label_nbframe.Name = "label_nbframe";
            this.label_nbframe.Size = new System.Drawing.Size(13, 13);
            this.label_nbframe.TabIndex = 13;
            this.label_nbframe.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 25);
            this.panel1.TabIndex = 15;
            // 
            // panelFichier
            // 
            this.panelFichier.Controls.Add(this.checkBoxValue);
            this.panelFichier.Controls.Add(this.panel3);
            this.panelFichier.Controls.Add(this.textBoxFilename);
            this.panelFichier.Controls.Add(this.buttonSaveRTB);
            this.panelFichier.Controls.Add(this.checkBox_Log_Scroll);
            this.panelFichier.Controls.Add(this.buttonFolderSave);
            this.panelFichier.Controls.Add(this.buttonRazLog);
            this.panelFichier.Controls.Add(this.checkBox_Save);
            this.panelFichier.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFichier.Location = new System.Drawing.Point(0, 170);
            this.panelFichier.Name = "panelFichier";
            this.panelFichier.Size = new System.Drawing.Size(246, 99);
            this.panelFichier.TabIndex = 32;
            // 
            // checkBoxValue
            // 
            this.checkBoxValue.AutoSize = true;
            this.checkBoxValue.Checked = true;
            this.checkBoxValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxValue.Location = new System.Drawing.Point(10, 76);
            this.checkBoxValue.Name = "checkBoxValue";
            this.checkBoxValue.Size = new System.Drawing.Size(61, 17);
            this.checkBoxValue.TabIndex = 18;
            this.checkBoxValue.Text = "Valeurs";
            this.checkBoxValue.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(232, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 99);
            this.panel3.TabIndex = 17;
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(3, 50);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(207, 20);
            this.textBoxFilename.TabIndex = 3;
            // 
            // buttonSaveRTB
            // 
            this.buttonSaveRTB.Location = new System.Drawing.Point(114, 3);
            this.buttonSaveRTB.Name = "buttonSaveRTB";
            this.buttonSaveRTB.Size = new System.Drawing.Size(61, 20);
            this.buttonSaveRTB.TabIndex = 2;
            this.buttonSaveRTB.Text = "Sauver";
            this.buttonSaveRTB.UseVisualStyleBackColor = true;
            this.buttonSaveRTB.Click += new System.EventHandler(this.buttonSaveRTB_Click);
            // 
            // checkBox_Log_Scroll
            // 
            this.checkBox_Log_Scroll.AutoSize = true;
            this.checkBox_Log_Scroll.Checked = true;
            this.checkBox_Log_Scroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Log_Scroll.Location = new System.Drawing.Point(479, 9);
            this.checkBox_Log_Scroll.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Log_Scroll.Name = "checkBox_Log_Scroll";
            this.checkBox_Log_Scroll.Size = new System.Drawing.Size(52, 17);
            this.checkBox_Log_Scroll.TabIndex = 1;
            this.checkBox_Log_Scroll.Text = "Scroll";
            this.checkBox_Log_Scroll.UseVisualStyleBackColor = true;
            // 
            // buttonFolderSave
            // 
            this.buttonFolderSave.Location = new System.Drawing.Point(3, 25);
            this.buttonFolderSave.Name = "buttonFolderSave";
            this.buttonFolderSave.Size = new System.Drawing.Size(207, 22);
            this.buttonFolderSave.TabIndex = 1;
            this.buttonFolderSave.UseVisualStyleBackColor = true;
            this.buttonFolderSave.Click += new System.EventHandler(this.buttonFolderSave_Click);
            // 
            // buttonRazLog
            // 
            this.buttonRazLog.Location = new System.Drawing.Point(410, 6);
            this.buttonRazLog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRazLog.Name = "buttonRazLog";
            this.buttonRazLog.Size = new System.Drawing.Size(50, 20);
            this.buttonRazLog.TabIndex = 0;
            this.buttonRazLog.Text = "Raz";
            this.buttonRazLog.UseVisualStyleBackColor = true;
            // 
            // checkBox_Save
            // 
            this.checkBox_Save.AutoSize = true;
            this.checkBox_Save.Checked = true;
            this.checkBox_Save.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Save.Location = new System.Drawing.Point(4, 6);
            this.checkBox_Save.Name = "checkBox_Save";
            this.checkBox_Save.Size = new System.Drawing.Size(111, 17);
            this.checkBox_Save.TabIndex = 0;
            this.checkBox_Save.Text = "Sauvegarder auto";
            this.checkBox_Save.UseVisualStyleBackColor = true;
            this.checkBox_Save.CheckedChanged += new System.EventHandler(this.checkBox_Save_CheckedChanged);
            // 
            // panel_serial
            // 
            this.panel_serial.Controls.Add(this.buttonSerialConnect);
            this.panel_serial.Controls.Add(this.labelParity);
            this.panel_serial.Controls.Add(this.buttonPort);
            this.panel_serial.Controls.Add(this.comboBoxParity);
            this.panel_serial.Controls.Add(this.labelDatabits);
            this.panel_serial.Controls.Add(this.comboBoxStop);
            this.panel_serial.Controls.Add(this.labelBaudrate);
            this.panel_serial.Controls.Add(this.comboBoxDatabits);
            this.panel_serial.Controls.Add(this.labelStop);
            this.panel_serial.Controls.Add(this.comboBoxPort);
            this.panel_serial.Controls.Add(this.comboBoxBaudrate);
            this.panel_serial.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_serial.Location = new System.Drawing.Point(0, 0);
            this.panel_serial.Name = "panel_serial";
            this.panel_serial.Size = new System.Drawing.Size(246, 170);
            this.panel_serial.TabIndex = 0;
            // 
            // buttonSerialConnect
            // 
            this.buttonSerialConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerialConnect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonSerialConnect.Location = new System.Drawing.Point(21, 135);
            this.buttonSerialConnect.Name = "buttonSerialConnect";
            this.buttonSerialConnect.Size = new System.Drawing.Size(163, 28);
            this.buttonSerialConnect.TabIndex = 8;
            this.buttonSerialConnect.Text = "Connexion";
            this.buttonSerialConnect.UseVisualStyleBackColor = true;
            this.buttonSerialConnect.Click += new System.EventHandler(this.buttonSerialConnect_Click);
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(23, 87);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(34, 13);
            this.labelParity.TabIndex = 7;
            this.labelParity.Text = "Parité";
            // 
            // buttonPort
            // 
            this.buttonPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPort.ForeColor = System.Drawing.Color.Navy;
            this.buttonPort.Location = new System.Drawing.Point(9, 7);
            this.buttonPort.Name = "buttonPort";
            this.buttonPort.Size = new System.Drawing.Size(51, 24);
            this.buttonPort.TabIndex = 12;
            this.buttonPort.Text = "Port";
            this.buttonPort.UseVisualStyleBackColor = true;
            this.buttonPort.Click += new System.EventHandler(this.buttonPort_Click);
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(63, 83);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParity.TabIndex = 6;
            // 
            // labelDatabits
            // 
            this.labelDatabits.AutoSize = true;
            this.labelDatabits.Location = new System.Drawing.Point(11, 61);
            this.labelDatabits.Name = "labelDatabits";
            this.labelDatabits.Size = new System.Drawing.Size(46, 13);
            this.labelDatabits.TabIndex = 11;
            this.labelDatabits.Text = "Databits";
            // 
            // comboBoxStop
            // 
            this.comboBoxStop.FormattingEnabled = true;
            this.comboBoxStop.Location = new System.Drawing.Point(63, 108);
            this.comboBoxStop.Name = "comboBoxStop";
            this.comboBoxStop.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStop.TabIndex = 8;
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Location = new System.Drawing.Point(7, 36);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(50, 13);
            this.labelBaudrate.TabIndex = 5;
            this.labelBaudrate.Text = "Baudrate";
            // 
            // comboBoxDatabits
            // 
            this.comboBoxDatabits.FormattingEnabled = true;
            this.comboBoxDatabits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.comboBoxDatabits.Location = new System.Drawing.Point(63, 58);
            this.comboBoxDatabits.Name = "comboBoxDatabits";
            this.comboBoxDatabits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDatabits.TabIndex = 10;
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(27, 110);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(29, 13);
            this.labelStop.TabIndex = 9;
            this.labelStop.Text = "Stop";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(63, 9);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 2;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(63, 34);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudrate.TabIndex = 4;
            // 
            // panelFrameView
            // 
            this.panelFrameView.Controls.Add(this.richTextBoxFrame);
            this.panelFrameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrameView.Location = new System.Drawing.Point(0, 0);
            this.panelFrameView.Name = "panelFrameView";
            this.panelFrameView.Size = new System.Drawing.Size(921, 372);
            this.panelFrameView.TabIndex = 1;
            // 
            // richTextBoxFrame
            // 
            this.richTextBoxFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxFrame.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxFrame.Name = "richTextBoxFrame";
            this.richTextBoxFrame.Size = new System.Drawing.Size(921, 372);
            this.richTextBoxFrame.TabIndex = 0;
            this.richTextBoxFrame.Text = "";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.groupBox3);
            this.panelData.Controls.Add(this.groupBoxKeyboard);
            this.panelData.Controls.Add(this.groupBox1);
            this.panelData.Controls.Add(this.groupBoxStatus);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelData.Location = new System.Drawing.Point(0, 372);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(921, 234);
            this.panelData.TabIndex = 4;
            // 
            // groupBoxKeyboard
            // 
            this.groupBoxKeyboard.Controls.Add(this.numericUpDownTempOrder);
            this.groupBoxKeyboard.Controls.Add(this.buttonTempup);
            this.groupBoxKeyboard.Controls.Add(this.buttonCircpump);
            this.groupBoxKeyboard.Controls.Add(this.buttonCmdBlower);
            this.groupBoxKeyboard.Controls.Add(this.buttonCmdPump2);
            this.groupBoxKeyboard.Controls.Add(this.buttonCmdPump1);
            this.groupBoxKeyboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxKeyboard.Location = new System.Drawing.Point(629, 0);
            this.groupBoxKeyboard.Name = "groupBoxKeyboard";
            this.groupBoxKeyboard.Size = new System.Drawing.Size(106, 234);
            this.groupBoxKeyboard.TabIndex = 2;
            this.groupBoxKeyboard.TabStop = false;
            this.groupBoxKeyboard.Text = "Clavier";
            this.groupBoxKeyboard.Visible = false;
            // 
            // numericUpDownTempOrder
            // 
            this.numericUpDownTempOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTempOrder.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownTempOrder.Location = new System.Drawing.Point(15, 153);
            this.numericUpDownTempOrder.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownTempOrder.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numericUpDownTempOrder.Name = "numericUpDownTempOrder";
            this.numericUpDownTempOrder.Size = new System.Drawing.Size(72, 29);
            this.numericUpDownTempOrder.TabIndex = 9;
            this.numericUpDownTempOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTempOrder.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(6, 19);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(65, 24);
            this.buttonMenu.TabIndex = 6;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            // 
            // buttonTempup
            // 
            this.buttonTempup.Location = new System.Drawing.Point(15, 184);
            this.buttonTempup.Name = "buttonTempup";
            this.buttonTempup.Size = new System.Drawing.Size(65, 24);
            this.buttonTempup.TabIndex = 4;
            this.buttonTempup.Text = "Temp";
            this.buttonTempup.UseVisualStyleBackColor = true;
            this.buttonTempup.Click += new System.EventHandler(this.buttonTempup_Click);
            // 
            // buttonCircpump
            // 
            this.buttonCircpump.Location = new System.Drawing.Point(15, 117);
            this.buttonCircpump.Name = "buttonCircpump";
            this.buttonCircpump.Size = new System.Drawing.Size(65, 24);
            this.buttonCircpump.TabIndex = 3;
            this.buttonCircpump.Text = "Filtration";
            this.buttonCircpump.UseVisualStyleBackColor = true;
            this.buttonCircpump.Click += new System.EventHandler(this.buttonCircpump_Click);
            // 
            // buttonCmdBlower
            // 
            this.buttonCmdBlower.Location = new System.Drawing.Point(15, 87);
            this.buttonCmdBlower.Name = "buttonCmdBlower";
            this.buttonCmdBlower.Size = new System.Drawing.Size(65, 24);
            this.buttonCmdBlower.TabIndex = 2;
            this.buttonCmdBlower.Text = "Blower";
            this.buttonCmdBlower.UseVisualStyleBackColor = true;
            this.buttonCmdBlower.Click += new System.EventHandler(this.buttonCmdBlower_Click);
            // 
            // buttonCmdPump2
            // 
            this.buttonCmdPump2.Location = new System.Drawing.Point(15, 57);
            this.buttonCmdPump2.Name = "buttonCmdPump2";
            this.buttonCmdPump2.Size = new System.Drawing.Size(65, 24);
            this.buttonCmdPump2.TabIndex = 1;
            this.buttonCmdPump2.Text = "Pompe 2";
            this.buttonCmdPump2.UseVisualStyleBackColor = true;
            this.buttonCmdPump2.Click += new System.EventHandler(this.buttonCmdPump2_Click);
            // 
            // buttonCmdPump1
            // 
            this.buttonCmdPump1.Location = new System.Drawing.Point(15, 27);
            this.buttonCmdPump1.Name = "buttonCmdPump1";
            this.buttonCmdPump1.Size = new System.Drawing.Size(65, 24);
            this.buttonCmdPump1.TabIndex = 0;
            this.buttonCmdPump1.Text = "Pompe 1";
            this.buttonCmdPump1.UseVisualStyleBackColor = true;
            this.buttonCmdPump1.Click += new System.EventHandler(this.buttonCmdPump1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOutTimer);
            this.groupBox1.Controls.Add(this.radioButtonOutLigthOn2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButtonOutLigthOn1);
            this.groupBox1.Controls.Add(this.radioButtonOutLigthOff);
            this.groupBox1.Controls.Add(this.buttonLightSpeed);
            this.groupBox1.Controls.Add(this.trackBarLigthSpeed);
            this.groupBox1.Controls.Add(this.trackBarLigthPower);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.numericUpDownColorB);
            this.groupBox1.Controls.Add(this.numericUpDownColorG);
            this.groupBox1.Controls.Add(this.numericUpDownColorR);
            this.groupBox1.Controls.Add(this.buttonLighton);
            this.groupBox1.Controls.Add(this.buttonColor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(414, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 234);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eclairage";
            // 
            // radioButtonOutTimer
            // 
            this.radioButtonOutTimer.AutoSize = true;
            this.radioButtonOutTimer.Location = new System.Drawing.Point(144, 188);
            this.radioButtonOutTimer.Name = "radioButtonOutTimer";
            this.radioButtonOutTimer.Size = new System.Drawing.Size(62, 17);
            this.radioButtonOutTimer.TabIndex = 31;
            this.radioButtonOutTimer.Text = "Horloge";
            this.radioButtonOutTimer.UseVisualStyleBackColor = true;
            this.radioButtonOutTimer.CheckedChanged += new System.EventHandler(this.radioButtonOutTimer_CheckedChanged);
            // 
            // radioButtonOutLigthOn2
            // 
            this.radioButtonOutLigthOn2.AutoSize = true;
            this.radioButtonOutLigthOn2.Location = new System.Drawing.Point(99, 188);
            this.radioButtonOutLigthOn2.Name = "radioButtonOutLigthOn2";
            this.radioButtonOutLigthOn2.Size = new System.Drawing.Size(45, 17);
            this.radioButtonOutLigthOn2.TabIndex = 30;
            this.radioButtonOutLigthOn2.Text = "On2";
            this.radioButtonOutLigthOn2.UseVisualStyleBackColor = true;
            this.radioButtonOutLigthOn2.CheckedChanged += new System.EventHandler(this.radioButtonOutLigthOn2_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(88, 109);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Off";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButtonOutLigthOn1
            // 
            this.radioButtonOutLigthOn1.AutoSize = true;
            this.radioButtonOutLigthOn1.Location = new System.Drawing.Point(54, 188);
            this.radioButtonOutLigthOn1.Name = "radioButtonOutLigthOn1";
            this.radioButtonOutLigthOn1.Size = new System.Drawing.Size(45, 17);
            this.radioButtonOutLigthOn1.TabIndex = 29;
            this.radioButtonOutLigthOn1.Text = "On1";
            this.radioButtonOutLigthOn1.UseVisualStyleBackColor = true;
            this.radioButtonOutLigthOn1.CheckedChanged += new System.EventHandler(this.radioButtonOutLigthOn1_CheckedChanged);
            // 
            // radioButtonOutLigthOff
            // 
            this.radioButtonOutLigthOff.AutoSize = true;
            this.radioButtonOutLigthOff.Checked = true;
            this.radioButtonOutLigthOff.Location = new System.Drawing.Point(15, 188);
            this.radioButtonOutLigthOff.Name = "radioButtonOutLigthOff";
            this.radioButtonOutLigthOff.Size = new System.Drawing.Size(39, 17);
            this.radioButtonOutLigthOff.TabIndex = 28;
            this.radioButtonOutLigthOff.TabStop = true;
            this.radioButtonOutLigthOff.Text = "Off";
            this.radioButtonOutLigthOff.UseVisualStyleBackColor = true;
            this.radioButtonOutLigthOff.CheckedChanged += new System.EventHandler(this.radioButtonOutLigthOff_CheckedChanged);
            // 
            // buttonLightSpeed
            // 
            this.buttonLightSpeed.Location = new System.Drawing.Point(122, 144);
            this.buttonLightSpeed.Name = "buttonLightSpeed";
            this.buttonLightSpeed.Size = new System.Drawing.Size(65, 24);
            this.buttonLightSpeed.TabIndex = 27;
            this.buttonLightSpeed.Text = "Cycle";
            this.buttonLightSpeed.UseVisualStyleBackColor = true;
            this.buttonLightSpeed.Click += new System.EventHandler(this.buttonLightSpeed_Click);
            // 
            // trackBarLigthSpeed
            // 
            this.trackBarLigthSpeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarLigthSpeed.Location = new System.Drawing.Point(98, 101);
            this.trackBarLigthSpeed.Maximum = 5;
            this.trackBarLigthSpeed.Name = "trackBarLigthSpeed";
            this.trackBarLigthSpeed.Size = new System.Drawing.Size(109, 45);
            this.trackBarLigthSpeed.TabIndex = 26;
            this.trackBarLigthSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trackBarLigthPower
            // 
            this.trackBarLigthPower.Location = new System.Drawing.Point(99, 19);
            this.trackBarLigthPower.Maximum = 5;
            this.trackBarLigthPower.Name = "trackBarLigthPower";
            this.trackBarLigthPower.Size = new System.Drawing.Size(109, 45);
            this.trackBarLigthPower.TabIndex = 25;
            this.trackBarLigthPower.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(78, 101);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 24;
            this.label28.Text = "B";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(78, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "G";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(78, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "R";
            // 
            // numericUpDownColorB
            // 
            this.numericUpDownColorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownColorB.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownColorB.Location = new System.Drawing.Point(6, 93);
            this.numericUpDownColorB.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownColorB.Name = "numericUpDownColorB";
            this.numericUpDownColorB.Size = new System.Drawing.Size(65, 29);
            this.numericUpDownColorB.TabIndex = 12;
            this.numericUpDownColorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownColorG
            // 
            this.numericUpDownColorG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownColorG.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownColorG.Location = new System.Drawing.Point(6, 58);
            this.numericUpDownColorG.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownColorG.Name = "numericUpDownColorG";
            this.numericUpDownColorG.Size = new System.Drawing.Size(65, 29);
            this.numericUpDownColorG.TabIndex = 11;
            this.numericUpDownColorG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownColorR
            // 
            this.numericUpDownColorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownColorR.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownColorR.Location = new System.Drawing.Point(6, 23);
            this.numericUpDownColorR.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownColorR.Name = "numericUpDownColorR";
            this.numericUpDownColorR.Size = new System.Drawing.Size(65, 29);
            this.numericUpDownColorR.TabIndex = 10;
            this.numericUpDownColorR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLighton
            // 
            this.buttonLighton.Location = new System.Drawing.Point(122, 66);
            this.buttonLighton.Name = "buttonLighton";
            this.buttonLighton.Size = new System.Drawing.Size(65, 24);
            this.buttonLighton.TabIndex = 7;
            this.buttonLighton.Text = "Niveau";
            this.buttonLighton.UseVisualStyleBackColor = true;
            this.buttonLighton.Click += new System.EventHandler(this.buttonLighton_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(6, 133);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(65, 24);
            this.buttonColor.TabIndex = 8;
            this.buttonColor.Text = "Couleur";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.label22);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusCircMode);
            this.groupBoxStatus.Controls.Add(this.textBoxLightMode);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusFilter2);
            this.groupBoxStatus.Controls.Add(this.label23);
            this.groupBoxStatus.Controls.Add(this.groupBox2);
            this.groupBoxStatus.Controls.Add(this.textBoxLightCycle);
            this.groupBoxStatus.Controls.Add(this.label15);
            this.groupBoxStatus.Controls.Add(this.label24);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusYear);
            this.groupBoxStatus.Controls.Add(this.textBoxLightBrightnes);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusClearray);
            this.groupBoxStatus.Controls.Add(this.label25);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusTemp);
            this.groupBoxStatus.Controls.Add(this.textBoxLightB);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusSettemp);
            this.groupBoxStatus.Controls.Add(this.label26);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusHeat);
            this.groupBoxStatus.Controls.Add(this.textBoxLightG);
            this.groupBoxStatus.Controls.Add(this.label10);
            this.groupBoxStatus.Controls.Add(this.label27);
            this.groupBoxStatus.Controls.Add(this.label6);
            this.groupBoxStatus.Controls.Add(this.textBoxLightR);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusCircul);
            this.groupBoxStatus.Controls.Add(this.label7);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusBlower);
            this.groupBoxStatus.Controls.Add(this.label8);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusPump2);
            this.groupBoxStatus.Controls.Add(this.label9);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusPump1);
            this.groupBoxStatus.Controls.Add(this.label5);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusMonth);
            this.groupBoxStatus.Controls.Add(this.label4);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusDay);
            this.groupBoxStatus.Controls.Add(this.label3);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusMinut);
            this.groupBoxStatus.Controls.Add(this.label2);
            this.groupBoxStatus.Controls.Add(this.textBoxStatusHour);
            this.groupBoxStatus.Controls.Add(this.label17);
            this.groupBoxStatus.Controls.Add(this.label11);
            this.groupBoxStatus.Controls.Add(this.label12);
            this.groupBoxStatus.Controls.Add(this.label13);
            this.groupBoxStatus.Controls.Add(this.label14);
            this.groupBoxStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(414, 234);
            this.groupBoxStatus.TabIndex = 3;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Statut";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(233, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "Mode";
            // 
            // textBoxStatusCircMode
            // 
            this.textBoxStatusCircMode.Location = new System.Drawing.Point(314, 71);
            this.textBoxStatusCircMode.Name = "textBoxStatusCircMode";
            this.textBoxStatusCircMode.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusCircMode.TabIndex = 16;
            this.textBoxStatusCircMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLightMode
            // 
            this.textBoxLightMode.Location = new System.Drawing.Point(231, 144);
            this.textBoxLightMode.Name = "textBoxLightMode";
            this.textBoxLightMode.Size = new System.Drawing.Size(39, 20);
            this.textBoxLightMode.TabIndex = 10;
            this.textBoxLightMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStatusFilter2
            // 
            this.textBoxStatusFilter2.Location = new System.Drawing.Point(318, 110);
            this.textBoxStatusFilter2.Name = "textBoxStatusFilter2";
            this.textBoxStatusFilter2.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusFilter2.TabIndex = 31;
            this.textBoxStatusFilter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(189, 133);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Cycle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelOrderCrc);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.labelOrderLength);
            this.groupBox2.Controls.Add(this.labelOrderType);
            this.groupBox2.Controls.Add(this.textBoxOrderCommand);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.buttonOrder);
            this.groupBox2.Controls.Add(this.textBoxOrderData);
            this.groupBox2.Controls.Add(this.textBoxorderChannel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 66);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commandes";
            // 
            // labelOrderCrc
            // 
            this.labelOrderCrc.AutoSize = true;
            this.labelOrderCrc.Location = new System.Drawing.Point(254, 33);
            this.labelOrderCrc.Name = "labelOrderCrc";
            this.labelOrderCrc.Size = new System.Drawing.Size(35, 13);
            this.labelOrderCrc.TabIndex = 37;
            this.labelOrderCrc.Text = "00 7E";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(172, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Données";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(108, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Cmd";
            // 
            // labelOrderLength
            // 
            this.labelOrderLength.AutoSize = true;
            this.labelOrderLength.Location = new System.Drawing.Point(6, 33);
            this.labelOrderLength.Name = "labelOrderLength";
            this.labelOrderLength.Size = new System.Drawing.Size(35, 13);
            this.labelOrderLength.TabIndex = 34;
            this.labelOrderLength.Text = "7E 05";
            // 
            // labelOrderType
            // 
            this.labelOrderType.AutoSize = true;
            this.labelOrderType.Location = new System.Drawing.Point(79, 33);
            this.labelOrderType.Name = "labelOrderType";
            this.labelOrderType.Size = new System.Drawing.Size(20, 13);
            this.labelOrderType.TabIndex = 33;
            this.labelOrderType.Text = "BF";
            // 
            // textBoxOrderCommand
            // 
            this.textBoxOrderCommand.Location = new System.Drawing.Point(105, 29);
            this.textBoxOrderCommand.MaxLength = 2;
            this.textBoxOrderCommand.Name = "textBoxOrderCommand";
            this.textBoxOrderCommand.Size = new System.Drawing.Size(35, 20);
            this.textBoxOrderCommand.TabIndex = 32;
            this.textBoxOrderCommand.Text = "C9";
            this.textBoxOrderCommand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOrderCommand.TextChanged += new System.EventHandler(this.textBoxOrderCommand_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Canal";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(305, 27);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(76, 24);
            this.buttonOrder.TabIndex = 9;
            this.buttonOrder.Text = "ordre";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Visible = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // textBoxOrderData
            // 
            this.textBoxOrderData.Location = new System.Drawing.Point(146, 29);
            this.textBoxOrderData.Name = "textBoxOrderData";
            this.textBoxOrderData.Size = new System.Drawing.Size(102, 20);
            this.textBoxOrderData.TabIndex = 28;
            this.textBoxOrderData.Text = "A4";
            this.textBoxOrderData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOrderData.TextChanged += new System.EventHandler(this.textBoxOrderData_TextChanged);
            // 
            // textBoxorderChannel
            // 
            this.textBoxorderChannel.Location = new System.Drawing.Point(47, 29);
            this.textBoxorderChannel.MaxLength = 2;
            this.textBoxorderChannel.Name = "textBoxorderChannel";
            this.textBoxorderChannel.Size = new System.Drawing.Size(26, 20);
            this.textBoxorderChannel.TabIndex = 29;
            this.textBoxorderChannel.Text = "10";
            this.textBoxorderChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxorderChannel.TextChanged += new System.EventHandler(this.textBoxorderChannel_TextChanged);
            // 
            // textBoxLightCycle
            // 
            this.textBoxLightCycle.Location = new System.Drawing.Point(186, 144);
            this.textBoxLightCycle.Name = "textBoxLightCycle";
            this.textBoxLightCycle.Size = new System.Drawing.Size(39, 20);
            this.textBoxLightCycle.TabIndex = 8;
            this.textBoxLightCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(331, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "année";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(140, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Niveau";
            // 
            // textBoxStatusYear
            // 
            this.textBoxStatusYear.Location = new System.Drawing.Point(314, 30);
            this.textBoxStatusYear.Name = "textBoxStatusYear";
            this.textBoxStatusYear.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusYear.TabIndex = 26;
            this.textBoxStatusYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLightBrightnes
            // 
            this.textBoxLightBrightnes.Location = new System.Drawing.Point(141, 144);
            this.textBoxLightBrightnes.Name = "textBoxLightBrightnes";
            this.textBoxLightBrightnes.Size = new System.Drawing.Size(39, 20);
            this.textBoxLightBrightnes.TabIndex = 6;
            this.textBoxLightBrightnes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStatusClearray
            // 
            this.textBoxStatusClearray.Location = new System.Drawing.Point(79, 110);
            this.textBoxStatusClearray.Name = "textBoxStatusClearray";
            this.textBoxStatusClearray.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusClearray.TabIndex = 24;
            this.textBoxStatusClearray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(108, 133);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "B";
            // 
            // textBoxStatusTemp
            // 
            this.textBoxStatusTemp.Location = new System.Drawing.Point(242, 110);
            this.textBoxStatusTemp.Name = "textBoxStatusTemp";
            this.textBoxStatusTemp.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusTemp.TabIndex = 22;
            this.textBoxStatusTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLightB
            // 
            this.textBoxLightB.Location = new System.Drawing.Point(96, 144);
            this.textBoxLightB.Name = "textBoxLightB";
            this.textBoxLightB.Size = new System.Drawing.Size(39, 20);
            this.textBoxLightB.TabIndex = 4;
            this.textBoxLightB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStatusSettemp
            // 
            this.textBoxStatusSettemp.Location = new System.Drawing.Point(162, 110);
            this.textBoxStatusSettemp.Name = "textBoxStatusSettemp";
            this.textBoxStatusSettemp.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusSettemp.TabIndex = 20;
            this.textBoxStatusSettemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(63, 133);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(15, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "G";
            // 
            // textBoxStatusHeat
            // 
            this.textBoxStatusHeat.Location = new System.Drawing.Point(6, 110);
            this.textBoxStatusHeat.Name = "textBoxStatusHeat";
            this.textBoxStatusHeat.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusHeat.TabIndex = 18;
            this.textBoxStatusHeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLightG
            // 
            this.textBoxLightG.Location = new System.Drawing.Point(51, 144);
            this.textBoxLightG.Name = "textBoxLightG";
            this.textBoxLightG.Size = new System.Drawing.Size(39, 20);
            this.textBoxLightG.TabIndex = 2;
            this.textBoxLightG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Flowswitch";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 133);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(15, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Circul";
            // 
            // textBoxLightR
            // 
            this.textBoxLightR.Location = new System.Drawing.Point(6, 144);
            this.textBoxLightR.Name = "textBoxLightR";
            this.textBoxLightR.Size = new System.Drawing.Size(39, 20);
            this.textBoxLightR.TabIndex = 0;
            this.textBoxLightR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStatusCircul
            // 
            this.textBoxStatusCircul.Location = new System.Drawing.Point(238, 71);
            this.textBoxStatusCircul.Name = "textBoxStatusCircul";
            this.textBoxStatusCircul.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusCircul.TabIndex = 14;
            this.textBoxStatusCircul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Blower";
            // 
            // textBoxStatusBlower
            // 
            this.textBoxStatusBlower.Location = new System.Drawing.Point(162, 71);
            this.textBoxStatusBlower.Name = "textBoxStatusBlower";
            this.textBoxStatusBlower.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusBlower.TabIndex = 12;
            this.textBoxStatusBlower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pompe2";
            // 
            // textBoxStatusPump2
            // 
            this.textBoxStatusPump2.Location = new System.Drawing.Point(82, 71);
            this.textBoxStatusPump2.Name = "textBoxStatusPump2";
            this.textBoxStatusPump2.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusPump2.TabIndex = 10;
            this.textBoxStatusPump2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Pompe1";
            // 
            // textBoxStatusPump1
            // 
            this.textBoxStatusPump1.Location = new System.Drawing.Point(6, 71);
            this.textBoxStatusPump1.Name = "textBoxStatusPump1";
            this.textBoxStatusPump1.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusPump1.TabIndex = 8;
            this.textBoxStatusPump1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "mois";
            // 
            // textBoxStatusMonth
            // 
            this.textBoxStatusMonth.Location = new System.Drawing.Point(238, 30);
            this.textBoxStatusMonth.Name = "textBoxStatusMonth";
            this.textBoxStatusMonth.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusMonth.TabIndex = 6;
            this.textBoxStatusMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "jour";
            // 
            // textBoxStatusDay
            // 
            this.textBoxStatusDay.Location = new System.Drawing.Point(162, 30);
            this.textBoxStatusDay.Name = "textBoxStatusDay";
            this.textBoxStatusDay.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusDay.TabIndex = 4;
            this.textBoxStatusDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "minute";
            // 
            // textBoxStatusMinut
            // 
            this.textBoxStatusMinut.Location = new System.Drawing.Point(82, 30);
            this.textBoxStatusMinut.Name = "textBoxStatusMinut";
            this.textBoxStatusMinut.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusMinut.TabIndex = 2;
            this.textBoxStatusMinut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "heure";
            // 
            // textBoxStatusHour
            // 
            this.textBoxStatusHour.Location = new System.Drawing.Point(6, 30);
            this.textBoxStatusHour.Name = "textBoxStatusHour";
            this.textBoxStatusHour.Size = new System.Drawing.Size(70, 20);
            this.textBoxStatusHour.TabIndex = 0;
            this.textBoxStatusHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(336, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Filtre2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Clearray";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Temp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Consigne";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Chauffage";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxOrderFilter2);
            this.groupBox3.Controls.Add(this.buttonOrderFilter2);
            this.groupBox3.Controls.Add(this.comboBoxOrderUnitTemp);
            this.groupBox3.Controls.Add(this.buttonOrderUnitTemp);
            this.groupBox3.Controls.Add(this.textBoxOrderYear);
            this.groupBox3.Controls.Add(this.buttonMenu);
            this.groupBox3.Controls.Add(this.buttonOrderYear);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(735, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 234);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clavier";
            this.groupBox3.Visible = false;
            // 
            // buttonOrderYear
            // 
            this.buttonOrderYear.Location = new System.Drawing.Point(10, 184);
            this.buttonOrderYear.Name = "buttonOrderYear";
            this.buttonOrderYear.Size = new System.Drawing.Size(61, 24);
            this.buttonOrderYear.TabIndex = 4;
            this.buttonOrderYear.Text = "Année";
            this.buttonOrderYear.UseVisualStyleBackColor = true;
            this.buttonOrderYear.Click += new System.EventHandler(this.buttonOrderYear_Click);
            // 
            // textBoxOrderYear
            // 
            this.textBoxOrderYear.Location = new System.Drawing.Point(77, 187);
            this.textBoxOrderYear.Name = "textBoxOrderYear";
            this.textBoxOrderYear.Size = new System.Drawing.Size(61, 20);
            this.textBoxOrderYear.TabIndex = 33;
            this.textBoxOrderYear.Text = "2025";
            this.textBoxOrderYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOrderUnitTemp
            // 
            this.buttonOrderUnitTemp.Location = new System.Drawing.Point(10, 130);
            this.buttonOrderUnitTemp.Name = "buttonOrderUnitTemp";
            this.buttonOrderUnitTemp.Size = new System.Drawing.Size(61, 24);
            this.buttonOrderUnitTemp.TabIndex = 34;
            this.buttonOrderUnitTemp.Text = "Unité";
            this.buttonOrderUnitTemp.UseVisualStyleBackColor = true;
            this.buttonOrderUnitTemp.Click += new System.EventHandler(this.buttonOrderUnitTemp_Click);
            // 
            // comboBoxOrderUnitTemp
            // 
            this.comboBoxOrderUnitTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderUnitTemp.FormattingEnabled = true;
            this.comboBoxOrderUnitTemp.Items.AddRange(new object[] {
            "Celcius",
            "Farhenheit"});
            this.comboBoxOrderUnitTemp.Location = new System.Drawing.Point(79, 130);
            this.comboBoxOrderUnitTemp.Name = "comboBoxOrderUnitTemp";
            this.comboBoxOrderUnitTemp.Size = new System.Drawing.Size(59, 21);
            this.comboBoxOrderUnitTemp.TabIndex = 35;
            // 
            // checkBoxAllFrame
            // 
            this.checkBoxAllFrame.AutoSize = true;
            this.checkBoxAllFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxAllFrame.Location = new System.Drawing.Point(0, 492);
            this.checkBoxAllFrame.Name = "checkBoxAllFrame";
            this.checkBoxAllFrame.Size = new System.Drawing.Size(246, 17);
            this.checkBoxAllFrame.TabIndex = 35;
            this.checkBoxAllFrame.Text = "Toutes les trames";
            this.checkBoxAllFrame.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrderFilter2
            // 
            this.comboBoxOrderFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderFilter2.FormattingEnabled = true;
            this.comboBoxOrderFilter2.Items.AddRange(new object[] {
            "Fréquent",
            "Rare",
            "Eliminer"});
            this.comboBoxOrderFilter2.Location = new System.Drawing.Point(79, 100);
            this.comboBoxOrderFilter2.Name = "comboBoxOrderFilter2";
            this.comboBoxOrderFilter2.Size = new System.Drawing.Size(59, 21);
            this.comboBoxOrderFilter2.TabIndex = 37;
            // 
            // buttonOrderFilter2
            // 
            this.buttonOrderFilter2.Location = new System.Drawing.Point(10, 100);
            this.buttonOrderFilter2.Name = "buttonOrderFilter2";
            this.buttonOrderFilter2.Size = new System.Drawing.Size(61, 24);
            this.buttonOrderFilter2.TabIndex = 36;
            this.buttonOrderFilter2.Text = "Filtre 2";
            this.buttonOrderFilter2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1171, 606);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Emulateur Sundance";
            this.TopMost = true;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelfilter.ResumeLayout(false);
            this.panel_nbfile.ResumeLayout(false);
            this.panel_nbfile.PerformLayout();
            this.panelFichier.ResumeLayout(false);
            this.panelFichier.PerformLayout();
            this.panel_serial.ResumeLayout(false);
            this.panel_serial.PerformLayout();
            this.panelFrameView.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.groupBoxKeyboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLigthSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLigthPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorR)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_nbfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nbframe;
        private System.Windows.Forms.Panel panelFichier;
        private System.Windows.Forms.CheckBox checkBox_Log_Scroll;
        private System.Windows.Forms.Button buttonFolderSave;
        private System.Windows.Forms.Button buttonRazLog;
        private System.Windows.Forms.CheckBox checkBox_Save;
        private System.Windows.Forms.Panel panel_serial;
        private System.Windows.Forms.Button buttonSerialConnect;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Button buttonPort;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label labelDatabits;
        private System.Windows.Forms.ComboBox comboBoxStop;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.ComboBox comboBoxDatabits;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.Panel panelFrameView;
        private System.Windows.Forms.RichTextBox richTextBoxFrame;
        private System.Windows.Forms.Button buttonFrameRaz;
        private System.Windows.Forms.GroupBox groupBoxKeyboard;
        private System.Windows.Forms.Button buttonCmdBlower;
        private System.Windows.Forms.Button buttonCmdPump2;
        private System.Windows.Forms.Button buttonCmdPump1;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Button buttonCircpump;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStatusHour;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonLighton;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonTempup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStatusCircul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStatusBlower;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStatusPump2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStatusPump1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStatusMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStatusDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStatusMinut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxStatusTemp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxStatusSettemp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxStatusHeat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStatusCircMode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxStatusClearray;
        private System.Windows.Forms.Panel panelfilter;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.CheckedListBox checkedListBoxFilter;
        private System.Windows.Forms.Button buttonSaveRTB;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxValue;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxLightMode;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxLightCycle;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxLightBrightnes;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxLightB;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxLightG;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxLightR;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxStatusYear;
        private System.Windows.Forms.TextBox textBoxOrderData;
        private System.Windows.Forms.TextBox textBoxorderChannel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxOrderCommand;
        private System.Windows.Forms.Label labelOrderLength;
        private System.Windows.Forms.Label labelOrderType;
        private System.Windows.Forms.Label labelOrderCrc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxStatusFilter2;
        private System.Windows.Forms.NumericUpDown numericUpDownTempOrder;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numericUpDownColorB;
        private System.Windows.Forms.NumericUpDown numericUpDownColorG;
        private System.Windows.Forms.NumericUpDown numericUpDownColorR;
        private System.Windows.Forms.TrackBar trackBarLigthSpeed;
        private System.Windows.Forms.TrackBar trackBarLigthPower;
        private System.Windows.Forms.Button buttonLightSpeed;
        private System.Windows.Forms.RadioButton radioButtonOutTimer;
        private System.Windows.Forms.RadioButton radioButtonOutLigthOn2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButtonOutLigthOn1;
        private System.Windows.Forms.RadioButton radioButtonOutLigthOff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonOrderYear;
        private System.Windows.Forms.TextBox textBoxOrderYear;
        private System.Windows.Forms.Button buttonOrderUnitTemp;
        private System.Windows.Forms.ComboBox comboBoxOrderUnitTemp;
        private System.Windows.Forms.CheckBox checkBoxAllFrame;
        private System.Windows.Forms.ComboBox comboBoxOrderFilter2;
        private System.Windows.Forms.Button buttonOrderFilter2;
    }
}

