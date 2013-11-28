using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TNT.login
{
    public partial class authentification : Form
     {
       traitement_authentification tr = new traitement_authentification();

       string repertoire = ConfigurationManager.GetChemin<string>("repertoire");

      public authentification()
        {
            InitializeComponent();
            string bdd = repertoire.Substring(15, 2);
            lab_bdd.Text = bdd;
        }

      
       private void pb_Entrer_Click(object sender, EventArgs e)
        {
            tr.Traitement(textBoxLogin.Text.ToString(), textBoxPassword.Text.ToString());
        }

        private void pb_Fermer_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void pBQuitter_Click(object sender, EventArgs e)
        {

        }

        private void pBLogin_Click(object sender, EventArgs e)
        {

        }

        private void pBQuitter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBLogin_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; 
         
            tr.Traitement(textBoxLogin.Text.ToString(), textBoxPassword.Text.ToString());

            Cursor.Current = Cursors.Default; 
        }

        private void lMobilusSolution_ParentChanged(object sender, EventArgs e)
        {

        }

    }

} 
