using DesktopPim.Views;

namespace DesktopPim.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private async void Autenticar_Click(object sender, EventArgs e)
        {
            //    string usuario = UserBox.Text;
            //    string senha = Passwordbox.Text;

            //    var loginController = new LoginController();
            //    bool isAuthenticated = await loginController.AuthenticateAsync(usuario, senha);

            //    if (isAuthenticated)
            //    {
            //        MessageBox.Show("Login bem sucedido, bem-vindo!", "Autenticado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HomeView homeView = new();
            homeView.Show();
            this.Hide();
        }
    }
}
//            }
//            else
//            {
//                MessageBox.Show("Autenticação falhou. Verifique suas credenciais.", "Erro de Autenticação");
//            }
//        }
//    }
//}