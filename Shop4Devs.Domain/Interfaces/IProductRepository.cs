using Shop4Devs.Domain.Entities;

namespace Shop4Devs.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(Guid? id);

        #region Admin Methods
        Task Create(Product product);
        Task Update(Product product);
        Task Remove(Guid id);
        #endregion
    }
}
