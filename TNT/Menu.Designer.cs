namespace TNT
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.check = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pBEnd = new System.Windows.Forms.PictureBox();
            this.pB_enlev = new System.Windows.Forms.PictureBox();
            this.pB_recep = new System.Windows.Forms.PictureBox();
            this.lab_enlev = new System.Windows.Forms.Label();
            this.lab_recep = new System.Windows.Forms.Label();
            this.pBSyncPCversPDA = new System.Windows.Forms.PictureBox();
            this.lab_sync = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(112, 126);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(93, 46);
            this.check.TabIndex = 1;
            this.check.Text = "check in\\check out";
            this.check.Visible = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // pBEnd
            // 
            this.pBEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pBEnd.Image = ((System.Drawing.Image)(resources.GetObject("pBEnd.Image")));
            this.pBEnd.Location = new System.Drawing.Point(136, 181);
            this.pBEnd.Name = "pBEnd";
            this.pBEnd.Size = new System.Drawing.Size(69, 65);
            this.pBEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBEnd.Click += new System.EventHandler(this.pBEnd_Click_1);
            // 
            // pB_enlev
            // 
            this.pB_enlev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pB_enlev.Enabled = false;
            this.pB_enlev.Image = ((System.Drawing.Image)(resources.GetObject("pB_enlev.Image")));
            this.pB_enlev.Location = new System.Drawing.Point(14, 11);
            this.pB_enlev.Name = "pB_enlev";
            this.pB_enlev.Size = new System.Drawing.Size(87, 54);
            this.pB_enlev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_enlev.Click += new System.EventHandler(this.pBStock_Click_1);
            // 
            // pB_recep
            // 
            this.pB_recep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pB_recep.Enabled = false;
            this.pB_recep.Image = ((System.Drawing.Image)(resources.GetObject("pB_recep.Image")));
            this.pB_recep.Location = new System.Drawing.Point(14, 98);
            this.pB_recep.Name = "pB_recep";
            this.pB_recep.Size = new System.Drawing.Size(87, 54);
            this.pB_recep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_recep.Click += new System.EventHandler(this.pBDelivery_Click_1);
            // 
            // lab_enlev
            // 
            this.lab_enlev.BackColor = System.Drawing.Color.Transparent;
            this.lab_enlev.Enabled = false;
            this.lab_enlev.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lab_enlev.Location = new System.Drawing.Point(12, 64);
            this.lab_enlev.Name = "lab_enlev";
            this.lab_enlev.Size = new System.Drawing.Size(85, 20);
            this.lab_enlev.Text = "Enlevement";
            // 
            // lab_recep
            // 
            this.lab_recep.BackColor = System.Drawing.Color.Transparent;
            this.lab_recep.Enabled = false;
            this.lab_recep.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lab_recep.Location = new System.Drawing.Point(14, 150);
            this.lab_recep.Name = "lab_recep";
            this.lab_recep.Size = new System.Drawing.Size(100, 20);
            this.lab_recep.Text = "Livraison";
            // 
            // pBSyncPCversPDA
            // 
            this.pBSyncPCversPDA.BackColor = System.Drawing.Color.White;
            this.pBSyncPCversPDA.Image = ((System.Drawing.Image)(resources.GetObject("pBSyncPCversPDA.Image")));
            this.pBSyncPCversPDA.Location = new System.Drawing.Point(139, 11);
            this.pBSyncPCversPDA.Name = "pBSyncPCversPDA";
            this.pBSyncPCversPDA.Size = new System.Drawing.Size(66, 55);
            this.pBSyncPCversPDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSyncPCversPDA.Click += new System.EventHandler(this.pBSyncPCversPDA_Click_1);
            // 
            // lab_sync
            // 
            this.lab_sync.BackColor = System.Drawing.Color.Transparent;
            this.lab_sync.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lab_sync.Location = new System.Drawing.Point(129, 69);
            this.lab_sync.Name = "lab_sync";
            this.lab_sync.Size = new System.Drawing.Size(98, 20);
            this.lab_sync.Text = "Syncronisation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(24, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.Text = "Cloturé";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(128, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.Text = "Deconexion";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_sync);
            this.Controls.Add(this.pBSyncPCversPDA);
            this.Controls.Add(this.pB_recep);
            this.Controls.Add(this.pB_enlev);
            this.Controls.Add(this.pBEnd);
            this.Controls.Add(this.check);
            this.Controls.Add(this.lab_recep);
            this.Controls.Add(this.lab_enlev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Menu = this.mainMenu1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.PictureBox pBEnd;
        private System.Windows.Forms.PictureBox pB_enlev;
        private System.Windows.Forms.Label lab_enlev;
        private System.Windows.Forms.Label lab_recep;
        private System.Windows.Forms.PictureBox pBSyncPCversPDA;
        private System.Windows.Forms.Label lab_sync;
        private System.Windows.Forms.PictureBox pB_recep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}