using UI.Desktop.Sections.Main;
using UI.Desktop.Sections.Login;

namespace UI.Desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnSumbit_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = LoginService.AuthData(userInp.Text, passwrdInp.Text);
            if (response == DialogResult.OK)
            {
                frmPrincipal main = new frmPrincipal(userInp.Text);
                main.ShowDialog();
                this.Close();
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
            else if (response == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}
