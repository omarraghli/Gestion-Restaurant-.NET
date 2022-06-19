
namespace Gestion_Restaurant.Home
{
    partial class FormFacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacture));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textDateCommande = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextModePay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BoxPersonne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxNTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextFacture = new System.Windows.Forms.RichTextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonImp = new System.Windows.Forms.Button();
            this.buttonGen = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(608, 41);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(33, 26);
            this.buttonSearch.TabIndex = 62;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(356, 41);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(224, 29);
            this.textSearch.TabIndex = 61;
            this.textSearch.TabStop = false;
            this.textSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(136, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "Numéro de la commande  :";
            // 
            // textDateCommande
            // 
            this.textDateCommande.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDateCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDateCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDateCommande.Location = new System.Drawing.Point(209, 285);
            this.textDateCommande.Multiline = true;
            this.textDateCommande.Name = "textDateCommande";
            this.textDateCommande.Size = new System.Drawing.Size(165, 29);
            this.textDateCommande.TabIndex = 76;
            this.textDateCommande.TabStop = false;
            this.textDateCommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "Date Commande    :";
            // 
            // TextModePay
            // 
            this.TextModePay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextModePay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextModePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextModePay.Location = new System.Drawing.Point(209, 237);
            this.TextModePay.Multiline = true;
            this.TextModePay.Name = "TextModePay";
            this.TextModePay.Size = new System.Drawing.Size(165, 29);
            this.TextModePay.TabIndex = 72;
            this.TextModePay.TabStop = false;
            this.TextModePay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 20);
            this.label11.TabIndex = 71;
            this.label11.Text = "Mode payement     :";
            // 
            // BoxPersonne
            // 
            this.BoxPersonne.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxPersonne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxPersonne.Location = new System.Drawing.Point(209, 192);
            this.BoxPersonne.Multiline = true;
            this.BoxPersonne.Name = "BoxPersonne";
            this.BoxPersonne.Size = new System.Drawing.Size(165, 29);
            this.BoxPersonne.TabIndex = 70;
            this.BoxPersonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nombre personne  :";
            // 
            // BoxNTable
            // 
            this.BoxNTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxNTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxNTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNTable.Location = new System.Drawing.Point(209, 145);
            this.BoxNTable.Multiline = true;
            this.BoxNTable.Name = "BoxNTable";
            this.BoxNTable.Size = new System.Drawing.Size(165, 29);
            this.BoxNTable.TabIndex = 68;
            this.BoxNTable.TabStop = false;
            this.BoxNTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "N° de la Table          :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextFacture
            // 
            this.TextFacture.BackColor = System.Drawing.Color.White;
            this.TextFacture.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFacture.Location = new System.Drawing.Point(408, 122);
            this.TextFacture.Name = "TextFacture";
            this.TextFacture.Size = new System.Drawing.Size(352, 283);
            this.TextFacture.TabIndex = 77;
            this.TextFacture.Text = "";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReset.Location = new System.Drawing.Point(153, 370);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 35);
            this.buttonReset.TabIndex = 80;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonImp
            // 
            this.buttonImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.buttonImp.FlatAppearance.BorderSize = 0;
            this.buttonImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonImp.Location = new System.Drawing.Point(273, 370);
            this.buttonImp.Name = "buttonImp";
            this.buttonImp.Size = new System.Drawing.Size(101, 35);
            this.buttonImp.TabIndex = 79;
            this.buttonImp.Text = "Imprimer";
            this.buttonImp.UseVisualStyleBackColor = false;
            this.buttonImp.Click += new System.EventHandler(this.buttonImp_Click);
            // 
            // buttonGen
            // 
            this.buttonGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.buttonGen.FlatAppearance.BorderSize = 0;
            this.buttonGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGen.Location = new System.Drawing.Point(36, 370);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(106, 35);
            this.buttonGen.TabIndex = 78;
            this.buttonGen.Text = "Générer";
            this.buttonGen.UseVisualStyleBackColor = false;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonImp);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.TextFacture);
            this.Controls.Add(this.textDateCommande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextModePay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BoxPersonne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxNTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label12);
            this.Name = "FormFacture";
            this.Text = "FormFacture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textDateCommande;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextModePay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BoxPersonne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxNTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextFacture;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonImp;
        private System.Windows.Forms.Button buttonGen;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}