﻿using Azure;
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
using Timer = System.Windows.Forms.Timer;

namespace DesktopPim.Views.ViewHome
{
    public partial class FuncionariosView : Form
    {
        private bool podeClicar = true;
        private Timer timer1;
        public FuncionariosView()
        {
            InitializeComponent();
            dataGridViewFuncionarios.Columns.Clear();
            dataGridViewFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            RelatoriosView rView = new RelatoriosView(dataGridViewFuncionarios);
            timer1 = new Timer();
            timer1.Interval = 2000;
            timer1.Tick += HabilitarClique;
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
                    string nomeFunc = (string)dataGridViewFuncionarios.SelectedRows[0].Cells["Nome"].Value;

                    DialogResult desejaExcluir = MessageBox.Show($"Ao continuar, você excluirá o funcionário '{nomeFunc}'. Tem certeza que deseja continuar?", "Exclusão de funcionário", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (desejaExcluir == DialogResult.OK)
                    {
                        FuncionariosController funcionariosController = new FuncionariosController();
                        bool excluiu = await funcionariosController.ExcluirFuncionario(idFuncionarioSelecionado);

                        if (excluiu)
                        {
                            dataGridViewFuncionarios.Columns.Clear();
                            FuncionariosView funcionariosView = new();
                            HomeView homeView = new();
                            homeView.ABrirFormFilho(funcionariosView);
                            funcionariosController.LoadDataAPI(this);
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
                MessageBox.Show("Selecione um funcionário na tabela para excluí-lo.", "Nenhum funcionário selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (podeClicar)
            {
                podeClicar = false;
                buttonAtualizar.Enabled = false;
                timer1.Start();

                
            }
            FuncionariosController funcionariosController = new FuncionariosController();
            funcionariosController.LoadDataAPI(this);
        }
        private void HabilitarClique(object sender, EventArgs e)
        {
            podeClicar = true;
            buttonAtualizar.Enabled = true;
            timer1.Stop();
            
        }

        public async void buttonAlterar_Click(object sender, EventArgs e)
        {

            if (dataGridViewFuncionarios.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridViewFuncionarios.SelectedRows[0];

                int idFunci = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                if (!IsFormOpen(typeof(AlteraFuncionarioView)))
                {
                    AlteraFuncionarioView alt = new AlteraFuncionarioView(idFunci);
                    alt.Show();
                }
                else
                {
                    var openForm = Application.OpenForms.OfType<AlteraFuncionarioView>().FirstOrDefault();
                    openForm.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário para alterar.", "Selecione um funcionário.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


    }
}