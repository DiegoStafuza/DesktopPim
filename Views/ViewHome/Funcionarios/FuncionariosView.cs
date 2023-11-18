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
using DesktopPim.Model;
using DesktopPim.Views.ViewHome.Funcionarios;
using com.sun.xml.@internal.bind.v2.model.core;

namespace DesktopPim.Views.ViewHome
{
    public partial class FuncionariosView : Form
    {
        
        AlteraFuncionarioView altView = new();
        

        public FuncionariosView()
        {
            InitializeComponent();
            dataGridViewFuncionarios.Columns.Clear();
            dataGridViewFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void FuncionariosView_Load(object sender, EventArgs e)
        {
            FuncionariosController funcionariosController = new FuncionariosController();
            funcionariosController.LoadDataAPI(this);
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal();
        }

        public async void buttonExcluir_Click(object sender, EventArgs e)
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

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            FuncionariosController funcionariosController = new FuncionariosController();
            funcionariosController.LoadDataAPI(this);
        }

        private async void buttonAlterar_Click(object sender, EventArgs e)
        {

            int idFunci = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[0].Cells["ID"].Value);

            FuncionariosController funcionariosController = new();

            funcionariosController.ObterFuncionarioPorId(idFunci);

            altView.PreencherDetalhesFuncionario(idFunci);

            AbrirFormularioAlteracao();


        }
        private AlteraFuncionarioView altera;
        private void AbrirFormularioAlteracao()
        {
            if (altera == null || altera.IsDisposed)
            {
                altera = new AlteraFuncionarioView();
                altera.FormClosed += (sender, e) => altera = null;
                altera.Show();
            }
            else
            {
                altera.BringToFront();
            }
        }

    }
}