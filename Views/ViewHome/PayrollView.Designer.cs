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
            panel1 = new Panel();
            label3 = new Label();
            textBoxDepto = new TextBox();
            label2 = new Label();
            textBoxSalario = new TextBox();
            label1 = new Label();
            textBoxCargo = new TextBox();
            comboBoxFuncionarios = new ComboBox();
            buttonAtualizarDetalhes = new Button();
            buttonAdicionar = new Button();
            dataGridViewDescontos = new DataGridView();
            label4 = new Label();
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
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(448, 45);
            label3.Name = "label3";
            label3.Size = new Size(144, 35);
            label3.TabIndex = 6;
            label3.Text = "Departamento";
            // 
            // textBoxDepto
            // 
            textBoxDepto.Location = new Point(448, 83);
            textBoxDepto.Name = "textBoxDepto";
            textBoxDepto.Size = new Size(352, 23);
            textBoxDepto.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(448, 128);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 4;
            label2.Text = "Salário";
            // 
            // textBoxSalario
            // 
            textBoxSalario.Location = new Point(448, 166);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(352, 23);
            textBoxSalario.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 128);
            label1.Name = "label1";
            label1.Size = new Size(100, 35);
            label1.TabIndex = 2;
            label1.Text = "Cargo";
            // 
            // textBoxCargo
            // 
            textBoxCargo.Location = new Point(36, 166);
            textBoxCargo.Name = "textBoxCargo";
            textBoxCargo.Size = new Size(352, 23);
            textBoxCargo.TabIndex = 1;
            // 
            // comboBoxFuncionarios
            // 
            comboBoxFuncionarios.FormattingEnabled = true;
            comboBoxFuncionarios.Location = new Point(36, 73);
            comboBoxFuncionarios.Name = "comboBoxFuncionarios";
            comboBoxFuncionarios.Size = new Size(352, 23);
            comboBoxFuncionarios.TabIndex = 0;
            comboBoxFuncionarios.SelectedIndexChanged += comboBoxFuncionarios_SelectedIndexChanged;
            // 
            // buttonAtualizarDetalhes
            // 
            buttonAtualizarDetalhes.Location = new Point(36, 577);
            buttonAtualizarDetalhes.Name = "buttonAtualizarDetalhes";
            buttonAtualizarDetalhes.Size = new Size(146, 43);
            buttonAtualizarDetalhes.TabIndex = 2;
            buttonAtualizarDetalhes.Text = "button1";
            buttonAtualizarDetalhes.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(769, 247);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(146, 43);
            buttonAdicionar.TabIndex = 3;
            buttonAdicionar.Text = "button1";
            buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDescontos
            // 
            dataGridViewDescontos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDescontos.Location = new Point(36, 296);
            dataGridViewDescontos.Name = "dataGridViewDescontos";
            dataGridViewDescontos.RowTemplate.Height = 25;
            dataGridViewDescontos.Size = new Size(879, 275);
            dataGridViewDescontos.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.OliveDrab;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(238, 46);
            label4.TabIndex = 7;
            label4.Text = "Geração de folha";
            // 
            // PayrollView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1147, 657);
            Controls.Add(dataGridViewDescontos);
            Controls.Add(buttonAdicionar);
            Controls.Add(buttonAtualizarDetalhes);
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
        private TextBox textBoxCargo;
        private ComboBox comboBoxFuncionarios;
        private Label label3;
        private TextBox textBoxDepto;
        private Label label2;
        private TextBox textBoxSalario;
        private Button buttonAtualizarDetalhes;
        private Button buttonAdicionar;
        private DataGridView dataGridViewDescontos;
        private Label label4;
    }
}