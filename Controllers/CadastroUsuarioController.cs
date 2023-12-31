﻿using System;
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

namespace DesktopPim.Controllers
{
    public class CadastroUsuarioController : Controller
    {
        private readonly HttpClient client;
        private readonly string apiUrl = "https://20.14.87.19/api/Autenticacao/registrar";

        public CadastroUsuarioController()
        {
            client = new HttpClientService().CreateHttpClient();
        }

        public async Task Cadastro(CadastroViewModel form)
        {
            try
            {

                var userData = new
                {
                    nome = form.Nome,
                    email = form.Email,
                    senha = form.Senha,
                    administrador = form.Tipo,
                    ativo = form.Ativo
                };

                var json = JsonSerializer.Serialize(userData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sucesso ao cadastrar o novo usuário!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o novo usuário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro inesperado ao cadastrar o usuário.\n Status: {ex.Message}", "Erro inesperado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}