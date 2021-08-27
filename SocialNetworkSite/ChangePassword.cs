using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SocialNetworkSite
{
    public partial class ChangePassword : Form
    {
        SocialNetworkContext accounts = new SocialNetworkContext();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text != "" && tbConfirmNewPassword.Text != "")
            {
                if (tbChangeCode.Text == MainForm.passwordCode)
                {
                    if (ValidationPassword(tbNewPassword.Text))
                    {
                        if (tbNewPassword.Text == tbConfirmNewPassword.Text)
                        {

                            using (SHA256 sha = SHA256.Create())
                            {
                                User user = accounts.Users.FirstOrDefault(user => user.Email == MainForm.email);
                                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(tbNewPassword.Text));

                                StringBuilder builder = new StringBuilder();
                                for (int i = 0; i < bytes.Length; i++)
                                {
                                    builder.Append(bytes[i].ToString("x2"));
                                }
                                user.Password = builder.ToString();
                                accounts.SaveChanges();
                                DialogResult result = MessageBox.Show("Your password successfully changed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (result == DialogResult.OK)
                                {
                                    MainForm.ClearTextBoxes(gbChangingPassword);
                                    MainForm.CloseForms();
                                    MainForm.ShowForm("SignIn");

                                }
                            }
                        }
                        else
                        {
                            MainForm.MessageBoxShow("Please confirm the password");
                        }
                    }
                    else
                    {
                        MainForm.MessageBoxShow("This password is not valid");
                    }
                }
                else
                {
                    MainForm.MessageBoxShow("The change code is incorrect");
                }

            }
            else MainForm.MessageBoxShow("Please insert all fields");


        }
        private bool ValidationPassword(string password)
        {
            Regex rg = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[-.]).{6,15}$");
            if (rg.IsMatch(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

}
