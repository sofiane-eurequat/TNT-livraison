namespace TNT.login
{
    partial class authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authentification));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelMotdepasse = new System.Windows.Forms.Label();
            this.lb_entrer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pB = new System.Windows.Forms.PictureBox();
            this.lAuthentification = new System.Windows.Forms.Label();
            this.lMobilusSolution = new System.Windows.Forms.Label();
            this.pBQuitter = new System.Windows.Forms.PictureBox();
            this.pBLogin = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_bdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(80, 129);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(136, 21);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(80, 158);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(136, 21);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.Location = new System.Drawing.Point(13, 130);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(58, 20);
            this.labelLogin.Text = "login";
            // 
            // labelMotdepasse
            // 
            this.labelMotdepasse.Location = new System.Drawing.Point(11, 158);
            this.labelMotdepasse.Name = "labelMotdepasse";
            this.labelMotdepasse.Size = new System.Drawing.Size(68, 20);
            this.labelMotdepasse.Text = "pass word ";
            // 
            // lb_entrer
            // 
            this.lb_entrer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_entrer.Location = new System.Drawing.Point(140, 235);
            this.lb_entrer.Name = "lb_entrer";
            this.lb_entrer.Size = new System.Drawing.Size(53, 20);
            this.lb_entrer.Text = "Entrer";
            this.lb_entrer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(34, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.Text = "Fermer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pB
            // 
            this.pB.BackColor = System.Drawing.Color.White;
            this.pB.Image = ((System.Drawing.Image)(resources.GetObject("pB.Image")));
            this.pB.Location = new System.Drawing.Point(6, 31);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(76, 74);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // lAuthentification
            // 
            this.lAuthentification.BackColor = System.Drawing.Color.White;
            this.lAuthentification.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lAuthentification.ForeColor = System.Drawing.Color.OrangeRed;
            this.lAuthentification.Location = new System.Drawing.Point(87, 51);
            this.lAuthentification.Name = "lAuthentification";
            this.lAuthentification.Size = new System.Drawing.Size(150, 20);
            this.lAuthentification.Text = "Authentification";
            // 
            // lMobilusSolution
            // 
            this.lMobilusSolution.BackColor = System.Drawing.Color.White;
            this.lMobilusSolution.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lMobilusSolution.ForeColor = System.Drawing.Color.OrangeRed;
            this.lMobilusSolution.Location = new System.Drawing.Point(0, 0);
            this.lMobilusSolution.Name = "lMobilusSolution";
            this.lMobilusSolution.Size = new System.Drawing.Size(240, 22);
            this.lMobilusSolution.Text = "TNT Solution";
            this.lMobilusSolution.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lMobilusSolution.ParentChanged += new System.EventHandler(this.lMobilusSolution_ParentChanged);
            // 
            // pBQuitter
            // 
            this.pBQuitter.Image = ((System.Drawing.Image)(resources.GetObject("pBQuitter.Image")));
            this.pBQuitter.Location = new System.Drawing.Point(44, 199);
            this.pBQuitter.Name = "pBQuitter";
            this.pBQuitter.Size = new System.Drawing.Size(34, 34);
            this.pBQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBQuitter.Click += new System.EventHandler(this.pBQuitter_Click_1);
            // 
            // pBLogin
            // 
            this.pBLogin.BackColor = System.Drawing.Color.White;
            this.pBLogin.Image = ((System.Drawing.Image)(resources.GetObject("pBLogin.Image")));
            this.pBLogin.Location = new System.Drawing.Point(150, 199);
            this.pBLogin.Name = "pBLogin";
            this.pBLogin.Size = new System.Drawing.Size(34, 34);
            this.pBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogin.Click += new System.EventHandler(this.pBLogin_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(187, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 11);
            this.label2.Text = "V 0.4.beta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lab_bdd
            // 
            this.lab_bdd.Location = new System.Drawing.Point(3, 2);
            this.lab_bdd.Name = "lab_bdd";
            this.lab_bdd.Size = new System.Drawing.Size(57, 20);
            // 
            // authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lab_bdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBQuitter);
            this.Controls.Add(this.pBLogin);
            this.Controls.Add(this.lAuthentification);
            this.Controls.Add(this.lMobilusSolution);
            this.Controls.Add(this.pB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_entrer);
            this.Controls.Add(this.labelMotdepasse);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Menu = this.mainMenu1;
            this.Name = "authentification";
            this.Text = "authentification";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelMotdepasse;
        public System.Windows.Forms.TextBox textBoxLogin;
        public System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lb_entrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.Label lAuthentification;
        private System.Windows.Forms.Label lMobilusSolution;
        private System.Windows.Forms.PictureBox pBQuitter;
        private System.Windows.Forms.PictureBox pBLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_bdd;
    }
}