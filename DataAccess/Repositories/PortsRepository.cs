using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class PortsRepository
    {
        private readonly Connection _connection = new Connection();

        public List<Ports> GetAll()
        {
            string query = "SELECT ID, [Name], IdCountry FROM [Ports]";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<Ports>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read Ports. " + ex.Message);
                }
            }
        }

        public void Insert(Ports port)
        {
            string query = "INSERT INTO Ports ([Name], IdCountry) VALUES (@Name, @IdCountry)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, port);
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to Insert a new Port. " + ex.Message);
                }
            }
        }
    }
}
