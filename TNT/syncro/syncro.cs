using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentPro.Net;
using TNT.login;

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
    }
}