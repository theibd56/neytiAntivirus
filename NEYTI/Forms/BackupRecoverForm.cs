using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEYTI.Forms
{
    public partial class BackupRecoverForm : Form
    {
        //DataBase dataBase = new DataBase();
        //SqlConnection conn = new SqlConnection(@"server = .\\localdb; database = NEYTI_DB;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=NEYTI_DB;Integrated Security=True");
        public BackupRecoverForm()
        {
            InitializeComponent();
            btnBackup.Enabled = false;
            btnRecover.Enabled = false;
        }

        private void btnBackupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pathBackupFileLoc.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = conn.Database.ToString();
            if (pathBackupFileLoc.Text == string.Empty)
            {
                lblBackupStatus.Text = "enter backup file location";
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database+"] TO DISK = '"+pathBackupFileLoc.Text+"\\"+"NEYTI"+"-"+DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss")+".bak'";
                conn.Open();
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
                lblBackupStatus.Text = "backup done successfuly";
                conn.Close();
                btnBackup.Enabled = false;
            }
        }

        private void btnRecoverBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files| .bak";
            dlg.Title = "Database recover";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                pathRecoverFileLoc.Text = dlg.FileName;
                btnRecover.Enabled = true;
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            string database = conn.Database.ToString();
            conn.Open();

            try
            {
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, conn);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + pathRecoverFileLoc.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, conn);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, conn);
                cmd3.ExecuteNonQuery();

                lblRecoverStatus.Text = "restore done successfuly";
                conn.Close();
            }
            catch
            {

            }

        }


    }
}
