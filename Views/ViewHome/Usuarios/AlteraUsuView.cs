using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopPim.Controllers;

namespace DesktopPim.Views.ViewHome.Usuarios
{
    public partial class AlteraUsuView : Form
    {
        private readonly int idUsuario;

        Controllers.UsuariosController usuariosController = new();

        public AlteraUsuView(int id)
        {
            InitializeComponent();
            idUsuario = id;
            PreencherDetalhesUsuario(idUsuario);
        }
        public AlteraUsuView()
        {
            InitializeComponent();
        }

        private void AlteraUsuView_Load(object sender, EventArgs e)
        {
            UsuariosController usuariosController = new();
        }

        public async void PreencherDetalhesUsuario(int id)
        {

            this.Show();

            var usuario = await usuariosController.ObterUsuarioPorId(id);

            if (usuario != null)
            {
                textBoxNomeCompleto.Text = usuario.nome.ToString();
                textBoxEmail.Text = usuario.email;
                if (usuario.administrador == 1)
                {
                    checkBoxAdministrador.Checked = true;
                }
                else
                {
                    checkBoxAdministrador.Checked = false;
                }
                if (usuario.ativo == 1)
                {
                    checkBoxAtivo.Checked = true;
                }
                else
                {
                    checkBoxAtivo.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Não foi possível obter os dados do usuário. Tente novamente mais tarde!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}