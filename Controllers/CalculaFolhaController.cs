using com.sun.security.ntlm;
using DesktopPim.Controllers;
using DesktopPim.Model;
using System;
using System.Collections.Generic;
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
        apiDadosFuncComplt = "https://20.206.249.21/api/Funcionarios/dadosFuncionarioCompleto/{id}";
        apiDadosFunc = "https://20.206.249.21/api/Funcionarios";
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

    public async Task<List<FuncionarioDetalhes>> ObterDetalhesFuncionario(int funcionarioId)
    {
        try
        {
            var response = await httpClient.GetAsync(apiDadosFuncComplt);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<FuncionarioDetalhes>>(jsonString);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return new List<FuncionarioDetalhes>();
    }

    public void PreencherDataGridView(int funcionarioId)
    {

        DataGridViewRow row = new DataGridViewRow();
        row.Cells.Add(new DataGridViewTextBoxCell { Value = "INSS" });
        row.Cells.Add(new DataGridViewTextBoxCell { Value = "Desconto" });
        row.Cells.Add(new DataGridViewTextBoxCell { Value = "10%" });
    }

}
