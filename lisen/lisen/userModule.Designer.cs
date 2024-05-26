namespace lisen
{
    partial class userModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userModule));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.messageTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTxb = new System.Windows.Forms.Button();
            this.studentNo = new System.Windows.Forms.Label();
            this.studentEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridBorrow = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchData = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridBorrow);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 389);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.messageTxb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.emailTxb);
            this.groupBox2.Controls.Add(this.studentNo);
            this.groupBox2.Controls.Add(this.studentEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 361);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // messageTxb
            // 
            this.messageTxb.Location = new System.Drawing.Point(11, 166);
            this.messageTxb.Multiline = true;
            this.messageTxb.Name = "messageTxb";
            this.messageTxb.Size = new System.Drawing.Size(209, 115);
            this.messageTxb.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student No.";
            // 
            // emailTxb
            // 
            this.emailTxb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.emailTxb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailTxb.BackgroundImage")));
            this.emailTxb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emailTxb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailTxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.emailTxb.Location = new System.Drawing.Point(49, 303);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(112, 39);
            this.emailTxb.TabIndex = 25;
            this.emailTxb.Text = "   Email";
            this.emailTxb.UseVisualStyleBackColor = false;
            this.emailTxb.Click += new System.EventHandler(this.emailTxb_Click);
            // 
            // studentNo
            // 
            this.studentNo.AutoSize = true;
            this.studentNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentNo.Location = new System.Drawing.Point(11, 54);
            this.studentNo.Name = "studentNo";
            this.studentNo.Size = new System.Drawing.Size(82, 21);
            this.studentNo.TabIndex = 2;
            this.studentNo.Text = "------------";
            // 
            // studentEmail
            // 
            this.studentEmail.AutoSize = true;
            this.studentEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentEmail.Location = new System.Drawing.Point(11, 121);
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(82, 21);
            this.studentEmail.TabIndex = 4;
            this.studentEmail.Text = "------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Email";
            // 
            // dataGridBorrow
            // 
            this.dataGridBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBorrow.Location = new System.Drawing.Point(268, 22);
            this.dataGridBorrow.Name = "dataGridBorrow";
            this.dataGridBorrow.RowTemplate.Height = 25;
            this.dataGridBorrow.Size = new System.Drawing.Size(830, 353);
            this.dataGridBorrow.TabIndex = 0;
            this.dataGridBorrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickDataGrid);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(614, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // searchData
            // 
            this.searchData.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchData.Location = new System.Drawing.Point(280, 24);
            this.searchData.Name = "searchData";
            this.searchData.PlaceholderText = "           Search ";
            this.searchData.Size = new System.Drawing.Size(367, 32);
            this.searchData.TabIndex = 30;
            this.searchData.TextChanged += new System.EventHandler(this.searchData_TextChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(18, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(51, 25);
            this.exitBtn.TabIndex = 33;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // userModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 453);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "userModule";
            this.Text = "userModule";
            this.Load += new System.EventHandler(this.userModule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dataGridBorrow;
        private GroupBox groupBox2;
        private Label label1;
        private Button emailTxb;
        private Label studentNo;
        private Label studentEmail;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox searchData;
        private Label exitBtn;
        private TextBox messageTxb;
    }
}