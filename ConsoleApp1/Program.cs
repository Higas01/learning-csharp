using System;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500, 10);
            System.Console.WriteLine(p.Nome);
        }
    }
}