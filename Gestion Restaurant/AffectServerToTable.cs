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
    public partial class AffectServerToTable : Form
    {
        Model1 db = new Model1();
        public AffectServerToTable()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SuivantBtn_Click(object sender, EventArgs e)
        {
            string NomServeur = NomServeurText.Text;
            string PrenomServeur = PrenomServeurText.Text;

            var serveur = db.serveurs.Where(u => u.nom == (string)NomServeur && u.prenom == (string)PrenomServeur).First();

            SuivantBtn.Visible = false;
         //   InfoText.Visible = true;
            IdTableText.Visible = true;
            IdTableLabel.Visible = true;
            SauvagrderBtn.Visible = true;
        }

        private void SauvagrderBtn_Click(object sender, EventArgs e)
        {
            string NomServeur = NomServeurText.Text;
            string PrenomServeur = PrenomServeurText.Text;
            int NumTable = int.Parse(IdTableText.Text);

            var serveur = db.serveurs.Where(u => u.nom == (string)NomServeur && u.prenom == (string)PrenomServeur).First();
            var table = db.tables.Find(NumTable);
            table.serveurs.Add(serveur);
            //serveur.tables.Add(table);
            db.SaveChanges();

            msg.Text = "affecté avec succé";
        }
    }
}
