using nestSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace nestSolution.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
         public int? categoryId { get; set; }
    }
}
