
using nestSolution.Application.Catalog.Products.Dtos;
using nestSolution.Application.Catalog.Products.Dtos.Public;
using nestSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nestSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
       Task<PagedResult<ProductViewModel>> GetAllbyCategoryId(GetProductPagingRequest request);
    }
}
