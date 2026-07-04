using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess.Repositories;

namespace Business
{
    public class PurchaseFrequencyService
    {
        private readonly PurchaseFrequencyRepo _purchaseFrequencyRepo;

        public PurchaseFrequencyService()
        {
            _purchaseFrequencyRepo = new PurchaseFrequencyRepo();
        }
         public List<PurchaseFrequency> GetAll()
        {   
            return _purchaseFrequencyRepo.GetAll(); 
        }

        public void Insert(PurchaseFrequency purchaseFrequency)
        {   
            if (string.IsNullOrWhiteSpace(purchaseFrequency.Name))
            {
                throw new Exception("Error: Please enter a Name for Purchase Frequency.");
            }
            if (purchaseFrequency.Name.Length > 20 )

            {
                throw new Exception("Error: The field Name can not possess more than 20 characters. ");
            }
            _purchaseFrequencyRepo.Insert(purchaseFrequency);
        }
}}
