using DesktopPim.Model;

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

        }
        async void PayrollView_Load(object sender, EventArgs e)
        {
            funcionariosCalculos = await calculaFolha.ObterTodosFuncionarios();
            comboBoxFuncionarios.DataSource = funcionariosCalculos;
            comboBoxFuncionarios.DisplayMember = "nome_funcionario";
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

        void ValorLiquido()
        {
            decimal valorProventos = 0;
            decimal valorDescontos = 0;

            foreach (DataGridViewRow row in dataGridViewDescontos.Rows)
            {
                string tipo = row.Cells["Tipo"].Value.ToString();
                decimal valor = Convert.ToDecimal(row.Cells["Valor"].Value);

                if (tipo == "Provento")
                {
                    valorProventos += valor;
                }
                else if (tipo == "Desconto")
                {
                    valorDescontos += valor;
                }
            }

            decimal valorLiquido = valorProventos - valorDescontos;

            labelValorLiquido.Text = $"Valor líquido: R$ {valorLiquido:N2}";
        }


    }
}
