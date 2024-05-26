namespace lisen
{
    partial class profile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seeOrNotBtn = new System.Windows.Forms.Button();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.passViewer = new System.Windows.Forms.TextBox();
            this.emailViewer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sectionViewer = new System.Windows.Forms.Label();
            this.userViewer = new System.Windows.Forms.Label();
            this.courseViewer = new System.Windows.Forms.Label();
            this.lastnameViewer = new System.Windows.Forms.Label();
            this.firstnameViewer = new System.Windows.Forms.Label();
            this.statusViewer = new System.Windows.Forms.Label();
            this.studNoViewer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.exitBtn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.seeOrNotBtn);
            this.groupBox1.Controls.Add(this.changePassBtn);
            this.groupBox1.Controls.Add(this.passViewer);
            this.groupBox1.Controls.Add(this.emailViewer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sectionViewer);
            this.groupBox1.Controls.Add(this.userViewer);
            this.groupBox1.Controls.Add(this.courseViewer);
            this.groupBox1.Controls.Add(this.lastnameViewer);
            this.groupBox1.Controls.Add(this.firstnameViewer);
            this.groupBox1.Controls.Add(this.statusViewer);
            this.groupBox1.Controls.Add(this.studNoViewer);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // seeOrNotBtn
            // 
            this.seeOrNotBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seeOrNotBtn.BackgroundImage")));
            this.seeOrNotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.seeOrNotBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seeOrNotBtn.Location = new System.Drawing.Point(404, 161);
            this.seeOrNotBtn.Name = "seeOrNotBtn";
            this.seeOrNotBtn.Size = new System.Drawing.Size(40, 36);
            this.seeOrNotBtn.TabIndex = 22;
            this.seeOrNotBtn.UseVisualStyleBackColor = true;
            this.seeOrNotBtn.Click += new System.EventHandler(this.seeOrNotBtn_Click);
            // 
            // changePassBtn
            // 
            this.changePassBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changePassBtn.Location = new System.Drawing.Point(450, 161);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(94, 36);
            this.changePassBtn.TabIndex = 21;
            this.changePassBtn.Text = "Change";
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // passViewer
            // 
            this.passViewer.Location = new System.Drawing.Point(180, 163);
            this.passViewer.Name = "passViewer";
            this.passViewer.PasswordChar = '*';
            this.passViewer.Size = new System.Drawing.Size(218, 32);
            this.passViewer.TabIndex = 20;
            // 
            // emailViewer
            // 
            this.emailViewer.AutoSize = true;
            this.emailViewer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailViewer.Location = new System.Drawing.Point(179, 83);
            this.emailViewer.Name = "emailViewer";
            this.emailViewer.Size = new System.Drawing.Size(108, 25);
            this.emailViewer.TabIndex = 19;
            this.emailViewer.Text = "------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // sectionViewer
            // 
            this.sectionViewer.AutoSize = true;
            this.sectionViewer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sectionViewer.Location = new System.Drawing.Point(548, 107);
            this.sectionViewer.Name = "sectionViewer";
            this.sectionViewer.Size = new System.Drawing.Size(108, 25);
            this.sectionViewer.TabIndex = 17;
            this.sectionViewer.Text = "------------";
            // 
            // userViewer
            // 
            this.userViewer.AutoSize = true;
            this.userViewer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userViewer.Location = new System.Drawing.Point(178, 107);
            this.userViewer.Name = "userViewer";
            this.userViewer.Size = new System.Drawing.Size(108, 25);
            this.userViewer.TabIndex = 12;
            this.userViewer.Text = "------------";
            // 
            // courseViewer
            // 
            this.courseViewer.AutoSize = true;
            this.courseViewer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseViewer.Location = new System.Drawing.Point(548, 82);
            this.courseViewer.Name = "courseViewer";
            this.courseViewer.Size = new System.Drawing.Size(108, 25);
            this.courseViewer.TabIndex = 16;
            this.courseViewer.Text = "------------";
            // 
            // lastnameViewer
            // 
            this.lastnameViewer.AutoSize = true;
            this.lastnameViewer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastnameViewer.Location = new System.Drawing.Point(548, 57);
            this.lastnameViewer.Name = "lastnameViewer";
            this.lastnameViewer.Size = new System.Drawing.Size(108, 25);
            this.lastnameViewer.TabIndex = 15;
            this.lastnameViewer.Text = "------------";
            // 
            // firstnameViewer
            // 
            this.firstnameViewer.AutoSize = true;
            this.firstnameViewer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameViewer.Location = new System.Drawing.Point(548, 32);
            this.firstnameViewer.Name = "firstnameViewer";
            this.firstnameViewer.Size = new System.Drawing.Size(108, 25);
            this.firstnameViewer.TabIndex = 14;
            this.firstnameViewer.Text = "------------";
            // 
            // statusViewer
            // 
            this.statusViewer.AutoSize = true;
            this.statusViewer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusViewer.Location = new System.Drawing.Point(178, 57);
            this.statusViewer.Name = "statusViewer";
            this.statusViewer.Size = new System.Drawing.Size(108, 25);
            this.statusViewer.TabIndex = 11;
            this.statusViewer.Text = "------------";
            // 
            // studNoViewer
            // 
            this.studNoViewer.AutoSize = true;
            this.studNoViewer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studNoViewer.Location = new System.Drawing.Point(178, 32);
            this.studNoViewer.Name = "studNoViewer";
            this.studNoViewer.Size = new System.Drawing.Size(108, 25);
            this.studNoViewer.TabIndex = 10;
            this.studNoViewer.Text = "------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Section:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Course:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lastname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Firstname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No.:";
            // 
            // errorEmpty
            // 
            this.errorEmpty.ContainerControl = this;
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
            this.exitBtn.TabIndex = 32;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 279);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label studNoViewer;
        private Label emailViewer;
        private Label sectionViewer;
        private Label courseViewer;
        private Label lastnameViewer;
        private Label firstnameViewer;
        private Label userViewer;
        private Label statusViewer;
        private TextBox passViewer;
        private Button changePassBtn;
        private Button seeOrNotBtn;
        private ErrorProvider errorEmpty;
        private Label exitBtn;
    }
}