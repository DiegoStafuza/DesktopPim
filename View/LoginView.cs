using DesktopPim.Controller;
using DesktopPim.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Autenticar_Click(object sender, EventArgs e)
        {
            string usuario = UserBox.Text;
            string senha = Passwordbox.Text;

            UserRepo userRepository = new UserRepo("Data Source=LENOVODIEGO\\SQLEXPRESS;Initial Catalog=PIM;User ID=di;Password=1234;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;");
            LoginController loginController = new LoginController(userRepository);

            if (loginController.AutenticaUsu(usuario, senha))
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                HomeView homeView = new HomeView();
                homeView.Show();
            }
            else
            {
                MessageBox.Show("Credenciais incorretas. Tente novamente.", "Erro ao autenticar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}