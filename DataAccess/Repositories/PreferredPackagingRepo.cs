using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class PreferredPackagingRepo
    {
        private readonly Connection _connection = new Connection();

        public List<PreferredPackaging> GetAll()
        {
            string query = "SELECT ID, [Name] FROM PreferredPackaging";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<PreferredPackaging>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to read PreferredPackaging. " + ex.Message);
                }
            }
        }

        public void Insert(PreferredPackaging preferredPackaging)
        {
            string query = "INSERT INTO PreferredPackaging ([Name]) VALUES (@Name)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, preferredPackaging);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to Insert a new Preferredpackaging" + ex.Message);
                }
            }
        }
    }
}
