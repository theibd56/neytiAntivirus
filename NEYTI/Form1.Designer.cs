namespace NEYTI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Contact = new FontAwesome.Sharp.IconButton();
            this.btn_FAQ = new FontAwesome.Sharp.IconButton();
            this.btn_Setting = new FontAwesome.Sharp.IconButton();
            this.btn_Privacy = new FontAwesome.Sharp.IconButton();
            this.btn_Protection = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.panelTitleBar.Controls.Add(this.btn_Minimize);
            this.panelTitleBar.Controls.Add(this.btn_Close);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(206, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(778, 51);
            this.panelTitleBar.TabIndex = 3;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_Minimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(60)))), ((int)(((byte)(144)))));
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 32;
            this.btn_Minimize.Location = new System.Drawing.Point(676, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(51, 51);
            this.btn_Minimize.TabIndex = 1;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_Close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(60)))), ((int)(((byte)(144)))));
            this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Close.IconSize = 32;
            this.btn_Close.Location = new System.Drawing.Point(727, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(51, 51);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.panelMenu.Controls.Add(this.btn_Contact);
            this.panelMenu.Controls.Add(this.btn_FAQ);
            this.panelMenu.Controls.Add(this.btn_Setting);
            this.panelMenu.Controls.Add(this.btn_Privacy);
            this.panelMenu.Controls.Add(this.btn_Protection);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(206, 526);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_Contact
            // 
            this.btn_Contact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Contact.FlatAppearance.BorderSize = 0;
            this.btn_Contact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Contact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.btn_Contact.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Contact.IconColor = System.Drawing.Color.Black;
            this.btn_Contact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Contact.Location = new System.Drawing.Point(0, 401);
            this.btn_Contact.Name = "btn_Contact";
            this.btn_Contact.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Contact.Size = new System.Drawing.Size(205, 51);
            this.btn_Contact.TabIndex = 5;
            this.btn_Contact.Text = "Contact us";
            this.btn_Contact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Contact.UseVisualStyleBackColor = true;
            this.btn_Contact.Click += new System.EventHandler(this.btn_Contact_Click);
            // 
            // btn_FAQ
            // 
            this.btn_FAQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_FAQ.FlatAppearance.BorderSize = 0;
            this.btn_FAQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_FAQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_FAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btn_FAQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.btn_FAQ.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_FAQ.IconColor = System.Drawing.Color.Black;
            this.btn_FAQ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_FAQ.Location = new System.Drawing.Point(0, 452);
            this.btn_FAQ.Name = "btn_FAQ";
            this.btn_FAQ.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_FAQ.Size = new System.Drawing.Size(205, 51);
            this.btn_FAQ.TabIndex = 4;
            this.btn_FAQ.Text = "FAQ";
            this.btn_FAQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FAQ.UseVisualStyleBackColor = true;
            this.btn_FAQ.Click += new System.EventHandler(this.btn_FAQ_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.btn_Setting.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Setting.IconColor = System.Drawing.Color.Black;
            this.btn_Setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Setting.Location = new System.Drawing.Point(0, 228);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Setting.Size = new System.Drawing.Size(205, 51);
            this.btn_Setting.TabIndex = 3;
            this.btn_Setting.Text = "Setting";
            this.btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Privacy
            // 
            this.btn_Privacy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Privacy.FlatAppearance.BorderSize = 0;
            this.btn_Privacy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Privacy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Privacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Privacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Privacy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.btn_Privacy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Privacy.IconColor = System.Drawing.Color.Black;
            this.btn_Privacy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Privacy.Location = new System.Drawing.Point(0, 177);
            this.btn_Privacy.Name = "btn_Privacy";
            this.btn_Privacy.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Privacy.Size = new System.Drawing.Size(205, 51);
            this.btn_Privacy.TabIndex = 2;
            this.btn_Privacy.Text = "Privacy";
            this.btn_Privacy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Privacy.UseVisualStyleBackColor = true;
            this.btn_Privacy.Click += new System.EventHandler(this.btn_Privacy_Click);
            // 
            // btn_Protection
            // 
            this.btn_Protection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Protection.FlatAppearance.BorderSize = 0;
            this.btn_Protection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Protection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Protection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Protection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Protection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.btn_Protection.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Protection.IconColor = System.Drawing.Color.Black;
            this.btn_Protection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Protection.Location = new System.Drawing.Point(0, 126);
            this.btn_Protection.Name = "btn_Protection";
            this.btn_Protection.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Protection.Size = new System.Drawing.Size(205, 51);
            this.btn_Protection.TabIndex = 1;
            this.btn_Protection.Text = "Protection";
            this.btn_Protection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Protection.UseVisualStyleBackColor = true;
            this.btn_Protection.Click += new System.EventHandler(this.btn_Protection_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 100);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Home.Image = global::NEYTI.Properties.Resources.Логотип;
            this.btn_Home.Location = new System.Drawing.Point(3, 3);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(197, 94);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(206, 51);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(778, 475);
            this.panelDesktop.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NEYTI Antivirus";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_Home;
        private FontAwesome.Sharp.IconButton btn_Contact;
        private FontAwesome.Sharp.IconButton btn_FAQ;
        private FontAwesome.Sharp.IconButton btn_Setting;
        private FontAwesome.Sharp.IconButton btn_Privacy;
        private FontAwesome.Sharp.IconButton btn_Protection;
        private FontAwesome.Sharp.IconButton btn_Close;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

