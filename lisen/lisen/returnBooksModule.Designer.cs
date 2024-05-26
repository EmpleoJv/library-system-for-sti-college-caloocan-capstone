namespace lisen
{
    partial class returnBooksModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnBooksModule));
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.borrowDataView = new System.Windows.Forms.DataGridView();
            this.studentno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingCodeTxb = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.refreshDataBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.loadDataBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadDataBtn.BackgroundImage")));
            this.loadDataBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadDataBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadDataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.loadDataBtn.Location = new System.Drawing.Point(608, 12);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(167, 41);
            this.loadDataBtn.TabIndex = 3;
            this.loadDataBtn.Text = "   Load Data";
            this.loadDataBtn.UseVisualStyleBackColor = false;
            this.loadDataBtn.Click += new System.EventHandler(this.loadDataBtn_Click);
            // 
            // borrowDataView
            // 
            this.borrowDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentno,
            this.email,
            this.bookname,
            this.status,
            this.date,
            this.duedate});
            this.borrowDataView.Location = new System.Drawing.Point(12, 104);
            this.borrowDataView.Name = "borrowDataView";
            this.borrowDataView.RowTemplate.Height = 25;
            this.borrowDataView.Size = new System.Drawing.Size(763, 340);
            this.borrowDataView.TabIndex = 4;
            // 
            // studentno
            // 
            this.studentno.HeaderText = "Student No.";
            this.studentno.Name = "studentno";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // bookname
            // 
            this.bookname.HeaderText = "Book";
            this.bookname.Name = "bookname";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 160;
            // 
            // duedate
            // 
            this.duedate.HeaderText = "Return Date";
            this.duedate.Name = "duedate";
            this.duedate.Width = 160;
            // 
            // borrowingCodeTxb
            // 
            this.borrowingCodeTxb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowingCodeTxb.Location = new System.Drawing.Point(394, 59);
            this.borrowingCodeTxb.Multiline = true;
            this.borrowingCodeTxb.Name = "borrowingCodeTxb";
            this.borrowingCodeTxb.PlaceholderText = "   Ex. 12345";
            this.borrowingCodeTxb.Size = new System.Drawing.Size(208, 39);
            this.borrowingCodeTxb.TabIndex = 5;
            this.borrowingCodeTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.forOnlyNumberTxb);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.returnBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnBtn.BackgroundImage")));
            this.returnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.returnBtn.Location = new System.Drawing.Point(608, 57);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(167, 41);
            this.returnBtn.TabIndex = 6;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // refreshDataBtn
            // 
            this.refreshDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.refreshDataBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshDataBtn.BackgroundImage")));
            this.refreshDataBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refreshDataBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refreshDataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.refreshDataBtn.Location = new System.Drawing.Point(435, 12);
            this.refreshDataBtn.Name = "refreshDataBtn";
            this.refreshDataBtn.Size = new System.Drawing.Size(167, 41);
            this.refreshDataBtn.TabIndex = 7;
            this.refreshDataBtn.Text = "   Refresh Data";
            this.refreshDataBtn.UseVisualStyleBackColor = false;
            this.refreshDataBtn.Click += new System.EventHandler(this.refreshDataBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(12, 17);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(51, 25);
            this.exitBtn.TabIndex = 33;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // returnBooksModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 447);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.refreshDataBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.borrowingCodeTxb);
            this.Controls.Add(this.borrowDataView);
            this.Controls.Add(this.loadDataBtn);
            this.DoubleBuffered = true;
            this.Name = "returnBooksModule";
            this.Text = "Return Books Module";
            this.Load += new System.EventHandler(this.returnBooksModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button loadDataBtn;
        private DataGridView borrowDataView;
        private TextBox borrowingCodeTxb;
        private DataGridViewTextBoxColumn studentno;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn bookname;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn duedate;
        private Button returnBtn;
        private Button refreshDataBtn;
        private Label exitBtn;
    }
}