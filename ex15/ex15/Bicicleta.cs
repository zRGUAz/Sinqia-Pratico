using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15
{
    public class Bicicleta : Veiculo
    {
        private bool Infantil { get; set; }

        public Bicicleta(bool usaCombustivel, int rodas) : base(usaCombustivel, rodas) 
        {
            if (rodas > 2)
            {
                Infantil = true;
            }
            else
            {
                Infantil = false;
            }
        }

    }
}
