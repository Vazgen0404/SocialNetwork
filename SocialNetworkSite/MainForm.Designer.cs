
using System.IO;

namespace SocialNetworkSite
{
    partial class MainForm
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
            this.Header = new System.Windows.Forms.GroupBox();
            this.lbSocialNetwork = new System.Windows.Forms.Label();
            this.btSignIn = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Control;
            this.Header.Controls.Add(this.lbSocialNetwork);
            this.Header.Controls.Add(this.btSignIn);
            this.Header.Controls.Add(this.btRegister);
            this.Header.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Header.Location = new System.Drawing.Point(0, 1);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(875, 72);
            this.Header.TabIndex = 7;
            this.Header.TabStop = false;
            // 
            // lbSocialNetwork
            // 
            this.lbSocialNetwork.AutoSize = true;
            this.lbSocialNetwork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSocialNetwork.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSocialNetwork.Location = new System.Drawing.Point(42, 15);
            this.lbSocialNetwork.Name = "lbSocialNetwork";
            this.lbSocialNetwork.Size = new System.Drawing.Size(224, 40);
            this.lbSocialNetwork.TabIndex = 2;
            this.lbSocialNetwork.Text = "Social Network";
            this.lbSocialNetwork.Click += new System.EventHandler(this.lbSocialNetwork_Click);
            // 
            // btSignIn
            // 
            this.btSignIn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSignIn.Location = new System.Drawing.Point(775, 15);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(94, 40);
            this.btSignIn.TabIndex = 1;
            this.btSignIn.TabStop = false;
            this.btSignIn.Text = "Sign In";
            this.btSignIn.UseVisualStyleBackColor = true;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // btRegister
            // 
            this.btRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRegister.Location = new System.Drawing.Point(675, 15);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(94, 40);
            this.btRegister.TabIndex = 0;
            this.btRegister.TabStop = false;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 79);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(875, 600);
            this.panel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(876, 679);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Header);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetwork";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Header;
        private System.Windows.Forms.Label lbSocialNetwork;
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Panel panel;
    }
}

