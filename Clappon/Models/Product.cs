namespace Clappon.Models
{
    public class Product
    {
        /// <summary>
        /// Identifier for product entity
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Category Id of the product
        /// </summary>
        public int CategoryId { get; set; }//1:1

        /// <summary>
        /// Category
        /// </summary>
        public Category ProductCategory { get; set; }//1:many//


    }
}
