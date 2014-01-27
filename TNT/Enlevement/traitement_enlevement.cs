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
using ComponentPro.Net;
using TNT.Helper;

namespace TNT.login
{

    class traitement_enlevement    {
        public DataSet ds;
        public DataSet dss;
        public int rep;
        public static int identifiant;
        public static int expediteur;
        public static int destinataire;
        public static int util_exp;
        public static int util_dest;
        public int id_type;


        string personne = ConfigurationManager.GetChemin<string>("U_personne");
        string enlevement = ConfigurationManager.GetChemin<string>("U_enlevement");
        string pers_type = ConfigurationManager.GetChemin<string>("U_pers_type");

        string repertoire = ConfigurationManager.GetChemin<string>("repertoire");
        string repertoire_signature = ConfigurationManager.GetChemin<string>("repertoire")+"signature/enlevement";

        string serv_personne = ConfigurationManager.GetChemin<string>("repertoire")+ConfigurationManager.GetChemin<string>("U_serv_personne");
        string serv_enlevement = ConfigurationManager.GetChemin<string>("repertoire")+ConfigurationManager.GetChemin<string>("U_serv_enlevement");
        string serv_pers_type = ConfigurationManager.GetChemin<string>("repertoire")+ConfigurationManager.GetChemin<string>("U_serv_pers_type");

        string server = ConfigurationManager.GetChemin<string>("server");
        string user = ConfigurationManager.GetChemin<string>("user");
        string pw = ConfigurationManager.GetChemin<string>("pw");

        

        public bool recherche(string societe,string type_pers,string type)
        {
            bool repense = false;
            requete_enlevement req = new requete_enlevement();
            if (type == "code")
            {
                ds = req.Select_rech_pers(societe);
            }
            if(type=="nom")
            {
                ds = req.Select_rech_pers_nom(societe);
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("La société n'existe pas");
                return repense;
            }
            else
            {
                int id_type;
                if (type_pers == "Destinataire")
                {
                    id_type = 2;
                }
                else 
                {
                    id_type = 1;
                }
                identifiant = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                int util_pers = int.Parse(ds.Tables[0].Rows[0][1].ToString());
                
                dss = req.Select_rech_type_pers(identifiant,util_pers, id_type);
                if (dss.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("La société n'existe pas");
                    return repense;
                }
                else
                {
                    if (type_pers == "Destinataire")
                    {
                        destinataire = int.Parse(dss.Tables[0].Rows[0][0].ToString());
                        util_dest = int.Parse(dss.Tables[0].Rows[0][1].ToString());
                    }
                    else
                    {
                        expediteur = int.Parse(dss.Tables[0].Rows[0][0].ToString());
                        util_exp = int.Parse(dss.Tables[0].Rows[0][1].ToString());
                    }
                    Info_exp_dest inf = new Info_exp_dest();
                    inf.type_pers = type_pers;
                    inf.titre.Text = "Information Client";
                    inf.recherche(ds);
                    inf.Show();
                    repense = true;
                    return repense;
                }
            }

        }
        int repense;


        public int insert(string nom, string prnom, string soc, string code_agence, string type_pers, int util)
        {
            requete_enlevement req = new requete_enlevement();
            int existe_pers = req.verifier_pers(nom, prnom, soc, type_pers);
            if(existe_pers==-1)
            {
                rep = req.insert_pers(nom,prnom,soc,code_agence,util);

                if (rep == -1)
                {
                    MessageBox.Show("La personne n'a pas pu etre insert !!!");
                    return rep;
                }
                else
                {
                    int id_pers=req.count_pers("id_pers","personne");
                    if (type_pers == "Destinataire")
                    {
                        id_type = 2;
                        repense = req.insert_type_pers(id_pers, id_type,util);
                        destinataire = req.count_pers("id_pers_type","pers_type");
                        util_dest = util;
                    }
                    else
                    {
                        if (type_pers == "Expéditeur")
                        {
                            id_type = 1;
                            repense = req.insert_type_pers(id_pers, id_type,util);
                            expediteur = req.count_pers("id_pers_type", "pers_type");
                            util_exp = util;
                        }
                    }
                    return repense;
                }
            }
            else
            {
                if (existe_pers == -2)
                {
                    MessageBox.Show("Cette personne existe déjà dans la base de données !!!");
                    return -1;
                }
                else 
                {
                    if (type_pers == "Destinataire")
                    {
                        id_type = 2;
                        repense = req.insert_type_pers(existe_pers, id_type,util);
                        destinataire = req.count_pers("id_pers_type", "pers_type");
                    }
                    else
                    {
                        if (type_pers == "Expéditeur")
                        {
                            id_type = 1;
                            repense = req.insert_type_pers(existe_pers, id_type,util);
                            expediteur = req.count_pers("id_pers_type", "pers_type");
                        }
                    }
                    return repense;              
                }
            }
        }


