namespace TNT
{
    partial class exp_dest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exp_dest));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.TBrech_clt = new System.Windows.Forms.TextBox();
            this.ajout = new System.Windows.Forms.Button();
            this.lab_pers = new System.Windows.Forms.Label();
            this.pBTrouver = new System.Windows.Forms.PictureBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.sp1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_ajt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBrech_nom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBrech_clt
            // 
            this.TBrech_clt.Location = new System.Drawing.Point(20, 54);
            this.TBrech_clt.Name = "TBrech_clt";
            this.TBrech_clt.Size = new System.Drawing.Size(158, 21);
            this.TBrech_clt.TabIndex = 0;
            // 
            // ajout
            // 
            this.ajout.BackColor = System.Drawing.Color.DarkGray;
            this.ajout.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ajout.Location = new System.Drawing.Point(36, 174);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(162, 32);
            this.ajout.TabIndex = 2;
            this.ajout.Text = " ";
            this.ajout.Visible = false;
            this.ajout.Click += new System.EventHandler(this.ajout_Click);
            // 
            // lab_pers
            // 
            this.lab_pers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lab_pers.Location = new System.Drawing.Point(83, 3);
            this.lab_pers.Name = "lab_pers";
            this.lab_pers.Size = new System.Drawing.Size(115, 20);
            this.lab_pers.Text = "label1";
            // 
            // pBTrouver
            // 
            this.pBTrouver.Image = ((System.Drawing.Image)(resources.GetObject("pBTrouver.Image")));
            this.pBTrouver.Location = new System.Drawing.Point(185, 48);
            this.pBTrouver.Name = "pBTrouver";
            this.pBTrouver.Size = new System.Drawing.Size(30, 30);
            this.pBTrouver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBTrouver.Click += new System.EventHandler(this.pBTrouver_Click_1);
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(20, 224);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(48, 41);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click_1);
            // 
            // sp1
            // 
            this.sp1.BackColor = System.Drawing.SystemColors.InfoText;
            this.sp1.Location = new System.Drawing.Point(11, 148);
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(218, 1);
            this.sp1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Location = new System.Drawing.Point(11, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Location = new System.Drawing.Point(11, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.Text = "Recherche par Code Agence";
            this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // lab_ajt
            // 
            this.lab_ajt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lab_ajt.Location = new System.Drawing.Point(20, 151);
            this.lab_ajt.Name = "lab_ajt";
            this.lab_ajt.Size = new System.Drawing.Size(100, 20);
            this.lab_ajt.Text = "Ajouter";
            this.lab_ajt.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.Text = "Recherche par Nom Agence";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TBrech_nom
            // 
            this.TBrech_nom.Location = new System.Drawing.Point(20, 119);
            this.TBrech_nom.Name = "TBrech_nom";
            this.TBrech_nom.Size = new System.Drawing.Size(158, 21);
            this.TBrech_nom.TabIndex = 10;
            // 
            // exp_dest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBrech_nom);
            this.Controls.Add(this.lab_ajt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sp1);
            this.Controls.Add(this.pBHome);
            this.Controls.Add(this.pBTrouver);
            this.Controls.Add(this.lab_pers);
            this.Controls.Add(this.ajout);
            this.Controls.Add(this.TBrech_clt);
            this.Menu = this.mainMenu1;
            this.Name = "exp_dest";
            this.Text = "exp_dest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBrech_clt;
        private System.Windows.Forms.Button ajout;
        private System.Windows.Forms.Label lab_pers;
        private System.Windows.Forms.PictureBox pBTrouver;
        private System.Windows.Forms.PictureBox pBHome;
        private System.Windows.Forms.Panel sp1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_ajt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBrech_nom;
    }
}