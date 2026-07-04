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

        public void Insert (ProductSpecifications productSpecifications)
        {
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
                throw new Exception("Error: The field Total Damage can not possess more than 20 charaters.");
            }
            if (productSpecifications.Moisture != null && productSpecifications.Moisture.Length > 20)
            {
                throw new Exception("Error: The field Mositure can not possess more than 20 characters.");
            }
            if (productSpecifications.SplitAndBroken != null && productSpecifications.SplitAndBroken.Length > 20)
            {
                throw new Exception("Error: The field Split & Broken can not possess more than 20 characters.");
            }
            if (productSpecifications.Foreignmatter != null && productSpecifications.Foreignmatter.Length >20)
            {
                throw new Exception("Error: The field Foreignmatter can not posses more than 20 characters.");
            }
            if (productSpecifications.Purity != null && productSpecifications.Purity.Length > 20)
            {
                throw new Exception("Error: The field Purity can not possess more than 20 charaters. ");
            }

            _productSpecificationsRepo.Insert(productSpecifications);
        }
    }
}
