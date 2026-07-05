using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class ShipmentStatusService
    {
        private readonly ShipmentStatusRepo _shipmentStatusRepo;

        public ShipmentStatusService()
        {
            _shipmentStatusRepo = new ShipmentStatusRepo();
        }

        public List<ShipmentStatus> GetAll()
        {
            return _shipmentStatusRepo.GetAll();
        }

        public void Insert(ShipmentStatus shipmentStatus)
        {
            ValidateShipmentStatus(shipmentStatus);
            _shipmentStatusRepo.Insert(shipmentStatus);
        }

        private void ValidateShipmentStatus(ShipmentStatus shipmentStatus)
        {
            if (shipmentStatus == null)
            {
                throw new Exception("Error: No data was provided.");
            }
            if (string.IsNullOrWhiteSpace(shipmentStatus.Name))
            {
                throw new Exception("Error: Please complete the field Shipment Status Name");
            }
            if (!string.IsNullOrWhiteSpace(shipmentStatus.Name) && shipmentStatus.Name.Length > 30)
            {
                throw new Exception ("Error: The field Name can not possess more than 30 characters. ");
            }
        }
    }
}
