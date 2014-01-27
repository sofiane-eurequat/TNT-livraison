using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.IO;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Windows.Forms;
using TNT.Helper;
using TNT.login;

namespace TNT.con_req
{
    class connexion
    {
        public static string FileBase;
        public SqlCeConnection conne;

        //recupérer la chaine de connexion
        public static void DataBasePath(string Database)
        {
            string ExePath = Assembly.GetExecutingAssembly().GetName().CodeBase;
            string startupPath = Path.GetDirectoryName(ExePath);
            FileBase = Path.Combine(startupPath, Database);
            if (!File.Exists(FileBase))
            {
                MessageBox.Show("erreur de connexion");
            }
        }


        // etablire et ouvrir la connexion 
        public SqlCeConnection OpenConnection()
        {
            DataBasePath("bdd_tnt.sdf");
            string cS = String.Format("DATA SOURCE = '{0}';", FileBase);
            conne = new SqlCeConnection();
            conne.ConnectionString = cS;
            try
            {
                conne.Open();
            }
            catch (Exception ex)
            {
                WriteLogFile.write("Connexion " + ex.Message + " ; 0 ; " + traitement_authentification.sync);
                MessageBox.Show("erreur BDD");
                Application.Exit();
            }
            return conne;
        }


    }
}
