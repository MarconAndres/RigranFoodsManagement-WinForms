using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Entities;
using Dapper;

namespace DataAccess.Repositories
{
    public class BusinessSectorRepository
    {
        private readonly Connection  _connection = new Connection();
        
        public List<BusinessSector> GetAll()
        {
          
            string query = "SELECT ID, Description FROM BusinessSector";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<BusinessSector>(query);

                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to read BusinessSector with Dapper: " + ex.Message);
                }
            }
        }

        public void Insert (BusinessSector businessSector)
        {
            string query = "INSERT INTO BusinessSector (Description) VALUES (@Description)";

            using (SqlConnection conn = _connection.GetConnection()) 
            {
                try
                {
                    conn.Execute(query, businessSector);
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error trying to Insert Sector into BusinessSector: " + ex.Message);
                }
            }
        }
        
}}
