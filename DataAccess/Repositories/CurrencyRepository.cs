using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Entities;
using Microsoft.Data.SqlClient;

namespace DataAccess.Repositories
{
    public class CurrencyRepository
    {
        private readonly Connection _connection = new Connection();

        public List<Currency> GetAll()
        {
            string query = "SELECT ID, Code, [Name] FROM Currency";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<Currency>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to read Currency with Dapper. "+ ex.Message);
                }
            }
        }

        public void Insert (Currency currency)
        {
            string query = "INSERT INTO Currency (Code, [Name] VALUES (@Code, @Name))";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, currency);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to Insert a new Currency. " + ex.Message);
                }
            }
        }
}}
