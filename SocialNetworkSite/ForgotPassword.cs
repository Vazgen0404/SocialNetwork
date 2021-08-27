using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SocialNetworkSite
{
    public partial class ForgotPassword : Form
    {
        SocialNetworkContext accounts = new SocialNetworkContext();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void lbBackToSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.CloseForms();
            MainForm.ShowForm("SignIn");
        }
        private void btRequest_Click(object sender, EventArgs e)
        {
            if (tbEmailForgotPassword.Text != "Email address")
            {
                if (IsExistEmail(tbEmailForgotPassword.Text))
                {
                    MainForm.passwordCode = MainForm.RandomNumbers();
                    MainForm.email = tbEmailForgotPassword.Text;
                    MainForm.SendingEmail(tbEmailForgotPassword.Text, $"One-time password change code is {MainForm.passwordCode}", "Password recovery");
                    MessageBox.Show("The change code has been sent to your email address", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm.ClearTextBoxes(gbForgotPassword);
                    MainForm.CloseForms();
                    MainForm.ShowForm("ChangePassword");

                }
                else
                {
                    MainForm.MessageBoxShow("This email does not exist");
                }
            }
            else
            {
                MainForm.MessageBoxShow("Please enter the email");
            }

        }

        private bool IsExistEmail(string email)
        {
            if (accounts.Users.Count(user => user.Email == email) > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
