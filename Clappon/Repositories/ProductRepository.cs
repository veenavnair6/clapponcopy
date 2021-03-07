using Clappon.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clappon.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ClapponDbContext _context;

        public ProductRepository(ClapponDbContext context)
        {
            _context = context;
        }

        public Product Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public Product Update(Product productChanges)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product productChanges)
        {
            throw new NotImplementedException();
        }
        
        public List<Product> GetAll(Product productChanges)
        {
            throw new NotImplementedException();
        }

        public Product GetProductName(string productName)
        {
            return _context.Products.FirstOrDefault(p => p.ProductName == productName);
        }
    }
}
