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
    public partial class AjouterPlat : Form
    {
        public AjouterPlat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();

            string Libelle = LibelleText.Text;
            string type = TypeText.Text;
            float prix = int.Parse(PrixText.Text);

            plats plt = new plats() {libelle = Libelle, type = type, prix = prix };

            db.plats.Add(plt);
            db.SaveChanges();

            LibelleText.ResetText();
            TypeText.ResetText();
            PrixText.ResetText();
        }
    }
}
