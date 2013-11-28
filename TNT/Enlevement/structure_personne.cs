using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TNT.Enlevement
{
    class structure_personne
    {
    

        private String m_id_pers = "";

        private String m_nom_pers = "";
        private String m_prenom_pres = "";
        private String m_adr_pres = "";
        private String m_societe = "";
        private String m_tel_pres = "";
       

       /* public String analytique
        {
            get { return m_analytique; }
            set { m_analytique = value; }
        }*/

        public String id_pers
        {
            get { return m_id_pers; }
            set { m_id_pers = value; }
        }

        public String nom
        {
            get { return m_nom_pers; }
            set { m_nom_pers = value; }
        }

        public String prenom
        {
            get { return m_prenom_pres; }
            set { m_prenom_pres = value; }
        }

        public String adress
        {
            get { return m_adr_pres; }
            set { m_adr_pres = value; }
        }

        public String societe
        {
            get { return m_societe; }
            set { m_societe = value; }
        }

                public String telephone
        {
            get { return m_tel_pres; }
            set { m_tel_pres = value; }
        }
        /* public String type_read
         {
             get { return m_type_read; }
             set { m_type_read = value; }
         }*/
        
        
        public structure_personne() { }

        public String toString(){
            string format ="dd/MM/yyyy,HH:mm:ss";
            StringBuilder builder = new StringBuilder();
            builder.Append(m_id_pers).Append(";")
                .Append(m_nom_pers).Append(";").Append(m_prenom_pres).Append(";")
                .Append(m_societe).Append("\n");
            return builder.ToString();
        }
        

        public structure_personne( String m_id_pers,   String m_nom,  String m_prenom,   //String m_analytique, 
            String m_societe, String m_tel
         //String m_type_read
         //DateTime m_date
            )
        {
            m_id_pers = id_pers;
            m_nom = nom;
            m_prenom = prenom;
            m_societe = societe;
     

        }


    }
}
