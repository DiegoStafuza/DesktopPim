namespace DesktopPim.View
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            Autenticar = new Button();
            Passwordbox = new TextBox();
            UserBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Autenticar
            // 
            Autenticar.Cursor = Cursors.Hand;
            Autenticar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Autenticar.Location = new Point(177, 469);
            Autenticar.Name = "Autenticar";
            Autenticar.Size = new Size(430, 53);
            Autenticar.TabIndex = 3;
            Autenticar.Text = "Autenticar";
            Autenticar.UseVisualStyleBackColor = true;
            // 
            // Passwordbox
            // 
            Passwordbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Passwordbox.Location = new Point(177, 406);
            Passwordbox.Name = "Passwordbox";
            Passwordbox.PlaceholderText = "Senha";
            Passwordbox.Size = new Size(430, 29);
            Passwordbox.TabIndex = 2;
            Passwordbox.UseSystemPasswordChar = true;
            // 
            // UserBox
            // 
            UserBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserBox.Location = new Point(177, 356);
            UserBox.Name = "UserBox";
            UserBox.PlaceholderText = "usuario@dominio.com";
            UserBox.Size = new Size(430, 29);
            UserBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(144, 352);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(144, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(177, 249);
            label1.Name = "label1";
            label1.Size = new Size(430, 47);
            label1.TabIndex = 7;
            label1.Text = "Automatização de holerites";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(200, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(406, 178);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 120, 87);
            ClientSize = new Size(800, 626);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(UserBox);
            Controls.Add(Passwordbox);
            Controls.Add(Autenticar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Autenticar;
        private TextBox Passwordbox;
        private TextBox UserBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
    }
}