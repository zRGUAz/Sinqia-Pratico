using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    public class Time
    {
        public string NomePais { get; set; }
        public string NomeEsporte { get; set; }
        public int Pontuacao { get; set; }

        public Time()
        {
            Pontuacao = 0;
        }

        public void Pontuar(char resultado)
        {
            switch (resultado)
            {
                case 'W':
                    Pontuacao += 3;
                    break;

                case 'D':
                    Pontuacao += 1;
                    break;

                default:
                    break;
            }
        }
    }
}
