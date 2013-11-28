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

namespace TNT.login
{
    class requete_enlevement
    {

        public DataSet Select_rech_pers(string rech)
        {
            try
            {
                DataSet dss = null;
                string requete = "SELECT        id_pers, id_util, nom_pers, prnom_pers, societe_pers, tel_pers, mail_pers, adr_pers, wilaya_pers, comun_pers, status_pers,code_soc FROM            personne WHERE        (code_soc = '"+rech.ToString()+"')";
                dss = Requete.ExecuteSelect(requete);
                return dss;
            }
            catch
            {
                MessageBox.Show("erreur requete");
                return null;
            }
        }

        public DataSet Select_rech_pers_nom(string rech)
        {
            try
            {
                DataSet dss = null;
                string requete = "SELECT        id_pers, id_util, nom_pers, prnom_pers, societe_pers, tel_pers, mail_pers, adr_pers, wilaya_pers, comun_pers, status_pers,code_soc FROM            personne WHERE        (societe_pers = '" + rech.ToString() + "')";
                dss = Requete.ExecuteSelect(requete);
                return dss;
            }
            catch
            {
                MessageBox.Show("erreur requete");
                return null;
            }
        }

        public DataSet Select_rech_type_pers(int id_pers,int util_pers, int id_type)
        {
            try
            {
                DataSet dss = null;
                string requete = "SELECT id_pers_type,id_util,id_pers, id_type,date_pers_type FROM pers_type WHERE        (id_pers = " + id_pers + " and id_type="+ id_type +" and id_util="+util_pers+")";
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

        public int insert_pers(string nom_pers,string prenom_pers,string societe_pers,string code_soc,int id_util)
        {
            try
            {
                
                string requete = "insert into personne (nom_pers,prnom_pers,societe_pers,id_util,code_soc) values ('"+nom_pers.ToString()+"','"+prenom_pers.ToString()+"','"+societe_pers.ToString()+"',"+id_util+",'"+code_soc.ToString()+"')";
                int rep = Requete.ExecuteUpdate(requete);
                return rep;
            }
            catch
            {
                MessageBox.Show("erreur requete");
                return -1;
            }
        }

        public int insert_type_pers(int id_pers,int id_type,int util)
        {
            try
            {   
                DateTime dt = DateTime.Now;
                string Format= "yyyy-MM-dd H:mm:ss";
                string dat = dt.ToString(Format);

                //MessageBox.Show(DateTime.Now());
                string requete = "insert into pers_type (id_pers,id_type,date_pers_type,id_util) values (" + id_pers + "," + id_type + ",'" + dat.ToString() + "',"+util+")";
                int rep = Requete.ExecuteUpdate(requete);
                return rep;
            }
            catch
            {
                MessageBox.Show("Erreur requete");
                return -1;
            }
        }
                
        public int count_pers(string id,string table)
        {
            try
            {
                DataSet dss = null;
                int count;
                string requete = "SELECT max("+id.ToString()+") FROM "+table.ToString();
                dss = Requete.ExecuteSelect(requete);
                if (dss.Tables[0].Rows[0][0].ToString()!= "")
                {
                    count =int.Parse(dss.Tables[0].Rows[0][0].ToString());
                }
                else
                {
                    count = 0;
                }
                return count ;
            }
            catch
            {
                MessageBox.Show("erreur requete");
                return 0;
            }
        }

        public int verifier_pers(string nom, string prnom, string societe, string type_pers)
        {
            int retour;
            DataSet ds = null;
            DataSet ds_res = null;
            string requete = "Select id_pers from personne where nom_pers ='" + nom + "' and prnom_pers='" + prnom + "' and societe_pers='" + societe + "'";
            ds = Requete.ExecuteSelect(requete);
            if (ds.Tables[0].Rows.Count == 0)
            {
                retour = -1;
                return retour;
            }else
            {
                int id_type;
                if(type_pers=="Destinataire")
                {
                    id_type = 2;
                }
                else
                {
                    id_type = 1;
                }
                int id_pers=int.Parse(ds.Tables[0].Rows[0][0].ToString());
                string req = "select id_pers_type from pers_type where id_pers=" + id_pers+" and id_type="+id_type;
                ds_res = Requete.ExecuteSelect(req);
                if (ds_res.Tables[0].Rows.Count == 0)
                {
                    // personne existe mais 
                    return id_pers;
                }
                else 
                {
                    int id_type_pers = int.Parse(ds_res.Tables[0].Rows[0][0].ToString());

                    return -2;
                }
            }
        }

        public DataSet verfier_scanne(string scanne)
        {
            DataSet ds = null;
            string req ="select * from enlevement where code_colis='"+scanne+"'";
            ds = Requete.ExecuteSelect(req);
            return ds;
        }

        public DataSet select_tab(string table)
        {
            string req = "select * from " + table;
            DataSet ds = Requete.ExecuteSelect(req);
            return ds;
        }
    }
}

