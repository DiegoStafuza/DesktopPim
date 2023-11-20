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
            buttonAdicionar = new Button();
            dataGridViewDescontos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            button1 = new Button();
            labelValorLiquido = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDescontos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 274);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(38, 67);
            label7.Name = "label7";
            label7.Size = new Size(115, 35);
            label7.TabIndex = 12;
            label7.Text = "Funcionário";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(868, 66);
            label6.Name = "label6";
            label6.Size = new Size(73, 35);
            label6.TabIndex = 11;
            label6.Text = "Mês";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(868, 159);
            label5.Name = "label5";
            label5.Size = new Size(73, 35);
            label5.TabIndex = 10;
            label5.Text = "Ano";
            // 
            // comboBoxAno
            // 
            comboBoxAno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAno.FormattingEnabled = true;
            comboBoxAno.Location = new Point(868, 197);
            comboBoxAno.Name = "comboBoxAno";
            comboBoxAno.Size = new Size(214, 33);
            comboBoxAno.TabIndex = 9;
            // 
            // comboBoxMes
            // 
            comboBoxMes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Location = new Point(868, 105);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(214, 33);
            comboBoxMes.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OliveDrab;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(268, 46);
            label4.TabIndex = 7;
            label4.Text = "Geração de folha";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(448, 66);
            label3.Name = "label3";
            label3.Size = new Size(144, 36);
            label3.TabIndex = 6;
            label3.Text = "Departamento";
            // 
            // textBoxDepto
            // 
            textBoxDepto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDepto.Location = new Point(448, 105);
            textBoxDepto.Name = "textBoxDepto";
            textBoxDepto.Size = new Size(352, 33);
            textBoxDepto.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(448, 160);
            label2.Name = "label2";
            label2.Size = new Size(73, 35);
            label2.TabIndex = 4;
            label2.Text = "Salário";
            // 
            // textBoxSalario
            // 
            textBoxSalario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSalario.Location = new Point(448, 197);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(352, 33);
            textBoxSalario.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 160);
            label1.Name = "label1";
            label1.Size = new Size(65, 35);
            label1.TabIndex = 2;
            label1.Text = "Cargo";
            // 
            // textBoxCargo
            // 
            textBoxCargo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCargo.Location = new Point(36, 198);
            textBoxCargo.Name = "textBoxCargo";
            textBoxCargo.Size = new Size(352, 33);
            textBoxCargo.TabIndex = 1;
            // 
            // comboBoxFuncionarios
            // 
            comboBoxFuncionarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFuncionarios.FormattingEnabled = true;
            comboBoxFuncionarios.Location = new Point(36, 105);
            comboBoxFuncionarios.Name = "comboBoxFuncionarios";
            comboBoxFuncionarios.Size = new Size(352, 33);
            comboBoxFuncionarios.TabIndex = 0;
            comboBoxFuncionarios.SelectedIndexChanged += comboBoxFuncionarios_SelectedIndexChanged;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.DarkGreen;
            buttonAdicionar.BackgroundImage = (Image)resources.GetObject("buttonAdicionar.BackgroundImage");
            buttonAdicionar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdicionar.Cursor = Cursors.Hand;
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionar.ForeColor = SystemColors.Control;
            buttonAdicionar.Location = new Point(898, 280);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(146, 43);
            buttonAdicionar.TabIndex = 3;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // dataGridViewDescontos
            // 
            dataGridViewDescontos.AllowUserToAddRows = false;
            dataGridViewDescontos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDescontos.BackgroundColor = SystemColors.Control;
            dataGridViewDescontos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewDescontos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDescontos.Columns.AddRange(new DataGridViewColumn[] { ID, Tipo, Nome, Valor });
            dataGridViewDescontos.Location = new Point(36, 329);
            dataGridViewDescontos.MultiSelect = false;
            dataGridViewDescontos.Name = "dataGridViewDescontos";
            dataGridViewDescontos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDescontos.RowTemplate.Height = 25;
            dataGridViewDescontos.Size = new Size(1008, 275);
            dataGridViewDescontos.TabIndex = 4;
            dataGridViewDescontos.CellFormatting += dataGridViewDescontos_CellFormatting;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(38, 607);
            button1.Name = "button1";
            button1.Size = new Size(146, 43);
            button1.TabIndex = 5;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            // 
            // labelValorLiquido
            // 
            labelValorLiquido.BackColor = SystemColors.ActiveBorder;
            labelValorLiquido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorLiquido.Location = new Point(799, 610);
            labelValorLiquido.Name = "labelValorLiquido";
            labelValorLiquido.Size = new Size(245, 40);
            labelValorLiquido.TabIndex = 0;
            labelValorLiquido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PayrollView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1147, 657);
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
    }
}