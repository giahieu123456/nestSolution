using nestSolution.Application.Catalog.Products.Dtos;
using nestSolution.Application.Catalog.Products.Dtos.Public;
using nestSolution.Application.Dtos;
using nestSolution.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nestSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        private readonly NestDbContext _context;
        public PublicProductService(NestDbContext context)
        {
            _context = context;
        }
        Task<PagedResult<ProductViewModel>> IPublicProductService.GetAllbyCategoryId(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
