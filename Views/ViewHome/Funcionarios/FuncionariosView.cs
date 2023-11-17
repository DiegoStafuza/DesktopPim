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

        }

        private void FuncionariosView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionaFuncionarioView adicionaFuncionarioView = new();
            adicionaFuncionarioView.Show();
        }

        public async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuncionarios.SelectedRows.Count > 0)
            {
                int idFuncionarioSelecionado = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[0].Cells["ID"].Value);
                MessageBox.Show($"ID do Funcionário Selecionado: {idFuncionarioSelecionado}");

                FuncionariosController funcionariosController = new FuncionariosController();
                bool excluiu = await funcionariosController.ExcluirFuncionario(idFuncionarioSelecionado);

                if (excluiu)
                {
                    dataGridViewFuncionarios.Columns.Clear();
                    funcionariosController.LoadDataAPI(this);
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário na tabela para excluí-lo.");
            }
        }
    }
}