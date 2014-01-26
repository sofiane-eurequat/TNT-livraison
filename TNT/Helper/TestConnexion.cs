using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;
using ComponentPro.IO;
using ComponentPro.Net;

namespace TNT.Helper
{
    public static class TestConnexion
    {
        public static Boolean Test(Boolean verbose)
        {
            
       
            var url = "http://www.google.com";
            Uri myUri = new Uri(url);
            // Create a 'HttpWebRequest' object for the specified url. 
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create(myUri);
            myHttpWebRequest.AllowAutoRedirect = true;
            // Send the request and wait for response.
            var connected = false;
            HttpWebResponse myHttpWebResponse = null;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse())
                {
                    if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                    {
                        connected = true;
                        if (verbose) MessageBox.Show("Connexion internet ok");
                        Ftp client = new Ftp();
                        try
                        {

                            // Connect to the FTP server.
                            var adresseServeur=ConfigurationManager.GetChemin<String>("server");
                            var user = ConfigurationManager.GetChemin<String>("user");
                            var pass = ConfigurationManager.GetChemin<String>("pw");
                            client.Connect(adresseServeur);

                            // Authenticate.
                            client.Authenticate(user, pass);
                            // Do something here. You can browse directories, list files, transfer files
                            // ...
                            // Disconnect.
                            Cursor.Current = Cursors.Default;
                            if (verbose) MessageBox.Show("Serveur Disponible");


                            /*
                            foreach (FtpFileInfo info in client.ListDirectory("/www/tnt web/bdd/upload/bdd1/"))
                            {
                                MessageBox.Show("Name: "+info.FullName+", UserId: "+info.FilePermissionsEnum+", Permissions: "+ info.FilePermissions);
                            }
                            */


                            client.Disconnect();
                            return true;
                        }
                        catch (FtpException exc)
                        {
                            Cursor.Current = Cursors.Default;
                            if (client.State == RemoteFileSystemState.Connected ||
                                client.State == RemoteFileSystemState.Idle)
                            {
                                client.Disconnect();
                            }
                            MessageBox.Show("Probleme Serveur");
                            return false;
                        }

                    }
                    MessageBox.Show("Probleme internet");
                    return false;
                }
            }
            catch (WebException ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Probleme internet");
                return false;

            }
        }
    }
}
