using System.Net;
using System.Text;
using System.Text.Json;
using System.Web.Mvc;
using DesktopPim.Controllers;

namespace DesktopPim.Controllers
{
    public class LoginController : Controller
    {

        private readonly string apiUrl = "https://20.14.87.19/api/Autenticacao/login";
        private readonly HttpClient client;

        public LoginController()
        {
            client = new HttpClientService().CreateHttpClient();
        }

        public async Task<Model.LoginResponse> Login(string username, string password)
        { 

            var data = new
            {
                email = username,
                Senha = password
            };

            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(apiUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                var loginResponse = JsonSerializer.Deserialize<Model.LoginResponse>(body);

                return loginResponse;

            }
            return null;
        }
    }
}

