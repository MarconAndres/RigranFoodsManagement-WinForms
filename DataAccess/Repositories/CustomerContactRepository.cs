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
            string query = "SELECT ID, IdCustomer, FirstName, LastName, [Role/Position] AS RolePosition, Email, PhoneNumber FROM CustomerContact";

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
            string query = "INSERT INTO CustomerContact (IdCustomer, FirstName, LastName, [Role/Position], Email, PhoneNumber) VALUES (@IdCustomer, @FirstName, @LastName, @RolePosition, @Email, @PhoneNumber)";

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

        public void Update (CustomerContact contact)
        {
            string query = "UPDATE CustomerContact SET IdCustomer = @IdCustomer, FirstName = @FirstName, LastName = @LastName, [Role/Position] = @RolePosition, Email = @Email, PhoneNumber = @PhoneNumber WHERE ID = @ID";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, contact);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error: While Trying to Update Customer Contact. " + ex.Message);
                }
            }
        }  

        public CustomerContact GetById(int id)
        {
            string query = "SELECT ID, IdCustomer, FirstName, LastName, [Role/Position] AS RolePosition, Email, PhoneNumber FROM CustomerContact WHERE ID = @ID";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.QuerySingleOrDefault<CustomerContact>(query, new { ID = id });
                    return result;
                }
                catch (Exception ex)
                {

                    throw new Exception("Error: While Trying to Retrieve Customer Contact. " + ex.Message);
                }
            }
        }
    }
}
