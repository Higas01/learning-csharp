using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio
{
    public class Pensionato
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int Quarto { get; private set; }
        public Pensionato(string name, string email, int quarto)
        {
            Nome = name;
            Email = email;
            Quarto = quarto;
        }

    }
}