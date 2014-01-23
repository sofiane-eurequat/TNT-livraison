using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using TNT.Helper;

namespace TNT.login
{
   
    class traitement_authentification 
    {
        // requete_authentification req; 
         public DataSet ds ;
         public static string id_util ;
         public static string grade_util ;
         public static EtatSynch sync = EtatSynch.initial;
         
        public   void   Traitement(string tr_log, string tr_wp)
        {
          
          
                requete_authentification req = new requete_authentification();
                ds = req.Selection(tr_log, tr_wp);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Erreur login");
                }
                else
                {
                    id_util = ds.Tables[0].Rows[0][0].ToString();
                    grade_util = ds.Tables[0].Rows[0][2].ToString(); 
                    (new Menu()).Show();
                   
                }

          }
       
        
    }
}
