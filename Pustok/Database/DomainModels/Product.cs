﻿namespace Pustok.Database.DomainModels
{
    public class Product
    {
        public Product()
        {
            Id = ++DbContext._productId;
        }

        public Product(int id, string name, string description, string color, string size, decimal price)
        {
            Id = ++DbContext._productId;
            Name = name;
            Description = description;
            Color = color;
            Size = size;
            Price = price; 
        }

        public int Id { get; set; } 

        public string Name { get; set; }

        public string Description { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public decimal Price { get; set; }

    }
}
