using Shop4Devs.Application.Interfaces;
using Shop4Devs.Domain.Entities;
using Shop4Devs.Domain.Interfaces;

namespace Shop4Devs.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<IEnumerable<Category>> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Task<Category> GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Task CreateCategory(Category category)
        {
            return _categoryRepository.Create(category);
        }
    }
}
