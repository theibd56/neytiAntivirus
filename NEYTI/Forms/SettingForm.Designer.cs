namespace NEYTI.Forms
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AutoRunCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NotificationSound = new System.Windows.Forms.CheckBox();
            this.TaskbarTrayMode = new System.Windows.Forms.CheckBox();
            this.MaliciousUtilitesCheckbox = new System.Windows.Forms.CheckBox();
            this.acrUSBM = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WebcamProtection_Link = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(505, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "LICENSE KEY: THIS PROGRAM IS IN BETA TESTING";
            // 
            // AutoRunCheck
            // 
            this.AutoRunCheck.AutoSize = true;
            this.AutoRunCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoRunCheck.ForeColor = System.Drawing.Color.White;
            this.AutoRunCheck.Location = new System.Drawing.Point(26, 53);
            this.AutoRunCheck.Name = "AutoRunCheck";
            this.AutoRunCheck.Size = new System.Drawing.Size(284, 24);
            this.AutoRunCheck.TabIndex = 15;
            this.AutoRunCheck.Text = "Enable antivirus on Windows startup";
            this.AutoRunCheck.UseVisualStyleBackColor = true;
            this.AutoRunCheck.CheckedChanged += new System.EventHandler(this.AutoRunCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "OPERATING MODE";
            // 
            // NotificationSound
            // 
            this.NotificationSound.AutoSize = true;
            this.NotificationSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationSound.ForeColor = System.Drawing.Color.White;
            this.NotificationSound.Location = new System.Drawing.Point(25, 167);
            this.NotificationSound.Name = "NotificationSound";
            this.NotificationSound.Size = new System.Drawing.Size(204, 44);
            this.NotificationSound.TabIndex = 25;
            this.NotificationSound.Text = "Accompany notifications \r\nwiths sound signal\r\n";
            this.NotificationSound.UseVisualStyleBackColor = true;
            // 
            // TaskbarTrayMode
            // 
            this.TaskbarTrayMode.AutoSize = true;
            this.TaskbarTrayMode.Checked = true;
            this.TaskbarTrayMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TaskbarTrayMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskbarTrayMode.ForeColor = System.Drawing.Color.White;
            this.TaskbarTrayMode.Location = new System.Drawing.Point(25, 92);
            this.TaskbarTrayMode.Name = "TaskbarTrayMode";
            this.TaskbarTrayMode.Size = new System.Drawing.Size(328, 24);
            this.TaskbarTrayMode.TabIndex = 26;
            this.TaskbarTrayMode.Text = "Minimize the application to the taskbar tray";
            this.TaskbarTrayMode.UseVisualStyleBackColor = true;
            this.TaskbarTrayMode.CheckedChanged += new System.EventHandler(this.TaskbarTrayMode_CheckedChanged);
            // 
            // MaliciousUtilitesCheckbox
            // 
            this.MaliciousUtilitesCheckbox.AutoSize = true;
            this.MaliciousUtilitesCheckbox.Checked = true;
            this.MaliciousUtilitesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaliciousUtilitesCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaliciousUtilitesCheckbox.ForeColor = System.Drawing.Color.White;
            this.MaliciousUtilitesCheckbox.Location = new System.Drawing.Point(26, 133);
            this.MaliciousUtilitesCheckbox.Name = "MaliciousUtilitesCheckbox";
            this.MaliciousUtilitesCheckbox.Size = new System.Drawing.Size(208, 24);
            this.MaliciousUtilitesCheckbox.TabIndex = 16;
            this.MaliciousUtilitesCheckbox.Text = "Remove malicious utilities";
            this.MaliciousUtilitesCheckbox.UseVisualStyleBackColor = true;
            this.MaliciousUtilitesCheckbox.CheckedChanged += new System.EventHandler(this.RemoveMaliciousUtilites_CheckedChanged);
            // 
            // acrUSBM
            // 
            this.acrUSBM.AutoSize = true;
            this.acrUSBM.Checked = true;
            this.acrUSBM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.acrUSBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acrUSBM.ForeColor = System.Drawing.Color.White;
            this.acrUSBM.Location = new System.Drawing.Point(18, 51);
            this.acrUSBM.Name = "acrUSBM";
            this.acrUSBM.Size = new System.Drawing.Size(297, 24);
            this.acrUSBM.TabIndex = 27;
            this.acrUSBM.Text = "Activate device control (USBManager)";
            this.acrUSBM.UseVisualStyleBackColor = true;
            this.acrUSBM.CheckedChanged += new System.EventHandler(this.acrUSBM_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "LANGUAGE";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.ForeColor = System.Drawing.Color.Transparent;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English (UK)",
            "English (US)",
            "English (AU)",
            "English (CA)"});
            this.comboBox1.Location = new System.Drawing.Point(18, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "English(US)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NotificationSound);
            this.panel1.Controls.Add(this.AutoRunCheck);
            this.panel1.Controls.Add(this.MaliciousUtilitesCheckbox);
            this.panel1.Controls.Add(this.TaskbarTrayMode);
            this.panel1.Location = new System.Drawing.Point(24, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 222);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(418, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 100);
            this.panel3.TabIndex = 33;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.acrUSBM);
            this.panel4.Location = new System.Drawing.Point(24, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 100);
            this.panel4.TabIndex = 34;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "ACTIVATE ADDITIONAL FEATURES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "WEBCAM PROTECTION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.WebcamProtection_Link);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(418, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 98);
            this.panel2.TabIndex = 35;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // WebcamProtection_Link
            // 
            this.WebcamProtection_Link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.WebcamProtection_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WebcamProtection_Link.LinkColor = System.Drawing.Color.Transparent;
            this.WebcamProtection_Link.Location = new System.Drawing.Point(13, 46);
            this.WebcamProtection_Link.Name = "WebcamProtection_Link";
            this.WebcamProtection_Link.Size = new System.Drawing.Size(259, 40);
            this.WebcamProtection_Link.TabIndex = 7;
            this.WebcamProtection_Link.TabStop = true;
            this.WebcamProtection_Link.Text = "Add, edit or remove applications \r\nin the webcam access list";
            this.WebcamProtection_Link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.WebcamProtection_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebcamProtection_Link_LinkClicked);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(779, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox AutoRunCheck;
        public System.Windows.Forms.CheckBox NotificationSound;
        public System.Windows.Forms.CheckBox TaskbarTrayMode;
        public System.Windows.Forms.CheckBox MaliciousUtilitesCheckbox;
        public System.Windows.Forms.CheckBox acrUSBM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel WebcamProtection_Link;
    }
}