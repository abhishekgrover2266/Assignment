using Microsoft.EntityFrameworkCore;
using ProductService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductServiceAPI.Infrastructure.ProductDbContext
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext() : base() { }
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
