
namespace Gestion_Restaurant.Table
{
    partial class ModifierTable
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
            this.IdToUpdateText = new System.Windows.Forms.TextBox();
            this.SuivantBtn = new System.Windows.Forms.Button();
            this.CapaciteNewText = new System.Windows.Forms.TextBox();
            this.CapaciteNvx = new System.Windows.Forms.Label();
            this.SauvagrderBtn = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.Location = new System.Drawing.Point(62, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro de la table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IdToUpdateText
            // 
            this.IdToUpdateText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IdToUpdateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdToUpdateText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.IdToUpdateText.Location = new System.Drawing.Point(67, 142);
            this.IdToUpdateText.Multiline = true;
            this.IdToUpdateText.Name = "IdToUpdateText";
            this.IdToUpdateText.Size = new System.Drawing.Size(250, 39);
            this.IdToUpdateText.TabIndex = 1;
            this.IdToUpdateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SuivantBtn
            // 
            this.SuivantBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.SuivantBtn.FlatAppearance.BorderSize = 0;
            this.SuivantBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuivantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SuivantBtn.ForeColor = System.Drawing.Color.White;
            this.SuivantBtn.Location = new System.Drawing.Point(67, 197);
            this.SuivantBtn.Name = "SuivantBtn";
            this.SuivantBtn.Size = new System.Drawing.Size(116, 42);
            this.SuivantBtn.TabIndex = 3;
            this.SuivantBtn.Text = "Suivant";
            this.SuivantBtn.UseVisualStyleBackColor = false;
            this.SuivantBtn.Click += new System.EventHandler(this.SuivantBtn_Click);
            // 
            // CapaciteNewText
            // 
            this.CapaciteNewText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CapaciteNewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CapaciteNewText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CapaciteNewText.Location = new System.Drawing.Point(67, 301);
            this.CapaciteNewText.Multiline = true;
            this.CapaciteNewText.Name = "CapaciteNewText";
            this.CapaciteNewText.Size = new System.Drawing.Size(250, 39);
            this.CapaciteNewText.TabIndex = 5;
            this.CapaciteNewText.TabStop = false;
            this.CapaciteNewText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CapaciteNewText.Visible = false;
            this.CapaciteNewText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CapaciteNvx
            // 
            this.CapaciteNvx.AutoSize = true;
            this.CapaciteNvx.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.CapaciteNvx.Location = new System.Drawing.Point(62, 261);
            this.CapaciteNvx.Name = "CapaciteNvx";
            this.CapaciteNvx.Size = new System.Drawing.Size(213, 25);
            this.CapaciteNvx.TabIndex = 4;
            this.CapaciteNvx.Text = "Nouvelle capacité";
            this.CapaciteNvx.Visible = false;
            this.CapaciteNvx.Click += new System.EventHandler(this.label3_Click);
            // 
            // SauvagrderBtn
            // 
            this.SauvagrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(153)))), ((int)(((byte)(180)))));
            this.SauvagrderBtn.FlatAppearance.BorderSize = 0;
            this.SauvagrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SauvagrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SauvagrderBtn.ForeColor = System.Drawing.Color.White;
            this.SauvagrderBtn.Location = new System.Drawing.Point(67, 359);
            this.SauvagrderBtn.Name = "SauvagrderBtn";
            this.SauvagrderBtn.Size = new System.Drawing.Size(116, 42);
            this.SauvagrderBtn.TabIndex = 6;
            this.SauvagrderBtn.Text = "Sauvegarder";
            this.SauvagrderBtn.UseVisualStyleBackColor = false;
            this.SauvagrderBtn.Visible = false;
            this.SauvagrderBtn.Click += new System.EventHandler(this.SauvagrderBtn_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Location = new System.Drawing.Point(388, 350);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 13);
            this.msg.TabIndex = 7;
            // 
            // ModifierTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.SauvagrderBtn);
            this.Controls.Add(this.CapaciteNewText);
            this.Controls.Add(this.CapaciteNvx);
            this.Controls.Add(this.SuivantBtn);
            this.Controls.Add(this.IdToUpdateText);
            this.Controls.Add(this.label1);
            this.Name = "ModifierTable";
            this.Text = "ModifierTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdToUpdateText;
        private System.Windows.Forms.Button SuivantBtn;
        private System.Windows.Forms.TextBox CapaciteNewText;
        private System.Windows.Forms.Label CapaciteNvx;
        private System.Windows.Forms.Button SauvagrderBtn;
        private System.Windows.Forms.Label msg;
    }
}