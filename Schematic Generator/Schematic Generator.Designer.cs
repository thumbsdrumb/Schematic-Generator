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
            this.HourMeter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.singlePhaseOptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // HourMeter
            // 
            this.HourMeter.Location = new System.Drawing.Point(12, 226);
            this.HourMeter.Name = "HourMeter";
            this.HourMeter.Size = new System.Drawing.Size(75, 23);
            this.HourMeter.TabIndex = 0;
            this.HourMeter.Text = "Hour Meter";
            this.HourMeter.UseVisualStyleBackColor = true;
            this.HourMeter.Click += new System.EventHandler(this.HourMeter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // singlePhaseOptions
            // 
            this.singlePhaseOptions.FormattingEnabled = true;
            this.singlePhaseOptions.Items.AddRange(new object[] {
            "ZP-8_16_32-2-H_AC",
            "ZP-44_64-2-H_AC",
            "ZPH-8_16_32-2-H_AC",
            "ZPH-8_16_32-2-H_AC",
            "ZPH-8_16_32-2-H_AC",
            "ZPH-8_16_32-2-SCT_AC",
            "ZPH-8_16_32-2-SCT_AC",
            "ZPH-8-1-1-H_AC",
            "ZP-8_16_32-2-2-H_AC",
            "ZPH-8_16_32-2-2-H_AC",
            "",
            "",
            "",
            "",
            ""});
            this.singlePhaseOptions.Location = new System.Drawing.Point(35, 23);
            this.singlePhaseOptions.Name = "singlePhaseOptions";
            this.singlePhaseOptions.Size = new System.Drawing.Size(121, 21);
            this.singlePhaseOptions.TabIndex = 2;
            this.singlePhaseOptions.SelectedIndexChanged += new System.EventHandler(this.singlePhaseOptions_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(562, 261);
            this.Controls.Add(this.singlePhaseOptions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HourMeter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HourMeterButton;
        private System.Windows.Forms.Button HourMeter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox singlePhaseOptions;
    }
}

