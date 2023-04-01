using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagment.Application;
using ShopManagment.Application.Contracts.ProductCategory;
using ShopManagment.Domain.ProductCategoryAgg;
using ShopManagment.Infrastruct.EFCore;
using ShopManagment.Infrastruct.EFCore.Repository;
using System;

namespace ShopManagment.Configuration
{
    public class ShopManagementBoostrapper
    {
        public static void Configure(IServiceCollection services,string connectionString)
        {
            services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));
             
        }
    }
}
