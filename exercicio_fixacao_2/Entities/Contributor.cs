using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_fixacao_2.Entities
{
    public abstract class Contributor
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Contributor(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double CalculateTaxes();

    }
}