using _0_FrameWork.Application;
using ShopManagment.Application.Contracts.ProductCategory;
using ShopManagment.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;

namespace ShopManagment.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();

            if (_productCategoryRepository.Exists(x=>x.Name== command.Name))
                return operation.Failed("رکورد از قبل موجود است");

            var productCategory = new ProductCategory(command.Name, command.Description, command.Picture
                , command.PictureAlt, command.PictureTitle, command.Slug, command.KeyWords, command.MetaDescription);

            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.SaveChanges();
            return operation.Succedde();

        }

        public OperationResult Edit(EditProductCategory command)
        {
            var operation = new OperationResult();
            var productCategory = _productCategoryRepository.Get(command.Id);
            if (productCategory == null)
                return operation.Failed("رکورد با اطلاعات درخواست شده یافت نشد");
            if (_productCategoryRepository.Exists(x=>x.Name==command.Name && x.Id !=command.Id))
                return operation.Failed("رکورد از قبل موجود است");
            
            productCategory.Edit(command.Name, command.Description, command.Picture
                , command.PictureAlt, command.PictureTitle, command.Slug, command.KeyWords, command.MetaDescription);

            _productCategoryRepository.SaveChanges();

            return operation.Succedde();
        }

        public EditProductCategory GetDetail(long id)
        {
            return _productCategoryRepository.GetDetails(id);
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _productCategoryRepository.Search(searchModel);
        }
    }
}
