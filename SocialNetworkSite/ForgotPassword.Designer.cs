
namespace SocialNetworkSite
{
    partial class ForgotPassword
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
            this.gbForgotPassword = new System.Windows.Forms.GroupBox();
            this.lbBackToSignIn = new System.Windows.Forms.LinkLabel();
            this.btRequest = new System.Windows.Forms.Button();
            this.tbEmailForgotPassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbForgotPassword
            // 
            this.gbForgotPassword.Controls.Add(this.lbBackToSignIn);
            this.gbForgotPassword.Controls.Add(this.btRequest);
            this.gbForgotPassword.Controls.Add(this.tbEmailForgotPassword);
            this.gbForgotPassword.Controls.Add(this.label15);
            this.gbForgotPassword.Controls.Add(this.label14);
            this.gbForgotPassword.Controls.Add(this.label13);
            this.gbForgotPassword.Location = new System.Drawing.Point(0, 0);
            this.gbForgotPassword.Name = "gbForgotPassword";
            this.gbForgotPassword.Size = new System.Drawing.Size(602, 447);
            this.gbForgotPassword.TabIndex = 7;
            this.gbForgotPassword.TabStop = false;
            // 
            // lbBackToSignIn
            // 
            this.lbBackToSignIn.AutoSize = true;
            this.lbBackToSignIn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBackToSignIn.Location = new System.Drawing.Point(226, 371);
            this.lbBackToSignIn.Name = "lbBackToSignIn";
            this.lbBackToSignIn.Size = new System.Drawing.Size(136, 25);
            this.lbBackToSignIn.TabIndex = 20;
            this.lbBackToSignIn.TabStop = true;
            this.lbBackToSignIn.Text = "Back to Sign In";
            this.lbBackToSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbBackToSignIn_LinkClicked);
            // 
            // btRequest
            // 
            this.btRequest.BackColor = System.Drawing.Color.ForestGreen;
            this.btRequest.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRequest.ForeColor = System.Drawing.SystemColors.Control;
            this.btRequest.Location = new System.Drawing.Point(72, 266);
            this.btRequest.Name = "btRequest";
            this.btRequest.Size = new System.Drawing.Size(457, 55);
            this.btRequest.TabIndex = 19;
            this.btRequest.TabStop = false;
            this.btRequest.Text = "Request password reset";
            this.btRequest.UseVisualStyleBackColor = false;
            this.btRequest.Click += new System.EventHandler(this.btRequest_Click);
            // 
            // tbEmailForgotPassword
            // 
            this.tbEmailForgotPassword.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmailForgotPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbEmailForgotPassword.Location = new System.Drawing.Point(72, 200);
            this.tbEmailForgotPassword.Name = "tbEmailForgotPassword";
            this.tbEmailForgotPassword.PlaceholderText = "Email address";
            this.tbEmailForgotPassword.Size = new System.Drawing.Size(457, 33);
            this.tbEmailForgotPassword.TabIndex = 9;
            this.tbEmailForgotPassword.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(72, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 30);
            this.label15.TabIndex = 8;
            this.label15.Text = "Email address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(72, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(351, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "Please enter the email you use to sign in";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(130, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(333, 40);
            this.label13.TabIndex = 6;
            this.label13.Text = "Forgot your password?";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 448);
            this.Controls.Add(this.gbForgotPassword);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.gbForgotPassword.ResumeLayout(false);
            this.gbForgotPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel lbBackToSignIn;
        private System.Windows.Forms.Button btRequest;
        private System.Windows.Forms.TextBox tbEmailForgotPassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.GroupBox gbForgotPassword;
    }
}