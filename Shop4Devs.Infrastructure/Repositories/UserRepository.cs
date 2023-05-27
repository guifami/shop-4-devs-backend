using Dapper;
using Shop4Devs.Domain.Entities;
using Shop4Devs.Domain.Interfaces;
using System.Data;

namespace Shop4Devs.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _dbConnection;

        public UserRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<User> GetById(Guid id)
        {
            string query = $"SELECT * FROM TB_USUARIOS WHERE Id = '{id}'";

            var result = await _dbConnection.QueryFirstOrDefaultAsync<User>(query);

            if (result == null) return null;

            return await _dbConnection.QueryFirstOrDefaultAsync<User>(query);
        }

        public async Task<User> GetByUsername(string username)
        {
            string query = $"SELECT * FROM TB_USUARIOS WHERE Name = '{username}'";

            var result = await _dbConnection.QueryFirstOrDefaultAsync<User>(query);

            if (result == null) return null;

            return await _dbConnection.QueryFirstOrDefaultAsync<User>(query);
        }

        public async Task CreateUser(User user)
        {
            string query = @"INSERT INTO TB_USUARIOS 
                            (Name, Email, Password)
                            VALUES
                            (@Name, @Email, @Password)";

            await _dbConnection.ExecuteAsync(query, user);
        }
    }
}