        public void exporte_fichier()
        {

// exporte enlevement
            requete_enlevement req = new requete_enlevement();
            DataSet ds_enlev = req.select_tab("enlevement");
            StreamWriter sw_enlev = new StreamWriter(enlevement);//création du fichier 
               
            foreach(DataRow dr in ds_enlev.Tables[0].Rows )
            {
                string sp = ";";
                string text = dr[0].ToString() + sp + dr[1].ToString() + sp + dr[2].ToString() + sp + dr[3].ToString() + sp + dr[4].ToString() + sp + dr[5].ToString() + sp + dr[6].ToString() + sp + dr[7].ToString() + sp + dr[8].ToString() + sp + dr[9].ToString() + sp + dr[10].ToString() + sp + dr[11].ToString() + sp + dr[12].ToString() + sp + dr[13].ToString() + "\n";
                //text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                sw_enlev.Write(text);//enregistrement du message dans le fichier 
            }
            sw_enlev.Close();

// exporte personne 
            DataSet ds_pers = req.select_tab("personne");
            StreamWriter sw_pers = new StreamWriter(personne);//création du fichier 

            foreach (DataRow dr in ds_pers.Tables[0].Rows)
            {
                string sp = ";";
                string text = dr[0].ToString() + sp + dr[1].ToString() + sp + dr[2].ToString() + sp + dr[3].ToString() + sp + dr[4].ToString() + sp + dr[5].ToString() + sp + dr[6].ToString() + sp + dr[7].ToString() + sp + dr[8].ToString() + sp + dr[9].ToString() + sp + dr[10].ToString() + sp + dr[11].ToString() + "\n";
                //text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                sw_pers.Write(text);//enregistrement du message dans le fichier 
            }
            sw_pers.Close();

// exporte personne type
            DataSet ds_pers_type = req.select_tab("pers_type");
            StreamWriter sw_type_pers = new StreamWriter(pers_type);//création du fichier 

            foreach (DataRow dr in ds_pers_type.Tables[0].Rows)
            {
                string sp = ";";
                string text = dr[0].ToString() + sp + dr[1].ToString() + sp + dr[2].ToString() + sp + dr[3].ToString() + sp + dr[4].ToString() + sp + dr[5].ToString() + "\n";
                //text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                sw_type_pers.Write(text);//enregistrement du message dans le fichier 
            }
            sw_type_pers.Close();

        }

        
        public void upload()// transferer de PDA vers serveur
        {
            try
            {
                
                Ftp client = new Ftp();
                client.Connect(server);
                client.Authenticate(user, pw);   
                
                if (!client.DirectoryExists(repertoire))
                {
                    client.CreateDirectory(repertoire);
                }
                
                if (!client.DirectoryExists(repertoire_signature))
                {
                    client.CreateDirectory(repertoire_signature);
                }
                
                client.UploadFiles("My Documents\\signature\\enlevement", repertoire_signature);
                
                client.UploadFile(enlevement, serv_enlevement);
                client.UploadFile(personne, serv_personne);
                client.UploadFile(pers_type, serv_pers_type);
                
                client.Disconnect();
                MessageBox.Show("Enlevement effectue avec synchronisation!");

            }
            catch (FtpException e)
            {
                WriteLogFile.write("Traitement_enlevement " + e.Message + " ; 0 ; " + traitement_authentification.sync);
                MessageBox.Show("Problème de connexion! synchronisation non effectue!");
            }
        }
    }
}
