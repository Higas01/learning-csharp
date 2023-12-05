using System;
using System.Collections.Generic;

namespace exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários você vai cadastrar? ");
            List<Employee> list = new List<Employee>();
            int qtd = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            for (int i = 0; i < qtd; i++)
            {
                System.Console.Write("Digite o ID do funcionário: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Digite o nome do funcionário: ");
                string nome = Console.ReadLine();
                System.Console.Write("Digite o salário do funcionário: ");
                double sallary = double.Parse(Console.ReadLine());
                Employee employee = new Employee(id, nome, sallary);
                list.Add(employee);
            }

            System.Console.Write("Entre com o id do funcionário que terá o salário incrementado: ");
            int employeeId = int.Parse(Console.ReadLine());

            Employee employeeSearch = list.Find(Employee => Employee.Id == employeeId);

            if (employeeSearch != null)
            {
                employeeSearch.increaseSallary(10);

            }
            else
            {

            }



        }
    }
}