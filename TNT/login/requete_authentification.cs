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
    class requete_authentification
    {
         
       public DataSet  Selection(string selec_log, string selec_wp)
        {
            try
            {
            DataSet dss = null;
            string requete = "SELECT id_util,  nom_util,grade_util from Utilisateur   WHERE   (log_util = '"+selec_log+"') AND (pw_util = '"+selec_wp+"')";
            dss =Requete.ExecuteSelect(requete);
            return dss;
            }
            catch
            {
                MessageBox.Show("erreur requete");
                return null;
            }
       }

        //*****************************************************************

       



    }
}

