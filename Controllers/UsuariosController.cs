using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Text.Json;
using DesktopPim.Model;
using System.Net.Http;
using DesktopPim.Controllers;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using DesktopPim.Models;
using DesktopPim.Views;
using DesktopPim.View;
using Newtonsoft.Json;
using DesktopPim.Views.ViewHome;
using ApiPIM.Models;
using Chilkat;
using Usuarios = DesktopPim.Models.Usuarios;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace DesktopPim.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly HttpClient client;
        private readonly string apiUrl = "https://20.14.87.19/api/Autenticacao/listarUsuarios";
        UsuariosView usuView = new();

        public UsuariosController()
        {
            client = new HttpClientService().CreateHttpClient();
        }

        public async Task<List<Models.Usuarios>> LoadUsuarios(UsuariosView usuariosView)
        {

            FuncionariosController funcionariosController = new FuncionariosController();
            var usuariosLista = new List<Models.Usuarios>();
            var response = await client.GetAsync("https://20.14.87.19/api/Autenticacao/listarUsuarios");

            if (response.IsSuccessStatusCode)
            {

                var jsonString = await response.Content.ReadAsStringAsync();
                var dadosUsu = System.Text.Json.JsonSerializer.Deserialize<List<Models.Usuarios>>(jsonString);


                foreach (var item in dadosUsu)
                {
                    var usuario = new Usuarios
                    {
                        usuario_id = item.usuario_id,
                        nome = item.nome,
                        email = item.email,
                        ativo = item.ativo,
                        administrador = item.administrador
                    };
                    usuariosLista.Add(usuario);
                }
            }
            return usuariosLista;
        }

        public async void LoadDataAPI(UsuariosView usuariosView)
        {
            UsuariosController usuariosController = new();

            usuariosView.dataGridViewUsuarios.Columns.Clear();
            usuariosView.dataGridViewUsuarios.Columns.Add("ID", "ID");
            usuariosView.dataGridViewUsuarios.Columns.Add("Nome", "Nome");
            usuariosView.dataGridViewUsuarios.Columns.Add("E-mail", "E-mail");
            usuariosView.dataGridViewUsuarios.Columns.Add("Ativo", "Ativo");
            usuariosView.dataGridViewUsuarios.Columns.Add("Administrador", "Administrador");

            List<Usuarios> usuarios = await usuariosController.LoadUsuarios(usuariosView);

            if (usuarios != null)
            {
                foreach (var usu in usuarios)
                {
                    usuariosView.dataGridViewUsuarios.Rows.Add(usu.usuario_id, usu.nome, usu.email, usu.ativo, usu.administrador, usu);
                }
            }
        }

        public async Task<bool> ExcluirUsuario(int id)
        {

            try
            {

                HttpResponseMessage response = await client.DeleteAsync($"https://20.14.87.19/api/Usuarios/excluir/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Erro ao excluir usuário. Status Code: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir usuário. Status: {ex.Message}");
                return false;
            }
        }

        public async Task <Usuarios> ObterUsuarioPorId(int id)
        {
            var response = await client.GetAsync($"https://20.14.87.19/api/Usuarios/listarUsuarios");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var usuarios = JsonConvert.DeserializeObject<List<Usuarios>>(jsonString);

                Usuarios usuarioDados = usuarios.FirstOrDefault(usuarios => usuarios.usuario_id == id);

                if (usuarioDados != null)
                {

                    return usuarioDados;

                }

            }
            return null;
        }
    }
}
