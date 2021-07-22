using System;
using System.Collections.Generic;
using System.Text;

namespace nestSolution.Application.Dtos
{
    public class PagingRequestBase
    {
        public int PageSize { get; set; }

        public int PageIndex { get; set; }
    }
}
