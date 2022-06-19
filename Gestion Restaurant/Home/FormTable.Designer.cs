
namespace Gestion_Restaurant.Home
{
    partial class FormTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
            this.panelMenuTable = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddServeurButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelchildrenTable = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuTable.SuspendLayout();
            this.panelchildrenTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuTable
            // 
            this.panelMenuTable.Controls.Add(this.button3);
            this.panelMenuTable.Controls.Add(this.button1);
            this.panelMenuTable.Controls.Add(this.AddServeurButton);
            this.panelMenuTable.Controls.Add(this.panel2);
            this.panelMenuTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuTable.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTable.Name = "panelMenuTable";
            this.panelMenuTable.Size = new System.Drawing.Size(204, 450);
            this.panelMenuTable.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 190);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(204, 48);
            this.button3.TabIndex = 6;
            this.button3.Text = "Lister Tables";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 142);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(204, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modifier Table";
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
            this.AddServeurButton.Location = new System.Drawing.Point(0, 94);
            this.AddServeurButton.Name = "AddServeurButton";
            this.AddServeurButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.AddServeurButton.Size = new System.Drawing.Size(204, 48);
            this.AddServeurButton.TabIndex = 3;
            this.AddServeurButton.Text = "Ajouter Table";
            this.AddServeurButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddServeurButton.UseVisualStyleBackColor = false;
            this.AddServeurButton.Click += new System.EventHandler(this.AddServeurButton_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 94);
            this.panel2.TabIndex = 0;
            // 
            // panelchildrenTable
            // 
            this.panelchildrenTable.Controls.Add(this.pictureBox1);
            this.panelchildrenTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchildrenTable.Location = new System.Drawing.Point(204, 0);
            this.panelchildrenTable.Name = "panelchildrenTable";
            this.panelchildrenTable.Size = new System.Drawing.Size(584, 450);
            this.panelchildrenTable.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.panelchildrenTable);
            this.Controls.Add(this.panelMenuTable);
            this.Name = "FormTable";
            this.Text = "FormTable";
            this.Load += new System.EventHandler(this.FormTable_Load);
            this.panelMenuTable.ResumeLayout(false);
            this.panelchildrenTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddServeurButton;
        private System.Windows.Forms.Panel panelchildrenTable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}