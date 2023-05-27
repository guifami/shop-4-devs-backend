using Shop4Devs.Domain.Entities;

namespace Shop4Devs.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(int id);

        #region Admin Methods
        Task Create(Category category);
        Task Update(Category category);
        Task Remove(int id);
        #endregion
    }
}
