using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ComponentPro.Net;
using System.Data;
using System.IO;
using System.Windows.Forms;
using TNT.Helper;
using TNT.login;

namespace TNT.syncro
{
    class traitement_upload
    {
        
        string u_personne       = ConfigurationManager.GetChemin<string>("U_personne");
        string u_enlevement     = ConfigurationManager.GetChemin<string>("U_enlevement");
        string u_pers_type      = ConfigurationManager.GetChemin<string>("U_pers_type");
        string u_utilisateur    = ConfigurationManager.GetChemin<string>("U_utilisateur");
        string u_reception      = ConfigurationManager.GetChemin<string>("U_reception");

        string repertoire   = ConfigurationManager.GetChemin<string>("repertoire");


        string u_serv_personne = ConfigurationManager.GetChemin<string>("repertoire") + ConfigurationManager.GetChemin<string>("U_serv_personne");
        string u_serv_enlevement = ConfigurationManager.GetChemin<string>("repertoire") + ConfigurationManager.GetChemin<string>("U_serv_enlevement");
        string u_serv_enlevement_def = ConfigurationManager.GetChemin<string>("repertoire") + ConfigurationManager.GetChemin<string>("U_serv_enlevement_def");
        
        string u_serv_pers_type = ConfigurationManager.GetChemin<string>("repertoire")+ConfigurationManager.GetChemin<string>("U_serv_pers_type");
        string u_serv_utilisateur =ConfigurationManager.GetChemin<string>("repertoire")+ ConfigurationManager.GetChemin<string>("U_serv_utilisateur");
        string u_serv_reception =ConfigurationManager.GetChemin<string>("repertoire")+ ConfigurationManager.GetChemin<string>("U_serv_reception");
        string u_serv_reception_def = ConfigurationManager.GetChemin<string>("repertoire") + ConfigurationManager.GetChemin<string>("U_serv_reception_def");
        


        string server = ConfigurationManager.GetChemin<string>("server");
        string user = ConfigurationManager.GetChemin<string>("user");
        string pw = ConfigurationManager.GetChemin<string>("pw");



        public int copy_signature(string sourcePath,string targetPath)
        {
            try
            {
                string fileName = "";
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);

                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }

                if (System.IO.Directory.Exists(sourcePath))
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);

