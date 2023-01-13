using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16
{
    public class Programa
    {
        public int Duracao { get; set; }

        public string Genero { get; set; }

        public Programa()
        {
            Random r = new Random();

            string[] generos = new string[5] { "Ação", "Comedia", "Suspense", "Drama", "Terror" };
            Genero = generos[r.Next(0, 5)];

            Duracao = r.Next(90, 180);
        }


    }
}
