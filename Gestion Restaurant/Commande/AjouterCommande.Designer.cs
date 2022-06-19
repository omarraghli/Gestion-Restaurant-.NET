
namespace Gestion_Restaurant
{
    partial class AjouterCommande
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
            this.label1 = new System.Windows.Forms.Label();
            this.NbrPersonneList = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ModePaimentText = new System.Windows.Forms.ComboBox();
            this.NumeroTableText = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AjouterCommandBtn = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TypePlat1 = new System.Windows.Forms.ComboBox();
            this.Plat1 = new System.Windows.Forms.ComboBox();
            this.TypePlat2 = new System.Windows.Forms.ComboBox();
            this.Plat2 = new System.Windows.Forms.ComboBox();
            this.TypePlat3 = new System.Windows.Forms.ComboBox();
            this.Plat3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NbrPersonneList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.Location = new System.Drawing.Point(140, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de personne";
            // 
            // NbrPersonneList
            // 
            this.NbrPersonneList.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.NbrPersonneList.Location = new System.Drawing.Point(154, 60);
            this.NbrPersonneList.Name = "NbrPersonneList";
            this.NbrPersonneList.Size = new System.Drawing.Size(205, 27);
            this.NbrPersonneList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.Location = new System.Drawing.Point(295, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mode de paiment";
            // 
            // ModePaimentText
            // 
            this.ModePaimentText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ModePaimentText.FormattingEnabled = true;
            this.ModePaimentText.Items.AddRange(new object[] {
            "Carte bancaire",
            "Espèces"});
            this.ModePaimentText.Location = new System.Drawing.Point(300, 271);
            this.ModePaimentText.Name = "ModePaimentText";
            this.ModePaimentText.Size = new System.Drawing.Size(205, 29);
            this.ModePaimentText.TabIndex = 5;
            this.ModePaimentText.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NumeroTableText
            // 
            this.NumeroTableText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.NumeroTableText.FormattingEnabled = true;
            this.NumeroTableText.Location = new System.Drawing.Point(300, 335);
            this.NumeroTableText.Name = "NumeroTableText";
            this.NumeroTableText.Size = new System.Drawing.Size(205, 29);
            this.NumeroTableText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.Location = new System.Drawing.Point(295, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numéro de la table";
            // 
            // AjouterCommandBtn
            // 
            this.AjouterCommandBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.AjouterCommandBtn.FlatAppearance.BorderSize = 0;
            this.AjouterCommandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterCommandBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AjouterCommandBtn.ForeColor = System.Drawing.Color.White;
            this.AjouterCommandBtn.Location = new System.Drawing.Point(145, 378);
            this.AjouterCommandBtn.Name = "AjouterCommandBtn";
            this.AjouterCommandBtn.Size = new System.Drawing.Size(229, 48);
            this.AjouterCommandBtn.TabIndex = 8;
            this.AjouterCommandBtn.Text = "Ajouter Une Commande";
            this.AjouterCommandBtn.UseVisualStyleBackColor = false;
            this.AjouterCommandBtn.Click += new System.EventHandler(this.AjouterCommandBtn_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Location = new System.Drawing.Point(297, 202);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 13);
            this.msg.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label4.Location = new System.Drawing.Point(12, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Deuxième plat";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Premier plat";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label6.Location = new System.Drawing.Point(294, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Type troisième plat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label7.Location = new System.Drawing.Point(11, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Type premier plat";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label8.Location = new System.Drawing.Point(12, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Type deuxième plat";
            // 
            // TypePlat1
            // 
            this.TypePlat1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypePlat1.FormattingEnabled = true;
            this.TypePlat1.Location = new System.Drawing.Point(17, 135);
            this.TypePlat1.Name = "TypePlat1";
            this.TypePlat1.Size = new System.Drawing.Size(205, 29);
            this.TypePlat1.TabIndex = 20;
            this.TypePlat1.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // Plat1
            // 
            this.Plat1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Plat1.FormattingEnabled = true;
            this.Plat1.Location = new System.Drawing.Point(17, 193);
            this.Plat1.Name = "Plat1";
            this.Plat1.Size = new System.Drawing.Size(205, 29);
            this.Plat1.TabIndex = 21;
            this.Plat1.Visible = false;
            // 
            // TypePlat2
            // 
            this.TypePlat2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TypePlat2.FormattingEnabled = true;
            this.TypePlat2.Location = new System.Drawing.Point(16, 271);
            this.TypePlat2.Name = "TypePlat2";
            this.TypePlat2.Size = new System.Drawing.Size(205, 29);
            this.TypePlat2.TabIndex = 22;
            this.TypePlat2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Plat2
            // 
            this.Plat2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Plat2.FormattingEnabled = true;
            this.Plat2.Location = new System.Drawing.Point(17, 335);
            this.Plat2.Name = "Plat2";
            this.Plat2.Size = new System.Drawing.Size(205, 29);
            this.Plat2.TabIndex = 23;
            this.Plat2.Visible = false;
            // 
            // TypePlat3
            // 
            this.TypePlat3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TypePlat3.FormattingEnabled = true;
            this.TypePlat3.Location = new System.Drawing.Point(299, 133);
            this.TypePlat3.Name = "TypePlat3";
            this.TypePlat3.Size = new System.Drawing.Size(205, 29);
            this.TypePlat3.TabIndex = 24;
            this.TypePlat3.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged_1);
            // 
            // Plat3
            // 
            this.Plat3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Plat3.FormattingEnabled = true;
            this.Plat3.Location = new System.Drawing.Point(299, 193);
            this.Plat3.Name = "Plat3";
            this.Plat3.Size = new System.Drawing.Size(205, 29);
            this.Plat3.TabIndex = 26;
            this.Plat3.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label9.Location = new System.Drawing.Point(294, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Troisième plat";
            this.label9.Visible = false;
            // 
            // AjouterCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Plat3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TypePlat3);
            this.Controls.Add(this.Plat2);
            this.Controls.Add(this.TypePlat2);
            this.Controls.Add(this.Plat1);
            this.Controls.Add(this.TypePlat1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.AjouterCommandBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumeroTableText);
            this.Controls.Add(this.ModePaimentText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NbrPersonneList);
            this.Controls.Add(this.label1);
            this.Name = "AjouterCommande";
            this.Text = "AjouterCommande";
            this.Load += new System.EventHandler(this.AjouterCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NbrPersonneList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NbrPersonneList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ModePaimentText;
        private System.Windows.Forms.ComboBox NumeroTableText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AjouterCommandBtn;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TypePlat1;
        private System.Windows.Forms.ComboBox Plat1;
        private System.Windows.Forms.ComboBox TypePlat2;
        private System.Windows.Forms.ComboBox Plat2;
        private System.Windows.Forms.ComboBox TypePlat3;
        private System.Windows.Forms.ComboBox Plat3;
        private System.Windows.Forms.Label label9;
    }
}