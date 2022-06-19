
namespace Gestion_Restaurant
{
    partial class AjouterPlat
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
            this.LibelleText = new System.Windows.Forms.TextBox();
            this.TypeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PrixText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LibelleText
            // 
            this.LibelleText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LibelleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LibelleText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LibelleText.Location = new System.Drawing.Point(44, 90);
            this.LibelleText.Multiline = true;
            this.LibelleText.Name = "LibelleText";
            this.LibelleText.Size = new System.Drawing.Size(250, 39);
            this.LibelleText.TabIndex = 0;
            this.LibelleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TypeText
            // 
            this.TypeText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TypeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TypeText.Location = new System.Drawing.Point(44, 174);
            this.TypeText.Multiline = true;
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(250, 39);
            this.TypeText.TabIndex = 1;
            this.TypeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.Location = new System.Drawing.Point(39, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(44, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.Location = new System.Drawing.Point(39, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prix";
            // 
            // PrixText
            // 
            this.PrixText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrixText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrixText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PrixText.Location = new System.Drawing.Point(44, 258);
            this.PrixText.Multiline = true;
            this.PrixText.Name = "PrixText";
            this.PrixText.Size = new System.Drawing.Size(250, 39);
            this.PrixText.TabIndex = 7;
            this.PrixText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AjouterPlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrixText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.LibelleText);
            this.Name = "AjouterPlat";
            this.Text = "AjouterPlat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LibelleText;
        private System.Windows.Forms.TextBox TypeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrixText;
    }
}