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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonAtualizar = new Button();
            buttonExcluir = new Button();
            buttonCadastrar = new Button();
            dataGridViewFuncionarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nome_completo = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            buttonAlterar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.BackColor = Color.DarkGreen;
            buttonAtualizar.Cursor = Cursors.Hand;
            buttonAtualizar.FlatStyle = FlatStyle.Flat;
            buttonAtualizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAtualizar.ForeColor = SystemColors.Control;
            buttonAtualizar.Location = new Point(132, 462);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(181, 66);
            buttonAtualizar.TabIndex = 5;
            buttonAtualizar.Text = "Atualizar tabela";
            buttonAtualizar.UseVisualStyleBackColor = false;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.FromArgb(174, 13, 13);
            buttonExcluir.Cursor = Cursors.Hand;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = SystemColors.Control;
            buttonExcluir.Location = new Point(330, 10);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(181, 66);
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
            buttonCadastrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrar.ForeColor = SystemColors.Control;
            buttonCadastrar.Location = new Point(1238, 10);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(181, 66);
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.AllowUserToAddRows = false;
            dataGridViewFuncionarios.AllowUserToDeleteRows = false;
            dataGridViewFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFuncionarios.BackgroundColor = SystemColors.Control;
            dataGridViewFuncionarios.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewFuncionarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Columns.AddRange(new DataGridViewColumn[] { ID, nome_completo, departamento });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewFuncionarios.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewFuncionarios.Location = new Point(132, 82);
            dataGridViewFuncionarios.MultiSelect = false;
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.ReadOnly = true;
            dataGridViewFuncionarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewFuncionarios.RowTemplate.Height = 30;
            dataGridViewFuncionarios.Size = new Size(1287, 374);
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
            buttonAlterar.BackColor = Color.FromArgb(215, 190, 57);
            buttonAlterar.Cursor = Cursors.Hand;
            buttonAlterar.FlatStyle = FlatStyle.Flat;
            buttonAlterar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAlterar.ForeColor = SystemColors.Control;
            buttonAlterar.Location = new Point(132, 10);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(181, 66);
            buttonAlterar.TabIndex = 4;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(4, 120, 87);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 56);
            label1.TabIndex = 3;
            label1.Text = "Funcionários";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewFuncionarios);
            panel1.Controls.Add(buttonAtualizar);
            panel1.Controls.Add(buttonAlterar);
            panel1.Controls.Add(buttonExcluir);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Location = new Point(2, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(1570, 598);
            panel1.TabIndex = 6;
            // 
            // FuncionariosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1573, 877);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FuncionariosView";
            Text = "FuncionariosView";
            Load += FuncionariosView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button buttonAlterar;
        public Button buttonCadastrar;
        public Button buttonExcluir;
        public DataGridView dataGridViewFuncionarios;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nome_completo;
        private DataGridViewTextBoxColumn departamento;
        private Button buttonAtualizar;
        private Panel panel1;
    }
}