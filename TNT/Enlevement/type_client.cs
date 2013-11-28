using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TNT.Enlevement
{
    class type_client
    {
        

        private String m_type_clt = "";

        private String m_type = "";
        private String m_personne = "";


       /* public String analytique
        {
            get { return m_analytique; }
            set { m_analytique = value; }
        }*/

        public String id_clt_type
        {
            get { return m_type_clt; }
            set { m_type_clt = value; }
        }

        public String id_type
        {
            get { return m_type; }
            set { m_type = value; }
        }

        public String id_personne
        {
            get { return m_personne; }
            set { m_personne = value; }
        }

        public type_client() { }

        public String toString(){
            string format ="dd/MM/yyyy,HH:mm:ss";
            StringBuilder builder = new StringBuilder();
            builder.Append(m_type_clt).Append(";")
                .Append(m_type).Append(";").Append(m_personne).Append("\n");
            return builder.ToString();
        }
        

        public type_client( String m_Id_clt_type,   String m_Type,  String m_Personne)
        {
            m_Id_clt_type = id_clt_type;
            m_Type = id_type;
            m_Personne = id_personne;
        }

    }
}
