using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
	public class Boletim
	{
        private string NomeDoAluno { get; set; }
        private int Ano { get; set; }
        private int Semestre { get; set; }
        private List<double> Medias { get; set; } = new List<double>(6);

        public Boletim()
        {
            EntradaDados e = new EntradaDados();

            NomeDoAluno = e.PegarNome();
            Ano = e.PegarAno();
            Semestre = e.PegarSemestre();

            for (int i = 0; i < Medias.Capacity; i++)
            {
                Console.Write($"Media da Materia {i + 1}: ");
                double media = e.PegarMedia();
                Medias.Add(media);
            }
        }
    }
}
