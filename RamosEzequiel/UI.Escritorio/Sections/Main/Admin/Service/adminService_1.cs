using Entidades;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Desktop.Sections.Main.Admin.AddUser;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using UI.Desktop.Sections.Main.Admin.DeleteUser;
using UI.Desktop.Sections.Main.Admin.ModUser;

namespace UI.Desktop.Sections.Main.Admin.Service
{
    internal class adminService
    {

        public static Form openAddUser(string usernameactive)
        {
            addUser addUser = new addUser(usernameactive);
            addUser.ShowDialog();
            return addUser;
        }

        public static Form openDeleteUser(string usernameactive)
        {
            deleteUser deleteUser = new deleteUser(usernameactive);
            deleteUser.ShowDialog();
            return deleteUser;
        }

        public static Form openModifyUser(string usernameactive)
        {
            modifyUser modifyUser = new modifyUser(usernameactive);
            modifyUser.ShowDialog();
            return modifyUser;
        }

        public static DialogResult closewarn(Form activeForm)
        {
            if (activeForm is addUser)
            {
                return MessageBox.Show("¿Está seguro que quiere cerrar esta pestaña? Los datos del usuario no se guardarán", "Cerrar agregar usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else if (activeForm is deleteUser)
            {
                return MessageBox.Show("¿Está seguro que quiere cerrar esta pestaña? Los datos del usuario no se borrarán", "Cerrar borrar usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else if (activeForm is modifyUser)
            {
                return MessageBox.Show("¿Está seguro que quiere cerrar esta pestaña? Los datos del usuario no se modificarán", "Cerrar modificar usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                return DialogResult.No;
            }

        }

        public static User addUser(int id, string username, string password, string nombre, string apellido, string email, int type, bool status, DateTime fechaRegistro)
        {
            System.Diagnostics.Debug.WriteLine("ENTRO ACA");
            return UserDB.AddUser(id, username, password, nombre, apellido, email, type, status, fechaRegistro);
        }

        public static int comBoxHandler(ComboBox comboxType)
        {
            return comboxType.SelectedIndex;
        }

        public static DialogResult regResponse(string username, string password, string name, string lastname, int type)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastname) || type == -1)
            {
                return MessageBox.Show("Por favor, complete todos los campos", "Datos no completados", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                return MessageBox.Show("Usuario registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static int IDValidationResponse(string IDinput)
        {
            int idParsed;
            if (string.IsNullOrEmpty(IDinput))
            {
                MessageBox.Show("Por favor, complete el campo ID", "Datos no completados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -2;
            }
            else
            {
                if (int.TryParse(IDinput, out idParsed))
                {
                    MessageBox.Show("Buscando usuario con ID: " +idParsed, "Buscando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return idParsed;
                }
                else
                {
                    MessageBox.Show("El ID debe ser un número entero, no un caracter", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }

        public static void fieldsProvider(User searchIDResponse, TextBox modUserInp, TextBox modUserPasswrdInp, TextBox modUserNameInp, TextBox modUserLastnameInp, ComboBox newUserTypeComBox , TextBox modUserEmailInp)
        {
            modUserInp.Text = searchIDResponse.username;
            modUserPasswrdInp.Text = searchIDResponse.password;
            modUserNameInp.Text = searchIDResponse.nombre;
            modUserLastnameInp.Text = searchIDResponse.apellido;
            modUserEmailInp.Text = searchIDResponse.email;
            newUserTypeComBox.SelectedIndex = searchIDResponse.type;
        }

        public static void modifyMessages(bool modifyResponse)
        {
            if (modifyResponse == true)
            {
                MessageBox.Show("Usuario modificado correctamente", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha modificado ningún campo o el usuario es nulo", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void deleteUserMessages(bool deleteResponse)
        {
            if (deleteResponse)
            {
                MessageBox.Show("Usuario eliminado correctamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar ningún usuario. -Error desconocido", "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
