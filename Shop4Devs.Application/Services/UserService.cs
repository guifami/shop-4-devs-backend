using Shop4Devs.Application.Interfaces;
using Shop4Devs.Domain.Entities;
using Shop4Devs.Domain.Interfaces;

namespace Shop4Devs.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordService _passwordService;

        public UserService(IUserRepository userRepository, IPasswordService passwordService)
        {
            _userRepository = userRepository;
            _passwordService = passwordService;
        }

        public Task<User> GetUserById(Guid id)
        {
            return _userRepository.GetById(id);
        }

        public Task<User> GetByUsername(string username)
        {
            return _userRepository.GetByUsername(username);
        }

        public async Task CreateUser(User user)
        {
            var existingUser = await _userRepository.GetById(user.Id);

            if (existingUser != null)
                throw new Exception("Usuário já existe!");

            string passwordHash = _passwordService.HashPassword(user.Password);
            user.Password = passwordHash;

            await _userRepository.CreateUser(user);
        }
    }
}
