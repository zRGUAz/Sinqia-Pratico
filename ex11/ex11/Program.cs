namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurante restaurante = new Restaurante();

            char resposta;
            do
            {
                Console.Clear();
                Console.WriteLine("NOVO PEDIDO\n");

                Console.Write("Informe a cidade em que mora: ");
                string cidade = Console.ReadLine();

                restaurante.EntregaPedido(cidade);

                Console.WriteLine("\nGostaria de fazer outro pedido?");
                bool sucesso;
                do
                {
                    Console.Write("Digite S para SIM ou Qualquer outra tecla para NÃO: ");
                    sucesso = char.TryParse(Console.ReadLine().ToUpper(), out resposta);

                    if (!sucesso)
                    {
                        Console.WriteLine("Por Favor, digite apenas um caracter para responder\n");
                    }

                } while (!sucesso);


            } while (resposta == 'S');
        }
    }
}