using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Desktop.Sections.About;
using UI.Desktop.Sections.Login;


namespace UI.Desktop.Sections.Main
{
    internal class MainService
    {
        public static Form openAbout(string userName)
        {
            Form about = new frmAbout(userName);
            about.ShowDialog();
            return about;
        }

        public static DialogResult logOutResponse()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }
    }
}
