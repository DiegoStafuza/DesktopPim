using DesktopPim.Model;
using DesktopPim.Views.ViewHome.Mensal;
using System.Windows.Forms;
using System.Linq;

namespace DesktopPim.Views
{
    public partial class PayrollView : Form
    {
        private List<FuncionarioDetalhes> funcionarioDetalhes;
        private List<FuncionariosCalculo> funcionariosCalculos;
        CalculaFolhaController calculaFolha = new CalculaFolhaController();
        public PayrollView()
        {
            InitializeComponent();
            dataGridViewDescontos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            calculaFolha.IniciarComboBoxes(this);


        }
        async void PayrollView_Load(object sender, EventArgs e)
        {
            funcionariosCalculos = await calculaFolha.ObterTodosFuncionarios();
            comboBoxFuncionarios.DataSource = funcionariosCalculos;
            comboBoxFuncionarios.DisplayMember = "nome_funcionario";
            calculaFolha.ValorLiquido();
        }



        async void comboBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFuncionarios.SelectedItem != null)
            {
                int selectedFuncionariId = (comboBoxFuncionarios.SelectedItem as FuncionariosCalculo).id_funcionario;

                var funcionarioDetalhes = await calculaFolha.ObterDetalhesFuncionarioPorId(selectedFuncionariId);

                if (funcionarioDetalhes != null)
                {
                    if (dataGridViewDescontos.Columns.Count == 0)
                    {

                        dataGridViewDescontos.Columns.Add("ID", "ID");
                        dataGridViewDescontos.Columns.Add("Tipo", "Tipo");
                        dataGridViewDescontos.Columns.Add("Nome", "Nome");
                        dataGridViewDescontos.Columns.Add("Valor", "Valor");
                    }
                    dataGridViewDescontos.Rows.Clear();

                    int id = dataGridViewDescontos.Rows.Count + 1;


                    dataGridViewDescontos.Rows.Add(id, "Provento", "Salário", funcionarioDetalhes.salario);


                    dataGridViewDescontos.Rows.Add(dataGridViewDescontos.Rows.Count + 1, "Desconto", "INSS", funcionarioDetalhes.descontoINSS);
                    dataGridViewDescontos.Rows.Add(dataGridViewDescontos.Rows.Count + 1, "Desconto", "IRRF", funcionarioDetalhes.descontoIRRF);


                    await PreencherDetalhesFuncionario(funcionarioDetalhes);
                }
                else
                {
                    LimparCamposDetalhesFuncionario();
                }
            }
        }

        public async Task PreencherDetalhesFuncionario(FuncionarioDetalhes funcionario)
        {
            if (funcionario != null)
            {
                textBoxDepto.Text = funcionario.departamento;
                textBoxSalario.Text = "R$ " + funcionario.salario.ToString();
                textBoxCargo.Text = funcionario.cargo;

                textBoxDepto.Enabled = false;
                textBoxSalario.Enabled = false;
                textBoxCargo.Enabled = false;
            }
        }
        void LimparCamposDetalhesFuncionario()
        {

            textBoxDepto.Text = string.Empty;
            textBoxSalario.Text = string.Empty;
            textBoxCargo.Text = string.Empty;


            textBoxDepto.Enabled = true;
            textBoxSalario.Enabled = true;
            textBoxCargo.Enabled = true;
        }


        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal();
        }

        private PayrollAdicionaValor formularioModal;

        private void AbrirFormularioModal()
        {
            if (formularioModal == null || formularioModal.IsDisposed)
            {
                formularioModal = new PayrollAdicionaValor();
                formularioModal.FormClosed += (sender, e) => formularioModal = null;
                formularioModal.Show();
            }
            else
            {
                formularioModal.BringToFront();
            }
        }

        private void dataGridViewDescontos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDescontos.Columns["Valor"].Index && e.Value != null)
            {

                if (e.Value is decimal || e.Value is double || e.Value is float)
                {

                    e.Value = string.Format("R$ {0:N2}", e.Value);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}