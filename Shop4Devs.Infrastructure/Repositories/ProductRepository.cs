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

        public async Task<IEnumerable<Product>> GetAll()
        {
            string query = "SELECT * FROM TB_PRODUTOS";
            return await _dbConnection.QueryAsync<Product>(query);
        }

        public async Task<Product> GetById(Guid? id)
        {
            string query = $"SELECT * FROM TB_PRODUTOS WHERE Id = '{id}'";

            var result = await _dbConnection.QueryFirstOrDefaultAsync<Product>(query);

            if (result == null) return null;

            return await _dbConnection.QueryFirstOrDefaultAsync<Product>(query);
        }

        #region Admin Methods
        public async Task Create(Product product)
        {
            string query = @"INSERT INTO TB_PRODUTOS 
                            (CategoryId, Name, Description, Price, Stock, Image)
                            VALUES
                            (@CategoryId, @Name, @Description, @Price, @Stock, @Image)";

            await _dbConnection.ExecuteAsync(query, product);
        }
        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
