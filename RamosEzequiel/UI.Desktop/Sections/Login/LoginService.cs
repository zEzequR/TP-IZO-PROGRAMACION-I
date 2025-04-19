using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.Sections.Login;

namespace UI.Desktop.Sections.Login
{
    internal class LoginService
    {
        User user = new User();
        private const int attempts = 3;
        static int trys = 3;
        public static DialogResult AuthData(string userInp, string passwordInp)
        {
            if (userInp == User.username && passwordInp == User.password && (!string.IsNullOrEmpty(userInp) && !string.IsNullOrEmpty(passwordInp)))
            {
                return MessageBox.Show("Sesión iniciada con éxito, bienvenido " + userInp + "!", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(userInp) || string.IsNullOrEmpty(passwordInp))
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
                        trys = attempts;
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
    }
}
