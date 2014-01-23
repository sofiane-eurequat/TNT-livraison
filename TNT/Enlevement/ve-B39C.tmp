using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNT.login;

namespace TNT
{
    public partial class exp_dest : Form
    {
        private List<Enlevement.structure_personne> m_list_pers = new List<Enlevement.structure_personne>();
        public String m_user;
        public bool fermer;
        private List<Enlevement.structure_personne> liste
        {
            get { return m_list_pers; }
            set { m_list_pers = value; }
        }
        public String User
        {
            get { return m_user; }
            set { m_user = value; }
        }
        public static Info_exp_dest info;
        public string type_personne;
        public String id_expediteur="";

        public exp_dest()
        {
            InitializeComponent();
            string grade_util = traitement_authentification.grade_util;
            if (grade_util == "1")
            {
                sp1.Visible = true;
                lab_ajt.Visible = true;
                ajout.Visible = true;
            }
        }

        public void expediteur()
        {
            ajout.Text = "Ajouter expéditeur";
            type_personne = "expediteur";
            lab_pers.Text = "Expéditeur";  
        }

        public void destinataire()
        {
            ajout.Text = "Ajouter Destinataire";
            type_personne = "destinateire";
            lab_pers.Text = "Destinataire";
        }

        private void ajout_Click(object sender, EventArgs e)
        {
            info = new Info_exp_dest();
            info.bt_suivant.Visible = false;
            info.type_pers = lab_pers.Text;
            if (lab_pers.Text == "Destinataire")
            {
                info.titre.Text = "Ajout Destinataire";
            }
            else 
            { 
                info.titre.Text = "Ajout Expéditeur"; 
            }
            info.Show();
            this.Close();
        }


        private void pBTrouver_Click_1(object sender, EventArgs e)
        {
            traitement_enlevement tr = new traitement_enlevement();
            bool rep =tr.recherche(TBrech_clt.Text.ToString(),lab_pers.Text.ToString(),"code");
            if (rep == true) { this.Close(); }
        }


        private void pBHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
            (new Menu()).Show();
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            traitement_enlevement tr = new traitement_enlevement();
            bool rep = tr.recherche(TBrech_nom.Text.ToString(), lab_pers.Text.ToString(),"nom");
            if (rep == true) { this.Close(); }
        }
    }
}