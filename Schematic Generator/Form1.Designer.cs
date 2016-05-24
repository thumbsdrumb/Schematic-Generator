namespace Schematic_Generator
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
            this.PhaseButton2_Click = new System.Windows.Forms.Button();
            this.singlePhaseOptions = new System.Windows.Forms.ComboBox();
            this.VoltageSelection1_Click = new System.Windows.Forms.Button();
            this.VoltageSelection2_Click = new System.Windows.Forms.Button();
            this.PhaseButton1_Click = new System.Windows.Forms.Button();
            this.VoltageSelection3_Click = new System.Windows.Forms.Button();
            this.VoltageSelection4_Click = new System.Windows.Forms.Button();
            this.DisconnectOption1_Click = new System.Windows.Forms.Button();
            this.DisconnectOption2_Click = new System.Windows.Forms.Button();
            this.HiLoButton_Click = new System.Windows.Forms.Button();
            this.RecircButton_Click = new System.Windows.Forms.Button();
            this.LN2Option_Click = new System.Windows.Forms.Button();
            this.DAPOption_Click = new System.Windows.Forms.Button();
            this.FrozenCoilOption_Click = new System.Windows.Forms.Button();
            this.AtomizerOption_Click = new System.Windows.Forms.Button();
            this.IEEEOption_Click = new System.Windows.Forms.Button();
            this.MonitorOption_Click = new System.Windows.Forms.Button();
            this.RTDOption_Click = new System.Windows.Forms.Button();
            this.DigOut_Click = new System.Windows.Forms.Button();
            this.ChartOption_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.threePhaseOptions = new System.Windows.Forms.ComboBox();
            this.DigIn_Click = new System.Windows.Forms.Button();
            this.SizeOption_Click = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HourMeter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.GenerateScript = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ClearScript = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhaseButton2_Click
            // 
            this.PhaseButton2_Click.Location = new System.Drawing.Point(90, 18);
            this.PhaseButton2_Click.Name = "PhaseButton2_Click";
            this.PhaseButton2_Click.Size = new System.Drawing.Size(75, 23);
            this.PhaseButton2_Click.TabIndex = 1;
            this.PhaseButton2_Click.Text = "60Hz";
            this.PhaseButton2_Click.UseVisualStyleBackColor = true;
            this.PhaseButton2_Click.Click += new System.EventHandler(this.PhaseButton2_Click_Click);
            // 
            // singlePhaseOptions
            // 
            this.singlePhaseOptions.FormattingEnabled = true;
            this.singlePhaseOptions.Items.AddRange(new object[] {
            "  (NONE SELECTED)",
            "ZP-8_16_32-2-H_AC",
            "ZP-44_64-2-H_AC",
            "ZPH-8_16_32-2-H_AC",
            "ZPH-44_64-2-H_AC",
            "ZP-8_16_32-2-SCT_AC",
            "ZPH-8_16_32-2-SCT_AC",
            "ZP-8-1-1-H_AC",
            "ZPH-8-1-1-H_AC",
            "ZP-8_16_32-2-2-H_AC",
            "ZPH-8_16_32-2-2-H_AC",
            "",
            ""});
            this.singlePhaseOptions.Location = new System.Drawing.Point(6, 52);
            this.singlePhaseOptions.Name = "singlePhaseOptions";
            this.singlePhaseOptions.Size = new System.Drawing.Size(133, 22);
            this.singlePhaseOptions.TabIndex = 2;
            this.singlePhaseOptions.Text = "   (NONE SELECTED)";
            this.singlePhaseOptions.SelectedIndexChanged += new System.EventHandler(this.singlePhaseOptions_SelectedIndexChanged);
            // 
            // VoltageSelection1_Click
            // 
            this.VoltageSelection1_Click.Location = new System.Drawing.Point(9, 29);
            this.VoltageSelection1_Click.Name = "VoltageSelection1_Click";
            this.VoltageSelection1_Click.Size = new System.Drawing.Size(75, 23);
            this.VoltageSelection1_Click.TabIndex = 3;
            this.VoltageSelection1_Click.Text = "200VAC";
            this.VoltageSelection1_Click.UseVisualStyleBackColor = true;
            this.VoltageSelection1_Click.Click += new System.EventHandler(this.VoltageSelection1_Click_Click);
            // 
            // VoltageSelection2_Click
            // 
            this.VoltageSelection2_Click.Location = new System.Drawing.Point(90, 29);
            this.VoltageSelection2_Click.Name = "VoltageSelection2_Click";
            this.VoltageSelection2_Click.Size = new System.Drawing.Size(75, 23);
            this.VoltageSelection2_Click.TabIndex = 4;
            this.VoltageSelection2_Click.Text = "208VAC";
            this.VoltageSelection2_Click.UseVisualStyleBackColor = true;
            this.VoltageSelection2_Click.Click += new System.EventHandler(this.VoltageSelection2_Click_Click);
            // 
            // PhaseButton1_Click
            // 
            this.PhaseButton1_Click.Location = new System.Drawing.Point(9, 18);
            this.PhaseButton1_Click.Name = "PhaseButton1_Click";
            this.PhaseButton1_Click.Size = new System.Drawing.Size(75, 23);
            this.PhaseButton1_Click.TabIndex = 5;
            this.PhaseButton1_Click.Text = "50Hz";
            this.PhaseButton1_Click.UseVisualStyleBackColor = true;
            this.PhaseButton1_Click.Click += new System.EventHandler(this.PhaseButton1_Click_Click);
            // 
            // VoltageSelection3_Click
            // 
            this.VoltageSelection3_Click.Location = new System.Drawing.Point(9, 62);
            this.VoltageSelection3_Click.Name = "VoltageSelection3_Click";
            this.VoltageSelection3_Click.Size = new System.Drawing.Size(75, 23);
            this.VoltageSelection3_Click.TabIndex = 6;
            this.VoltageSelection3_Click.Text = "220VAC";
            this.VoltageSelection3_Click.UseVisualStyleBackColor = true;
            this.VoltageSelection3_Click.Click += new System.EventHandler(this.VoltageSelection3_Click_Click);
            // 
            // VoltageSelection4_Click
            // 
            this.VoltageSelection4_Click.Location = new System.Drawing.Point(90, 62);
            this.VoltageSelection4_Click.Name = "VoltageSelection4_Click";
            this.VoltageSelection4_Click.Size = new System.Drawing.Size(75, 23);
            this.VoltageSelection4_Click.TabIndex = 7;
            this.VoltageSelection4_Click.Text = "230VAC";
            this.VoltageSelection4_Click.UseVisualStyleBackColor = true;
            this.VoltageSelection4_Click.Click += new System.EventHandler(this.VoltageSelection4_Click_Click);
            // 
            // DisconnectOption1_Click
            // 
            this.DisconnectOption1_Click.Location = new System.Drawing.Point(93, 19);
            this.DisconnectOption1_Click.Name = "DisconnectOption1_Click";
            this.DisconnectOption1_Click.Size = new System.Drawing.Size(75, 23);
            this.DisconnectOption1_Click.TabIndex = 8;
            this.DisconnectOption1_Click.Text = "3PH DISC";
            this.DisconnectOption1_Click.UseVisualStyleBackColor = true;
            this.DisconnectOption1_Click.Click += new System.EventHandler(this.DisconnectOption1_Click_Click);
            // 
            // DisconnectOption2_Click
            // 
            this.DisconnectOption2_Click.Location = new System.Drawing.Point(9, 19);
            this.DisconnectOption2_Click.Name = "DisconnectOption2_Click";
            this.DisconnectOption2_Click.Size = new System.Drawing.Size(75, 23);
            this.DisconnectOption2_Click.TabIndex = 9;
            this.DisconnectOption2_Click.Text = "1PH DISC";
            this.DisconnectOption2_Click.UseVisualStyleBackColor = true;
            this.DisconnectOption2_Click.Click += new System.EventHandler(this.DisconnectOption2_Click_Click);
            // 
            // HiLoButton_Click
            // 
            this.HiLoButton_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HiLoButton_Click.Location = new System.Drawing.Point(473, 26);
            this.HiLoButton_Click.Name = "HiLoButton_Click";
            this.HiLoButton_Click.Size = new System.Drawing.Size(75, 23);
            this.HiLoButton_Click.TabIndex = 10;
            this.HiLoButton_Click.Text = "HI/LO LIMIT";
            this.HiLoButton_Click.UseVisualStyleBackColor = true;
            this.HiLoButton_Click.Click += new System.EventHandler(this.HiLoButton_Click_Click);
            // 
            // RecircButton_Click
            // 
            this.RecircButton_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RecircButton_Click.Location = new System.Drawing.Point(198, 63);
            this.RecircButton_Click.Name = "RecircButton_Click";
            this.RecircButton_Click.Size = new System.Drawing.Size(75, 23);
            this.RecircButton_Click.TabIndex = 11;
            this.RecircButton_Click.Text = "RECIRC";
            this.RecircButton_Click.UseVisualStyleBackColor = true;
            this.RecircButton_Click.Click += new System.EventHandler(this.RecircButton_Click_Click);
            // 
            // LN2Option_Click
            // 
            this.LN2Option_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LN2Option_Click.Location = new System.Drawing.Point(473, 65);
            this.LN2Option_Click.Name = "LN2Option_Click";
            this.LN2Option_Click.Size = new System.Drawing.Size(75, 23);
            this.LN2Option_Click.TabIndex = 12;
            this.LN2Option_Click.Text = "LN2";
            this.LN2Option_Click.UseVisualStyleBackColor = true;
            this.LN2Option_Click.Click += new System.EventHandler(this.LN2Option_Click_Click);
            // 
            // DAPOption_Click
            // 
            this.DAPOption_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DAPOption_Click.Location = new System.Drawing.Point(290, 26);
            this.DAPOption_Click.Name = "DAPOption_Click";
            this.DAPOption_Click.Size = new System.Drawing.Size(75, 23);
            this.DAPOption_Click.TabIndex = 13;
            this.DAPOption_Click.Text = "DAP";
            this.DAPOption_Click.UseVisualStyleBackColor = true;
            this.DAPOption_Click.Click += new System.EventHandler(this.DAPOption_Click_Click);
            // 
            // FrozenCoilOption_Click
            // 
            this.FrozenCoilOption_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FrozenCoilOption_Click.Location = new System.Drawing.Point(564, 65);
            this.FrozenCoilOption_Click.Name = "FrozenCoilOption_Click";
            this.FrozenCoilOption_Click.Size = new System.Drawing.Size(75, 23);
            this.FrozenCoilOption_Click.TabIndex = 14;
            this.FrozenCoilOption_Click.Text = "FRZ COIL";
            this.FrozenCoilOption_Click.UseVisualStyleBackColor = true;
            this.FrozenCoilOption_Click.Click += new System.EventHandler(this.FrozenCoilOption_Click_Click);
            // 
            // AtomizerOption_Click
            // 
            this.AtomizerOption_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AtomizerOption_Click.Location = new System.Drawing.Point(381, 65);
            this.AtomizerOption_Click.Name = "AtomizerOption_Click";
            this.AtomizerOption_Click.Size = new System.Drawing.Size(75, 23);
            this.AtomizerOption_Click.TabIndex = 15;
            this.AtomizerOption_Click.Text = "ATOMIZER";
            this.AtomizerOption_Click.UseVisualStyleBackColor = true;
            this.AtomizerOption_Click.Click += new System.EventHandler(this.AtomizerOption_Click_Click);
            // 
            // IEEEOption_Click
            // 
            this.IEEEOption_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.IEEEOption_Click.Location = new System.Drawing.Point(107, 63);
            this.IEEEOption_Click.Name = "IEEEOption_Click";
            this.IEEEOption_Click.Size = new System.Drawing.Size(75, 23);
            this.IEEEOption_Click.TabIndex = 16;
            this.IEEEOption_Click.Text = "IEEE";
            this.IEEEOption_Click.UseVisualStyleBackColor = true;
            this.IEEEOption_Click.Click += new System.EventHandler(this.IEEEOption_Click_Click);
            // 
            // MonitorOption_Click
            // 
            this.MonitorOption_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MonitorOption_Click.Location = new System.Drawing.Point(290, 65);
            this.MonitorOption_Click.Name = "MonitorOption_Click";
            this.MonitorOption_Click.Size = new System.Drawing.Size(75, 23);
            this.MonitorOption_Click.TabIndex = 17;
            this.MonitorOption_Click.Text = "MONITOR";
            this.MonitorOption_Click.UseVisualStyleBackColor = true;
            this.MonitorOption_Click.Click += new System.EventHandler(this.MonitorOption_Click_Click);
            // 
            // RTDOption_Click
            // 
            this.RTDOption_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RTDOption_Click.Location = new System.Drawing.Point(381, 26);
            this.RTDOption_Click.Name = "RTDOption_Click";
            this.RTDOption_Click.Size = new System.Drawing.Size(75, 23);
            this.RTDOption_Click.TabIndex = 18;
            this.RTDOption_Click.Text = "RTD";
            this.RTDOption_Click.UseVisualStyleBackColor = true;
            this.RTDOption_Click.Click += new System.EventHandler(this.RTDOption_Click_Click);
            // 
            // DigOut_Click
            // 
            this.DigOut_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DigOut_Click.Location = new System.Drawing.Point(17, 63);
            this.DigOut_Click.Name = "DigOut_Click";
            this.DigOut_Click.Size = new System.Drawing.Size(75, 23);
            this.DigOut_Click.TabIndex = 19;
            this.DigOut_Click.Text = "DIG OUT";
            this.DigOut_Click.UseVisualStyleBackColor = true;
            this.DigOut_Click.Click += new System.EventHandler(this.DigOut_Click_Click);
            // 
            // ChartOption_Click
            // 
            this.ChartOption_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ChartOption_Click.Location = new System.Drawing.Point(564, 26);
            this.ChartOption_Click.Name = "ChartOption_Click";
            this.ChartOption_Click.Size = new System.Drawing.Size(75, 23);
            this.ChartOption_Click.TabIndex = 20;
            this.ChartOption_Click.Text = "CHART";
            this.ChartOption_Click.UseVisualStyleBackColor = true;
            this.ChartOption_Click.Click += new System.EventHandler(this.ChartOption_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "(SINGLE PHASE)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "(THREE PHASE)";
            // 
            // threePhaseOptions
            // 
            this.threePhaseOptions.FormattingEnabled = true;
            this.threePhaseOptions.Items.AddRange(new object[] {
            "  (NONE SELECTED)",
            "ZP-8_16_32-2-H_AC",
            "ZP-44_64-2-H_AC",
            "ZPH-8_16_32-2-H_AC",
            "ZPH-44_64-2-H_AC",
            "ZP-8_16_32-2-SCT_AC",
            "ZPH-8_16_32-2-SCT_AC",
            "ZP-8-1-1-H_AC",
            "ZPH-8-1-1-H_AC",
            "ZP-8_16_32-2-2-H_AC",
            "ZPH-8_16_32-2-2-H_AC"});
            this.threePhaseOptions.Location = new System.Drawing.Point(157, 52);
            this.threePhaseOptions.Name = "threePhaseOptions";
            this.threePhaseOptions.Size = new System.Drawing.Size(133, 22);
            this.threePhaseOptions.TabIndex = 23;
            this.threePhaseOptions.Text = "   (NONE SELECTED)";
            this.threePhaseOptions.SelectedIndexChanged += new System.EventHandler(this.threePhaseOptions_SelectedIndexChanged);
            // 
            // DigIn_Click
            // 
            this.DigIn_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DigIn_Click.Location = new System.Drawing.Point(17, 26);
            this.DigIn_Click.Name = "DigIn_Click";
            this.DigIn_Click.Size = new System.Drawing.Size(75, 23);
            this.DigIn_Click.TabIndex = 26;
            this.DigIn_Click.Text = "DIG IN";
            this.DigIn_Click.UseVisualStyleBackColor = true;
            this.DigIn_Click.Click += new System.EventHandler(this.DigIn_Click_Click);
            // 
            // SizeOption_Click
            // 
            this.SizeOption_Click.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SizeOption_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SizeOption_Click.Location = new System.Drawing.Point(198, 26);
            this.SizeOption_Click.Name = "SizeOption_Click";
            this.SizeOption_Click.Size = new System.Drawing.Size(75, 23);
            this.SizeOption_Click.TabIndex = 27;
            this.SizeOption_Click.Text = "32,44,64";
            this.SizeOption_Click.UseVisualStyleBackColor = true;
            this.SizeOption_Click.Click += new System.EventHandler(this.SizeOption_Click_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.LN2Option_Click);
            this.groupBox1.Controls.Add(this.SizeOption_Click);
            this.groupBox1.Controls.Add(this.HourMeter);
            this.groupBox1.Controls.Add(this.DigIn_Click);
            this.groupBox1.Controls.Add(this.ChartOption_Click);
            this.groupBox1.Controls.Add(this.DigOut_Click);
            this.groupBox1.Controls.Add(this.RTDOption_Click);
            this.groupBox1.Controls.Add(this.HiLoButton_Click);
            this.groupBox1.Controls.Add(this.MonitorOption_Click);
            this.groupBox1.Controls.Add(this.RecircButton_Click);
            this.groupBox1.Controls.Add(this.IEEEOption_Click);
            this.groupBox1.Controls.Add(this.DAPOption_Click);
            this.groupBox1.Controls.Add(this.AtomizerOption_Click);
            this.groupBox1.Controls.Add(this.FrozenCoilOption_Click);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 102);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHAMBER OPTIONS";
            // 
            // HourMeter
            // 
            this.HourMeter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HourMeter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HourMeter.Location = new System.Drawing.Point(107, 26);
            this.HourMeter.Name = "HourMeter";
            this.HourMeter.Size = new System.Drawing.Size(75, 23);
            this.HourMeter.TabIndex = 0;
            this.HourMeter.Text = "HR METER";
            this.HourMeter.UseVisualStyleBackColor = true;
            this.HourMeter.Click += new System.EventHandler(this.HourMeter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = global::Schematic_Generator.Properties.Resources.CSZ;
            this.pictureBox1.Location = new System.Drawing.Point(438, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 121);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.VoltageSelection1_Click);
            this.groupBox2.Controls.Add(this.VoltageSelection2_Click);
            this.groupBox2.Controls.Add(this.VoltageSelection3_Click);
            this.groupBox2.Controls.Add(this.VoltageSelection4_Click);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 100);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VOLTAGE OPTIONS";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.singlePhaseOptions);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.threePhaseOptions);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 100);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MODEL NUMBER";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.PhaseButton1_Click);
            this.groupBox4.Controls.Add(this.PhaseButton2_Click);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(498, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 48);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FREQUENCY OPTIONS";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.DisconnectOption1_Click);
            this.groupBox5.Controls.Add(this.DisconnectOption2_Click);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Location = new System.Drawing.Point(498, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(174, 48);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DISCONNECT OPTIONS";
            // 
            // GenerateScript
            // 
            this.GenerateScript.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GenerateScript.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GenerateScript.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenerateScript.Location = new System.Drawing.Point(0, 0);
            this.GenerateScript.Name = "GenerateScript";
            this.GenerateScript.Size = new System.Drawing.Size(150, 42);
            this.GenerateScript.TabIndex = 34;
            this.GenerateScript.Text = "GENERATE SCRIPT";
            this.GenerateScript.UseVisualStyleBackColor = false;
            this.GenerateScript.Click += new System.EventHandler(this.GenerateScript_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox6.Controls.Add(this.GenerateScript);
            this.groupBox6.Location = new System.Drawing.Point(17, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(150, 42);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox7.Controls.Add(this.ClearScript);
            this.groupBox7.Location = new System.Drawing.Point(199, 30);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(151, 42);
            this.groupBox7.TabIndex = 36;
            this.groupBox7.TabStop = false;
            // 
            // ClearScript
            // 
            this.ClearScript.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClearScript.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearScript.Location = new System.Drawing.Point(0, 0);
            this.ClearScript.Name = "ClearScript";
            this.ClearScript.Size = new System.Drawing.Size(151, 42);
            this.ClearScript.TabIndex = 34;
            this.ClearScript.Text = "CLEAR SCRIPT";
            this.ClearScript.UseVisualStyleBackColor = false;
            this.ClearScript.Click += new System.EventHandler(this.ClearScript_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox8.Controls.Add(this.groupBox7);
            this.groupBox8.Controls.Add(this.groupBox6);
            this.groupBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox8.Location = new System.Drawing.Point(36, 255);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(366, 100);
            this.groupBox8.TabIndex = 37;
            this.groupBox8.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(683, 382);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "SCHEMATIC GENERATOR";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PhaseButton2_Click;
        private System.Windows.Forms.ComboBox singlePhaseOptions;
        private System.Windows.Forms.Button VoltageSelection1_Click;
        private System.Windows.Forms.Button VoltageSelection2_Click;
        private System.Windows.Forms.Button PhaseButton1_Click;
        private System.Windows.Forms.Button VoltageSelection3_Click;
        private System.Windows.Forms.Button VoltageSelection4_Click;
        private System.Windows.Forms.Button DisconnectOption1_Click;
        private System.Windows.Forms.Button DisconnectOption2_Click;
        private System.Windows.Forms.Button HiLoButton_Click;
        private System.Windows.Forms.Button RecircButton_Click;
        private System.Windows.Forms.Button LN2Option_Click;
        private System.Windows.Forms.Button DAPOption_Click;
        private System.Windows.Forms.Button FrozenCoilOption_Click;
        private System.Windows.Forms.Button AtomizerOption_Click;
        private System.Windows.Forms.Button IEEEOption_Click;
        private System.Windows.Forms.Button MonitorOption_Click;
        private System.Windows.Forms.Button RTDOption_Click;
        private System.Windows.Forms.Button DigOut_Click;
        private System.Windows.Forms.Button ChartOption_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox threePhaseOptions;
        private System.Windows.Forms.Button DigIn_Click;
        private System.Windows.Forms.Button SizeOption_Click;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button GenerateScript;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button ClearScript;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button HourMeter;
    }
}

