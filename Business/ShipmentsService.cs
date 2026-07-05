using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class ShipmentsService
    {
        private readonly ShipmentsRepository _shipmentsRepository;

        public ShipmentsService()
        {
            _shipmentsRepository = new ShipmentsRepository();
        }

        public List<Shipments> GetAll()
        {
            return _shipmentsRepository.GetAll();
        }

        public void Insert(Shipments shipments)
        {

            ValidateShipments(shipments);
            _shipmentsRepository.Insert(shipments);
        }
      
        private void ValidateShipments(Shipments shipments)
        {
            if (shipments == null)
            {
                throw new Exception("Error: No data was provided.");
            }
            if (!shipments.IdSales.HasValue || !shipments.IdShipmentStatus.HasValue || string.IsNullOrWhiteSpace(shipments.BookingNumber) || string.IsNullOrWhiteSpace(shipments.ShippingLine) || !shipments.IdPortOfLoading.HasValue || !shipments.IdPortOfDestination.HasValue)
            {
                throw new Exception("Error: Please complete the obligatory fields. ");
            }
            if (shipments.ETD == DateTime.MinValue)
            {
                throw new Exception("Error: Please provide a valid ETD. ");
            }
            if (shipments.IdSales.HasValue && shipments.IdSales.Value <= 0)
            {
                throw new Exception("Error: The selected Sales is not correct or it does not exist. ");
            }
            if (shipments.IdShipmentStatus.HasValue && shipments.IdShipmentStatus.Value <= 0)
            {
                throw new Exception("Error: The selected Shipment Status is not correct or it does not exist. ");
            }
            if (!string.IsNullOrWhiteSpace(shipments.BookingNumber) && shipments.BookingNumber.Length > 50)
            {
                throw new Exception("Error: The field Booking Number can not possess more than 50 characters.");
            }
            if (!string.IsNullOrWhiteSpace(shipments.ShippingLine) && shipments.ShippingLine.Length > 100)
            {
                throw new Exception("Error: The field Shipping Line can not possess more than 100 characters.");
            }
            if (shipments.IdPortOfLoading.HasValue && shipments.IdPortOfLoading.Value <= 0)
            {
                throw new Exception("Error: The selected Port of Loading is not correct or it does not exist. ");
            }
            if (shipments.IdPortOfDestination.HasValue && shipments.IdPortOfDestination.Value <= 0)
            {
                throw new Exception("Error: The selected Port of Destination is not correct or it does not exist. ");
            }
            if (shipments.IdContainerType.HasValue && shipments.IdContainerType.Value <= 0)
            {
                throw new Exception("Error: The selected Container Type is not correct or it does not exist. ");
            }
            if (shipments.ATD.HasValue && shipments.ATD.Value < shipments.ETD)
            {
                throw new Exception("Error: The Actual Time of Departure (ATD) cannot be earlier than the Estimated Time of Departure (ETD).");
            }
            if (shipments.ETA.HasValue && shipments.ETA.Value < shipments.ETD)
            {
                throw new Exception("Error: The Estimated Time of Arrival (ETA) cannot be earlier than the Estimated Time of Departure (ETD).");
            }
            if (shipments.ATA.HasValue)
            {
                if (shipments.ATA.Value < shipments.ETD)
                {
                    throw new Exception("Error: The Actual Time of Arrival (ATA) cannot be earlier than the Estimated Time of Departure (ETD).");
                }
                if (shipments.ATD.HasValue && shipments.ATA.Value < shipments.ATD.Value)
                {
                    throw new Exception("Error: The Actual Time of Arrival (ATA) cannot be earlier than the Actual Time of Departure (ATD).");
                }
            }
            if (shipments.FreeDays != null && shipments.FreeDays.Length >50)
            {
                throw new Exception("Error: The field Free Days can not possess more than 50 characters.");
            }
            if (shipments.DHLNumber != null && shipments.DHLNumber.Length > 100)
            {
                throw new Exception("Error: The field DHL number can not possess more than 100 characters.");
            }
        }
    }
}
