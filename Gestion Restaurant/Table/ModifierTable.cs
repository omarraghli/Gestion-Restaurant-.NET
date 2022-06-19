using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Restaurant.Table
{
    public partial class ModifierTable : Form
    {
        Model1 db = new Model1();

        int NumTable;
        int Capacite;
        public ModifierTable()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SuivantBtn_Click(object sender, EventArgs e)
        {
             NumTable = int.Parse(IdToUpdateText.Text);
            var tbl = db.tables.Find(NumTable);
            CapaciteNewText.Visible = true;
            CapaciteNvx.Visible = true;
            SauvagrderBtn.Visible = true;
            SuivantBtn.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SauvagrderBtn_Click(object sender, EventArgs e)
        {
            Capacite = int.Parse(CapaciteNewText.Text);
            var tbl = db.tables.Find(NumTable);
            tbl.capacite = Capacite;
            db.SaveChanges();

            IdToUpdateText.ResetText();
            CapaciteNewText.ResetText();
        }
    }
}
