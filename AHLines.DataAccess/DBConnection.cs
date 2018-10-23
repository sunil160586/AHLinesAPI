using System.Configuration;
using System.Data.SqlClient;

namespace AHLines.DataAccess
{
    public class DBConnection
    {
        public static string SqlConnectionString
        {
            get
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["constring"].ToString());
                return con.ConnectionString;
            }
        }
    }
}
