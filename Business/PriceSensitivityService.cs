using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess.Repositories;

namespace Business
{
    public class PriceSensitivityService
    {
        private readonly PriceSensitivityRepo _priceSensitivityRepo;

        public PriceSensitivityService()
        {
            _priceSensitivityRepo = new PriceSensitivityRepo();
        }

        public List<PriceSensitivity> GetAll()
        {
            return _priceSensitivityRepo.GetAll();
        }

        public void Insert(PriceSensitivity priceSensitivity)
        {
            if (string.IsNullOrWhiteSpace(priceSensitivity.Level))
            {
                throw new Exception("Error: Please complete the obligatory fields.");
            }
            if (priceSensitivity.Level.Length > 20 )
            {
                throw new Exception("Error: The field Level can not possess more than 20 characters. ");
            }
            _priceSensitivityRepo.Insert(priceSensitivity);
        }
    }
}
