using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14
{
    public class Album
    {
        private int qtdFigurinhas { get; set; }
        private bool[] FigurinhasColadas { get; set; }

        public Album()
        {
            qtdFigurinhas = 50;

            FigurinhasColadas = new bool[qtdFigurinhas];

            for (int i = 0; i < FigurinhasColadas.Length; i++)
            {
                FigurinhasColadas[i] = false;
            }
        }

        public void VerFigurinhasRestantes()
        {
            Console.WriteLine("FIGURINHAS RESTANTES");
            for (int i = 0; i < qtdFigurinhas; i++)
            {
                if (i != 0 && i % 10 == 0)
                {
                    Console.Write("\n");
                }

                if (FigurinhasColadas[i] == false)
                {
                    Console.Write((i + 1) + "\t");
                }
                else
                {
                    Console.Write("X\t");
                }
            }
            Console.WriteLine("\n");
        }

        public void ColarFigurinha()
        {
            bool sucesso;
            do
            {
                VerFigurinhasRestantes();

                Console.Write("Qual Figurinha Deseja Colar: ");
                sucesso = int.TryParse(Console.ReadLine(), out int figurinha);

                Console.Clear();

                if (!sucesso || (figurinha < 1 || figurinha > qtdFigurinhas))
                {
                    Console.WriteLine($"Essa Figurinha Não Existe, Digite uma Figurinha Existente (1 a {qtdFigurinhas})\n");
                    sucesso = false;
                }
                else if (FigurinhasColadas[figurinha - 1] == true)
                {
                    Console.WriteLine("Essa Figurinha Já Foi Colada\n");
                }
                else
                {
                    FigurinhasColadas[figurinha - 1] = true;
                    Console.WriteLine($"Figurinha {figurinha} Colada Com Sucesso!!!\n");
                }

            } while (!sucesso);

        }
    }
}
