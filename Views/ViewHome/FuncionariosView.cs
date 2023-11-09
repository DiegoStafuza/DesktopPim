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
            dataGridViewFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FuncionariosView_Load(object sender, EventArgs e)
        {
            this.dataGridViewFuncionarios.Columns.Clear();
            funcionariosController.LoadDataAPI(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionaFuncionarioView adicionaFuncionarioView = new();
            adicionaFuncionarioView.Show();
        }
    }
}
