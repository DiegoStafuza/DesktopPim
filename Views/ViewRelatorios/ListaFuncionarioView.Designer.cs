namespace DesktopPim.Views.ViewDuvidas
{
    partial class ListaFuncionarioView
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
            comboBoxAno = new ComboBox();
            dataGridViewDados = new DataGridView();
            Mês = new DataGridViewTextBoxColumn();
            Ano = new DataGridViewTextBoxColumn();
            total_proventos = new DataGridViewTextBoxColumn();
            total_descontos = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            comboBoxFuncionarios = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            buttonGeraPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxAno
            // 
            comboBoxAno.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAno.FormattingEnabled = true;
            comboBoxAno.Location = new Point(975, 156);
            comboBoxAno.Name = "comboBoxAno";
            comboBoxAno.Size = new Size(221, 40);
            comboBoxAno.TabIndex = 1;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToAddRows = false;
            dataGridViewDados.AllowUserToDeleteRows = false;
            dataGridViewDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDados.BackgroundColor = SystemColors.Control;
            dataGridViewDados.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Columns.AddRange(new DataGridViewColumn[] { Mês, Ano, total_proventos, total_descontos, Valor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewDados.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDados.Location = new Point(132, 82);
            dataGridViewDados.MultiSelect = false;
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.ReadOnly = true;
            dataGridViewDados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(1063, 374);
            dataGridViewDados.TabIndex = 2;
            // 
            // Mês
            // 
            Mês.HeaderText = "Mês";
            Mês.Name = "Mês";
            Mês.ReadOnly = true;
            // 
            // Ano
            // 
            Ano.HeaderText = "Ano";
            Ano.Name = "Ano";
            Ano.ReadOnly = true;
            // 
            // total_proventos
            // 
            total_proventos.HeaderText = "Total proventos";
            total_proventos.Name = "total_proventos";
            total_proventos.ReadOnly = true;
            // 
            // total_descontos
            // 
            total_descontos.HeaderText = "Total descontos";
            total_descontos.Name = "total_descontos";
            total_descontos.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor líquido";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // comboBoxFuncionarios
            // 
            comboBoxFuncionarios.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFuncionarios.FormattingEnabled = true;
            comboBoxFuncionarios.Location = new Point(133, 156);
            comboBoxFuncionarios.Name = "comboBoxFuncionarios";
            comboBoxFuncionarios.Size = new Size(440, 40);
            comboBoxFuncionarios.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(945, 10);
            button1.Name = "button1";
            button1.Size = new Size(250, 66);
            button1.TabIndex = 4;
            button1.Text = "Buscar pagamentos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonBuscar_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(buttonGeraPDF);
            panel1.Controls.Add(dataGridViewDados);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(2, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(1570, 598);
            panel1.TabIndex = 15;
            // 
            // buttonGeraPDF
            // 
            buttonGeraPDF.BackColor = Color.FromArgb(128, 128, 255);
            buttonGeraPDF.BackgroundImageLayout = ImageLayout.Stretch;
            buttonGeraPDF.Cursor = Cursors.Hand;
            buttonGeraPDF.FlatStyle = FlatStyle.Flat;
            buttonGeraPDF.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGeraPDF.ForeColor = SystemColors.Control;
            buttonGeraPDF.Location = new Point(132, 471);
            buttonGeraPDF.Name = "buttonGeraPDF";
            buttonGeraPDF.Size = new Size(181, 66);
            buttonGeraPDF.TabIndex = 7;
            buttonGeraPDF.Text = "Gerar PDF";
            buttonGeraPDF.UseVisualStyleBackColor = false;
            buttonGeraPDF.Click += buttonGeraPDF_Click;
            // 
            // ListaFuncionarioView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1573, 877);
            Controls.Add(panel1);
            Controls.Add(comboBoxFuncionarios);
            Controls.Add(comboBoxAno);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListaFuncionarioView";
            Load += ListaFuncionarioView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxAno;
        private Button button1;
        public ComboBox comboBoxFuncionarios;
        public DataGridView dataGridViewDados;
        private Panel panel1;
        private DataGridViewTextBoxColumn Mês;
        private DataGridViewTextBoxColumn Ano;
        private DataGridViewTextBoxColumn total_proventos;
        private DataGridViewTextBoxColumn total_descontos;
        private DataGridViewTextBoxColumn Valor;
        private Button buttonGeraPDF;
    }
}