using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepo;

        public CustomerService()
        {  _customerRepo = new CustomerRepository(); }

        public List<Customer> GetAll()
        {
            return _customerRepo.GetAll();
        }

        public void Insert (Customer customer)
        {
            ValidateCustomer(customer);
            _customerRepo.Insert(customer);
        }
        public void Update (Customer customer)
        {
            ValidateCustomer(customer);
            if (customer.ID <= 0)
            {
                throw new Exception("Error: The Customer you are trying to modify does not have a valid ID.");
            }
            _customerRepo.Update(customer);
        }

        private void ValidateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new Exception("Error: No data was provided. ");
            }
            if (string.IsNullOrWhiteSpace(customer.Name) || string.IsNullOrWhiteSpace(customer.Email) || customer.IdCountry <= 0 || string.IsNullOrWhiteSpace(customer.PhoneNumber))
            {
                throw new Exception("Error: Please complete the obligatory fields. ");
            }            
            if (customer.Name.Length > 100)
            {
                throw new Exception("Error: Customer Name can not possess more than 100 characters.");
            }
            if (customer.IdBusinessSector.HasValue && customer.IdBusinessSector.Value <= 0)
            {
                throw new Exception("Error: The selected Business Sector is not valid. ");
            }
            if (customer.RegisteredName != null && customer.RegisteredName.Length > 100)
            {
                throw new Exception("Error: Customer Registered Name can not possess more than 100 characters.");
            }
            if (customer.Address != null && customer.Address.Length > 100)
            {
                throw new Exception("Error: Customer Address can not possess more than 100 characters.");
            }
            if (customer.Email.Length > 100)
            {
                throw new Exception("Error: Customer Email can not possess more than 100 characters.");
            }
            if (customer.VAT != null && customer.VAT.Length > 50)
            {
                throw new Exception("Error: Customer VAT can not possess more than 50 characters.");
            }
            if (customer.PhoneNumber.Length > 50)
            {
                throw new Exception("Error: Customer Phone Number can not posses more than 50 characters.");
            }
            if (customer.EORI != null && customer.EORI.Length > 50)
            {
                throw new Exception("Error: Customer EORI can not possess more than 50 characters.");
            }

        }
}   }
