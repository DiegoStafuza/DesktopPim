using System.Web.Mvc;
using System.Text.Json;
using DesktopPim.Model;
using DesktopPim.Views.ViewHome;
using DesktopPim.Models;

namespace DesktopPim.Controllers
{

    public class FuncionariosController : Controller
    {
        private readonly HttpClient client;
        private readonly string apiUrl = "https://20.206.249.21/api/Funcionarios/dadosFuncionarioCompleto";
        public FuncionariosController()
        {
            client = new HttpClientService().CreateHttpClient();
        }

        public async Task<List<ListaFuncionarios>> ObterFuncionarios()
        {
            var funcionariosLista = new List<ListaFuncionarios>();
            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var dadosFunc = JsonSerializer.Deserialize<List<FuncionarioDTO>>(jsonString);

                foreach (var item in dadosFunc)
                {
                    var funcionario = new ListaFuncionarios
                    {
                        funcionario_id = item.funcionario.id_funcionario,
                        nome_completo = item.funcionario.nome_funcionario,
                        deparamento = item.funcionario.departamento
                    };
                    funcionariosLista.Add(funcionario);
                }
            }

            return funcionariosLista;
        }

        public async void LoadDataAPI(FuncionariosView funcionariosView)
        {
            List<ListaFuncionarios> funcionarios = await this.ObterFuncionarios();

            if (funcionarios != null)
            {
                funcionariosView.dataGridViewFuncionarios.Columns.Add("funcionario_id", "ID");
                funcionariosView.dataGridViewFuncionarios.Columns.Add("nome_completo", "Nome Completo");
                funcionariosView.dataGridViewFuncionarios.Columns.Add("departamento", "Departamento");

                foreach (var funcionario in funcionarios)
                {
                    funcionariosView.dataGridViewFuncionarios.Rows.Add(funcionario.funcionario_id, funcionario.nome_completo, funcionario.deparamento);
                }
            }
        }
    }
}