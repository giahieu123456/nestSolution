using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nestSolution.Application.Catalog.Products;
using nestSolution.ViewModels.Catalog.Products;
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
        private readonly PublicProductService _publicProductService;
        private readonly ManageProductService _mangageProductService;

        public ProductController(PublicProductService publicProductService,
            ManageProductService manageproductService)
        {
            _publicProductService = publicProductService;
            _mangageProductService = manageproductService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _publicProductService.GetAll();
            return Ok(products);
        }

        [HttpGet("public-paging")]
        public async Task<IActionResult> Get([FromQuery] GetPublicProductPagingRequest request)
        {
            var products = await _publicProductService.GetAllbyCategoryId(request);
            return Ok(products);
        }

        //http://Localhost:port/product/
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]  ProductCreateRequest request)
        {
            var productId = await _mangageProductService.Create(request);
            if (productId == 0)
                return BadRequest();

            var product = await _mangageProductService.GetById(productId);
            return CreatedAtAction( nameof(GetById), new {id = productId }, product);
        }

        //http://Localhost:port/product/productId
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(int productId)
        {
            var product = await _mangageProductService.GetById(productId);
            if (product == null)
                return BadRequest("cannot find product");
            return Ok(product);
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ProductUpdateRequest request)
        {
            var affectedResult = await _mangageProductService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }


        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _mangageProductService.Delete(productId);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

    }
}
