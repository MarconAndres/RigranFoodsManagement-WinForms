using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess.Repositories;

namespace Business
{
    public class QualityStandartService
    {
        private readonly QualityStandartRepo _qualityStandartRepo;

        public QualityStandartService()
        {
            _qualityStandartRepo = new QualityStandartRepo();
        }

        public List<QualityStandart> GetAll()
        {
            return _qualityStandartRepo.GetAll();
        }

        public void Insert(QualityStandart qualityStandart)
        {
            if (string.IsNullOrWhiteSpace(qualityStandart.Name))
            {
                throw new Exception("Error: Please complete the fields Name.");
            }
            if (qualityStandart.Name.Length > 50 )
            {
                throw new Exception("Error: The field Name can not possess more than 50 characters. ");
            }
            if (qualityStandart.Description != null && qualityStandart.Description.Length >200)
            {
                throw new Exception("Error: The field Description can not posses more than 200 characters.");
            }

            _qualityStandartRepo.Insert(qualityStandart);
        }
    }
}
