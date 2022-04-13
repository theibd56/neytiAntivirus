using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NEYTI.Forms.PopUpForm;

using System.Drawing;
using NEYTI.USBManager;

namespace NEYTI.Forms
{
    public partial class ProtectionForm : Form
    {
        PopUpCustomScan PUCS; PopUpQuickScan PUQS; 
        PopUpProtectionTips PUPT; UsbManagerForm USBM;
        SettingForm SF = new SettingForm();/*PopUpDiskScan PUDS;*/ //set the form to variable


        public bool IsScanning;

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

        public ProtectionForm()
        {
            InitializeComponent();
        }

        private void btn_QuickScan_Click(object sender, EventArgs e)
        {
            PUQS = new PopUpQuickScan();
            PUQS.ShowDialog();
        }

        private void btn_ProtectionTips_Click(object sender, EventArgs e)
        {
            PUPT = new PopUpProtectionTips();
            PUPT.ShowDialog();
        }

        private void btn_CustomScan_Click(object sender, EventArgs e)
        {
            PUCS = new PopUpCustomScan();
            PUCS.ShowDialog();

            var VirusesDetected = (PUCS.lblStatusResult.Text);

            if (VirusesDetected == "Infected! File deleted")
            {
                int numbers = int.Parse(lblTotalViruses.Text) + 1;
                lblTotalViruses.Text = String.Format("{0:d3}", numbers);
            }

        }

        private void btn_CustomScan_Paint(object sender, PaintEventArgs e)
        {
            btn_CustomScan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_CustomScan.Width, btn_CustomScan.Height, 25, 25));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 25, 25));
        }

        private void btn_DiskScan_Paint(object sender, PaintEventArgs e)
        {
            btn_DiskScan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_DiskScan.Width, btn_DiskScan.Height, 25, 25));
        }

        private void btn_QuickScan_Paint(object sender, PaintEventArgs e)
        {
            btn_QuickScan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_QuickScan.Width, btn_QuickScan.Height, 25, 25));
        }

        private void btn_ProtectionTips_Paint(object sender, PaintEventArgs e)
        {
            btn_ProtectionTips.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ProtectionTips.Width, btn_ProtectionTips.Height, 25, 25));
        }

        private void btn_DiskScan_Click(object sender, EventArgs e)
        {
            if (SF.acrUSBM.Checked == true)
            {
                USBM = new UsbManagerForm();
                USBM.ShowDialog();
            }
            else
            {
                MessageBox.Show("NEYTI AV will now open automatically when you start your computer", "NEYTI SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
} 
