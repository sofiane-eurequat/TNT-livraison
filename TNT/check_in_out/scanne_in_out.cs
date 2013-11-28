using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNT.Enlevement;

namespace TNT.check_in_out
{
    public partial class scanne_in_out : Form
    {

        private String m_id_env = "";
        public String m_colis;
        private String m_dest = "";
        private String m_exp = "";
        private String m_user = "";
        private AP scanAPI=null;
        private EventHandler myReadNotifyHandler = null;
        public bool fermer = false;

  
        private List<Enlevement.datastructure> m_envois = new List<Enlevement.datastructure>();
        private Enlevement.datastructure m_envoi;

        private List<Enlevement.datastructure> envois
        {
            get { return m_envois; }
            set { m_envois = value; }
        }

        public String User
        {
            get { return m_user; }
            set { m_user = value; }
        }

        public String exp
        {
            get { return m_exp; }
            set { m_exp = value; }
        }
        public String dest
        {
            get { return m_dest; }
            set { m_dest = value; }
        }

        public String colis
        {
            get { return m_colis; }
            set { m_colis = value; }
        }
       private Enlevement.datastructure envoi_ajt
        {
            get { return m_envoi; }
            set { m_envoi = value; }
        }
        public String id_envoi
        {
            get { return m_id_env; }
            set { m_id_env = value; }
        }



        public scanne_in_out()
        {
            InitializeComponent();
        }

        public void next_Click(object sender, EventArgs e)
        {
            //appendInventoryData();
            initAll();
            this.articleBox.Focus();

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

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int check_in;

        private void pBUpdate_Click(object sender, EventArgs e)
        {
            traitement_check tr_check = new traitement_check();
            tr_check.eng_scane(check_in ,this.scannedData.Text.ToString());
            initAll();
            this.articleBox.Focus();
        }

        private void pBHome_Click(object sender, EventArgs e)
        {
            scanAPI.StopRead();
            this.Close();
        }

        private void scanne_in_out_Load(object sender, EventArgs e)
        {
            scanAPI = new AP();
            scanAPI.InitReader();
            scanAPI.StartRead(false);
            this.myReadNotifyHandler = new EventHandler(myReader_ReadNotify);
            scanAPI.AttachReadNotify(myReadNotifyHandler);
            List<String> states = new List<String>();
            this.articleBox.Focus();

        }

    }
}