using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEYTI.Forms.PopUpForm
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string compname = System.Windows.Forms.SystemInformation.ComputerName;
            string username = System.Windows.Forms.SystemInformation.UserName.ToString();
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            textBox1.Text = compname;
            textBox2.Text = userName;
        }

        private void testForm_Load(object sender, EventArgs e)
        {

        }
    }
}
