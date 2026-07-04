using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess.Repositories;

namespace Business
{
    public class ProductTypeService
    {
        private readonly ProductTypeRepo _productTypeRepo;

        public ProductTypeService()
        {
            _productTypeRepo = new ProductTypeRepo();
        }

        public List<ProductType> GetAll()
        {
            return _productTypeRepo.GetAll();
        }

        public void Insert(ProductType productType)
        {
            if (string.IsNullOrWhiteSpace(productType.Name))
            {
                throw new Exception("Error: Please complete the obligatory fields.");
            }
            if (productType.Name.Length > 50 )
            {
                throw new Exception("Error: The field Name can not possess more than 50 characters. ");
            }
            _productTypeRepo.Insert(productType);
        }
    }
}
