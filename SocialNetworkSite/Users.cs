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
    public partial class Users : Form
    {
        SocialNetworkContext context = new SocialNetworkContext();
        
        public Users()
        {
            InitializeComponent();
           
        }

        private void Users_Load(object sender, EventArgs e)
        {
            int pictureX = 39;
            int pictureY = 12;
            int labelX = 65;
            int labelY = 159;
            int count = 0;
            foreach (User user in context.Users)
            {
                PictureBox picture = new PictureBox();
                if (user.Picture != null)
                {
                    MemoryStream mstream = new MemoryStream(user.Picture);
                    picture.Image = Image.FromStream(mstream);
                }
                else
                {
                    picture.Image = new Bitmap(Properties.Resources.user_account_icon_vector_12896453);
                }

                picture.Location = new Point(pictureX, pictureY);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Size = new Size(169, 144);
                picture.Name = user.Email;
                picture.Click += Picture_Click;
                picture.Cursor = Cursors.Hand;

                Label label = new Label();
                label.Location = new Point(labelX, labelY);
                label.Size = new Size(165, 20);
                label.Text = user.FirstName + " " + user.LastName;
                this.Controls.Add(picture);
                this.Controls.Add(label);
                count++;
                pictureX += 240;
                labelX += 240;
                if (count == 3)
                {
                    pictureX = 39;
                    labelX = 63;
                    pictureY += 207;
                    labelY += 207;
                    count = 0;
                }

            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            MainForm.ViewProfil = picture.Name;
            Account.ViewProfile();
        }
    }
}
