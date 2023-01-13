using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    public class EntradaDados
    {
        public string PegaCor()
        {
            Console.Write("Cor do Carro: ");
            return Console.ReadLine();
        }

        public string PegaMarca()
        {
            Console.Write("Marca do Carro: ");
            return Console.ReadLine();
        }

        public int PegaModelo()
        {
            int modelo;
            do
            {
                Console.Write("Modelo do Carro (1 para sedan ou 2 para hatch): ");
                int.TryParse(Console.ReadLine(), out modelo);

                if (modelo != 1 && modelo != 2)
                {
                    Console.WriteLine("Opção digitada inexistente, digite 1 para sedan ou 2 para hatch\n");
                }

            } while (modelo != 1 && modelo != 2);

            return modelo;
        }

        public double PegaCapacidade()
        {
            double capacidadeDoTanque;
            bool sucesso;
            do
            {
                Console.Write("Capacidade do Tanque (em litros): ");
                sucesso = double.TryParse(Console.ReadLine(), out capacidadeDoTanque);

                if (!sucesso)
                {
                    Console.WriteLine("Por Favor, digite apenas numeros\n");
                }

            } while (!sucesso);

            return capacidadeDoTanque;
        }

        public int PegaTipoCombustivel()
        {
            int tipoDeCombustivel;
            do
            {
                Console.Write("Tipo de Combustivel (1 para gasolina, 2 para alcool e 3 para flex): ");
                int.TryParse(Console.ReadLine(), out tipoDeCombustivel);

                if (tipoDeCombustivel < 1 || tipoDeCombustivel > 3)
                {
                    Console.WriteLine("Opção digitada inexistente, digite 1 para gasolina, 2 para alcool e 3 para flex\n");
                }

            } while (tipoDeCombustivel < 1 || tipoDeCombustivel > 3);

            return tipoDeCombustivel;
        }

        public double PegaPorcentagemGasolina() 
        {
            double porcentagemGasolina;
            bool sucesso;

            do
            {
                Console.Write("\nPorcentagem de Gasolina desejada: ");
                sucesso = double.TryParse(Console.ReadLine(), out porcentagemGasolina);

                if (!sucesso)
                {
                    Console.WriteLine("Por Favor, digite apenas numeros");
                    continue;
                }

                if (porcentagemGasolina < 0 || porcentagemGasolina > 100)
                {
                    Console.WriteLine("Por Favor, digite uma porcentagem valida de 0 a 100");
                }

            } while (!sucesso || porcentagemGasolina < 0 || porcentagemGasolina > 100);

            return porcentagemGasolina;
        }

    }
}
