using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13
{
    public class SmartWatch
    {
        public int passos { get; set; }

        public void Andar()
        {
            passos++;
        }

        public void ResetOnMidnight()
        {
            passos = 0;
        }
    }
}
