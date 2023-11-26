namespace DesktopPim.Views
{
    partial class PayrollView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollView));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBoxAno = new ComboBox();
            comboBoxMes = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            textBoxDepto = new TextBox();
            label2 = new Label();
            textBoxSalario = new TextBox();
            label1 = new Label();
            textBoxCargo = new TextBox();
            comboBoxFuncionarios = new ComboBox();
            textDataContratacao = new TextBox();
            buttonAdicionar = new Button();
            dataGridViewDescontos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            button1 = new Button();
            labelValorLiquido = new Label();
            button2 = new Button();
            textBoxDataContratacao = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDescontos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxDataContratacao);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBoxAno);
            panel1.Controls.Add(comboBoxMes);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxDepto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxSalario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxCargo);
            panel1.Controls.Add(comboBoxFuncionarios);
            panel1.Controls.Add(textDataContratacao);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1573, 274);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(134, 81);
            label7.Name = "label7";
            label7.Size = new Size(197, 35);
            label7.TabIndex = 12;
            label7.Text = "Funcionário";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1085, 79);
            label6.Name = "label6";
            label6.Size = new Size(195, 35);
            label6.TabIndex = 11;
            label6.Text = "Mês";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1085, 172);
            label5.Name = "label5";
            label5.Size = new Size(195, 35);
            label5.TabIndex = 10;
            label5.Text = "Ano";
            // 
            // comboBoxAno
            // 
            comboBoxAno.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAno.FormattingEnabled = true;
            comboBoxAno.Location = new Point(1085, 210);
            comboBoxAno.Name = "comboBoxAno";
            comboBoxAno.Size = new Size(336, 40);
            comboBoxAno.TabIndex = 9;
            // 
            // comboBoxMes
            // 
            comboBoxMes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Location = new Point(1085, 118);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(336, 40);
            comboBoxMes.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(4, 120, 87);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(337, 54);
            label4.TabIndex = 7;
            label4.Text = "Geração de folha";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(610, 80);
            label3.Name = "label3";
            label3.Size = new Size(226, 36);
            label3.TabIndex = 6;
            label3.Text = "Departamento";
            // 
            // textBoxDepto
            // 
            textBoxDepto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDepto.Location = new Point(610, 119);
            textBoxDepto.Name = "textBoxDepto";
            textBoxDepto.Size = new Size(422, 39);
            textBoxDepto.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(610, 174);
            label2.Name = "label2";
            label2.Size = new Size(151, 35);
            label2.TabIndex = 4;
            label2.Text = "Salário";
            // 
            // textBoxSalario
            // 
            textBoxSalario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSalario.Location = new Point(610, 211);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(422, 39);
            textBoxSalario.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(132, 174);
            label1.Name = "label1";
            label1.Size = new Size(152, 35);
            label1.TabIndex = 2;
            label1.Text = "Cargo";
            // 
            // textBoxCargo
            // 
            textBoxCargo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCargo.Location = new Point(132, 212);
            textBoxCargo.Name = "textBoxCargo";
            textBoxCargo.Size = new Size(421, 39);
            textBoxCargo.TabIndex = 1;
            // 
            // comboBoxFuncionarios
            // 
            comboBoxFuncionarios.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFuncionarios.FormattingEnabled = true;
            comboBoxFuncionarios.Location = new Point(132, 119);
            comboBoxFuncionarios.Name = "comboBoxFuncionarios";
            comboBoxFuncionarios.Size = new Size(421, 40);
            comboBoxFuncionarios.TabIndex = 0;
            comboBoxFuncionarios.SelectedIndexChanged += comboBoxFuncionarios_SelectedIndexChanged;
            // 
            // textDataContratacao
            // 
            textDataContratacao.BackColor = SystemColors.ActiveCaptionText;
            textDataContratacao.BorderStyle = BorderStyle.None;
            textDataContratacao.Enabled = false;
            textDataContratacao.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            textDataContratacao.ForeColor = SystemColors.ActiveBorder;
            textDataContratacao.Location = new Point(428, 38);
            textDataContratacao.Name = "textDataContratacao";
            textDataContratacao.Size = new Size(315, 2);
            textDataContratacao.TabIndex = 13;
            textDataContratacao.Visible = false;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.DarkGreen;
            buttonAdicionar.BackgroundImage = (Image)resources.GetObject("buttonAdicionar.BackgroundImage");
            buttonAdicionar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdicionar.Cursor = Cursors.Hand;
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionar.ForeColor = SystemColors.Control;
            buttonAdicionar.Location = new Point(1240, 291);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(181, 66);
            buttonAdicionar.TabIndex = 3;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // dataGridViewDescontos
            // 
            dataGridViewDescontos.AllowUserToAddRows = false;
            dataGridViewDescontos.AllowUserToDeleteRows = false;
            dataGridViewDescontos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDescontos.BackgroundColor = SystemColors.Control;
            dataGridViewDescontos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewDescontos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDescontos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDescontos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDescontos.Columns.AddRange(new DataGridViewColumn[] { ID, Tipo, Nome, Valor });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewDescontos.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewDescontos.Location = new Point(134, 363);
            dataGridViewDescontos.MultiSelect = false;
            dataGridViewDescontos.Name = "dataGridViewDescontos";
            dataGridViewDescontos.ReadOnly = true;
            dataGridViewDescontos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDescontos.RowTemplate.Height = 30;
            dataGridViewDescontos.Size = new Size(1287, 374);
            dataGridViewDescontos.TabIndex = 4;
            dataGridViewDescontos.CellFormatting += dataGridViewDescontos_CellFormatting;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(134, 743);
            button1.Name = "button1";
            button1.Size = new Size(181, 66);
            button1.TabIndex = 5;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelValorLiquido
            // 
            labelValorLiquido.AutoEllipsis = true;
            labelValorLiquido.BackColor = SystemColors.ActiveBorder;
            labelValorLiquido.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorLiquido.Location = new Point(962, 743);
            labelValorLiquido.Name = "labelValorLiquido";
            labelValorLiquido.Size = new Size(459, 69);
            labelValorLiquido.TabIndex = 0;
            labelValorLiquido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(337, 743);
            button2.Name = "button2";
            button2.Size = new Size(181, 66);
            button2.TabIndex = 6;
            button2.Text = "Gerar PDF";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBoxDataContratacao
            // 
            textBoxDataContratacao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDataContratacao.Location = new Point(610, 9);
            textBoxDataContratacao.Name = "textBoxDataContratacao";
            textBoxDataContratacao.Size = new Size(421, 39);
            textBoxDataContratacao.TabIndex = 13;
            textBoxDataContratacao.Visible = false;
            // 
            // PayrollView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1573, 877);
            Controls.Add(button2);
            Controls.Add(labelValorLiquido);
            Controls.Add(button1);
            Controls.Add(dataGridViewDescontos);
            Controls.Add(buttonAdicionar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PayrollView";
            Text = "PayrollView";
            Load += PayrollView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDescontos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button buttonAdicionar;
        private Label label4;
        public TextBox textBoxCargo;
        public ComboBox comboBoxFuncionarios;
        public TextBox textBoxDepto;
        public TextBox textBoxSalario;
        public DataGridView dataGridViewDescontos;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Valor;
        private Label label6;
        private Label label5;
        public ComboBox comboBoxMes;
        public ComboBox comboBoxAno;
        public Label labelValorLiquido;
        private Label label7;
        private Button button2;
        private TextBox textDataContratacao;
        private Label LabelDataContratacao;
        private TextBox textBoxDataContratacao;
    }
}