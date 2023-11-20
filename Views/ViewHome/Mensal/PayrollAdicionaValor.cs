using DesktopPim.Model;
using DesktopPim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPim.Views.ViewHome.Mensal
{
    public partial class PayrollAdicionaValor : Form
    {
        PayrollView p = new PayrollView();
        public PayrollAdicionaValor()
        {
            InitializeComponent();
            IniciarComboBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        public void buttonAdicionarValor_Click(object sender, EventArgs e)
        {
            var nomeValor = textBoxNomeValor.Text;
            var tipoValor = comboBoxTp.SelectedItem?.ToString();
            var valor = decimal.Parse(textBoxValor.Text);

            if(!string.IsNullOrEmpty(nomeValor) && !string.IsNullOrEmpty(tipoValor))
            {
                p.dataGridViewDescontos.Rows.Add(p.dataGridViewDescontos.Rows.Count + 1, tipoValor, nomeValor, valor);
                this.Close();
                p.dataGridViewDescontos.Update();
            }
            else
            {
                MessageBox.Show("Algum campo está em branco ou é inválido.");
            }
        }

        public async void IniciarComboBoxes()
        {
            comboBoxTp.Items.Clear();
            comboBoxTp.Items.Insert(0, string.Empty);
            comboBoxTp.Items.Insert(1, "Provento");
            comboBoxTp.Items.Insert(2, "Desconto");
        }
    }
}
