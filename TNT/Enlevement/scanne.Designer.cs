namespace TNT
{
    partial class scanne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scanne));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.scannedData = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.Label();
            this.scan_manuel = new System.Windows.Forms.TextBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.pBUpdate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pBQuitter = new System.Windows.Forms.PictureBox();
            this.txb_gn_desc = new System.Windows.Forms.TextBox();
            this.txb_package = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zone_signature = new System.Windows.Forms.Panel();
            this.Effacer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_com = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scannedData
            // 
            this.scannedData.BackColor = System.Drawing.Color.Aquamarine;
            this.scannedData.Location = new System.Drawing.Point(5, 39);
            this.scannedData.Name = "scannedData";
            this.scannedData.Size = new System.Drawing.Size(115, 23);

            // 
            // article
            // 
            this.article.Location = new System.Drawing.Point(125, 21);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(105, 19);
            this.article.Text = "Saisie manuelle";
            // 
            // scan_manuel
            // 
            this.scan_manuel.Location = new System.Drawing.Point(122, 40);
            this.scan_manuel.Name = "scan_manuel";
            this.scan_manuel.Size = new System.Drawing.Size(116, 21);
            this.scan_manuel.TabIndex = 6;
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(44, 230);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(35, 35);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click_1);
            // 
            // pBUpdate
            // 
            this.pBUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pBUpdate.Image")));
            this.pBUpdate.Location = new System.Drawing.Point(103, 230);
            this.pBUpdate.Name = "pBUpdate";
            this.pBUpdate.Size = new System.Drawing.Size(35, 35);
            this.pBUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBUpdate.Click += new System.EventHandler(this.pBUpdate_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.Text = "Scanner";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(70, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Scan Colis";
            // 
            // pBQuitter
            // 
            this.pBQuitter.Image = ((System.Drawing.Image)(resources.GetObject("pBQuitter.Image")));
            this.pBQuitter.Location = new System.Drawing.Point(160, 230);
            this.pBQuitter.Name = "pBQuitter";
            this.pBQuitter.Size = new System.Drawing.Size(35, 35);
            this.pBQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBQuitter.Click += new System.EventHandler(this.pBQuitter_Click);
            // 
            // txb_gn_desc
            // 
            this.txb_gn_desc.Location = new System.Drawing.Point(6, 87);
            this.txb_gn_desc.Name = "txb_gn_desc";
            this.txb_gn_desc.Size = new System.Drawing.Size(119, 21);
            this.txb_gn_desc.TabIndex = 17;
            // 
            // txb_package
            // 
            this.txb_package.Location = new System.Drawing.Point(153, 87);
            this.txb_package.Name = "txb_package";
            this.txb_package.Size = new System.Drawing.Size(78, 21);
            this.txb_package.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.Text = "General description";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(151, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.Text = "Nbr Plis";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Location = new System.Drawing.Point(7, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 1);
            // 
            // zone_signature
            // 
            this.zone_signature.BackColor = System.Drawing.Color.WhiteSmoke;
            this.zone_signature.Location = new System.Drawing.Point(7, 136);
            this.zone_signature.Name = "zone_signature";
            this.zone_signature.Size = new System.Drawing.Size(100, 80);
            // 
            // Effacer
            // 
            this.Effacer.Location = new System.Drawing.Point(63, 118);
            this.Effacer.Name = "Effacer";
            this.Effacer.Size = new System.Drawing.Size(45, 16);
            this.Effacer.TabIndex = 0;
            this.Effacer.Text = "Effacer";
            this.Effacer.Click += new System.EventHandler(this.Effacer_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.Text = "Signature";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(125, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.Text = "Commentaires";
            // 
            // txb_com
            // 
            this.txb_com.Location = new System.Drawing.Point(113, 136);
            this.txb_com.Multiline = true;
            this.txb_com.Name = "txb_com";
            this.txb_com.Size = new System.Drawing.Size(124, 80);
            this.txb_com.TabIndex = 46;
            // 
            // scanne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Effacer);
            this.Controls.Add(this.txb_com);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zone_signature);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_package);
            this.Controls.Add(this.txb_gn_desc);
            this.Controls.Add(this.pBQuitter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBUpdate);
            this.Controls.Add(this.pBHome);
            this.Controls.Add(this.scannedData);
            this.Controls.Add(this.article);
            this.Controls.Add(this.scan_manuel);
            this.Menu = this.mainMenu1;
            this.Name = "scanne";
            this.Text = "Scan";
            this.Load += new System.EventHandler(this.scanne_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label scannedData;
        private System.Windows.Forms.Label article;
        private System.Windows.Forms.TextBox scan_manuel;
        private System.Windows.Forms.PictureBox pBHome;
        private System.Windows.Forms.PictureBox pBUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBQuitter;
        private System.Windows.Forms.TextBox txb_gn_desc;
        private System.Windows.Forms.TextBox txb_package;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel zone_signature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_com;
        private System.Windows.Forms.Button Effacer;
    }
}