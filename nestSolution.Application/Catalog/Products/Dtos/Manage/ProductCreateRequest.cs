using System;
using System.Collections.Generic;
using System.Text;

namespace nestSolution.Application.Catalog.Products.Dtos.Manage
{
    public class ProductCreateRequest
    {
        public string name { get; set; }
        public int price { get; set; }
    }
}
