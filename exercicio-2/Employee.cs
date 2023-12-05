using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_2
{
    public class Employee
    {
        public int Id;
        public string Name;
        public double Sallary;

        public Employee(int id, string name, double sallary)
        {
            Id = id;
            Name = name;
            Sallary = sallary;
        }

        public void increaseSallary(double percentage)
        {
            double increaseAmount = Sallary * (percentage / 100);
            Sallary += increaseAmount;
        }
    }
}