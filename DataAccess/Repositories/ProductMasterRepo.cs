using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class ProductMasterRepo
    {
        private readonly Connection _connection = new Connection();

        public List<ProductMaster> GetAll()
        {
            string query = "SELECT ID, IdProductType, [Name] FROM ProductMaster";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<ProductMaster>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read ProductMaster. " + ex.Message);
                }
            }
        }

        public void Insert (ProductMaster productMaster)
        {
            string query = "INSERT INTO ProductMaster (IdProductType, [Name]) VALUES (@IdProductType, @Name)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, productMaster);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to Insert a new ProductMaster. " + ex.Message);
                }
            }
        }
        public void Update (ProductMaster productMaster)
        {
            string query = "UPDATE ProductMaster SET IdProductType = @IdProductType, [Name] = @Name";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Query<ProductMaster>(query);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while tryin to update ProductMaster" + ex.Message);
                }
            }
        }
    }
}
