using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    public class Restaurante
    {
        private string Cidade { get; set; }
        private bool Delivery { get; set; }
        private int PedidosPendentes { get; set ; }
        private int TempoEntrega { get; set; }

        public Restaurante()
        {
            Cidade = "Santo Andre";
            PedidosPendentes = 0;
        }

        public void EntregaPedido(string cidade)
        {
            Delivery = Cidade.Equals(cidade, StringComparison.OrdinalIgnoreCase);

            if (!Delivery)
            {
                Console.WriteLine("Desculpe, mas so fazemos entrega em " + Cidade);
            }
            else
            {
                Console.WriteLine("\nPedido aceito e encaminhado para produção");
                TempoEntrega = 10 + 2 * PedidosPendentes;
                Console.WriteLine($"Tempo estimado de entrega {TempoEntrega} minutos");
                PedidosPendentes++;
            }
        }
    }
}
