namespace TNT.reception
{
    partial class recpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recpt));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.scanneData = new System.Windows.Forms.Label();
            this.lab_nom = new System.Windows.Forms.Label();
            this.lab_prenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_societe = new System.Windows.Forms.Label();
            this.pBUpdate = new System.Windows.Forms.PictureBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_recept_info_sup = new System.Windows.Forms.PictureBox();
            this.article = new System.Windows.Forms.Label();
            this.scan_manuel = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // scanneData
            // 
            this.scanneData.BackColor = System.Drawing.Color.Aquamarine;
            this.scanneData.Location = new System.Drawing.Point(6, 56);
            this.scanneData.Name = "scanneData";
            this.scanneData.Size = new System.Drawing.Size(109, 22);
            this.scanneData.TextChanged += new System.EventHandler(this.charger_dest);
            // 
            // lab_nom
            // 
            this.lab_nom.Location = new System.Drawing.Point(80, 124);
            this.lab_nom.Name = "lab_nom";
            this.lab_nom.Size = new System.Drawing.Size(100, 20);
            // 
            // lab_prenom
            // 
            this.lab_prenom.Location = new System.Drawing.Point(80, 155);
            this.lab_prenom.Name = "lab_prenom";
            this.lab_prenom.Size = new System.Drawing.Size(100, 20);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Scan";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(82, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Info client";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.Text = "Nom ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.Text = "Sociète";
            // 
            // lab_societe
            // 
            this.lab_societe.Location = new System.Drawing.Point(80, 185);
            this.lab_societe.Name = "lab_societe";
            this.lab_societe.Size = new System.Drawing.Size(100, 20);
            // 
            // pBUpdate
            // 
            this.pBUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pBUpdate.Image")));
            this.pBUpdate.Location = new System.Drawing.Point(180, 218);
            this.pBUpdate.Name = "pBUpdate";
            this.pBUpdate.Size = new System.Drawing.Size(42, 40);
            this.pBUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBUpdate.Click += new System.EventHandler(this.pBUpdate_Click);
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(18, 216);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(43, 43);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(10, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, -65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(10, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, -65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel6.Location = new System.Drawing.Point(0, 123);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(10, 29);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(0, -65);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(218, 1);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel9.Location = new System.Drawing.Point(0, 123);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(218, 1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(77, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.Text = "Réception";
            // 
            // BT_recept_info_sup
            // 
            this.BT_recept_info_sup.BackColor = System.Drawing.Color.White;
            this.BT_recept_info_sup.Image = ((System.Drawing.Image)(resources.GetObject("BT_recept_info_sup.Image")));
            this.BT_recept_info_sup.Location = new System.Drawing.Point(94, 216);
            this.BT_recept_info_sup.Name = "BT_recept_info_sup";
            this.BT_recept_info_sup.Size = new System.Drawing.Size(50, 43);
            this.BT_recept_info_sup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_recept_info_sup.Click += new System.EventHandler(this.BT_recept_info_sup_Click);
            // 
            // article
            // 
            this.article.Location = new System.Drawing.Point(132, 34);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(105, 19);
            this.article.Text = "Saisie manuelle";
            // 
            // scan_manuel
            // 
            this.scan_manuel.Location = new System.Drawing.Point(121, 57);
            this.scan_manuel.Name = "scan_manuel";
            this.scan_manuel.Size = new System.Drawing.Size(116, 21);
            this.scan_manuel.TabIndex = 18;
            // 
            // recpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.scan_manuel);
            this.Controls.Add(this.article);
            this.Controls.Add(this.BT_recept_info_sup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pBUpdate);
            this.Controls.Add(this.pBHome);
            this.Controls.Add(this.lab_societe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_prenom);
            this.Controls.Add(this.lab_nom);
            this.Controls.Add(this.scanneData);
            this.Menu = this.mainMenu1;
            this.Name = "recpt";
            this.Text = "Réception";
            this.Load += new System.EventHandler(this.recpt_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label scanneData;
        private System.Windows.Forms.Label lab_nom;
        private System.Windows.Forms.Label lab_prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_societe;
        private System.Windows.Forms.PictureBox pBUpdate;
        private System.Windows.Forms.PictureBox pBHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox BT_recept_info_sup;
        private System.Windows.Forms.Label article;
        private System.Windows.Forms.TextBox scan_manuel;
    }
}