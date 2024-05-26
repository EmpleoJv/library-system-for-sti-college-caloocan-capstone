namespace lisen
{
    partial class studentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentDashboard));
            this.profileBtn = new System.Windows.Forms.Button();
            this.usersInputModuleBtn = new System.Windows.Forms.Button();
            this.borrowedBooksModuleBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profileBtn
            // 
            this.profileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileBtn.BackgroundImage")));
            this.profileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileBtn.Location = new System.Drawing.Point(86, 178);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(150, 154);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // usersInputModuleBtn
            // 
            this.usersInputModuleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usersInputModuleBtn.BackgroundImage")));
            this.usersInputModuleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usersInputModuleBtn.Location = new System.Drawing.Point(326, 178);
            this.usersInputModuleBtn.Name = "usersInputModuleBtn";
            this.usersInputModuleBtn.Size = new System.Drawing.Size(150, 154);
            this.usersInputModuleBtn.TabIndex = 1;
            this.usersInputModuleBtn.UseVisualStyleBackColor = true;
            this.usersInputModuleBtn.Click += new System.EventHandler(this.usersInputModuleBtn_Click);
            // 
            // borrowedBooksModuleBtn
            // 
            this.borrowedBooksModuleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("borrowedBooksModuleBtn.BackgroundImage")));
            this.borrowedBooksModuleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borrowedBooksModuleBtn.Location = new System.Drawing.Point(565, 178);
            this.borrowedBooksModuleBtn.Name = "borrowedBooksModuleBtn";
            this.borrowedBooksModuleBtn.Size = new System.Drawing.Size(150, 154);
            this.borrowedBooksModuleBtn.TabIndex = 3;
            this.borrowedBooksModuleBtn.UseVisualStyleBackColor = true;
            this.borrowedBooksModuleBtn.Click += new System.EventHandler(this.borrowedBooksModuleBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.exitBtn.Location = new System.Drawing.Point(33, 27);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(51, 25);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(299, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Student\'s Module";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(523, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Borrowed Books Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(309, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "User\'s Input Module";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Profile";
            // 
            // studentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.borrowedBooksModuleBtn);
            this.Controls.Add(this.usersInputModuleBtn);
            this.Controls.Add(this.profileBtn);
            this.DoubleBuffered = true;
            this.Name = "studentDashboard";
            this.Text = "studentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button profileBtn;
        private Button usersInputModuleBtn;
        private Button borrowedBooksModuleBtn;
        private Label exitBtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}