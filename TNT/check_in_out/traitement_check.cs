using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace TNT.check_in_out
{
    class traitement_check
    {
        public DataSet ds;
        public static int id_depot;

        public DataSet  rech_depot(string nom)
        {
            requete_check req = new requete_check();
            ds = req.select_depot(nom);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Le depôt n'existe pas !!! vèrifier le nom ");
                return null;
            }
            else 
            {
                id_depot = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                return ds;
            }
        }
        public int eng_in()
        {
            requete_check req_check = new requete_check();
            int check_in= req_check.insrt_check_in();
            return check_in;
        
        }

        public void eng_scane(int check_in,string scanne)
        {
            requete_check req_check = new requete_check();
            int repense;
            if (menu_in_out.check.ToString() == "in")
            {
                repense = req_check.insert_in(check_in,scanne);
            }
            else 
            {
                repense = req_check.insert_out(scanne);                
            }
            if (repense == -1)
            {
                MessageBox.Show("Echec d'insertion");
            }
            else 
            {
                MessageBox.Show("Insertion réussite");
            }
        }

    }
}
