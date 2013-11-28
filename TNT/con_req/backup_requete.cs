using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Data;



namespace TNT.con_req
{
    class backup_requete
    {
        public static string Fil;
        private SqlCeConnection backup_connexion;


        internal static int ExecuteUpdate(string requête)
        {
            backup_connexion con = new backup_connexion();
            SqlCeConnection conne = con.OpenConnection();
            try
            {
                SqlCeCommand sqlCommand = new SqlCeCommand(requête, conne);
               
                int nbLignes = sqlCommand.ExecuteNonQuery();
                
                return nbLignes;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                conne.Close();
            }
        } //ExecuteUppdate


        internal static int ExecuteSet(string requête,string table)
        {
            backup_connexion con = new backup_connexion();
            SqlCeConnection connection = con.OpenConnection();
            
            SqlCeCommand identChange = connection.CreateCommand();
            identChange.CommandText = "SET IDENTITY_INSERT "+table+" ON";
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandText = requête;
            SqlCeCommand ident = connection.CreateCommand();
            ident.CommandText = "SET IDENTITY_INSERT "+table+" OFF";
          
            try
            {
               // connection.Open();
                identChange.ExecuteNonQuery();
                int repense =cmd.ExecuteNonQuery();
                ident.ExecuteNonQuery();
                return repense;
            }

            catch (SqlCeException ex)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        } //ExecuteUppdate

        
        // exécution d'une requête Select
        internal static DataSet ExecuteSelect(string requête)
        {
            try
            {
                backup_connexion con = new backup_connexion();
                SqlCeConnection connexion = con.OpenConnection();

                using (connexion)
                {
                    SqlCeCommand cmd = connexion.CreateCommand();
                    cmd.CommandText = requête;
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    return ds;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}

