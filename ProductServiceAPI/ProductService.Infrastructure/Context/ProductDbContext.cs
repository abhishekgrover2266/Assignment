﻿using Microsoft.EntityFrameworkCore;
using ProductService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Infrastructure.Context
{
    public class ProductDbContext : DbContext
        {
            public ProductDbContext() : base() { }
            public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
            {
            }

            public DbSet<Product> Products { get; set; }
    }
}
