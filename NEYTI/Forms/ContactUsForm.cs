using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NEYTI.Forms
{
    public partial class ContactUsForm : Form
    {
        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public ContactUsForm()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 25, 25));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 25, 25));
        }

        private void PhoneForPartnerships_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("tel:+79642133222");
        }

        private void AddresForPartnerships_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com.br/maps/place/%D0%A1%D0%BE%D0%B2%D0%B5%D1%82%D1%81%D0%BA%D0%B0%D1%8F+%D1%83%D0%BB.,+%D0%98%D1%80%D0%BA%D1%83%D1%82%D1%81%D0%BA,+%D0%98%D1%80%D0%BA%D1%83%D1%82%D1%81%D0%BA%D0%B0%D1%8F+%D0%BE%D0%B1%D0%BB.,+664009/@52.2798654,104.3325242,17z/data=!3m1!4b1!4m5!3m4!1s0x5da83b435893a6d7:0x58c99f983ecf482d!8m2!3d52.2798621!4d104.3347129");
        }

        private void EmailForPartnerships_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto: partner@neyti.ru");
        }

        private void PhoneForPress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("tel:+79642133222");
        }

        private void EmailForPress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto: press@neyti.ru");
        }

        private void PhoneForSupportRU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("tel:88002000001");
        }

        private void PhoneForSupportCIS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("tel:81080020000000");
        }

        private void EmailForSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto: support@neyti.ru");
        }
    }
}
