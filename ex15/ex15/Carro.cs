using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15
{
    public class Carro : Veiculo 
    {
        private int TipoDeCombustivel { get; set; }

        public Carro(bool usaCombustivel, int rodas) : base(usaCombustivel, rodas) 
        {
            Console.WriteLine("\nQue Combustivel Seu Veiculo Usa?");
            do
            {
                Console.Write("Digite 1 para Gasolina, 2 para Alcool e 3 para Flex: ");
                int.TryParse(Console.ReadLine(), out int tipoDeCombustivel);

                if (tipoDeCombustivel < 1 || tipoDeCombustivel > 3)
                {
                    Console.WriteLine("Opção Digitada Inexistente\n");
                }
                else
                {
                    TipoDeCombustivel = tipoDeCombustivel;
                }

            } while (TipoDeCombustivel < 1 || TipoDeCombustivel > 3);
        }
        
    }
}
