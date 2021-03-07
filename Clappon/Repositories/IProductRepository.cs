using Clappon.Models;
using System.Collections.Generic;

namespace Clappon.Repositories
{
    /// <summary>
    /// Interface for product services
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Add Products
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Product Add(Product product);

        /// <summary>
        /// Update the product Details
        /// </summary>
        /// <param name="productChanges"></param>
        /// <returns></returns>
        Product Update(Product productChanges);

        /// <summary>
        /// Delete the product
        /// </summary>
        /// <param name="productChanges"></param>
        void Delete(Product productChanges);

        /// <summary>
        /// get all products
        /// </summary>
        /// <param name="productChanges"></param>
        /// <returns></returns>
        List<Product> GetAll(Product productChanges);

        Product GetProductName(string productName);
    }
}
