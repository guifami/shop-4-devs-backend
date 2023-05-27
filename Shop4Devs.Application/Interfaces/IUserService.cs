using Shop4Devs.Domain.Entities;

namespace Shop4Devs.Application.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserById(Guid id);
        Task<User> GetByUsername(string username);
        Task CreateUser(User user);
    }
}
