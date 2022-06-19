using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Restaurant.Home
{
    public partial class FormServeur : Form
    {
        private Button CurrentButton;
        private Form activeForm;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nleft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse


            );


        void ActivateButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if (CurrentButton != (Button)btnSender)
                {
                    disableButton();
                    Color color = Color.FromArgb(21, 153, 180);
                    CurrentButton = (Button)btnSender;
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;

                }
            }
        }


        void disableButton()
        {
            foreach (Control previousbtn in MenuPanelServeur.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.DimGray;
                    previousbtn.ForeColor = Color.White;



                }
            }
        }


        void OpenChildForm(Form childform, Object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            ActivateButton(btnsender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelChildServeur.Controls.Add(childform);
            this.panelChildServeur.Tag = childform;
            childform.BringToFront();
            childform.Show();


        }

        public FormServeur()
        {
            InitializeComponent();

            //AddServeurButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AddServeurButton.Width, AddServeurButton.Height, 10, 10));
        }

        private void AddServeurButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AjouterServeur(), sender);
        }

        private void UpdateServeurButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Serveur.ModifierServeur(), sender);
        }

        private void AffectServeurButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AffectServerToTable(), sender);
        }

        private void ReadServeurButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm( new Serveur.AfficherServeur(), sender);
        }
    }
}
