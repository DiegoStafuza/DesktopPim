using Azure;
using DesktopPim.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPim.Views.ViewHome
{
    public partial class FuncionariosView : Form
    {
        FuncionariosController funcionariosController = new FuncionariosController();
        public FuncionariosView()
        {
            InitializeComponent();
            dataGridViewFuncionarios.Columns.Clear();
            funcionariosController.LoadDataAPI(this);
            dataGridViewFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void FuncionariosView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal();
        }

        public async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuncionarios.SelectedRows.Count > 0)
            {
                try
                {
                    int idFuncionarioSelecionado = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[0].Cells["ID"].Value);
                    string nomeFunc = (string)dataGridViewFuncionarios.SelectedRows[0].Cells["Nome completo"].Value;

                    DialogResult desejaExcluir = MessageBox.Show($"Ao continuar, você excluirá o funcionário '{nomeFunc}'. Tem certeza que deseja continuar?", "Exclusão de funcionário", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (desejaExcluir == DialogResult.OK)
                    {
                        FuncionariosController funcionariosController = new FuncionariosController();
                        bool excluiu = await funcionariosController.ExcluirFuncionario(idFuncionarioSelecionado);

                        if (excluiu)
                        {
                            dataGridViewFuncionarios.Columns.Clear();
                            funcionariosController.LoadDataAPI(this);
                            FuncionariosView funcionariosView = new();
                            HomeView homeView = new();
                            homeView.ABrirFormFilho(funcionariosView);
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


        private AdicionaFuncionarioView formularioModal;

        private void AbrirFormularioModal()
        {
            if (formularioModal == null || formularioModal.IsDisposed)
            {
                formularioModal = new AdicionaFuncionarioView();
                formularioModal.FormClosed += (sender, e) => formularioModal = null;
                formularioModal.Show();
            }
            else
            {
                formularioModal.BringToFront();
            }
        }
    }
}