using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using ComponentPro.Net;
using System.Windows.Forms;
using ErikEJ.SqlCe;

namespace TNT.syncro
{
    class traitement_download
    {

        string u_personne = ConfigurationManager.GetChemin<string>("U_personne");
        string u_enlevement = ConfigurationManager.GetChemin<string>("U_enlevement");
        string u_pers_type = ConfigurationManager.GetChemin<string>("U_pers_type");
        string u_utilisateur = ConfigurationManager.GetChemin<string>("U_utilisateur");
        string u_reception = ConfigurationManager.GetChemin<string>("U_reception");

        string d_personne = ConfigurationManager.GetChemin<string>("D_personne");
        string d_enlevement = ConfigurationManager.GetChemin<string>("D_enlevement");
        string d_pers_type = ConfigurationManager.GetChemin<string>("D_pers_type");
        string d_utilisateur = ConfigurationManager.GetChemin<string>("D_utilisateur");
        string d_count = ConfigurationManager.GetChemin<string>("D_count");

        
        string d_serv_personne = ConfigurationManager.GetChemin<string>("D_serv_personne");
        string d_serv_enlevement = ConfigurationManager.GetChemin<string>("D_serv_enlevement");
        string d_serv_pers_type = ConfigurationManager.GetChemin<string>("D_serv_pers_type");
        string d_serv_utilisateur = ConfigurationManager.GetChemin<string>("D_serv_utilisateur");

        string d_serv_count = ConfigurationManager.GetChemin<string>("D_serv_count");

        string server = ConfigurationManager.GetChemin<string>("server");
        string user = ConfigurationManager.GetChemin<string>("user");
        string pw = ConfigurationManager.GetChemin<string>("pw");
        

        int rep_tt=1;
        public int download()
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


                client.DownloadFile(d_serv_enlevement , d_enlevement);
                client.DownloadFile(d_serv_personne   , d_personne); 
                client.DownloadFile(d_serv_pers_type  , d_pers_type);
                client.DownloadFile(d_serv_utilisateur, d_utilisateur);



                client.DownloadFile(d_serv_count, d_count);
                // Disconnect.
                
