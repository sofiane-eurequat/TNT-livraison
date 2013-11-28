using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TNT.Enlevement
{
    class datastructure
    {


        private String m_envoi = "";

        private String m_exp = "";
        private String m_dest = "";
        private String m_scanne = "";
        private String m_util = "";
        private DateTime m_date;
       

       /* public String analytique
        {
            get { return m_analytique; }
            set { m_analytique = value; }
        }*/

        public String id_envoi
        {
            get { return m_envoi; }
            set { m_envoi = value; }
        }

        public String expediteur
        {
            get { return m_exp; }
            set { m_exp = value; }
        }

        public String destinataire
        {
            get { return m_dest; }
            set { m_dest = value; }
        }

        public String scanne
        {
            get { return m_scanne; }
            set { m_scanne = value; }
        }

        public String utilisateur
        {
            get { return m_util; }
            set { m_util = value; }
        }
        /* public String type_read
         {
             get { return m_type_read; }
             set { m_type_read = value; }
         }*/
        public DateTime date
        {
            get { return m_date; }
            set { m_date = value; }
        }
        public datastructure() { }

        public String toString(){
            string format ="dd/MM/yyyy,HH:mm:ss";
            StringBuilder builder = new StringBuilder();
            builder.Append(m_envoi).Append(";")
                .Append(m_exp).Append(";").Append(m_dest).Append(";").Append(m_scanne).Append(";")
                .Append(m_util).Append(";").Append(m_date).Append("\n");
            return builder.ToString();
        }
        

        public datastructure( String m_Envoi,   String m_Exp,  String m_Dest,  String m_Scan, //String m_analytique, 
            String m_Util, DateTime m_date
         //String m_type_read
         //DateTime m_date
            )
        {
            m_Envoi = id_envoi;
            m_Exp = expediteur;
            m_Dest = destinataire;
            m_Scan = scanne;
            m_Util = utilisateur;
            m_date = date;
             //m_analytique = analytique;
            
        }


    }
}
