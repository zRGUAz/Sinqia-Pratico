namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Não entendi como esse exercicio ajuda com POO

            SmartWatch sw = new SmartWatch();

            bool andar; //Um exemplo de como um verdadeiro pedometro contabiliza os passos de uma pessoa
            int horario = 1;
            char resposta;
            do //reseta ciclo todo dia
            {
                Console.Clear();
                Console.WriteLine("PEDOMETRO DIARIO\n");

                //teste 24h pra ver se a pessoa anda
                if (andar = true)
                {
                    sw.Andar();
                }

                Console.WriteLine("Passos Diarios: " + sw.passos);

                //Meia noite reseta os passos
                if (horario == 0)
                {
                    sw.ResetOnMidnight();
                }

                Console.WriteLine("\nFechar APP?");
                bool sucesso;
                do
                {
                    Console.WriteLine("Digite S para SIM ou Qualquer Tecla para Continuar Usando o APP: ");
                    sucesso = char.TryParse(Console.ReadLine().ToUpper(), out resposta);

                    if (!sucesso)
                    {
                        Console.WriteLine("Por Favor, utilizar apenas um caracter\n");
                    }

                } while (!sucesso);

            } while (resposta != 'S');
        }
    }
}