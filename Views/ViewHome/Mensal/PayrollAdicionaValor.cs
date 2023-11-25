using DesktopPim.Model;
using DesktopPim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string valor = textBox1.Text;

            string valorTexto = valor.Replace("R$ ", "").Replace(".", "");


            if (decimal.TryParse(valorTexto, out decimal valorNovo) && !string.IsNullOrEmpty(nomeValor) && !string.IsNullOrEmpty(tipoValor))
            {
                payrollView.dataGridViewDescontos.Rows.Add(payrollView.dataGridViewDescontos.Rows.Count + 1, tipoValor, nomeValor, valorNovo);
                textBoxNomeValor.Text = "";
                comboBoxTp.SelectedIndex = -1;
                textBox1.Text = "";
                payrollView.CalcularValorLiquido();
            }
            else
            {
                MessageBox.Show("Algum campo está em branco ou é inválido.", "Erro ao adicionar evento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void IniciarComboBoxes()
        {
            comboBoxTp.Items.Clear();
            comboBoxTp.Items.Insert(0, string.Empty);
            comboBoxTp.Items.Insert(1, "Provento");
            comboBoxTp.Items.Insert(2, "Desconto");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Remove o manipulador de eventos para evitar a chamada recursiva
            textBox1.TextChanged -= textBox1_TextChanged;

            // Remove caracteres não numéricos
            string text = Regex.Replace(textBox1.Text, @"[^0-9]", "");

            // Verifica se a string é um número válido
            if (decimal.TryParse(text, out decimal value))
            {
                // Converte para decimal e divide por 100 para obter os centavos
                value /= 100;

                // Formata como valor monetário brasileiro
                textBox1.Text = value.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));

                // Move o cursor para o final
                textBox1.SelectionStart = textBox1.Text.Length;
            }

            // Adiciona o manipulador de eventos de volta
            textBox1.TextChanged += textBox1_TextChanged;
        }



    }
}