
namespace Gestion_Restaurant.Home
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.PanelChild = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.FactureButton = new System.Windows.Forms.Button();
            this.CommandeButton = new System.Windows.Forms.Button();
            this.PlatButton = new System.Windows.Forms.Button();
            this.TableButton = new System.Windows.Forms.Button();
            this.ServeurButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.PanelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelChild
            // 
            this.PanelChild.AutoScroll = true;
            this.PanelChild.BackColor = System.Drawing.Color.White;
            this.PanelChild.Controls.Add(this.pictureBox2);
            this.PanelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChild.Location = new System.Drawing.Point(201, 0);
            this.PanelChild.Name = "PanelChild";
            this.PanelChild.Size = new System.Drawing.Size(786, 473);
            this.PanelChild.TabIndex = 4;
            this.PanelChild.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChild_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(588, 370);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelMenu.Controls.Add(this.FactureButton);
            this.panelMenu.Controls.Add(this.CommandeButton);
            this.panelMenu.Controls.Add(this.PlatButton);
            this.panelMenu.Controls.Add(this.TableButton);
            this.panelMenu.Controls.Add(this.ServeurButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(201, 473);
            this.panelMenu.TabIndex = 3;
            // 
            // FactureButton
            // 
            this.FactureButton.BackColor = System.Drawing.Color.DimGray;
            this.FactureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FactureButton.FlatAppearance.BorderSize = 0;
            this.FactureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FactureButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactureButton.ForeColor = System.Drawing.Color.White;
            this.FactureButton.Image = ((System.Drawing.Image)(resources.GetObject("FactureButton.Image")));
            this.FactureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FactureButton.Location = new System.Drawing.Point(0, 396);
            this.FactureButton.Name = "FactureButton";
            this.FactureButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.FactureButton.Size = new System.Drawing.Size(201, 83);
            this.FactureButton.TabIndex = 5;
            this.FactureButton.Text = "    Facture";
            this.FactureButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FactureButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FactureButton.UseVisualStyleBackColor = false;
            this.FactureButton.Click += new System.EventHandler(this.FactureButton_Click);
            // 
            // CommandeButton
            // 
            this.CommandeButton.BackColor = System.Drawing.Color.DimGray;
            this.CommandeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommandeButton.FlatAppearance.BorderSize = 0;
            this.CommandeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandeButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandeButton.ForeColor = System.Drawing.Color.White;
            this.CommandeButton.Image = ((System.Drawing.Image)(resources.GetObject("CommandeButton.Image")));
            this.CommandeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommandeButton.Location = new System.Drawing.Point(0, 313);
            this.CommandeButton.Name = "CommandeButton";
            this.CommandeButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.CommandeButton.Size = new System.Drawing.Size(201, 83);
            this.CommandeButton.TabIndex = 4;
            this.CommandeButton.Text = "    Commande";
            this.CommandeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommandeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CommandeButton.UseVisualStyleBackColor = false;
            this.CommandeButton.Click += new System.EventHandler(this.CommandeButton_Click);
            // 
            // PlatButton
            // 
            this.PlatButton.BackColor = System.Drawing.Color.DimGray;
            this.PlatButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlatButton.FlatAppearance.BorderSize = 0;
            this.PlatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlatButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatButton.ForeColor = System.Drawing.Color.White;
            this.PlatButton.Image = ((System.Drawing.Image)(resources.GetObject("PlatButton.Image")));
            this.PlatButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlatButton.Location = new System.Drawing.Point(0, 230);
            this.PlatButton.Name = "PlatButton";
            this.PlatButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.PlatButton.Size = new System.Drawing.Size(201, 83);
            this.PlatButton.TabIndex = 3;
            this.PlatButton.Text = "    Plat";
            this.PlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlatButton.UseVisualStyleBackColor = false;
            this.PlatButton.Click += new System.EventHandler(this.PlatButton_Click);
            // 
            // TableButton
            // 
            this.TableButton.BackColor = System.Drawing.Color.DimGray;
            this.TableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableButton.FlatAppearance.BorderSize = 0;
            this.TableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableButton.ForeColor = System.Drawing.Color.White;
            this.TableButton.Image = ((System.Drawing.Image)(resources.GetObject("TableButton.Image")));
            this.TableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableButton.Location = new System.Drawing.Point(0, 147);
            this.TableButton.Name = "TableButton";
            this.TableButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.TableButton.Size = new System.Drawing.Size(201, 83);
            this.TableButton.TabIndex = 2;
            this.TableButton.Text = "    Table";
            this.TableButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TableButton.UseVisualStyleBackColor = false;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // ServeurButton
            // 
            this.ServeurButton.BackColor = System.Drawing.Color.DimGray;
            this.ServeurButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServeurButton.FlatAppearance.BorderSize = 0;
            this.ServeurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServeurButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServeurButton.ForeColor = System.Drawing.Color.White;
            this.ServeurButton.Image = ((System.Drawing.Image)(resources.GetObject("ServeurButton.Image")));
            this.ServeurButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServeurButton.Location = new System.Drawing.Point(0, 64);
            this.ServeurButton.Name = "ServeurButton";
            this.ServeurButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.ServeurButton.Size = new System.Drawing.Size(201, 83);
            this.ServeurButton.TabIndex = 1;
            this.ServeurButton.Text = "   Serveur";
            this.ServeurButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServeurButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ServeurButton.UseVisualStyleBackColor = false;
            this.ServeurButton.Click += new System.EventHandler(this.ServeurButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DimGray;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(201, 64);
            this.panelLogo.TabIndex = 0;
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 473);
            this.Controls.Add(this.PanelChild);
            this.Controls.Add(this.panelMenu);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.PanelChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelChild;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button CommandeButton;
        private System.Windows.Forms.Button PlatButton;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button ServeurButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button FactureButton;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
    }
}