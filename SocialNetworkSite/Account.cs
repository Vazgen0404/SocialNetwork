using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SocialNetworkSite
{
    public partial class Account : Form
    {
        public static List<Form> forms = new List<Form>();
        public static List<Label> labels = new List<Label>();


        public Account()
        {
            InitializeComponent();

            Profile profile = new Profile();
            Users users = new Users();
            Cities cities = new Cities();
            Settings settings = new Settings();

            labels.Add(lbProfile);
            labels.Add(lbUsers);
            labels.Add(lbCities);
            labels.Add(lbSettings);

            forms.Add(profile);
            forms.Add(users);
            forms.Add(cities);
            forms.Add(settings);

            foreach (Form form in forms)
            {
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                panelGb.Controls.Add(form);

            }
        }

        public void lbProfile_Click(object sender, EventArgs e)
        {
            ViewProfile();

        }

        public static void ViewProfile()
        {
            ResetColours();
            ChangeColour(labels[0]);
            HideForms();
            Profile profile = (Profile)forms[0];
            profile.LoadDatas();
            ShowForm(forms[0]);
        }

        public static void ShowForm(Form form)
        {
            form.Show();
        }

        public static void HideForms()
        {
            foreach (Form form in forms)
            {
                form.Hide();
            }
        }

        public static void ChangeColour(Label label)
        {
            label.ForeColor = SystemColors.HotTrack;
        }

        public static void ResetColours()
        {
            foreach (Label label in labels)
            {
                label.ForeColor = SystemColors.WindowText;
            }

        }

        private void lbSettings_Click(object sender, EventArgs e)
        {
            ViewSettings();
        }

        public static void ViewSettings()
        {
            if (MainForm.SignedEmail == null)
            {
                MainForm.CloseForms();
                MainForm.ShowForm("SignIn");
                MainForm.SignInLoadPage = "Settings";
            }
            else
            {
                ResetColours();
                ChangeColour(labels[3]);
                HideForms();
                ShowForm(forms[3]);
            }

        }

        private void lbUsers_Click(object sender, EventArgs e)
        {
            ViewUsers();
        }

        private void ViewUsers()
        {
            ResetColours();
            ChangeColour(labels[1]);
            HideForms();
            ShowForm(forms[1]);
        }

        private void lbCities_Click(object sender, EventArgs e)
        {
            ViewCities();

        }

        public static void ViewCities()
        {
            if (MainForm.SignedEmail == null)
            {
                MainForm.CloseForms();
                MainForm.ShowForm("SignIn");
                MainForm.SignInLoadPage = "Cities";
            }
            else
            {
                ResetColours();
                ChangeColour(labels[2]);
                HideForms();
                ShowForm(forms[2]);
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {
            ShowHomePageUsers();
        }
        public static void ChangeColourTheme2()
        {
            if (MainForm.ColourTheme == "Blue")
            {
                Profile profile = (Profile)forms[0];

                profile.panel.BackColor = SystemColors.HotTrack;
                profile.panelEditing.BackColor = SystemColors.Highlight;
                profile.BackColor = SystemColors.Highlight;
                Users users = (Users)forms[1];
                users.BackColor = SystemColors.Highlight;
                Cities cities = (Cities)forms[2];
                cities.BackColor = SystemColors.Highlight;
                Settings settings = (Settings)forms[3];
                settings.BackColor = SystemColors.Highlight;

            }
            else if (MainForm.ColourTheme == "Light")
            {
                Profile profile = (Profile)forms[0];

                profile.panel.BackColor = SystemColors.ControlDarkDark;
                profile.panelEditing.BackColor = SystemColors.Control;
                profile.BackColor = SystemColors.Control;
                Users users = (Users)forms[1];
                users.BackColor = SystemColors.Control;
                Cities cities = (Cities)forms[2];
                cities.BackColor = SystemColors.Control;
                Settings settings = (Settings)forms[3];
                settings.BackColor = SystemColors.Control;

            }
        }

        
        public static void ShowHomePageUsers()
        {
            ResetColours();
            ChangeColour(labels[1]);
            HideForms();
            ShowForm(forms[1]);
        }


    }
}
