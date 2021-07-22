
using nestSolution.Data.EF;
using nestSolution.ViewModels.Catalog.Products;
using nestSolution.ViewModels.Catalog.Products.Manage;
using nestSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nestSolution.Application.Catalog.Products
{
    class ManageProductService : IManageproductService
    {
        private readonly NestDbContext _context;
        public ManageProductService(NestDbContext context)
        {
            _context = context;
        }
        public Task<int> Create(ProductCreateRequest request)
        {
            throw new NotImplementedException();

        }

        public Task<int> Delete(int ProductId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }


        public Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }


        public Task<bool> UpdatePrice(int ProductId, decimal newPrice)
        {
            throw new NotImplementedException();
        }

    }
}
