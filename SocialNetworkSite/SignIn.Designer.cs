
namespace SocialNetworkSite
{
    partial class SignIn
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.lbCreateAnAccount = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btSignIn = new System.Windows.Forms.Button();
            this.tbPasswordSignIn = new System.Windows.Forms.TextBox();
            this.tbEmailSignIn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.SystemColors.Control;
            this.gbLogin.Controls.Add(this.lbCreateAnAccount);
            this.gbLogin.Controls.Add(this.label12);
            this.gbLogin.Controls.Add(this.lbForgotPassword);
            this.gbLogin.Controls.Add(this.btSignIn);
            this.gbLogin.Controls.Add(this.tbPasswordSignIn);
            this.gbLogin.Controls.Add(this.tbEmailSignIn);
            this.gbLogin.Controls.Add(this.label11);
            this.gbLogin.Controls.Add(this.label10);
            this.gbLogin.Controls.Add(this.label9);
            this.gbLogin.Location = new System.Drawing.Point(1, 1);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(558, 472);
            this.gbLogin.TabIndex = 9;
            this.gbLogin.TabStop = false;
            // 
            // lbCreateAnAccount
            // 
            this.lbCreateAnAccount.AutoSize = true;
            this.lbCreateAnAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCreateAnAccount.Location = new System.Drawing.Point(260, 397);
            this.lbCreateAnAccount.Name = "lbCreateAnAccount";
            this.lbCreateAnAccount.Size = new System.Drawing.Size(165, 25);
            this.lbCreateAnAccount.TabIndex = 21;
            this.lbCreateAnAccount.TabStop = true;
            this.lbCreateAnAccount.Text = "Create an account";
            this.lbCreateAnAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbCreateAnAccount_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(166, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "New user?";
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbForgotPassword.Location = new System.Drawing.Point(347, 197);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(161, 25);
            this.lbForgotPassword.TabIndex = 19;
            this.lbForgotPassword.TabStop = true;
            this.lbForgotPassword.Text = "Forgot password?";
            this.lbForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbForgotPassword_LinkClicked);
            // 
            // btSignIn
            // 
            this.btSignIn.BackColor = System.Drawing.Color.ForestGreen;
            this.btSignIn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btSignIn.Location = new System.Drawing.Point(51, 307);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(457, 55);
            this.btSignIn.TabIndex = 1;
            this.btSignIn.Text = "Sign In";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // tbPasswordSignIn
            // 
            this.tbPasswordSignIn.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPasswordSignIn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPasswordSignIn.Location = new System.Drawing.Point(51, 247);
            this.tbPasswordSignIn.Name = "tbPasswordSignIn";
            this.tbPasswordSignIn.PasswordChar = '*';
            this.tbPasswordSignIn.PlaceholderText = "Password";
            this.tbPasswordSignIn.Size = new System.Drawing.Size(457, 33);
            this.tbPasswordSignIn.TabIndex = 3;
            // 
            // tbEmailSignIn
            // 
            this.tbEmailSignIn.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmailSignIn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbEmailSignIn.Location = new System.Drawing.Point(51, 142);
            this.tbEmailSignIn.Name = "tbEmailSignIn";
            this.tbEmailSignIn.PlaceholderText = "Email address";
            this.tbEmailSignIn.Size = new System.Drawing.Size(457, 33);
            this.tbEmailSignIn.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(51, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 30);
            this.label11.TabIndex = 7;
            this.label11.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(51, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 30);
            this.label10.TabIndex = 6;
            this.label10.Text = "Email address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(143, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(337, 40);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sign in to your account";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 471);
            this.Controls.Add(this.gbLogin);
            this.KeyPreview = true;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignIn_KeyDown);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel lbCreateAnAccount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel lbForgotPassword;
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.TextBox tbPasswordSignIn;
        private System.Windows.Forms.TextBox tbEmailSignIn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.GroupBox gbLogin;
    }
}