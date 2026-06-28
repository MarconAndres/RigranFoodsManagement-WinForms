using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;


namespace DataAccess.Repositories
{
    public class QualityStandartRepo
    {
        private readonly Connection _connection = new Connection();

        public List<QualityStandart> GetAll()
        {
            string query = "SELECT ID, [Name], [Description] FROM QualityStandart";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<QualityStandart>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to read QualityStandard. " + ex.Message);
                }
            }
        }

        public void Insert (QualityStandart qualityStandart)
        {
            string query = "INSERT INTO QualityStandart ([Name], [Description]) VALUES (@Name, @Description)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, qualityStandart);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to insert a new QualityStandard.  " + ex.Message);
                }
            }
        }
    }
}
