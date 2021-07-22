

using nestSolution.ViewModels.Catalog.Products;
using nestSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nestSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
       Task<PagedResult<ProductViewModel>> GetAllbyCategoryId(GetPublicProductPagingRequest request);
    }
}
