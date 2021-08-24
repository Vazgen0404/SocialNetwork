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
    public partial class Registration : Form
    {
        SocialNetworkContext accounts = new SocialNetworkContext();
        string emailCode = null;
        public Registration()
        {
            InitializeComponent();
        }
        private void btRegister_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                VerifyEmail();
            }
        }

        private string ChangeDesign(string text)
        {
            string poqratar = text.ToLower();
            string mecatar = text.ToUpper();
            string template = null;
            for (int i = 0; i < poqratar.Length; i++)
            {
                if (i == 0)
                {
                    template += mecatar[i];
                }
                else
                {
                    template += poqratar[i];
                }
            }
            return template;
        }

        private bool Validation()
        {
            if (ValidationNames())
            {
                if (ValidationEmail())
                {
                    if (!IsExistEmail(tbEmail.Text))
                    {
                        if (ValidationPassword(tbPassword.Text))
                        {
                            if (ValidationConfirmPassword())
                            {
                                if (ValidationCheckbox())
                                {

                                    return true;
                                }
                                else
                                {
                                    MessageBoxShow("You must accept the Terms of use & Privacy Police");

                                }
                            }
                            else
                            {
                                MessageBoxShow("Please confirm the password");

                            }
                        }
                        else
                        {
                            MessageBoxShow("This password is not valid");

                        }
                    }
                    else
                    {
                        MessageBoxShow("This email is already exist");
                    }
                }
                else
                {
                    MessageBoxShow("Please enter the correct Email");
                }
            }
            else
            {
                MessageBoxShow("Please insert all fields");
            }
            return false;
        }

        private void VerifyEmail()
        {
            checkBox1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            btRegister.Visible = false;
            label8.Visible = false;
            lbSignIn.Visible = false;
            tbEmailCode.Visible = true;
            emailCode = MainForm.RandomNumbers();
            MainForm.SendingEmail(tbEmail.Text, $"Your registration code is {emailCode}", "Registration code");
        }
        private void RegistrationUser()
        {
            User user = new User();
            user.FirstName = ChangeDesign(tbFirstName.Text);
            user.LastName = ChangeDesign(tbLastName.Text);
            user.Email = tbEmail.Text;
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(tbPassword.Text));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                user.Password = builder.ToString();
            }

            accounts.Add(user);
            accounts.SaveChanges();

            MainForm.SendingEmail(tbEmail.Text, "You have successfully registered on a Social Network site", "Registration");
            MainForm.ClearTextBoxes(gbRegister);

            DialogResult result = MessageBox.Show("Registration completed successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainForm.CloseForm("Registration");
                MainForm.ShowForm("SignIn");

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

        private bool ValidationNames()
        {
            foreach (Control textBox in gbRegister.Controls)
            {
                if (textBox is TextBox)
                {
                    switch (textBox.Name)
                    {
                        case "tbFirstName":
                            if (textBox.Text == "First Name")
                            {
                                return false;
                            }
                            break;
                        case "tbLastName":
                            if (textBox.Text == "Last Name")
                            {
                                return false;
                            }
                            break;
                        case "tbEmail":
                            if (textBox.Text == "Email")
                            {
                                return false;
                            }
                            break;
                        case "tbPassword":
                            if (textBox.Text == "Password")
                            {
                                return false;
                            }
                            break;
                        case "tbConfirmPassword":
                            if (textBox.Text == "Confirm Password")
                            {
                                return false;
                            }
                            break;
                        default:
                            break;
                    }
                }

            }
            return true;
        }
        private void MessageBoxShow(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidationCheckbox()
        {
            if (checkBox1.Checked)
            {
                return true;
            }
            return false;
        }

        private bool ValidationConfirmPassword()
        {
            if (tbPassword.Text == tbConfirmPassword.Text)
            {
                return true;
            }
            else return false;
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

        private bool ValidationEmail()
        {
            Regex rg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (rg.IsMatch(tbEmail.Text))
            {
                return true;
            }
            else return false;

        }

        private void lbSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.CloseForm("Registration");
            MainForm.ShowForm("SignIn");
            MainForm.ClearTextBoxes(gbRegister);

        }

        private void tbEmailCode_TextChanged(object sender, EventArgs e)
        {
            if (tbEmailCode.Text == emailCode)
            {
                checkBox1.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                btRegister.Visible = true;
                label8.Visible = true;
                lbSignIn.Visible = true;
                tbEmailCode.Visible = false;
                RegistrationUser();
            }
        }

        private void Registration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btRegister.PerformClick();
            }
        }
    }
}
