using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_fixacao.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFree { get; private set; }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price)
        {
            CustomsFree = customsFree;
        }

        private void TotalPrice()
        {
            base.Price += CustomsFree;
        }

        public override string PriceTag()
        {
            TotalPrice();
            return base.PriceTag();
        }
    }
}