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
    public partial class AfficherPlats : Form
    {
        Model1 db = new Model1();
        public AfficherPlats()
        {
            InitializeComponent();
        }

        private void AfficherPlats_Load(object sender, EventArgs e)
        {
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.FlatStyle = FlatStyle.Popup;
            this.PlatGrd.Columns.Add(deleteButton);

            PlatGrd.DataSource = db.plats.Select(x => new
            {
                Numéro = x.id,
                Libelle = x.libelle,
                Type = x.type,
                Prix = x.prix,

            }).ToList();
            StyleDatagridview();
            DeleteChangePos();

        }
        void DeleteChangePos()
        {
            PlatGrd.Columns["dataGridViewDeleteButton"].DisplayIndex = PlatGrd.ColumnCount - 1;
        }

        void StyleDatagridview()
        {
            PlatGrd.BorderStyle = BorderStyle.None;
            PlatGrd.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            PlatGrd.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PlatGrd.DefaultCellStyle.SelectionBackColor = Color.FromArgb(21, 153, 180);
            PlatGrd.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            PlatGrd.BackgroundColor = Color.White;
            PlatGrd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            PlatGrd.EnableHeadersVisualStyles = false;
            PlatGrd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            PlatGrd.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 153, 180);
            PlatGrd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        private void PlatGrd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            //if click is on new row or header row
            if (e.RowIndex == PlatGrd.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == PlatGrd.Columns["dataGridViewDeleteButton"].Index)
            {
                plats plt = db.plats.Find(PlatGrd.Rows[e.RowIndex].Cells[1].Value);
                db.plats.Remove(plt);
                db.SaveChanges();
                PlatGrd.DataSource = db.plats.Select(x => new
                {
                    Numéro = x.id,
                    Libelle = x.libelle,
                    Type = x.type,
                    Prix = x.prix,

                }).ToList();
                DeleteChangePos();
            }

        }
    }
}