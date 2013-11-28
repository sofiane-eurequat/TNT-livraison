namespace TNT.reception
{
    partial class recept_info_sup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recept_info_sup));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.enr_recept = new System.Windows.Forms.PictureBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txb_com = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zone_signature = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_code = new System.Windows.Forms.Label();
            this.Effacer = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // enr_recept
            // 
            this.enr_recept.Image = ((System.Drawing.Image)(resources.GetObject("enr_recept.Image")));
            this.enr_recept.Location = new System.Drawing.Point(142, 223);
            this.enr_recept.Name = "enr_recept";
            this.enr_recept.Size = new System.Drawing.Size(42, 40);
            this.enr_recept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enr_recept.Click += new System.EventHandler(this.enr_recept_Click);
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(57, 221);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(43, 43);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel4.Location = new System.Drawing.Point(11, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(11, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 22);
            this.label6.Text = "Réception info supplémentaire";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(11, 26);
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
            // txb_com
            // 
            this.txb_com.Location = new System.Drawing.Point(112, 79);
            this.txb_com.Multiline = true;
            this.txb_com.Name = "txb_com";
            this.txb_com.Size = new System.Drawing.Size(124, 80);
            this.txb_com.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(124, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.Text = "Commentaires";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.Text = "Signature";
            // 
            // zone_signature
            // 
            this.zone_signature.Location = new System.Drawing.Point(6, 79);
            this.zone_signature.Name = "zone_signature";
            this.zone_signature.Size = new System.Drawing.Size(100, 80);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.Text = "Code";
            // 
            // lab_code
            // 
            this.lab_code.Location = new System.Drawing.Point(82, 35);
            this.lab_code.Name = "lab_code";
            this.lab_code.Size = new System.Drawing.Size(143, 20);
            // 
            // Effacer
            // 
            this.Effacer.Location = new System.Drawing.Point(61, 61);
            this.Effacer.Name = "Effacer";
            this.Effacer.Size = new System.Drawing.Size(45, 16);
            this.Effacer.TabIndex = 59;
            this.Effacer.Text = "Effacer";
            this.Effacer.Click += new System.EventHandler(this.Effacer_Click_1);
            // 
            // recept_info_sup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Effacer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_code);
            this.Controls.Add(this.txb_com);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zone_signature);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.enr_recept);
            this.Controls.Add(this.pBHome);
            this.Menu = this.mainMenu1;
            this.Name = "recept_info_sup";
            this.Text = "Réception";
            this.Load += new System.EventHandler(this.recept_info_sup_Load);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox enr_recept;
        private System.Windows.Forms.PictureBox pBHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txb_com;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel zone_signature;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lab_code;
        private System.Windows.Forms.Button Effacer;
    }
}