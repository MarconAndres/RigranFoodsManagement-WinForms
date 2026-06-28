using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class ShipmentStatusRepo
    {
        private readonly Connection _connection = new Connection();

        public List<ShipmentStatus> GetAll()
        {
            string query = "SELECT ID, [Name] FROM ShipmentStatus";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<ShipmentStatus>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read ShipmentStatus. " + ex.Message);
                }
            }
        }

        public void Insert (ShipmentStatus shipmentStatus)
        {
            string query = "INSERT INTO ShipmentStatus ([Name]) VALUES (@Name)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, shipmentStatus);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to insert a new ShipmentStatus. " + ex.Message);
                }
            }
        }
    }
}
