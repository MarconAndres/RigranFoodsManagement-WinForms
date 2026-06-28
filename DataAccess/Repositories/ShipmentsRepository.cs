using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using Entities;

namespace DataAccess.Repositories
{
    public class ShipmentsRepository
    {
        private readonly Connection _connection = new Connection();

        public List<Shipments> GetAll()
        {
            string query = "SELECT ID, IdSales, IdShipmentStatus, BookingNumber, ContainerNumber, IdContainerType, ShippingLine, IdPortOfLoading, IdPortOfDestination, ETD, ATD, ETA, ATA, FreeDays, BLApproved, DHLNumber, HasClaim, ClaimNotes, Notes FROM Shipments";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    var result = conn.Query<Shipments>(query);
                    return result.AsList();
                }
                catch (Exception ex)
                {

                    throw new Exception ("Error while trying to read Shipments. " + ex.Message);
                }
            }
        }

        public void Insert (Shipments shipments)
        {
            string query = "INSERT INTO Shipments (IdSales, IdShipmentStatus, BookingNumber, ContainerNumber, IdContainerType, ShippingLine, IdPortOfLoading, IdPortOfDestination, ETD, ATD, ETA, ATA, FreeDays, BLApproved, DHLNumber, HasClaim, ClaimNotes, Notes) VALUES (@IdSales, @IdShipmentStatus, @BookingNumber, @ContainerNumber, @IdContainerType, @ShippingLine, @IdPortOfLoading, @IdPortOfDestination, @ETD, @ATD, @ETA, @ATA, @FreeDays, @BLApproved, @DHLNumber, @HasClaim, @ClaimNotes, @Notes)";

            using (SqlConnection conn = _connection.GetConnection())
            {
                try
                {
                    conn.Execute(query, shipments);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error while trying to insert a new Shipment. " + ex.Message);
                }
            }
        }
    }
}
