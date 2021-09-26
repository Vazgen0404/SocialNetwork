using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworkSite
{
    public partial class MainForm : Form, IDisposable
    {
        public SocialNetworkContext accounts = new SocialNetworkContext();
        public static string SignedEmail = null;

        public static string passwordCode;
        public static string email;


        public static List<Form> forms = new List<Form>();
        public static List<Button> buttons = new List<Button>();

        public static string ViewProfil = null;
        public static string SignInLoadPage = null;
        public static string ColourTheme = "Light";

        public MainForm()
        {
            InitializeComponent();

            Registration registration = new Registration();
            SignIn signIn = new SignIn();
            ForgotPassword forgotPassword = new ForgotPassword();
            ChangePassword changePassword = new ChangePassword();
            Account account = new Account();

            forms.Add(registration);
            forms.Add(signIn);
            forms.Add(forgotPassword);
            forms.Add(changePassword);
            forms.Add(account);


            foreach (Form form in forms)
            {
                form.TopLevel = false;
                panel.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;

                form.Location = new Point((this.panel.ClientSize.Width - form.ClientSize.Width) / 2,
                                  (this.panel.ClientSize.Height - form.ClientSize.Height) / 2);

            }
            forms.Add(this);
            buttons.Add(btRegister);
            buttons.Add(btSignIn);

        }



        public static void ShowForm(string formname)
        {

            Form form = forms.FirstOrDefault(form => form.Name == formname);
            form.Show();

        }
        public static void CloseForms()
        {
            foreach (Form form in forms)
            {
                if (form.Name != "MainForm")
                {
                    form.Hide();
                }

            }
        }

        public static void MessageBoxShow(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            panelMain.Location = new Point((this.ClientSize.Width - panelMain.ClientSize.Width) / 2,
                                            (this.ClientSize.Height - panelMain.ClientSize.Height) / 2);
        }




        public static void ClearTextBoxes(GroupBox groupBox)
        {
            foreach (Control textbox in groupBox.Controls)
            {
                if (textbox is TextBox)
                {
                    textbox.Text = "";
                }

            }
        }
        public static string RandomNumbers()
        {
            int n1 = new Random().Next(0, 10);
            int n2 = new Random().Next(0, 10);
            int n3 = new Random().Next(0, 10);
            int n4 = new Random().Next(0, 10);
            int n5 = new Random().Next(0, 10);
            int n6 = new Random().Next(0, 10);
            string code = "" + n1 + n2 + n3 + n4 + n5 + n6;
            return code;
        }

        public static void SendingEmail(string email, string text, string subject)
        {

            User user = new SocialNetworkContext().Users.FirstOrDefault(user => user.Email == email);


            MailAddress From = new MailAddress("vazgen_avetisyan0404@mail.ru", "Social Network");
            MailAddress To = new MailAddress(email);
            MailMessage message = new MailMessage(From, To);
            message.Subject = subject;
            message.Body = text;
            message.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("vazgen_avetisyan0404@mail.ru", "vvv7770404");
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string userEmail = accounts.SavedAccounts.FirstOrDefault(User => User.MachineName == Environment.MachineName)==null ? "":
                accounts.SavedAccounts.FirstOrDefault(User => User.MachineName == Environment.MachineName).UserEmail;                                                                
                               
            if (userEmail != "")
            {
                MainForm.SignedEmail = userEmail;

                MainForm.CloseForms();
                MainForm.SignIn();
                MainForm.ColourTheme = accounts.Users.FirstOrDefault(User => User.Email == MainForm.SignedEmail).ColourTheme ?? "Light";
                Settings.ChangeCheck();
                MainForm.ChangeColourTheme1();
                Account.ChangeColourTheme2();
            }
                ShowForm("Account");                   
           
        }

        public static void ChangeColourTheme1()
        {
            if (ColourTheme == "Blue")
            {

                MainForm form = (MainForm)forms[5];
                form.BackColor = SystemColors.Highlight;
                Registration registration = (Registration)forms[0];
                registration.gbRegister.BackColor = SystemColors.Highlight;
                SignIn signIn = (SignIn)forms[1];
                signIn.gbLogin.BackColor = SystemColors.Highlight;
                ForgotPassword forgotPassword = (ForgotPassword)forms[2];
                forgotPassword.gbForgotPassword.BackColor = SystemColors.Highlight;
                ChangePassword changePassword = (ChangePassword)forms[3];
                changePassword.gbChangingPassword.BackColor = SystemColors.Highlight;
                Account account = (Account)forms[4];
                account.panel.BackColor = SystemColors.Highlight;
                account.panelGb.BackColor = SystemColors.Highlight;

            }
            else if (ColourTheme == "Light")
            {
                MainForm form = (MainForm)forms[5];
                form.BackColor = SystemColors.Control;
                Registration registration = (Registration)forms[0];
                registration.gbRegister.BackColor = SystemColors.Control;
                SignIn signIn = (SignIn)forms[1];
                signIn.gbLogin.BackColor = SystemColors.Control;
                ForgotPassword forgotPassword = (ForgotPassword)forms[2];
                forgotPassword.gbForgotPassword.BackColor = SystemColors.Control;
                ChangePassword changePassword = (ChangePassword)forms[3];
                changePassword.gbChangingPassword.BackColor = SystemColors.Control;
                Account account = (Account)forms[4];
                account.panel.BackColor = SystemColors.Control;
                account.panelGb.BackColor = SystemColors.Control;

            }
        }
        private void btRegister_Click(object sender, EventArgs e)
        {
            CloseForms();
            ShowForm("Registration");
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            if (btSignIn.Text == "Sign In")
            {
                CloseForms();
                ShowForm("SignIn");
            }
            else if (btSignIn.Text == "Log Out")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to leave?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SavedAccount savedAccount = accounts.SavedAccounts.FirstOrDefault(User => User.UserEmail == MainForm.SignedEmail);
                    accounts.SavedAccounts.Remove(savedAccount);
                    accounts.SaveChanges();

                    LogOut();
                    CloseForms();
                    ShowForm("Account");
                    Users.LoadPictures();
                    Account.ShowHomePageUsers();
       
                }
            }
        }
        private void lbSocialNetwork_Click(object sender, EventArgs e)
        {
            CloseForms();
            ShowForm("Account");
            Users.LoadPictures();
            Account.ShowHomePageUsers();
        }
        public static void SignIn()
        {
            buttons[0].Visible = false;
            buttons[1].Text = "Log Out";
        }
        public static void LogOut()
        {
            buttons[0].Visible = true;
            buttons[1].Text = "Sign In";
            SignedEmail = null;
        }
    }
}


