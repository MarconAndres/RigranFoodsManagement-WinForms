using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class CustomerProductProfileRepo
    {
        private readonly Connection _connection = new Connection();

        public List<CustomerProductProfile> GetAll()
        {
            string query = "SELECT IdCustomer, IdProductMaster, AnnualVolume, IdPreferredPackaging, IdPurchaseFrequency, IdPriceSensitivity, AlternativeOrigin, IdQualityStandart, Notes FROM CustomerProductProfile";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<CustomerProductProfile>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read CustomerProductProfile. " + ex.Message);
                }
            }
        }

        public void Insert(CustomerProductProfile customerProductProfile)
        {
            string query = "INSERT INTO CustomerProductProfile (IdCustomer, IdProductMaster, AnnualVolume, IdPreferredPackaging, IdPurchaseFrequency, IdPriceSensitivity, AlternativeOrigin, IdQualityStandart, Notes) VALUES (@IdCustomer, @IdProductMaster, @AnnualVolume, @IdPreferredPackaging, @IdPurchaseFrequency, @IdPriceSensitivity, @AlternativeOrigin, @IdQualityStandart, @Notes)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, customerProductProfile);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to Insert a new CustomerProductProfile. " + ex.Message);
                }
            }
        }
    }
}
