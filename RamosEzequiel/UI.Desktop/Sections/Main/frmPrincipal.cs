using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.Sections.About;
using UI.Desktop.Sections.Login;
using UI.Desktop.Sections.Main;

namespace UI.Desktop.Sections.Main
{
    public partial class frmPrincipal : Form
    {
        private string userName;
        public frmPrincipal(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            statusTxt.Text = userName;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MainService.logOutResponse();
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }
        private void aboutBtn_Click(object sender, EventArgs e)
        {
            Form aboutform = MainService.openAbout(userName);
        }
    }
}