                client.Disconnect();
                MessageBox.Show("Synchronisation PC-> PDA effetue avec succé !");
                return rep_tt = 1;

            }
            catch (FtpException ex)
            {

                MessageBox.Show("Problème de connexion! synchronisation non effectue!");
                return rep_tt = -1;

            }
        }
       
        
        public void sup_fiche()
        {
            if (File.Exists(u_enlevement))
            {
                File.Delete(u_enlevement);
            }
            
            if (File.Exists(u_personne))
            {
                File.Delete(u_personne);
            }
            
            if (File.Exists(u_reception))
            {
                File.Delete(u_reception);
            }
            
            if (File.Exists(u_pers_type))
            {
                File.Delete(u_pers_type);
            }                
        }

        public void delete_tab()
        {
            requete_download req_dn = new requete_download();
            int rep1 = req_dn.delete_tab("enlevement");
            int rep3 = req_dn.delete_tab("pers_type");
            int rep4 = req_dn.delete_tab("utilisateur");
            int rep2 = req_dn.delete_tab("personne");
            if (rep1 != -1 && rep2 != -1 && rep3 != -1 && rep4 != -1)
            {
                MessageBox.Show(" Suppression de base de donnée réussite");
            }
        }
        

        public void insert()
        {
            int rep=-1;
            string[] Tligne = new string[100]; // tableau qui va contenir les sous-chaines extraites d'une ligne.
            char[] splitter = { ';' }; // délimiteur du fichier texte
            string fic_serveur = null; // chaine qui contient le nom du fichier csv à ouvrir
            fic_serveur = d_utilisateur;

            if (System.IO.File.Exists(fic_serveur))
            {
                // On vérifie si le fichier existe avant de l'ouvrir
                System.IO.StreamReader line = new System.IO.StreamReader(fic_serveur);
                string ligne = null;
                // on parcours les lignes jusqu'à la fin du fichier
                requete_download req_dn = new requete_download();
                while ((ligne = line.ReadLine()) != null)
                {
                    Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier
                    string requete_insrt = "INSERT INTO utilisateur (id_util,nom_util,prnom_util,tel_util,adr_util,mail_util,log_util,pw_util,grade_util,status_util) VALUES ( " + 
                        Tligne[0] + ", '"+Tligne[1].ToString() + "','" + Tligne[2].ToString() + "', '" + Tligne[3].ToString() + "','" + Tligne[4].ToString() + "','" + Tligne[5].ToString() + "','" + Tligne[6].ToString() + "','" + Tligne[7].ToString() + "','" + Tligne[8].ToString() + "'," + Tligne[9] + ");";

                    rep = req_dn.insert(requete_insrt,"utilisateur");
                }
                if (rep == -1)
                { MessageBox.Show("Echec insertion | TAB Utilisateur !!"); }
                else { MessageBox.Show("Insert réussite | TAB Utilisateur !!"); }
            }
        }


        public void insert_enlev()
        {
            int rep=-1;
            string[] Tligne = new string[100]; // tableau qui va contenir les sous-chaines extraites d'une ligne.
            char[] splitter = { ';' }; // délimiteur du fichier texte
            string fic_serveur = null; // chaine qui contient le nom du fichier csv à ouvrir
            fic_serveur = d_enlevement;

            if (System.IO.File.Exists(fic_serveur))
            {
                // On vérifie si le fichier existe avant de l'ouvrir
                System.IO.StreamReader line = new System.IO.StreamReader(fic_serveur);
                string ligne = null;
                // on parcours les lignes jusqu'à la fin du fichier
                requete_download req_dn = new requete_download();
                while ((ligne = line.ReadLine()) != null)
                {
                    Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier
                    string requete_insrt = "INSERT INTO enlevement (id_enlev,id_util,exp,dest,code_colis,observ_enlev,photo_enleve,signature_enlev,date_enlev,status_enlev,general_desc,nb_package,util_exp,util_dest) VALUES ( " +
                        Tligne[0] + ", " + Tligne[1] + ", " + Tligne[2] + ", " + Tligne[3] + ",'" + Tligne[4].ToString() + "','" + Tligne[5].ToString() + "','" + Tligne[6].ToString() + "','" + Tligne[7].ToString() + "','" + Tligne[8].ToString() + "'," + Tligne[9] + ",'" + Tligne[10].ToString() + "'," + Tligne[11] + "," + Tligne[12] + "," + Tligne[13] + ");";

                    rep = req_dn.insert(requete_insrt, "enlevement");
                    
                }
                if (rep == -1)
                { 
                    MessageBox.Show("Echec insertion | TAB Enlevement !!");
                    req_dn.int_auto("enlevement", "id_enlev");
                
                }
                else 
                {
                    MessageBox.Show("Insertion réussite | TAB Enlevement !!");
                    req_dn.int_auto("enlevement", "id_enlev");
                }
            }
        }

        public void insert_pers()
        {
            int rep=-1 ;
            string[] Tligne = new string[100]; // tableau qui va contenir les sous-chaines extraites d'une ligne.
            char[] splitter = { ';' }; // délimiteur du fichier texte
            string fic_serveur = null; // chaine qui contient le nom du fichier csv à ouvrir
            fic_serveur = d_personne;
            int repo = 1;
            if (System.IO.File.Exists(fic_serveur))
            {
                // On vérifie si le fichier existe avant de l'ouvrir
                System.IO.StreamReader line = new System.IO.StreamReader(fic_serveur);
                string ligne = null;
                // on parcours les lignes jusqu'à la fin du fichier
                requete_download req_dn = new requete_download();
                while ((ligne = line.ReadLine()) != null)
                {
                    Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier
                    string requete_insrt = "INSERT INTO personne (id_pers,nom_pers,prnom_pers,societe_pers,tel_pers,adr_pers,mail_pers,wilaya_pers,comun_pers,status_pers,id_util,code_soc) VALUES ( " +
                        Tligne[0] + ", '" + Tligne[1].ToString() + "','" + Tligne[2].ToString() + "', '" + Tligne[3].ToString() + "','" + Tligne[4].ToString() + "','" + Tligne[5].ToString() + "','" + Tligne[6].ToString() + "','" + Tligne[7].ToString() + "','" + Tligne[8].ToString() + "'," + Tligne[9] + "," + Tligne[10] + ",'" + Tligne[11].ToString() + "');";

                    rep = req_dn.insert(requete_insrt, "personne");
                }
                if (rep == -1)
                { MessageBox.Show("Echec insertion | TAB Agence !!"); }
                else {
                    MessageBox.Show("Insertion réussite | TAB Agence!!");
                    int ct_pers = req_dn.int_auto("personne","id_pers");
                    
                }
                rep_tt = rep_tt * rep;
            }
        }
        public void insert_pers_type()
        {
            int rep = -1;
            string[] Tligne = new string[100]; // tableau qui va contenir les sous-chaines extraites d'une ligne.
            char[] splitter = { ';' }; // délimiteur du fichier texte
            string fic_serveur = null; // chaine qui contient le nom du fichier csv à ouvrir
            fic_serveur = d_pers_type;

            if (System.IO.File.Exists(fic_serveur))
            {
                // On vérifie si le fichier existe avant de l'ouvrir
                System.IO.StreamReader line = new System.IO.StreamReader(fic_serveur);
                string ligne = null;
                // on parcours les lignes jusqu'à la fin du fichier
                requete_download req_dn = new requete_download();
                while ((ligne = line.ReadLine()) != null)
                {
                    Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier
                    string requete_insrt = "INSERT INTO pers_type (id_pers_type,id_pers,id_type,date_pers_type,status_pers_type,id_util) VALUES ( " +
                        Tligne[0] + ", " + Tligne[1] + ", " + Tligne[2] + ", '" + Tligne[3].ToString() + "'," + Tligne[4] + "," + Tligne[5] + ");";

                    rep = req_dn.insert(requete_insrt, "pers_type");
                    
                }
                if (rep == -1)
                { MessageBox.Show("Echec insertion | TAB Type Agence !!"); }
                else 
                {

                    MessageBox.Show("Insertion réussite | TAB Type Agence !!");
                    
                    req_dn.int_auto("pers_type", "id_pers_type");
                }
                rep_tt = rep_tt * rep;
            }
        }
    }
}
