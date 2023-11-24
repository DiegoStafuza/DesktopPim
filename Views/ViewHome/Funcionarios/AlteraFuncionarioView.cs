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
using SlackAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FuncionariosController = DesktopPim.Controllers.FuncionariosController;


namespace DesktopPim.Views.ViewHome.Funcionarios
{
    public partial class AlteraFuncionarioView : Form
    {
        private readonly int idFuncionario;

        FuncionariosController funcionariosController = new();
        public AlteraFuncionarioView(int id)
        {
            InitializeComponent();
            idFuncionario = id;
            PreencherDetalhesFuncionario(idFuncionario);
        }
        public AlteraFuncionarioView()
        {
            InitializeComponent();
        }

        public async void AlteraFuncionarioView_Load(object sender, EventArgs e)
        {

            this.comboBoxCargos.Items.Clear();
            await funcionariosController.LoadCargos(this);
            funcionariosController.IniciarComboBoxes(this);
            await funcionariosController.LoadUsuarios(this);
        }


        public async void PreencherDetalhesFuncionario(int id)
        {
            this.Show();
            var funcionario = await funcionariosController.ObterFuncionarioPorId(id);


            textBoxNomeCompleto.Text = funcionario.funcionario.nome_funcionario;
            comboBoxEstadoCivil.Text = funcionario.funcionario.estado_civil;
            if (funcionario.funcionario.sexo == "Masculino")
            {
                checkBoxMasculino.Checked = true;
            }
            else
            {
                checkBoxFeminino.Checked = true;
            }
            comboBoxCargos.Text = funcionario.funcionario.cargo;
            textBoxRua.Text = funcionario.enderecos.FirstOrDefault()?.rua;
            comboBoxTpEndereco.Text = funcionario.enderecos.FirstOrDefault()?.tipo_endereco;
            textBoxBairro.Text = funcionario.enderecos.FirstOrDefault()?.bairro;
            maskedTextBoxCEP.Text = funcionario.enderecos.FirstOrDefault()?.cep;
            textBoxCidade.Text = funcionario.enderecos.FirstOrDefault()?.cidade;
            comboBoxTpContato.Text = funcionario.contatos.FirstOrDefault()?.tipo_telefone;
            label3.Text = $"ID: {funcionario.funcionario.id_funcionario}";
            maskedTextBoxDTContratacao.Text = Convert.ToString(funcionario.funcionario.data_contratacao);
            textBoxNmrContato.Text = funcionario.contatos.FirstOrDefault()?.numero_contato;
            //comboBoxUsuarios.Text = funcionario.funcionario.email_usuario;
            //maskedTextBoxUF.Text = funcionario.enderecos.FirstOrDefault()?.
            maskedTextBoxCpf.Text = funcionario.funcionario.cpf;
        }

        private void checkBoxFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFeminino.Checked)
            {
                checkBoxMasculino.Checked = false;
            }
        }

        private void checkBoxMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMasculino.Checked)
            {
                checkBoxFeminino.Checked = false;
            }
        }

        private async void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {
                FuncionariosController funcionariosController = new FuncionariosController();

                FuncionarioDTO funcionarioDTO = new FuncionarioDTO();

                funcionarioDTO.funcionario = new FuncionarioDTO.FuncionarioDetalhe
                {
                    nome_funcionario = textBoxNomeCompleto.Text,
                    cpf = maskedTextBoxCpf.Text,
                    sexo = GetSexoSelecionado(),
                    cargo_id = ((CargosDTO)comboBoxCargos.SelectedItem)?.id_cargo,
                    estado_civil = (string)comboBoxEstadoCivil.SelectedItem,
                    data_contratacao = Convert.ToDateTime(maskedTextBoxDTContratacao.Text)
                };

                funcionarioDTO.enderecos = new List<FuncionarioDTO.Endereco>
                {
                    new FuncionarioDTO.Endereco
                    {
                        tipo_endereco = (string)comboBoxTpEndereco.SelectedItem,
                        bairro = textBoxBairro.Text,
                        cep = maskedTextBoxCEP.Text,
                        cidade = textBoxCidade.Text
                    }
                };

                funcionarioDTO.contatos = new List<FuncionarioDTO.Contato>
{
                    new FuncionarioDTO.Contato
                    {
                    tipo_telefone = (string)comboBoxTpContato.SelectedItem,
                    numero_contato = textBoxNmrContato.Text
                    }
                };

                //await funcionariosController.AtualizarFuncionario(funcionarioDTO);
                funcionariosController.LimparCampos(this);
                this.Close();
                FuncionariosView funcionariosView = new FuncionariosView();
                funcionariosController.LoadDataAPI(funcionariosView);

            }
            else
            {
                FuncionariosController funcionariosController = new();
                MessageBox.Show("Preencha todos os campos antes de cadastrar um novo funcionário!", "Existem campos sem preenchimento!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool CamposPreenchidos() =>
       !string.IsNullOrWhiteSpace(textBoxNomeCompleto.Text)
           && !string.IsNullOrWhiteSpace(maskedTextBoxCpf.Text)
           //&& !string.IsNullOrWhiteSpace((string)comboBoxUsuarios.SelectedItem)
           && !string.IsNullOrWhiteSpace(GetSexoSelecionado())
           && comboBoxCargos.SelectedItem != null
           && (maskedTextBoxDtContratacao_Validating())
           && !string.IsNullOrWhiteSpace((string)comboBoxEstadoCivil.SelectedItem)
           && !string.IsNullOrWhiteSpace(textBoxRua.Text)
           && !string.IsNullOrWhiteSpace((string)comboBoxTpEndereco.SelectedItem)
           && !string.IsNullOrWhiteSpace(textBoxBairro.Text)
           && !string.IsNullOrWhiteSpace(textBoxCidade.Text)
           && !string.IsNullOrWhiteSpace(maskedTextBoxCEP.Text)
           && !string.IsNullOrWhiteSpace(textBoxNmrContato.Text)
           && !string.IsNullOrWhiteSpace((string)comboBoxTpContato.SelectedItem);

        private string GetSexoSelecionado()
        {
            if (checkBoxMasculino.Checked)
            {
                return "Masculino";
            }
            else if (checkBoxFeminino.Checked)
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

            if (!DateTime.TryParseExact(maskedTextBoxDTContratacao.Text, dateFormat, provider, DateTimeStyles.None, out _))
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
