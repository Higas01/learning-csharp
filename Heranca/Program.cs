using System;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account c1 = new Account(1001, "Alex", 500.0);
            Account c2 = new SavingsAccount(1002, "Anna", 500.0, 5.0);

            c1.Withdraw(100);
            c2.Withdraw(100);

            System.Console.WriteLine(c1.Balance);
            System.Console.WriteLine(c2.Balance);
        }
    }
}