using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TNT.login;


namespace TNT
{
    public partial class Info_exp_dest : Form
    {
        private List<Enlevement.type_client> m_type_pers = new List<TNT.Enlevement.type_client>();
        private List<Enlevement.structure_personne> m_list_pers = new List<Enlevement.structure_personne>();
        private Enlevement.structure_personne str_pers;
        private Enlevement.type_client str_type;
        public string id_expediteur;
        public string id_pers;
        public exp_dest dest;
        public scanne scan;
        public string type_pers;
        private String m_id_exp;
        private String m_id_dest;
        private String m_user;


        private List<Enlevement.structure_personne> liste
        {
            get { return m_list_pers; }
            set { m_list_pers = value; }
        }
        private List<Enlevement.type_client> type_clt
        {
            get{ return m_type_pers;}
            set { m_type_pers = value; }
        }
        private Enlevement.structure_personne list_pers_ajt
        {
            get { return str_pers; }
            set { str_pers = value; }
        }
        public String id_exp
        {
            get { return m_id_exp; }
            set { m_id_exp = value; }
        }
        private String id_dest
        {
            get { return m_id_dest; }
            set { m_id_dest = value; }
        }
        public String User
        {
            get { return m_user; }
            set { m_user = value; }
        }


        public Info_exp_dest()
        {
            InitializeComponent();

            if (scanne.fermer == true)
            {
                this.Close();
            }

        }





        public void recherche(DataSet ds)
        {
            tb_nom.Text = ds.Tables[0].Rows[0][2].ToString();
            tb_prenom.Text = ds.Tables[0].Rows[0][3].ToString();
            tb_societe.Text = ds.Tables[0].Rows[0][4].ToString();
            tb_code_agence.Text = ds.Tables[0].Rows[0][11].ToString();
        
        }


        private void pBValiderVisite_Click_1(object sender, EventArgs e)
        {
            if (type_pers == "Expéditeur")
            {
                dest = new exp_dest();
                dest.destinataire();
                dest.User = User;
                //id_exp = id_expediteur;
                dest.id_expediteur = id_expediteur;
                dest.Show();
                this.Close();
            }

            if (type_pers == "Destinataire")
            {
                scan = new scanne();
                scan.dest = id_expediteur;
                scan.exp = id_exp;

                this.Close();
                scan.Show();
            }
        }






        private void pBHome_Click(object sender, EventArgs e)
        {
            (new Menu()).Show();
            this.Close();
        }




        private void pBUpdate_Click(object sender, EventArgs e)
        {
            int util = int.Parse(traitement_authentification.id_util.ToString());
            traitement_enlevement tr = new traitement_enlevement();
            int repense = tr.insert(tb_nom.Text.ToString(), tb_prenom.Text.ToString(), tb_societe.Text.ToString(),tb_code_agence.Text.ToString(),type_pers,util);
            //ajt_pers();
            if (repense != -1)
            {
                if (type_pers == "Expéditeur")
                {
                    MessageBox.Show("L'Expéditeur est ajouté avec succé");
                    dest = new exp_dest();
                    dest.destinataire();
                    //dest.User = User;
                    dest.Show();
                    this.Close();
                }

                if (type_pers == "Destinataire")
                {
                    MessageBox.Show("Le Destinataire est ajouté avec succé");
                    scan = new scanne();
                    scan.exp = id_exp;
                    //scan.User = User;
                    scan.Show();
                    this.Close();
                }

            }

        }

        public void fermer()
        {
            this.Close();
        }

        private void Info_exp_dest_Load(object sender, EventArgs e)
        {
            if (scanne.fermer == true)
            {
                this.Close();
            }
        }

        private void Info_exp_dest_Load_1(object sender, EventArgs e)
        {

        }





    }
}