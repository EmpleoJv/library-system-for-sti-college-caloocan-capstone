namespace lisen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usernameTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forgotLble = new System.Windows.Forms.LinkLabel();
            this.seeOrNotBtn = new System.Windows.Forms.Button();
            this.registerTxb = new System.Windows.Forms.Button();
            this.loginTxb = new System.Windows.Forms.Button();
            this.passTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTxb
            // 
            this.usernameTxb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTxb.Location = new System.Drawing.Point(5, 36);
            this.usernameTxb.Multiline = true;
            this.usernameTxb.Name = "usernameTxb";
            this.usernameTxb.Size = new System.Drawing.Size(272, 36);
            this.usernameTxb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.forgotLble);
            this.panel1.Controls.Add(this.registerTxb);
            this.panel1.Controls.Add(this.seeOrNotBtn);
            this.panel1.Controls.Add(this.loginTxb);
            this.panel1.Controls.Add(this.passTxb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.usernameTxb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(472, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 222);
            this.panel1.TabIndex = 2;
            // 
            // forgotLble
            // 
            this.forgotLble.AutoSize = true;
            this.forgotLble.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgotLble.Location = new System.Drawing.Point(71, 189);
            this.forgotLble.Name = "forgotLble";
            this.forgotLble.Size = new System.Drawing.Size(133, 21);
            this.forgotLble.TabIndex = 7;
            this.forgotLble.TabStop = true;
            this.forgotLble.Text = "Forgot Password?";
            this.forgotLble.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotLble_LinkClicked);
            // 
            // seeOrNotBtn
            // 
            this.seeOrNotBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seeOrNotBtn.BackgroundImage")));
            this.seeOrNotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.seeOrNotBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seeOrNotBtn.Location = new System.Drawing.Point(237, 103);
            this.seeOrNotBtn.Name = "seeOrNotBtn";
            this.seeOrNotBtn.Size = new System.Drawing.Size(40, 36);
            this.seeOrNotBtn.TabIndex = 6;
            this.seeOrNotBtn.UseVisualStyleBackColor = true;
            this.seeOrNotBtn.Click += new System.EventHandler(this.seeOrNotBtn_Click);
            // 
            // registerTxb
            // 
            this.registerTxb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.registerTxb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerTxb.BackgroundImage")));
            this.registerTxb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerTxb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerTxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.registerTxb.Location = new System.Drawing.Point(150, 145);
            this.registerTxb.Name = "registerTxb";
            this.registerTxb.Size = new System.Drawing.Size(110, 41);
            this.registerTxb.TabIndex = 5;
            this.registerTxb.Text = "Register";
            this.registerTxb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerTxb.UseVisualStyleBackColor = false;
            this.registerTxb.Click += new System.EventHandler(this.registerTxb_Click);
            // 
            // loginTxb
            // 
            this.loginTxb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.loginTxb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginTxb.BackgroundImage")));
            this.loginTxb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginTxb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginTxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.loginTxb.Location = new System.Drawing.Point(24, 145);
            this.loginTxb.Name = "loginTxb";
            this.loginTxb.Size = new System.Drawing.Size(110, 41);
            this.loginTxb.TabIndex = 4;
            this.loginTxb.Text = "    Login";
            this.loginTxb.UseVisualStyleBackColor = false;
            this.loginTxb.Click += new System.EventHandler(this.loginTxb_Click);
            // 
            // passTxb
            // 
            this.passTxb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passTxb.Location = new System.Drawing.Point(5, 103);
            this.passTxb.Multiline = true;
            this.passTxb.Name = "passTxb";
            this.passTxb.PasswordChar = '*';
            this.passTxb.Size = new System.Drawing.Size(226, 36);
            this.passTxb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 366);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox usernameTxb;
        private Label label1;
        private Panel panel1;
        private Button registerTxb;
        private Button loginTxb;
        private TextBox passTxb;
        private Label label2;
        private Button seeOrNotBtn;
        private LinkLabel forgotLble;
    }
}