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
    public partial class AjouterTable : Form
    {
        public AjouterTable()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int Capacite = int.Parse(CapaciteText.Text);
            tables tbl = new tables() { capacite = Capacite };
            db.tables.Add(tbl);
            db.SaveChanges();
            CapaciteText.ResetText();

        }
    }
}
