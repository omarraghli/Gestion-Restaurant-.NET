
namespace Gestion_Restaurant
{
    partial class AjouterServeur
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
            this.labelNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PrenomText = new System.Windows.Forms.TextBox();
            this.NomText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(66, 74);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(118, 25);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom        :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.Location = new System.Drawing.Point(66, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom   :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(285, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrenomText
            // 
            this.PrenomText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrenomText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrenomText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomText.ForeColor = System.Drawing.Color.DimGray;
            this.PrenomText.Location = new System.Drawing.Point(211, 178);
            this.PrenomText.Multiline = true;
            this.PrenomText.Name = "PrenomText";
            this.PrenomText.Size = new System.Drawing.Size(281, 39);
            this.PrenomText.TabIndex = 12;
            this.PrenomText.TabStop = false;
            this.PrenomText.Text = "Entrer le prénom du serveur";
            this.PrenomText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrenomText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoxPrenomClick);
            this.PrenomText.Leave += new System.EventHandler(this.BoxPrenomLeave);
            // 
            // NomText
            // 
            this.NomText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NomText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomText.ForeColor = System.Drawing.Color.DimGray;
            this.NomText.Location = new System.Drawing.Point(211, 74);
            this.NomText.Multiline = true;
            this.NomText.Name = "NomText";
            this.NomText.Size = new System.Drawing.Size(281, 39);
            this.NomText.TabIndex = 11;
            this.NomText.TabStop = false;
            this.NomText.Text = "Enter le nom du serveur";
            this.NomText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NomText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoxNomChange);
            this.NomText.TextChanged += new System.EventHandler(this.NomText_TextChanged);
            this.NomText.Leave += new System.EventHandler(this.BoxNomLEave);
            // 
            // AjouterServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrenomText);
            this.Controls.Add(this.NomText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNom);
            this.Name = "AjouterServeur";
            this.Text = "AjouterServeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PrenomText;
        private System.Windows.Forms.TextBox NomText;
    }
}