using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol;
using TNT.Enlevement;
using System.IO;
using ComponentPro.Net;



namespace TNT.reception
{
    public partial class recpt : Form
    {
        private AP API_scanne = null;
        private List<struc_recept> liste = new List<struc_recept>();
        private EventHandler myReadNotifyHandler = null;
        public string code = "";
        public string type_clt = "";
        public string personne = "";
        public string id_env = "";
        public String m_user = "";
        public string scan = "";

        public String User
        {
            get { return m_user; }
            set { m_user = value; }
        }



        public recpt()
        {
            InitializeComponent();
        }


        public void charger_dest(object sender, EventArgs e)
        {
            if (this.scanneData.Text != "")
            {
                code = this.scanneData.Text;

                //inventoryData.type_read = "S";
                traitement_reception tr_recp = new traitement_reception();
                DataSet ds = tr_recp.rech_dest(code);
                lab_nom.Text = ds.Tables[0].Rows[0][0].ToString();
                lab_prenom.Text = ds.Tables[0].Rows[0][1].ToString();
                lab_societe.Text = ds.Tables[0].Rows[0][2].ToString();

            }
            API_scanne.StopRead();
        }


        private void myReader_ReadNotify(object Sender, EventArgs e)
        {
            // Get ReaderData
            Symbol.Barcode.ReaderData TheReaderData = API_scanne.Reader.GetNextReaderData();

            switch (TheReaderData.Result)
            {
                case Symbol.Results.SUCCESS:

                    // Handle the data from this read & submit the next read.

                    this.scanneData.Text = TheReaderData.Text;
                    API_scanne.StartRead(false);
                    //this.stateBox.Focus();
                    break;

                case Symbol.Results.E_SCN_READTIMEOUT:


                    API_scanne.StartRead(false);
                    break;

                case Symbol.Results.CANCELED:

                    break;

                case Symbol.Results.E_SCN_DEVICEFAILURE:

                    API_scanne.StopRead();
                    API_scanne.StartRead(false);
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



        private void recpt_Load(object sender, EventArgs e)
        {
            API_scanne = new AP();
            API_scanne.InitReader();
            API_scanne.StartRead(false);
            this.myReadNotifyHandler = new EventHandler(myReader_ReadNotify);
            API_scanne.AttachReadNotify(myReadNotifyHandler);
            List<String> states = new List<String>();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pBHome_Click(object sender, EventArgs e)
        {
            API_scanne.StopRead();
            this.Close();
            (new Menu()).Show();
        }

        private void pBUpdate_Click(object sender, EventArgs e)
        {

            if (this.scanneData.Text != "" || scan_manuel.Text != "")
            {

                if (scan_manuel.Text != "" && this.scanneData.Text=="")
                {
                    scan = scan_manuel.Text;
                }
                else {
                    scan = this.scanneData.Text;
                }
                Cursor.Current = Cursors.WaitCursor;

                traitement_reception tr_recept = new traitement_reception();
                int result = tr_recept.insrt_respt(scan, "", "");
                
                /*
                if (result == 1)
                {
                    tr_recept.export_fichier();
                    tr_recept.upload();
                }
                */

                Cursor.Current = Cursors.Default;

                //fermeture de la fenetre this.close
                API_scanne.StopRead();
                this.Close();
                (new Menu()).Show();
            }
            else {
                MessageBox.Show("Aucun scan est effectue  !!");
            }
        }

        private void BT_recept_info_sup_Click(object sender, EventArgs e)
        {
            if (this.scanneData.Text != "" || scan_manuel.Text != "")
            {

                if (scan_manuel.Text != "")
                {
                    scan = scan_manuel.Text;
                }
                else
                {
                    scan = this.scanneData.Text;
                }
            }
            recept_info_sup info_sup = new recept_info_sup();
            info_sup.lab_code.Text = this.scan.ToString();
            API_scanne.StopRead();
            info_sup.Show();
        }

        private void article_ParentChanged(object sender, EventArgs e)
        {

        }

        private void articleBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}