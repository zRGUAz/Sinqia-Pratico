using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17
{
    public class AudioBook : Livro
    {
        public int Duracao { get; set; }

        public AudioBook(string autor, int ano) : base(autor, ano)
        {
            Random r = new Random();

            Duracao = r.Next(30, 420);
            Console.WriteLine($"Duração do AudioBook: {Duracao}m");

        }
    }
}
