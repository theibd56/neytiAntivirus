
namespace NEYTI.Forms
{
    partial class BackupRecoverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupRecoverForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathBackupFileLoc = new System.Windows.Forms.TextBox();
            this.pathRecoverFileLoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBackupStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecoverStatus = new System.Windows.Forms.Label();
            this.btnRecover = new FontAwesome.Sharp.IconButton();
            this.btnRecoverBrowse = new FontAwesome.Sharp.IconButton();
            this.btnBackup = new FontAwesome.Sharp.IconButton();
            this.btnBackupBrowse = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblBackupStatus);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.btnBackupBrowse);
            this.groupBox1.Controls.Add(this.pathBackupFileLoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(58, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEYTI Backup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblRecoverStatus);
            this.groupBox2.Controls.Add(this.btnRecover);
            this.groupBox2.Controls.Add(this.btnRecoverBrowse);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pathRecoverFileLoc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(58, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NEYTI Recover";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(505, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "LICENSE KEY: THIS PROGRAM IS IN BETA TESTING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location";
            // 
            // pathBackupFileLoc
            // 
            this.pathBackupFileLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.pathBackupFileLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathBackupFileLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pathBackupFileLoc.ForeColor = System.Drawing.SystemColors.Window;
            this.pathBackupFileLoc.Location = new System.Drawing.Point(108, 48);
            this.pathBackupFileLoc.Name = "pathBackupFileLoc";
            this.pathBackupFileLoc.ReadOnly = true;
            this.pathBackupFileLoc.Size = new System.Drawing.Size(374, 26);
            this.pathBackupFileLoc.TabIndex = 3;
            // 
            // pathRecoverFileLoc
            // 
            this.pathRecoverFileLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.pathRecoverFileLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathRecoverFileLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pathRecoverFileLoc.ForeColor = System.Drawing.SystemColors.Window;
            this.pathRecoverFileLoc.Location = new System.Drawing.Point(108, 46);
            this.pathRecoverFileLoc.Name = "pathRecoverFileLoc";
            this.pathRecoverFileLoc.ReadOnly = true;
            this.pathRecoverFileLoc.Size = new System.Drawing.Size(374, 26);
            this.pathRecoverFileLoc.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Backup status:";
            // 
            // lblBackupStatus
            // 
            this.lblBackupStatus.AutoSize = true;
            this.lblBackupStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblBackupStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBackupStatus.Location = new System.Drawing.Point(160, 100);
            this.lblBackupStatus.Name = "lblBackupStatus";
            this.lblBackupStatus.Size = new System.Drawing.Size(49, 25);
            this.lblBackupStatus.TabIndex = 33;
            this.lblBackupStatus.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Recover status:";
            // 
            // lblRecoverStatus
            // 
            this.lblRecoverStatus.AutoSize = true;
            this.lblRecoverStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblRecoverStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRecoverStatus.Location = new System.Drawing.Point(169, 98);
            this.lblRecoverStatus.Name = "lblRecoverStatus";
            this.lblRecoverStatus.Size = new System.Drawing.Size(49, 25);
            this.lblRecoverStatus.TabIndex = 33;
            this.lblRecoverStatus.Text = "N/A";
            // 
            // btnRecover
            // 
            this.btnRecover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRecover.FlatAppearance.BorderSize = 0;
            this.btnRecover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRecover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnRecover.ForeColor = System.Drawing.Color.White;
            this.btnRecover.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRecover.IconColor = System.Drawing.Color.White;
            this.btnRecover.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRecover.IconSize = 31;
            this.btnRecover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecover.Location = new System.Drawing.Point(495, 84);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRecover.Size = new System.Drawing.Size(126, 39);
            this.btnRecover.TabIndex = 33;
            this.btnRecover.Text = "RECOVER";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnRecoverBrowse
            // 
            this.btnRecoverBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRecoverBrowse.FlatAppearance.BorderSize = 0;
            this.btnRecoverBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRecoverBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRecoverBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnRecoverBrowse.ForeColor = System.Drawing.Color.White;
            this.btnRecoverBrowse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRecoverBrowse.IconColor = System.Drawing.Color.White;
            this.btnRecoverBrowse.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRecoverBrowse.IconSize = 31;
            this.btnRecoverBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverBrowse.Location = new System.Drawing.Point(499, 39);
            this.btnRecoverBrowse.Name = "btnRecoverBrowse";
            this.btnRecoverBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRecoverBrowse.Size = new System.Drawing.Size(118, 39);
            this.btnRecoverBrowse.TabIndex = 32;
            this.btnRecoverBrowse.Text = "BROWSE";
            this.btnRecoverBrowse.UseVisualStyleBackColor = true;
            this.btnRecoverBrowse.Click += new System.EventHandler(this.btnRecoverBrowse_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
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
            this.btnBackup.Location = new System.Drawing.Point(499, 86);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBackup.Size = new System.Drawing.Size(118, 39);
            this.btnBackup.TabIndex = 29;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBackupBrowse
            // 
            this.btnBackupBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnBackupBrowse.FlatAppearance.BorderSize = 0;
            this.btnBackupBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnBackupBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnBackupBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackupBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBackupBrowse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBackupBrowse.IconColor = System.Drawing.Color.White;
            this.btnBackupBrowse.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBackupBrowse.IconSize = 31;
            this.btnBackupBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackupBrowse.Location = new System.Drawing.Point(499, 41);
            this.btnBackupBrowse.Name = "btnBackupBrowse";
            this.btnBackupBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBackupBrowse.Size = new System.Drawing.Size(118, 39);
            this.btnBackupBrowse.TabIndex = 28;
            this.btnBackupBrowse.Text = "BROWSE";
            this.btnBackupBrowse.UseVisualStyleBackColor = true;
            this.btnBackupBrowse.Click += new System.EventHandler(this.btnBackupBrowse_Click);
            // 
            // BackupRecoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(779, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupRecoverForm";
            this.Text = "BackupRecoverForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathBackupFileLoc;
        private FontAwesome.Sharp.IconButton btnBackupBrowse;
        private FontAwesome.Sharp.IconButton btnBackup;
        private FontAwesome.Sharp.IconButton btnRecover;
        private FontAwesome.Sharp.IconButton btnRecoverBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pathRecoverFileLoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBackupStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecoverStatus;
    }
}