using System.Windows.Forms;

namespace UARTTerminalPro
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
            this.labelTerminal = new System.Windows.Forms.Label();
            this.rtbTerminal = new System.Windows.Forms.RichTextBox();
            this.checkBoxTimestamp = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoScroll = new System.Windows.Forms.CheckBox();
            this.checkBoxHexMode = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.labelComPort = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkBoxHexSend = new System.Windows.Forms.CheckBox();
            this.checkBoxPeriodic = new System.Windows.Forms.CheckBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.textBoxPeriod = new System.Windows.Forms.NumericUpDown();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimerPeriodicSend = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRxCount = new System.Windows.Forms.Label();
            this.labelTxCount = new System.Windows.Forms.Label();
            this.labelFailCount = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPeriod)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTerminal
            // 
            this.labelTerminal.AutoSize = true;
            this.labelTerminal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTerminal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.labelTerminal.Location = new System.Drawing.Point(16, 113);
            this.labelTerminal.Name = "labelTerminal";
            this.labelTerminal.Size = new System.Drawing.Size(119, 19);
            this.labelTerminal.TabIndex = 0;
            this.labelTerminal.Text = "UART TERMINAL";
            // 
            // rtbTerminal
            // 
            this.rtbTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.rtbTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTerminal.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbTerminal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.rtbTerminal.Location = new System.Drawing.Point(0, 0);
            this.rtbTerminal.Name = "rtbTerminal";
            this.rtbTerminal.ReadOnly = true;
            this.rtbTerminal.Size = new System.Drawing.Size(713, 299);
            this.rtbTerminal.TabIndex = 1;
            this.rtbTerminal.Text = "";
            // 
            // checkBoxTimestamp
            // 
            this.checkBoxTimestamp.AutoSize = true;
            this.checkBoxTimestamp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxTimestamp.ForeColor = System.Drawing.Color.White;
            this.checkBoxTimestamp.Location = new System.Drawing.Point(31, 448);
            this.checkBoxTimestamp.Name = "checkBoxTimestamp";
            this.checkBoxTimestamp.Size = new System.Drawing.Size(86, 19);
            this.checkBoxTimestamp.TabIndex = 2;
            this.checkBoxTimestamp.Text = "Timestamp";
            this.checkBoxTimestamp.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoScroll
            // 
            this.checkBoxAutoScroll.AutoSize = true;
            this.checkBoxAutoScroll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxAutoScroll.ForeColor = System.Drawing.Color.White;
            this.checkBoxAutoScroll.Location = new System.Drawing.Point(123, 448);
            this.checkBoxAutoScroll.Name = "checkBoxAutoScroll";
            this.checkBoxAutoScroll.Size = new System.Drawing.Size(84, 19);
            this.checkBoxAutoScroll.TabIndex = 3;
            this.checkBoxAutoScroll.Text = "Auto Scroll";
            this.checkBoxAutoScroll.UseVisualStyleBackColor = true;
            // 
            // checkBoxHexMode
            // 
            this.checkBoxHexMode.AutoSize = true;
            this.checkBoxHexMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxHexMode.ForeColor = System.Drawing.Color.White;
            this.checkBoxHexMode.Location = new System.Drawing.Point(224, 448);
            this.checkBoxHexMode.Name = "checkBoxHexMode";
            this.checkBoxHexMode.Size = new System.Drawing.Size(82, 19);
            this.checkBoxHexMode.TabIndex = 4;
            this.checkBoxHexMode.Text = "HEX Mode";
            this.checkBoxHexMode.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(442, 445);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(135, 26);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "TERMİNALİ TEMİZLE";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.buttonSaveLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSaveLog.ForeColor = System.Drawing.Color.White;
            this.buttonSaveLog.Location = new System.Drawing.Point(591, 445);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(135, 26);
            this.buttonSaveLog.TabIndex = 7;
            this.buttonSaveLog.Text = "LOG KAYDET";
            this.buttonSaveLog.UseVisualStyleBackColor = false;
            this.buttonSaveLog.Click += new System.EventHandler(this.buttonSaveLog_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.textBoxSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSend.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.textBoxSend.Location = new System.Drawing.Point(18, 505);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(571, 96);
            this.textBoxSend.TabIndex = 8;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.panelSettings.Controls.Add(this.comboBoxStopBits);
            this.panelSettings.Controls.Add(this.comboBoxParity);
            this.panelSettings.Controls.Add(this.comboBoxDataBits);
            this.panelSettings.Controls.Add(this.comboBoxBaudRate);
            this.panelSettings.Controls.Add(this.comboBoxComPort);
            this.panelSettings.Controls.Add(this.labelComPort);
            this.panelSettings.Controls.Add(this.labelBaudRate);
            this.panelSettings.Controls.Add(this.labelDataBits);
            this.panelSettings.Controls.Add(this.labelParity);
            this.panelSettings.Controls.Add(this.labelStopBits);
            this.panelSettings.Controls.Add(this.buttonConnection);
            this.panelSettings.Controls.Add(this.labelStatus);
            this.panelSettings.Location = new System.Drawing.Point(20, 20);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(711, 90);
            this.panelSettings.TabIndex = 9;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(402, 30);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(96, 23);
            this.comboBoxStopBits.TabIndex = 5;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(306, 30);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(86, 23);
            this.comboBoxParity.TabIndex = 4;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(226, 30);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(70, 23);
            this.comboBoxDataBits.TabIndex = 3;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(120, 30);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(96, 23);
            this.comboBoxBaudRate.TabIndex = 2;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(3, 30);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(110, 23);
            this.comboBoxComPort.TabIndex = 1;
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.labelComPort.Location = new System.Drawing.Point(12, 10);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(60, 15);
            this.labelComPort.TabIndex = 0;
            this.labelComPort.Text = "COM Port";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.labelBaudRate.Location = new System.Drawing.Point(132, 10);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(54, 15);
            this.labelBaudRate.TabIndex = 0;
            this.labelBaudRate.Text = "Baudrate";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.labelDataBits.Location = new System.Drawing.Point(238, 10);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(53, 15);
            this.labelDataBits.TabIndex = 0;
            this.labelDataBits.Text = "Data Bits";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.labelParity.Location = new System.Drawing.Point(318, 10);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(37, 15);
            this.labelParity.TabIndex = 0;
            this.labelParity.Text = "Parity";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.labelStopBits.Location = new System.Drawing.Point(414, 10);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(53, 15);
            this.labelStopBits.TabIndex = 0;
            this.labelStopBits.Text = "Stop Bits";
            // 
            // buttonConnection
            // 
            this.buttonConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(88)))), ((int)(((byte)(176)))));
            this.buttonConnection.FlatAppearance.BorderSize = 0;
            this.buttonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonConnection.ForeColor = System.Drawing.Color.White;
            this.buttonConnection.Location = new System.Drawing.Point(508, 27);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(117, 26);
            this.buttonConnection.TabIndex = 0;
            this.buttonConnection.Text = "Bağlan";
            this.buttonConnection.UseVisualStyleBackColor = false;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelStatus.Location = new System.Drawing.Point(625, 31);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(86, 17);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "● Bağlı değil";
            // 
            // checkBoxHexSend
            // 
            this.checkBoxHexSend.AutoSize = true;
            this.checkBoxHexSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxHexSend.ForeColor = System.Drawing.Color.White;
            this.checkBoxHexSend.Location = new System.Drawing.Point(20, 607);
            this.checkBoxHexSend.Name = "checkBoxHexSend";
            this.checkBoxHexSend.Size = new System.Drawing.Size(90, 19);
            this.checkBoxHexSend.TabIndex = 0;
            this.checkBoxHexSend.Text = "HEX Gönder";
            this.checkBoxHexSend.UseVisualStyleBackColor = true;
            // 
            // checkBoxPeriodic
            // 
            this.checkBoxPeriodic.AutoSize = true;
            this.checkBoxPeriodic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxPeriodic.ForeColor = System.Drawing.Color.White;
            this.checkBoxPeriodic.Location = new System.Drawing.Point(127, 607);
            this.checkBoxPeriodic.Name = "checkBoxPeriodic";
            this.checkBoxPeriodic.Size = new System.Drawing.Size(117, 19);
            this.checkBoxPeriodic.TabIndex = 0;
            this.checkBoxPeriodic.Text = "Periyodik Gönder";
            this.checkBoxPeriodic.UseVisualStyleBackColor = true;
            this.checkBoxPeriodic.CheckedChanged += new System.EventHandler(this.checkBoxPeriodic_CheckedChanged);
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.labelPeriod.Location = new System.Drawing.Point(257, 605);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(81, 19);
            this.labelPeriod.TabIndex = 0;
            this.labelPeriod.Text = "Periyot (ms)";
            this.labelPeriod.Click += new System.EventHandler(this.labelPeriod_Click);
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.BackColor = System.Drawing.Color.White;
            this.textBoxPeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPeriod.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxPeriod.Location = new System.Drawing.Point(341, 605);
            this.textBoxPeriod.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.textBoxPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(77, 23);
            this.textBoxPeriod.TabIndex = 0;
            this.textBoxPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPeriod.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxPeriod.TextChanged += new System.EventHandler(this.textBoxPeriod_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(88)))), ((int)(((byte)(176)))));
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(592, 530);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(140, 48);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "➤ GÖNDER";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(16, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "COMMANDS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtbTerminal);
            this.panel1.Location = new System.Drawing.Point(18, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 301);
            this.panel1.TabIndex = 11;
            // 
            // TimerPeriodicSend
            // 
            this.TimerPeriodicSend.Tick += new System.EventHandler(this.TimerPeriodicSend_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelRxCount);
            this.panel2.Controls.Add(this.labelTxCount);
            this.panel2.Controls.Add(this.labelFailCount);
            this.panel2.Controls.Add(this.version);
            this.panel2.Location = new System.Drawing.Point(12, 634);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 38);
            this.panel2.TabIndex = 12;
            // 
            // labelRxCount
            // 
            this.labelRxCount.AutoSize = true;
            this.labelRxCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.labelRxCount.Location = new System.Drawing.Point(75, 10);
            this.labelRxCount.Name = "labelRxCount";
            this.labelRxCount.Size = new System.Drawing.Size(13, 15);
            this.labelRxCount.TabIndex = 1;
            this.labelRxCount.Text = "0";
            // 
            // labelTxCount
            // 
            this.labelTxCount.AutoSize = true;
            this.labelTxCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.labelTxCount.Location = new System.Drawing.Point(169, 10);
            this.labelTxCount.Name = "labelTxCount";
            this.labelTxCount.Size = new System.Drawing.Size(13, 15);
            this.labelTxCount.TabIndex = 2;
            this.labelTxCount.Text = "0";
            // 
            // labelFailCount
            // 
            this.labelFailCount.AutoSize = true;
            this.labelFailCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.labelFailCount.Location = new System.Drawing.Point(260, 10);
            this.labelFailCount.Name = "labelFailCount";
            this.labelFailCount.Size = new System.Drawing.Size(13, 15);
            this.labelFailCount.TabIndex = 3;
            this.labelFailCount.Text = "0";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.version.Location = new System.Drawing.Point(570, 10);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(131, 15);
            this.version.TabIndex = 0;
            this.version.Text = "UART Terminal Pro V1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(147, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(240, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(747, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTerminal);
            this.Controls.Add(this.checkBoxTimestamp);
            this.Controls.Add(this.checkBoxAutoScroll);
            this.Controls.Add(this.checkBoxHexMode);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSaveLog);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.checkBoxHexSend);
            this.Controls.Add(this.checkBoxPeriodic);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(755, 695);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UART Terminal Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPeriod)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTerminal;
        private System.Windows.Forms.RichTextBox rtbTerminal;
        private System.Windows.Forms.CheckBox checkBoxTimestamp;
        private System.Windows.Forms.CheckBox checkBoxAutoScroll;
        private System.Windows.Forms.CheckBox checkBoxHexMode;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSaveLog;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkBoxHexSend;
        private System.Windows.Forms.CheckBox checkBoxPeriodic;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.NumericUpDown textBoxPeriod;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label1;
        private ComboBox comboBoxStopBits;
        private ComboBox comboBoxParity;
        private ComboBox comboBoxDataBits;
        private ComboBox comboBoxBaudRate;
        private ComboBox comboBoxComPort;
        private Panel panel1;
        private Timer TimerPeriodicSend;
        private Panel panel2;
        private Label version;
        private Label labelRxCount;
        private Label labelTxCount;
        private Label labelFailCount;
        private Label label3;
        private Label label2;
    }
}
