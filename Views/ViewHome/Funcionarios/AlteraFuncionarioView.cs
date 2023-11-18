using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiPIM.Controllers;
using DesktopPim.Controllers;
using DesktopPim.Model;
using javax.management.loading;
using FuncionariosController = DesktopPim.Controllers.FuncionariosController;


namespace DesktopPim.Views.ViewHome.Funcionarios
{
    public partial class AlteraFuncionarioView : Form
    {
        FuncionariosController funcionariosController = new();
        public AlteraFuncionarioView()
        {
            InitializeComponent();

        }

        private async void AlteraFuncionarioView_Load(object sender, EventArgs e)
        {
            
            this.comboBoxCargos.Items.Clear();
            await funcionariosController.LoadCargos(this);
            funcionariosController.IniciarComboBoxes(this);
        }


        public async Task PreencherDetalhesFuncionario(int id)
        {
            var funcionario = await funcionariosController.ObterFuncionarioPorId(id);

            if(funcionario != null)
            {
                textBoxNomeCompleto.Text = funcionario.funcionario.nome_funcionario;

            }
            else
            {
                MessageBox.Show("Dados do funcionário não encontrados.");
                this.Close();
            }
        }
        
       
    }
}
