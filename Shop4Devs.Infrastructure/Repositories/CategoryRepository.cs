using Dapper;
using Shop4Devs.Domain.Entities;
using Shop4Devs.Domain.Interfaces;
using System.Data;

namespace Shop4Devs.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbConnection _dbConnection;

        public CategoryRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            string query = "SELECT * FROM TB_CATEGORIAS";
            return await _dbConnection.QueryAsync<Category>(query);
        }

        public async Task<Category> GetById(int id)
        {
            string query = $"SELECT * FROM TB_CATEGORIAS WHERE Id = {id}";

            var result = await _dbConnection.QueryFirstOrDefaultAsync<Category>(query);

            if (result == null) return null;

            return await _dbConnection.QueryFirstOrDefaultAsync<Category>(query);
        }

        #region Admin Methods
        public async Task Create(Category category)
        {
            string query = @"INSERT INTO TB_CATEGORIAS (Name) VALUES (@Name)";

            await _dbConnection.ExecuteAsync(query, category);
        }

        public Task Update(Category category)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
