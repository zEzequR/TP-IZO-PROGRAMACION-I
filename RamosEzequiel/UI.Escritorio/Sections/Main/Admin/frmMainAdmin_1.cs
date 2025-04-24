using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Business.Main.Admin;
using UI.Desktop.Sections.Main.Service;
using UI.Desktop.Sections.Main.Admin.Service;
using Datos;

namespace UI.Escritorio
{
    public partial class frmMainAdmin : Form
    {
        private string usernameActive;
        #region DLLimport
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        #endregion
        public frmMainAdmin(string nameOfUser)
        {
            InitializeComponent();
            statusTxt.Text = nameOfUser;
            usernameActive = nameOfUser;
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

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {
            MainAdminWorker service = new MainAdminWorker();
            userDBBindingSource.DataSource = service.RecoverList();
        }

        private void cerrarSesiónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult logoutresponse = MainService.logOutResponse();
            if (logoutresponse == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = MainService.openAbout(usernameActive);
        }

        private void cambiarAspectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en construcción", "Funcionalidad no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addUserOpc_Click(object sender, EventArgs e)
        {
            Form addUser;
            addUser = adminService.openAddUser(usernameActive);
        }

        private void deleteUserOpc_Click(object sender, EventArgs e)
        {
            Form deleteUser;
            deleteUser = adminService.openDeleteUser(usernameActive);
        }

        private void updateUserOpc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en construcción", "Funcionalidad no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void modUserOpc_Click(object sender, EventArgs e)
        {
            Form modifyUser;
            modifyUser = adminService.openModifyUser(usernameActive);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tabla de usuarios actualizada", "Actualización usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            usersTable.DataSource = UserDB.RecoverList();
        }
    }
}
