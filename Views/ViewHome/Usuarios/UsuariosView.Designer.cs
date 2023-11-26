using Org.BouncyCastle.Asn1.Crmf;

namespace DesktopPim.Views
{
    partial class UsuariosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosView));
            dataGridViewUsuarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewTextBoxColumn();
            Administrador = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.BackgroundColor = SystemColors.Control;
            dataGridViewUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, email, Ativo, Administrador });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUsuarios.Location = new Point(132, 82);
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewUsuarios.RowTemplate.Height = 30;
            dataGridViewUsuarios.Size = new Size(1287, 374);
            dataGridViewUsuarios.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "E-mail";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            // 
            // Administrador
            // 
            Administrador.HeaderText = "Administrador";
            Administrador.Name = "Administrador";
            Administrador.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(132, 462);
            button1.Name = "button1";
            button1.Size = new Size(181, 66);
            button1.TabIndex = 0;
            button1.Text = "Atualizar tabela";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonAtualizar_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridViewUsuarios);
            panel2.Location = new Point(2, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(1570, 598);
            panel2.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1240, 287);
            button2.Name = "button2";
            button2.Size = new Size(181, 66);
            button2.TabIndex = 3;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonCadastrar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(215, 190, 57);
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(134, 287);
            button4.Name = "button4";
            button4.Size = new Size(181, 66);
            button4.TabIndex = 9;
            button4.Text = "Alterar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonAlterar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(174, 13, 13);
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(333, 287);
            button3.Name = "button3";
            button3.Size = new Size(181, 66);
            button3.TabIndex = 6;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonExcluir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(4, 120, 87);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(172, 50);
            label6.TabIndex = 16;
            label6.Text = "Usuários";
            // 
            // UsuariosView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1573, 877);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsuariosView";
            Load += UsuariosView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button button1;
        public DataGridView dataGridViewUsuarios;
        private Button button2;
        private Button button4;
        private Button button3;
        private Label label6;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Ativo;
        private DataGridViewTextBoxColumn Administrador;
    }
}