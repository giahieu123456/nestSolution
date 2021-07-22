﻿using nestSolution.ViewModels.Catalog.Products;
using nestSolution.ViewModels.Common;
using System;
using System.Threading.Tasks;

namespace nestSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        public int categoryId { get; set; }

        public Task<PagedResult<ProductViewModel>> GetAllbyCategoryId(GetPublicProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
