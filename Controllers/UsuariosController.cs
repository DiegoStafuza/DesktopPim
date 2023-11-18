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

        //public async void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        HttpResponseMessage response = await client.GetAsync(apiUrl);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            string jsonResponse = await response.Content.ReadAsStringAsync();
        //            var usuarios = JsonConvert.DeserializeObject<Usuarios[]>(jsonResponse);

        //            if (usuarios.Length > 0)
        //            {
        //                usuView.dataGridViewUsuarios.Rows.Clear();
        //                usuView.dataGridViewUsuarios.Columns.Clear();
        //            }
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show($"Erro ao tentar listar usuários: {ex.Message}");
        //    }
        //}
    }
}
