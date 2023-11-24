using DesktopPim.Controllers;
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
using DesktopPim.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopPim.Views
{
    public partial class AdicionaUsu : Form
    {
        public AdicionaUsu()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            NomeCompletoTx.Clear();
            EmailTx.Clear();
            SenhaTx.Clear();
            CheckAtivo.Checked = false;
            CheckAdm.Checked = false;
            ConfirmSenTx.Clear();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {
                if (SenhaTx.Text != ConfirmSenTx.Text)
                {
                    MessageBox.Show("As senhas não coincidem", "Verifique!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var cadastroController = new CadastroUsuarioController();
                    CadastroViewModel cadastroViewModel = new CadastroViewModel
                    {
                        Nome = NomeCompletoTx.Text,
                        Email = EmailTx.Text,
                        Senha = SenhaTx.Text,
                        Tipo = (short)(CheckAdm.Checked ? 1 : 0),
                        Ativo = (short)(CheckAtivo.Checked ? 1 : 0)
                    };

                    await cadastroController.Cadastro(cadastroViewModel);
                    this.LimparCampos();
                    this.Close();
                    UsuariosView usuariosView = new UsuariosView();
                    UsuariosController usuariosController = new UsuariosController();
                    usuariosController.LoadDataAPI(usuariosView);

                }
            }
            else
            {
                MessageBox.Show("Um dos campos obrigatórios não está preenchido.", "Verifique!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CamposPreenchidos() =>
            !string.IsNullOrWhiteSpace(NomeCompletoTx.Text)
                && !string.IsNullOrWhiteSpace(EmailTx.Text)
                && !string.IsNullOrWhiteSpace(SenhaTx.Text)
                && !string.IsNullOrWhiteSpace(ConfirmSenTx.Text);
    }
}

