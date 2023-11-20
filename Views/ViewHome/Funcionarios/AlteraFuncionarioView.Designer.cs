namespace DesktopPim.Views.ViewHome.Funcionarios
{
    partial class AlteraFuncionarioView
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
            label1 = new Label();
            textBoxNomeCompleto = new TextBox();
            label2 = new Label();
            checkBoxFeminino = new CheckBox();
            label4 = new Label();
            checkBoxMasculino = new CheckBox();
            comboBoxEstadoCivil = new ComboBox();
            label5 = new Label();
            comboBoxCargos = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            textBoxRua = new TextBox();
            label10 = new Label();
            textBoxCidade = new TextBox();
            maskedTextBoxCEP = new MaskedTextBox();
            label11 = new Label();
            textBoxBairro = new TextBox();
            label12 = new Label();
            comboBoxTpEndereco = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            comboBoxTpContato = new ComboBox();
            textBoxNmrContato = new TextBox();
            button1 = new Button();
            labelID = new Label();
            label3 = new Label();
            maskedTextBoxDTContratacao = new MaskedTextBox();
            label18 = new Label();
            comboBoxUsuarios = new ComboBox();
            label8 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 60);
            label1.TabIndex = 49;
            label1.Text = "Alterar funcionário";
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomeCompleto.Location = new Point(12, 127);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.Size = new Size(414, 29);
            textBoxNomeCompleto.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(180, 34);
            label2.TabIndex = 49;
            label2.Text = "Nome completo";
            // 
            // checkBoxFeminino
            // 
            checkBoxFeminino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFeminino.Location = new Point(144, 207);
            checkBoxFeminino.Name = "checkBoxFeminino";
            checkBoxFeminino.Size = new Size(109, 35);
            checkBoxFeminino.TabIndex = 5;
            checkBoxFeminino.Text = "Feminino";
            checkBoxFeminino.UseVisualStyleBackColor = true;
            checkBoxFeminino.CheckedChanged += checkBoxFeminino_CheckedChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 173);
            label4.Name = "label4";
            label4.Size = new Size(63, 34);
            label4.TabIndex = 28;
            label4.Text = "Sexo";
            // 
            // checkBoxMasculino
            // 
            checkBoxMasculino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMasculino.Location = new Point(16, 207);
            checkBoxMasculino.Name = "checkBoxMasculino";
            checkBoxMasculino.Size = new Size(124, 35);
            checkBoxMasculino.TabIndex = 4;
            checkBoxMasculino.Text = "Masculino";
            checkBoxMasculino.UseVisualStyleBackColor = true;
            checkBoxMasculino.CheckedChanged += checkBoxMasculino_CheckedChanged;
            // 
            // comboBoxEstadoCivil
            // 
            comboBoxEstadoCivil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEstadoCivil.FormattingEnabled = true;
            comboBoxEstadoCivil.Location = new Point(12, 283);
            comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            comboBoxEstadoCivil.Size = new Size(153, 29);
            comboBoxEstadoCivil.TabIndex = 6;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 248);
            label5.Name = "label5";
            label5.Size = new Size(117, 34);
            label5.TabIndex = 49;
            label5.Text = "Estado civil";
            // 
            // comboBoxCargos
            // 
            comboBoxCargos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCargos.FormattingEnabled = true;
            comboBoxCargos.Location = new Point(205, 283);
            comboBoxCargos.Name = "comboBoxCargos";
            comboBoxCargos.Size = new Size(262, 29);
            comboBoxCargos.TabIndex = 7;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(205, 244);
            label6.Name = "label6";
            label6.Size = new Size(76, 34);
            label6.TabIndex = 49;
            label6.Text = "Cargo";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 357);
            label7.Name = "label7";
            label7.Size = new Size(117, 34);
            label7.TabIndex = 28;
            label7.Text = "Endereço";
            // 
            // textBoxRua
            // 
            textBoxRua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRua.Location = new Point(16, 437);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(414, 29);
            textBoxRua.TabIndex = 9;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(14, 575);
            label10.Name = "label10";
            label10.Size = new Size(77, 34);
            label10.TabIndex = 60;
            label10.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCidade.Location = new Point(18, 612);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(414, 29);
            textBoxCidade.TabIndex = 13;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCEP.Location = new Point(436, 519);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(153, 29);
            maskedTextBoxCEP.TabIndex = 12;
            maskedTextBoxCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(436, 482);
            label11.Name = "label11";
            label11.Size = new Size(65, 34);
            label11.TabIndex = 57;
            label11.Text = "CEP";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBairro.Location = new Point(16, 519);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(414, 29);
            textBoxBairro.TabIndex = 11;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(14, 482);
            label12.Name = "label12";
            label12.Size = new Size(77, 34);
            label12.TabIndex = 56;
            label12.Text = "Bairro";
            // 
            // comboBoxTpEndereco
            // 
            comboBoxTpEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTpEndereco.FormattingEnabled = true;
            comboBoxTpEndereco.Location = new Point(438, 437);
            comboBoxTpEndereco.Name = "comboBoxTpEndereco";
            comboBoxTpEndereco.Size = new Size(153, 29);
            comboBoxTpEndereco.TabIndex = 10;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(438, 400);
            label13.Name = "label13";
            label13.Size = new Size(56, 34);
            label13.TabIndex = 58;
            label13.Text = "Tipo";
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(14, 400);
            label14.Name = "label14";
            label14.Size = new Size(63, 34);
            label14.TabIndex = 55;
            label14.Text = "Rua";
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(219, 707);
            label15.Name = "label15";
            label15.Size = new Size(168, 34);
            label15.TabIndex = 52;
            label15.Text = "Número contato";
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(19, 659);
            label16.Name = "label16";
            label16.Size = new Size(117, 34);
            label16.TabIndex = 50;
            label16.Text = "Contato";
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(19, 707);
            label17.Name = "label17";
            label17.Size = new Size(138, 34);
            label17.TabIndex = 51;
            label17.Text = "Tipo contato";
            // 
            // comboBoxTpContato
            // 
            comboBoxTpContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTpContato.FormattingEnabled = true;
            comboBoxTpContato.Location = new Point(22, 744);
            comboBoxTpContato.Name = "comboBoxTpContato";
            comboBoxTpContato.Size = new Size(176, 29);
            comboBoxTpContato.TabIndex = 14;
            // 
            // textBoxNmrContato
            // 
            textBoxNmrContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNmrContato.Location = new Point(219, 744);
            textBoxNmrContato.Name = "textBoxNmrContato";
            textBoxNmrContato.Size = new Size(206, 29);
            textBoxNmrContato.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(636, 726);
            button1.Name = "button1";
            button1.Size = new Size(199, 51);
            button1.TabIndex = 16;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = false;
            // 
            // labelID
            // 
            labelID.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(12, 35);
            labelID.Name = "labelID";
            labelID.Size = new Size(56, 34);
            labelID.TabIndex = 62;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 9);
            label3.Name = "label3";
            label3.Size = new Size(127, 48);
            label3.TabIndex = 0;
            // 
            // maskedTextBoxDTContratacao
            // 
            maskedTextBoxDTContratacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxDTContratacao.Location = new Point(485, 283);
            maskedTextBoxDTContratacao.Mask = "00/00/0000";
            maskedTextBoxDTContratacao.Name = "maskedTextBoxDTContratacao";
            maskedTextBoxDTContratacao.Size = new Size(102, 29);
            maskedTextBoxDTContratacao.TabIndex = 8;
            maskedTextBoxDTContratacao.ValidatingType = typeof(DateTime);
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(489, 246);
            label18.Name = "label18";
            label18.Size = new Size(206, 34);
            label18.TabIndex = 66;
            label18.Text = "Data de contratação";
            // 
            // comboBoxUsuarios
            // 
            comboBoxUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUsuarios.FormattingEnabled = true;
            comboBoxUsuarios.Location = new Point(451, 127);
            comboBoxUsuarios.Name = "comboBoxUsuarios";
            comboBoxUsuarios.Size = new Size(213, 29);
            comboBoxUsuarios.TabIndex = 2;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(451, 90);
            label8.Name = "label8";
            label8.Size = new Size(96, 34);
            label8.TabIndex = 68;
            label8.Text = "Usuário";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(689, 127);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(146, 29);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(689, 90);
            label9.Name = "label9";
            label9.Size = new Size(80, 34);
            label9.TabIndex = 51;
            label9.Text = "CPF";
            // 
            // AlteraFuncionarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 789);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBoxUsuarios);
            Controls.Add(label18);
            Controls.Add(maskedTextBoxDTContratacao);
            Controls.Add(label3);
            Controls.Add(labelID);
            Controls.Add(button1);
            Controls.Add(textBoxNmrContato);
            Controls.Add(label15);
            Controls.Add(comboBoxTpContato);
            Controls.Add(label7);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(label6);
            Controls.Add(textBoxRua);
            Controls.Add(label13);
            Controls.Add(comboBoxCargos);
            Controls.Add(comboBoxTpEndereco);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(comboBoxEstadoCivil);
            Controls.Add(textBoxBairro);
            Controls.Add(checkBoxFeminino);
            Controls.Add(label11);
            Controls.Add(checkBoxMasculino);
            Controls.Add(maskedTextBoxCEP);
            Controls.Add(textBoxCidade);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(textBoxNomeCompleto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AlteraFuncionarioView";
            Load += AlteraFuncionarioView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        public TextBox textBoxNomeCompleto;
        public CheckBox checkBoxFeminino;
        public CheckBox checkBoxMasculino;
        public ComboBox comboBoxEstadoCivil;
        public ComboBox comboBoxCargos;
        public TextBox textBoxRua;
        public TextBox textBoxCidade;
        public MaskedTextBox maskedTextBoxCEP;
        public TextBox textBoxBairro;
        public ComboBox comboBoxTpEndereco;
        public ComboBox comboBoxTpContato;
        public TextBox textBoxNmrContato;
        public Button button1;
        public Label labelID;
        private Label label3;
        private MaskedTextBox maskedTextBoxDTContratacao;
        private Label label18;
        public ComboBox comboBoxUsuarios;
        private Label label8;
        private MaskedTextBox maskedTextBox1;
        private Label label9;
    }
}