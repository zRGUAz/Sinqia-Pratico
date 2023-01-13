using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class EntradaDados
    {
        public string PegarNome()
        {
            Console.Write("Nome do Aluno: ");
            return Console.ReadLine();
        }

        public int PegarAno()
        {
            int ano;

            do
            {
                Console.Write("Ano: ");
                bool sucesso = int.TryParse(Console.ReadLine(), out ano);

                if (!sucesso)
                {
                    Console.WriteLine("Por Favor, digite um Ano valido utilizando apenas numeros\n");
                    continue;
                }

                if (ano <= 1964)
                {
                    Console.WriteLine("Por Favor, digite um Ano maior que 1964\n");
                }

            } while (ano <= 1964);

            return ano;
        }

        public int PegarSemestre()
        {
            int semestre;

            do
            {
                Console.Write("Semestre: ");
                bool sucesso = int.TryParse(Console.ReadLine(), out semestre);

                if (!sucesso)
                {
                    Console.WriteLine("Por Favor, digite um Semestre valido utilizando apenas numeros\n");
                    continue;
                }

                if (semestre < 1 || semestre > 14)
                {
                    Console.WriteLine("Por Favor, digite um Semestre de 1 a 14\n");
                }

            } while (semestre < 1 || semestre > 14);

            return semestre;
        }

        public double PegarMedia()
        {
            double media;

            do
            {
                bool sucesso = double.TryParse(Console.ReadLine(), out media);

                if (!sucesso)
                {
                    Console.WriteLine("Por Favor, digite uma Media valida utilizando apenas numeros\n");
                    Console.Write("Media: ");
                    media = -1;
                    continue;
                }

                if (media < 0 || media > 10)
                {
                    Console.WriteLine("Por Favor, digite uma Media de 0 a 10\n");
                    Console.Write("Media: ");
                }

            } while (media < 0 || media > 10);

            return media;
        }
    }
}
