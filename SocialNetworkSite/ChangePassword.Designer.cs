
namespace SocialNetworkSite
{
    partial class ChangePassword
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
            this.gbChangingPassword = new System.Windows.Forms.GroupBox();
            this.tbChangeCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSaveChanges = new System.Windows.Forms.Button();
            this.tbConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gbChangingPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChangingPassword
            // 
            this.gbChangingPassword.Controls.Add(this.tbChangeCode);
            this.gbChangingPassword.Controls.Add(this.label1);
            this.gbChangingPassword.Controls.Add(this.btSaveChanges);
            this.gbChangingPassword.Controls.Add(this.tbConfirmNewPassword);
            this.gbChangingPassword.Controls.Add(this.label18);
            this.gbChangingPassword.Controls.Add(this.tbNewPassword);
            this.gbChangingPassword.Controls.Add(this.label17);
            this.gbChangingPassword.Controls.Add(this.label16);
            this.gbChangingPassword.Location = new System.Drawing.Point(2, 1);
            this.gbChangingPassword.Name = "gbChangingPassword";
            this.gbChangingPassword.Size = new System.Drawing.Size(552, 541);
            this.gbChangingPassword.TabIndex = 8;
            this.gbChangingPassword.TabStop = false;
            // 
            // tbChangeCode
            // 
            this.tbChangeCode.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbChangeCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbChangeCode.Location = new System.Drawing.Point(53, 163);
            this.tbChangeCode.Name = "tbChangeCode";
            this.tbChangeCode.Size = new System.Drawing.Size(457, 33);
            this.tbChangeCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Change code";
            // 
            // btSaveChanges
            // 
            this.btSaveChanges.BackColor = System.Drawing.Color.ForestGreen;
            this.btSaveChanges.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSaveChanges.ForeColor = System.Drawing.SystemColors.Control;
            this.btSaveChanges.Location = new System.Drawing.Point(53, 451);
            this.btSaveChanges.Name = "btSaveChanges";
            this.btSaveChanges.Size = new System.Drawing.Size(457, 55);
            this.btSaveChanges.TabIndex = 1;
            this.btSaveChanges.Text = "Save Changes";
            this.btSaveChanges.UseVisualStyleBackColor = false;
            this.btSaveChanges.Click += new System.EventHandler(this.btSaveChanges_Click);
            // 
            // tbConfirmNewPassword
            // 
            this.tbConfirmNewPassword.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbConfirmNewPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbConfirmNewPassword.Location = new System.Drawing.Point(53, 372);
            this.tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            this.tbConfirmNewPassword.PasswordChar = '*';
            this.tbConfirmNewPassword.Size = new System.Drawing.Size(457, 33);
            this.tbConfirmNewPassword.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(53, 329);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(202, 30);
            this.label18.TabIndex = 11;
            this.label18.Text = "Confirm password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNewPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbNewPassword.Location = new System.Drawing.Point(53, 276);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(457, 33);
            this.tbNewPassword.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(53, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 30);
            this.label17.TabIndex = 9;
            this.label17.Text = "New password";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(105, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(326, 40);
            this.label16.TabIndex = 7;
            this.label16.Text = "Change user password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 542);
            this.Controls.Add(this.gbChangingPassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.gbChangingPassword.ResumeLayout(false);
            this.gbChangingPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbChangeCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSaveChanges;
        private System.Windows.Forms.TextBox tbConfirmNewPassword;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.GroupBox gbChangingPassword;
    }
}