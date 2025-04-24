using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Escritorio.Sections.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using UI.Desktop.Sections.PreLogin.Service;

namespace UI.Escritorio.Sections.Main
{
    public partial class frmPreLogin : Form
    {
        #region DLLimport
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        #endregion

        public frmPreLogin()
        {
            InitializeComponent();
        }

        #region WindowFuncionalitys
        private void winBarClseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void winBarMinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void winStatusBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                winStatusBtn.Image = Image.FromFile("C:\\Users\\EZEQUIELEITOR\\Downloads\\IZO.P1.TP3.RamosEzequiel\\RamosEzequiel\\UI.Escritorio\\Icons\\maximizar.png");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                winStatusBtn.Image = Image.FromFile("C:\\Users\\EZEQUIELEITOR\\Downloads\\IZO.P1.TP3.RamosEzequiel\\RamosEzequiel\\UI.Escritorio\\Icons\\cambiartamventana.png");
            }
        }

        private void tableContWinBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
        #endregion

        private void loginOpc_Click(object sender, EventArgs e)
        {
            Form login = PreLoginService.openLogin();
        }

        private void logoutOpc_Click(object sender, EventArgs e)
        {
            Form login = PreLoginService.openLogin();
        }

        private void cambiarAspectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en construcción", "Funcionalidad no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
