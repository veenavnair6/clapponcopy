using Clappon.Models;
using Clappon.Repositories;
using System;
using System.Collections.Generic;

namespace Clappon.Services
{
    public class ProductServices : IProductServices
    {
        private IProductRepository _productRepository;
        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Add(Product product)
        {

            if (!string.IsNullOrEmpty(product.ProductName))
            {
                if (_productRepository.GetProductName(product.ProductName) == null)
                {
                    return _productRepository.Add(product);
                }
                else
                {
                    throw new ArgumentException("Product already exists");
                }
            }
            else
            {
                throw new ArgumentException("Product Name cannot be null");
            }
        }

        

        public void Delete(Product productChanges)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll(Product productChanges)
        {
            throw new System.NotImplementedException();
        }

        public Product Update(Product productChanges)
        {
            throw new System.NotImplementedException();
        }
    }
}
