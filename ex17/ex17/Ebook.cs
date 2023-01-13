using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17
{
    public class Ebook : Livro
    {
        public int NumPaginas { get; set; }
        public int NumCapitulos { get; set; }

        public Ebook(string autor, int ano) : base(autor, ano)
        {
            Random r = new Random();

            NumPaginas = r.Next(100, 501);
            Console.WriteLine("Numero de Paginas: " + NumPaginas);

            NumCapitulos = r.Next(1, 21);
            Console.WriteLine("Numero de Capitulos: " + NumCapitulos);
        }
    }
}
