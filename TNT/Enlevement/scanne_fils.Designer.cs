namespace TNT.Enlevement
{
    partial class scanne_fils
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scanne_fils));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.button1 = new System.Windows.Forms.Button();
            this.pBQuitter = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBUpdate = new System.Windows.Forms.PictureBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.scannedData = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.Label();
            this.articleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 18;
            this.button1.Text = "Sous colis";
            // 
            // pBQuitter
            // 
            this.pBQuitter.Image = ((System.Drawing.Image)(resources.GetObject("pBQuitter.Image")));
            this.pBQuitter.Location = new System.Drawing.Point(173, 216);
            this.pBQuitter.Name = "pBQuitter";
            this.pBQuitter.Size = new System.Drawing.Size(41, 40);
            this.pBQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBQuitter.Click += new System.EventHandler(this.pBQuitter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Location = new System.Drawing.Point(9, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(48, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.Text = "Scanne Sous Colis ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Scanner";
            // 
            // pBUpdate
            // 
            this.pBUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pBUpdate.Image")));
            this.pBUpdate.Location = new System.Drawing.Point(104, 216);
            this.pBUpdate.Name = "pBUpdate";
            this.pBUpdate.Size = new System.Drawing.Size(42, 40);
            this.pBUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBUpdate.Click += new System.EventHandler(this.pBUpdate_Click);
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(31, 213);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(43, 43);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click);
            // 
            // scannedData
            // 
            this.scannedData.BackColor = System.Drawing.Color.Aquamarine;
            this.scannedData.Location = new System.Drawing.Point(7, 52);
            this.scannedData.Name = "scannedData";
            this.scannedData.Size = new System.Drawing.Size(227, 25);
            // 
            // article
            // 
            this.article.Location = new System.Drawing.Point(7, 90);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(214, 19);
            this.article.Text = "saisie manuelle";
            // 
            // articleBox
            // 
            this.articleBox.Location = new System.Drawing.Point(7, 112);
            this.articleBox.Name = "articleBox";
            this.articleBox.Size = new System.Drawing.Size(226, 21);
            this.articleBox.TabIndex = 17;
            // 
            // scanne_fils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pBQuitter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBUpdate);
            this.Controls.Add(this.pBHome);
            this.Controls.Add(this.scannedData);
            this.Controls.Add(this.article);
            this.Controls.Add(this.articleBox);
            this.Menu = this.mainMenu1;
            this.Name = "scanne_fils";
            this.Text = "scanne_fils";
            this.Load += new System.EventHandler(this.scanne_fils_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pBQuitter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBUpdate;
        private System.Windows.Forms.PictureBox pBHome;
        private System.Windows.Forms.Label scannedData;
        private System.Windows.Forms.Label article;
        private System.Windows.Forms.TextBox articleBox;
    }
}