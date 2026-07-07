using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess.Repositories;

namespace Business
{
    public class ProductSpecificationsService
    {
        private readonly ProductSpecificationsRepo _productSpecificationsRepo;

        public ProductSpecificationsService()
        {
            _productSpecificationsRepo = new ProductSpecificationsRepo();
        }

        public List<ProductSpecifications> GetAll()
        {
            return _productSpecificationsRepo.GetAll();
        }
        private void ValidateProductSpecifications(ProductSpecifications productSpecifications)
        {
            if (productSpecifications == null)
            {
                throw new Exception("Error: No data was provided.");
            }
            if (!productSpecifications.IdProductMaster.HasValue || productSpecifications.IdProductMaster.Value <= 0 || string.IsNullOrWhiteSpace(productSpecifications.Size) || string.IsNullOrWhiteSpace(productSpecifications.TotalDamage))
            {
                throw new Exception("Error: Please complete the obligatory fields.");
            }
            if (productSpecifications.Size.Length > 20)
            {
                throw new Exception("Error: The field Size can not possess more than 20 characters.");
            }
            if (productSpecifications.TotalDamage.Length > 20)
            {
                throw new Exception("Error: The field Total Damage can not possess more than 20 characters.");
            }
            if (productSpecifications.Moisture != null && productSpecifications.Moisture.Length > 20)
            {
                throw new Exception("Error: The field Moisture can not possess more than 20 characters.");
            }
            if (productSpecifications.SplitAndBroken != null && productSpecifications.SplitAndBroken.Length > 20)
            {
                throw new Exception("Error: The field Split & Broken can not possess more than 20 characters.");
            }
            if (productSpecifications.Foreignmatter != null && productSpecifications.Foreignmatter.Length > 20)
            {
                throw new Exception("Error: The field Foreignmatter can not posses more than 20 characters.");
            }
            if (productSpecifications.Purity != null && productSpecifications.Purity.Length > 20)
            {
                throw new Exception("Error: The field Purity can not possess more than 20 charaters. ");
            }

        }
        public void Insert (ProductSpecifications productSpecifications)
        {
            ValidateProductSpecifications(productSpecifications);
            _productSpecificationsRepo.Insert(productSpecifications);
        }
        public void Update (ProductSpecifications productSpecifications)
        {
            ValidateProductSpecifications(productSpecifications);
            if (productSpecifications.ID <= 0)
            {
                throw new Exception("Error: The Product Specification you are trying to modify does not have a valid ID.");
            }
            _productSpecificationsRepo.Update(productSpecifications);
        }
    }
}
