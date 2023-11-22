namespace DesktopPim.Views.ViewHome.Usuarios
{
    partial class AlteraUsuView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteraUsuView));
            textBoxSenha = new TextBox();
            textBoxNomeCompleto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxConfirmaSenha = new TextBox();
            label5 = new Label();
            checkBoxAtivo = new CheckBox();
            checkBoxAdministrador = new CheckBox();
            buttonCadastrar = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxSenha
            // 
            textBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSenha.Location = new Point(179, 317);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(414, 29);
            textBoxSenha.TabIndex = 2;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomeCompleto.Location = new Point(179, 134);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.Size = new Size(414, 29);
            textBoxNomeCompleto.TabIndex = 0;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(221, -140);
            label1.Name = "label1";
            label1.Size = new Size(361, 60);
            label1.TabIndex = 11;
            label1.Text = "Cadastro de usuário";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 97);
            label2.Name = "label2";
            label2.Size = new Size(180, 34);
            label2.TabIndex = 10;
            label2.Text = "Nome completo";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(179, 225);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(414, 29);
            textBoxEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(179, 188);
            label3.Name = "label3";
            label3.Size = new Size(180, 34);
            label3.TabIndex = 9;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(179, 280);
            label4.Name = "label4";
            label4.Size = new Size(180, 34);
            label4.TabIndex = 8;
            label4.Text = "Senha";
            // 
            // textBoxConfirmaSenha
            // 
            textBoxConfirmaSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConfirmaSenha.Location = new Point(179, 404);
            textBoxConfirmaSenha.Name = "textBoxConfirmaSenha";
            textBoxConfirmaSenha.Size = new Size(414, 29);
            textBoxConfirmaSenha.TabIndex = 3;
            textBoxConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(179, 367);
            label5.Name = "label5";
            label5.Size = new Size(180, 34);
            label5.TabIndex = 7;
            label5.Text = "Confirma senha";
            // 
            // checkBoxAtivo
            // 
            checkBoxAtivo.Cursor = Cursors.Hand;
            checkBoxAtivo.FlatStyle = FlatStyle.Flat;
            checkBoxAtivo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAtivo.Location = new Point(179, 510);
            checkBoxAtivo.Name = "checkBoxAtivo";
            checkBoxAtivo.Size = new Size(166, 57);
            checkBoxAtivo.TabIndex = 5;
            checkBoxAtivo.Text = "Ativo";
            checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdministrador
            // 
            checkBoxAdministrador.Cursor = Cursors.Hand;
            checkBoxAdministrador.FlatStyle = FlatStyle.Flat;
            checkBoxAdministrador.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAdministrador.Location = new Point(179, 447);
            checkBoxAdministrador.Name = "checkBoxAdministrador";
            checkBoxAdministrador.Size = new Size(166, 57);
            checkBoxAdministrador.TabIndex = 4;
            checkBoxAdministrador.Text = "Administrador";
            checkBoxAdministrador.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackgroundImage = (Image)resources.GetObject("buttonCadastrar.BackgroundImage");
            buttonCadastrar.Cursor = Cursors.Hand;
            buttonCadastrar.FlatStyle = FlatStyle.Flat;
            buttonCadastrar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastrar.ForeColor = Color.White;
            buttonCadastrar.Location = new Point(179, 659);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(414, 57);
            buttonCadastrar.TabIndex = 18;
            buttonCadastrar.Text = "Alterar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(248, 9);
            label6.Name = "label6";
            label6.Size = new Size(272, 60);
            label6.TabIndex = 7;
            label6.Text = "Alterar usuário";
            // 
            // AlteraUsuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 728);
            Controls.Add(label6);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxSenha);
            Controls.Add(checkBoxAdministrador);
            Controls.Add(textBoxNomeCompleto);
            Controls.Add(checkBoxAtivo);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBoxConfirmaSenha);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AlteraUsuView";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AlteraUsuView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSenha;
        private TextBox textBoxNomeCompleto;
        private Label label1;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label3;
        private Label label4;
        private TextBox textBoxConfirmaSenha;
        private Label label5;
        private CheckBox checkBoxAtivo;
        private CheckBox checkBoxAdministrador;
        private Button buttonCadastrar;
        private Label label6;
    }
}