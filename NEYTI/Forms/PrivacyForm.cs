using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace NEYTI.Forms
{
    public partial class PrivacyForm : Form
    {
        DataBase dataBase = new DataBase();
        string sql = "";

        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public PrivacyForm()
        {
            InitializeComponent();
            btnBackup.Enabled = false;
            btnRestore.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void WebcamProtection_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("ms-settings:privacy-webcam?activationSource=SMC-IA-4558611");
        }

        private void SelectBackupLoc_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            List<string> Lstdata = new List<string>();
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DirectoryInfo dir = new DirectoryInfo(dialog.FileName);
                pathBackupFileLoc.Text = dir.ToString();
                Lstdata.Add(dir.ToString());
                File.WriteAllLines("backupsettings", Lstdata.ToArray());
                btnBackup.Enabled = true;
                btnRestore.Enabled = true;
            }
            else
            {
                btnBackup.Enabled = false;
                btnRestore.Enabled = false;
            }

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            btnBackup.Enabled = false;

            try
            {
                string backupName = "NEYTI_DB" + "_" + DateTime.Now.ToString("ddMMyyyy_HH.mm.ss") + ".bak";
                Server dbServer = new Server(new ServerConnection(@"(LocalDB)\MSSQLLocalDB",
                   @"DESKTOP-FDCN24F\igorb-pc", ""));

                Backup _backup = new Backup()
                {
                    Action = BackupActionType.Database,
                    Database = "NEYTI_DB",
                };
                _backup.Devices.AddDevice(@"E:\Temp", DeviceType.File);
                _backup.Initialize = true;
                _backup.PercentComplete += DB_BackUp_PersentComplete;
                _backup.Complete += DB_Backup_Complete;
                _backup.SqlBackupAsync(dbServer);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnBackup.Enabled = true;
            }
        }

        private void DB_Backup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {

                lb_statues.Invoke(new Action(() => lb_statues.Text = e.Error.Message));
                btnBackup.Invoke(new Action(() => btnBackup.Enabled = true));

            }
        }

        private void DB_BackUp_PersentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();

            });

            lb_statues.Invoke((MethodInvoker)delegate
            {
                lb_statues.Text = $"{e.Percent }%";
            });
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try

            {
                btnRestore.Enabled = false;
                CloseAllConnection();
                string BackupdataBasePath = @"E:\Temp";
                Server dbServer = new Server(new ServerConnection
                    (@"Data Source=(LocalDB)\MSSQLLocalDB"));

                Restore _Restore = new Restore()
                {
                    Database = "NEYTI_DB",
                    Action = RestoreActionType.Database,
                    ReplaceDatabase = true,
                    NoRecovery = false
                };

                _Restore.Devices.AddDevice(BackupdataBasePath, DeviceType.File);

                _Restore.PercentComplete += DB_Restore_PersentComplete;
                _Restore.Complete += DB_Restore_Complete;
                _Restore.SqlRestoreAsync(dbServer);

            }
            catch (Exception ex)
            {
                btnRestore.Enabled = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void DB_Restore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {

                lb_statues.Invoke(new Action(() => lb_statues.Text = e.Error.Message));
                btnRestore.Invoke(new Action(() => btnRestore.Enabled = true));
            }
        }

        private void DB_Restore_PersentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();

            });

            lb_statues.Invoke((MethodInvoker)delegate
            {
                lb_statues.Text = $"{e.Percent }%";
            });
        }

        // function to close any opend database connections
        private void CloseAllConnection()
        {

            string script = File.ReadAllText("closesCons.sql"); //file included in debug folder 

            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);


            SqlConnection _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB");

            _connection.Open();
            foreach (string commandString in commandStrings)
            {
                if (commandString.Trim() != "")
                {
                    using (var command = new SqlCommand(commandString, _connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            _connection.Close();
            _connection.Dispose();
        }

        private void btnBrowse_Paint(object sender, PaintEventArgs e)
        {
            btnBrowse.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBrowse.Width, btnBrowse.Height, 15, 15));
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
