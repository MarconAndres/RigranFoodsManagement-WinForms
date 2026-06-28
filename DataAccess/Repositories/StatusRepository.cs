using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class StatusRepository
    {
        private readonly Connection _connection = new Connection();

        public List<Status> GetAll()
        {
            string query = "SELECT ID, [Name] FROM Status";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<Status>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read Status. " + ex.Message);
                }
            }
        }

        public void Insert (Status status)
        {
            string query = "INSERT INTO Status ([Name]) VALUES (@Name)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, status);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to insert a new Status. " + ex.Message);
                }
            }
        }
    }
}