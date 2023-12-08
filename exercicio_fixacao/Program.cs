using System;
using exercicio_fixacao.Entities;

namespace exercicio_fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Camiseta", 200.00);
            Product p2 = new ImportedProduct("Camiseta", 200.00, 20);
            DateTime date = DateTime.Parse("20/07/2025");
            Product p3 = new UsedProduct("Camiseta", 200.00, date);

            System.Console.WriteLine(p1.PriceTag());
            System.Console.WriteLine(p3.PriceTag());
        }
    }
}