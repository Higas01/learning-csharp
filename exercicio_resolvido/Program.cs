using System;
using System.Globalization;
using exercicio_resolvido.Entities;

namespace exercicio_resolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            System.Console.Write("Enter the numbers of employee: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Employee #{i} data: ");
                System.Console.Write("Outsourced (s/n)?");
                char ch = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    System.Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

            }

            System.Console.WriteLine();
            System.Console.WriteLine("PAYMENTS");

            foreach (Employee emp in list)
            {
                System.Console.WriteLine(emp.Name + "- $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }


    }
}