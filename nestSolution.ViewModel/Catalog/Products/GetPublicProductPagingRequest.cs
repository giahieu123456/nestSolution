﻿
using nestSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace nestSolution.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
         public int? categoryId { get; set; }
    }
}
