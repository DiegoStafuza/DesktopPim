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

        private bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == formType)
                {
                    return true;
                }
            }
            return false;
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
                            UsuariosView usuarios = new();
                            HomeView homeView = new();
                            homeView.ABrirFormFilho(usuarios);
                            usuariosController.LoadDataAPI(this);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Houve um erro ao tentar excluir o usuário selecionado. Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário na tabela para excluí-lo.", "Selecione um usuário.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public async void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridViewUsuarios.SelectedRows[0];

                int idFunci = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                if (!IsFormOpen(typeof(AlteraUsuView)))
                {
                    AlteraUsuView alteraUsuView = new AlteraUsuView(idFunci);
                    alteraUsuView.Show();

                }
                else
                {
                    var openForm = Application.OpenForms.OfType<AlteraUsuView>().FirstOrDefault();
                    openForm.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um usuário para alterar.", "Selecione um usuário.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UsuariosView_Load(object sender, EventArgs e)
        {
            UsuariosController usuariosController = new();
            usuariosController.LoadDataAPI(this);
        }
    }
}
