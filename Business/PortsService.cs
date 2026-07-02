using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class PortsService
    {
        private readonly PortsRepository _portsRepo;

        public PortsService()
        {
            _portsRepo = new PortsRepository();
        }

        public List<Ports> GetAll()
        {
            return _portsRepo.GetAll();
        }

        public void Insert(Ports port)
        {
            if (string.IsNullOrWhiteSpace(port.Name))
            {
                throw new Exception("Error: Please complete the obligatory fields.");
            }
            if (port.Name.Length > 50)
            {
                throw new Exception("Error: Port Name can not possess more than 50 characters.");
            }

            if (port.IdCountry.HasValue && port.IdCountry.Value <= 0)
            {
                throw new Exception("Error: The selected Country is not correct. ");
            }
            _portsRepo.Insert(port);
        }

    }
}
