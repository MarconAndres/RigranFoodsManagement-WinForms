using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess.Repositories;

namespace Business
{
    public class SalesService
    {
        private readonly SalesRepository _salesRepo;

        public SalesService()
        {
            _salesRepo = new SalesRepository();
        }
         public List<Sales> GetAll()
        {
            return _salesRepo.GetAll();
        }
        public void Insert(Sales sales)
        {
            if (!sales.IdCustomer.HasValue || !sales.IdProduct.HasValue || !sales.IdStatus.HasValue || !sales.ContractDate.HasValue || string.IsNullOrWhiteSpace(sales.CropYear) || !sales.Quantity.HasValue || !sales.PricePerTon.HasValue || !sales.IdCurrency.HasValue || !sales.IdIncoTerm.HasValue || !sales.IdMethodOfPayment.HasValue)
            {
                throw new Exception("Error: Please complete the obligatory fields.");
            }
            if (sales.IdCustomer.HasValue && sales.IdCustomer.Value <= 0)
            {
                throw new Exception("Error: The selected Customer is not correct or it doesn't exist.");
            }
            if (sales.IdProduct.HasValue && sales.IdProduct.Value <= 0)
            {
                throw new Exception("Error: The selected Product is not correct or it doesn't exist.");
            }
            if (sales.IdStatus.HasValue && sales.IdStatus.Value <= 0)
            {
                throw new Exception("Error: The selected Status is not correct or it doesn't exist.");
            }
            if (sales.CropYear.Length > 20)
            {
                throw new Exception("Error: The field Crop Year can not possess more than 20 characters.");
            }
            if (sales.Quantity.HasValue && sales.Quantity.Value <= 0)
            {
                throw new Exception("Error: The Quantity can not be 0 or negative. ");
            }
            if (sales.PricePerTon.HasValue && sales.PricePerTon.Value <= 0)
            {
                throw new Exception("Error: The Price per Ton can not be 0 or negative. ");
            }
            if (sales.IdCurrency.HasValue && sales.IdCurrency.Value <= 0)
            {
                throw new Exception("Error: The selected Currency is not correct or it doesn't exist.");
            }
            if (sales.IdIncoTerm.HasValue && sales.IdIncoTerm.Value <= 0)
            {
                throw new Exception("Error: The selected Incoterm is not correct or it doesn't exist.");
            }
            if (sales.IdMethodOfPayment.HasValue && sales.IdMethodOfPayment.Value <= 0)
            {
                throw new Exception("Error: The selected Method of Payment is not correct or it doesn't exist.");
            }
            if (sales.Shipper != null && sales.Shipper.Length > 100)
            {
                throw new Exception("Error: The field Shipper can not possess more than 100 characters.");
            }
            if (sales.Seller != null && sales.Seller.Length > 100)
            {
                throw new Exception("Error: The field Seller can not possess more than 100 characters.");
            }
            if (sales.IdPortOfLoading.HasValue && sales.IdPortOfLoading.Value <= 0)
            {
                throw new Exception("Error: The selected Port of Loading is not correct or it doesn't exist.");
            }
            if (sales.IdPortOfDestination.HasValue && sales.IdPortOfDestination.Value <= 0)
            {
                throw new Exception("Error: The selected Port of Destination is not correct or it doesn't exist.");
            }

            _salesRepo.Insert(sales);
        }
    }
}
