
using nestSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace nestSolution.ViewModels.Catalog.Products.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
         public int? categoryId { get; set; }
    }
}
