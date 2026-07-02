using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class IncoTermService
    {
        private readonly IncoTermRepository _incoTermRepo;

        public IncoTermService()
        {
            _incoTermRepo = new IncoTermRepository();
        }

        public List<IncoTerm> GetAll()
        {
            return _incoTermRepo.GetAll();
        }

        public void Insert(IncoTerm incoTerm)
        {
            if (string.IsNullOrWhiteSpace(incoTerm.Code) || string.IsNullOrWhiteSpace(incoTerm.Description))
            {
                throw new Exception("Error: Please complete the obligatory fields. ");
            }
            if (incoTerm.Code.Length > 3)
            {
                throw new Exception("Error: IncoTerm Code can not possess more than 3 characters.");
            }
            if (incoTerm.Description.Length > 150)
            {
                throw new Exception("Error: IncoTerm Description can not possess more than 150 characters.");
            }
            _incoTermRepo.Insert(incoTerm);
        }
    }
}
