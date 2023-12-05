using System;
using System.Globalization;
using exercicio;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Pensionato[] vect = new Pensionato[10];

            System.Console.Write("Quantos estudantes irão alugar os quartos? ");
            int totalDeEstudantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalDeEstudantes; i++)
            {
                System.Console.Write("Digite o nome do estudante: ");
                string Nome = Console.ReadLine();
                System.Console.Write("Digite o email do estudante: ");
                string Email = Console.ReadLine();
                System.Console.Write("Digite o quarto que o estudante deseja: ");
                int Quarto = int.Parse(Console.ReadLine());
                vect[Quarto] = new Pensionato(Nome, Email, Quarto);
            }
            System.Console.WriteLine("Busy rooms:");

            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i].Quarto + ":" + vect[i].Nome + ", " + vect[i].Email);
                }
            }
        }
    }
}