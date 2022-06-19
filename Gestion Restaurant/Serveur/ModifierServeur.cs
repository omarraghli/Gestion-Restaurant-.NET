using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Restaurant.Serveur
{
    public partial class ModifierServeur : Form
    {
        Model1 db = new Model1();
        int IdToUpdate;

        public ModifierServeur()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            string NomModifier = NomModifierText.Text;
            string PrenomModifier = PrenomModifierText.Text;

            var serveur = db.serveurs.Where(u => u.nom == (string)NomModifier && u.prenom == (string)PrenomModifier).First();
            IdToUpdate = serveur.id;
            NomNewText.Text = NomModifier;
            PrenomNewText.Text = PrenomModifier;

            Suivant.Visible = false;
            NomNewText.Visible = true;
            Sauvgarderbtn.Visible = true;
            PrenomNewText.Visible = true;
            NvxNom.Visible = true;
            NvxPrenom.Visible = true;
        }

        private void Sauvgarderbtn_Click(object sender, EventArgs e)
        {

            var srv = db.serveurs.Find(IdToUpdate);

            srv.nom = NomNewText.Text;
            srv.prenom = PrenomNewText.Text;

            db.SaveChanges();


            NomModifierText.ResetText();
            PrenomModifierText.ResetText();
            NomNewText.ResetText();
            PrenomNewText.ResetText();
        }

        private void NomModifierText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NvxNom_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NomNewText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}