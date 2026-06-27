using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DataAccess.Repositories
{
    public class CountryRepository
    {
        private readonly Connection _connection = new Connection();

        public List<Country> GetAll()
        {
            string query = "SELECT ID, Name FROM Country";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<Country>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read Country with dapper" + ex.Message);
                }
            }
        }

        public void Insert(Country country)
        {
            string query = "INSERT INTO Country (Name) VALUES (@Name)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, country);
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to insert a new country" + ex.Message);
                }
            }
        }
    }
}
