using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class CountryService
    {
        private readonly CountryRepository _repocountry;

        public CountryService()
        {
            _repocountry = new CountryRepository();
        }


        public List<Country> GetAll()
        {
            return _repocountry.GetAll();
        }

        public void Insert(Country country)
        {
            if (string.IsNullOrWhiteSpace(country.Name))
            {
                throw new Exception("Error: the name of the Country can not be empty.");
            }
            if (country.Name.Length > 50)
            {
                throw new Exception("Error: The Cpuntry Name can not posses more than 50 characters. ");
            }
                _repocountry.Insert(country);
        }
    }   
}