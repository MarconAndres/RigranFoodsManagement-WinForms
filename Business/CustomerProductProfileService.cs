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
            if (customerProductProfile.IdCustomer <= 0 || customerProductProfile.IdProductMaster <= 0)
            {
                throw new Exception("Error: Please complete the obligatorie fields. ");
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
                throw new Exception("Error: The selected Quality Standard is not correect. ");
            }

            _customerProductProfileRepo.Insert(customerProductProfile);
        }
    }
}
