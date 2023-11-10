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

namespace DesktopPim.Views.ViewHome
{
    public partial class AdicionaFuncionarioView : Form
    {
        FuncionariosController funcionariosController = new FuncionariosController();
        public AdicionaFuncionarioView()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }

        }

        private void AdicionaFuncionarioView_Load(object sender, EventArgs e)
        {
            this.comboBoxCargos.Items.Clear();
            funcionariosController.LoadCargos(this);


            comboBoxEstadoCivil.Items.Insert(0, string.Empty);
            comboBoxEstadoCivil.Items.Insert(1, "Solteiro(a)");
            comboBoxEstadoCivil.Items.Insert(2, "Casado(a)");
            comboBoxEstadoCivil.Items.Insert(3, "Divorciado(a)");
            comboBoxEstadoCivil.Items.Insert(4, "União estável");

            comboBoxTpContato.Items.Insert(0, string.Empty);
            comboBoxTpContato.Items.Insert(1, "Telefone");
            comboBoxTpContato.Items.Insert(2, "Comercial");
            comboBoxTpContato.Items.Insert(3, "Residencial");

            comboBoxTpEndereco.Items.Insert(0, string.Empty);
            comboBoxTpEndereco.Items.Insert(1, "Residencial");
            comboBoxTpEndereco.Items.Insert(2, "Comercial");
            comboBoxTpEndereco.Items.Insert(3, "Apartamento");
        }
    }
}
