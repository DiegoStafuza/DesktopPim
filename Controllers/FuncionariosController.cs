using System.Web.Mvc;
using System.Text.Json;
using DesktopPim.Model;
using DesktopPim.Views.ViewHome;
using DesktopPim.Models;
using DesktopPim.Views;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Headers;
using ApiPIM.Models;
using com.sun.xml.@internal.bind.v2.model.core;

namespace DesktopPim.Controllers
{

    public class FuncionariosController : Controller
    {
        private readonly HttpClient client;
        private readonly string apiUrl = "https://20.14.87.19/api/Funcionarios/dadosFuncionarioCompleto";
        private readonly string apiNovoFunc = "https://20.14.87.19/api/Funcionarios/novoFuncionario";
        AdicionaFuncionarioView addFuncionario = new();
        private const string baseUrl = "https://20.14.87.19/api/Funcionarios/";

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
                var dadosFunc = JsonSerializer.Deserialize<List<Model.FuncionarioDTO>>(jsonString);

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
            funcionariosView.dataGridViewFuncionarios.Columns.Clear();
            funcionariosView.dataGridViewFuncionarios.Columns.Add("ID", "ID");
            funcionariosView.dataGridViewFuncionarios.Columns.Add("Nome Completo", "Nome Completo");
            funcionariosView.dataGridViewFuncionarios.Columns.Add("Departamento", "Departamento");

            List<ListaFuncionarios> funcionarios = await this.ObterFuncionarios();

            if (funcionarios != null)
            {
                foreach (var funcionario in funcionarios)
                {
                    funcionariosView.dataGridViewFuncionarios.Rows.Add(funcionario.funcionario_id, funcionario.nome_completo, funcionario.deparamento);
                }
            }
        }

        public async Task LoadCargos(AdicionaFuncionarioView addFuncionariosView)
        {
            var response = await client.GetAsync("https://20.14.87.19/api/Cargos/retornaCargos");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var cargos = JsonSerializer.Deserialize<List<CargosDTO>>(jsonString);

                addFuncionariosView.comboBoxCargos.Items.Clear();

                var itemVazio = new CargosDTO { id_cargo = 0, nome_cargo = "" };
                cargos.Insert(0, itemVazio);

                addFuncionariosView.comboBoxCargos.DataSource = cargos;
                addFuncionariosView.comboBoxCargos.DisplayMember = "nome_cargo";
                addFuncionariosView.comboBoxCargos.ValueMember = "id_cargo";
                //int selectedCargoId = (int)addFuncionariosView.comboBoxCargos.SelectedValue;
            }
        }

        public void IniciarComboBoxes(AdicionaFuncionarioView addFuncionario)
        {
            addFuncionario.comboBoxEstadoCivil.Items.Insert(0, string.Empty);
            addFuncionario.comboBoxEstadoCivil.Items.Insert(1, "Solteiro(a)");
            addFuncionario.comboBoxEstadoCivil.Items.Insert(2, "Casado(a)");
            addFuncionario.comboBoxEstadoCivil.Items.Insert(3, "Divorciado(a)");
            addFuncionario.comboBoxEstadoCivil.Items.Insert(4, "União estável");

            addFuncionario.comboBoxTpContato.Items.Insert(0, string.Empty);
            addFuncionario.comboBoxTpContato.Items.Insert(1, "Telefone");
            addFuncionario.comboBoxTpContato.Items.Insert(2, "Comercial");
            addFuncionario.comboBoxTpContato.Items.Insert(3, "Residencial");

            addFuncionario.comboBoxTpEndereco.Items.Insert(0, string.Empty);
            addFuncionario.comboBoxTpEndereco.Items.Insert(1, "Residencial");
            addFuncionario.comboBoxTpEndereco.Items.Insert(2, "Comercial");
            addFuncionario.comboBoxTpEndereco.Items.Insert(3, "Apartamento");
        }

        public async Task<bool> CadastrarFuncionario(NovoFuncionarioViewModel fun)
        {

            try
            {
                var data = new
                {
                    fun.nome,
                    fun.cpf,
                    fun.sexo,
                    fun.cargo_id,
                    fun.data_contratacao,
                    fun.estado_civil,
                    fun.rua,
                    fun.tipo_endereco,
                    fun.num_endereco,
                    fun.bairro,
                    fun.cep,
                    fun.cidade,
                    fun.uf_estado,
                    fun.tipo_telefone,
                    fun.numero_contato
                };
                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiNovoFunc, content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void LimparCampos(AdicionaFuncionarioView addFuncionario)
        {
            addFuncionario.textBoxNomeCompleto.Text = string.Empty;
            addFuncionario.maskedTextCPF.Text = string.Empty;
            addFuncionario.checkBox1.Checked = false;
            addFuncionario.checkBox2.Checked = false;
            addFuncionario.comboBoxEstadoCivil.Text = string.Empty;
            addFuncionario.comboBoxCargos.Text = string.Empty;
            LimparSelecaoMonthCalendar(addFuncionario.monthCalendar1);
            addFuncionario.textBox2.Text = string.Empty;
            addFuncionario.comboBoxTpEndereco.Text = string.Empty;
            addFuncionario.textBox3.Text = string.Empty;
            addFuncionario.maskedTextBox2.Text = string.Empty;
            addFuncionario.textBox5.Text = string.Empty;
            addFuncionario.textBox4.Text = string.Empty;
            addFuncionario.maskedTextBox1.Text = string.Empty;
            addFuncionario.comboBoxTpContato.Text = string.Empty;
            addFuncionario.textBox7.Text = string.Empty;

        }


        public async Task<bool> ExcluirFuncionario(int id)
        {

            try
            {

                HttpResponseMessage response = await client.DeleteAsync($"https://20.14.87.19/api/Funcionarios/excluir/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao excluir funcionário. Status Code: {response.StatusCode}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir funcionário. {ex.Message}");
                    return false;
                }
        }

        private void LimparSelecaoMonthCalendar(MonthCalendar monthCalendar)
        {
            addFuncionario.monthCalendar1.SetDate(DateTime.Today);

            addFuncionario.monthCalendar1.SelectionStart = addFuncionario.monthCalendar1.TodayDate;
            addFuncionario.monthCalendar1.SelectionEnd = addFuncionario.monthCalendar1.TodayDate;
        }
    }
}