using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class CustomerContactService
    {
        private readonly CustomerContactRepository _customerContactRepo;

        public CustomerContactService()
        {
            _customerContactRepo = new CustomerContactRepository();
        }

        public List<CustomerContact> GetAll()
        {
            return _customerContactRepo.GetAll();
        }

        public void Insert(CustomerContact customerContact)
        {
            if (customerContact.IdCustomer <= 0 || string.IsNullOrWhiteSpace(customerContact.FirstName) || string.IsNullOrWhiteSpace(customerContact.Email))
            {
                throw new Exception("Error: Please complete the obligatorie fields. ");
            }
            if (customerContact.Email.Length >100)
            {
                throw new Exception("Error: Customer Contact Email can not possess more than 100 characters.");
            }
            if (customerContact.LastName != null && customerContact.LastName.Length > 50)
            {
                throw new Exception("Error: Customer Contact Last Name can not possess more than 50 characters.");
            }
            if (customerContact.RolePosition != null && customerContact.RolePosition.Length > 50)
            {
                throw new Exception("Error: Customer Contact Role/Position can not possess more than 50 characters. ");
            }
            if (customerContact.PhoneNumber != null && customerContact.PhoneNumber.Length > 50)
            {
                throw new Exception("Error: Customer Contact Phone Number can not possess more than 50 characters. ");
            }

            _customerContactRepo.Insert(customerContact);
        }
    }
}
