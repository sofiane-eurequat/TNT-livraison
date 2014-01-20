﻿

using TNT.login;
using OpenNETCF.Net.NetworkInformation;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;


namespace TNT.syncro
{
    public partial class syncro : Form
    {
        public syncro()
        {
            InitializeComponent();

            int syncro = traitement_authentification.sync;
            if (syncro == 1)
            {
                bt_synch_pda.Enabled = true;
                lab_syncro_pc_pda.Enabled = true;

            } if (syncro == 0)
            {
                MessageBox.Show("Veuliez etablir la synchronisation PDA -> PC !!");
            } if (syncro == 2)
            {
                bt_synch_pda.Enabled = false;
                lab_syncro_pc_pda.Enabled = false;

            } 
            
        }

        private void pBHome_Click(object sender, EventArgs e)
        {

        }

        private void bt_sync_pc_Click(object sender, EventArgs e)
        {
            traitement_upload up = new traitement_upload();
            up.exporte_fichier();
            up.upload();
        }

        private void bt_sync_pda_Click(object sender, EventArgs e)
        {
            traitement_download dn = new traitement_download();
            int rep = dn.download();
            if(rep == 1)
            {
                dn.delete_tab();

                dn.insert();
                dn.insert_pers();
                dn.insert_pers_type();
                dn.insert_enlev();
                dn.sup_fiche();
            }
        }

        private void pBHome_Click_1(object sender, EventArgs e)
        {
            int syncro = traitement_authentification.sync;
            if (syncro == 0 || syncro == 2)
            {
                this.Close();
                (new Menu()).Show();
            }
            else 
            {
                MessageBox.Show("Veillez établir la Synchronisation PC -> PDA");
            }
        }

        private void bt_synch_pda_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; 
            
            traitement_download dn = new traitement_download();
            int rep = dn.download();
            if (rep == 1)
            {
                dn.delete_tab();

                dn.insert();
                dn.insert_pers();
                dn.insert_pers_type();
                dn.insert_enlev();
                dn.sup_fiche();

                traitement_authentification.sync = 2;
           
                bt_synch_pda.Enabled = false;
                lab_syncro_pc_pda.Enabled = false;

            
            }
            Cursor.Current = Cursors.Default;
        }

        private void bt_synch_pc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            traitement_upload up = new traitement_upload();
            up.exporte_fichier();
            up.upload();
            if (traitement_authentification.sync == -1)
            {
                traitement_authentification.sync = 1;
            }
            
            
            int syncro = traitement_authentification.sync;
            if (syncro == 1)
            {
                bt_synch_pda.Enabled = true;
                lab_syncro_pc_pda.Enabled = true;
            }
            
            Cursor.Current = Cursors.Default;

        }

        /*

        public static string PingHost(string host)
        {
            //string to hold our return messge
            string returnMessage = string.Empty;

            //IPAddress instance for holding the returned host
            IPAddress address = GetIpFromHost(ref host);

            //set the ping options, TTL 128
            PingOptions pingOptions = new PingOptions(128, true);

            //create a new ping instance
            Ping ping = new Ping();

            //32 byte buffer (create empty)
            byte[] buffer = new byte[32];

            //first make sure we actually have an internet connection
            if (HasConnection())
            {
                //here we will ping the host 4 times (standard)
                for (int i = 0; i < 4; i++)
                {
                    try
                    {
                        //send the ping 4 times to the host and record the returned data.
                        //The Send() method expects 4 items:
                        //1) The IPAddress we are pinging
                        //2) The timeout value
                        //3) A buffer (our byte array)
                        //4) PingOptions
                        PingReply pingReply = ping.Send(address, buffer, 1000, pingOptions);

                        //make sure we dont have a null reply
                        if (!(pingReply == null))
                        {
                            switch (pingReply.Status)
                            {
                                case IPStatus.Success:
                                    returnMessage = string.Format("Reply from {0}: bytes={1} time={2}ms TTL={3}", pingReply.Address, pingReply.Buffer.Length,  pingReply.Options.Ttl);
                                    break;
                                case IPStatus.TimedOut:
                                    returnMessage = "Connection has timed out...";
                                    break;
                                default:
                                    returnMessage = string.Format("Ping failed: {0}", pingReply.Status.ToString());
                                    break;
                            }
                        }
                        else
                            returnMessage = "Connection failed for an unknown reason...";
                    }
                    catch (PingException ex)
                    {
                        returnMessage = string.Format("Connection Error: {0}", ex.Message);
                    }
                    catch (SocketException ex)
                    {
                        returnMessage = string.Format("Connection Error: {0}", ex.Message);
                    }
                }
            }
            else
                returnMessage = "No Internet connection found...";

            //return the message
            return returnMessage;
        }
        */
    
        string result = "Pas de connexion";
        private void Con_Click(object sender, EventArgs e)
        {
            string msg = "";
         Ping myPing = new Ping(); 
        String host = "google.com"; 
        byte[] buffer = new byte[32]; 
        int timeout = 1000; 
        PingOptions pingOptions = new PingOptions(); 
        PingReply reply = myPing.Send(host,  buffer,timeout, pingOptions); 
        if (reply.Status == IPStatus.Success) 
        {
           msg="Connexion réussite !!";
        }
        else
        {
            msg="problème de connexion !!";
        }
           // string msg = PingHost("eurequat-algerie.com");
           // MessageBox.Show(msg.ToString());
        }
    }
}