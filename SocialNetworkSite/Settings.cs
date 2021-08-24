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
    public partial class Settings : Form
    {
        static List<CheckBox> checkBoxes = new List<CheckBox>();
        SocialNetworkContext accounts = new SocialNetworkContext();
        public Settings()
        {
            InitializeComponent();
            checkBoxes.Add(checkBoxLight);
            checkBoxes.Add(checkBoxBlue);
        }

        private void checkBoxLight_Click(object sender, EventArgs e)
        {
            MainForm.ColourTheme = "Light";
            MainForm.ChangeColourTheme1();
            Account.ChangeColourTheme2();
            ChangeUserColourTheme(MainForm.ColourTheme);
            ChangeCheck();
        }

        private void ChangeUserColourTheme(string colourTheme)
        {
            User user = accounts.Users.FirstOrDefault(user => user.Email == MainForm.SignedEmail);
            user.ColourTheme = colourTheme;
            accounts.SaveChanges();
        }

        private void checkBoxBlue_Click(object sender, EventArgs e)
        {
            MainForm.ColourTheme = "Blue";
            ChangeUserColourTheme(MainForm.ColourTheme);
            MainForm.ChangeColourTheme1();
            Account.ChangeColourTheme2();
            ChangeCheck();
        }

        public static void ChangeCheck()
        {
            if (MainForm.ColourTheme == "Light")
            {
                checkBoxes[0].Checked = true;
                checkBoxes[1].Checked = false;
            }
            else if (MainForm.ColourTheme == "Blue")
            {
                checkBoxes[1].Checked = true;
                checkBoxes[0].Checked = false;
            }
        }


    }
}
