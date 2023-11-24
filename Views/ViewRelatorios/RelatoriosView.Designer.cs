namespace DesktopPim.Views
{
    partial class RelatoriosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatoriosView));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            buttonFuncionariosPDF = new Button();
            panel3 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(191, 60);
            label1.TabIndex = 0;
            label1.Text = "Relatórios";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(239, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 573);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(buttonFuncionariosPDF);
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 573);
            panel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-2, 200);
            button2.Name = "button2";
            button2.Size = new Size(233, 68);
            button2.TabIndex = 15;
            button2.Text = "        Pagamentos";
            button2.UseVisualStyleBackColor = false;
            // 
            // buttonFuncionariosPDF
            // 
            buttonFuncionariosPDF.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFuncionariosPDF.Cursor = Cursors.Hand;
            buttonFuncionariosPDF.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonFuncionariosPDF.FlatAppearance.BorderSize = 0;
            buttonFuncionariosPDF.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            buttonFuncionariosPDF.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            buttonFuncionariosPDF.FlatStyle = FlatStyle.Flat;
            buttonFuncionariosPDF.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFuncionariosPDF.ForeColor = SystemColors.Control;
            buttonFuncionariosPDF.Image = (Image)resources.GetObject("buttonFuncionariosPDF.Image");
            buttonFuncionariosPDF.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFuncionariosPDF.Location = new Point(0, 112);
            buttonFuncionariosPDF.Name = "buttonFuncionariosPDF";
            buttonFuncionariosPDF.Size = new Size(233, 68);
            buttonFuncionariosPDF.TabIndex = 14;
            buttonFuncionariosPDF.Text = "        Funcionários";
            buttonFuncionariosPDF.UseVisualStyleBackColor = false;
            buttonFuncionariosPDF.Click += buttonFuncionariosPDF_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 84);
            panel3.TabIndex = 16;
            // 
            // RelatoriosView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1288, 573);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RelatoriosView";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button buttonFuncionariosPDF;
        private Button button2;
        private Panel panel3;
    }
}