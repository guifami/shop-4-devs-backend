using Shop4Devs.Domain.Entities;

namespace Shop4Devs.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetById(Guid id);
        Task<User> GetByUsername(string username);
        Task CreateUser(User user);
    }
}
