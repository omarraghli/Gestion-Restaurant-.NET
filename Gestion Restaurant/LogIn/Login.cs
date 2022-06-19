using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Restaurant.LogIn
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nleft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse


            );

        public Login()
        {
            InitializeComponent();
            removeBG(pictureBox1, pictureBox3);
            TextName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TextName.Width, TextName.Height, 15, 15));
            TextPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TextPassword.Width, TextPassword.Height, 15, 15));
            LoginButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginButton.Width, LoginButton.Height, 15, 15));

        }

       
      

        void removeBG(PictureBox pb, PictureBox pb2)
        {
            var pos = this.PointToScreen(pb2.Location);
            pos = pb.PointToClient(pos);
            pb2.Parent = pb;
            pb2.Location = pos;
            pb2.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Username_Changed(object sender, EventArgs e)
        {

        }

        private void TextUsername_Leave(object sender, EventArgs e)
        {
            if (TextName.Text == "")
            {
                TextName.Text = "Nom d'utilisateur";
                TextName.ForeColor = Color.DimGray;
            }
        }

        private void TextName_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextName.Text == "Nom d'utilisateur")
            {
                TextName.Text = "";
                TextName.ForeColor = Color.Black;
            }
        }


        private void TextPassword_Leave(object sender, EventArgs e)
        {
            if (TextPassword.Text == "")
            {
                TextPassword.Text = "Mot de passe";
                TextPassword.ForeColor = Color.DimGray;
            }
        }

        private void TextPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextPassword.Text == "Mot de passe")
            {
                TextPassword.Text = "";
                TextPassword.ForeColor = Color.Black;
            }
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            Model1 db = new Model1();
            var a = db.manager;
           

            if (db.manager.Where(r => r.username == TextName.Text && r.passwrd == TextPassword.Text).Count() > 0)
            {
                Home.HomePage h = new Home.HomePage();
                h.Show();
                this.Hide();
            }
        }
    }
}
