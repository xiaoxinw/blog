using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Blog
{
    public class DbContext 
    {
        public static IDbConnection GetConnection()
        {
            return new SqlConnection();
        }
    }
}