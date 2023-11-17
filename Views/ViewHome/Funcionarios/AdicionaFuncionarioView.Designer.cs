namespace DesktopPim.Views.ViewHome
{
    partial class AdicionaFuncionarioView
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
            label2 = new Label();
            textBoxNomeCompleto = new TextBox();
            label3 = new Label();
            maskedTextCPF = new MaskedTextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            comboBoxEstadoCivil = new ComboBox();
            label6 = new Label();
            comboBoxCargos = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            panel2 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label13 = new Label();
            textBox5 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            textBox4 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label16 = new Label();
            label11 = new Label();
            label17 = new Label();
            textBox3 = new TextBox();
            comboBoxTpContato = new ComboBox();
            label10 = new Label();
            comboBoxTpEndereco = new ComboBox();
            label18 = new Label();
            textBox7 = new TextBox();
            textBox2 = new TextBox();
            buttonCadastrarFunc = new Button();
            panel3 = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(418, 60);
            label1.TabIndex = 12;
            label1.Text = "Cadastro de funcionário";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(180, 34);
            label2.TabIndex = 12;
            label2.Text = "Nome completo";
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomeCompleto.Location = new Point(12, 104);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.Size = new Size(414, 29);
            textBoxNomeCompleto.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(571, 60);
            label3.Name = "label3";
            label3.Size = new Size(56, 34);
            label3.TabIndex = 14;
            label3.Text = "CPF";
            // 
            // maskedTextCPF
            // 
            maskedTextCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextCPF.Location = new Point(573, 104);
            maskedTextCPF.Mask = "000,000,000-00";
            maskedTextCPF.Name = "maskedTextCPF";
            maskedTextCPF.Size = new Size(262, 29);
            maskedTextCPF.TabIndex = 2;
            maskedTextCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 135);
            label4.Name = "label4";
            label4.Size = new Size(63, 34);
            label4.TabIndex = 16;
            label4.Text = "Sexo";
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(12, 169);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 35);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Masculino";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(139, 169);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(109, 35);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Feminino";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(2, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 207);
            panel1.TabIndex = 19;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(590, 158);
            label7.Name = "label7";
            label7.Size = new Size(176, 34);
            label7.TabIndex = 25;
            label7.Text = "Data contratação";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 231);
            label5.Name = "label5";
            label5.Size = new Size(117, 34);
            label5.TabIndex = 20;
            label5.Text = "Estado civil";
            // 
            // comboBoxEstadoCivil
            // 
            comboBoxEstadoCivil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEstadoCivil.FormattingEnabled = true;
            comboBoxEstadoCivil.Location = new Point(12, 268);
            comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            comboBoxEstadoCivil.Size = new Size(153, 29);
            comboBoxEstadoCivil.TabIndex = 3;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(271, 231);
            label6.Name = "label6";
            label6.Size = new Size(76, 34);
            label6.TabIndex = 22;
            label6.Text = "Cargo";
            // 
            // comboBoxCargos
            // 
            comboBoxCargos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCargos.FormattingEnabled = true;
            comboBoxCargos.Location = new Point(271, 268);
            comboBoxCargos.Name = "comboBoxCargos";
            comboBoxCargos.Size = new Size(228, 29);
            comboBoxCargos.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(568, 219);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Location = new Point(2, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 150);
            panel2.TabIndex = 26;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(8, 105);
            label8.Name = "label8";
            label8.Size = new Size(117, 34);
            label8.TabIndex = 27;
            label8.Text = "Endereço";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(8, 17);
            label9.Name = "label9";
            label9.Size = new Size(63, 34);
            label9.TabIndex = 29;
            label9.Text = "Rua";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(432, 17);
            label12.Name = "label12";
            label12.Size = new Size(56, 34);
            label12.TabIndex = 34;
            label12.Text = "Tipo";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(590, 99);
            label13.Name = "label13";
            label13.Size = new Size(94, 34);
            label13.TabIndex = 37;
            label13.Text = "Número";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(589, 136);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 29);
            textBox5.TabIndex = 10;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(435, 192);
            label15.Name = "label15";
            label15.Size = new Size(38, 34);
            label15.TabIndex = 42;
            label15.Text = "UF";
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(8, 192);
            label14.Name = "label14";
            label14.Size = new Size(77, 34);
            label14.TabIndex = 40;
            label14.Text = "Cidade";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(12, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(414, 29);
            textBox4.TabIndex = 11;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox2.Location = new Point(430, 136);
            maskedTextBox2.Mask = "00000-000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(153, 29);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(8, 271);
            label16.Name = "label16";
            label16.Size = new Size(117, 34);
            label16.TabIndex = 43;
            label16.Text = "Contato";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(430, 99);
            label11.Name = "label11";
            label11.Size = new Size(65, 34);
            label11.TabIndex = 33;
            label11.Text = "CEP";
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(8, 319);
            label17.Name = "label17";
            label17.Size = new Size(138, 34);
            label17.TabIndex = 44;
            label17.Text = "Tipo contato";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(10, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(414, 29);
            textBox3.TabIndex = 8;
            // 
            // comboBoxTpContato
            // 
            comboBoxTpContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTpContato.FormattingEnabled = true;
            comboBoxTpContato.Location = new Point(11, 356);
            comboBoxTpContato.Name = "comboBoxTpContato";
            comboBoxTpContato.Size = new Size(176, 29);
            comboBoxTpContato.TabIndex = 13;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(8, 99);
            label10.Name = "label10";
            label10.Size = new Size(77, 34);
            label10.TabIndex = 31;
            label10.Text = "Bairro";
            // 
            // comboBoxTpEndereco
            // 
            comboBoxTpEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTpEndereco.FormattingEnabled = true;
            comboBoxTpEndereco.Location = new Point(432, 54);
            comboBoxTpEndereco.Name = "comboBoxTpEndereco";
            comboBoxTpEndereco.Size = new Size(153, 29);
            comboBoxTpEndereco.TabIndex = 7;
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(208, 319);
            label18.Name = "label18";
            label18.Size = new Size(168, 34);
            label18.TabIndex = 47;
            label18.Text = "Número contato";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(208, 356);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(206, 29);
            textBox7.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(10, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 29);
            textBox2.TabIndex = 6;
            // 
            // buttonCadastrarFunc
            // 
            buttonCadastrarFunc.BackColor = Color.OliveDrab;
            buttonCadastrarFunc.FlatStyle = FlatStyle.Flat;
            buttonCadastrarFunc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrarFunc.ForeColor = SystemColors.Control;
            buttonCadastrarFunc.Location = new Point(634, 334);
            buttonCadastrarFunc.Name = "buttonCadastrarFunc";
            buttonCadastrarFunc.Size = new Size(199, 51);
            buttonCadastrarFunc.TabIndex = 15;
            buttonCadastrarFunc.Text = "Cadastrar";
            buttonCadastrarFunc.UseVisualStyleBackColor = false;
            buttonCadastrarFunc.Click += buttonCadastrarFunc_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(maskedTextBox1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(buttonCadastrarFunc);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(comboBoxTpEndereco);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(comboBoxTpContato);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(maskedTextBox2);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(2, 381);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 396);
            panel3.TabIndex = 48;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(435, 229);
            maskedTextBox1.Mask = "AA";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(53, 29);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            // 
            // AdicionaFuncionarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 789);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBoxCargos);
            Controls.Add(label6);
            Controls.Add(comboBoxEstadoCivil);
            Controls.Add(label5);
            Controls.Add(maskedTextCPF);
            Controls.Add(label2);
            Controls.Add(textBoxNomeCompleto);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AdicionaFuncionarioView";
            Load += AdicionaFuncionarioView_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private Label label12;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label13;
        private Label label15;
        private Label label14;
        private Label label16;
        private Label label11;
        private Label label17;
        private Label label10;
        private Label label18;
        private Panel panel3;
        public ComboBox comboBoxCargos;
        public ComboBox comboBoxEstadoCivil;
        public ComboBox comboBoxTpContato;
        public ComboBox comboBoxTpEndereco;
        public TextBox textBoxNomeCompleto;
        public MaskedTextBox maskedTextCPF;
        public CheckBox checkBox1;
        public CheckBox checkBox2;
        public MonthCalendar monthCalendar1;
        public TextBox textBox5;
        public TextBox textBox4;
        public MaskedTextBox maskedTextBox2;
        public TextBox textBox3;
        public TextBox textBox7;
        public TextBox textBox2;
        public Button buttonCadastrarFunc;
        public MaskedTextBox maskedTextBox1;
    }
}