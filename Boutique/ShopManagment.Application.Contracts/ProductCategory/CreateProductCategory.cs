﻿using _0_FrameWork.Application;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopManagment.Application.Contracts.ProductCategory
{
    public class CreateProductCategory
    {
        [Required (ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get;  set; }

        public string Description { get;  set; }

        public string Picture { get;  set; }

        public string PictureTitle { get;  set; }

        public string PictureAlt { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string KeyWords { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get;  set; }
    }
}
