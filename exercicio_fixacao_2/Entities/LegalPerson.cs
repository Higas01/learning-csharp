using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_fixacao_2.Entities
{
    public class LegalPerson : Contributor
    {
        public int NumbersOfEmployee { get; set; }

        public LegalPerson(string name, double annualIncome, int numbersOfEmployee) : base(name, annualIncome)
        {
            NumbersOfEmployee = numbersOfEmployee;
        }

        public override double CalculateTaxes()
        {
            if (NumbersOfEmployee > 10)
            {
                double percent = base.AnnualIncome *= 0.14;
                return base.AnnualIncome - percent;
            }
            else
            {
                double percent = base.AnnualIncome *= 0.16;
                return base.AnnualIncome - percent;
            }
        }

    }
}