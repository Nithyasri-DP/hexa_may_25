﻿using Authentication_Demo1.Models;
using Microsoft.EntityFrameworkCore;

namespace Authentication_Demo1.Contexts
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
    }
}
