namespace lisen
{
    partial class usersInputBorrowingModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usersInputBorrowingModule));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BooksViewer = new System.Windows.Forms.DataGridView();
            this.searchData = new System.Windows.Forms.TextBox();
            this.bookNameTxb = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.returnDateTxb = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTxb = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.refreshData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.BooksViewer);
            this.groupBox1.Controls.Add(this.searchData);
            this.groupBox1.Controls.Add(this.bookNameTxb);
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.returnDateTxb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTxb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 412);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // refreshData
            // 
            this.refreshData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.refreshData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refreshData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.refreshData.Location = new System.Drawing.Point(311, 361);
            this.refreshData.Name = "refreshData";
            this.refreshData.Size = new System.Drawing.Size(99, 30);
            this.refreshData.TabIndex = 37;
            this.refreshData.Text = "Refresh Data";
            this.refreshData.UseVisualStyleBackColor = false;
            this.refreshData.Click += new System.EventHandler(this.refreshData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "List Of Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(649, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // BooksViewer
            // 
            this.BooksViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksViewer.Location = new System.Drawing.Point(26, 172);
            this.BooksViewer.Name = "BooksViewer";
            this.BooksViewer.RowTemplate.Height = 25;
            this.BooksViewer.Size = new System.Drawing.Size(656, 181);
            this.BooksViewer.TabIndex = 35;
            // 
            // searchData
            // 
            this.searchData.BackColor = System.Drawing.Color.White;
            this.searchData.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchData.Location = new System.Drawing.Point(416, 359);
            this.searchData.Name = "searchData";
            this.searchData.PlaceholderText = "   Search for a book";
            this.searchData.Size = new System.Drawing.Size(266, 32);
            this.searchData.TabIndex = 26;
            this.searchData.TextChanged += new System.EventHandler(this.searchData_TextChanged);
            // 
            // bookNameTxb
            // 
            this.bookNameTxb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookNameTxb.FormattingEnabled = true;
            this.bookNameTxb.Location = new System.Drawing.Point(26, 108);
            this.bookNameTxb.Name = "bookNameTxb";
            this.bookNameTxb.Size = new System.Drawing.Size(542, 33);
            this.bookNameTxb.TabIndex = 34;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.submitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitBtn.BackgroundImage")));
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.submitBtn.Location = new System.Drawing.Point(574, 102);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(108, 45);
            this.submitBtn.TabIndex = 33;
            this.submitBtn.Text = "     Borrow";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // returnDateTxb
            // 
            this.returnDateTxb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnDateTxb.Location = new System.Drawing.Point(357, 45);
            this.returnDateTxb.Name = "returnDateTxb";
            this.returnDateTxb.Size = new System.Drawing.Size(325, 32);
            this.returnDateTxb.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(357, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Return Date";
            // 
            // dateTxb
            // 
            this.dateTxb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTxb.Location = new System.Drawing.Point(26, 45);
            this.dateTxb.Name = "dateTxb";
            this.dateTxb.Size = new System.Drawing.Size(325, 32);
            this.dateTxb.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Title of the Book";
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(12, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(51, 25);
            this.exitBtn.TabIndex = 33;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // usersInputBorrowingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 494);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "usersInputBorrowingModule";
            this.Text = "usersInputBorrowingModule";
            this.Load += new System.EventHandler(this.usersInputBorrowingModule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private DateTimePicker returnDateTxb;
        private Label label5;
        private DateTimePicker dateTxb;
        private Label label3;
        private Label label4;
        private Button submitBtn;
        private ComboBox bookNameTxb;
        private DataGridView BooksViewer;
        private TextBox searchData;
        private PictureBox pictureBox1;
        private Label label1;
        private Button refreshData;
        private Label exitBtn;
    }
}