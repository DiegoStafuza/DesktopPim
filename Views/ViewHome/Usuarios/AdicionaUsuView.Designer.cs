namespace DesktopPim.Views
{
    partial class AdicionaUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionaUsu));
            NomeCompletoTx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmailTx = new TextBox();
            label4 = new Label();
            SenhaTx = new TextBox();
            label5 = new Label();
            ConfirmSenTx = new TextBox();
            CheckAtivo = new CheckBox();
            CheckAdm = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // NomeCompletoTx
            // 
            NomeCompletoTx.Cursor = Cursors.IBeam;
            NomeCompletoTx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeCompletoTx.Location = new Point(199, 138);
            NomeCompletoTx.Name = "NomeCompletoTx";
            NomeCompletoTx.Size = new Size(414, 29);
            NomeCompletoTx.TabIndex = 0;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(234, 9);
            label1.Name = "label1";
            label1.Size = new Size(361, 60);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de usuário";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(199, 101);
            label2.Name = "label2";
            label2.Size = new Size(180, 34);
            label2.TabIndex = 0;
            label2.Text = "Nome completo";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(199, 192);
            label3.Name = "label3";
            label3.Size = new Size(180, 34);
            label3.TabIndex = 0;
            label3.Text = "E-mail";
            // 
            // EmailTx
            // 
            EmailTx.Cursor = Cursors.IBeam;
            EmailTx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTx.Location = new Point(199, 229);
            EmailTx.Name = "EmailTx";
            EmailTx.Size = new Size(414, 29);
            EmailTx.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(199, 280);
            label4.Name = "label4";
            label4.Size = new Size(180, 34);
            label4.TabIndex = 0;
            label4.Text = "Senha";
            // 
            // SenhaTx
            // 
            SenhaTx.Cursor = Cursors.IBeam;
            SenhaTx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SenhaTx.Location = new Point(199, 317);
            SenhaTx.Name = "SenhaTx";
            SenhaTx.Size = new Size(414, 29);
            SenhaTx.TabIndex = 2;
            SenhaTx.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(199, 367);
            label5.Name = "label5";
            label5.Size = new Size(180, 34);
            label5.TabIndex = 0;
            label5.Text = "Confirma senha";
            // 
            // ConfirmSenTx
            // 
            ConfirmSenTx.Cursor = Cursors.IBeam;
            ConfirmSenTx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmSenTx.Location = new Point(199, 404);
            ConfirmSenTx.Name = "ConfirmSenTx";
            ConfirmSenTx.Size = new Size(414, 29);
            ConfirmSenTx.TabIndex = 3;
            ConfirmSenTx.UseSystemPasswordChar = true;
            // 
            // CheckAtivo
            // 
            CheckAtivo.Cursor = Cursors.Hand;
            CheckAtivo.FlatStyle = FlatStyle.Flat;
            CheckAtivo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CheckAtivo.Location = new Point(199, 510);
            CheckAtivo.Name = "CheckAtivo";
            CheckAtivo.Size = new Size(166, 57);
            CheckAtivo.TabIndex = 5;
            CheckAtivo.Text = "Ativo";
            CheckAtivo.UseVisualStyleBackColor = true;
            // 
            // CheckAdm
            // 
            CheckAdm.Cursor = Cursors.Hand;
            CheckAdm.FlatStyle = FlatStyle.Flat;
            CheckAdm.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CheckAdm.Location = new Point(199, 447);
            CheckAdm.Name = "CheckAdm";
            CheckAdm.Size = new Size(166, 57);
            CheckAdm.TabIndex = 4;
            CheckAdm.Text = "Administrador";
            CheckAdm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(199, 659);
            button1.Name = "button1";
            button1.Size = new Size(414, 57);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdicionaUsu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(847, 728);
            Controls.Add(button1);
            Controls.Add(CheckAdm);
            Controls.Add(CheckAtivo);
            Controls.Add(label5);
            Controls.Add(ConfirmSenTx);
            Controls.Add(label4);
            Controls.Add(SenhaTx);
            Controls.Add(label3);
            Controls.Add(EmailTx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NomeCompletoTx);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AdicionaUsu";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NomeCompletoTx;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmailTx;
        private Label label4;
        private TextBox SenhaTx;
        private Label label5;
        private TextBox ConfirmSenTx;
        private CheckBox CheckAtivo;
        private CheckBox CheckAdm;
        private Button button1;
    }
}