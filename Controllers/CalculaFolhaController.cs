using com.sun.security.ntlm;
using DesktopPim.Controllers;
using DesktopPim.Model;
using DesktopPim.Views;
using DesktopPim.Views.ViewHome;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

public class CalculaFolhaController
{
    private readonly string apiDadosFuncComplt;
    private readonly string apiDadosFunc;
    private CalculaFolhaViewModel viewModel;
    private readonly HttpClient httpClient;

    public CalculaFolhaController()
    {
        apiDadosFuncComplt = "https://20.14.87.19/api/Funcionarios/dadosFuncionarioCompleto/{id}";
        apiDadosFunc = "https://20.14.87.19/api/Funcionarios";
        viewModel = new CalculaFolhaViewModel();
        httpClient = new HttpClientService().CreateHttpClient();


    }

    public async Task<List<FuncionariosCalculo>> ObterTodosFuncionarios()
    {
        try
        {
            var response = await httpClient.GetAsync(apiDadosFunc);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<FuncionariosCalculo>>(jsonString);
            }
            else
            {
                MessageBox.Show("Não foi possível obter os dados do funcionário");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return new List<FuncionariosCalculo>();
    }

    public async Task<FuncionarioDetalhes> ObterDetalhesFuncionario(int id)
    {
        var detalhes = await ObterDetalhesFuncionarioPorId(id);

        if (detalhes != null)
        {
            return detalhes;
        }
        else
        {
            return null;
        }
    }

    public async Task PreencherDetalhesFuncionario(int selectedFuncionarioId)
    {
        PayrollView payrollView = new();
        var funcionarioDetalhes = await ObterDetalhesFuncionario(selectedFuncionarioId);
        await payrollView.PreencherDetalhesFuncionario(funcionarioDetalhes);
    }

    public async Task<FuncionarioDetalhes> ObterDetalhesFuncionarioPorId(int id)
    {
        var response = await httpClient.GetAsync($"https://20.14.87.19/api/Funcionarios/dadosFuncionarioCalculo/{id}");

        if (response.IsSuccessStatusCode)
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            var funcionarioDetalhes = JsonSerializer.Deserialize<List<FuncionarioDetalhes>>(jsonString);

            if (funcionarioDetalhes != null && funcionarioDetalhes.Count > 0)
            {
                return funcionarioDetalhes[0];
            }
        }

        return null;
    }

    public void IniciarComboBoxes(PayrollView payroll)
    {

        payroll.comboBoxMes.Items.Insert(0, "Janeiro");
        payroll.comboBoxMes.Items.Insert(1, "Fevereiro");
        payroll.comboBoxMes.Items.Insert(2, "Março");
        payroll.comboBoxMes.Items.Insert(3, "Abril");
        payroll.comboBoxMes.Items.Insert(4, "Maio");
        payroll.comboBoxMes.Items.Insert(5, "Junho");
        payroll.comboBoxMes.Items.Insert(6, "Julho");
        payroll.comboBoxMes.Items.Insert(7, "Agosto");
        payroll.comboBoxMes.Items.Insert(8, "Setembro");
        payroll.comboBoxMes.Items.Insert(9, "Outubro");
        payroll.comboBoxMes.Items.Insert(10, "Novembro");
        payroll.comboBoxMes.Items.Insert(11, "Dezembro");

        payroll.comboBoxAno.Items.Insert(0, "2023");
        payroll.comboBoxAno.Items.Insert(1, "2024");
        payroll.comboBoxAno.Items.Insert(2, "2025");
        payroll.comboBoxAno.Items.Insert(3, "2026");
        payroll.comboBoxAno.Items.Insert(4, "2027");
        payroll.comboBoxAno.Items.Insert(5, "2028");
        payroll.comboBoxAno.Items.Insert(6, "2029");
        payroll.comboBoxAno.Items.Insert(7, "2030");


    }
    public void ValorLiquido()
    {
        PayrollView payroll = new();

        bool todasAsLinhasComValor = true;

        foreach (DataGridViewRow row in payroll.dataGridViewDescontos.Rows)
        {
            if (!row.IsNewRow && (row.Cells["Valor"].Value == null || string.IsNullOrWhiteSpace(row.Cells["Valor"].Value.ToString())))
            {
                todasAsLinhasComValor = false;
                break;
            }
        }
        if (todasAsLinhasComValor)
        {
            double totalProventos = 0.00;
            double totalDescontos = 0.00;

            foreach (DataGridViewRow row in payroll.dataGridViewDescontos.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["Tipo"].Value != null && row.Cells["Valor"].Value != null)
                    {
                        string tipo = row.Cells["Tipo"].Value.ToString();
                        double valor = 0.00;

                        if (double.TryParse(row.Cells["Valor"].Value.ToString(), out valor))
                        {
                            if (tipo == "Provento")
                            {
                                totalProventos += valor;
                            }
                            else if (tipo == "Desconto")
                            {
                                totalDescontos += valor;
                            }
                        }
                        else
                        {
                            todasAsLinhasComValor = false;
                            break;
                        }
                    }
                }
            }
            if (todasAsLinhasComValor)
            {
                double saldo = totalProventos - totalDescontos;
                payroll.labelValorLiquido.Text = $"Valor líquido: R$ {saldo}";
            }
            else
            {

                payroll.labelValorLiquido.Text = "Algumas linhas possuem valores inválidos!";
            }
        }
        else
        {

            payroll.labelValorLiquido.Text = "Algumas linhas estão sem valor!";
        }
    }
}
