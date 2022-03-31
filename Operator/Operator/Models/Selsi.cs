using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.Models
{
    internal class Selsi
    {
        public int Degre { get; set; }
        public Selsi(int degre)
        {
Degre = degre;
        }

        public static implicit operator Kelvin(Selsi degre)
        {
            return new Kelvin(degre.Degre+273);
        }
    }
}
