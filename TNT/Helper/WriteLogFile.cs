using System;
using System.IO;
using System.Windows.Forms;
using TNT.login;

namespace TNT.Helper
{
    public static class WriteLogFile
    {
        public static Boolean write(string message)
        {
            Cursor.Current = Cursors.Default;
            var fileName = ConfigurationManager.GetChemin<String>("Log");

            FileStream FichierLog = null;
            if (!File.Exists(fileName))
            {
                FichierLog = File.Create(fileName);
                FichierLog.Close();
            }

            var InfoLog = new StreamWriter(fileName,true);
            try
            {

                InfoLog.WriteLine(DateTime.Now + " ; " + traitement_authentification.id_util + " ; " + message);
                InfoLog.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}