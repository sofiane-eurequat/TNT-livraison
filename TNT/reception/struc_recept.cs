using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TNT.reception
{
    class struc_recept
    {
           private String m_id_recept = "";

        private String m_id_env = "";
        private String m_id_util = "";
        private String m_obser = "";
        private String m_signe = "";
        private DateTime m_date_recp;
       

       /* public String analytique
        {
            get { return m_analytique; }
            set { m_analytique = value; }
        }*/

        public String id_recept
        {
            get { return m_id_recept; }
            set { m_id_recept = value; }
        }

        public String id_env
        {
            get { return m_id_env; }
            set { m_id_env = value; }
        }

        public String util
        {
            get { return m_id_util; }
            set { m_id_util = value; }
        }

        public String observ        {
            get { return m_obser; }
            set { m_obser = value; }
        }

        public String signe
        {
            get { return m_signe; }
            set { m_signe = value; }
        }

                public DateTime date_recp
        {
            get { return m_date_recp; }
            set { m_date_recp = value; }
        }
        /* public String type_read
         {
             get { return m_type_read; }
             set { m_type_read = value; }
         }*/
        
        
        public struc_recept() { }

        public String toString(){
            string format ="dd/MM/yyyy,HH:mm:ss";
            StringBuilder builder = new StringBuilder();
            builder.Append(m_id_recept).Append(";")
                .Append(m_id_env).Append(";").Append(m_id_util).Append(";").Append(m_obser).Append(";")
                .Append(m_signe).Append(";")
                .Append(m_date_recp).Append("\n");
            return builder.ToString();
        }
        

        public struc_recept( String m_id_recept,   String m_id__env,  String m_id_util,  String m_obser, //String m_analytique, 
            String m_signe,DateTime m_date_recp)
        {
            m_id_recept = id_recept;
            m_id_env = id_env;
            m_id_util = util;
            m_obser = observ;
            m_signe = signe;
            m_date_recp = date_recp;            
        }


    }
}
