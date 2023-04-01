using Microsoft.EntityFrameworkCore;
using ShopManagment.Domain.ProductCategoryAgg;
using ShopManagment.Infrastruct.EFCore.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopManagment.Infrastruct.EFCore
{
    public class ShopContext:DbContext
    {
        public DbSet<ProductCategory> productCategories { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly=typeof(ProductCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
