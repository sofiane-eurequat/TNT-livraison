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

namespace TNT.con_req
{
    class backup_connexion
    {
        public static string Fil;
        public SqlCeConnection con;

        //recupérer la chaine de connexion
        public static void bddPath(string Database)
        {
            string ExePath = Assembly.GetExecutingAssembly().GetName().CodeBase;
            string startupPath = Path.GetDirectoryName(ExePath);
            Fil = Path.Combine(startupPath, Database);
            if (!File.Exists(Fil))
            {
                MessageBox.Show("erreur de connexion Backup");
            }
        }


        // etablire et ouvrir la connexion 
        public SqlCeConnection OpenConnection()
        {
            bddPath("backup_tnt.sdf");
            string cS = String.Format("DATA SOURCE = '{0}';", Fil);
            con = new SqlCeConnection();
            con.ConnectionString = cS;
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("erreur BDD Backup");
                con.Close();
                Application.Exit();
            }
            return con;
        }

    }
}
