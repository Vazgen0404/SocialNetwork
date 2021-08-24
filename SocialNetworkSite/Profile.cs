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
    public partial class Profile : Form
    {
        SocialNetworkContext context = new SocialNetworkContext();
        string image;

        public Profile()
        {
            InitializeComponent();
        }


        public void LoadDatas()
        {
            User user = null;
            if (MainForm.ViewProfil == null && MainForm.SignedEmail == null)
            {
                MainForm.CloseForm("Account");
                MainForm.ShowForm("SignIn");
                MainForm.SignInLoadPage = "Profile";
            }
            else if (MainForm.ViewProfil == null)
            {
                user = context.Users.FirstOrDefault(user => user.Email == MainForm.SignedEmail);
            }
            else
            {
                user = context.Users.FirstOrDefault(user => user.Email == MainForm.ViewProfil);
            }

            if (user!=null)
            {
                if (user.Picture != null)
                {
                    MemoryStream mstream = new MemoryStream(user.Picture);
                    pictureProfil.Image = Image.FromStream(mstream);
                }
                else
                {
                    pictureProfil.Image = new Bitmap(Properties.Resources.user_account_icon_vector_12896453);
                }
                lbFirstName.Text = user.FirstName;
                lbLastName.Text = user.LastName;
                lbEmail.Text = user.Email;
                lbBirthday.Text = user.BirthdayDate == null ? "" : user.BirthdayDate;
                lbPhone.Text = user.PhoneNumber == null ? "" : user.PhoneNumber;
                lbAddress.Text = user.Address == null ? "" : user.Address;
                lbGender.Text = user.Gender == null ? "" : user.Gender;

                panelEditing.Visible = false;
                btEdit.Visible = true;
                if (MainForm.SignedEmail != MainForm.ViewProfil && MainForm.ViewProfil != null)
                {
                    btEdit.Visible = false;
                }
                
            }
            MainForm.ViewProfil = null;
        }

        private void btUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opnfd = new OpenFileDialog())
            {

                opnfd.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    pictureProfilCHange.Image = Image.FromFile(opnfd.FileName);
                    image = opnfd.FileName;
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            panelEditing.Visible = true;
            User user = context.Users.FirstOrDefault(user => user.Email == MainForm.SignedEmail);

            tbFirstName.Text = user.FirstName;
            tbLastName.Text = user.LastName;
            tbEmail.Text = user.Email;
            dtBirthday.Text = user.BirthdayDate == null ? "" : user.BirthdayDate;
            tbPhone.Text = user.PhoneNumber == null ? "" : user.PhoneNumber;
            tbAddress.Text = user.Address == null ? "" : user.Address;
            if (user.Gender == "Male")
            {
                checkBoxMale.Checked = true;
            }
            else if (user.Gender == "Female")
            {
                checkBoxFemale.Checked = true;
            }
            if (user.Picture != null)
            {
                MemoryStream mstream = new MemoryStream(user.Picture);
                pictureProfilCHange.Image = Image.FromStream(mstream);
            }
            else
            {
                pictureProfilCHange.Image = new Bitmap(Properties.Resources.user_account_icon_vector_12896453);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            panelEditing.Visible = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            User user = context.Users.FirstOrDefault(user => user.Email == lbEmail.Text);
            user.BirthdayDate = dtBirthday.Value.Date.ToShortDateString();
            user.Address = tbAddress.Text;
            if (checkBoxMale.Checked)
            {
                user.Gender = "Male";
            }
            else if (checkBoxFemale.Checked)
            {
                user.Gender = "Female";
            }
            user.PhoneNumber = tbPhone.Text;
            if (image != null)
            {
                using (FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read))
                {
                    user.Picture = new byte[fs.Length];
                    fs.Read(user.Picture);
                }
            }

            context.SaveChanges();
            DialogResult result = MessageBox.Show("Your data has been successfully modified", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                LoadDatas();
                panelEditing.Visible = false;
            }

            image = null;
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked)
            {
                checkBoxFemale.Checked = false;
            }
            else
            {
                checkBoxFemale.Checked = true;
            }
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked)
            {
                checkBoxMale.Checked = false;
            }
            else
            {
                checkBoxMale.Checked = true;
            }
        }
    }
}
