using Microsoft.AspNetCore.Mvc;
using Shop4Devs.Application.Services;
using Shop4Devs.Domain.Entities;

namespace Shop4Devs.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProducts();

            if (products == null) return StatusCode(404);

            return StatusCode(200, products);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var product = await _productService.GetProductById(id);

            if (product == null) return StatusCode(404);

            return StatusCode(200, product);
        }

        #region Admin Methods
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            await _productService.CreateProduct(product);
            return StatusCode(200, $"Produto {product.Name} criado com sucesso!");
        }
        #endregion
    }
}

