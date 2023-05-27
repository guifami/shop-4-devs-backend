using Shop4Devs.Domain.Entities;

namespace Shop4Devs.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(Guid id);
        Task CreateProduct(Product product);
    }
}
