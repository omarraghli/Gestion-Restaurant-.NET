using Gestion_Restaurant.Commande;
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
    public partial class FormCommande : Form
    {
        private Button CurrentButton;
        private Form activeForm;
        public FormCommande()
        {
            InitializeComponent();
        }

        void disableButton()
        {
            foreach (Control previousbtn in panelMenuTable.Controls)
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
            this.panel1.Controls.Add(childform);
            this.panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();


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

        private void AddServeurButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AjouterCommande(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AfficherCommande(), sender);
        }
    }
}
