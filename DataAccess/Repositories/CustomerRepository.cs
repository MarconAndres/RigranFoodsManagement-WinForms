using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sql;
using Dapper;
using Entities;
using Microsoft.Data.SqlClient;

namespace DataAccess.Repositories
{
    public class CustomerRepository
    {
        private readonly Connection _connection = new Connection();

        public List<Customer> GetAll()
        {
            string query = "SELECT ID, [Name], IdBusinessSector, RegisteredName, [Address], [E-mail] as Email, VAT, IdCountry, PhoneNumber, BIO, EORI, Active FROM Customer";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<Customer>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying ro read Customer with Dapper. " + ex.Message);
                }
            }
        }

        public void Insert (Customer customer)
        {
            string query = "INSERT INTO Customer ([Name], IdBusinessSector, RegisteredName, [Address], [E-mail], VAT, IdCountry, PhoneNumber, BIO, EORI, Active) VALUES (@Name, @IdBusinessSector, @RegisteredName, @Address, @Email, @VAT, @IdCountry, @PhoneNumber, @BIO, @EORI, @Active)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, customer);
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to Insert a new Customer. " + ex.Message);
                }
            }
        }
    }
}
