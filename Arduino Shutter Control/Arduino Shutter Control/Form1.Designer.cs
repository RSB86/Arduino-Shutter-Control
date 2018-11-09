﻿namespace Arduino_Shutter_Control
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
            this.listViewSerialPorts = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonM1CmdIN = new System.Windows.Forms.Button();
            this.buttonM1CmdOUT = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panelSystem = new System.Windows.Forms.Panel();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.comboBoxCh5 = new System.Windows.Forms.ComboBox();
            this.textBoxCh5FwdPosIs = new System.Windows.Forms.TextBox();
            this.comboBoxCh4 = new System.Windows.Forms.ComboBox();
            this.textBoxCh4FwdPosIs = new System.Windows.Forms.TextBox();
            this.comboBoxCh3 = new System.Windows.Forms.ComboBox();
            this.textBoxCh3FwdPosIs = new System.Windows.Forms.TextBox();
            this.comboBoxCh2 = new System.Windows.Forms.ComboBox();
            this.textBoxCh2FwdPosIs = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.TextBoxConfigStatus = new System.Windows.Forms.TextBox();
            this.comboBoxCh1 = new System.Windows.Forms.ComboBox();
            this.textBoxCh1FwdPosIs = new System.Windows.Forms.TextBox();
            this.NumChanneslConfigured = new System.Windows.Forms.NumericUpDown();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.panelCh1 = new System.Windows.Forms.Panel();
            this.panelCh1Fdbk = new System.Windows.Forms.Panel();
            this.M1FdbkOUT = new Arduino_Shutter_Control.RoundButton();
            this.M1FdbkIN = new Arduino_Shutter_Control.RoundButton();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panelCh1Cmd = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.M1Name = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panelCh2 = new System.Windows.Forms.Panel();
            this.panelCh2Fdbk = new System.Windows.Forms.Panel();
            this.M2FdbkOUT = new Arduino_Shutter_Control.RoundButton();
            this.M2FdbkIN = new Arduino_Shutter_Control.RoundButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panelCh2Cmd = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonM2CmdIN = new System.Windows.Forms.Button();
            this.buttonM2CmdOUT = new System.Windows.Forms.Button();
            this.M2Name = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.panelCh3 = new System.Windows.Forms.Panel();
            this.panelCh3Fdbk = new System.Windows.Forms.Panel();
            this.M3FdbkOUT = new Arduino_Shutter_Control.RoundButton();
            this.M3FdbkIN = new Arduino_Shutter_Control.RoundButton();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.panelCh3Cmd = new System.Windows.Forms.Panel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.buttonM3CmdIN = new System.Windows.Forms.Button();
            this.buttonM3CmdOUT = new System.Windows.Forms.Button();
            this.M3Name = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.panelCh4 = new System.Windows.Forms.Panel();
            this.panelCh4Fdbk = new System.Windows.Forms.Panel();
            this.M4FdbkOUT = new Arduino_Shutter_Control.RoundButton();
            this.M4FdbkIN = new Arduino_Shutter_Control.RoundButton();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.panelCh4Cmd = new System.Windows.Forms.Panel();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.buttonM4CmdIN = new System.Windows.Forms.Button();
            this.buttonM4CmdOUT = new System.Windows.Forms.Button();
            this.M4Name = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.panelCh5 = new System.Windows.Forms.Panel();
            this.panelCh5Fdbk = new System.Windows.Forms.Panel();
            this.M5FdbkOUT = new Arduino_Shutter_Control.RoundButton();
            this.M5FdbkIN = new Arduino_Shutter_Control.RoundButton();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.panelCh5Cmd = new System.Windows.Forms.Panel();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.buttonM5CmdIN = new System.Windows.Forms.Button();
            this.buttonM5CmdOUT = new System.Windows.Forms.Button();
            this.M5Name = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.panelSystem.SuspendLayout();
            this.panelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumChanneslConfigured)).BeginInit();
            this.panelCh1.SuspendLayout();
            this.panelCh1Fdbk.SuspendLayout();
            this.panelCh1Cmd.SuspendLayout();
            this.panelCh2.SuspendLayout();
            this.panelCh2Fdbk.SuspendLayout();
            this.panelCh2Cmd.SuspendLayout();
            this.panelCh3.SuspendLayout();
            this.panelCh3Fdbk.SuspendLayout();
            this.panelCh3Cmd.SuspendLayout();
            this.panelCh4.SuspendLayout();
            this.panelCh4Fdbk.SuspendLayout();
            this.panelCh4Cmd.SuspendLayout();
            this.panelCh5.SuspendLayout();
            this.panelCh5Fdbk.SuspendLayout();
            this.panelCh5Cmd.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSerialPorts
            // 
            this.listViewSerialPorts.FullRowSelect = true;
            this.listViewSerialPorts.Location = new System.Drawing.Point(10, 40);
            this.listViewSerialPorts.Margin = new System.Windows.Forms.Padding(2);
            this.listViewSerialPorts.Name = "listViewSerialPorts";
            this.listViewSerialPorts.Size = new System.Drawing.Size(324, 106);
            this.listViewSerialPorts.TabIndex = 1;
            this.listViewSerialPorts.UseCompatibleStateImageBehavior = false;
            this.listViewSerialPorts.SelectedIndexChanged += new System.EventHandler(this.ListViewSerialPorts_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 223);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 22);
            this.textBox1.TabIndex = 2;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Silver;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(10, 152);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(95, 45);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh List";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Silver;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(125, 151);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(95, 45);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonM1CmdIN
            // 
            this.buttonM1CmdIN.BackColor = System.Drawing.Color.Silver;
            this.buttonM1CmdIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM1CmdIN.Location = new System.Drawing.Point(20, 25);
            this.buttonM1CmdIN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonM1CmdIN.Name = "buttonM1CmdIN";
            this.buttonM1CmdIN.Size = new System.Drawing.Size(100, 45);
            this.buttonM1CmdIN.TabIndex = 5;
            this.buttonM1CmdIN.Text = "IN";
            this.buttonM1CmdIN.UseVisualStyleBackColor = false;
            this.buttonM1CmdIN.Click += new System.EventHandler(this.buttonMCmdIN_Click);
            // 
            // buttonM1CmdOUT
            // 
            this.buttonM1CmdOUT.BackColor = System.Drawing.Color.Silver;
            this.buttonM1CmdOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM1CmdOUT.Location = new System.Drawing.Point(160, 25);
            this.buttonM1CmdOUT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonM1CmdOUT.Name = "buttonM1CmdOUT";
            this.buttonM1CmdOUT.Size = new System.Drawing.Size(100, 45);
            this.buttonM1CmdOUT.TabIndex = 6;
            this.buttonM1CmdOUT.Text = "OUT";
            this.buttonM1CmdOUT.UseVisualStyleBackColor = false;
            this.buttonM1CmdOUT.Click += new System.EventHandler(this.buttonMCmdOUT_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.Silver;
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(239, 151);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(95, 45);
            this.buttonDisconnect.TabIndex = 8;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(10, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(324, 24);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "System Connection";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(324, 19);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Connection Status";
            // 
            // panelSystem
            // 
            this.panelSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSystem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSystem.Controls.Add(this.panelConfig);
            this.panelSystem.Controls.Add(this.textBox2);
            this.panelSystem.Controls.Add(this.textBox3);
            this.panelSystem.Controls.Add(this.listViewSerialPorts);
            this.panelSystem.Controls.Add(this.textBox1);
            this.panelSystem.Controls.Add(this.buttonRefresh);
            this.panelSystem.Controls.Add(this.buttonConnect);
            this.panelSystem.Controls.Add(this.buttonDisconnect);
            this.panelSystem.Location = new System.Drawing.Point(14, 71);
            this.panelSystem.Name = "panelSystem";
            this.panelSystem.Size = new System.Drawing.Size(344, 644);
            this.panelSystem.TabIndex = 13;
            // 
            // panelConfig
            // 
            this.panelConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelConfig.Controls.Add(this.comboBoxCh5);
            this.panelConfig.Controls.Add(this.textBoxCh5FwdPosIs);
            this.panelConfig.Controls.Add(this.comboBoxCh4);
            this.panelConfig.Controls.Add(this.textBoxCh4FwdPosIs);
            this.panelConfig.Controls.Add(this.comboBoxCh3);
            this.panelConfig.Controls.Add(this.textBoxCh3FwdPosIs);
            this.panelConfig.Controls.Add(this.comboBoxCh2);
            this.panelConfig.Controls.Add(this.textBoxCh2FwdPosIs);
            this.panelConfig.Controls.Add(this.textBox17);
            this.panelConfig.Controls.Add(this.TextBoxConfigStatus);
            this.panelConfig.Controls.Add(this.comboBoxCh1);
            this.panelConfig.Controls.Add(this.textBoxCh1FwdPosIs);
            this.panelConfig.Controls.Add(this.NumChanneslConfigured);
            this.panelConfig.Controls.Add(this.textBox25);
            this.panelConfig.Controls.Add(this.textBox24);
            this.panelConfig.Location = new System.Drawing.Point(12, 252);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(322, 383);
            this.panelConfig.TabIndex = 13;
            // 
            // comboBoxCh5
            // 
            this.comboBoxCh5.FormattingEnabled = true;
            this.comboBoxCh5.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.comboBoxCh5.Location = new System.Drawing.Point(151, 235);
            this.comboBoxCh5.Name = "comboBoxCh5";
            this.comboBoxCh5.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCh5.TabIndex = 28;
            this.comboBoxCh5.SelectedIndexChanged += new System.EventHandler(this.comboBoxCh_SelectedIndexChanged);
            // 
            // textBoxCh5FwdPosIs
            // 
            this.textBoxCh5FwdPosIs.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCh5FwdPosIs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCh5FwdPosIs.Enabled = false;
            this.textBoxCh5FwdPosIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCh5FwdPosIs.Location = new System.Drawing.Point(17, 235);
            this.textBoxCh5FwdPosIs.Multiline = true;
            this.textBoxCh5FwdPosIs.Name = "textBoxCh5FwdPosIs";
            this.textBoxCh5FwdPosIs.Size = new System.Drawing.Size(128, 22);
            this.textBoxCh5FwdPosIs.TabIndex = 27;
            this.textBoxCh5FwdPosIs.Text = "Ch. 5 Fwd. Pos. is";
            // 
            // comboBoxCh4
            // 
            this.comboBoxCh4.FormattingEnabled = true;
            this.comboBoxCh4.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.comboBoxCh4.Location = new System.Drawing.Point(151, 208);
            this.comboBoxCh4.Name = "comboBoxCh4";
            this.comboBoxCh4.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCh4.TabIndex = 26;
            this.comboBoxCh4.SelectedIndexChanged += new System.EventHandler(this.comboBoxCh_SelectedIndexChanged);
            // 
            // textBoxCh4FwdPosIs
            // 
            this.textBoxCh4FwdPosIs.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCh4FwdPosIs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCh4FwdPosIs.Enabled = false;
            this.textBoxCh4FwdPosIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCh4FwdPosIs.Location = new System.Drawing.Point(17, 208);
            this.textBoxCh4FwdPosIs.Multiline = true;
            this.textBoxCh4FwdPosIs.Name = "textBoxCh4FwdPosIs";
            this.textBoxCh4FwdPosIs.Size = new System.Drawing.Size(128, 22);
            this.textBoxCh4FwdPosIs.TabIndex = 25;
            this.textBoxCh4FwdPosIs.Text = "Ch. 4 Fwd. Pos. is";
            // 
            // comboBoxCh3
            // 
            this.comboBoxCh3.FormattingEnabled = true;
            this.comboBoxCh3.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.comboBoxCh3.Location = new System.Drawing.Point(151, 181);
            this.comboBoxCh3.Name = "comboBoxCh3";
            this.comboBoxCh3.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCh3.TabIndex = 24;
            this.comboBoxCh3.SelectedIndexChanged += new System.EventHandler(this.comboBoxCh_SelectedIndexChanged);
            // 
            // textBoxCh3FwdPosIs
            // 
            this.textBoxCh3FwdPosIs.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCh3FwdPosIs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCh3FwdPosIs.Enabled = false;
            this.textBoxCh3FwdPosIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCh3FwdPosIs.Location = new System.Drawing.Point(17, 181);
            this.textBoxCh3FwdPosIs.Multiline = true;
            this.textBoxCh3FwdPosIs.Name = "textBoxCh3FwdPosIs";
            this.textBoxCh3FwdPosIs.Size = new System.Drawing.Size(128, 22);
            this.textBoxCh3FwdPosIs.TabIndex = 23;
            this.textBoxCh3FwdPosIs.Text = "Ch. 3 Fwd. Pos. is";
            // 
            // comboBoxCh2
            // 
            this.comboBoxCh2.FormattingEnabled = true;
            this.comboBoxCh2.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.comboBoxCh2.Location = new System.Drawing.Point(151, 154);
            this.comboBoxCh2.Name = "comboBoxCh2";
            this.comboBoxCh2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCh2.TabIndex = 22;
            this.comboBoxCh2.SelectedIndexChanged += new System.EventHandler(this.comboBoxCh_SelectedIndexChanged);
            // 
            // textBoxCh2FwdPosIs
            // 
            this.textBoxCh2FwdPosIs.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCh2FwdPosIs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCh2FwdPosIs.Enabled = false;
            this.textBoxCh2FwdPosIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCh2FwdPosIs.Location = new System.Drawing.Point(17, 154);
            this.textBoxCh2FwdPosIs.Multiline = true;
            this.textBoxCh2FwdPosIs.Name = "textBoxCh2FwdPosIs";
            this.textBoxCh2FwdPosIs.Size = new System.Drawing.Size(128, 22);
            this.textBoxCh2FwdPosIs.TabIndex = 21;
            this.textBoxCh2FwdPosIs.Text = "Ch. 2 Fwd. Pos. is";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.Control;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Enabled = false;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(4, 333);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(324, 19);
            this.textBox17.TabIndex = 20;
            this.textBox17.Text = "Configuration Status";
            // 
            // TextBoxConfigStatus
            // 
            this.TextBoxConfigStatus.Location = new System.Drawing.Point(4, 354);
            this.TextBoxConfigStatus.Name = "TextBoxConfigStatus";
            this.TextBoxConfigStatus.Size = new System.Drawing.Size(311, 20);
            this.TextBoxConfigStatus.TabIndex = 19;
            // 
            // comboBoxCh1
            // 
            this.comboBoxCh1.FormattingEnabled = true;
            this.comboBoxCh1.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.comboBoxCh1.Location = new System.Drawing.Point(151, 70);
            this.comboBoxCh1.Name = "comboBoxCh1";
            this.comboBoxCh1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCh1.TabIndex = 18;
            this.comboBoxCh1.SelectedIndexChanged += new System.EventHandler(this.comboBoxCh_SelectedIndexChanged);
            // 
            // textBoxCh1FwdPosIs
            // 
            this.textBoxCh1FwdPosIs.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCh1FwdPosIs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCh1FwdPosIs.Enabled = false;
            this.textBoxCh1FwdPosIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCh1FwdPosIs.Location = new System.Drawing.Point(17, 70);
            this.textBoxCh1FwdPosIs.Multiline = true;
            this.textBoxCh1FwdPosIs.Name = "textBoxCh1FwdPosIs";
            this.textBoxCh1FwdPosIs.Size = new System.Drawing.Size(128, 22);
            this.textBoxCh1FwdPosIs.TabIndex = 17;
            this.textBoxCh1FwdPosIs.Text = "Ch. 1 Fwd. Pos. is";
            // 
            // NumChanneslConfigured
            // 
            this.NumChanneslConfigured.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumChanneslConfigured.Location = new System.Drawing.Point(210, 31);
            this.NumChanneslConfigured.Name = "NumChanneslConfigured";
            this.NumChanneslConfigured.Size = new System.Drawing.Size(62, 26);
            this.NumChanneslConfigured.TabIndex = 15;
            this.NumChanneslConfigured.ValueChanged += new System.EventHandler(this.NumChanneslConfigured_ValueChanged);
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.SystemColors.Control;
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox25.Enabled = false;
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox25.Location = new System.Drawing.Point(17, 33);
            this.textBox25.Multiline = true;
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(212, 22);
            this.textBox25.TabIndex = 16;
            this.textBox25.Text = "Num. Channels Configured";
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.SystemColors.Control;
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.Enabled = false;
            this.textBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.Location = new System.Drawing.Point(4, 3);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(275, 22);
            this.textBox24.TabIndex = 14;
            this.textBox24.Text = "Configuration";
            // 
            // panelCh1
            // 
            this.panelCh1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCh1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh1.Controls.Add(this.panelCh1Fdbk);
            this.panelCh1.Controls.Add(this.panelCh1Cmd);
            this.panelCh1.Controls.Add(this.M1Name);
            this.panelCh1.Controls.Add(this.textBox5);
            this.panelCh1.Location = new System.Drawing.Point(364, 71);
            this.panelCh1.Name = "panelCh1";
            this.panelCh1.Size = new System.Drawing.Size(620, 125);
            this.panelCh1.TabIndex = 15;
            // 
            // panelCh1Fdbk
            // 
            this.panelCh1Fdbk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh1Fdbk.Controls.Add(this.M1FdbkOUT);
            this.panelCh1Fdbk.Controls.Add(this.M1FdbkIN);
            this.panelCh1Fdbk.Controls.Add(this.textBox8);
            this.panelCh1Fdbk.Location = new System.Drawing.Point(320, 38);
            this.panelCh1Fdbk.Name = "panelCh1Fdbk";
            this.panelCh1Fdbk.Size = new System.Drawing.Size(280, 80);
            this.panelCh1Fdbk.TabIndex = 16;
            // 
            // M1FdbkOUT
            // 
            this.M1FdbkOUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.M1FdbkOUT.BackColor = System.Drawing.Color.Silver;
            this.M1FdbkOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M1FdbkOUT.Location = new System.Drawing.Point(180, 6);
            this.M1FdbkOUT.Name = "M1FdbkOUT";
            this.M1FdbkOUT.Size = new System.Drawing.Size(70, 70);
            this.M1FdbkOUT.TabIndex = 19;
            this.M1FdbkOUT.Text = "OUT";
            this.M1FdbkOUT.UseVisualStyleBackColor = false;
            // 
            // M1FdbkIN
            // 
            this.M1FdbkIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.M1FdbkIN.BackColor = System.Drawing.Color.Silver;
            this.M1FdbkIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M1FdbkIN.Location = new System.Drawing.Point(30, 6);
            this.M1FdbkIN.Name = "M1FdbkIN";
            this.M1FdbkIN.Size = new System.Drawing.Size(70, 70);
            this.M1FdbkIN.TabIndex = 18;
            this.M1FdbkIN.Text = "IN";
            this.M1FdbkIN.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(100, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(122, 15);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "Feedback";
            // 
            // panelCh1Cmd
            // 
            this.panelCh1Cmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh1Cmd.Controls.Add(this.textBox7);
            this.panelCh1Cmd.Controls.Add(this.buttonM1CmdIN);
            this.panelCh1Cmd.Controls.Add(this.buttonM1CmdOUT);
            this.panelCh1Cmd.Location = new System.Drawing.Point(20, 38);
            this.panelCh1Cmd.Name = "panelCh1Cmd";
            this.panelCh1Cmd.Size = new System.Drawing.Size(280, 80);
            this.panelCh1Cmd.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(100, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(122, 15);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "Commands";
            // 
            // M1Name
            // 
            this.M1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M1Name.Location = new System.Drawing.Point(77, 4);
            this.M1Name.Margin = new System.Windows.Forms.Padding(2);
            this.M1Name.Name = "M1Name";
            this.M1Name.Size = new System.Drawing.Size(537, 29);
            this.M1Name.TabIndex = 16;
            this.M1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.M1Name.TextChanged += new System.EventHandler(this.MotorName_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(3, 11);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 15);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Channel 1";
            // 
            // panelCh2
            // 
            this.panelCh2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCh2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh2.Controls.Add(this.panelCh2Fdbk);
            this.panelCh2.Controls.Add(this.panelCh2Cmd);
            this.panelCh2.Controls.Add(this.M2Name);
            this.panelCh2.Controls.Add(this.textBox10);
            this.panelCh2.Location = new System.Drawing.Point(364, 202);
            this.panelCh2.Name = "panelCh2";
            this.panelCh2.Size = new System.Drawing.Size(620, 125);
            this.panelCh2.TabIndex = 18;
            // 
            // panelCh2Fdbk
            // 
            this.panelCh2Fdbk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh2Fdbk.Controls.Add(this.M2FdbkOUT);
            this.panelCh2Fdbk.Controls.Add(this.M2FdbkIN);
            this.panelCh2Fdbk.Controls.Add(this.textBox4);
            this.panelCh2Fdbk.Location = new System.Drawing.Point(320, 38);
            this.panelCh2Fdbk.Name = "panelCh2Fdbk";
            this.panelCh2Fdbk.Size = new System.Drawing.Size(280, 80);
            this.panelCh2Fdbk.TabIndex = 16;
            // 
            // M2FdbkOUT
            // 
            this.M2FdbkOUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.M2FdbkOUT.BackColor = System.Drawing.Color.Silver;
            this.M2FdbkOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M2FdbkOUT.Location = new System.Drawing.Point(180, 6);
            this.M2FdbkOUT.Name = "M2FdbkOUT";
            this.M2FdbkOUT.Size = new System.Drawing.Size(70, 70);
            this.M2FdbkOUT.TabIndex = 21;
            this.M2FdbkOUT.Text = "OUT";
            this.M2FdbkOUT.UseVisualStyleBackColor = false;
            // 
            // M2FdbkIN
            // 
            this.M2FdbkIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.M2FdbkIN.BackColor = System.Drawing.Color.Silver;
            this.M2FdbkIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M2FdbkIN.Location = new System.Drawing.Point(30, 6);
            this.M2FdbkIN.Name = "M2FdbkIN";
            this.M2FdbkIN.Size = new System.Drawing.Size(70, 70);
            this.M2FdbkIN.TabIndex = 20;
            this.M2FdbkIN.Text = "IN";
            this.M2FdbkIN.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(100, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 15);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Feedback";
            // 
            // panelCh2Cmd
            // 
            this.panelCh2Cmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh2Cmd.Controls.Add(this.textBox6);
            this.panelCh2Cmd.Controls.Add(this.buttonM2CmdIN);
            this.panelCh2Cmd.Controls.Add(this.buttonM2CmdOUT);
            this.panelCh2Cmd.Location = new System.Drawing.Point(20, 38);
            this.panelCh2Cmd.Name = "panelCh2Cmd";
            this.panelCh2Cmd.Size = new System.Drawing.Size(280, 80);
            this.panelCh2Cmd.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(100, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(122, 15);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "Commands";
            // 
            // buttonM2CmdIN
            // 
            this.buttonM2CmdIN.BackColor = System.Drawing.Color.Silver;
            this.buttonM2CmdIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM2CmdIN.Location = new System.Drawing.Point(20, 25);
            this.buttonM2CmdIN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonM2CmdIN.Name = "buttonM2CmdIN";
            this.buttonM2CmdIN.Size = new System.Drawing.Size(100, 45);
            this.buttonM2CmdIN.TabIndex = 5;
            this.buttonM2CmdIN.Text = "IN";
            this.buttonM2CmdIN.UseVisualStyleBackColor = false;
            this.buttonM2CmdIN.Click += new System.EventHandler(this.buttonMCmdIN_Click);
            // 
            // buttonM2CmdOUT
            // 
            this.buttonM2CmdOUT.BackColor = System.Drawing.Color.Silver;
            this.buttonM2CmdOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM2CmdOUT.Location = new System.Drawing.Point(160, 25);
            this.buttonM2CmdOUT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonM2CmdOUT.Name = "buttonM2CmdOUT";
            this.buttonM2CmdOUT.Size = new System.Drawing.Size(100, 45);
            this.buttonM2CmdOUT.TabIndex = 6;
            this.buttonM2CmdOUT.Text = "OUT";
            this.buttonM2CmdOUT.UseVisualStyleBackColor = false;
            this.buttonM2CmdOUT.Click += new System.EventHandler(this.buttonMCmdOUT_Click);
            // 
            // M2Name
            // 
            this.M2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M2Name.Location = new System.Drawing.Point(77, 4);
            this.M2Name.Margin = new System.Windows.Forms.Padding(2);
            this.M2Name.Name = "M2Name";
            this.M2Name.Size = new System.Drawing.Size(537, 29);
            this.M2Name.TabIndex = 16;
            this.M2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.M2Name.TextChanged += new System.EventHandler(this.MotorName_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(3, 11);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(78, 15);
            this.textBox10.TabIndex = 15;
            this.textBox10.Text = "Channel 2";
            // 
            // panelCh3
            // 
            this.panelCh3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCh3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh3.Controls.Add(this.panelCh3Fdbk);
            this.panelCh3.Controls.Add(this.panelCh3Cmd);
            this.panelCh3.Controls.Add(this.M3Name);
            this.panelCh3.Controls.Add(this.textBox14);
            this.panelCh3.Location = new System.Drawing.Point(364, 328);
            this.panelCh3.Name = "panelCh3";
            this.panelCh3.Size = new System.Drawing.Size(620, 125);
            this.panelCh3.TabIndex = 18;
            // 
            // panelCh3Fdbk
            // 
            this.panelCh3Fdbk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh3Fdbk.Controls.Add(this.M3FdbkOUT);
            this.panelCh3Fdbk.Controls.Add(this.M3FdbkIN);
            this.panelCh3Fdbk.Controls.Add(this.textBox11);
            this.panelCh3Fdbk.Location = new System.Drawing.Point(320, 38);
            this.panelCh3Fdbk.Name = "panelCh3Fdbk";
            this.panelCh3Fdbk.Size = new System.Drawing.Size(280, 80);
            this.panelCh3Fdbk.TabIndex = 16;
            // 
            // M3FdbkOUT
            // 
            this.M3FdbkOUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.M3FdbkOUT.BackColor = System.Drawing.Color.Silver;
            this.M3FdbkOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M3FdbkOUT.Location = new System.Drawing.Point(180, 6);
            this.M3FdbkOUT.Name = "M3FdbkOUT";
            this.M3FdbkOUT.Size = new System.Drawing.Size(70, 70);
            this.M3FdbkOUT.TabIndex = 21;
            this.M3FdbkOUT.Text = "OUT";
            this.M3FdbkOUT.UseVisualStyleBackColor = false;
            // 
            // M3FdbkIN
            // 
            this.M3FdbkIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.M3FdbkIN.BackColor = System.Drawing.Color.Silver;
            this.M3FdbkIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M3FdbkIN.Location = new System.Drawing.Point(30, 6);
            this.M3FdbkIN.Name = "M3FdbkIN";
            this.M3FdbkIN.Size = new System.Drawing.Size(70, 70);
            this.M3FdbkIN.TabIndex = 20;
            this.M3FdbkIN.Text = "IN";
            this.M3FdbkIN.UseVisualStyleBackColor = false;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Control;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Enabled = false;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.Black;
            this.textBox11.Location = new System.Drawing.Point(100, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(122, 15);
            this.textBox11.TabIndex = 17;
            this.textBox11.Text = "Feedback";
            // 
            // panelCh3Cmd
            // 
            this.panelCh3Cmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh3Cmd.Controls.Add(this.textBox12);
            this.panelCh3Cmd.Controls.Add(this.buttonM3CmdIN);
            this.panelCh3Cmd.Controls.Add(this.buttonM3CmdOUT);
            this.panelCh3Cmd.Location = new System.Drawing.Point(20, 38);
            this.panelCh3Cmd.Name = "panelCh3Cmd";
            this.panelCh3Cmd.Size = new System.Drawing.Size(280, 80);
            this.panelCh3Cmd.TabIndex = 17;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Enabled = false;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Black;
            this.textBox12.Location = new System.Drawing.Point(100, 3);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(122, 15);
            this.textBox12.TabIndex = 16;
            this.textBox12.Text = "Commands";
            // 
            // buttonM3CmdIN
            // 
            this.buttonM3CmdIN.BackColor = System.Drawing.Color.Silver;
            this.buttonM3CmdIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM3CmdIN.Location = new System.Drawing.Point(20, 25);
            this.buttonM3CmdIN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonM3CmdIN.Name = "buttonM3CmdIN";
            this.buttonM3CmdIN.Size = new System.Drawing.Size(100, 45);
            this.buttonM3CmdIN.TabIndex = 5;
            this.buttonM3CmdIN.Text = "IN";
            this.buttonM3CmdIN.UseVisualStyleBackColor = false;
            this.buttonM3CmdIN.Click += new System.EventHandler(this.buttonMCmdIN_Click);
            // 
            // buttonM3CmdOUT
            // 
            this.buttonM3CmdOUT.BackColor = System.Drawing.Color.Silver;
            this.buttonM3CmdOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM3CmdOUT.Location = new System.Drawing.Point(160, 25);
            this.buttonM3CmdOUT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonM3CmdOUT.Name = "buttonM3CmdOUT";
            this.buttonM3CmdOUT.Size = new System.Drawing.Size(100, 45);
            this.buttonM3CmdOUT.TabIndex = 6;
            this.buttonM3CmdOUT.Text = "OUT";
            this.buttonM3CmdOUT.UseVisualStyleBackColor = false;
            this.buttonM3CmdOUT.Click += new System.EventHandler(this.buttonMCmdOUT_Click);
            // 
            // M3Name
            // 
            this.M3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M3Name.Location = new System.Drawing.Point(77, 4);
            this.M3Name.Margin = new System.Windows.Forms.Padding(2);
            this.M3Name.Name = "M3Name";
            this.M3Name.Size = new System.Drawing.Size(537, 29);
            this.M3Name.TabIndex = 16;
            this.M3Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.M3Name.TextChanged += new System.EventHandler(this.MotorName_TextChanged);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Control;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Enabled = false;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.Black;
            this.textBox14.Location = new System.Drawing.Point(3, 11);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(78, 15);
            this.textBox14.TabIndex = 15;
            this.textBox14.Text = "Channel 3";
            // 
            // panelCh4
            // 
            this.panelCh4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCh4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh4.Controls.Add(this.panelCh4Fdbk);
            this.panelCh4.Controls.Add(this.panelCh4Cmd);
            this.panelCh4.Controls.Add(this.M4Name);
            this.panelCh4.Controls.Add(this.textBox18);
            this.panelCh4.Location = new System.Drawing.Point(364, 459);
            this.panelCh4.Name = "panelCh4";
            this.panelCh4.Size = new System.Drawing.Size(620, 125);
            this.panelCh4.TabIndex = 18;
            // 
            // panelCh4Fdbk
            // 
            this.panelCh4Fdbk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh4Fdbk.Controls.Add(this.M4FdbkOUT);
            this.panelCh4Fdbk.Controls.Add(this.M4FdbkIN);
            this.panelCh4Fdbk.Controls.Add(this.textBox15);
            this.panelCh4Fdbk.Location = new System.Drawing.Point(320, 38);
            this.panelCh4Fdbk.Name = "panelCh4Fdbk";
            this.panelCh4Fdbk.Size = new System.Drawing.Size(280, 80);
            this.panelCh4Fdbk.TabIndex = 16;
            // 
            // M4FdbkOUT
            // 
            this.M4FdbkOUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.M4FdbkOUT.BackColor = System.Drawing.Color.Silver;
            this.M4FdbkOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M4FdbkOUT.Location = new System.Drawing.Point(180, 6);
            this.M4FdbkOUT.Name = "M4FdbkOUT";
            this.M4FdbkOUT.Size = new System.Drawing.Size(70, 70);
            this.M4FdbkOUT.TabIndex = 21;
            this.M4FdbkOUT.Text = "OUT";
            this.M4FdbkOUT.UseVisualStyleBackColor = false;
            // 
            // M4FdbkIN
            // 
            this.M4FdbkIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.M4FdbkIN.BackColor = System.Drawing.Color.Silver;
            this.M4FdbkIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M4FdbkIN.Location = new System.Drawing.Point(30, 6);
            this.M4FdbkIN.Name = "M4FdbkIN";
            this.M4FdbkIN.Size = new System.Drawing.Size(70, 70);
            this.M4FdbkIN.TabIndex = 20;
            this.M4FdbkIN.Text = "IN";
            this.M4FdbkIN.UseVisualStyleBackColor = false;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Control;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Enabled = false;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.ForeColor = System.Drawing.Color.Black;
            this.textBox15.Location = new System.Drawing.Point(100, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(122, 15);
            this.textBox15.TabIndex = 17;
            this.textBox15.Text = "Feedback";
            // 
            // panelCh4Cmd
            // 
            this.panelCh4Cmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh4Cmd.Controls.Add(this.textBox16);
            this.panelCh4Cmd.Controls.Add(this.buttonM4CmdIN);
            this.panelCh4Cmd.Controls.Add(this.buttonM4CmdOUT);
            this.panelCh4Cmd.Location = new System.Drawing.Point(20, 38);
            this.panelCh4Cmd.Name = "panelCh4Cmd";
            this.panelCh4Cmd.Size = new System.Drawing.Size(280, 80);
            this.panelCh4Cmd.TabIndex = 17;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Control;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Enabled = false;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.Black;
            this.textBox16.Location = new System.Drawing.Point(100, 3);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(122, 15);
            this.textBox16.TabIndex = 16;
            this.textBox16.Text = "Commands";
            // 
            // buttonM4CmdIN
            // 
            this.buttonM4CmdIN.BackColor = System.Drawing.Color.Silver;
            this.buttonM4CmdIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM4CmdIN.Location = new System.Drawing.Point(20, 25);
            this.buttonM4CmdIN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonM4CmdIN.Name = "buttonM4CmdIN";
            this.buttonM4CmdIN.Size = new System.Drawing.Size(100, 45);
            this.buttonM4CmdIN.TabIndex = 5;
            this.buttonM4CmdIN.Text = "IN";
            this.buttonM4CmdIN.UseVisualStyleBackColor = false;
            this.buttonM4CmdIN.Click += new System.EventHandler(this.buttonMCmdIN_Click);
            // 
            // buttonM4CmdOUT
            // 
            this.buttonM4CmdOUT.BackColor = System.Drawing.Color.Silver;
            this.buttonM4CmdOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM4CmdOUT.Location = new System.Drawing.Point(160, 25);
            this.buttonM4CmdOUT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonM4CmdOUT.Name = "buttonM4CmdOUT";
            this.buttonM4CmdOUT.Size = new System.Drawing.Size(100, 45);
            this.buttonM4CmdOUT.TabIndex = 6;
            this.buttonM4CmdOUT.Text = "OUT";
            this.buttonM4CmdOUT.UseVisualStyleBackColor = false;
            this.buttonM4CmdOUT.Click += new System.EventHandler(this.buttonMCmdOUT_Click);
            // 
            // M4Name
            // 
            this.M4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M4Name.Location = new System.Drawing.Point(77, 4);
            this.M4Name.Margin = new System.Windows.Forms.Padding(2);
            this.M4Name.Name = "M4Name";
            this.M4Name.Size = new System.Drawing.Size(537, 29);
            this.M4Name.TabIndex = 16;
            this.M4Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.M4Name.TextChanged += new System.EventHandler(this.MotorName_TextChanged);
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.Control;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Enabled = false;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.ForeColor = System.Drawing.Color.Black;
            this.textBox18.Location = new System.Drawing.Point(3, 11);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(78, 15);
            this.textBox18.TabIndex = 15;
            this.textBox18.Text = "Channel 4";
            // 
            // panelCh5
            // 
            this.panelCh5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCh5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh5.Controls.Add(this.panelCh5Fdbk);
            this.panelCh5.Controls.Add(this.panelCh5Cmd);
            this.panelCh5.Controls.Add(this.M5Name);
            this.panelCh5.Controls.Add(this.textBox22);
            this.panelCh5.Location = new System.Drawing.Point(364, 590);
            this.panelCh5.Name = "panelCh5";
            this.panelCh5.Size = new System.Drawing.Size(620, 125);
            this.panelCh5.TabIndex = 18;
            // 
            // panelCh5Fdbk
            // 
            this.panelCh5Fdbk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh5Fdbk.Controls.Add(this.M5FdbkOUT);
            this.panelCh5Fdbk.Controls.Add(this.M5FdbkIN);
            this.panelCh5Fdbk.Controls.Add(this.textBox19);
            this.panelCh5Fdbk.Location = new System.Drawing.Point(320, 38);
            this.panelCh5Fdbk.Name = "panelCh5Fdbk";
            this.panelCh5Fdbk.Size = new System.Drawing.Size(280, 80);
            this.panelCh5Fdbk.TabIndex = 16;
            // 
            // M5FdbkOUT
            // 
            this.M5FdbkOUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.M5FdbkOUT.BackColor = System.Drawing.Color.Silver;
            this.M5FdbkOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M5FdbkOUT.Location = new System.Drawing.Point(180, 6);
            this.M5FdbkOUT.Name = "M5FdbkOUT";
            this.M5FdbkOUT.Size = new System.Drawing.Size(70, 70);
            this.M5FdbkOUT.TabIndex = 21;
            this.M5FdbkOUT.Text = "OUT";
            this.M5FdbkOUT.UseVisualStyleBackColor = false;
            // 
            // M5FdbkIN
            // 
            this.M5FdbkIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.M5FdbkIN.BackColor = System.Drawing.Color.Silver;
            this.M5FdbkIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M5FdbkIN.Location = new System.Drawing.Point(30, 6);
            this.M5FdbkIN.Name = "M5FdbkIN";
            this.M5FdbkIN.Size = new System.Drawing.Size(70, 70);
            this.M5FdbkIN.TabIndex = 20;
            this.M5FdbkIN.Text = "IN";
            this.M5FdbkIN.UseVisualStyleBackColor = false;
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.SystemColors.Control;
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Enabled = false;
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.ForeColor = System.Drawing.Color.Black;
            this.textBox19.Location = new System.Drawing.Point(100, 3);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(122, 15);
            this.textBox19.TabIndex = 17;
            this.textBox19.Text = "Feedback";
            // 
            // panelCh5Cmd
            // 
            this.panelCh5Cmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCh5Cmd.Controls.Add(this.textBox20);
            this.panelCh5Cmd.Controls.Add(this.buttonM5CmdIN);
            this.panelCh5Cmd.Controls.Add(this.buttonM5CmdOUT);
            this.panelCh5Cmd.Location = new System.Drawing.Point(20, 38);
            this.panelCh5Cmd.Name = "panelCh5Cmd";
            this.panelCh5Cmd.Size = new System.Drawing.Size(280, 80);
            this.panelCh5Cmd.TabIndex = 17;
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.SystemColors.Control;
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.Enabled = false;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.ForeColor = System.Drawing.Color.Black;
            this.textBox20.Location = new System.Drawing.Point(100, 3);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(122, 15);
            this.textBox20.TabIndex = 16;
            this.textBox20.Text = "Commands";
            // 
            // buttonM5CmdIN
            // 
            this.buttonM5CmdIN.BackColor = System.Drawing.Color.Silver;
            this.buttonM5CmdIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM5CmdIN.Location = new System.Drawing.Point(20, 25);
            this.buttonM5CmdIN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonM5CmdIN.Name = "buttonM5CmdIN";
            this.buttonM5CmdIN.Size = new System.Drawing.Size(100, 45);
            this.buttonM5CmdIN.TabIndex = 5;
            this.buttonM5CmdIN.Text = "IN";
            this.buttonM5CmdIN.UseVisualStyleBackColor = false;
            this.buttonM5CmdIN.Click += new System.EventHandler(this.buttonMCmdIN_Click);
            // 
            // buttonM5CmdOUT
            // 
            this.buttonM5CmdOUT.BackColor = System.Drawing.Color.Silver;
            this.buttonM5CmdOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM5CmdOUT.Location = new System.Drawing.Point(160, 25);
            this.buttonM5CmdOUT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonM5CmdOUT.Name = "buttonM5CmdOUT";
            this.buttonM5CmdOUT.Size = new System.Drawing.Size(100, 45);
            this.buttonM5CmdOUT.TabIndex = 6;
            this.buttonM5CmdOUT.Text = "OUT";
            this.buttonM5CmdOUT.UseVisualStyleBackColor = false;
            this.buttonM5CmdOUT.Click += new System.EventHandler(this.buttonMCmdOUT_Click);
            // 
            // M5Name
            // 
            this.M5Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M5Name.Location = new System.Drawing.Point(77, 4);
            this.M5Name.Margin = new System.Windows.Forms.Padding(2);
            this.M5Name.Name = "M5Name";
            this.M5Name.Size = new System.Drawing.Size(537, 29);
            this.M5Name.TabIndex = 16;
            this.M5Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.M5Name.TextChanged += new System.EventHandler(this.MotorName_TextChanged);
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.SystemColors.Control;
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Enabled = false;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.ForeColor = System.Drawing.Color.Black;
            this.textBox22.Location = new System.Drawing.Point(3, 11);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(78, 15);
            this.textBox22.TabIndex = 15;
            this.textBox22.Text = "Channel 5";
            // 
            // textBox23
            // 
            this.textBox23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox23.BackColor = System.Drawing.SystemColors.Control;
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Enabled = false;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(298, 10);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(445, 55);
            this.textBox23.TabIndex = 19;
            this.textBox23.Text = "Shutter Control";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.panelCh5);
            this.Controls.Add(this.panelCh4);
            this.Controls.Add(this.panelCh3);
            this.Controls.Add(this.panelCh2);
            this.Controls.Add(this.panelCh1);
            this.Controls.Add(this.panelSystem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSystem.ResumeLayout(false);
            this.panelSystem.PerformLayout();
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumChanneslConfigured)).EndInit();
            this.panelCh1.ResumeLayout(false);
            this.panelCh1.PerformLayout();
            this.panelCh1Fdbk.ResumeLayout(false);
            this.panelCh1Fdbk.PerformLayout();
            this.panelCh1Cmd.ResumeLayout(false);
            this.panelCh1Cmd.PerformLayout();
            this.panelCh2.ResumeLayout(false);
            this.panelCh2.PerformLayout();
            this.panelCh2Fdbk.ResumeLayout(false);
            this.panelCh2Fdbk.PerformLayout();
            this.panelCh2Cmd.ResumeLayout(false);
            this.panelCh2Cmd.PerformLayout();
            this.panelCh3.ResumeLayout(false);
            this.panelCh3.PerformLayout();
            this.panelCh3Fdbk.ResumeLayout(false);
            this.panelCh3Fdbk.PerformLayout();
            this.panelCh3Cmd.ResumeLayout(false);
            this.panelCh3Cmd.PerformLayout();
            this.panelCh4.ResumeLayout(false);
            this.panelCh4.PerformLayout();
            this.panelCh4Fdbk.ResumeLayout(false);
            this.panelCh4Fdbk.PerformLayout();
            this.panelCh4Cmd.ResumeLayout(false);
            this.panelCh4Cmd.PerformLayout();
            this.panelCh5.ResumeLayout(false);
            this.panelCh5.PerformLayout();
            this.panelCh5Fdbk.ResumeLayout(false);
            this.panelCh5Fdbk.PerformLayout();
            this.panelCh5Cmd.ResumeLayout(false);
            this.panelCh5Cmd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSerialPorts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonM1CmdIN;
        private System.Windows.Forms.Button buttonM1CmdOUT;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panelSystem;
        private System.Windows.Forms.Panel panelCh1;
        private System.Windows.Forms.TextBox M1Name;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panelCh1Cmd;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panelCh1Fdbk;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panelCh2;
        private System.Windows.Forms.Panel panelCh2Fdbk;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panelCh2Cmd;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button buttonM2CmdIN;
        private System.Windows.Forms.Button buttonM2CmdOUT;
        private System.Windows.Forms.TextBox M2Name;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Panel panelCh3;
        private System.Windows.Forms.Panel panelCh3Fdbk;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Panel panelCh3Cmd;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button buttonM3CmdIN;
        private System.Windows.Forms.Button buttonM3CmdOUT;
        private System.Windows.Forms.TextBox M3Name;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Panel panelCh4;
        private System.Windows.Forms.Panel panelCh4Fdbk;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Panel panelCh4Cmd;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button buttonM4CmdIN;
        private System.Windows.Forms.Button buttonM4CmdOUT;
        private System.Windows.Forms.TextBox M4Name;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Panel panelCh5;
        private System.Windows.Forms.Panel panelCh5Fdbk;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Panel panelCh5Cmd;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Button buttonM5CmdIN;
        private System.Windows.Forms.Button buttonM5CmdOUT;
        private System.Windows.Forms.TextBox M5Name;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.NumericUpDown NumChanneslConfigured;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBoxCh1FwdPosIs;
        private System.Windows.Forms.ComboBox comboBoxCh1;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox TextBoxConfigStatus;
        private System.Windows.Forms.ComboBox comboBoxCh5;
        private System.Windows.Forms.TextBox textBoxCh5FwdPosIs;
        private System.Windows.Forms.ComboBox comboBoxCh4;
        private System.Windows.Forms.TextBox textBoxCh4FwdPosIs;
        private System.Windows.Forms.ComboBox comboBoxCh3;
        private System.Windows.Forms.TextBox textBoxCh3FwdPosIs;
        private System.Windows.Forms.ComboBox comboBoxCh2;
        private System.Windows.Forms.TextBox textBoxCh2FwdPosIs;
        private RoundButton M1FdbkOUT;
        private RoundButton M1FdbkIN;
        private RoundButton M2FdbkOUT;
        private RoundButton M2FdbkIN;
        private RoundButton M3FdbkOUT;
        private RoundButton M3FdbkIN;
        private RoundButton M4FdbkOUT;
        private RoundButton M4FdbkIN;
        private RoundButton M5FdbkOUT;
        private RoundButton M5FdbkIN;
    }
}

