using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class ContainerTypeRepository
    {
        private readonly Connection _connection = new Connection();

        public List<ContainerType> GetAll()
        {
            string query = "SELECT ID, Code, [Description] FROM ContainerType ";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<ContainerType>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to read ContainerType with Dapper. " + ex.Message);
                }
            }
        }

        public void Insert(ContainerType containerType)
        {
            string query = "INSERT INTO ContainerType (Code, Description) VALUES (@Code, @Description)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, containerType);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to insert a new ContainerType." + ex.Message);
                }
            }
        }

    }
}
