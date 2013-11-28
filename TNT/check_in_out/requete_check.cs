using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using TNT.con_req;
using TNT.login;

namespace TNT.check_in_out
{
    class requete_check
    {

        public DataSet select_depot(string nom_depot)
        {
            try
            {
                DataSet dss = null;
                string requete = "SELECT id_depot,  nom_depot, adr_depot from depot   WHERE   (nom_depot='"+ nom_depot.ToString() +"')";
                dss = Requete.ExecuteSelect(requete);
                return dss;
            }
            catch
            {
                MessageBox.Show("erreur requete");
                return null;
            }
        }

        //*****************************************************************
        public int insrt_check_in()
        {
            int id_depot = int.Parse(traitement_check.id_depot.ToString());

            DateTime dt = DateTime.Now;
            string Format = "yyyy-MM-dd H:mm:ss";
            string dat = dt.ToString(Format);

            int check_in=-1;
            string requete = "insert into check_in (id_depot,date_check_in) values ("+id_depot+",'" + dat.ToString() + "')";
            int rep = Requete.ExecuteUpdate(requete);
            if (rep != -1)
            {
                DataSet ds = Requete.ExecuteSelect("select max(id_check_in) from check_in");
                check_in = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            return check_in;
        }

        public int insert_in(int check_in,string code_colis)
        {
            try
            {
                
                string req = "select id_enlev from enlevement where code_colis='";
                int id_enlev = rout_enlev(code_colis, req);


                string requete = "insert into cor_check_in (id_check_in, id_enlev) values (" + check_in + "," + id_enlev + ")";
                int rep = Requete.ExecuteUpdate(requete);
                return rep;
            }
            catch
            {
                MessageBox.Show("erreur requete");
                return -1;
            }
        }
        /*
 public int insert_in(string code_colis)
 {
     try
     {
         int id_depot = int.Parse(traitement_check.id_depot.ToString());

         DateTime dt = DateTime.Now;
         string Format = "yyyy-MM-dd H:mm:ss";
         string dat = dt.ToString(Format);

         string req = "select id_enlev from enlevement where code_colis='" ;
         int id_enlev = rout_enlev(code_colis,req);


         string requete = "insert into check_in (id_depot, id_enlev,date_check_in) values (" + id_depot + "," + id_enlev + ",'" + dat.ToString() + "')";
         int rep = Requete.ExecuteUpdate(requete);
         return rep;
     }
     catch
     {
         MessageBox.Show("erreur requete");
         return -1;
     }
 }
 */

        public int insert_out(string code_colis)
        {
            try
            {
                int id_util = int.Parse(traitement_authentification.id_util.ToString());

                DateTime dt = DateTime.Now;
                string Format = "yyyy-MM-dd H:mm:ss";
                string dat = dt.ToString(Format);

                string req = "select id_enlev from enlevement where code_colis='";
                int id_enlev = rout_enlev(code_colis,req);

                string requete = "insert into check_out (id_check_in, id_util, id_enlev, date_check_out) values (," + id_util + "," + id_enlev + ",'" + dat.ToString() + "')";
                int rep = Requete.ExecuteUpdate(requete);
                return rep;
            }
            catch
            {
                return -1;
            }
        }


        
        
        private int rout_enlev(string colis,string requete)
        {
            int id_enlev;
            DataSet ds;
          
            ds = Requete.ExecuteSelect(requete+colis.ToString()+"'");
            if (ds.Tables[0].Rows.Count != 0)
            {
                id_enlev = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                return id_enlev;
            }
            else { return -1; }
        }

    }
}
