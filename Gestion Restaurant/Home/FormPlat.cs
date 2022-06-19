using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Restaurant.Home
{
    public partial class FormPlat : Form
    {
        private Button CurrentButton;
        private Form activeForm;
        public FormPlat()
        {
            InitializeComponent();
        }


        void ActivateButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if (CurrentButton != (Button)btnSender)
                {
                    disableButton();
                    Color color = Color.FromArgb(21, 153, 180);
                    CurrentButton = (Button)btnSender;
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;

                }
            }
        }


        void disableButton()
        {
            foreach (Control previousbtn in panelMenuPlat.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.DimGray;
                    previousbtn.ForeColor = Color.White;



                }
            }
        }


        void OpenChildForm(Form childform, Object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            ActivateButton(btnsender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelchildrenPlat.Controls.Add(childform);
            this.panelchildrenPlat.Tag = childform;
            childform.BringToFront();
            childform.Show();


        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AjouterPlat(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Plat.ModifierPlat(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Plat.AfficherPlats(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
