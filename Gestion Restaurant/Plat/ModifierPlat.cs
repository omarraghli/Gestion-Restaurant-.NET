using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Restaurant.Plat
{
    
    public partial class ModifierPlat : Form
    {
        private Model1 db = new Model1();
        int IdToUpdate;
        public ModifierPlat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            string TypeModifier = TypeModifierText.Text;
            string LibelleModifier = LibelleModifierText.Text;

            var plat = db.plats.Where(u => u.type == (string)TypeModifier && u.libelle == (string)LibelleModifier).First();
            IdToUpdate = plat.id;
            TypeNewText.Text = TypeModifier;
            LibelleNewText.Text = LibelleModifier;

            Suivant.Visible = false;
            TypeNewText.Visible = true;
            Sauvgarderbtn.Visible = true;
            LibelleNewText.Visible = true;
            NvxLibelle.Visible = true;
            NvxType.Visible = true;

        }

        private void Sauvgarderbtn_Click(object sender, EventArgs e)
        {
            var plt = db.plats.Find(IdToUpdate);

            plt.type = TypeNewText.Text;
            plt.libelle = LibelleNewText.Text;

            db.SaveChanges();

            TypeModifierText.ResetText();
            LibelleModifierText.ResetText();
            TypeNewText.ResetText();
            LibelleNewText.ResetText();
        }
    }
}
