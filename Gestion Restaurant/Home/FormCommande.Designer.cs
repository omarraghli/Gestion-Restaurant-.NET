
namespace Gestion_Restaurant.Home
{
    partial class FormCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommande));
            this.panelMenuTable = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AddServeurButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuTable
            // 
            this.panelMenuTable.Controls.Add(this.button1);
            this.panelMenuTable.Controls.Add(this.AddServeurButton);
            this.panelMenuTable.Controls.Add(this.panel2);
            this.panelMenuTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuTable.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTable.Name = "panelMenuTable";
            this.panelMenuTable.Size = new System.Drawing.Size(204, 450);
            this.panelMenuTable.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 355);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(204, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afficher les commandes non payé";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddServeurButton
            // 
            this.AddServeurButton.BackColor = System.Drawing.Color.DimGray;
            this.AddServeurButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddServeurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServeurButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddServeurButton.ForeColor = System.Drawing.Color.White;
            this.AddServeurButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddServeurButton.Location = new System.Drawing.Point(0, 307);
            this.AddServeurButton.Name = "AddServeurButton";
            this.AddServeurButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.AddServeurButton.Size = new System.Drawing.Size(204, 48);
            this.AddServeurButton.TabIndex = 3;
            this.AddServeurButton.Text = "Ajouter Commande";
            this.AddServeurButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddServeurButton.UseVisualStyleBackColor = false;
            this.AddServeurButton.Click += new System.EventHandler(this.AddServeurButton_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 307);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(204, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 450);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-107, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuTable);
            this.Name = "FormCommande";
            this.Text = "FormCommande";
            this.panelMenuTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddServeurButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}