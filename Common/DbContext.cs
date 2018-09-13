using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Blog
{
    public class DbContext
    {
        private readonly string _connectionStr;
        public DbContext(IConfiguration config)
        {
            _connectionStr = config.GetValue<string>("Connections:Default:ConnectionString");
        }

        public IDbConnection GetConnection()
        {
            var con = new NpgsqlConnection(_connectionStr);
            con.Open();
            return con;
        }
    }
}