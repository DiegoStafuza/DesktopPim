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
            panel1.Size = new Size(1147, 211);
            panel1.TabIndex = 0;
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
            label3.Location = new Point(448, 34);
            label3.Name = "label3";
            label3.Size = new Size(144, 36);
            label3.TabIndex = 6;
            label3.Text = "Departamento";
            // 
            // textBoxDepto
            // 
            textBoxDepto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDepto.Location = new Point(448, 73);
            textBoxDepto.Name = "textBoxDepto";
            textBoxDepto.Size = new Size(352, 33);
            textBoxDepto.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(448, 128);
            label2.Name = "label2";
            label2.Size = new Size(73, 35);
            label2.TabIndex = 4;
            label2.Text = "Salário";
            // 
            // textBoxSalario
            // 
            textBoxSalario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSalario.Location = new Point(448, 165);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(352, 33);
            textBoxSalario.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 128);
            label1.Name = "label1";
            label1.Size = new Size(65, 35);
            label1.TabIndex = 2;
            label1.Text = "Cargo";
            // 
            // textBoxCargo
            // 
            textBoxCargo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCargo.Location = new Point(36, 166);
            textBoxCargo.Name = "textBoxCargo";
            textBoxCargo.Size = new Size(352, 33);
            textBoxCargo.TabIndex = 1;
            // 
            // comboBoxFuncionarios
            // 
            comboBoxFuncionarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFuncionarios.FormattingEnabled = true;
            comboBoxFuncionarios.Location = new Point(36, 73);
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
            buttonAdicionar.Location = new Point(769, 247);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(146, 43);
            buttonAdicionar.TabIndex = 3;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDescontos
            // 
            dataGridViewDescontos.AllowUserToAddRows = false;
            dataGridViewDescontos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDescontos.BackgroundColor = SystemColors.Control;
            dataGridViewDescontos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewDescontos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDescontos.Columns.AddRange(new DataGridViewColumn[] { ID, Tipo, Nome, Valor });
            dataGridViewDescontos.Location = new Point(36, 296);
            dataGridViewDescontos.Name = "dataGridViewDescontos";
            dataGridViewDescontos.ReadOnly = true;
            dataGridViewDescontos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDescontos.RowTemplate.Height = 25;
            dataGridViewDescontos.Size = new Size(879, 275);
            dataGridViewDescontos.TabIndex = 4;
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
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(769, 577);
            button1.Name = "button1";
            button1.Size = new Size(146, 43);
            button1.TabIndex = 5;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            // 
            // labelValorLiquido
            // 
            labelValorLiquido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorLiquido.Location = new Point(38, 594);
            labelValorLiquido.Name = "labelValorLiquido";
            labelValorLiquido.Size = new Size(266, 23);
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
        private Label labelValorLiquido;
    }
}