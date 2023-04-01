using _0_FrameWork.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopManagment.Application.Contracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        OperationResult Create(CreateProductCategory command);

        OperationResult Edit(EditProductCategory command);

        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);

        EditProductCategory GetDetail(long id);
    }
}
