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

            //if(funcionario != null)
            //{
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
            //}
            //else
            //{
            //    MessageBox.Show("Dados do funcionário não encontrados.");
            //    this.Close();
            //}
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
    }
}
