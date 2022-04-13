using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NEYTI.Forms.SubForm
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("NEYTI AV", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("NEYTI AV");
            }


            // open the desired branch in the registry
            // @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\"
            Microsoft.Win32.RegistryKey Key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);

            //add the first parameter -the name of the key, the second parameter -the path to the executable file of our program.
            Key.SetValue("DoLinqToSql", "D:\\DoLinqToSql.exe");
            Key.Close();
        }

        private void AutoRunCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoRunCheck.Checked)
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.SetValue("NEYTI AV", Application.ExecutablePath.ToString());
                MessageBox.Show("NEYTI AV will now open automatically when you start your computer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.DeleteValue("NEYTI AV", false);
                MessageBox.Show("NEYTI AV will no longer open automatically on computer startup", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
