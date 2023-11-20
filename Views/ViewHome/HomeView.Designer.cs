namespace DesktopPim.Views
{
    partial class HomeView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            panelPrincipal = new Panel();
            button2 = new Button();
            DuvidasBtn = new Button();
            relatorioBtn = new Button();
            payrollBtn = new Button();
            panelLogo = new Panel();
            labelLogo = new Label();
            peopleBtn = new Button();
            panel2 = new Panel();
            button1 = new Button();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            panelPrincipal.SuspendLayout();
            panelLogo.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(4, 120, 87);
            panelPrincipal.Controls.Add(button2);
            panelPrincipal.Controls.Add(DuvidasBtn);
            panelPrincipal.Controls.Add(relatorioBtn);
            panelPrincipal.Controls.Add(payrollBtn);
            panelPrincipal.Controls.Add(panelLogo);
            panelPrincipal.Controls.Add(peopleBtn);
            panelPrincipal.Controls.Add(panel2);
            panelPrincipal.Dock = DockStyle.Left;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(293, 583);
            panelPrincipal.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(4, 120, 87);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 120, 87);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 120, 87);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 272);
            button2.Name = "button2";
            button2.Size = new Size(290, 68);
            button2.TabIndex = 13;
            button2.Text = "        Funcionários";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DuvidasBtn
            // 
            DuvidasBtn.BackgroundImageLayout = ImageLayout.Zoom;
            DuvidasBtn.Cursor = Cursors.Hand;
            DuvidasBtn.FlatAppearance.BorderColor = Color.FromArgb(4, 120, 87);
            DuvidasBtn.FlatAppearance.BorderSize = 0;
            DuvidasBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 120, 87);
            DuvidasBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 120, 87);
            DuvidasBtn.FlatStyle = FlatStyle.Flat;
            DuvidasBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            DuvidasBtn.ForeColor = SystemColors.Control;
            DuvidasBtn.Image = (Image)resources.GetObject("DuvidasBtn.Image");
            DuvidasBtn.ImageAlign = ContentAlignment.TopLeft;
            DuvidasBtn.Location = new Point(0, 444);
            DuvidasBtn.Name = "DuvidasBtn";
            DuvidasBtn.Size = new Size(289, 64);
            DuvidasBtn.TabIndex = 0;
            DuvidasBtn.Text = "Dúvidas";
            DuvidasBtn.UseVisualStyleBackColor = false;
            DuvidasBtn.Click += DuvidasBtn_Click;
            // 
            // relatorioBtn
            // 
            relatorioBtn.BackgroundImageLayout = ImageLayout.Stretch;
            relatorioBtn.Cursor = Cursors.Hand;
            relatorioBtn.FlatAppearance.BorderColor = Color.FromArgb(4, 120, 87);
            relatorioBtn.FlatAppearance.BorderSize = 0;
            relatorioBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 120, 87);
            relatorioBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 120, 87);
            relatorioBtn.FlatStyle = FlatStyle.Flat;
            relatorioBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            relatorioBtn.ForeColor = SystemColors.Control;
            relatorioBtn.Image = (Image)resources.GetObject("relatorioBtn.Image");
            relatorioBtn.ImageAlign = ContentAlignment.BottomLeft;
            relatorioBtn.Location = new Point(3, 360);
            relatorioBtn.Name = "relatorioBtn";
            relatorioBtn.Size = new Size(290, 64);
            relatorioBtn.TabIndex = 0;
            relatorioBtn.Text = "   Relatórios";
            relatorioBtn.UseVisualStyleBackColor = false;
            // 
            // payrollBtn
            // 
            payrollBtn.BackColor = Color.FromArgb(4, 120, 87);
            payrollBtn.BackgroundImageLayout = ImageLayout.Zoom;
            payrollBtn.Cursor = Cursors.Hand;
            payrollBtn.FlatAppearance.BorderColor = Color.FromArgb(4, 120, 87);
            payrollBtn.FlatAppearance.BorderSize = 0;
            payrollBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 120, 87);
            payrollBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 120, 87);
            payrollBtn.FlatStyle = FlatStyle.Flat;
            payrollBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            payrollBtn.ForeColor = SystemColors.Control;
            payrollBtn.Image = (Image)resources.GetObject("payrollBtn.Image");
            payrollBtn.ImageAlign = ContentAlignment.MiddleLeft;
            payrollBtn.Location = new Point(3, 118);
            payrollBtn.Name = "payrollBtn";
            payrollBtn.Size = new Size(290, 64);
            payrollBtn.TabIndex = 0;
            payrollBtn.Text = " Mensal";
            payrollBtn.TextAlign = ContentAlignment.TopCenter;
            payrollBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            payrollBtn.UseVisualStyleBackColor = false;
            payrollBtn.Click += PayrollBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(labelLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(293, 92);
            panelLogo.TabIndex = 0;
            // 
            // labelLogo
            // 
            labelLogo.Dock = DockStyle.Top;
            labelLogo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogo.ForeColor = SystemColors.Control;
            labelLogo.Location = new Point(0, 0);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(293, 92);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "Holfree";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // peopleBtn
            // 
            peopleBtn.BackColor = Color.FromArgb(4, 120, 87);
            peopleBtn.BackgroundImageLayout = ImageLayout.Stretch;
            peopleBtn.Cursor = Cursors.Hand;
            peopleBtn.FlatAppearance.BorderColor = Color.FromArgb(4, 120, 87);
            peopleBtn.FlatAppearance.BorderSize = 0;
            peopleBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 120, 87);
            peopleBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 120, 87);
            peopleBtn.FlatStyle = FlatStyle.Flat;
            peopleBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            peopleBtn.ForeColor = SystemColors.Control;
            peopleBtn.Image = (Image)resources.GetObject("peopleBtn.Image");
            peopleBtn.ImageAlign = ContentAlignment.MiddleLeft;
            peopleBtn.Location = new Point(1, 196);
            peopleBtn.Name = "peopleBtn";
            peopleBtn.Size = new Size(290, 64);
            peopleBtn.TabIndex = 0;
            peopleBtn.Text = " Usuários";
            peopleBtn.UseVisualStyleBackColor = true;
            peopleBtn.Click += PeopleBtn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 516);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 64);
            panel2.TabIndex = 11;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(4, 120, 87);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(4, 120, 87);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 120, 87);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 120, 87);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1, 0);
            button1.Name = "button1";
            button1.Size = new Size(293, 64);
            button1.TabIndex = 0;
            button1.Text = "         Sair";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.FromArgb(4, 120, 87);
            imageList1.Images.SetKeyName(0, "User Groups.png");
            imageList1.Images.SetKeyName(1, "UsersFour.png");
            imageList1.Images.SetKeyName(2, "Google Docs.png");
            imageList1.Images.SetKeyName(3, "People.png");
            imageList1.Images.SetKeyName(4, "Payroll.png");
            imageList1.Images.SetKeyName(5, "Screenshot_14.png");
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(293, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 583);
            panel1.TabIndex = 1;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(992, 583);
            Controls.Add(panel1);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeView";
            panelPrincipal.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Panel panelLogo;
        private Label labelLogo;
        private Button payrollBtn;
        private Button peopleBtn;
        private Button relatorioBtn;
        private Button DuvidasBtn;
        private Panel panel1;
        private Button button2;
        private Panel panel2;
        private Button button1;
        private ImageList imageList1;
    }
}