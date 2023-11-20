﻿namespace DesktopPim.Views.ViewHome.Mensal
{
    partial class PayrollAdicionaValor
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
            label1 = new Label();
            textBoxNomeValor = new TextBox();
            label2 = new Label();
            comboBoxTp = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBoxValor = new TextBox();
            buttonAdicionarValor = new Button();
            button2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(368, 44);
            label1.TabIndex = 8;
            label1.Text = "Adicionar desconto/provento";
            // 
            // textBoxNomeValor
            // 
            textBoxNomeValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomeValor.Location = new Point(12, 95);
            textBoxNomeValor.Name = "textBoxNomeValor";
            textBoxNomeValor.Size = new Size(368, 33);
            textBoxNomeValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(208, 35);
            label2.TabIndex = 8;
            label2.Text = "Nomenclatura do valor";
            // 
            // comboBoxTp
            // 
            comboBoxTp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTp.FormattingEnabled = true;
            comboBoxTp.Location = new Point(12, 189);
            comboBoxTp.Name = "comboBoxTp";
            comboBoxTp.Size = new Size(368, 33);
            comboBoxTp.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(60, 35);
            label3.TabIndex = 11;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(60, 32);
            label4.TabIndex = 12;
            label4.Text = "Valor";
            // 
            // textBoxValor
            // 
            textBoxValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValor.Location = new Point(12, 276);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(368, 33);
            textBoxValor.TabIndex = 3;
            // 
            // buttonAdicionarValor
            // 
            buttonAdicionarValor.BackColor = Color.OliveDrab;
            buttonAdicionarValor.Cursor = Cursors.Hand;
            buttonAdicionarValor.FlatStyle = FlatStyle.Flat;
            buttonAdicionarValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionarValor.ForeColor = SystemColors.Control;
            buttonAdicionarValor.Location = new Point(363, 329);
            buttonAdicionarValor.Name = "buttonAdicionarValor";
            buttonAdicionarValor.Size = new Size(118, 34);
            buttonAdicionarValor.TabIndex = 5;
            buttonAdicionarValor.Text = "Adicionar";
            buttonAdicionarValor.UseVisualStyleBackColor = false;
            buttonAdicionarValor.Click += buttonAdicionarValor_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(239, 329);
            button2.Name = "button2";
            button2.Size = new Size(118, 34);
            button2.TabIndex = 4;
            button2.Text = "Fechar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 306);
            panel1.TabIndex = 16;
            // 
            // PayrollAdicionaValor
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(493, 375);
            Controls.Add(button2);
            Controls.Add(buttonAdicionarValor);
            Controls.Add(label4);
            Controls.Add(textBoxValor);
            Controls.Add(label3);
            Controls.Add(comboBoxTp);
            Controls.Add(label2);
            Controls.Add(textBoxNomeValor);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "PayrollAdicionaValor";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNomeValor;
        private Label label2;
        private ComboBox comboBoxTp;
        private Label label3;
        private Label label4;
        private TextBox textBoxValor;
        private Button buttonAdicionarValor;
        private Button button2;
        private Panel panel1;
    }
}