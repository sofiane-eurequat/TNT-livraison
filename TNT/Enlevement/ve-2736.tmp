using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNT.login;
using TNT.con_req;
using ComponentPro.Net;


namespace TNT.Enlevement
{
    public partial class scanne_fils : Form
    {
        private AP scanAPI = null;
        private EventHandler myReadNotifyHandler = null;
        public string code_pere;
                
        public scanne_fils()
        {
            InitializeComponent();
        }

        private void scanne_fils_Load(object sender, EventArgs e)
        {

            scanAPI = new AP();
            scanAPI.InitReader();
            scanAPI.StartRead(false);
            this.myReadNotifyHandler = new EventHandler(myReader_ReadNotify);
            scanAPI.AttachReadNotify(myReadNotifyHandler);
            List<String> states = new List<String>();
            this.articleBox.Focus();

        }

        public void appendInventoryData()
        {

                int exp = int.Parse(traitement_enlevement.expediteur.ToString());
                int dest = int.Parse(traitement_enlevement.destinataire.ToString());
                int util = int.Parse(traitement_authentification.id_util.ToString());
                string requete = "insert into enlevement (exp,dest,id_util,code_colis,code_colis_fis) values (" + exp + "," + dest + "," + util + ",'"+ code_pere +"','" + this.scannedData.Text.ToString() + "')";
                int rep = Requete.ExecuteUpdate(requete);
                if (rep == 1)
                {
                    MessageBox.Show("L'insertion est réussite");
                }
                else
                {
                    MessageBox.Show("Echec d'insertion");
                }
        }


        private void initAll()
        {
            this.articleBox.Text = "";
            this.articleBox.Text = "";
            this.articleBox.Focus();
        }

        private void myReader_ReadNotify(object Sender, EventArgs e)
        {
            // Get ReaderData
            Symbol.Barcode.ReaderData TheReaderData = scanAPI.Reader.GetNextReaderData();

            switch (TheReaderData.Result)
            {
                case Symbol.Results.SUCCESS:

                    // Handle the data from this read & submit the next read.

                    this.scannedData.Text = TheReaderData.Text;
                    scanAPI.StartRead(false);
                    //this.stateBox.Focus();
                    break;

                case Symbol.Results.E_SCN_READTIMEOUT:


                    scanAPI.StartRead(false);
                    break;

                case Symbol.Results.CANCELED:

                    break;

                case Symbol.Results.E_SCN_DEVICEFAILURE:

                    scanAPI.StopRead();
                    scanAPI.StartRead(false);
                    break;

                default:

                    string sMsg = "Read Failed\n"
                        + "Result = "
                        + (TheReaderData.Result).ToString();

                    if (TheReaderData.Result == Symbol.Results.E_SCN_READINCOMPATIBLE)
                    {
                        // If the failure is E_SCN_READINCOMPATIBLE, exit the application.
                        MessageBox.Show("AppExitMsg", "Failure");

                        this.Close();
                        return;
                    }

                    break;
            }
        }




        public void upload()
        {
            try
            {

                // Create a new instance.
                Ftp client = new Ftp();
                // Connect to the FTP server.
                client.Connect("www.eurequat-algerie.com");
                // Or you can specify the FTP port with
                // client.Connect("myserver", 21);
                // Authenticate.
                client.Authenticate("eurequat", "Dely@2006");
                // Do something here...
                client.UploadFile("My Documents\\tnt\\enlevement.csv", "/www/tnt/bdd/personne.csv");
                client.UploadFile("My Documents\\tnt\\personne.csv", "/www/tnt/bdd/pers_type.csv");
                client.UploadFile("My Documents\\tnt\\pers_type.csv", "/www/tnt/bdd/envoyer.csv");
                // Disconnect.
                client.Disconnect();
                MessageBox.Show("Enlevement effectue avec synchronisation!");

            }
            catch (FtpException e)
            {

                MessageBox.Show("Problème de connexion! synchronisation non effectue!");
            }
        }


        private void pBQuitter_Click(object sender, EventArgs e)
        {
            scanAPI.StopRead();
            this.Close();
            TNT.Menu mn = new Menu();
            mn.Show();
        }

        private void pBUpdate_Click(object sender, EventArgs e)
        {

            appendInventoryData();
            traitement_enlevement tr_enlev = new traitement_enlevement();
            tr_enlev.exporte_fichier();
            upload();
            initAll();
            this.articleBox.Focus();
        }

        private void pBHome_Click(object sender, EventArgs e)
        {
            scanAPI.StopRead();
            this.Close();
        }

        

    }
}