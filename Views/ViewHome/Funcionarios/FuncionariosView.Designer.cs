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
            buttonAtualizar = new Button();
            buttonExcluir = new Button();
            buttonCadastrar = new Button();
            dataGridViewFuncionarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nome_completo = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            buttonAlterar = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAtualizar);
            panel1.Controls.Add(buttonExcluir);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Controls.Add(dataGridViewFuncionarios);
            panel1.Controls.Add(buttonAlterar);
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(1222, 544);
            panel1.TabIndex = 1;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.BackColor = Color.DarkGreen;
            buttonAtualizar.Cursor = Cursors.Hand;
            buttonAtualizar.FlatStyle = FlatStyle.Flat;
            buttonAtualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAtualizar.ForeColor = SystemColors.Control;
            buttonAtualizar.Location = new Point(81, 483);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(166, 56);
            buttonAtualizar.TabIndex = 5;
            buttonAtualizar.Text = "Atualizar tabela";
            buttonAtualizar.UseVisualStyleBackColor = false;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Brown;
            buttonExcluir.Cursor = Cursors.Hand;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = SystemColors.Control;
            buttonExcluir.Location = new Point(265, 87);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(166, 56);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.DarkGreen;
            buttonCadastrar.Cursor = Cursors.Hand;
            buttonCadastrar.FlatStyle = FlatStyle.Flat;
            buttonCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrar.ForeColor = SystemColors.Control;
            buttonCadastrar.Location = new Point(987, 87);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(166, 56);
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
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
            // buttonAlterar
            // 
            buttonAlterar.BackColor = Color.Goldenrod;
            buttonAlterar.Cursor = Cursors.Hand;
            buttonAlterar.FlatStyle = FlatStyle.Flat;
            buttonAlterar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAlterar.ForeColor = SystemColors.Control;
            buttonAlterar.Location = new Point(83, 87);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(166, 56);
            buttonAlterar.TabIndex = 4;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            buttonAlterar.Click += buttonAlterar_Click;
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
        private Button buttonAlterar;
        public Button buttonCadastrar;
        public Button buttonExcluir;
        public DataGridView dataGridViewFuncionarios;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nome_completo;
        private DataGridViewTextBoxColumn departamento;
        private Button buttonAtualizar;
    }
}