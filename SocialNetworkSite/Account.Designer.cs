
namespace SocialNetworkSite
{
    partial class Account
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
            this.panelGb = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.lbSettings = new System.Windows.Forms.Label();
            this.lbCities = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.Label();
            this.lbProfile = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGb
            // 
            this.panelGb.Location = new System.Drawing.Point(145, 0);
            this.panelGb.Name = "panelGb";
            this.panelGb.Size = new System.Drawing.Size(730, 600);
            this.panelGb.TabIndex = 5;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.lbSettings);
            this.panel.Controls.Add(this.lbCities);
            this.panel.Controls.Add(this.lbUsers);
            this.panel.Controls.Add(this.lbProfile);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(139, 600);
            this.panel.TabIndex = 4;
            // 
            // lbSettings
            // 
            this.lbSettings.AutoSize = true;
            this.lbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSettings.Location = new System.Drawing.Point(26, 176);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(79, 25);
            this.lbSettings.TabIndex = 3;
            this.lbSettings.Text = "Settings";
            this.lbSettings.Click += new System.EventHandler(this.lbSettings_Click);
            // 
            // lbCities
            // 
            this.lbCities.AutoSize = true;
            this.lbCities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCities.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCities.Location = new System.Drawing.Point(26, 124);
            this.lbCities.Name = "lbCities";
            this.lbCities.Size = new System.Drawing.Size(58, 25);
            this.lbCities.TabIndex = 2;
            this.lbCities.Text = "Cities";
            this.lbCities.Click += new System.EventHandler(this.lbCities_Click);
            // 
            // lbUsers
            // 
            this.lbUsers.AutoSize = true;
            this.lbUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsers.Location = new System.Drawing.Point(26, 69);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(58, 25);
            this.lbUsers.TabIndex = 1;
            this.lbUsers.Text = "Users";
            this.lbUsers.Click += new System.EventHandler(this.lbUsers_Click);
            // 
            // lbProfile
            // 
            this.lbProfile.AutoSize = true;
            this.lbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbProfile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProfile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbProfile.Location = new System.Drawing.Point(26, 19);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(67, 25);
            this.lbProfile.TabIndex = 0;
            this.lbProfile.Text = "Profile";
            this.lbProfile.Click += new System.EventHandler(this.lbProfile_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 600);
            this.Controls.Add(this.panelGb);
            this.Controls.Add(this.panel);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.Label lbCities;
        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.Label lbProfile;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Panel panelGb;
    }
}