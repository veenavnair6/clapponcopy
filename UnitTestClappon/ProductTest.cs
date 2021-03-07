using Clappon;
using Clappon.Models;
using Clappon.Repositories;
using Clappon.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestClappon
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ProductNameNullException()
        {
            Product product = new Product();
            ProductServices productServices = new ProductServices(null);           
            Assert.ThrowsException<System.ArgumentException>(()=>productServices.Add(product));
        }

        [TestMethod]
        public void ProductExistException()
        {
            Product product = new Product();
            product.ProductName = "Iphone";
            var productRepositoryMock = new Mock<IProductRepository>();
            productRepositoryMock.Setup(p => p.GetProductName(product.ProductName)).Returns(product);
            ProductServices productServices = new ProductServices(productRepositoryMock.Object);
            Assert.ThrowsException<System.ArgumentException>(() => productServices.Add(product));
        }

    }
}
