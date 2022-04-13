using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace NEYTI.Forms.PopUpForm
{
    public partial class FaqForm : Form
    {
        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public FaqForm()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 25, 25));

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 25, 25));

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/theibd56");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/theibd56");
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/theibd56");
        }
    }
}
