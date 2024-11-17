namespace ClubDeportivo
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            lblWelcome = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(236, 159, 5);
            btnLogin.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(36, 79, 38);
            btnLogin.Location = new Point(599, 304);
            btnLogin.Margin = new Padding(8, 7, 8, 7);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 79);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.FromArgb(201, 242, 153);
            lblWelcome.Font = new Font("Dubai", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(36, 79, 38);
            lblWelcome.Location = new Point(41, 27);
            lblWelcome.Margin = new Padding(8, 0, 8, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(182, 49);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "BIENVENIDO";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.ControlText;
            txtUser.Location = new Point(41, 191);
            txtUser.Margin = new Padding(8, 7, 8, 7);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(361, 40);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = SystemColors.ControlText;
            txtPass.Location = new Point(41, 340);
            txtPass.Margin = new Padding(8, 7, 8, 7);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(361, 43);
            txtPass.TabIndex = 3;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(139, 191, 167);
            label2.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(13, 55, 77);
            label2.Location = new Point(41, 123);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 36);
            label2.TabIndex = 5;
            label2.Text = "USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(139, 191, 167);
            label1.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 55, 77);
            label1.Location = new Point(41, 279);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 36);
            label1.TabIndex = 6;
            label1.Text = "CONTRASEÑA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(599, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(20F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 421);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogin);
            Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 7, 8, 7);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblWelcome;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
