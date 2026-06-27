using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class PriceSensitivityRepo
    {
        private readonly Connection _connection = new Connection();

        public List<PriceSensitivity> GetAll()
        {
            string query = "SELECT ID, [Level] FROM PriceSensitivity";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<PriceSensitivity>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read PriceSensitivity. "+ ex.Message);
                }
            }
        }

        public void Insert(PriceSensitivity priceSensitivity)
        {
            string query = "INSERT INTO PriceSensitivity ([Level]) VALUES (@Level)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, priceSensitivity);
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to Insert a new PriceSensitivity. " + ex.Message);
                }
            }
        }
    }
}
