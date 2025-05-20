namespace LoginShit
{
    partial class frmLogin
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lnklblClear = new System.Windows.Forms.LinkLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnklblRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(75, 62);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(148, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(75, 99);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(148, 20);
            this.txtPass.TabIndex = 1;
            // 
            // lnklblClear
            // 
            this.lnklblClear.AutoSize = true;
            this.lnklblClear.LinkColor = System.Drawing.Color.Black;
            this.lnklblClear.Location = new System.Drawing.Point(234, 102);
            this.lnklblClear.Name = "lnklblClear";
            this.lnklblClear.Size = new System.Drawing.Size(80, 13);
            this.lnklblClear.TabIndex = 2;
            this.lnklblClear.TabStop = true;
            this.lnklblClear.Text = "Clear Password";
            this.lnklblClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblClear_LinkClicked);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 66);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(75, 149);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(164, 149);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(59, 31);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnklblRegister
            // 
            this.lnklblRegister.AutoSize = true;
            this.lnklblRegister.LinkColor = System.Drawing.Color.Black;
            this.lnklblRegister.Location = new System.Drawing.Point(146, 127);
            this.lnklblRegister.Name = "lnklblRegister";
            this.lnklblRegister.Size = new System.Drawing.Size(75, 13);
            this.lnklblRegister.TabIndex = 7;
            this.lnklblRegister.TabStop = true;
            this.lnklblRegister.Text = "Register Here!";
            this.lnklblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRegister_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 225);
            this.Controls.Add(this.lnklblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lnklblClear);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel lnklblClear;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnklblRegister;
    }
}

