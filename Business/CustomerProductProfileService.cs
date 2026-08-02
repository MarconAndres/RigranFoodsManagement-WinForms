using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class CustomerProductProfileService
    {
        private readonly CustomerProductProfileRepo _customerProductProfileRepo;

         public CustomerProductProfileService()
        {
            _customerProductProfileRepo = new CustomerProductProfileRepo();
        }

        public List<CustomerProductProfile> GetAll()
        {
            return _customerProductProfileRepo.GetAll();
        }

        public void Insert(CustomerProductProfile customerProductProfile)
        {
            ValidateCustomerProductProfile(customerProductProfile);

            _customerProductProfileRepo.Insert(customerProductProfile);
        }

        private void ValidateCustomerProductProfile(CustomerProductProfile customerProductProfile)
        {
            if (customerProductProfile == null)
            {
                throw new Exception("Error: No data was provided.");
            }
            if (customerProductProfile.IdCustomer <= 0 || customerProductProfile.IdProductMaster <= 0)
            {
                throw new Exception("Error: Please complete the obligatory fields. ");
            }

            if (customerProductProfile.AnnualVolume.HasValue && customerProductProfile.AnnualVolume.Value < 0)
            {
                throw new Exception("Error: The annual volume can not be negative.");
            }
            if (customerProductProfile.AnnualVolume.HasValue && customerProductProfile.AnnualVolume.Value > 9999999.999m)
            {
                throw new Exception("Error: Annual Volume exceeds the maximum allowed limit. The maximum value is 9,999,999.999 with up to 3 decimal places.");
            }

            if (customerProductProfile.IdPreferredPackaging.HasValue && customerProductProfile.IdPreferredPackaging.Value <= 0)
            {
                throw new Exception("Error: The selected Preferred Packaging is not correct. ");
            }

            if (customerProductProfile.IdPurchaseFrequency.HasValue && customerProductProfile.IdPurchaseFrequency.Value <= 0)
            {
                throw new Exception("Error: The selected Purchase Frequency is not correct. ");

            }

            if (customerProductProfile.IdPriceSensitivity.HasValue && customerProductProfile.IdPriceSensitivity.Value <= 0)
            {
                throw new Exception("Error: The selected Price Sensitivity is not correct. ");
            }

            if (customerProductProfile.AlternativeOrigin != null && customerProductProfile.AlternativeOrigin.Length > 100)
            {
                throw new Exception("Error: The Alternative Origin can not possess more than 100 characters. ");
            }

            if (customerProductProfile.IdQualityStandart.HasValue && customerProductProfile.IdQualityStandart.Value <= 0)
            {
                throw new Exception("Error: The selected Quality Standard is not correct. ");
            }
        }

        public void Update(CustomerProductProfile customerProductProfile)
        {
            

            if (customerProductProfile.IdCustomer <= 0 || customerProductProfile.IdProductMaster <= 0)
            {
                throw new Exception("Error: The Customer Product Profile you are trying to modify does not have a valid ID.");
            }
            ValidateCustomerProductProfile(customerProductProfile);
            _customerProductProfileRepo.Update(customerProductProfile);
        }

        public CustomerProductProfile GetById(int idCustomer, int idProductMaster)
        {
            try
            {
                if (idCustomer <= 0 || idProductMaster <= 0)
                {
                    throw new Exception("Error: The provided Customer ID or Product Master ID is not valid.");
                }
                return _customerProductProfileRepo.GetById(idCustomer, idProductMaster);

            }
            catch (Exception ex)
            {

                throw new Exception("Error retrieving customer by ID: " + ex.Message);
            }
        }
    }
}
