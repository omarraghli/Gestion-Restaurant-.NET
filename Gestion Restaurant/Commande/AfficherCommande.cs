using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Restaurant.Commande
{
    public partial class AfficherCommande : Form
    {
        Model1 db = new Model1();
        public AfficherCommande()
        {
            InitializeComponent();
        }

        private void AfficherCommande_Load(object sender, EventArgs e)
        {
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.FlatStyle = FlatStyle.Popup;
            this.CmdGrd.Columns.Add(deleteButton);

            var PayButton = new DataGridViewButtonColumn();
            PayButton.Name = "dataGridViewPayButton";
            PayButton.HeaderText = "Payer";
            PayButton.Text = "Payer";
            PayButton.UseColumnTextForButtonValue = true;
            this.CmdGrd.Columns.Add(PayButton);


            CmdGrd.DataSource = db.commandes.Where(x => x.date_heur_paiment == null).Select(x => new
            {
                Numéro = x.id,
                Nombre_De_Personnes = x.nbr_personne,
                Numéro_De_Table_Résérvé = x.tableid,
                Mode_De_Paiment = x.mode_payment,
                Date_Et_Heur_De_Commande = x.date_heur_commande,
            }).ToList();
            StyleDatagridview();
            DeleteChangePos();
            System.Diagnostics.Debug.WriteLine(CmdGrd.ColumnCount - 1);
        }
        void DeleteChangePos()
        {
            CmdGrd.Columns["dataGridViewDeleteButton"].DisplayIndex = 6;
            CmdGrd.Columns["dataGridViewPayButton"].DisplayIndex = 6;
        }

        void StyleDatagridview()
        {

            CmdGrd.BorderStyle = BorderStyle.None;
            CmdGrd.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            CmdGrd.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CmdGrd.DefaultCellStyle.SelectionBackColor = Color.FromArgb(21, 153, 180);
            CmdGrd.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            CmdGrd.BackgroundColor = Color.White;
            CmdGrd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            CmdGrd.EnableHeadersVisualStyles = false;
            CmdGrd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CmdGrd.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 153, 180);
            CmdGrd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void CmdGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == CmdGrd.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == CmdGrd.Columns["dataGridViewDeleteButton"].Index)
            {

                commandes cmd = db.commandes.Find(CmdGrd.Rows[e.RowIndex].Cells[2].Value);
                db.commandes.Remove(cmd);
                db.SaveChanges();
                CmdGrd.DataSource = db.commandes.Where(x => x.date_heur_paiment == null).Select(x => new
                {
                    Numéro = x.id,
                    Nombre_De_Personnes = x.nbr_personne,
                    Numéro_De_Table_Résérvé = x.tableid,
                    Mode_De_Paiment = x.mode_payment,
                    Date_Et_Heur_De_Commande = x.date_heur_commande,
                }).ToList();

                DeleteChangePos();
            }
            else if (e.ColumnIndex == CmdGrd.Columns["dataGridViewPayButton"].Index)
            {
                commandes cmd = db.commandes.Find(CmdGrd.Rows[e.RowIndex].Cells[2].Value);
                cmd.date_heur_paiment = DateTime.Now;
                db.SaveChanges();
                CmdGrd.DataSource = db.commandes.Where(x => x.date_heur_paiment == null).Select(x => new
                {
                    Numéro = x.id,
                    Nombre_De_Personnes = x.nbr_personne,
                    Numéro_De_Table_Résérvé = x.tableid,
                    Mode_De_Paiment = x.mode_payment,
                    Date_Et_Heur_De_Commande = x.date_heur_commande,
                }).ToList();

                DeleteChangePos();
            }


        }
    }
}