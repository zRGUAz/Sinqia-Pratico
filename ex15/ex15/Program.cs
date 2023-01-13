namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VEICULOS\n");

            int rodas;
            bool usaCombustivel = true, sucesso;

            do
            {
                Console.Write("Quantas Rodas seu Veiculo Possui: ");
                sucesso = int.TryParse(Console.ReadLine(), out rodas);

                if (!sucesso)
                {
                    Console.WriteLine("Por Favor, Digite Apenas Numeros\n");
                }

            } while (!sucesso);

            Console.WriteLine("\nSeu Veiculo Usa Combustivel?");
            do
            {
                Console.Write("Digite S para SIM e N para NÃO: ");
                sucesso = char.TryParse(Console.ReadLine().ToUpper(), out char resposta);

                if (!sucesso || (resposta != 'S' && resposta != 'N'))
                {
                    Console.WriteLine("Opção Digitada Inexistente\n");
                    sucesso = false;
                }
                else if (resposta == 'S')
                {
                    usaCombustivel = true;
                }
                else
                {
                    usaCombustivel= false;
                }

            } while (!sucesso);

            switch (usaCombustivel)
            {
                case true:
                    Carro carro = new Carro(usaCombustivel, rodas);
                    break;

                case false:
                    Bicicleta bike = new Bicicleta(usaCombustivel, rodas);
                    break;
            }


        }
    }
}