using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp5.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public List<Product> Product { get; set; } = new List<Product>();

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {

            return Price * Quantity;
        }

        public void AddProduct(Product product)
        {
            Product.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Product.Remove(product);
        }
    }
}