namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SORTEIO\n");

            int qtdInscricoes;
            bool sucesso;
            do
            {
                Console.Write("Quantidade de Pessoas Inscritas: ");
                sucesso = int.TryParse(Console.ReadLine(), out qtdInscricoes);

                if (!sucesso)
                {
                    Console.WriteLine("Por Favor, digite utilizando apenas numeros\n");
                }

            } while (!sucesso);

            Sorteio sorteio = new Sorteio();
            sorteio.QtdInscricoes = qtdInscricoes;
            sorteio.SorteiaPremio();
        }
    }
}