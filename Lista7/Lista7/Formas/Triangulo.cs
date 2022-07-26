using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    internal class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double Area => (this.Base * this.Altura / 2);
    }
}
