using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;
{
    
}

namespace Business
{
    public class SectorBusinessService
    {
        private readonly BusinessSectorRepository _repo;

        public SectorBusinessService()
        {
            _repo = new BusinessSectorRepository();
        }

        public List<BusinessSector> GetAll()
        {
            /*aca podemos meter logica de validacion*/
            return _repo.GetAll();
        }

        public void Insert(BusinessSector businessSector)
        {
            if (string.IsNullOrWhiteSpace(businessSector.Description))
            {
                throw new Exception ("Error: the Description of the Business Sector can not be empty.");
            }
            if (businessSector.Description.Length > 50)
            {
                throw new Exception("Error: The Description can not posses more than 50 characters.");
            }
            _repo.Insert(businessSector);
        }
    }


}
