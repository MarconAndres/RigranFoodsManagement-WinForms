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
        private void ValidatePort(Ports port)
        {
            if (port == null)
            {
                throw new Exception("Error: No data was provided.");
            }
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

        }
        public void Insert(Ports port)
        {
            ValidatePort(port);
            _portsRepo.Insert(port);
        }
        public void Update(Ports port)
        {
            ValidatePort(port);
            if (port.ID <= 0)
            {
                throw new Exception("Error: The Port you are trying to modify does not have a valid ID.");
            }
            _portsRepo.Update(port);
        }

        public Ports GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return null;
                }

                return _portsRepo.GetById(id);
            }
            catch (Exception ex)
            {

                throw new Exception("Error while trying to Get by ID" + ex.Message);
            }
        }
    }
}
