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
    public partial class HomePage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nleft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse


            );

        private Button CurrentButton;
        private Form activeForm;
        public HomePage()
        {
            InitializeComponent();

        }

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
            foreach (Control previousbtn in panelMenu.Controls)
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
            this.PanelChild.Controls.Add(childform);
            this.PanelChild.Tag = childform;
            childform.BringToFront();
            childform.Show();


        }

        private void ServeurButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Home.FormServeur(), sender);
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Home.FormTable(), sender);
        }

        private void PlatButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Home.FormPlat(), sender);
        }

        private void CommandeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormCommande(), sender);
        }

        private void FactureButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Home.FormFacture(), sender);
        }

        private void PanelChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
