using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiPIM.Controllers;
using DesktopPim.Controllers;
using DesktopPim.Model;
using javax.management.loading;
using FuncionariosController = DesktopPim.Controllers.FuncionariosController;

namespace DesktopPim.Views.ViewHome
{

    public partial class AdicionaFuncionarioView : Form
    {

        public AdicionaFuncionarioView()
        {
            InitializeComponent();


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

        private async void AdicionaFuncionarioView_Load(object sender, EventArgs e)
        {
            FuncionariosController funcionariosController = new();
            this.comboBoxCargos.Items.Clear();
            await funcionariosController.LoadCargos(this);
            funcionariosController.IniciarComboBoxes(this);
            await funcionariosController.LoadUsuarios(this);
        }

        private async void buttonCadastrarFunc_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {
                FuncionariosController funcionariosController = new();
                NovoFuncionarioViewModel NovoFunc = new NovoFuncionarioViewModel()
                {
                    nome = textBoxNomeCompleto.Text,
                    cpf = maskedTextCPF.Text,
                    sexo = GetSexoSelecionado(),
                    cargo_id = ((CargosDTO)comboBoxCargos.SelectedItem)?.id_cargo,
                    data_contratacao = Convert.ToDateTime(maskedTextBoxDtContratacao.Text),
                    estado_civil = (string)comboBoxEstadoCivil.SelectedItem,
                    rua = textBox2.Text,
                    tipo_endereco = (string)comboBoxTpEndereco.SelectedItem,
                    num_endereco = textBox5.Text,
                    bairro = textBox3.Text,
                    cep = maskedTextBox2.Text,
                    cidade = textBox4.Text,
                    uf_estado = maskedTextBox1.Text,
                    tipo_telefone = (string)comboBoxTpContato.SelectedItem,
                    numero_contato = textBox7.Text
                };

                await funcionariosController.CadastrarFuncionario(NovoFunc);
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                funcionariosController.LimparCampos(this);
                this.Close();
            }
            else
            {
                FuncionariosController funcionariosController = new();
                MessageBox.Show("Preencha todos os campos antes de cadastrar um novo funcionário!", "Existem campos sem preenchimento!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool CamposPreenchidos() =>
            !string.IsNullOrWhiteSpace(textBoxNomeCompleto.Text)
                && !string.IsNullOrWhiteSpace(maskedTextCPF.Text)
                && !string.IsNullOrWhiteSpace(GetSexoSelecionado())
                && comboBoxCargos.SelectedItem != null
                && (maskedTextBoxDtContratacao_Validating())
                && !string.IsNullOrWhiteSpace((string)comboBoxEstadoCivil.SelectedItem)
                && !string.IsNullOrWhiteSpace(textBox2.Text)
                && !string.IsNullOrWhiteSpace((string)comboBoxTpEndereco.SelectedItem)
                && !string.IsNullOrWhiteSpace(textBox5.Text)
                && !string.IsNullOrWhiteSpace(textBox3.Text)
                && !string.IsNullOrWhiteSpace(maskedTextBox2.Text)
                && !string.IsNullOrWhiteSpace(textBox4.Text)
                && !string.IsNullOrWhiteSpace(maskedTextBox1.Text)
                && !string.IsNullOrWhiteSpace((string)comboBoxTpContato.SelectedItem)
                && !string.IsNullOrWhiteSpace(textBox7.Text);

        private string GetSexoSelecionado()
        {
            if (checkBox1.Checked)
            {
                return "Masculino";
            }
            else if (checkBox2.Checked)
            {
                return "Feminino";
            }
            else
            {
                return string.Empty;
            }
        }

        private bool maskedTextBoxDtContratacao_Validating()
        {
            string dateFormat = "dd/MM/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            if (!DateTime.TryParseExact(maskedTextBoxDtContratacao.Text, dateFormat, provider, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Por favor, insira uma data válida no formato DD/MM/AAAA.", "Data inválida.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
