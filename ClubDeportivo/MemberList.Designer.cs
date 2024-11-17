namespace ClubDeportivo
{
    partial class MemberList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberList));
            lblWelcome = new Label();
            dataGridView1 = new DataGridView();
            lblDoc = new Label();
            txtDocument = new TextBox();
            btnClean = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.FromArgb(201, 242, 153);
            lblWelcome.Font = new Font("Dubai", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(36, 79, 38);
            lblWelcome.Location = new Point(322, 9);
            lblWelcome.Margin = new Padding(9, 0, 9, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(285, 49);
            lblWelcome.TabIndex = 17;
            lblWelcome.Text = "ESTADO DE CUOTAS";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(813, 182);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.BackColor = Color.FromArgb(139, 191, 167);
            lblDoc.Font = new Font("Arial Rounded MT Bold", 15.75F);
            lblDoc.ForeColor = Color.FromArgb(13, 55, 77);
            lblDoc.Location = new Point(55, 88);
            lblDoc.Margin = new Padding(6, 0, 6, 0);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(214, 24);
            lblDoc.TabIndex = 19;
            lblDoc.Text = "BUQUEDA POR DNI";
            lblDoc.Click += lblDoc_Click;
            // 
            // txtDocument
            // 
            txtDocument.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocument.Location = new Point(312, 83);
            txtDocument.Margin = new Padding(6, 7, 6, 7);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(285, 35);
            txtDocument.TabIndex = 20;
            txtDocument.TextChanged += txtDocument_TextChanged;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.FromArgb(236, 159, 5);
            btnClean.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnClean.ForeColor = Color.FromArgb(36, 79, 38);
            btnClean.Location = new Point(654, 83);
            btnClean.Margin = new Padding(6, 7, 6, 7);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(214, 35);
            btnClean.TabIndex = 21;
            btnClean.Text = "PAGAR";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(236, 159, 5);
            button1.Font = new Font("Arial Rounded MT Bold", 15.75F);
            button1.ForeColor = Color.FromArgb(36, 79, 38);
            button1.Location = new Point(322, 356);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(285, 35);
            button1.TabIndex = 22;
            button1.Text = "PRÓXIMOS A VENCER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MemberList
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(917, 436);
            Controls.Add(button1);
            Controls.Add(btnClean);
            Controls.Add(txtDocument);
            Controls.Add(lblDoc);
            Controls.Add(dataGridView1);
            Controls.Add(lblWelcome);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MemberList";
            Text = "Club Deportivo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private DataGridView dataGridView1;
        private Label lblDoc;
        private TextBox txtDocument;
        private Button btnClean;
        private Button button1;
    }
}