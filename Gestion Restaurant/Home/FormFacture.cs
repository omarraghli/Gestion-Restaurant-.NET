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
    public partial class FormFacture : Form
    {
        public FormFacture()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            var id_commande = int.Parse(textSearch.Text);
            var cmd = db.commandes.Where(x => x.id == id_commande).First();



            BoxNTable.Text = cmd.tableid.ToString();
            BoxPersonne.Text = cmd.nbr_personne.ToString();
            TextModePay.Text = cmd.mode_payment;
            textDateCommande.Text = cmd.date_heur_commande.ToString();
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            BoxNTable.ResetText();
            BoxPersonne.ResetText();
            TextModePay.ResetText();
            textDateCommande.ResetText();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            TextFacture.Clear();

            TextFacture.Text += "\n FACTURE           \n\n";

            TextFacture.Text += "Date :" + DateTime.Now + "\n\n";

            TextFacture.Text += " Numéro de la table :" + BoxNTable.Text + "\n\n";
            TextFacture.Text += " Nombre de Personne :" + BoxPersonne.Text + "\n\n";
            TextFacture.Text += " Mode de Payement :" + TextModePay.Text + "\n\n";
            TextFacture.Text += " Date et heure de la commande :" + textDateCommande.Text + "\n\n";


            Model1 db = new Model1();

            var id_commande = int.Parse(textSearch.Text);
            

            //Selectioner les plats d'une commande
            db.commandes.Where(u => u.id == id_commande).SelectMany(u => u.plats).Distinct().ToList();

            //Sommer les prix d'une commande
            double PrixTotal = 0;

            TextFacture.Text += " Les plats :\n\n";
            foreach (plats element in db.commandes.Where(u => u.id == id_commande).SelectMany(u => u.plats).Distinct().ToList())
            {
                TextFacture.Text += " Type plat :" + element.type + "\n";
                TextFacture.Text += " Libelle plat :" + element.libelle + "\n";
                TextFacture.Text += " Prix plat :" + element.prix + "\n\n";
                PrixTotal += element.prix;
            }

            TextFacture.Text += " Prix Totale :" + PrixTotal + "\n\n";
            System.Diagnostics.Debug.WriteLine(PrixTotal);

        }

        private void buttonImp_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TextFacture.Text, new Font("Microsoft JhengHei", 12, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }
    }
}
