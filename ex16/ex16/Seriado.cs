using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16
{
    public class Seriado : Programa
    {
        public int NumeroEpisodios { get; set; }
        public int AnoInicio { get; set; }
        public int AnoFim { get; set; }

        public Seriado()
        {
            Random r = new Random();

            Console.WriteLine("Genero: " + Genero);

            NumeroEpisodios = r.Next(1, 101);
            Console.WriteLine("Numero de Episodios: " + NumeroEpisodios);

            AnoInicio = r.Next(2000, 2022);
            Console.WriteLine("Ano de Inicio: " + AnoInicio);

            AnoFim = r.Next(AnoInicio, 2023);
            Console.WriteLine("Ano de Fim: " + AnoFim);
        }
    }
}
