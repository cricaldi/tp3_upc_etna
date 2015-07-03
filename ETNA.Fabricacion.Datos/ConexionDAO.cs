using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class ConexionDAO
    {
        
        //SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        private static SqlConnection cn;

        private ConexionDAO()
        {
            
        }

       
        public static  SqlConnection getInstance() 
        {
            if (cn == null)
                cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

            return cn;
        }

    }
}
