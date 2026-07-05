using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class StatusService
    {
        private readonly StatusRepository _statusRepo;

        public StatusService()
        {
            _statusRepo = new StatusRepository();
        }

        public List<Status> GetAll()
        {
            return _statusRepo.GetAll();
        }

        private void ValidateStatus(Status status)
        {
            if (status == null)
            {
                throw new Exception("Error: No data was provided.");
            }
            if (string.IsNullOrWhiteSpace(status.Name))
            {
                throw new Exception("Error: Please complete the field Status Name");
            }
            if (!string.IsNullOrWhiteSpace(status.Name) && status.Name.Length > 30)
            {
                throw new Exception("Error: The field Name can not possess more than 30 characters. ");
            }
        }
    }
}
