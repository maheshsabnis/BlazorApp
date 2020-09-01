using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int Price { get; set; }
    }

    public class Products : List<Product>
    {
        public Products()
        {
            Add(new Product() { ProductId = 101, ProductName = "Laptop", CategoryName = "Electronics", Price = 1000000 });
            Add(new Product() { ProductId = 102, ProductName = "Mixer", CategoryName = "Electrical", Price = 1000000 });
            Add(new Product() { ProductId = 103, ProductName = "Biscuts", CategoryName = "Food", Price = 1000000 });
            Add(new Product() { ProductId = 104, ProductName = "Desktop", CategoryName = "Electronics", Price = 1000000 });
            Add(new Product() { ProductId = 105, ProductName = "Solder", CategoryName = "Electrical", Price = 1000000 });
            Add(new Product() { ProductId = 106, ProductName = "Chips", CategoryName = "Food", Price = 1000000 });
            Add(new Product() { ProductId = 107, ProductName = "Router", CategoryName = "Electronics", Price = 1000000 });
            Add(new Product() { ProductId = 108, ProductName = "Fan", CategoryName = "Electrical", Price = 1000000 });
            Add(new Product() { ProductId = 109, ProductName = "Sugar", CategoryName = "Food", Price = 1000000 });
            Add(new Product() { ProductId = 110, ProductName = "DVD Writer", CategoryName = "Electronics", Price = 1000000 });
            Add(new Product() { ProductId = 111, ProductName = "Ovan", CategoryName = "Electrical", Price = 1000000 });
            Add(new Product() { ProductId = 112, ProductName = "Food Oil", CategoryName = "Food", Price = 1000000 });
            Add(new Product() { ProductId = 113, ProductName = "RAM", CategoryName = "Electronics", Price = 1000000 });
            Add(new Product() { ProductId = 114, ProductName = "Iron", CategoryName = "Electrical", Price = 1000000 });
            Add(new Product() { ProductId = 115, ProductName = "Grains", CategoryName = "Food", Price = 1000000 });
            Add(new Product() { ProductId = 116, ProductName = "Mouse", CategoryName = "Electronics", Price = 1000000 });
            Add(new Product() { ProductId = 117, ProductName = "Volt Meter", CategoryName = "Electrical", Price = 1000000 });
            Add(new Product() { ProductId = 118, ProductName = "Rice", CategoryName = "Food", Price = 1000000 });
            Add(new Product() { ProductId = 119, ProductName = "HDD", CategoryName = "Electronics", Price = 1000000 });
            Add(new Product() { ProductId = 200, ProductName = "Power Wire", CategoryName = "Electrical", Price = 1000000 });
            Add(new Product() { ProductId = 201, ProductName = "Bevarage", CategoryName = "Food", Price = 1000000 });
        }
    }
}
