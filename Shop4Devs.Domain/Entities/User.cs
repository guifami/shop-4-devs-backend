namespace Shop4Devs.Domain.Entities
{
    public sealed class User
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
