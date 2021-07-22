using nestSolution.ViewModels.Catalog.Products;
using nestSolution.ViewModels.Catalog.Products.Manage;
using nestSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nestSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        public int categoryId { get; set; }

        public Task<PagedResult<ProductViewModel>> GetAllbyCategoryId(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
