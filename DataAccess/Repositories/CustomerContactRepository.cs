using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class CustomerContactRepository
    {
        private readonly Connection _connection = new Connection();

        public List<CustomerContact> GetAll()
        {
            string query = "SELECT ID, IdCustomer, FirstName, LastName, [Role/Position] AS Role, Email, PhoneNumber FROM CustomerContact";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<CustomerContact>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to read CustomerContact. " + ex.Message);
                }
            }
        }

        public void Insert (CustomerContact contact)
        {
            string query = "INSERT INTO CustomerContact (IdCustomer, FirstName, LastName, [Role/Position], Email, PhoneNumber) VALUES (@IdCustomer, @FirstName, @LastName, @Role, @Email, @PhoneNumber)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, contact);
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying Insert a new CustomerContact. " + ex.Message);
                }
            }
        }
}   }
