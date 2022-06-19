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
    public partial class AjouterCommande : Form
    {
        Model1 db = new Model1();

        public AjouterCommande()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjouterCommande_Load(object sender, EventArgs e)
        {
            NumeroTableText.DataSource = db.tables.Select(u => u.id).ToList();

            TypePlat1.DataSource = db.plats.Select(u => u.type).Distinct().ToList();
            TypePlat2.DataSource = db.plats.Select(u => u.type).Distinct().ToList();
            TypePlat3.DataSource = db.plats.Select(u => u.type).Distinct().ToList();
        }

        private void AjouterCommandBtn_Click(object sender, EventArgs e)
        {
            int NbrPersonne = (int)NbrPersonneList.Value;
            string ModePaiment = ModePaimentText.Text;
            int NbrTable = int.Parse(NumeroTableText.Text);

            var table = db.tables.Find(NbrTable);
            commandes cmd = new commandes() { date_heur_commande = DateTime.Now, mode_payment = ModePaiment, nbr_personne = NbrPersonne , tables=table };
            db.commandes.Add(cmd);

            var plt1 = db.plats.Where(u => u.type == TypePlat1.Text && u.libelle == Plat1.Text).Select(u => u).FirstOrDefault();
            var plt2 = db.plats.Where(u => u.type == TypePlat2.Text && u.libelle == Plat2.Text).Select(u => u).FirstOrDefault();
            var plt3 = db.plats.Where(u => u.type == TypePlat3.Text && u.libelle == Plat3.Text).Select(u => u).FirstOrDefault();

            cmd.plats.Add(plt1);
            cmd.plats.Add(plt2);
            cmd.plats.Add(plt3);
            db.SaveChanges();

            NbrPersonneList.ResetText();
            ModePaimentText.ResetText();
            NumeroTableText.ResetText();
            TypePlat1.ResetText();
            Plat1.ResetText();
            TypePlat2.ResetText();
            Plat2.ResetText();
            TypePlat3.ResetText();
            Plat3.ResetText();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            Plat1.Visible = true;

            string typeplat = TypePlat1.Text;
            Plat1.DataSource = db.plats.Where(x => x.type == typeplat).Select(u => u.libelle).ToList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            Plat2.Visible = true;

            string typeplat = TypePlat2.Text;
            Plat2.DataSource = db.plats.Where(x => x.type == typeplat).Select(u => u.libelle).ToList();
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label9.Visible = true;
            Plat3.Visible = true;

            string typeplat = TypePlat3.Text;
            Plat3.DataSource = db.plats.Where(x => x.type == typeplat).Select(u => u.libelle).ToList();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
