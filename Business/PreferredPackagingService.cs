using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess.Repositories;

namespace Business
{
    public class PreferredPackagingService
    {
        private readonly PreferredPackagingRepo _preferredPackagingRepo;


        public PreferredPackagingService()
        {
            _preferredPackagingRepo = new PreferredPackagingRepo();

        }

        public List<PreferredPackaging> GetAll()
        {
            return _preferredPackagingRepo.GetAll();
        }

        public void Insert(PreferredPackaging preferredPackaging)
        {
            if (string.IsNullOrWhiteSpace(preferredPackaging.Name))
            {
                throw new Exception("Error: Please complete the obligatory fields.");
            }
            if (preferredPackaging.Name.Length > 20 )
            {
                throw new Exception("Error: The field Name can not possess more than 20 characters. ");
            }
            _preferredPackagingRepo.Insert(preferredPackaging);
        }
    }
}   
