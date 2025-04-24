using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Escritorio.Sections.About;

namespace UI.Desktop.Sections.Main.Service
{
    internal class MainService
    {
        public static DialogResult logOutResponse()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }

        public static Form openAbout(string username)
        {
            frmAbout about = new frmAbout(username);
            about.ShowDialog();
            return about;
        }
    }
}
