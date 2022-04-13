namespace NEYTI.Forms
{
    partial class ProtectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtectionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalViruses = new System.Windows.Forms.Label();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_ProtectionTips = new FontAwesome.Sharp.IconButton();
            this.btn_QuickScan = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_CustomScan = new FontAwesome.Sharp.IconButton();
            this.btn_DiskScan = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
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
            this.label1.TabIndex = 9;
            this.label1.Text = "LICENSE KEY: THIS PROGRAM IS IN BETA TESTING";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTotalViruses);
            this.panel2.Location = new System.Drawing.Point(317, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 176);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "TOTAL VIRUSES DETECTED";
            // 
            // lblTotalViruses
            // 
            this.lblTotalViruses.AutoSize = true;
            this.lblTotalViruses.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lblTotalViruses.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalViruses.Location = new System.Drawing.Point(57, 45);
            this.lblTotalViruses.Name = "lblTotalViruses";
            this.lblTotalViruses.Size = new System.Drawing.Size(233, 120);
            this.lblTotalViruses.TabIndex = 2;
            this.lblTotalViruses.Text = "000";
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.iconPictureBox4.BackgroundImage = global::NEYTI.Properties.Resources.light_bulb__1_;
            this.iconPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 77;
            this.iconPictureBox4.Location = new System.Drawing.Point(111, 49);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(93, 77);
            this.iconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox4.TabIndex = 13;
            this.iconPictureBox4.TabStop = false;
            this.iconPictureBox4.Click += new System.EventHandler(this.btn_ProtectionTips_Click);
            // 
            // btn_ProtectionTips
            // 
            this.btn_ProtectionTips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_ProtectionTips.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_ProtectionTips.FlatAppearance.BorderSize = 0;
            this.btn_ProtectionTips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_ProtectionTips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_ProtectionTips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProtectionTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_ProtectionTips.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ProtectionTips.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ProtectionTips.IconColor = System.Drawing.Color.Black;
            this.btn_ProtectionTips.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ProtectionTips.Location = new System.Drawing.Point(40, 29);
            this.btn_ProtectionTips.Name = "btn_ProtectionTips";
            this.btn_ProtectionTips.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btn_ProtectionTips.Size = new System.Drawing.Size(244, 176);
            this.btn_ProtectionTips.TabIndex = 12;
            this.btn_ProtectionTips.Text = "TIPS ON HOW TO SECURE YOUR PS";
            this.btn_ProtectionTips.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ProtectionTips.UseVisualStyleBackColor = false;
            this.btn_ProtectionTips.Click += new System.EventHandler(this.btn_ProtectionTips_Click);
            this.btn_ProtectionTips.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_ProtectionTips_Paint);
            // 
            // btn_QuickScan
            // 
            this.btn_QuickScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_QuickScan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_QuickScan.FlatAppearance.BorderSize = 0;
            this.btn_QuickScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_QuickScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_QuickScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuickScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_QuickScan.ForeColor = System.Drawing.Color.Transparent;
            this.btn_QuickScan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_QuickScan.IconColor = System.Drawing.Color.Black;
            this.btn_QuickScan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuickScan.Location = new System.Drawing.Point(40, 234);
            this.btn_QuickScan.Name = "btn_QuickScan";
            this.btn_QuickScan.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btn_QuickScan.Size = new System.Drawing.Size(198, 191);
            this.btn_QuickScan.TabIndex = 1;
            this.btn_QuickScan.Text = "QUICK SCAN";
            this.btn_QuickScan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_QuickScan.UseVisualStyleBackColor = false;
            this.btn_QuickScan.Click += new System.EventHandler(this.btn_QuickScan_Click);
            this.btn_QuickScan.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_QuickScan_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 109;
            this.iconPictureBox1.Location = new System.Drawing.Point(573, 255);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(130, 109);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.btn_DiskScan_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.iconPictureBox3.BackgroundImage = global::NEYTI.Properties.Resources.ICON_FOLDER;
            this.iconPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 109;
            this.iconPictureBox3.Location = new System.Drawing.Point(320, 255);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(130, 109);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox3.TabIndex = 5;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.btn_CustomScan_Click);
            // 
            // btn_CustomScan
            // 
            this.btn_CustomScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_CustomScan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_CustomScan.FlatAppearance.BorderSize = 0;
            this.btn_CustomScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_CustomScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_CustomScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustomScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_CustomScan.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CustomScan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CustomScan.IconColor = System.Drawing.Color.Black;
            this.btn_CustomScan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CustomScan.Location = new System.Drawing.Point(266, 234);
            this.btn_CustomScan.Name = "btn_CustomScan";
            this.btn_CustomScan.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btn_CustomScan.Size = new System.Drawing.Size(237, 191);
            this.btn_CustomScan.TabIndex = 2;
            this.btn_CustomScan.Text = "CUSTOM SCAN";
            this.btn_CustomScan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CustomScan.UseVisualStyleBackColor = false;
            this.btn_CustomScan.Click += new System.EventHandler(this.btn_CustomScan_Click);
            this.btn_CustomScan.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_CustomScan_Paint);
            // 
            // btn_DiskScan
            // 
            this.btn_DiskScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_DiskScan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_DiskScan.FlatAppearance.BorderSize = 0;
            this.btn_DiskScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_DiskScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.btn_DiskScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DiskScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_DiskScan.ForeColor = System.Drawing.Color.Transparent;
            this.btn_DiskScan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_DiskScan.IconColor = System.Drawing.Color.Black;
            this.btn_DiskScan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DiskScan.Location = new System.Drawing.Point(533, 234);
            this.btn_DiskScan.Name = "btn_DiskScan";
            this.btn_DiskScan.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btn_DiskScan.Size = new System.Drawing.Size(222, 191);
            this.btn_DiskScan.TabIndex = 0;
            this.btn_DiskScan.Text = "USB MANAGER";
            this.btn_DiskScan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_DiskScan.UseVisualStyleBackColor = false;
            this.btn_DiskScan.Click += new System.EventHandler(this.btn_DiskScan_Click);
            this.btn_DiskScan.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_DiskScan_Paint);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.iconPictureBox2.BackgroundImage = global::NEYTI.Properties.Resources.ICON_MONITOR;
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 109;
            this.iconPictureBox2.Location = new System.Drawing.Point(74, 255);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(130, 109);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 7;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.btn_QuickScan_Click);
            // 
            // ProtectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(779, 475);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.btn_ProtectionTips);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.btn_QuickScan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.btn_CustomScan);
            this.Controls.Add(this.btn_DiskScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProtectionForm";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_DiskScan;
        private FontAwesome.Sharp.IconButton btn_QuickScan;
        private FontAwesome.Sharp.IconButton btn_CustomScan;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalViruses;
        private FontAwesome.Sharp.IconButton btn_ProtectionTips;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}