namespace Shop4Devs.Domain.Entities
{
    public sealed class Product
    {
        public Guid Id { get; private set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; } // Definir como sera armazenada
    }
}