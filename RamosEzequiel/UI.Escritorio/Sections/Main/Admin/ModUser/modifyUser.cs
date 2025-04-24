using Datos;
using Entidades;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UI.Desktop.Sections.Main.Admin.ModUser
{
    public partial class modifyUser : Form
    {
        private Entidades.User? searchIDResponse;
        #region ImportDll
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        #endregion

        public modifyUser(string usernameActive)
        {
            InitializeComponent();
            statusTxt.Text = usernameActive;
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

        private void SearchImg_Click(object sender, EventArgs e)
        {
            int idResult = adminService.IDValidationResponse(searchByID.Text);


            System.Diagnostics.Debug.WriteLine(idResult + " ID");
            
            searchIDResponse = UserDB.GetUsers(idResult);

            System.Diagnostics.Debug.WriteLine(searchIDResponse + " searchIDResponse");

            if (searchIDResponse != null)
            {
                MessageBox.Show("Usuario encontrado correctamente", "Usuario encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adminService.fieldsProvider(searchIDResponse, modUserInp, modUserPasswrdInp, modUserNameInp, modUserLastnameInp, newUserTypeComBox, modUserEmailInp);
                System.Diagnostics.Debug.WriteLine("------------usuario encontrado en la DB-----------------");
                System.Diagnostics.Debug.WriteLine(searchIDResponse.id + " ID");
                System.Diagnostics.Debug.WriteLine(searchIDResponse.username + " nombre de usuario");
                System.Diagnostics.Debug.WriteLine(searchIDResponse.password + " contraseña");
                System.Diagnostics.Debug.WriteLine(searchIDResponse.nombre + " nombre");
                System.Diagnostics.Debug.WriteLine(searchIDResponse.apellido + " apellido");
                System.Diagnostics.Debug.WriteLine(searchIDResponse.email + " email");
                System.Diagnostics.Debug.WriteLine(searchIDResponse.type + " tipo");
                System.Diagnostics.Debug.WriteLine(searchIDResponse.status + " estado");
                System.Diagnostics.Debug.WriteLine(searchIDResponse.lastTime + " fecha de registro");
            }
            else
            {
                MessageBox.Show("No se encontró el usuario con ID: " + idResult, "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine("No se encontró el usuario con ID: " + idResult);
            }
        }

        private void userRegistrerBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(searchIDResponse);
            bool modifystatus = UserDB.modifyUser(searchIDResponse, modUserInp.Text, modUserPasswrdInp.Text, modUserNameInp.Text, modUserLastnameInp.Text, modUserEmailInp.Text, adminService.comBoxHandler(newUserTypeComBox));
            adminService.modifyMessages(modifystatus);
            this.Close();
        }
    }
}