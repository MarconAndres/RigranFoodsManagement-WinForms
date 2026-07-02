using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class MethodOfPaymentService
    {
        private readonly MethodOfPaymentRepo _repo;

        public MethodOfPaymentService()
        {
            _repo = new MethodOfPaymentRepo();
        }

        public List<MethodOfPayment> GetAll()
        {
            return _repo.GetAll();
        }

        public void Insert(MethodOfPayment methodOfPayment)
        {
            if (string.IsNullOrWhiteSpace(methodOfPayment.Code) || string.IsNullOrWhiteSpace(methodOfPayment.Description))
            {
                throw new Exception("Error: Please complete the obligatory fields.");
            }

            if (methodOfPayment.Code.Length > 30)
            {
                throw new Exception("Error: The Code can not possess more than 30 characters.");
            }

            if (methodOfPayment.Description.Length > 100)
            {
                throw new Exception("Error: The Description can not possess more than 100 characters.");
            }

            _repo.Insert(methodOfPayment);
        }
    }
}
