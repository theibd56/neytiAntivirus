using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using NEYTI.Forms;
using MySql.Data.MySqlClient;

namespace NEYTI
{
    public partial class Form1 : Form
    {

        MySqlConnection connection = new MySqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=NEYTI_DB;Integrated Security=True");
        MySqlCommand command;
        MySqlDataReader mdr;



        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new ProtectionForm());
        }

        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        SettingForm SF = new SettingForm();

        //constructor
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 51);
            panelMenu.Controls.Add(leftBorderBtn);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(56, 28, 85);
                currentBtn.ForeColor = Color.FromArgb(195, 187, 204);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btn_Protection_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            OpenChildForm(new ProtectionForm());
        }

        private void btn_Privacy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            OpenChildForm(new PrivacyForm());
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            OpenChildForm(new SettingForm());
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            OpenChildForm(new ContactUsForm());
        }

        private void btn_FAQ_Click(object sender, EventArgs e)
        {   
            Process.Start("http://www.google.ru/");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon.Dispose();
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            if (SF.TaskbarTrayMode.Checked == true)
            {
                Hide();
                notifyIcon1.BalloonTipTitle = "NEYTI Antivirus был спрятан";
                notifyIcon1.BalloonTipText = "Обратите внимание что NEYTI Antivirus был спрятан в трей и продолжит свою работу.";
                notifyIcon1.ShowBalloonTip(4000); // Параметром указываем количество миллисекунд, которое будет показываться подсказка
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Icon.Dispose();
                notifyIcon1.Dispose();
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
