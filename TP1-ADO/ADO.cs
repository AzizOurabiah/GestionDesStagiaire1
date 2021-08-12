using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TP1_ADO
{
    class ADO
    {
        //Déclaration des objets SQL
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        //Déclaration de la méthode Connecté
        public void CONNECTER()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = "Data Source=AZIZ;Initial Catalog=TDI;Integrated Security=True";
                con.Open();
            }
        }
        //Déclaration de la méthode Déconnecté
        public void DECONNECTER()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
