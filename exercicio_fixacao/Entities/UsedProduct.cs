using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_fixacao.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manuFactureDate) : base(name, price)
        {
            ManufactureDate = manuFactureDate;
        }

        public override string PriceTag()
        {
            return base.Name + " (used) $ " + base.Price + " Manufacture date: " + ManufactureDate;
        }
    }
}