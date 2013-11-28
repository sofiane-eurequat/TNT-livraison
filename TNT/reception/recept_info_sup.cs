using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNT.Enlevement;
using TNT.login;

namespace TNT.reception
{
    public partial class recept_info_sup : Form
    {

        string repertoire_signature = ConfigurationManager.GetChemin<string>("repertoire_signature");

        public recept_info_sup()
        {
            InitializeComponent();
        }

        private void recept_info_sup_Load(object sender, EventArgs e)
        {
            requete_signature sign = new requete_signature();
            sign.Clear();
            sign.Location = zone_signature.Location;
            sign.Size = zone_signature.Size;

            this.zone_signature.Visible = false;
            //this.Controls.Add(sign);
            this.Controls.Add(sign);

        }

        private void enr_recept_Click(object sender, EventArgs e)
        {
            int util = int.Parse(traitement_authentification.id_util.ToString());
            Cursor.Current = Cursors.WaitCursor;
            enregistrer_img();
            requete_reception req = new requete_reception();

            int cpt_recept=req.count_pers("id_recept","reception");
              
            string cpt_sign=util.ToString()+"-"+cpt_recept.ToString();
            if (!System.IO.Directory.Exists("My Documents\\signature\\reception"))
            {
                System.IO.Directory.CreateDirectory("My Documents\\signature\\reception");
            }
            string chemin = "\\My Documents\\signature\\reception\\RS" + cpt_sign.ToString() +"-"+lab_code.Text.ToString()+ ".png";
            string chemin_serv = repertoire_signature + "reception/RS" + cpt_sign.ToString() + "-" + lab_code.Text.ToString() + ".png";
            requete_signature.image.Save(chemin, System.Drawing.Imaging.ImageFormat.Png);
         
            traitement_reception tr_recept = new traitement_reception();
            int result = tr_recept.insrt_respt(lab_code.Text.ToString(),chemin_serv,txb_com.Text.ToString());
            if (result == 1)
            {
                tr_recept.export_fichier();
                tr_recept.upload();
            }
            Cursor.Current = Cursors.Default; 
         
        }
        public void enregistrer_img()
        {
                   
        }

        private void pBHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Effacer_Click_1(object sender, EventArgs e)
        {
            requete_signature signature = new requete_signature();
            signature.Clear();
        }
    }
}