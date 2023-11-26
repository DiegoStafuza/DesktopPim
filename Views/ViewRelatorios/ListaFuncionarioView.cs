using DesktopPim.Controllers;
using DesktopPim.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPim.Views.ViewDuvidas
{
    public partial class ListaFuncionarioView : Form
    {
        FuncionariosController func = new();
        RelatorioController relatorios = new RelatorioController();
        public ListaFuncionarioView()
        {
            InitializeComponent();


        }

        private async void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBoxMes.SelectedIndex <= 0 || string.IsNullOrEmpty(comboBoxAno.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Preencha as informações corretamente antes de realizar a busca", "Erro ao buscar lançamentos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string mesSelecionado = (comboBoxMes.SelectedIndex).ToString("D2");
                    string anoSelecionado = comboBoxAno.SelectedItem.ToString();
                    int funcionarioId = (comboBoxFuncionarios.SelectedItem as FuncionariosCalculo).id_funcionario;

                    relatorios.LoadDataPgto(this, mesSelecionado, anoSelecionado, funcionarioId);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao tentar buscar as informações de pagamentos do funcionário. \n Status {ex.Message}", "Tente novamente masis tarde.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void ListaFuncionarioView_Load(object sender, EventArgs e)
        {
            await func.LoadFuncionarios(this);
            IniciarComboBoxes();
        }

        public void IniciarComboBoxes()
        {

            comboBoxMes.Items.Add("");
            comboBoxMes.Items.Add("Janeiro");
            comboBoxMes.Items.Add("Fevereiro");
            comboBoxMes.Items.Add("Março");
            comboBoxMes.Items.Add("Abril");
            comboBoxMes.Items.Add("Maio");
            comboBoxMes.Items.Add("Junho");
            comboBoxMes.Items.Add("Julho");
            comboBoxMes.Items.Add("Agosto");
            comboBoxMes.Items.Add("Setembro");
            comboBoxMes.Items.Add("Outubro");
            comboBoxMes.Items.Add("Novembro");
            comboBoxMes.Items.Add("Dezembro");

            comboBoxAno.Items.Insert(0, string.Empty);
            comboBoxAno.Items.Insert(1, "2023");
            comboBoxAno.Items.Insert(2, "2024");
            comboBoxAno.Items.Insert(3, "2025");
            comboBoxAno.Items.Insert(4, "2026");
            comboBoxAno.Items.Insert(5, "2027");
            comboBoxAno.Items.Insert(6, "2028");
            comboBoxAno.Items.Insert(7, "2029");
            comboBoxAno.Items.Insert(8, "2030");


        }
    }
}
