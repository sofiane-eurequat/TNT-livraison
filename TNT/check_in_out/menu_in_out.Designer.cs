namespace TNT.check_in_out
{
    partial class menu_in_out
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.bt_check_in = new System.Windows.Forms.Button();
            this.bt_check_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_check_in
            // 
            this.bt_check_in.Location = new System.Drawing.Point(58, 52);
            this.bt_check_in.Name = "bt_check_in";
            this.bt_check_in.Size = new System.Drawing.Size(135, 35);
            this.bt_check_in.TabIndex = 0;
            this.bt_check_in.Text = "Check in";
            this.bt_check_in.Click += new System.EventHandler(this.bt_check_in_Click);
            // 
            // bt_check_out
            // 
            this.bt_check_out.Location = new System.Drawing.Point(58, 168);
            this.bt_check_out.Name = "bt_check_out";
            this.bt_check_out.Size = new System.Drawing.Size(135, 37);
            this.bt_check_out.TabIndex = 1;
            this.bt_check_out.Text = "Check out";
            this.bt_check_out.Click += new System.EventHandler(this.bt_check_out_Click);
            // 
            // menu_in_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.bt_check_out);
            this.Controls.Add(this.bt_check_in);
            this.Menu = this.mainMenu1;
            this.Name = "menu_in_out";
            this.Text = "menu_in_out";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_check_in;
        private System.Windows.Forms.Button bt_check_out;
    }
}