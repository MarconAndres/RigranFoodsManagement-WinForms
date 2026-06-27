using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class MethodOfPaymentRepo
    {
        private readonly Connection _connection = new Connection();

        public List<MethodOfPayment> GetAll()
        {
            string query = "SELECT ID, Code, [Description] FROM MethodOfPayment";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<MethodOfPayment>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read MethodOfPayment" + ex.Message);
                }
            }
        }

        public void Insert(MethodOfPayment methodOfPayment)
        {
            string query = "INSERT INTO MethodOfPayment (Code, [Description]) VALUES (@Code, @Description)";

            using (SqlConnection conn =_connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, methodOfPayment);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to insert a new MethodOfPayment. " + ex.Message);
                }
            }
        }
    }
}
