using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UI.Escritorio.Sections.Main.User;

namespace UI.Escritorio.Sections.Login.Service
{
    public static class LoginService
    {
        private const int attemps = 3;
        static int trys = 3;
        public static DialogResult AuthResponse(bool? status, string userName)
        {
            if (status == true)
            {
                return MessageBox.Show("Sesión iniciada con éxito, bienvenido " + userName + "!", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (status == null)
            {
                return MessageBox.Show("Por favor, complete los campos requeridos.", "Campos vacíos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                trys--;
                if (trys == 0)
                {
                    DialogResult blocked;
                    blocked = MessageBox.Show("Se han agotado los intentos y el usuario ha sido bloqueado. ¿Desea volver a intentarlo?", "Usuario Bloqueado", MessageBoxButtons.YesNo);
                    if (blocked == DialogResult.Yes)
                    {
                        trys = 3;
                        return MessageBox.Show("Por favor, intente nuevamente.", "Usuario Desbloqueado", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Application.Exit();
                    }
                    return blocked;
                }
                else
                {
                    return MessageBox.Show("Usuario/Contraseña inválido/s. Por favor intente de nuevo. Intentos restantes: " + trys, "Error de autenticación", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        public static Form openMain(bool usertype, string user)
        {
            if (usertype)
            {
                frmMainUser mainUser = new frmMainUser(user);
                mainUser.ShowDialog();
            }
            else
            {
                frmMainAdmin mainAdmin = new frmMainAdmin(user);
                mainAdmin.ShowDialog();
            }
            return null;
        }
    }
}
