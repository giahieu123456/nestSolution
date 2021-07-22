using System;
using System.Collections.Generic;
using System.Text;

namespace nestSolution.Application.Catalog.Products.Dtos.Manage
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
}
