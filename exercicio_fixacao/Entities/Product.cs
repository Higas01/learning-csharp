using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_fixacao.Entities
{
    public class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price;
        }
    }
}