using com.sun.security.ntlm;
using DesktopPim.Controllers;
using DesktopPim.Model;
using DesktopPim.Views;
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

}
