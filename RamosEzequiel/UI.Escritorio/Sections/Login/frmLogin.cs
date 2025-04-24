using Datos;
using Negocio.Login;
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
using UI.Escritorio.Sections.Login.Service;
using UI.Escritorio.Sections.Main.User;

namespace UI.Escritorio.Sections.Login
{
    public partial class frmLogin : Form
    {
        #region ImportDll
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        #endregion
        public frmLogin()
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


        private void sumbitBtn_Click(object sender, EventArgs e)
        {
            string user;
            string password;

            user = userInp.Text;
            password = passwrdInp.Text;

            UserDB database = new UserDB();

            bool? auth = LoginWorker.AuthData(user, password);

            DialogResult response = LoginService.AuthResponse(auth, user);


            if (response == DialogResult.OK)
            {
                bool winresponse = LoginWorker.isUserOrAdmin(user);

                Form main = LoginService.openMain(winresponse, user);

            }
            else if (response == DialogResult.Retry)
            {
                userInp.Clear();
                passwrdInp.Clear();
                userInp.Focus();
            }
            else if (response == DialogResult.Yes)
            {
                userInp.Clear();
                passwrdInp.Clear();
                userInp.Focus();
            }

            //System.Diagnostics.Debug.WriteLine("Auth: " + auth);
            //System.Diagnostics.Debug.WriteLine(response);
        }
    }
}
