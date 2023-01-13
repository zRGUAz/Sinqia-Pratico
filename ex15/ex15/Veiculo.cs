using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15
{
    public abstract class Veiculo
    {
        private bool UsaCombustivel { get; set; }
        private int Rodas { get; set; }

        public Veiculo(bool usaCombustivel, int rodas)
        {
            UsaCombustivel = usaCombustivel;
            Rodas = rodas;
        }
    }
}
