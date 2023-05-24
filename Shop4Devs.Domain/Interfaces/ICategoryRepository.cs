using Shop4Devs.Domain.Entities;

namespace Shop4Devs.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllAsync();
        Task<Category> GetByIdAsync(Guid id);

        #region Admin Methods
        Task<Category> CreateAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<Category> RemoveAsync(Category category);
        #endregion
    }
}
