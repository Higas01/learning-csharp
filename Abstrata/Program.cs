using System;
using Abstrata.Entities;

namespace MyApp
{
    internal class Abstrata
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            System.Console.WriteLine("Enter the numbers of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Shape #{i} data: ");
                System.Console.Write("Rectangle or Circle (r/c)?");
            }
        }
    }
}