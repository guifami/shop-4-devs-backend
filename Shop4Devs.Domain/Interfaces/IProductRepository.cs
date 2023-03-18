using Shop4Devs.Domain.Entities;

namespace Shop4Devs.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(Guid? id);
        Task<Product> GetProductCategoryAsync(Guid? id);

        #region Admin Methods
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> RemoveAsync(Product product);
        #endregion
    }
}
