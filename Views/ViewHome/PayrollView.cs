using DesktopPim.Model;

namespace DesktopPim.Views
{
    public partial class PayrollView : Form
    {
        private CalculaFolhaController calculaFolha;
        private List<FuncionarioDetalhes> funcionarioDetalhes;
        private List<FuncionariosCalculo> funcionariosCalculos;
        public PayrollView()
        {
            InitializeComponent();
            calculaFolha = new CalculaFolhaController();
        }
        async void PayrollView_Load(object sender, EventArgs e)
        {
            funcionariosCalculos = await calculaFolha.ObterTodosFuncionarios();
            comboBoxFuncionarios.DataSource = funcionariosCalculos;
            comboBoxFuncionarios.DisplayMember = "nome_funcionario";
        }

        async void comboBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFuncionarioId = (comboBoxFuncionarios.SelectedItem as FuncionariosCalculo).id_funcionario;

            List<FuncionarioDetalhes> funcionarioDetalhes = await calculaFolha.ObterDetalhesFuncionario(selectedFuncionarioId);

            if (funcionarioDetalhes.Count > 0)
            {

                FuncionarioDetalhes func = funcionarioDetalhes[0];
                textBoxDepto.Text = func.departamento;
                textBoxCargo.Text = func.cargo;
                textBoxSalario.Text = func.salario.ToString("C");

                calculaFolha.PreencherDataGridView(selectedFuncionarioId);
            }
        }
    }
}
