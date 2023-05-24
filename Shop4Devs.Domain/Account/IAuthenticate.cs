namespace Shop4Devs.Domain.Account
{
    public interface IAuthenticate
    {
        Task<bool> LoginUser(string email, string password);
        Task<bool> RegisterUser(string email, string password);
        Task Logout();
    }
}
