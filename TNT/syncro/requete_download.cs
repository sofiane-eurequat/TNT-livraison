using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using TNT.con_req;
using System.Windows.Forms;
using System.Data;

namespace TNT.syncro
{
    class requete_download
    {
        public int delete_tab(string table)
        {
            int rep = -1;
            string req = "delete from " + table;
            rep = Requete.ExecuteUpdate(req);
            return rep;
        }

        public int insert_blok(string table, string fichier)
        {
            int rep = -1;
            string req = "BULK INSERT "+table+" FROM '"+fichier+"' WITH (   FIELDTERMINATOR = ';',  ROWTERMINATOR = '\n'  ) go";
            rep = Requete.ExecuteUpdate(req);
            
            return rep;
        }

        public int insert(string requete,string table)
        {
            int rep = -1;
            
            rep = Requete.ExecuteSet(requete,table);
            return rep;
        }

        public int int_auto (string table,string id)
        {
            try
            {
                int count=0;

                if (id == "id_enlev")
                {
                    string d_count = ConfigurationManager.GetChemin<string>("D_count");

                    
                    string[] Tligne = new string[100]; // tableau qui va contenir les sous-chaines extraites d'une ligne.
                    char[] splitter = { ';' }; // délimiteur du fichier texte
                    string fich_count = null; // chaine qui contient le nom du fichier csv à ouvrir
                    fich_count = d_count;

                    if (System.IO.File.Exists(fich_count))
                    {
                        // On vérifie si le fichier existe avant de l'ouvrir
                        System.IO.StreamReader line = new System.IO.StreamReader(fich_count);
                        string ligne = null;
                        // on parcours les lignes jusqu'à la fin du fichier
                        requete_download req_dn = new requete_download();
                        while ((ligne = line.ReadLine()) != null)
                        {
                            Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier
                            count = int.Parse(Tligne[0].ToString());
                        }
                    }


                }
                else
                {
                    DataSet dss = null;
                    string requete = "SELECT count(*) FROM " + table.ToString();
                    dss = Requete.ExecuteSelect(requete);
                    count = int.Parse(dss.Tables[0].Rows[0][0].ToString());
                  
                }
                count++;

                //MessageBox.Show("le id et de : " + count);

                int cpt = Requete.ExecuteUpdate("ALTER  TABLE "+table+" ALTER  COLUMN "+id+" IDENTITY  ( " + count + " , 1 )");
                return cpt;
            }
            catch
            {
                MessageBox.Show("erreur requete");
                return 0;
            }
        }

    }
}
