using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class Connection
    {
        private readonly string _connectionString = @"server=MSI\SQLEXPRESS;Database=RigranFoods_DB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
