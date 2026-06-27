using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class IncoTermRepository
    {
        private readonly Connection _connection = new Connection();

        public List<IncoTerm> GetAll()
        {
            string query = "SELECT ID, Code, Description FROM IncoTerm";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<IncoTerm>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read IncoTerm. " + ex.Message);
                }
            }
        }

        public void Insert(IncoTerm incoTerm)
        {
            string query = "INSERT INTO IncoTerm (Code, Description) VALUES (@Code, @Description)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, incoTerm);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to Insert a new IncoTerm. " + ex.Message);
                }
            }
        }
    }
}
