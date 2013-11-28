using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TNT.check_in_out
{
    public partial class check_in_out : Form
    {
        public check_in_out()
        {
            InitializeComponent();
        }

        private void bt_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pBTrouver_Click(object sender, EventArgs e)
        {
            traitement_check tr_check = new traitement_check();
            DataSet ds= tr_check.rech_depot(tb_depot.Text.ToString());
            tb_num.Text = ds.Tables[0].Rows[0][0].ToString();
            tb_nom.Text = ds.Tables[0].Rows[0][1].ToString();
            tb_adr.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void bt_suivant_Click(object sender, EventArgs e)
        {
            scanne_in_out in_out = new scanne_in_out();

            traitement_check tr_check = new traitement_check();


            in_out.check_in = tr_check.eng_in();
            in_out.Show();
        }
    }
}