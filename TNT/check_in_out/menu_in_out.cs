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
    public partial class menu_in_out : Form
    {
        public static string check;

        public menu_in_out()
        {
            InitializeComponent();
        }

        private void bt_check_in_Click(object sender, EventArgs e)
        {
            check_in_out check_in = new check_in_out();
            check_in.titre.Text = "Check IN";
            check_in.Show();
            check = "in";            
        }

        private void bt_check_out_Click(object sender, EventArgs e)
        {
            check_in_out check_out = new check_in_out();
            check_out.titre.Text = "Check OUT";
            check_out.Show();
            check = "out";
        }
    }
}