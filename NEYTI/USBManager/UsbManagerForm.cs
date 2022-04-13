using iTuner;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace NEYTI.USBManager
{
    public partial class UsbManagerForm : Form
    {
        private static readonly string CR = Environment.NewLine;
        private UsbManager manager;

        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        public UsbManagerForm()
        {
            InitializeComponent();

            manager = new UsbManager();
            UsbDiskCollection disks = manager.GetAvailableDisks();

            textBox1.AppendText(CR);
            textBox1.AppendText("NEYTI found the following USB drives available" + CR);

            foreach (UsbDisk disk in disks)
            {
                textBox1.AppendText(disk.ToString() + CR);
            }

            textBox1.AppendText(CR);

            manager.StateChanged += new UsbStateChangedEventHandler(DoStateChanged);

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void DoStateChanged(UsbStateChangedEventArgs e)
        {
            textBox1.AppendText(e.State + " " + e.Disk.ToString() + CR);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


