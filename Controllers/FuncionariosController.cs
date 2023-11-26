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
                        deparamento = item.funcionario.departamento,
                        sexo = item.funcionario.sexo,
                        cargo = item.funcionario.cargo,
                        data_contratacao = item.funcionario.data_contratacao
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
            funcionariosView.dataGridViewFuncionarios.Columns.Add("Nome", "Nome");
            funcionariosView.dataGridViewFuncionarios.Columns.Add("Departamento", "Departamento");
            funcionariosView.dataGridViewFuncionarios.Columns.Add("Sexo", "Sexo");
            funcionariosView.dataGridViewFuncionarios.Columns.Add("Cargo", "Cargo");
            funcionariosView.dataGridViewFuncionarios.Columns.Add("Contratação", "Contratação");

            List<ListaFuncionarios> funcionarios = await this.ObterFuncionarios();

            if (funcionarios != null)
            {
                foreach (var funcionario in funcionarios)
                {
                    funcionariosView.dataGridViewFuncionarios.Rows.Add(
                        funcionario.funcionario_id,
                        funcionario.nome_completo,
                        funcionario.deparamento,
                        funcionario.sexo,
                        funcionario.cargo,
                        funcionario.data_contratacao
                        );
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

        public async Task CadastrarFuncionario(NovoFuncionarioViewModel fun)
        {

            try
            {
                var data = new
                {
                    nome = fun.nome,
                    cpf = fun.cpf,
                    sexo = fun.sexo,
                    cargo_id = fun.cargo_id,
                    data_contratacao = fun.data_contratacao,
                    estado_civil = fun.estado_civil,
                    rua = fun.rua,
                    tipo_endereco = fun.tipo_endereco,
                    num_endereco = fun.num_endereco,
                    bairro = fun.bairro,
                    cep = fun.cep,
                    cidade = fun.cidade,
                    uf_estado = fun.uf_estado,
                    tipo_telefone = fun.tipo_telefone,
                    numero_contato = fun.numero_contato,
                    email_usuario = fun.email_usuario
                };
                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiNovoFunc, content);

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Funcionário já cadastrado.", "Funcionário já possui cadastro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                {

                    MessageBox.Show("Ocorreu um erro ao cadastrar o funcionário. Por favor, tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o funcionário\n Status: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            addFuncionario.maskedTextBoxDtContratacao.Text = string.Empty;
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
        public void LimparCampos(AlteraFuncionarioView alt)
        {
            alt.textBoxNomeCompleto.Text = string.Empty;
            alt.maskedTextBoxCpf.Text = string.Empty;
            alt.comboBoxUsuarios.Text = string.Empty;
            alt.checkBoxFeminino.Checked = false;
            alt.checkBoxMasculino.Checked = false;
            alt.comboBoxEstadoCivil.Text = string.Empty;
            alt.comboBoxCargos.Text = string.Empty;
            alt.maskedTextBoxDTContratacao.Text = string.Empty;
            alt.maskedTextBoxCEP.Text = string.Empty;
            alt.comboBoxTpEndereco.Text = string.Empty;
            alt.textBoxBairro.Text = string.Empty;
            alt.textBoxCidade.Text = string.Empty;
            alt.textBoxNmrContato.Text = string.Empty;
            alt.textBoxRua.Text = string.Empty;
            alt.comboBoxTpContato.Text = string.Empty;
            alt.textBoxNumero.Text = string.Empty;
            alt.maskedTextBoxUF.Text = string.Empty;
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
                MessageBox.Show($"Erro ao excluir funcionário. Status: {ex.Message}");
                return false;
            }
        }
        public async void IniciarComboBoxes(AlteraFuncionarioView altFuncionario)
        {
            altFuncionario.comboBoxEstadoCivil.Items.Insert(0, string.Empty);
            altFuncionario.comboBoxEstadoCivil.Items.Insert(1, "Solteiro(a)");
            altFuncionario.comboBoxEstadoCivil.Items.Insert(2, "Casado(a)");
            altFuncionario.comboBoxEstadoCivil.Items.Insert(3, "Divorciado(a)");
            altFuncionario.comboBoxEstadoCivil.Items.Insert(4, "União estável");

            altFuncionario.comboBoxTpContato.Items.Insert(0, string.Empty);
            altFuncionario.comboBoxTpContato.Items.Insert(1, "Telefone");
            altFuncionario.comboBoxTpContato.Items.Insert(2, "Comercial");
            altFuncionario.comboBoxTpContato.Items.Insert(3, "Residencial");

            altFuncionario.comboBoxTpEndereco.Items.Insert(0, string.Empty);
            altFuncionario.comboBoxTpEndereco.Items.Insert(1, "Residencial");
            altFuncionario.comboBoxTpEndereco.Items.Insert(2, "Comercial");
            altFuncionario.comboBoxTpEndereco.Items.Insert(3, "Apartamento");
        }
        public async Task LoadCargos(AlteraFuncionarioView alteraFuncionario)
        {
            var response = await client.GetAsync("https://20.14.87.19/api/Cargos/retornaCargos");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var cargos = JsonSerializer.Deserialize<List<CargosDTO>>(jsonString);

                alteraFuncionario.comboBoxCargos.Items.Clear();

                var itemVazio = new CargosDTO { id_cargo = 0, nome_cargo = "" };
                cargos.Insert(0, itemVazio);

                alteraFuncionario.comboBoxCargos.DataSource = cargos;
                alteraFuncionario.comboBoxCargos.DisplayMember = "nome_cargo";
                alteraFuncionario.comboBoxCargos.ValueMember = "id_cargo";
                //int selectedCargoId = (int)addFuncionariosView.comboBoxCargos.SelectedValue;
            }
        }
        public async Task<FuncionarioDTO> ObterFuncionarioPorId(int id)
        {
            var response = await client.GetAsync($"https://20.14.87.19/api/Funcionarios/dadosFuncionarioCompleto/{id}");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var funcionarios = JsonSerializer.Deserialize<List<FuncionarioDTO>>(jsonString);

                if (funcionarios != null)
                {

                    return funcionarios[0];

                }

            }
            return null;
        }

        public async Task LoadUsuarios(AdicionaFuncionarioView adicionaFuncionario)
        {
            var response = await client.GetAsync("https://20.14.87.19/api/Autenticacao/listarUsuarios");

            if (response.IsSuccessStatusCode)
            {

                var jsonString = await response.Content.ReadAsStringAsync();
                var usuarios = JsonSerializer.Deserialize<List<UsuarioDTO>>(jsonString);

                var itemVazio = new UsuarioDTO { usuario_id = 0, email = "" };

                usuarios.Insert(0, itemVazio);
                adicionaFuncionario.comboBoxUsuarios.DataSource = usuarios;
                adicionaFuncionario.comboBoxUsuarios.DisplayMember = "email";
                adicionaFuncionario.comboBoxUsuarios.ValueMember = "usuario_id";

            }
        }

        public async Task LoadUsuarios(AlteraFuncionarioView alteraFuncionarioView)
        {
            var response = await client.GetAsync("https://20.14.87.19/api/Autenticacao/listarUsuarios");

            if (response.IsSuccessStatusCode)
            {

                var jsonString = await response.Content.ReadAsStringAsync();
                var usuarios = JsonSerializer.Deserialize<List<UsuarioDTO>>(jsonString);

                var itemVazio = new UsuarioDTO { usuario_id = 0, email = "" };

                usuarios.Insert(0, itemVazio);
                alteraFuncionarioView.comboBoxUsuarios.DataSource = usuarios;
                alteraFuncionarioView.comboBoxUsuarios.DisplayMember = "email";
                alteraFuncionarioView.comboBoxUsuarios.ValueMember = "usuario_id";

            }
        }

        public async Task AtualizarFuncionario(FuncionarioDTO model)
        {
            try {
            List<EnderecoApiDTO> listaEndereco = new List<EnderecoApiDTO>();
            List<TelefoneApiDTO> listaTelefone = new List<TelefoneApiDTO>();

            if (model.enderecos != null)
            {
                model.enderecos.ForEach(end =>
                {
                    EnderecoApiDTO item = new EnderecoApiDTO();
                    item.id = end.id;
                    item.tipo_endereco = end.tipo_endereco;
                    item.rua = end.rua;
                    item.bairro = end.bairro;
                    item.num_endereco = end.num_endereco;
                    item.cep = end.cep;
                    item.cidade = end.cidade;
                    item.uf_estado = end.uf_estado;
                    listaEndereco.Add(item);
                });
            }

            if (model.contatos != null)
            {
                model.contatos.ForEach(cto =>
                {
                    TelefoneApiDTO item = new TelefoneApiDTO();
                    item.id = cto.id;
                    item.tipo_telefone = cto.tipo_telefone;
                    item.numero_contato = cto.numero_contato;
                    listaTelefone.Add(item);
                });
            }

            string usuario = "";

            if (model.funcionario.email_usuario != null)
            {
                usuario = model.funcionario.email_usuario.ToString();
            }

            var apiDto = new FuncionarioApiDTO
            {
                nome = model?.funcionario.nome_funcionario,
                sexo = model?.funcionario.sexo,
                estado_civil = model?.funcionario.estado_civil,
                cargo_id = model?.funcionario.cargo_id,
                data_contratacao = model?.funcionario.data_contratacao,
                cpf = model?.funcionario.cpf,
                email_usuario = usuario,
                enderecos = listaEndereco,
                telefones = listaTelefone
            };

                var jsonString = JsonSerializer.Serialize(apiDto);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"https://20.14.87.19/api/Funcionarios/atualizaFuncionario/{model.funcionario.id_funcionario}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sucesso ao atualizar o funcionário!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o funcionário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o funcionário!\n Status: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}