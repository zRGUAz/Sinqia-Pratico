using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    public class Sorteio
    {
        public int QtdInscricoes { get; set; }

        public void SorteiaPremio()
        {
            Random r = new Random();
            int vencedor = r.Next(1, QtdInscricoes+1);
            Console.WriteLine("\nO vencedor do sorteio é a pessoa com o numero de inscrição " + vencedor);
        }

    }
}
