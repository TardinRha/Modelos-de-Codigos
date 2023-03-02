using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetorNullable
{
    internal class Estudantes
    {
        public string Nome;
        public string Email;
        public int Quarto;

        public Estudantes(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }
        public override string ToString()
        {
            return Quarto + ": " + Nome + ", " + Email;
        }
    }
}
