using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Data;
using TNT.Helper;
using TNT.login;


namespace TNT.con_req
{
    class Requete
    {
        public static string FileBase;
        private SqlCeConnection connexion;


        internal static int ExecuteUpdate(string requête)
        {
            // on gère les éventuelles exceptions
            try
            {
                connexion con = new connexion();
                // ouverture connexion
                SqlCeConnection conne = con.OpenConnection();
                // exécute sqlCommand avec requête de mise à jour
                
                SqlCeCommand sqlCommand = new SqlCeCommand(requête, conne);
               
                int nbLignes = sqlCommand.ExecuteNonQuery();
                
                return nbLignes;

            }
            catch (Exception ex)
            {
                WriteLogFile.write("Requete " + ex.Message + " ; 0 ; " + traitement_authentification.sync + " ; 0 ; " + traitement_authentification.sync);
                return -1;
            }
        } //ExecuteUppdate


        internal static int ExecuteSet(string requête,string table)
        {
            connexion con = new connexion();
            // ouverture connexion
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
                //log ex
                WriteLogFile.write("Requete "+ ex.Message + " ; 0 ; " + traitement_authentification.sync);
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
                connexion con = new connexion();
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
            catch (Exception ex)
            {
                WriteLogFile.write("Requete " + ex.Message + " ; 0 ; " + traitement_authentification.sync);
                return null;
            }
        }


    }
}


