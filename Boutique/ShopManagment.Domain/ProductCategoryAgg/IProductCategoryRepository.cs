﻿using _0_FrameWork.Domain;
using ShopManagment.Application.Contracts.ProductCategory;
using System.Collections.Generic;

namespace ShopManagment.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository:IRepository<long,ProductCategory>
    {

        EditProductCategory GetDetails(long id);

        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);

    }
}
