namespace ClubDeportivo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnNewMember = new Button();
            btnActivities = new Button();
            MemberList = new Button();
            btnExit = new Button();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNewMember
            // 
            btnNewMember.BackColor = Color.FromArgb(236, 159, 5);
            btnNewMember.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewMember.ForeColor = Color.FromArgb(36, 79, 38);
            btnNewMember.Location = new Point(101, 93);
            btnNewMember.Margin = new Padding(7, 6, 7, 6);
            btnNewMember.Name = "btnNewMember";
            btnNewMember.Size = new Size(296, 89);
            btnNewMember.TabIndex = 0;
            btnNewMember.Text = "INSCRIBIR SOCIO";
            btnNewMember.UseVisualStyleBackColor = false;
            btnNewMember.Click += btnNewMember_Click;
            // 
            // btnActivities
            // 
            btnActivities.BackColor = Color.FromArgb(236, 159, 5);
            btnActivities.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActivities.ForeColor = Color.FromArgb(36, 79, 38);
            btnActivities.Location = new Point(101, 194);
            btnActivities.Margin = new Padding(7, 6, 7, 6);
            btnActivities.Name = "btnActivities";
            btnActivities.Size = new Size(296, 86);
            btnActivities.TabIndex = 1;
            btnActivities.Text = "PAGAR ACTIVIDAD";
            btnActivities.UseVisualStyleBackColor = false;
            btnActivities.Click += btnActivities_Click;
            // 
            // MemberList
            // 
            MemberList.BackColor = Color.FromArgb(236, 159, 5);
            MemberList.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MemberList.ForeColor = Color.FromArgb(36, 79, 38);
            MemberList.Location = new Point(101, 292);
            MemberList.Margin = new Padding(7, 6, 7, 6);
            MemberList.Name = "MemberList";
            MemberList.Size = new Size(296, 86);
            MemberList.TabIndex = 2;
            MemberList.Text = "CUOTAS";
            MemberList.UseVisualStyleBackColor = false;
            MemberList.Click += MemberList_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientInactiveCaption;
            btnExit.Font = new Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1469, 845);
            btnExit.Margin = new Padding(7, 6, 7, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(187, 58);
            btnExit.TabIndex = 3;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.FromArgb(201, 242, 153);
            lblWelcome.Font = new Font("Dubai", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(36, 79, 38);
            lblWelcome.Location = new Point(267, 18);
            lblWelcome.Margin = new Padding(9, 0, 9, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(382, 49);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "ADMINISTRACIÓN DEL CLUB";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(469, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 417);
            Controls.Add(pictureBox1);
            Controls.Add(lblWelcome);
            Controls.Add(btnExit);
            Controls.Add(MemberList);
            Controls.Add(btnActivities);
            Controls.Add(btnNewMember);
            Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewMember;
        private Button btnActivities;
        private Button MemberList;
        private Button btnExit;
        private Label lblWelcome;
        private PictureBox pictureBox1;
    }
}