namespace NEYTI.Forms
{
    partial class PrivacyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_statues = new System.Windows.Forms.Label();
            this.btnBackup = new FontAwesome.Sharp.IconButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnRestore = new FontAwesome.Sharp.IconButton();
            this.btnBrowse = new FontAwesome.Sharp.IconButton();
            this.pathBackupFileLoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.WebcamProtection_Link = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.label1.TabIndex = 10;
            this.label1.Text = "LICENSE KEY: THIS PROGRAM IS IN BETA TESTING";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lb_statues);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.pathBackupFileLoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(30, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 244);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(20, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Backup status:";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // lb_statues
            // 
            this.lb_statues.AutoSize = true;
            this.lb_statues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lb_statues.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_statues.Location = new System.Drawing.Point(172, 202);
            this.lb_statues.Name = "lb_statues";
            this.lb_statues.Size = new System.Drawing.Size(49, 25);
            this.lb_statues.TabIndex = 31;
            this.lb_statues.Text = "N/A";
            // 
            // btnBackup
            // 
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBackup.IconColor = System.Drawing.Color.White;
            this.btnBackup.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBackup.IconSize = 31;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.Location = new System.Drawing.Point(14, 147);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBackup.Size = new System.Drawing.Size(111, 39);
            this.btnBackup.TabIndex = 30;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 109);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(465, 23);
            this.progressBar1.TabIndex = 29;
            // 
            // btnRestore
            // 
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRestore.IconColor = System.Drawing.Color.White;
            this.btnRestore.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRestore.IconSize = 31;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.Location = new System.Drawing.Point(132, 147);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRestore.Size = new System.Drawing.Size(124, 39);
            this.btnRestore.TabIndex = 28;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBrowse.IconColor = System.Drawing.Color.White;
            this.btnBrowse.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBrowse.IconSize = 31;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.Location = new System.Drawing.Point(505, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBrowse.Size = new System.Drawing.Size(118, 39);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.btnBrowse.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBrowse_Paint);
            // 
            // pathBackupFileLoc
            // 
            this.pathBackupFileLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.pathBackupFileLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathBackupFileLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pathBackupFileLoc.ForeColor = System.Drawing.SystemColors.Window;
            this.pathBackupFileLoc.Location = new System.Drawing.Point(116, 67);
            this.pathBackupFileLoc.Name = "pathBackupFileLoc";
            this.pathBackupFileLoc.ReadOnly = true;
            this.pathBackupFileLoc.Size = new System.Drawing.Size(374, 26);
            this.pathBackupFileLoc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "DATA BACKUP AND RESTORE";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.panel6.Controls.Add(this.WebcamProtection_Link);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(30, 279);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(309, 130);
            this.panel6.TabIndex = 13;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // WebcamProtection_Link
            // 
            this.WebcamProtection_Link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.WebcamProtection_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WebcamProtection_Link.LinkColor = System.Drawing.Color.Transparent;
            this.WebcamProtection_Link.Location = new System.Drawing.Point(21, 61);
            this.WebcamProtection_Link.Name = "WebcamProtection_Link";
            this.WebcamProtection_Link.Size = new System.Drawing.Size(259, 40);
            this.WebcamProtection_Link.TabIndex = 7;
            this.WebcamProtection_Link.TabStop = true;
            this.WebcamProtection_Link.Text = "Add, edit or remove applications \r\nin the webcam access list";
            this.WebcamProtection_Link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.WebcamProtection_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebcamProtection_Link_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "WEBCAM PROTECTION";
            // 
            // PrivacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(779, 475);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrivacyForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel WebcamProtection_Link;
        private System.Windows.Forms.TextBox pathBackupFileLoc;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnRestore;
        private FontAwesome.Sharp.IconButton btnBrowse;
        private FontAwesome.Sharp.IconButton btnBackup;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lb_statues;
        private System.Windows.Forms.Label label5;
    }
}