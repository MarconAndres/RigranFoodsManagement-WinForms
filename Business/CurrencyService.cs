using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class CurrencyService
    {
        private readonly CurrencyRepository _currencyRepository;

        public CurrencyService()
        {
            _currencyRepository = new CurrencyRepository();
        }

        public List<Currency> GetAll()
        {
            return _currencyRepository.GetAll();
        }

        public void Insert(Currency currency)
        {
            if (string.IsNullOrWhiteSpace(currency.Code) || string.IsNullOrWhiteSpace(currency.Name))
            {
                throw new Exception("Error: The Currency Code or Name can not be empty. ");
            }
            if (currency.Code.Length > 3)
            {
                throw new Exception("Error: Currency Code can not possess more than 3 characters. ");
            }
            if (currency.Name.Length > 25)
            {
                throw new Exception("Error: Currency Name can not possess more than 25 characters. ");
            }

            _currencyRepository.Insert(currency);
        }
    }
}
