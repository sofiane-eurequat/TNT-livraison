using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TNT.con_req;
using System.Windows.Forms;

namespace TNT.syncro
{
    class requete_upload
    {
        public DataSet select_tab(string table)
        {
            try
            {
                string req = "select * from " + table;
                DataSet ds = Requete.ExecuteSelect(req);
                return ds;
            }
            catch 
            {
                MessageBox.Show("DataSet vide");
                return null;

            }
        }



        public int backup_insert(string requete)
        {


            
            int rep = -1;
            
            rep = backup_requete.ExecuteUpdate(requete);
            return rep;
             
            /*            int rep = -1;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                if(tab == "enlevement")
                {

                    string requete = "INSERT INTO enlevement (id_enlev,id_util,exp,dest,code_colis,observ_enlev,photo_enleve,signature_enlev,date_enlev,status_enlev,general_desc,nb_package,util_exp,util_dest) VALUES ( " +
                        dr[0] + ", " + dr[1] + ", " + dr[2] + ", " + dr[3] + ",'" + dr[4].ToString() + "','" + dr[5].ToString() + "','" + dr[6].ToString() + "','" + dr[7].ToString() + "','" + dr[8].ToString() + "'," + dr[9] + ",'" + dr[10].ToString() + "'," + dr[11] + "," + dr[12] + "," + dr[13] + ");";

                    rep = rep+backup_requete.ExecuteUpdate(requete);
                    //rep = backup_requete.ExecuteSet(requete,"enlevement");
                }

                if (tab == "reception")
                {

                    string requete = "INSERT INTO reception (id_recept,id_enlev,id_check_out,date_recept,obser_recept,photo_recept,signature_recept,status_recept,id_util,id_util_enlev,code_colis) VALUES ( " +
                    dr[0] + ", " + dr[1] + ", " + dr[2] + ", '" + dr[3].ToString() + "','" + dr[4].ToString() + "','" + dr[5].ToString() + "','" + dr[6].ToString() + "'," + dr[7] + "," + dr[8] + "," + dr[9] + ",'" + dr[10] + "');";

                    rep = rep + backup_requete.ExecuteUpdate(requete);
                }
            }

            return rep;*/
        }
        public int backup_insert_ds(string requete)
        {



            int rep = 0;

            rep = backup_requete.ExecuteUpdate(requete);
            return rep;
        }


    }
}
