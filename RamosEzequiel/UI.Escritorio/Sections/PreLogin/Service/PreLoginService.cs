using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Escritorio.Sections.Login;

namespace UI.Desktop.Sections.PreLogin.Service
{
    public static class PreLoginService
    {
        public static Form openLogin()
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            return login;
        }
    }
}
