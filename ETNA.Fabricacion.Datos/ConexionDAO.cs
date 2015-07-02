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
        
        SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public    SqlConnection Conecta() 
        {
            return cn;
        }

    }
}
