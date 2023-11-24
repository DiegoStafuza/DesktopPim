using DesktopPim.Controllers;
using DesktopPim.Views.ViewHome;
using DesktopPim.Views.ViewHome.Funcionarios;
using DesktopPim.Views.ViewHome.Mensal;
using DesktopPim.Views.ViewHome.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPim.Views
{
    public partial class UsuariosView : Form
    {
        public UsuariosView()
        {
            InitializeComponent();
            dataGridViewUsuarios.Columns.Clear();
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal();
        }

        private AdicionaUsu formularioModal;

        private void AbrirFormularioModal()
        {
            if (formularioModal == null || formularioModal.IsDisposed)
            {
                formularioModal = new AdicionaUsu();
                formularioModal.FormClosed += (sender, e) => formularioModal = null;
                formularioModal.Show();
            }
            else
            {
                formularioModal.BringToFront();
            }
        }

        private async void buttonAtualizar_Click(object sender, EventArgs e)
        {
            UsuariosController usuariosController = new();
            usuariosController.LoadDataAPI(this);
        }

        public async void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                try
                {
                    int idUsuario = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["ID"].Value);
                    string nomeUsu = (string)dataGridViewUsuarios.SelectedRows[0].Cells["Nome"].Value;

                    DialogResult desejaExcluir = MessageBox.Show($"Ao continuar, você excluirá o usuário '{nomeUsu}'. Tem certeza que deseja continuar?", "Exclusão de funcionário", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (desejaExcluir == DialogResult.OK)
                    {
                        UsuariosController usuariosController = new UsuariosController();
                        bool excluiu = await usuariosController.ExcluirUsuario(idUsuario);

                        if (excluiu)
                        {
                            dataGridViewUsuarios.Columns.Clear();
                            HomeView homeView = new();
                            homeView.ABrirFormFilho(this);
                            usuariosController.LoadDataAPI(this);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Houve um erro ao tentar excluir o funcionário selecionado. Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário na tabela para excluí-lo.");
            }
        }

        public async void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridViewUsuarios.SelectedRows[0];

                int idFunci = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                AlteraUsuView alteraUsuView = new AlteraUsuView(idFunci);

            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário para alterar.");
            }
        }

        private void UsuariosView_Load(object sender, EventArgs e)
        {
            UsuariosController usuariosController = new();
            usuariosController.LoadDataAPI(this);
        }
    }
}
