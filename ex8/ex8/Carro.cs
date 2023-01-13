using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    public class Carro
    {
        private string Cor { get; set; }
        private string Marca { get; set; }
        private int Modelo { get; set; }
        private double CapacidadeDoTanque { get; set; }
        private int TipoDeCombustível { get; set; }

        public Carro()
        {
            EntradaDados e = new EntradaDados();

            Cor = e.PegaCor();
            Marca = e.PegaMarca();
            Modelo = e.PegaModelo();
            CapacidadeDoTanque = e.PegaCapacidade();
            TipoDeCombustível = e.PegaTipoCombustivel();
        }

        public void Abastecer()
        {
            switch (TipoDeCombustível)
            {
                case 1:
                    Console.WriteLine("Enchendo o Tanque com Gasolina...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Valor total: R$" + (CapacidadeDoTanque * 5.62));
                    break;

                case 2:
                    Console.WriteLine("Enchendo o Tanque com Etanol...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Valor total: R$" + (CapacidadeDoTanque * 4.16));
                    break;

                case 3:

                    EntradaDados e = new EntradaDados();
                    double porcentagemGasolina = e.PegaPorcentagemGasolina();

                    switch (porcentagemGasolina)
                    {
                        case 100:
                            Console.WriteLine("Enchendo o Tanque com Gasolina...");
                            Thread.Sleep(2000);
                            Console.WriteLine("Valor total: R$" + (CapacidadeDoTanque * 5.62));
                            break;

                        case 0:
                            Console.WriteLine("Enchendo o Tanque com Etanol...");
                            Thread.Sleep(2000);
                            Console.WriteLine("Valor total: R$" + (CapacidadeDoTanque * 4.16));
                            break;

                        default:
                            Console.WriteLine($"Enchendo {CapacidadeDoTanque * (porcentagemGasolina / 100)}L de Gasolina...");
                            Thread.Sleep(1000);
                            Console.WriteLine($"Encehendo {CapacidadeDoTanque * ((100 - porcentagemGasolina) / 100)}L de Etanol...");
                            Thread.Sleep(1000);
                            Console.WriteLine("Valor total: R$" + ((CapacidadeDoTanque * (porcentagemGasolina / 100) * 5.62) + (CapacidadeDoTanque * ((100 - porcentagemGasolina) / 100)) * 4.16));
                            break;
                    }
                    break;
            }
        }
    }
}
