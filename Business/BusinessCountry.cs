using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class BusinessCountry
    {
        private readonly CountryRepository _repocountry = new CountryRepository();

        public List<Country> ListCountries()
        {
            return _repocountry.GetAll();
        }

        public void AddCountry(Country country)
        {
            if (string.IsNullOrWhiteSpace(country.Name))
            {
                throw new Exception("Error: the name of the Country can not be empty.");
            }
            _repocountry.Insert(country);
}}      }
