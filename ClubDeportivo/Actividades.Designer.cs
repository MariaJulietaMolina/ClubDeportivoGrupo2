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
            btnClean = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.FromArgb(201, 242, 153);
            lblWelcome.Font = new Font("Dubai", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(36, 79, 38);
            lblWelcome.Location = new Point(310, 9);
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
            label2.Location = new Point(41, 90);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(197, 36);
            label2.TabIndex = 6;
            label2.Text = "BUSCAR ACTIVIDAD";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.ControlText;
            txtUser.Location = new Point(310, 91);
            txtUser.Margin = new Padding(8, 7, 8, 7);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(316, 40);
            txtUser.TabIndex = 7;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(236, 159, 5);
            btnLogin.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(36, 79, 38);
            btnLogin.Location = new Point(686, 342);
            btnLogin.Margin = new Padding(8, 7, 8, 7);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(168, 44);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "OTORGAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(139, 191, 167);
            label1.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 55, 77);
            label1.Location = new Point(41, 342);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 9;
            label1.Text = " INGRESAR DNI ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(310, 338);
            textBox1.Margin = new Padding(8, 7, 8, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 40);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.FromArgb(236, 159, 5);
            btnClean.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnClean.ForeColor = Color.FromArgb(36, 79, 38);
            btnClean.Location = new Point(686, 91);
            btnClean.Margin = new Padding(6, 7, 6, 7);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(168, 35);
            btnClean.TabIndex = 22;
            btnClean.Text = "BUSCAR";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(236, 159, 5);
            button1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(36, 79, 38);
            button1.Location = new Point(538, 392);
            button1.Margin = new Padding(8, 7, 8, 7);
            button1.Name = "button1";
            button1.Size = new Size(316, 41);
            button1.TabIndex = 24;
            button1.Text = "QUITAR CUPO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 150);
            dataGridView1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(139, 191, 167);
            label3.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 55, 77);
            label3.Location = new Point(41, 392);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 36);
            label3.TabIndex = 26;
            label3.Text = "ACTIVIDAD PAGADA";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.FromArgb(201, 242, 153);
            checkBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = Color.FromArgb(33, 109, 132);
            checkBox2.Location = new Point(310, 391);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 34);
            checkBox2.TabIndex = 27;
            checkBox2.Text = "PAGÓ";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(201, 242, 153);
            checkBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(33, 109, 132);
            checkBox1.Location = new Point(403, 391);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 34);
            checkBox1.TabIndex = 28;
            checkBox1.Text = "ES SOCIO";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(686, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // Actividades
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 449);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btnClean);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            Name = "Actividades";
            Text = "Club Deportivo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnClean;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}