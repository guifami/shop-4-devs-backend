﻿namespace Shop4Devs.Domain.Entities
{
    public sealed class Product
    {
        public Guid Id { get; private set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public byte[] Image { get; set; }
    }
}