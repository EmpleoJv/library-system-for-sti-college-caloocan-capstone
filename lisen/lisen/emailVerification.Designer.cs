namespace lisen
{
    partial class emailVerification
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
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitCodeBtn = new System.Windows.Forms.Button();
            this.codeTxb = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input the Verification Code";
            // 
            // SubmitCodeBtn
            // 
            this.SubmitCodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.SubmitCodeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitCodeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.SubmitCodeBtn.Location = new System.Drawing.Point(69, 126);
            this.SubmitCodeBtn.Name = "SubmitCodeBtn";
            this.SubmitCodeBtn.Size = new System.Drawing.Size(93, 41);
            this.SubmitCodeBtn.TabIndex = 1;
            this.SubmitCodeBtn.Text = "Submit";
            this.SubmitCodeBtn.UseVisualStyleBackColor = false;
            this.SubmitCodeBtn.Click += new System.EventHandler(this.SubmitCodeBtn_Click);
            // 
            // codeTxb
            // 
            this.codeTxb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codeTxb.Location = new System.Drawing.Point(46, 91);
            this.codeTxb.Multiline = true;
            this.codeTxb.Name = "codeTxb";
            this.codeTxb.Size = new System.Drawing.Size(150, 29);
            this.codeTxb.TabIndex = 2;
            this.codeTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOnly);
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
            this.exitBtn.TabIndex = 34;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // emailVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 195);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.codeTxb);
            this.Controls.Add(this.SubmitCodeBtn);
            this.Controls.Add(this.label1);
            this.Name = "emailVerification";
            this.Text = "emailVerification";
            this.Load += new System.EventHandler(this.emailVerification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button SubmitCodeBtn;
        private TextBox codeTxb;
        private Label exitBtn;
    }
}