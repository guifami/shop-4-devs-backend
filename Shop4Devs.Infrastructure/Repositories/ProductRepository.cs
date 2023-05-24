using Dapper;
using Shop4Devs.Domain.Entities;
using Shop4Devs.Domain.Interfaces;
using System.Data;

namespace Shop4Devs.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Product> GetAllAsync()
        {
            string query = "SELECT * FROM TB_PRODUTOS";
            return _dbConnection.Query<Product>(query);
        }

        public Task<Product> CreateAsync(Product product)
        {
            throw new NotImplementedException();
        }


        public Task<Product> GetByIdAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductCategoryAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> RemoveAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
