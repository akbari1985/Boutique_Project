﻿using _0_FrameWork.Domain;

namespace ShopManagment.Domain.ProductCategoryAgg
{
    public class ProductCategory : EntityBase
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Picture { get; private set; }
        
        public string PictureTitle { get; private set; }

        public string PictureAlt { get; private set; }

        public string KeyWords { get; private set; }

        public string MetaDescription { get;private  set; }

        public string Slug { get;private  set; }

        public ProductCategory(string name, string description, string picture,
            string pictureTitle, string pictureAlt, string keyWords, string metaDescription, string slug)
        {
            Name = name;
            Description = description;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            KeyWords = keyWords;
            MetaDescription = metaDescription;
            Slug = slug;
        }

        public void Edit(string name, string description, string picture,
            string pictureTitle, string pictureAlt, string keyWords, string metaDescription, string slug)
        {
            Name = name;
            Description = description;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            KeyWords = keyWords;
            MetaDescription = metaDescription;
            Slug = slug;
        }
    }
}
