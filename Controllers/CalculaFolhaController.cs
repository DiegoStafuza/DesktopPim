using com.sun.security.ntlm;
using com.sun.xml.@internal.bind.v2.model.core;
using DesktopPim.Controllers;
using DesktopPim.Model;
using DesktopPim.Views;
using DesktopPim.Views.ViewHome;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
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
                MessageBox.Show("Não foi possível obter os dados do funcionário", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        await payrollView.PreencherDetalhesFuncionario(funcionarioDetalhes, funcionarioDetalhes.dataContratacao.ToString());
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
        payroll.comboBoxMes.Items.Add("");
        payroll.comboBoxMes.Items.Add("Janeiro");
        payroll.comboBoxMes.Items.Add("Fevereiro");
        payroll.comboBoxMes.Items.Add("Março");
        payroll.comboBoxMes.Items.Add("Abril");
        payroll.comboBoxMes.Items.Add("Maio");
        payroll.comboBoxMes.Items.Add("Junho");
        payroll.comboBoxMes.Items.Add("Julho");
        payroll.comboBoxMes.Items.Add("Agosto");
        payroll.comboBoxMes.Items.Add("Setembro");
        payroll.comboBoxMes.Items.Add("Outubro");
        payroll.comboBoxMes.Items.Add("Novembro");
        payroll.comboBoxMes.Items.Add("Dezembro");

        payroll.comboBoxAno.Items.Insert(0, string.Empty);
        payroll.comboBoxAno.Items.Insert(1, "2023");
        payroll.comboBoxAno.Items.Insert(2, "2024");
        payroll.comboBoxAno.Items.Insert(3, "2025");
        payroll.comboBoxAno.Items.Insert(4, "2026");
        payroll.comboBoxAno.Items.Insert(5, "2027");
        payroll.comboBoxAno.Items.Insert(6, "2028");
        payroll.comboBoxAno.Items.Insert(7, "2029");
        payroll.comboBoxAno.Items.Insert(8, "2030");


    }

    public decimal CorrigeValorDecimal(decimal valorOriginal)
    {

        string valorString = valorOriginal.ToString();


        if (valorString.Length > 2)
        {

            valorString = valorString.Insert(valorString.Length - 2, ".");
        }
        else
        {
            valorString = valorString.PadLeft(3, '0').Insert(1, ".");
        }

        return Convert.ToDecimal(valorString, CultureInfo.InvariantCulture);
    }

    public async Task AdicionarValores(ProventosViewModel model)
    {
        try
        {
            List<ProventosListModel> proventos = new List<ProventosListModel>();

            var dataContratacao = DateTime.Parse(model.DataContratacao.ToString()).ToString("MM/yyyy");

            string juntaAnoMes = $"{model.Mes}/{model.Ano}";
            var mesAnoCalculo = DateTime.Parse(juntaAnoMes.ToString()).ToString("MM/yyyy");

            var dataContratacaoFormatada = DateTime.Parse(dataContratacao);

            var mesAno = DateTime.Parse(mesAnoCalculo);

            if(mesAno <= dataContratacaoFormatada)
            {
                MessageBox.Show($"Mês e ano não podem ser menores ou igual a data de contratação. \n\n Data de contratação: {dataContratacao}", "Erro ao adicionar valores.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            model.Proventos.ForEach(p =>
            {
                var item = new ProventosListModel();
                item.id_funcionario = model.FuncionarioId;
                item.mes = model.Mes;
                item.ano = model.Ano;
                if (p.Valor.HasValue)
                {
                    item.valor = CorrigeValorDecimal(p.Valor.Value);
                }
                item.nome_valor = p.NomeValor;
                item.tipo_valor = p.TipoValor;
                item.data = DateTime.Now;
                proventos.Add(item);
            });

            var response = await httpClient.PostAsJsonAsync("https://20.14.87.19/api/Calculo/AdicionaValores", proventos);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Folha de pagamento gerada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.UnprocessableEntity)
            {
                MessageBox.Show($"Já existe cálculo para esse funcionário referente a {model.Mes} de {model.Ano}.", "Erro ao adicionar valores.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Erro na requisição. Status: {response.StatusCode}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro inesperado. Status: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}