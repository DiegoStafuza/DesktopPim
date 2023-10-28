using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

public class LoginController
{
    private readonly string apiBaseUrl = "https://20.206.249.21:433/api/Autenticacao/login"; //URL da API

    public async Task<bool> AuthenticateAsync(string email, string password)
    {
        try
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var loginData = new
                {
                    email,
                    senha = password
                };

                var jsonContent = JsonConvert.SerializeObject(loginData);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync(apiBaseUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    bool isAdmin = IsUserAdmin(email);
                    bool isUserActive = IsUserActive(email);

                    if (isAdmin && isUserActive)
                    {
                        // Autenticação bem-sucedida
                        return true;
                    }
                }
            }

            // Autenticação falhou
            return false;
        }
        catch (Exception ex)
        {
            // Lidar com erros, por exemplo, log ou notificar o usuário
            return false;
        }
    }

    private bool IsUserAdmin(string email)
    {
        return email == "admin@example.com";
    }

    private bool IsUserActive(string email)
    {
        // Simulação: Verifique se o usuário está ativo com base no email
        // Substitua por sua lógica real
        return true;
    }
}
