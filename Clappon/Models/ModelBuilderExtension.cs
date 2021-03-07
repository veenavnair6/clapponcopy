using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clappon.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelbuilder)
        {
            //modelbuilder.Entity<Product>().HasData(new Product { ProductId = 14, ProductName = "bhaskar2" });
        }
    }
}
