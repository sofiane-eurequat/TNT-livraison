namespace TNT.check_in_out
{
    partial class check_in_out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(check_in_out));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.titre = new System.Windows.Forms.Label();
            this.bt_retour = new System.Windows.Forms.Button();
            this.pBTrouver = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_depot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_adr = new System.Windows.Forms.TextBox();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titre.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.titre.Location = new System.Drawing.Point(32, 15);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(184, 25);
            this.titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_retour
            // 
            this.bt_retour.Location = new System.Drawing.Point(18, 237);
            this.bt_retour.Name = "bt_retour";
            this.bt_retour.Size = new System.Drawing.Size(72, 20);
            this.bt_retour.TabIndex = 1;
            this.bt_retour.Text = "Retour";
            this.bt_retour.Click += new System.EventHandler(this.bt_retour_Click);
            // 
            // pBTrouver
            // 
            this.pBTrouver.Image = ((System.Drawing.Image)(resources.GetObject("pBTrouver.Image")));
            this.pBTrouver.Location = new System.Drawing.Point(203, 68);
            this.pBTrouver.Name = "pBTrouver";
            this.pBTrouver.Size = new System.Drawing.Size(30, 30);
            this.pBTrouver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBTrouver.Click += new System.EventHandler(this.pBTrouver_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Location = new System.Drawing.Point(11, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 1);
            // 
            // tb_depot
            // 
            this.tb_depot.Location = new System.Drawing.Point(79, 72);
            this.tb_depot.Name = "tb_depot";
            this.tb_depot.Size = new System.Drawing.Size(116, 21);
            this.tb_depot.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.Text = "Nom Depôt";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(11, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.Text = "Num";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.Text = "Adr";
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(59, 126);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(126, 21);
            this.tb_num.TabIndex = 12;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(59, 156);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(126, 21);
            this.tb_nom.TabIndex = 13;
            // 
            // tb_adr
            // 
            this.tb_adr.Location = new System.Drawing.Point(59, 184);
            this.tb_adr.Name = "tb_adr";
            this.tb_adr.Size = new System.Drawing.Size(126, 21);
            this.tb_adr.TabIndex = 14;
            // 
            // bt_suivant
            // 
            this.bt_suivant.Location = new System.Drawing.Point(157, 237);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(72, 20);
            this.bt_suivant.TabIndex = 15;
            this.bt_suivant.Text = "Suivant";
            this.bt_suivant.Click += new System.EventHandler(this.bt_suivant_Click);
            // 
            // check_in_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.tb_adr);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_depot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pBTrouver);
            this.Controls.Add(this.bt_retour);
            this.Controls.Add(this.titre);
            this.Menu = this.mainMenu1;
            this.Name = "check_in_out";
            this.Text = "check_in_out";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button bt_retour;
        private System.Windows.Forms.PictureBox pBTrouver;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_depot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_adr;
        private System.Windows.Forms.Button bt_suivant;

    }
}