using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class Connection
    {
        private readonly string _connectionString = @"server=tcp:rigranfoods-server.database.windows.net,1433; initial Catalog=rigranfoods_DB; User ID=andresmarcon; Password=Avm93307; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
