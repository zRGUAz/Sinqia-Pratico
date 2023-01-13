using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18
{
    public class CameraTraseira : Camera
    {
        public int ResolucaoAtual { get; set; }

        public CameraTraseira()
        {
            Random r = new Random();

            ResolucaoMaxima = 12;
            ResolucaoAtual = r.Next(8, 13);
        }
    }
}
