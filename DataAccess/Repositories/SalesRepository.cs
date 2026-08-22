using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class SalesRepository
    {
        private readonly Connection _connection = new Connection();

        public List<Sales> GetAll()
        {
            string query = "SELECT ID, IdCustomer, IdProduct, IdProductSpecifications, IdStatus, ContractDate, Shipper, Seller, CropYear, Quantity, PricePerTon, IdCurrency, IdIncoTerm, IdMethodOfPayment, IdPortOfLoading, IdPortOfDestination, BrokerComissionPc FROM Sales";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<Sales>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to read Sales. " + ex.Message);
                }
            }
        }

        public void Insert (Sales sales)
        {
            string query = "INSERT INTO Sales (IdCustomer, IdProduct, IdProductSpecifications,IdStatus, ContractDate, Shipper, Seller, CropYear, Quantity, PricePerTon, IdCurrency, IdIncoTerm,IdMethodOfPayment, IdPortOfLoading, IdPortOfDestination, BrokerComissionPc) VALUES (@IdCustomer, @IdProduct, @ @IdStatus, @ContractDate, @Shipper, @Seller, @CropYear, @Quantity, @PricePerTon, @IdCurrency, @IdIncoTerm, @IdMethodOfPayment, @IdPortOfLoading, @IdPortOfDestination, @BrokerComissionPc)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, sales);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to insert a new Sale. " + ex.Message);
                }
            }
        }
        public void Update (Sales sales)
        {
            string query = "UPDATE Sales SET IdCustomer = @IdCustomer, IdProduct = @IdProduct, IdProductSpecifications = @IdProductSpecifications, IdStatus = @IdStatus, ContractDate = @ContractDate, Shipper = @Shipper, Seller = @Seller, CropYear = @CropYear, Quantity = @Quantity, PricePerTon = @PricePerTon, IdCurrency = @IdCurrency, IdIncoTerm = @IdIncoTerm, IdMethodOfPayment = @IdMethodOfPayment, IdPortOfLoading = @IdPortOfLoading, IdPortOfDestination = @IdPortOfDestination, BrokerComissionPc = @BrokerComissionPc WHERE ID = @ID";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, sales);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to Update a sale. " + ex.Message);
                }
            }
        }
        public Sales GetById(int id)
        {
            string query = "SELECT ID, IdCustomer, IdProduct, IdProductSpecifications, IdStatus, ContractDate, Shipper, Seller, CropYear, Quantity, PricePerTon, IdCurrency, IdIncoTerm, IdMethodOfPayment, IdPortOfLoading, IdPortOfDestination, BrokerComissionPc FROM Sales WHERE ID = @ID";
            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.QuerySingleOrDefault<Sales>(query, new { ID = id });
                    if (result == null)
                    {
                        throw new Exception("Error: Sale not found.");
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while trying to retrieve sale by ID. " + ex.Message);
                }
            }
        }
    }   }