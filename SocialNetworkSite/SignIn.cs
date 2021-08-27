using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SocialNetworkSite
{
    public partial class SignIn : Form
    {
        SocialNetworkContext accounts = new SocialNetworkContext();
        public SignIn()
        {
            InitializeComponent();
        }


        private void lbCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.CloseForms();
            MainForm.ShowForm("Registration");
            MainForm.ClearTextBoxes(gbLogin);

        }
        private void btSignIn_Click(object sender, EventArgs e)
        { 
           
            if (Checking())
            {
                MainForm.SignedEmail = tbEmailSignIn.Text;
                MainForm.ClearTextBoxes(gbLogin);
                
                MainForm.CloseForms();
                MainForm.ShowForm("Account");
                MainForm.ColourTheme = accounts.Users.FirstOrDefault(User => User.Email == MainForm.SignedEmail).ColourTheme ?? "Light";
                Settings.ChangeCheck();
                MainForm.ChangeColourTheme1();
                Account.ChangeColourTheme2();
                switch (MainForm.SignInLoadPage)
                {
                    case "Profile":
                        Account.ViewProfile();
                        break;
                    case "Cities":
                        Account.ViewCities();
                        break;
                    case "Settings":
                        Account.ViewSettings();
                        break;
                    default:
                        break;
                }
            }
        }
        private bool Checking()
        {
            if (AreCompletedFields())
            {
                if (IsExistEmail(tbEmailSignIn.Text))
                {
                    if (IsPasswordTrue())
                    {
                        return true;
                    }
                    else
                    {
                        MainForm.MessageBoxShow("Please enter the correct password");
                    }
                }
                else
                {
                    MainForm.MessageBoxShow("This email does not exist");
                }
            }
            else
            {
                MainForm.MessageBoxShow("Please insert all fields");
            }
            return false;
        }
        private bool IsPasswordTrue()
        {
            User user = accounts.Users.FirstOrDefault(user => user.Email == tbEmailSignIn.Text);
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(tbPasswordSignIn.Text));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                if (user.Password == builder.ToString())
                {
                    return true;
                }
                else return false;
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

        private bool AreCompletedFields()
        {
            if (tbEmailSignIn.Text == "Email address" || tbPasswordSignIn.Text == "Password")
            {
                return false;
            }
            return true;
        }

        private void lbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.CloseForms();
            MainForm.ShowForm("ForgotPassword");
            MainForm.ClearTextBoxes(gbLogin);
        }

        private void SignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSignIn.PerformClick();
            }
        }
    }
}
