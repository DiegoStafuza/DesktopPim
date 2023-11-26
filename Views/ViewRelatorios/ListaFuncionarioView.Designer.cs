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
            comboBoxMes = new ComboBox();
            comboBoxAno = new ComboBox();
            dataGridViewDados = new DataGridView();
            comboBoxFuncionarios = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMes
            // 
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Location = new Point(654, 121);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(195, 23);
            comboBoxMes.TabIndex = 0;
            // 
            // comboBoxAno
            // 
            comboBoxAno.FormattingEnabled = true;
            comboBoxAno.Location = new Point(855, 121);
            comboBoxAno.Name = "comboBoxAno";
            comboBoxAno.Size = new Size(175, 23);
            comboBoxAno.TabIndex = 1;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(284, 193);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(746, 236);
            dataGridViewDados.TabIndex = 2;
            // 
            // comboBoxFuncionarios
            // 
            comboBoxFuncionarios.FormattingEnabled = true;
            comboBoxFuncionarios.Location = new Point(284, 121);
            comboBoxFuncionarios.Name = "comboBoxFuncionarios";
            comboBoxFuncionarios.Size = new Size(270, 23);
            comboBoxFuncionarios.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(929, 435);
            button1.Name = "button1";
            button1.Size = new Size(101, 54);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonBuscar_Click;
            // 
            // ListaFuncionarioView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1178, 548);
            Controls.Add(button1);
            Controls.Add(comboBoxFuncionarios);
            Controls.Add(dataGridViewDados);
            Controls.Add(comboBoxAno);
            Controls.Add(comboBoxMes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListaFuncionarioView";
            Load += ListaFuncionarioView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxMes;
        private ComboBox comboBoxAno;
        private DataGridView dataGridView1;
        private Button button1;
        public ComboBox comboBoxFuncionarios;
        public DataGridView dataGridViewDados;
    }
}