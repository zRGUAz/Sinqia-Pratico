using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16
{
    public class Filme : Programa
    {
        public Filme()
        {
            Random r = new Random();

            Console.WriteLine("Genero: " + Genero);
            Console.WriteLine($"Duração: {Duracao}m" );
        }
    }
}
