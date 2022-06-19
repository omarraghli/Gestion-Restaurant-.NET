
namespace Gestion_Restaurant.Serveur
{
    partial class ModifierServeur
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
            this.Suivant = new System.Windows.Forms.Button();
            this.Sauvgarderbtn = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.NvxNom = new System.Windows.Forms.Label();
            this.NvxPrenom = new System.Windows.Forms.Label();
            this.PrenomNewText = new System.Windows.Forms.TextBox();
            this.NomNewText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrenomModifierText = new System.Windows.Forms.TextBox();
            this.NomModifierText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Suivant
            // 
            this.Suivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.Suivant.FlatAppearance.BorderSize = 0;
            this.Suivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suivant.ForeColor = System.Drawing.Color.White;
            this.Suivant.Location = new System.Drawing.Point(36, 171);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(124, 44);
            this.Suivant.TabIndex = 9;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = false;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Sauvgarderbtn
            // 
            this.Sauvgarderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.Sauvgarderbtn.FlatAppearance.BorderSize = 0;
            this.Sauvgarderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sauvgarderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Sauvgarderbtn.ForeColor = System.Drawing.Color.White;
            this.Sauvgarderbtn.Location = new System.Drawing.Point(36, 394);
            this.Sauvgarderbtn.Name = "Sauvgarderbtn";
            this.Sauvgarderbtn.Size = new System.Drawing.Size(124, 44);
            this.Sauvgarderbtn.TabIndex = 10;
            this.Sauvgarderbtn.Text = "Sauvgarder";
            this.Sauvgarderbtn.UseVisualStyleBackColor = false;
            this.Sauvgarderbtn.Visible = false;
            this.Sauvgarderbtn.Click += new System.EventHandler(this.Sauvgarderbtn_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Location = new System.Drawing.Point(242, 456);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 13);
            this.msg.TabIndex = 11;
            // 
            // NvxNom
            // 
            this.NvxNom.AutoSize = true;
            this.NvxNom.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.NvxNom.Location = new System.Drawing.Point(31, 245);
            this.NvxNom.Name = "NvxNom";
            this.NvxNom.Size = new System.Drawing.Size(213, 25);
            this.NvxNom.TabIndex = 7;
            this.NvxNom.Text = "Nouveau nom       :";
            this.NvxNom.Visible = false;
            this.NvxNom.Click += new System.EventHandler(this.NvxNom_Click);
            // 
            // NvxPrenom
            // 
            this.NvxPrenom.AutoSize = true;
            this.NvxPrenom.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.NvxPrenom.Location = new System.Drawing.Point(31, 311);
            this.NvxPrenom.Name = "NvxPrenom";
            this.NvxPrenom.Size = new System.Drawing.Size(213, 25);
            this.NvxPrenom.TabIndex = 8;
            this.NvxPrenom.Text = "Nouveau prenom :";
            this.NvxPrenom.Visible = false;
            // 
            // PrenomNewText
            // 
            this.PrenomNewText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrenomNewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrenomNewText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PrenomNewText.Location = new System.Drawing.Point(248, 311);
            this.PrenomNewText.Multiline = true;
            this.PrenomNewText.Name = "PrenomNewText";
            this.PrenomNewText.Size = new System.Drawing.Size(205, 34);
            this.PrenomNewText.TabIndex = 6;
            this.PrenomNewText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrenomNewText.Visible = false;
            // 
            // NomNewText
            // 
            this.NomNewText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NomNewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomNewText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.NomNewText.Location = new System.Drawing.Point(250, 245);
            this.NomNewText.Multiline = true;
            this.NomNewText.Name = "NomNewText";
            this.NomNewText.Size = new System.Drawing.Size(205, 34);
            this.NomNewText.TabIndex = 5;
            this.NomNewText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NomNewText.Visible = false;
            this.NomNewText.TextChanged += new System.EventHandler(this.NomNewText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom     :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prenom :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PrenomModifierText
            // 
            this.PrenomModifierText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrenomModifierText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrenomModifierText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PrenomModifierText.Location = new System.Drawing.Point(133, 98);
            this.PrenomModifierText.Multiline = true;
            this.PrenomModifierText.Name = "PrenomModifierText";
            this.PrenomModifierText.Size = new System.Drawing.Size(320, 34);
            this.PrenomModifierText.TabIndex = 2;
            this.PrenomModifierText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NomModifierText
            // 
            this.NomModifierText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NomModifierText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomModifierText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.NomModifierText.Location = new System.Drawing.Point(133, 34);
            this.NomModifierText.Multiline = true;
            this.NomModifierText.Name = "NomModifierText";
            this.NomModifierText.Size = new System.Drawing.Size(320, 34);
            this.NomModifierText.TabIndex = 1;
            this.NomModifierText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NomModifierText.TextChanged += new System.EventHandler(this.NomModifierText_TextChanged);
            // 
            // ModifierServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.Sauvgarderbtn);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.NvxPrenom);
            this.Controls.Add(this.NvxNom);
            this.Controls.Add(this.PrenomNewText);
            this.Controls.Add(this.NomNewText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrenomModifierText);
            this.Controls.Add(this.NomModifierText);
            this.Name = "ModifierServeur";
            this.Text = "ModifierServeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Sauvgarderbtn;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Label NvxNom;
        private System.Windows.Forms.Label NvxPrenom;
        private System.Windows.Forms.TextBox PrenomNewText;
        private System.Windows.Forms.TextBox NomNewText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrenomModifierText;
        private System.Windows.Forms.TextBox NomModifierText;
    }
}