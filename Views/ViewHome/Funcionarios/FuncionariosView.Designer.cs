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
            dataGridViewFuncionarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nome_completo = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.AllowUserToAddRows = false;
            dataGridViewFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFuncionarios.BackgroundColor = SystemColors.Control;
            dataGridViewFuncionarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Columns.AddRange(new DataGridViewColumn[] { ID, nome_completo, departamento });
            dataGridViewFuncionarios.Dock = DockStyle.Fill;
            dataGridViewFuncionarios.Location = new Point(0, 0);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.ReadOnly = true;
            dataGridViewFuncionarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewFuncionarios.RowTemplate.Height = 25;
            dataGridViewFuncionarios.Size = new Size(872, 257);
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
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 418);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewFuncionarios);
            panel2.Location = new Point(129, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(872, 257);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(982, 56);
            button1.Name = "button1";
            button1.Size = new Size(142, 41);
            button1.TabIndex = 2;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(14, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1127, 100);
            panel3.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(659, 56);
            button3.Name = "button3";
            button3.Size = new Size(142, 41);
            button3.TabIndex = 4;
            button3.Text = "ALTERAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(822, 56);
            button2.Name = "button2";
            button2.Size = new Size(142, 41);
            button2.TabIndex = 3;
            button2.Text = "EXCLUIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FuncionariosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1153, 567);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FuncionariosView";
            Text = "FuncionariosView";
            Load += FuncionariosView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nome_completo;
        private DataGridViewTextBoxColumn departamento;
        public DataGridView dataGridViewFuncionarios;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        public Button button1;
        public Button button2;
    }
}