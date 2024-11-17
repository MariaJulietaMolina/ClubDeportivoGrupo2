namespace ClubDeportivo
{
    partial class Actividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actividades));
            lblWelcome = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.FromArgb(201, 242, 153);
            lblWelcome.Font = new Font("Dubai", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(36, 79, 38);
            lblWelcome.Location = new Point(235, 19);
            lblWelcome.Margin = new Padding(9, 0, 9, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(316, 49);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "ASIGNAR ACTIVIDADES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(139, 191, 167);
            label2.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(13, 55, 77);
            label2.Location = new Point(39, 92);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 36);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.ControlText;
            txtUser.Location = new Point(410, 92);
            txtUser.Margin = new Padding(8, 7, 8, 7);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(361, 40);
            txtUser.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(236, 159, 5);
            btnLogin.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(36, 79, 38);
            btnLogin.Location = new Point(554, 365);
            btnLogin.Margin = new Padding(8, 7, 8, 7);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(217, 79);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(139, 191, 167);
            label1.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 55, 77);
            label1.Location = new Point(39, 150);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 36);
            label1.TabIndex = 9;
            label1.Text = "DNI";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(410, 150);
            textBox1.Margin = new Padding(8, 7, 8, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 40);
            textBox1.TabIndex = 10;
            // 
            // Actividades
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(797, 460);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            Name = "Actividades";
            Text = "Club Deportivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label label2;
        private TextBox txtUser;
        private Button btnLogin;
        private Label label1;
        private TextBox textBox1;
    }
}