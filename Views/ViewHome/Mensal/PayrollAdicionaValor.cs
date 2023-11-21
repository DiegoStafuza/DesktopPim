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
        private PayrollView payrollView;
        public PayrollAdicionaValor(PayrollView payrollView)
        {
            this.payrollView = payrollView;
            InitializeComponent();
            IniciarComboBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        public void buttonAdicionarValor_Click(object sender, EventArgs e)
        {
            string nomeValor = textBoxNomeValor.Text;
            string tipoValor = comboBoxTp.SelectedItem?.ToString();
            decimal valor;

            if(decimal.TryParse(textBoxValor.Text, out valor) && !string.IsNullOrEmpty(nomeValor) && !string.IsNullOrEmpty(tipoValor))
            {
                payrollView.dataGridViewDescontos.Rows.Add(payrollView.dataGridViewDescontos.Rows.Count + 1, tipoValor, nomeValor, valor);
                textBoxNomeValor.Text = "";
                comboBoxTp.SelectedIndex = -1;
                textBoxValor.Text = "";
                payrollView.CalcularValorLiquido();
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
