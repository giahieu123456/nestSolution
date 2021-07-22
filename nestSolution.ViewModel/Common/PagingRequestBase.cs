using System;
using System.Collections.Generic;
using System.Text;

namespace nestSolution.ViewModels.Common
{
    public class PagingRequestBase
    {
        public int PageSize { get; set; }

        public int PageIndex { get; set; }
    }
}
