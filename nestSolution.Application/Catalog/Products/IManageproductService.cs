
using nestSolution.ViewModels.Catalog.Products;
using nestSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nestSolution.Application.Catalog.Products
{
    public interface IManageproductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update( ProductUpdateRequest request);

        Task<bool> UpdatePrice(int ProductId, decimal newPrice);

        Task<int> Delete(int ProductId);

        Task<List<ProductViewModel>>GetAll();

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
       
    }
}
