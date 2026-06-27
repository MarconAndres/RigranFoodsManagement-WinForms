using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class ProductSpecificationsRepo
    {
        private readonly Connection _connection = new Connection();

        public List<ProductSpecifications> GetAll()
        {
            string query = "SELECT ID, IdProductMaster, [Size], Moisture, SplitAndBroken, Foreignmatter, TotalDamage, Purity,AddSpecs FROM ProductSpecifications";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<ProductSpecifications>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read ProductSpecifications" + ex.Message);
                }
            }
        }

        public void Insert(ProductSpecifications productSpecifications)
        {
            string query = "INSERT INTO ProductSpecifications (IdProductMaster, [Size], Moisture, SplitAndBroken, Foreignmatter, TotalDamage, Purity,AddSpecs) VALUES (@IdProductMaster, @Size, @Moisture, @SplitAndBroken, @Foreignmatter, @TotalDamage, @Purity, @AddSpecs)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, productSpecifications);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to Insert a new ProductSpecification. " + ex.Message);
                }
            }
        }
    }
}
