using Shop4Devs.Application.Interfaces;
using Shop4Devs.Domain.Entities;
using Shop4Devs.Domain.Interfaces;

namespace Shop4Devs.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Task<Product> GetProductById(Guid id)
        {
            return _productRepository.GetById(id);
        }

        public Task CreateProduct(Product product)
        {
            return _productRepository.Create(product);
        }
    }
}
