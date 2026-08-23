using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess.Repositories;

namespace Business
{
    public class ProductMasterService
    {
        private readonly ProductMasterRepo _productMasterRepo;

        public ProductMasterService()
        {
            _productMasterRepo = new ProductMasterRepo();
        }

        public List<ProductMaster> GetAll()
        {
            return _productMasterRepo.GetAll();
        }

        public void Insert(ProductMaster productMaster)
        {
            ValidateProductMaster(productMaster);
            _productMasterRepo.Insert(productMaster);
        }

        public void Update(ProductMaster productMaster)
        {
            if (productMaster.ID <= 0)
            {
                throw new Exception("Error: The Product Master you are trying to modify does not have a valid ID.");
            }
            ValidateProductMaster(productMaster);
            _productMasterRepo.Update(productMaster);
        }

        private void ValidateProductMaster(ProductMaster productMaster)
        {
            if (productMaster == null)
            {
                throw new Exception("Error: No data was provided.");
            }
            if (!productMaster.IdProductType.HasValue || productMaster.IdProductType.Value <= 0)
            {
                throw new Exception("Error: Please select a Product Type.");
            }
            if (string.IsNullOrWhiteSpace(productMaster.Name))
            {
                throw new Exception("Error: Please complete the field Name.");
            }
            if (productMaster.Name.Length > 100)
            {
                throw new Exception("Error: The field Name can not possess more than 100 charaters.");
            }
        }
        public ProductMaster GetById(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Error: The Product Master ID provided is not valid.");
            }
            return _productMasterRepo.GetById(id);
        }
    }   
}