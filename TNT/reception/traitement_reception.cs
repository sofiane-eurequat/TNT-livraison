using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using TNT.login;
using ComponentPro.Net;

namespace TNT.reception
{

    class traitement_reception
    {
        private int id_pers = 0;
        string u_personne = ConfigurationManager.GetChemin<string>("U_personne");
        string u_enlevement = ConfigurationManager.GetChemin<string>("U_enlevement");
        string u_pers_type = ConfigurationManager.GetChemin<string>("U_pers_type");
        string u_utilisateur = ConfigurationManager.GetChemin<string>("U_utilisateur");
        string u_reception = ConfigurationManager.GetChemin<string>("U_reception");

        string repertoire = ConfigurationManager.GetChemin<string>("repertoire");
        string repertoire_signature = ConfigurationManager.GetChemin<string>("repertoire") + "signature/reception";

        
        string u_serv_personne = ConfigurationManager.GetChemin<string>("repertoire")+ConfigurationManager.GetChemin<string>("U_serv_personne");
        string u_serv_enlevement = ConfigurationManager.GetChemin<string>("repertoire")+ConfigurationManager.GetChemin<string>("U_serv_enlevement");
        string u_serv_pers_type = ConfigurationManager.GetChemin<string>("repertoire")+ConfigurationManager.GetChemin<string>("U_serv_pers_type");
        string u_serv_utilisateur = ConfigurationManager.GetChemin<string>("repertoire")+ConfigurationManager.GetChemin<string>("U_serv_utilisateur");
        string u_serv_reception = ConfigurationManager.GetChemin<string>("repertoire")+ConfigurationManager.GetChemin<string>("U_serv_reception");

        string server = ConfigurationManager.GetChemin<string>("server");
        string user = ConfigurationManager.GetChemin<string>("user");
        string pw = ConfigurationManager.GetChemin<string>("pw");


        

        // requete_authentification req; 
        public DataSet ds;
        
        public DataSet rech_dest(string scanne)
        {
            requete_reception req_recpt = new requete_reception();
            DataSet id_personne = req_recpt.retour_id_pers(scanne);
            int id_pers = int.Parse(id_personne.Tables[0].Rows[0][0].ToString());
            int id_util = int.Parse(id_personne.Tables[0].Rows[0][1].ToString());
            ds = req_recpt.Select_dest(id_pers,id_util);
            
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Le code scanner n'est pas correcte !! ");
                return null;
            }
            else 
            {
                return ds;
            }
        }

        public int insrt_respt(string scanne,string signature,string commentaire)
        {
            requete_reception req_recpt = new requete_reception();
            string req ="select id_enlev from enlevement where code_colis='"+scanne+"'";
            string req2 = "select id_util from enlevement where code_colis='" + scanne + "'";
            

            int id_enlev = req_recpt.retour_id( req);
            int id_util = req_recpt.retour_id(req2);
            if (id_enlev != 0)
            {
                DataSet ds = req_recpt.cher_recept(id_enlev,id_util);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    string req_check_out = "select id_check_out from check_out where id_enlev=" + id_enlev.ToString();
                    //int check_out=req_recpt.retour_id(req_check_out);
                    int util = int.Parse(traitement_authentification.id_util.ToString());

                    int repense = req_recpt.insert_recept(id_enlev,util,id_util,signature,commentaire,scanne);
                    if (repense != -1)
                    {
                        MessageBox.Show("reception effecuter avec succée");
                        return 1;
                    }
                    else
                    {

                        MessageBox.Show("erreur requete");
                        return -1;
                    }
                }
                else 
                {
                    MessageBox.Show("Ce colis a déjà été scanner !!!");
                    return -1;

                }
            }
            MessageBox.Show("Ce colis n'a pas était enlevé");
            return -1;
        }

        public void export_fichier() 
        {

            requete_reception req = new requete_reception();
            DataSet ds_recept = req.select_tab("reception");
            StreamWriter sw_recept = new StreamWriter(u_reception);//création du fichier 

            foreach (DataRow dr in ds_recept.Tables[0].Rows)
            {
                string sp = ";";
                string text = dr[0].ToString() + sp + dr[1].ToString() + sp + dr[2].ToString() + sp + dr[3].ToString() + sp + dr[4].ToString() + sp + dr[5].ToString() + sp + dr[6].ToString() + sp + dr[7].ToString() + sp + dr[8].ToString() + sp + dr[10].ToString() + sp+dr[9].ToString()+"\n";
                //text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                sw_recept.Write(text);//enregistrement du message dans le fichier 
            }
            sw_recept.Close();

        }

        public void upload()
        {
            try
            {

                // Create a new instance.
                Ftp client = new Ftp();
                // Connect to the FTP server.
                client.Connect(server);
                // Or you can specify the FTP port with
                // client.Connect("myserver", 21);
                // Authenticate.
                client.Authenticate(user, pw);
                // Do something here...
                

                if (!client.DirectoryExists(repertoire))
                {
                    client.CreateDirectory(repertoire);
                }

                if (!client.DirectoryExists(repertoire_signature))
                {
                    client.CreateDirectory(repertoire_signature);
                }

                client.UploadFiles("My Documents\\signature\\reception", repertoire_signature);
                
                client.UploadFile(u_reception,u_serv_reception);
                // Disconnect.
                client.Disconnect();
                MessageBox.Show("Enlevement effectue avec synchronisation!");

            }
            catch (FtpException e)
            {

                MessageBox.Show("Problème de connexion! synchronisation non effectue!");
            }
        }

    }
}
