namespace ClubDeportivo
{
    partial class NewMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMemberForm));
            btnRegister = new Button();
            lblName = new Label();
            lblLastName = new Label();
            lblDoc = new Label();
            lblBirth = new Label();
            lblEmail = new Label();
            cboGender = new ComboBox();
            lblGender = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtDocument = new TextBox();
            txtEmail = new TextBox();
            btnExit = new Button();
            btnClean = new Button();
            dtpBirth = new DateTimePicker();
            lblWelcome = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(236, 159, 5);
            btnRegister.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnRegister.ForeColor = Color.FromArgb(36, 79, 38);
            btnRegister.Location = new Point(652, 305);
            btnRegister.Margin = new Padding(6, 7, 6, 7);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(237, 87);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTAR";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(139, 191, 167);
            lblName.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(13, 55, 77);
            lblName.Location = new Point(28, 86);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 24);
            lblName.TabIndex = 1;
            lblName.Text = "NOMBRE";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.FromArgb(139, 191, 167);
            lblLastName.Font = new Font("Arial Rounded MT Bold", 15.75F);
            lblLastName.ForeColor = Color.FromArgb(13, 55, 77);
            lblLastName.Location = new Point(28, 154);
            lblLastName.Margin = new Padding(6, 0, 6, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(119, 24);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "APELLIDO";
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.BackColor = Color.FromArgb(139, 191, 167);
            lblDoc.Font = new Font("Arial Rounded MT Bold", 15.75F);
            lblDoc.ForeColor = Color.FromArgb(13, 55, 77);
            lblDoc.Location = new Point(28, 222);
            lblDoc.Margin = new Padding(6, 0, 6, 0);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(78, 24);
            lblDoc.TabIndex = 3;
            lblDoc.Text = "N° DNI";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.BackColor = Color.FromArgb(139, 191, 167);
            lblBirth.Font = new Font("Arial Rounded MT Bold", 15.75F);
            lblBirth.ForeColor = Color.FromArgb(13, 55, 77);
            lblBirth.Location = new Point(453, 155);
            lblBirth.Margin = new Padding(6, 0, 6, 0);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(171, 24);
            lblBirth.TabIndex = 4;
            lblBirth.Text = "FECHA DE NAC";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(139, 191, 167);
            lblEmail.Font = new Font("Arial Rounded MT Bold", 15.75F);
            lblEmail.ForeColor = Color.FromArgb(13, 55, 77);
            lblEmail.Location = new Point(453, 222);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(205, 24);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "DIRECCIÓN EMAIL";
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cboGender.Location = new Point(670, 86);
            cboGender.Margin = new Padding(6, 7, 6, 7);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(219, 29);
            cboGender.TabIndex = 6;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.FromArgb(139, 191, 167);
            lblGender.Font = new Font("Arial Rounded MT Bold", 15.75F);
            lblGender.ForeColor = Color.FromArgb(13, 55, 77);
            lblGender.Location = new Point(453, 87);
            lblGender.Margin = new Padding(6, 0, 6, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(103, 24);
            lblGender.TabIndex = 7;
            lblGender.Text = "GENERO";
            // 
            // txtName
            // 
            txtName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(178, 86);
            txtName.Margin = new Padding(6, 7, 6, 7);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 35);
            txtName.TabIndex = 8;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(178, 154);
            txtLastName.Margin = new Padding(6, 7, 6, 7);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(239, 35);
            txtLastName.TabIndex = 9;
            // 
            // txtDocument
            // 
            txtDocument.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocument.Location = new Point(178, 221);
            txtDocument.Margin = new Padding(6, 7, 6, 7);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(239, 35);
            txtDocument.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(670, 221);
            txtEmail.Margin = new Padding(6, 7, 6, 7);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 35);
            txtEmail.TabIndex = 12;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1481, 999);
            btnExit.Margin = new Padding(6, 7, 6, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(178, 81);
            btnExit.TabIndex = 13;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.FromArgb(236, 159, 5);
            btnClean.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnClean.ForeColor = Color.FromArgb(36, 79, 38);
            btnClean.Location = new Point(28, 305);
            btnClean.Margin = new Padding(6, 7, 6, 7);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(237, 87);
            btnClean.TabIndex = 14;
            btnClean.Text = "LIMPIAR";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // dtpBirth
            // 
            dtpBirth.CalendarForeColor = Color.FromArgb(13, 55, 77);
            dtpBirth.CustomFormat = "yyyy-mm-dd";
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.Location = new Point(670, 155);
            dtpBirth.Margin = new Padding(6, 7, 6, 7);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(219, 43);
            dtpBirth.TabIndex = 15;
            dtpBirth.ValueChanged += dtpBirth_ValueChanged;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.FromArgb(201, 242, 153);
            lblWelcome.Font = new Font("Dubai", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(36, 79, 38);
            lblWelcome.Location = new Point(304, 9);
            lblWelcome.Margin = new Padding(9, 0, 9, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(354, 49);
            lblWelcome.TabIndex = 16;
            lblWelcome.Text = "REGISTRAR NUEVO SOCIO";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(201, 242, 153);
            checkBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(33, 109, 132);
            checkBox1.Location = new Point(473, 358);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(151, 34);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "APTO FÍSICO";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.FromArgb(201, 242, 153);
            checkBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = Color.FromArgb(33, 109, 132);
            checkBox2.Location = new Point(277, 358);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 34);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "PAGÓ";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(13, 55, 77);
            dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(476, 305);
            dateTimePicker1.Margin = new Padding(6, 7, 6, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 43);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(139, 191, 167);
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 55, 77);
            label1.Location = new Point(277, 305);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 21;
            label1.Text = "FECHA PAGO";
            label1.Click += label1_Click;
            // 
            // NewMemberForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(919, 438);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(lblWelcome);
            Controls.Add(dtpBirth);
            Controls.Add(btnClean);
            Controls.Add(btnExit);
            Controls.Add(txtEmail);
            Controls.Add(txtDocument);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(lblGender);
            Controls.Add(cboGender);
            Controls.Add(lblEmail);
            Controls.Add(lblBirth);
            Controls.Add(lblDoc);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(btnRegister);
            ForeColor = Color.Black;
            Margin = new Padding(6, 7, 6, 7);
            Name = "NewMemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo";
            Load += NewMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label lblName;
        private Label lblLastName;
        private Label lblDoc;
        private Label lblBirth;
        private Label lblEmail;
        private ComboBox cboGender;
        private Label lblGender;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtDocument;
        private TextBox txtEmail;
        private Button btnExit;
        private Button btnClean;
        private DateTimePicker dtpBirth;
        private Label lblWelcome;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}