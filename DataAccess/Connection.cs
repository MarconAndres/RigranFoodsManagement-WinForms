using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class Connection
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["RigranFoodsDB"].ConnectionString;

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
