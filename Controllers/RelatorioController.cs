using System.Web.Mvc;
using System.Text.Json;
using DesktopPim.Model;
using DesktopPim.Views.ViewHome;
using DesktopPim.Models;
using DesktopPim.Views;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Headers;
using com.sun.xml.@internal.bind.v2.model.core;
using DesktopPim.Views.ViewHome.Funcionarios;
using System.Web.Helpers;
using Microsoft.IdentityModel.Tokens;
using ApiPIM.Models;
using DesktopPim.Views.ViewDuvidas;
using FuncionarioDTO = DesktopPim.Model.FuncionarioDTO;

namespace DesktopPim.Controllers
{

    public class RelatorioController : Controller
    {
        private readonly HttpClient client;

        public RelatorioController()
        {
            client = new HttpClientService().CreateHttpClient();

        }

        public async Task<List<DadosPgto>> DadosPgto(string mesSelecionado, string anoSelecionado, int id)
        {
            int mes;
            int ano;

            if (!int.TryParse(mesSelecionado, out mes) || !int.TryParse(anoSelecionado, out ano))
            {
                MessageBox.Show("Insira um mês e ano válidos.");
                return new List<DadosPgto>();
            }
            
            var response = await client.GetAsync($"https://20.14.87.19/api/App/{id}");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var dadosApi = JsonSerializer.Deserialize<List<DadosPgto>>(jsonString);

                var listaFiltrada = new List<DadosPgto>();

                foreach (var item in dadosApi)
                {
                    if (int.Parse(item.mes) == mes && int.Parse(item.ano) == ano)
                    {
                        listaFiltrada.Add(new DadosPgto
                        {
                            mes = item.mes,
                            ano = item.ano,
                            total_descontos = item.total_descontos,
                            total_proventos = item.total_proventos,
                            valor_liquido = item.valor_liquido
                        });
                    }
                }
                if(dadosApi == null)
                {
                        MessageBox.Show("Não houve pagamento no mês e ano selecionado para esse funcionário.", "Informações não encontradas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

               return listaFiltrada;
                }
            else
            {
                MessageBox.Show("Falha ao obter os dados da API.");
                return new List<DadosPgto>();
            }
        }

        public async void LoadDataPgto(ListaFuncionarioView list, string mesSelecionado, string anoSelecionado, int id)
        {
            list.dataGridViewDados.Columns.Clear();
            list.dataGridViewDados.Columns.Add("Mês", "Mês");
            list.dataGridViewDados.Columns.Add("Ano", "Ano");
            list.dataGridViewDados.Columns.Add("Total proventos", "Total proventos");
            list.dataGridViewDados.Columns.Add("Total descontos", "Total descontos");
            list.dataGridViewDados.Columns.Add("Valor líquido", "Valor líquido");

            List<DadosPgto> dados = await this.DadosPgto(mesSelecionado, anoSelecionado, id);

            if (dados != null)
            {
                foreach (var dado in dados)
                {
                    list.dataGridViewDados.Rows.Add(
                        dado.mes,
                        dado.ano,
                        "R$ " + dado.total_proventos,
                        "R$ " + dado.total_descontos,
                        "R$ " + dado.valor_liquido
                        );
                }
            }
        
        }
    }
}
