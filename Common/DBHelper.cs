using System.Data;
using System.Data.SqlClient;

namespace blog
{
    public class DBHelper
    {
        public static IDbConnection GetConnection()
        {
            return new SqlConnection();
        }
    }
}