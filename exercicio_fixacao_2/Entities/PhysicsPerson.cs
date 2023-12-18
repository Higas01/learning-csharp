using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_fixacao_2.Entities
{
    public class PhysicsPerson : Contributor
    {
        public double HealthSpending { get; set; }

        public PhysicsPerson(double healthSpending, string name, double annualIncome) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double CalculateTaxes()
        {
            if (base.AnnualIncome < 20000)
            {
                base.AnnualIncome *= 0.15;
                return base.AnnualIncome;

            }
            else
            {
                base.AnnualIncome *= 0.25;
                return base.AnnualIncome;
            }
        }
    }
}