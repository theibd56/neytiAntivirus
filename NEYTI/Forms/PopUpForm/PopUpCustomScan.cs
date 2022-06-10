using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace NEYTI.Forms.PopUpForm
{
    public partial class PopUpCustomScan : Form
    {

        DataBase dataBase = new DataBase();
        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        public PopUpCustomScan()
        {
            InitializeComponent();
            btnScan.Enabled = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        public string GetMD5FromFile(string filenPath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filenPath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            //close_form(PopUpCustomScan.ActiveForm);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbMD5.Text = GetMD5FromFile(ofd.FileName);
                tbFilePath.Text = ofd.FileName;
            }

            btnScan.Enabled = true;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {

            var hashItem = tbMD5.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select * from MD5DB where hash = '{hashItem}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            btnScan.Enabled = false;


            if (table.Rows.Count == 1)
            {
                File.Delete(tbFilePath.Text);
                lblStatusResult.Text = "Infected! File deleted";            }
            else
            {
                lblStatusResult.Text = "Clean!";
            }

            //var md5signatures = File.ReadAllLines("MD5DB.md");
            ////var md5signatures = $"use NEYTI_DB go select * from MD5DB";

            //if (md5signatures.Contains(tbMD5.Text))
            //{
            //    File.Delete(tbFilePath.Text);
            //    lblStatusResult.Text = "Infected! File deleted";
            //}
            //else
            //{
            //    lblStatusResult.Text = "Clean!";
            //}
            //btnScan.Enabled = false;
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

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
