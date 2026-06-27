using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;
using Entities;
{
    
}

namespace Business
{
    public class BusinessSectorBusiness
    {
        private readonly BusinessSectorRepository _repo = new BusinessSectorRepository();

        public List<BusinessSector> ListSectors()
        {
            /*aca podemos meter logica de validacion*/
            return _repo.GetAll();
        }

        public void InsertSector (BusinessSector businessSector)
        {
            if (string.IsNullOrWhiteSpace(businessSector.Description))
            {
                throw new Exception("Error: the Description of the Business Sector can not be empty.");
            }
            _repo.Insert(businessSector);
        }
    }


}
