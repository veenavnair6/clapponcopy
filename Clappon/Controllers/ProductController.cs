using Clappon.Models;
using Clappon.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Clappon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductServices _productServices;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productServices"></param>
        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            try
            {
                var savedProduct = _productServices.Add(product);
                return Ok(savedProduct);
            }
            catch(Exception ex) 
            {
                return StatusCode(500);
            }
        }
    }
}
