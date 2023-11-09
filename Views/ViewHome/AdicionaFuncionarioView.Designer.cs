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
            textBox1 = new TextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel1 = new Panel();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            label7 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            comboBox3 = new ComboBox();
            label13 = new Label();
            textBox5 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label14 = new Label();
            textBox4 = new TextBox();
            label15 = new Label();
            textBox6 = new TextBox();
            label16 = new Label();
            comboBox4 = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            textBox7 = new TextBox();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(178, 9);
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 23);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(573, 69);
            label3.Name = "label3";
            label3.Size = new Size(56, 34);
            label3.TabIndex = 14;
            label3.Text = "CPF";
            label3.Click += label3_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(573, 106);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(262, 23);
            maskedTextBox1.TabIndex = 15;
            maskedTextBox1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
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
            checkBox1.TabIndex = 17;
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
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Feminino";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 207);
            panel1.TabIndex = 19;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 21;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(271, 268);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 23);
            comboBox2.TabIndex = 23;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(568, 268);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 24;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(592, 231);
            label7.Name = "label7";
            label7.Size = new Size(176, 34);
            label7.TabIndex = 25;
            label7.Text = "Data contratação";
            // 
            // panel2
            // 
            panel2.Location = new Point(2, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 199);
            panel2.TabIndex = 26;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(8, 433);
            label8.Name = "label8";
            label8.Size = new Size(117, 34);
            label8.TabIndex = 27;
            label8.Text = "Endereço";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 525);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 23);
            textBox2.TabIndex = 28;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 488);
            label9.Name = "label9";
            label9.Size = new Size(63, 34);
            label9.TabIndex = 29;
            label9.Text = "Rua";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(14, 573);
            label10.Name = "label10";
            label10.Size = new Size(77, 34);
            label10.TabIndex = 31;
            label10.Text = "Bairro";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 610);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(414, 23);
            textBox3.TabIndex = 30;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(434, 573);
            label11.Name = "label11";
            label11.Size = new Size(65, 34);
            label11.TabIndex = 33;
            label11.Text = "CEP";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(443, 486);
            label12.Name = "label12";
            label12.Size = new Size(56, 34);
            label12.TabIndex = 34;
            label12.Text = "Tipo";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(443, 525);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(153, 23);
            comboBox3.TabIndex = 35;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(615, 488);
            label13.Name = "label13";
            label13.Size = new Size(94, 34);
            label13.TabIndex = 37;
            label13.Text = "Número";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(615, 525);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 23);
            textBox5.TabIndex = 36;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(443, 610);
            maskedTextBox2.Mask = "00000-000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(153, 23);
            maskedTextBox2.TabIndex = 38;
            maskedTextBox2.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(14, 647);
            label14.Name = "label14";
            label14.Size = new Size(77, 34);
            label14.TabIndex = 40;
            label14.Text = "Cidade";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 684);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(414, 23);
            textBox4.TabIndex = 39;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(611, 573);
            label15.Name = "label15";
            label15.Size = new Size(38, 34);
            label15.TabIndex = 42;
            label15.Text = "UF";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(611, 610);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(53, 23);
            textBox6.TabIndex = 41;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(12, 729);
            label16.Name = "label16";
            label16.Size = new Size(117, 34);
            label16.TabIndex = 43;
            label16.Text = "Contato";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(12, 804);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(176, 23);
            comboBox4.TabIndex = 45;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(12, 765);
            label17.Name = "label17";
            label17.Size = new Size(138, 34);
            label17.TabIndex = 44;
            label17.Text = "Tipo contato";
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(210, 767);
            label18.Name = "label18";
            label18.Size = new Size(168, 34);
            label18.TabIndex = 47;
            label18.Text = "Número contato";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(210, 804);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(206, 23);
            textBox7.TabIndex = 46;
            // 
            // panel3
            // 
            panel3.Location = new Point(2, 436);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 404);
            panel3.TabIndex = 48;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(644, 843);
            button1.Name = "button1";
            button1.Size = new Size(199, 51);
            button1.TabIndex = 49;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // AdicionaFuncionarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 896);
            Controls.Add(button1);
            Controls.Add(label18);
            Controls.Add(textBox7);
            Controls.Add(comboBox4);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(textBox6);
            Controls.Add(label14);
            Controls.Add(textBox4);
            Controls.Add(maskedTextBox2);
            Controls.Add(label13);
            Controls.Add(textBox5);
            Controls.Add(comboBox3);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AdicionaFuncionarioView";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel panel1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private ComboBox comboBox2;
        private MonthCalendar monthCalendar1;
        private Label label7;
        private Panel panel2;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
        private Label label11;
        private Label label12;
        private ComboBox comboBox3;
        private Label label13;
        private TextBox textBox5;
        private MaskedTextBox maskedTextBox2;
        private Label label14;
        private TextBox textBox4;
        private Label label15;
        private TextBox textBox6;
        private Label label16;
        private ComboBox comboBox4;
        private Label label17;
        private Label label18;
        private TextBox textBox7;
        private Panel panel3;
        private Button button1;
    }
}