                    foreach (string s in files)
                    {
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(targetPath, fileName);
                        System.IO.File.Copy(s, destFile, true);
                        System.IO.File.Delete(s);
                    }
                }
                return 1;
            }
            catch (FtpException ex)
            {
                
                MessageBox.Show("Problème de connexion! la copy non effectue!");
                return -1;
            }
        
        }


        public void backup_recept()
        {
            int rep = 0;
            requete_upload rq = new requete_upload();
            DataSet ds_recept = rq.select_tab("reception");

            foreach (DataRow dr in ds_recept.Tables[0].Rows)
            {
                String format = "yyyy-MM-dd hh:mm:ss";
                DateTime dt = DateTime.Parse(dr[3].ToString());
                string dat = dt.ToString(format);
                string requete = "INSERT INTO reception (id_recept,id_enlev,date_recept,obser_recept,photo_recept,signature_recept,status_recept,id_util,id_util_enlev,code_colis) VALUES ( " +
                     dr[0] + ", " + dr[1] + ", '" +dat + "','" + dr[4].ToString() + "','" + dr[5].ToString() + "','" + dr[6].ToString() + "'," + dr[7] + "," + dr[8] + "," + dr[9] + ",'" + dr[10] + "');";

                rep = rep + rq.backup_insert_ds(requete);
            }
            if (rep == 0)
            {
                MessageBox.Show("Echec insertion Backup | TAB Reception !!");
            }
            else
            {
                MessageBox.Show("Insertion réussite Backup | TAB Reception !! Nombre de ligne: "+rep);
            }
        }

        
        public void backup_enlev()
        {
            int rep = 0;
            requete_upload rq = new requete_upload();
            DataSet ds_enlev = rq.select_tab("enlevement");

            foreach (DataRow dr in ds_enlev.Tables[0].Rows)
            {
                string requete = "INSERT INTO enlevement (id_enlev,exp,dest,code_colis,observ_enlev,photo_enleve,signature_enlev,date_enlev,status_enlev,id_util,general_desc,nb_package,util_exp,util_dest) VALUES ( " +
                       dr[0] + ", " + dr[1] + ", " + dr[2] + ", '" + dr[3].ToString() + "','" + dr[4].ToString() + "','" + dr[5].ToString() + "','" + dr[6].ToString() + "','" + dr[7].ToString() + "'," + dr[8] + "," + dr[9] + ",'" + dr[10].ToString() + "'," + dr[11] + "," + dr[12] + "," + dr[13] + ");";
                rep=rep+rq.backup_insert_ds(requete);
            }
            if(rep ==0)
            {
                MessageBox.Show("Echec insertion Backup | TAB Enlevement !! ");
            }
            else{
                MessageBox.Show("Insertion réussite Backup | TAB Enlevement !!"+rep);
            }
        }

        public int upload()
        {
            try
            {
                
                Ftp client = new Ftp();

                FtpExceptionStatus ex = new FtpExceptionStatus();
               

                client.Connect(server);
                client.Authenticate(user, pw);
                
                if (!client.DirectoryExists(repertoire))
                {
                    client.CreateDirectory(repertoire);
                }
                /*
                if (!client.DirectoryExists(repertoire+"signature/enlevement"))
                {
                    client.CreateDirectory(repertoire + "signature/enlevement");
                }
                
                if (!client.DirectoryExists(repertoire+"signature/reception"))
                {
                    client.CreateDirectory(repertoire + "signature/reception");
                }

                if (!Directory.Exists("My Documents\\signature\\enlevement"))
                {
                    Directory.CreateDirectory("My Documents\\signature\\enlevement");
                }

                if (!Directory.Exists("My Documents\\signature\\reception"))
                {
                    Directory.CreateDirectory("My Documents\\signature\\reception");
                }
                

                client.UploadFiles("My Documents\\signature\\enlevement", repertoire + "signature/enlevement");
                client.UploadFiles("My Documents\\signature\\reception", repertoire + "signature/reception");
                */

                int counter = 0;
                string line;

                client.UploadFile(u_reception, u_serv_reception);
                client.Rename(u_serv_reception, u_serv_reception_def);
                WriteLogFile.write("#######################################################  Reception ################################");
                System.IO.StreamReader file = new System.IO.StreamReader(u_reception);
                while (( line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    WriteLogFile.write(line);
                    counter++;
                }
                WriteLogFile.write("nombre de lignes "+counter.ToString());
                WriteLogFile.write("#######################################################  Reception ################################");
                

                client.UploadFile(u_enlevement, u_serv_enlevement);
                client.Rename(u_serv_enlevement, u_serv_enlevement_def);
                
                counter = 0;
                WriteLogFile.write("#######################################################  ENLEVEMENT ################################");
                file = new System.IO.StreamReader(u_enlevement);
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    WriteLogFile.write(line);
                    counter++;
                }
                WriteLogFile.write("nombre de lignes "+counter.ToString());
                WriteLogFile.write("#######################################################  ENLEVEMENT ################################");       
                
                /*client.UploadFile(u_personne, u_serv_personne);

                client.UploadFile(u_pers_type, u_serv_pers_type);
                
                client.UploadFile(u_utilisateur,u_serv_utilisateur);*/
                
                

                client.Disconnect();
                WriteLogFile.write("Sync PDA=>PC ; 1 ; " + traitement_authentification.sync);
                var sync = traitement_authentification.sync;
                /*if (sync == 2)
                {
                    traitement_authentification.sync = 2;
                }*/
                /*else*/ { traitement_authentification.sync = EtatSynch.PdaVersPc; }
                MessageBox.Show("Synchronisation PDA -> PC effetue avec succé !");
                //TODO : prbleme => si le traitement_authentification.sync=2 il ne sera jamais remis a 1
                //TODO: solution preconisé est d'ajouter un etat 3 qui representerai le fait que la sync pda=> pc peut se faire et que pc => pda est bloqué
                return 1;                
            }
            catch (Exception ex)
            {
                if (ex is FtpException)
                {
                    MessageBox.Show( ex.Message);
                }
                
                MessageBox.Show("Problème de connexion! synchronisation non effectue!");
                traitement_authentification.sync = EtatSynch.PcVersPda;
                WriteLogFile.write("Sync PDA=>PC ; 0 ; " + traitement_authentification.sync);
                return -1;
            }
        }


        public void exporte_fichier()
        {

            requete_upload req = new requete_upload();
            DataSet ds_enlev = req.select_tab("enlevement");
            StreamWriter sw_enlev = new StreamWriter(u_enlevement);//création du fichier 

            foreach (DataRow dr in ds_enlev.Tables[0].Rows)
            {
                string sp = ";";
                string text = dr[0].ToString() + sp + dr[1].ToString() + sp + dr[2].ToString() + sp + dr[3].ToString() + sp + dr[4].ToString() + sp + dr[5].ToString() + sp + dr[6].ToString() + sp + dr[7].ToString() + sp + dr[8].ToString() + sp + dr[9].ToString() + sp + dr[10].ToString() + sp + dr[11].ToString() + sp + dr[12].ToString() + sp + dr[13].ToString() + "\n";
                //text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                sw_enlev.Write(text);//enregistrement du message dans le fichier 
            }
            sw_enlev.Close();

            // exporte personne 
            DataSet ds_pers = req.select_tab("personne");
            StreamWriter sw_pers = new StreamWriter(u_personne);//création du fichier 

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
            StreamWriter sw_type_pers = new StreamWriter(u_pers_type);//création du fichier 

            foreach (DataRow dr in ds_pers_type.Tables[0].Rows)
            {
                string sp = ";";
                string text = dr[0].ToString() + sp + dr[1].ToString() + sp + dr[2].ToString() + sp + dr[3].ToString() + sp + dr[4].ToString() + sp + dr[5].ToString() + "\n";
                //text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                sw_type_pers.Write(text);//enregistrement du message dans le fichier 
            }
            sw_type_pers.Close();

            // export utilisateur
            DataSet ds_util = req.select_tab("utilisateur");
            StreamWriter sw_util = new StreamWriter(u_utilisateur);//création du fichier 

            foreach (DataRow dr in ds_util.Tables[0].Rows)
            {
                string sp = ";";
                string text = dr[0].ToString() + sp + dr[1].ToString() + sp + dr[2].ToString() + sp + dr[3].ToString() + sp + dr[4].ToString() + sp + dr[5].ToString() + sp + dr[6].ToString() + sp + dr[7].ToString() + sp + dr[8].ToString() + sp + dr[9].ToString() + "\n";
                //text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                sw_util.Write(text);//enregistrement du message dans le fichier 
            }
            sw_util.Close();



            DataSet ds_recept = req.select_tab("reception");
            StreamWriter sw_recept = new StreamWriter(u_reception);//création du fichier 
            
            foreach (DataRow dr in ds_recept.Tables[0].Rows)
            {
                string sp = ";";
                string text = dr[0].ToString() + sp + dr[1].ToString() + sp + dr[2].ToString() + sp + dr[3].ToString() + sp + dr[4].ToString() + sp + dr[5].ToString() + sp + dr[6].ToString() + sp + dr[7].ToString() + sp + dr[8].ToString() + sp + dr[10].ToString() + sp + dr[9].ToString() + "\n";
                //text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                sw_recept.Write(text);//enregistrement du message dans le fichier 
            }
            sw_recept.Close();
        }

    }
}
