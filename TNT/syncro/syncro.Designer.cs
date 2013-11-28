namespace TNT.syncro
{
    partial class syncro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(syncro));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_syncro_pc_pda = new System.Windows.Forms.Label();
            this.bt_synch_pda = new System.Windows.Forms.PictureBox();
            this.bt_synch_pc = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(196, 211);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(30, 30);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.Text = "Syncronisation PDA -> PC";
            // 
            // lab_syncro_pc_pda
            // 
            this.lab_syncro_pc_pda.Enabled = false;
            this.lab_syncro_pc_pda.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lab_syncro_pc_pda.Location = new System.Drawing.Point(5, 124);
            this.lab_syncro_pc_pda.Name = "lab_syncro_pc_pda";
            this.lab_syncro_pc_pda.Size = new System.Drawing.Size(220, 20);
            this.lab_syncro_pc_pda.Text = "Syncronisation PC -> PDA";
            // 
            // bt_synch_pda
            // 
            this.bt_synch_pda.BackColor = System.Drawing.Color.White;
            this.bt_synch_pda.Enabled = false;
            this.bt_synch_pda.Image = ((System.Drawing.Image)(resources.GetObject("bt_synch_pda.Image")));
            this.bt_synch_pda.Location = new System.Drawing.Point(49, 165);
            this.bt_synch_pda.Name = "bt_synch_pda";
            this.bt_synch_pda.Size = new System.Drawing.Size(113, 54);
            this.bt_synch_pda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_synch_pda.Click += new System.EventHandler(this.bt_synch_pda_Click);
            // 
            // bt_synch_pc
            // 
            this.bt_synch_pc.BackColor = System.Drawing.Color.White;
            this.bt_synch_pc.Image = ((System.Drawing.Image)(resources.GetObject("bt_synch_pc.Image")));
            this.bt_synch_pc.Location = new System.Drawing.Point(49, 46);
            this.bt_synch_pc.Name = "bt_synch_pc";
            this.bt_synch_pc.Size = new System.Drawing.Size(113, 54);
            this.bt_synch_pc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_synch_pc.Click += new System.EventHandler(this.bt_synch_pc_Click);
            // 
            // syncro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.bt_synch_pc);
            this.Controls.Add(this.bt_synch_pda);
            this.Controls.Add(this.lab_syncro_pc_pda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBHome);
            this.Menu = this.mainMenu1;
            this.Name = "syncro";
            this.Text = "syncro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_syncro_pc_pda;
        private System.Windows.Forms.PictureBox bt_synch_pda;
        private System.Windows.Forms.PictureBox bt_synch_pc;
    }
}