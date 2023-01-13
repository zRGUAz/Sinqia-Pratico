namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TIME\n");
            Time time1  = new Time();

            Console.Write("Nome do pais: ");
            time1.NomePais = Console.ReadLine();

            Console.Write("Esporte praticado: ");
            time1.NomeEsporte = Console.ReadLine();

            int qtdPartidas;
            bool sucesso;
            do
            {
                Console.Write("Quantidade de partidas jogadas: ");
                sucesso = int.TryParse(Console.ReadLine(), out qtdPartidas);

                if (!sucesso)
                {
                    Console.WriteLine("Por Favor, digite apenas numeros\n");
                }

            } while (!sucesso);

            for (int i = 0; i < qtdPartidas; i++)
            {
                Console.WriteLine($"\nResultado da {i + 1}° partida");

                char resultado;
                do
                {
                    Console.Write("Digite W para Vitoria, L para Derrota e D para Empate: ");
                    char.TryParse(Console.ReadLine().ToUpper(), out resultado);

                    if (resultado != 'W' && resultado != 'L' && resultado != 'D')
                    {
                        Console.WriteLine("Resultado Digitado Invalido\n");
                    }

                } while (resultado != 'W' && resultado != 'L' && resultado != 'D');

                time1.Pontuar(resultado);
            }

            Console.WriteLine($"\nO resultado final do(a) {time1.NomePais} no(a) {time1.NomeEsporte} é {time1.Pontuacao}");
        }
    }
}