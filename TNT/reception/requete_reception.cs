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

namespace TNT.reception
{
    class requete_reception    
    {

        public int count_pers(string id, string table)
        {
            try
            {
                DataSet dss = null;
                int count;
                string requete = "SELECT max(" + id.ToString() + ") FROM " + table.ToString();
                dss = Requete.ExecuteSelect(requete);
                if (dss.Tables[0].Rows[0][0].ToString() != "")
                {
                    count = int.Parse(dss.Tables[0].Rows[0][0].ToString());
                }
                else
                {
                    count = 0;
                }
                return count;
            }
            catch
            {
                MessageBox.Show("erreur requete");
                return 0;
            }
        }


        public DataSet Select_dest(int id_pers,int id_util)
        {
            try
            {
                DataSet dss = null;
                string requete = "SELECT nom_pers,prnom_pers,societe_pers from personne   WHERE   (id_pers = " + id_pers + ") and (id_util="+id_util+")";
                dss = Requete.ExecuteSelect(requete);
                return dss;
            }
            catch
            {
                MessageBox.Show("erreur requete");
                return null;
            }
        }

        public DataSet retour_id_pers(string colis)
        {
            int id_pers;
            DataSet ds;
            ds = Requete.ExecuteSelect("SELECT personne.id_pers,personne.id_util,enlevement.id_enlev FROM enlevement INNER JOIN pers_type ON enlevement.dest = pers_type.id_pers_type and enlevement.util_dest=pers_type.id_util AND enlevement.code_colis = '" + colis.ToString() + "' INNER JOIN personne ON pers_type.id_pers = personne.id_pers and pers_type.id_util = personne.id_util");
            if (ds.Tables[0].Rows.Count != 0)
            {
                //id_pers = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                return ds;
            }
            else 
            {
                return null;
            }
        }

        public int retour_id(string requete)
        {
            int id_enlev;
            DataSet ds;


            ds = Requete.ExecuteSelect(requete);
            if (ds.Tables[0].Rows.Count != 0)
            {
                id_enlev = int.Parse(ds.Tables[0].Rows[0][0].ToString());
              
                return id_enlev;
            }
            else
            {
                return 0;
            }
        }

        public DataSet cher_recept(int id_enlev,int id_util)
        {
            DataSet ds;
            ds = Requete.ExecuteSelect("SELECT id_recept FROM reception WHERE id_enlev='"+id_enlev+"' and id_util_enlev="+id_util);
            return ds;
        }

        public int insert_recept(int id_enlev, int id_util, int id_util_enlev,string signature,string commentaire,string scanne)
        {

            try
            {

                DateTime dt = DateTime.Now;
                string Format = "yyyy-MM-dd H:mm:ss";
                string dat = dt.ToString(Format);


                string requete = "insert into reception (id_enlev,date_recept,id_util,id_util_enlev,obser_recept,signature_recept,code_colis) values (" + id_enlev + ",'" + dat.ToString() + "'," + id_util + ","+id_util_enlev+",'"+commentaire+"','"+signature+"','"+scanne+"')";
                int rep = Requete.ExecuteUpdate(requete);


                string requeteIdRecept = "Select id_recept from reception where id_enlev=" + id_enlev + ",date_recept=" + dat.ToString() + "id_util=" + id_util + "id_util_enlev=" + id_util_enlev;
                return rep;
                var ds=Requete.ExecuteSelect(requeteIdRecept);
               

                /*

                if (check_out == -1)
                {

                    string requete = "insert into reception (id_enlev,date_recept,id_util) values (" + id_enlev + ",'" + dat.ToString() + "',"+id_util+")";
                    int rep = Requete.ExecuteUpdate(requete);
                    return rep;
                }

                else
                {
                    string requete = "insert into reception (id_check_out,date_recept) values (" + check_out + ",'" + dat.ToString() + "')";
                    int rep = Requete.ExecuteUpdate(requete);
                    return rep;

                }*/
            }
            catch 
            {
                MessageBox.Show("erreur requete");
                //WriteLogFile.write("Reception" + " ; 1 ; " + traitement_authentification.sync + ";" );
                return -1;
            }
        }

        public DataSet select_tab(string table)
        {
            string req = "select * from " + table;
            DataSet ds = Requete.ExecuteSelect(req);
            return ds;
        }
    }
}
