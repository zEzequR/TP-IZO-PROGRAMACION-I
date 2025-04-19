using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Sections.PreLogin
{
    public partial class preLogIn : Form
    {
        public preLogIn()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
