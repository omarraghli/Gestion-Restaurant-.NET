using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Restaurant
{
    public partial class AjouterServeur : Form
    {
        public AjouterServeur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            string Nom = NomText.Text;
            string Prenom = PrenomText.Text;

            serveurs srvr = new serveurs() { nom = Nom, prenom = Prenom };

            db.serveurs.Add(srvr);
            db.SaveChanges();

            NomText.ResetText();
            PrenomText.ResetText();
        }

        private void NomText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BoxNomChange(object sender, MouseEventArgs e)
        {
            if (NomText.Text == "Enter le nom du serveur")
            {
                NomText.Text = "";
                NomText.ForeColor = Color.Black;
            }
        }

        private void BoxPrenomClick(object sender, MouseEventArgs e)
        {
            if (PrenomText.Text == "Entrer le prénom du serveur")
            {
                PrenomText.Text = "";
                PrenomText.ForeColor = Color.Black;
            }
        }

        private void BoxNomLEave(object sender, EventArgs e)
        {
            if (NomText.Text == "")
            {
                NomText.Text = "Enter le nom du serveur";
                NomText.ForeColor = Color.DimGray;
            }
        }

        private void BoxPrenomLeave(object sender, EventArgs e)
        {
            if (PrenomText.Text == "")
            {
                PrenomText.Text = "Entrer le prénom du serveur";
                PrenomText.ForeColor = Color.DimGray;
            }

        }
    }
}
