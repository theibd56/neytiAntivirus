using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.Win32;
using NEYTI.Forms;

namespace NEYTI.Forms
{
    public partial class SettingForm : Form
    {
        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        //fields
        private IconButton currentBtn;
        private Panel bottomBorderBtn;
        private Form currentChildForm;

        public SettingForm()
        {
            InitializeComponent();
            bottomBorderBtn = new Panel();
            bottomBorderBtn.Size = new Size(7, 51);
        }

        //struct
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(124, 63, 183);
        }

        //methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = Color.Transparent;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;

                bottomBorderBtn.BackColor = color;
                bottomBorderBtn.Location = new Point(0, currentBtn.Location.X);
                bottomBorderBtn.Visible = true;
                bottomBorderBtn.BringToFront();
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(45, 15, 75);
                currentBtn.ForeColor = Color.FromArgb(195, 187, 204);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
        }

        private void AutoRunCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoRunCheck.Checked)
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.SetValue("NEYTI AV", Application.ExecutablePath.ToString());
                MessageBox.Show("NEYTI AV will now open automatically when you start your computer", "NEYTI SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.DeleteValue("NEYTI AV", false);
                MessageBox.Show("NEYTI AV will no longer open automatically on computer startup", "NEYTI SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RemoveMaliciousUtilites_CheckedChanged(object sender, EventArgs e)
        {
            if (MaliciousUtilitesCheckbox.Checked)
            {
                MessageBox.Show("Once a malicious utility is detected, it will be automatically removed.", "NEYTI SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("After detecting a malicious utility, you will need to carry out the removal procedure yourself.", "NEYTI SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 25, 25));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 25, 25));
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 25, 25));
        }

        private void acrUSBM_CheckedChanged_1(object sender, EventArgs e)
        {
            if (acrUSBM.Checked)
            {
                MessageBox.Show("Congratulations! You have activated additional functions, NEYTI USBManager is now available to you!.", "NEYTI SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("You have deactivated advanced features, NEYTI USBManager is no longer available to you!", "NEYTI SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TaskbarTrayMode_CheckedChanged(object sender, EventArgs e)
        {
            if (TaskbarTrayMode.Checked)
            {
                MessageBox.Show("Now the application will minimize to the tray.", "NEYTI SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Now the application will not minimize to the tray.", "NEYTI SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WebcamProtection_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("ms-settings:privacy-webcam?activationSource=SMC-IA-4558611");
        }
    }
}
