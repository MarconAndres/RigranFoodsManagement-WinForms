using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;

namespace Business
{
    public class ContainerTypeService
    {
        private readonly ContainerTypeRepository _repo;

        public ContainerTypeService()
        {
            _repo = new ContainerTypeRepository();
        }

        public List<ContainerType> GetAll()
        {
            return _repo.GetAll();
        }

        public void Insert(ContainerType containerType)
        {
            if (string.IsNullOrWhiteSpace(containerType.Code) || string.IsNullOrWhiteSpace(containerType.Description))
            {
                throw new Exception("Error ContainerType Code or Description can not be empty. ");
            }
            if(containerType.Code.Length > 10)
            {
                throw new Exception("Error: The Container Code can not possess more than 10 characters. ");
            }
            if (containerType.Description.Length > 50)
            {
                throw new Exception("Error: The Container Description can not possess more than 50 characters.");
            }
            _repo.Insert(containerType);
        }
    }
}
