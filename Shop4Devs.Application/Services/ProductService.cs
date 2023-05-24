using Shop4Devs.Domain.Entities;
using Shop4Devs.Domain.Interfaces;

namespace Shop4Devs.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllAsync();
        }
    }
}
