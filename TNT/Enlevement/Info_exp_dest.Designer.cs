namespace TNT
{
    partial class Info_exp_dest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_exp_dest));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.Nom = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_societe = new System.Windows.Forms.TextBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.titre = new System.Windows.Forms.Label();
            this.bt_suivant = new System.Windows.Forms.PictureBox();
            this.bt_enreg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_code_agence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(17, 60);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(51, 20);
            this.Nom.Text = "Nom";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(101, 56);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(131, 21);
            this.tb_nom.TabIndex = 2;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(17, 97);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(51, 20);
            this.Prenom.Text = "Prenom";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(101, 95);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(131, 21);
            this.tb_prenom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.Text = "Agence";
            // 
            // tb_societe
            // 
            this.tb_societe.Location = new System.Drawing.Point(101, 132);
            this.tb_societe.Name = "tb_societe";
            this.tb_societe.Size = new System.Drawing.Size(131, 21);
            this.tb_societe.TabIndex = 10;
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(43, 210);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(47, 44);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click);
            // 
            // titre
            // 
            this.titre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.titre.Location = new System.Drawing.Point(30, 12);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(186, 20);
            // 
            // bt_suivant
            // 
            this.bt_suivant.BackColor = System.Drawing.Color.White;
            this.bt_suivant.Image = ((System.Drawing.Image)(resources.GetObject("bt_suivant.Image")));
            this.bt_suivant.Location = new System.Drawing.Point(140, 212);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(49, 42);
            this.bt_suivant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_suivant.Click += new System.EventHandler(this.pBValiderVisite_Click_1);
            // 
            // bt_enreg
            // 
            this.bt_enreg.Image = ((System.Drawing.Image)(resources.GetObject("bt_enreg.Image")));
            this.bt_enreg.Location = new System.Drawing.Point(140, 212);
            this.bt_enreg.Name = "bt_enreg";
            this.bt_enreg.Size = new System.Drawing.Size(49, 42);
            this.bt_enreg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_enreg.Click += new System.EventHandler(this.pBUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Location = new System.Drawing.Point(13, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 1);
            // 
            // tb_code_agence
            // 
            this.tb_code_agence.Location = new System.Drawing.Point(101, 167);
            this.tb_code_agence.Name = "tb_code_agence";
            this.tb_code_agence.Size = new System.Drawing.Size(131, 21);
            this.tb_code_agence.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.Text = "Code agence";
            // 
            // Info_exp_dest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tb_code_agence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.pBHome);
            this.Controls.Add(this.tb_societe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.bt_enreg);
            this.Menu = this.mainMenu1;
            this.Name = "Info_exp_dest";
            this.Text = "Info_exp_dest";
            this.Load += new System.EventHandler(this.Info_exp_dest_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_societe;
        private System.Windows.Forms.PictureBox pBHome;
        public System.Windows.Forms.PictureBox bt_suivant;
        public System.Windows.Forms.PictureBox bt_enreg;
        public System.Windows.Forms.Label titre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_code_agence;
        private System.Windows.Forms.Label label2;
    }
}