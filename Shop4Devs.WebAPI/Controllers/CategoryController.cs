using Microsoft.AspNetCore.Mvc;
using Shop4Devs.Application.Interfaces;
using Shop4Devs.Domain.Entities;

namespace Shop4Devs.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategories();

            if (categories == null) return StatusCode(404);

            return StatusCode(200, categories);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _categoryService.GetCategoryById(id);

            if (category == null) return StatusCode(404);

            return StatusCode(200, category);
        }

        #region Admin Methods
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Category category)
        {
            await _categoryService.CreateCategory(category);
            return StatusCode(200, $"Categoria {category.Name} criada com sucesso!");
        }
        #endregion
    }
}
