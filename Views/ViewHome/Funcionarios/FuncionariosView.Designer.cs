namespace DesktopPim.Views.ViewHome
{
    partial class FuncionariosView
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
            panel1 = new Panel();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridViewFuncionarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nome_completo = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            button3 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridViewFuncionarios);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(1222, 544);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGreen;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(81, 483);
            button4.Name = "button4";
            button4.Size = new Size(166, 56);
            button4.TabIndex = 5;
            button4.Text = "Atualizar tabela";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(265, 87);
            button2.Name = "button2";
            button2.Size = new Size(166, 56);
            button2.TabIndex = 3;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(987, 87);
            button1.Name = "button1";
            button1.Size = new Size(166, 56);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.AllowUserToAddRows = false;
            dataGridViewFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFuncionarios.BackgroundColor = SystemColors.Control;
            dataGridViewFuncionarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Columns.AddRange(new DataGridViewColumn[] { ID, nome_completo, departamento });
            dataGridViewFuncionarios.Location = new Point(81, 154);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.ReadOnly = true;
            dataGridViewFuncionarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewFuncionarios.RowTemplate.Height = 25;
            dataGridViewFuncionarios.Size = new Size(1070, 323);
            dataGridViewFuncionarios.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "id_funcionario";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // nome_completo
            // 
            nome_completo.DataPropertyName = "nome_completo";
            nome_completo.HeaderText = "Nome completo";
            nome_completo.Name = "nome_completo";
            nome_completo.ReadOnly = true;
            // 
            // departamento
            // 
            departamento.DataPropertyName = "deparamento";
            departamento.HeaderText = "Departamento";
            departamento.Name = "departamento";
            departamento.ReadOnly = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(83, 87);
            button3.Name = "button3";
            button3.Size = new Size(166, 56);
            button3.TabIndex = 4;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 42);
            label1.TabIndex = 3;
            label1.Text = "Funcionários";
            // 
            // panel3
            // 
            panel3.Location = new Point(14, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1208, 39);
            panel3.TabIndex = 4;
            // 
            // FuncionariosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1223, 602);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FuncionariosView";
            Text = "FuncionariosView";
            Load += FuncionariosView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Button button3;
        public Button button1;
        public Button button2;
        public DataGridView dataGridViewFuncionarios;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nome_completo;
        private DataGridViewTextBoxColumn departamento;
        private Button button4;
    }
}