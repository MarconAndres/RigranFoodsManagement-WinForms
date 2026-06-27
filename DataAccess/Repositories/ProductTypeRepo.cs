using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class ProductTypeRepo
    {
        private readonly Connection _connection = new Connection();

        public List<ProductType> GetAll()
        {
            string query = "SELECT ID, [Name] FROM ProductType";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<ProductType>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read ProductType. " + ex.Message);
                }
            }
        }
    }
}
