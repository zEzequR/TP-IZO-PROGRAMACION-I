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
using UI.Desktop.Sections.Main.Admin.Service;
using Entidades;
using Datos;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Desktop.Sections.Main.Admin.AddUser
{
    public partial class addUser : Form
    {
        #region ImportDll
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        #endregion
        public addUser(string usernameactive)
        {
            InitializeComponent();
            statusTxt.Text = usernameactive;
        }

        #region WindowFuncionalitys

        private void tableContWinBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
        #endregion

        private void winBarClseBtn_Click(object sender, EventArgs e)
        {
            DialogResult warning = adminService.closewarn(this);
            if (warning == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void userRegistrerBtn_Click(object sender, EventArgs e)
        {
            int id = UserDB.UserIDHandler();
            string username = newUserInp.Text;
            string password = newUserPasswrdInp.Text;
            string name = newUserNameInp.Text;
            string lastname = newUserLastnameInp.Text;
            string email = newUserEmailInp.Text;
            int type = adminService.comBoxHandler(newUserTypeComBox);
            bool role = true;
            DateTime lastTime = DateTime.Now;

            DialogResult response = adminService.regResponse(username, password, name, lastname, type);
            if (response == DialogResult.OK)
            {
                User aver;
                List<Entidades.User> todoslosusuarios;
                aver = adminService.addUser(id, username, password, name, lastname, email, type, role, lastTime);
                System.Diagnostics.Debug.WriteLine("AVER");
                System.Diagnostics.Debug.WriteLine("------------USUARIO CARGADO------------");
                System.Diagnostics.Debug.WriteLine(aver.id + " ID");
                System.Diagnostics.Debug.WriteLine(aver.username + " nombre de usuario");
                System.Diagnostics.Debug.WriteLine(aver.password + " contraseña");
                System.Diagnostics.Debug.WriteLine(aver.nombre + " nombre");
                System.Diagnostics.Debug.WriteLine(aver.apellido + " apellido");
                System.Diagnostics.Debug.WriteLine(aver.email + " email");
                System.Diagnostics.Debug.WriteLine(aver.type + " tipo");
                System.Diagnostics.Debug.WriteLine(aver.status + " estado");
                System.Diagnostics.Debug.WriteLine(aver.lastTime + " fecha de registro");

                todoslosusuarios = UserDB.RecoverList();
                System.Diagnostics.Debug.WriteLine(".....TODOS LOS USUARIOS.....");
                foreach (var user in todoslosusuarios)
                {
                    System.Diagnostics.Debug.WriteLine(user.id + " ID");
                    System.Diagnostics.Debug.WriteLine(user.username + " nombre de usuario");
                    System.Diagnostics.Debug.WriteLine(user.password + " contraseña");
                    System.Diagnostics.Debug.WriteLine(user.nombre + " nombre");
                    System.Diagnostics.Debug.WriteLine(user.apellido + " apellido");
                    System.Diagnostics.Debug.WriteLine(user.email + " email");
                    System.Diagnostics.Debug.WriteLine(user.type + " tipo");
                    System.Diagnostics.Debug.WriteLine(user.status + " estado");
                    System.Diagnostics.Debug.WriteLine(user.lastTime + " fecha de registro");
                }

                this.Close();
            }
        }
    }
}
