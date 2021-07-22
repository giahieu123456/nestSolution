using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nestSolution.Application.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nestSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;

        public ProductController(IPublicProductService PublicProductService)
        {
            _publicProductService = PublicProductService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("test ok");
        }
    }
}
