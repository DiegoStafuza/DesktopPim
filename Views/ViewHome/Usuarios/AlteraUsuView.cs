﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chilkat;
using DesktopPim.Controllers;
using DesktopPim.Model;
using DesktopPim.Models;

namespace DesktopPim.Views.ViewHome.Usuarios
{
    public partial class AlteraUsuView : Form
    {
        private readonly int idUsuario;

        Controllers.UsuariosController usuariosController = new();

        public AlteraUsuView(int id)
        {
            InitializeComponent();
            idUsuario = id;
            PreencherDetalhesUsuario(idUsuario);
            checkBox1.Checked = false;
            textBoxSenha.Enabled = false;
            textBoxConfirmaSenha.Enabled = false;
            label5.Enabled = false;
            label4.Enabled = false;
        }
        public AlteraUsuView()
        {
            InitializeComponent();
        }




        public async void PreencherDetalhesUsuario(int id)
        {

            this.Show();


            var usuario = await usuariosController.ObterUsuarioPorId(id);

            if (usuario != null)
            {


                labeliD.Text = $"{usuario.usuario_id}";
                textBoxNomeCompleto.Text = usuario.nome.ToString();
                textBoxEmail.Text = usuario.email;
                if (usuario.administrador == 1)
                {
                    checkBoxAdministrador.Checked = true;
                }
                else
                {
                    checkBoxAdministrador.Checked = false;
                }
                if (usuario.ativo == 1)
                {
                    checkBoxAtivo.Checked = true;
                }
                else
                {
                    checkBoxAtivo.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Não foi possível obter os dados do usuário. Tente novamente mais tarde!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {

                if (textBoxSenha.Text != textBoxConfirmaSenha.Text)
                {
                    MessageBox.Show("As senhas não coincidem", "Verifique!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    UsuariosModel usuariosModel = new UsuariosModel
                    {
                        usuario_id = int.Parse(labeliD.Text),
                        nome = textBoxNomeCompleto.Text,
                        email = textBoxEmail.Text,
                        administrador = (short)(checkBoxAdministrador.Checked ? 1 : 0),
                        ativo = (short)(checkBoxAtivo.Checked ? 1 : 0),
                        senha = textBoxSenha.Text,
                        token = null,
                        expiration_token = null
                    };
                    await usuariosController.EditarUsuario(usuariosModel);
                    this.LimparCampos();

                    UsuariosView usuariosView = new UsuariosView();
                    usuariosController.LoadDataAPI(usuariosView);
                    this.Close();

                }
            }
            else
            {

                MessageBox.Show("Preencha todos os campos antes de alterar um usuário!", "Existem campos sem preenchimento!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private bool CamposPreenchidos() =>
            !string.IsNullOrWhiteSpace(textBoxNomeCompleto.Text)
                && !string.IsNullOrWhiteSpace(textBoxEmail.Text);

        private void LimparCampos()
        {
            textBoxNomeCompleto.Clear();
            textBoxEmail.Clear();
            textBoxSenha.Clear();
            textBoxConfirmaSenha.Clear();
            checkBoxAtivo.Checked = false;
            checkBoxAdministrador.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBoxSenha.Enabled = true;
                textBoxConfirmaSenha.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
            }
            else
            {
                textBoxSenha.Enabled = false;
                textBoxConfirmaSenha.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
            }
        }
    }

}