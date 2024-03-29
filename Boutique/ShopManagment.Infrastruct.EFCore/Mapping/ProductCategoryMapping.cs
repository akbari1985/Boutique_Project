﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagment.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopManagment.Infrastruct.EFCore.Mapping
{
    public class ProductCategoryMapping : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x=>x.Description).HasMaxLength(500);
            builder.Property(x=>x.Picture).HasMaxLength(1000);
            builder.Property(x=>x.PictureAlt).HasMaxLength(255);
            builder.Property(x=>x.PictureTitle).HasMaxLength(500);
            builder.Property(x=>x.KeyWords).HasMaxLength(80).IsRequired();
            builder.Property(x=>x.MetaDescription).HasMaxLength(150).IsRequired();
            builder.Property(x=>x.Slug).HasMaxLength(300).IsRequired();




        }
    }
}
