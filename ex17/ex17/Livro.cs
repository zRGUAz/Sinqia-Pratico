using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17
{
    public abstract class Livro
    {
        private string Autor { get; set; }
        private int Ano { get; set; }

        public Livro(string autor, int ano)
        {
            Autor = autor;
            Ano = ano;
        }
    }
}
