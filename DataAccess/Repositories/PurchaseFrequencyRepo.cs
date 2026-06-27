using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class PurchaseFrequencyRepo
    {
        private readonly Connection _connection = new Connection();

        public List<PurchaseFrequency> GetAll()
        {
            string query = "SELECT ID, [Name] FROM PurchaseFrequency";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<PurchaseFrequency>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read Purchasefrequency. " + ex.Message);
                }
            }
        }

        public void Insert (PurchaseFrequency purchaseFrequency)
        {
            string query = "INSERT INTO PurchaseFrequency ([Name]) VALUES (@Name)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, purchaseFrequency);
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to Insert a new PurchaseFrequency. " + ex.Message);
                }
            }
        }
    }
}
