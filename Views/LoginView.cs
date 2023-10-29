using Azure;
using DesktopPim.Controllers;
using DesktopPim.Model;
using DesktopPim.Views;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Net.Http;
using System.Text.Json;

namespace DesktopPim.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            Autenticar.Click += Autenticar_Click;


            async void Autenticar_Click(object sender, EventArgs e)
            {
                string usuario = UserBox.Text;
                string senha = Passwordbox.Text;

                LoginController loginController = new();
                LoginResponse response = await loginController.Login(usuario, senha);

                if (response != null && response.usuario.ativo == 1 && response.usuario.administrador == 1)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    HomeView homeView = new();
                    homeView.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos. Tente novamente", "Erro ao autenticar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}