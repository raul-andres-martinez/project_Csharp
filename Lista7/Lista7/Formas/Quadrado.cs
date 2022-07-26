using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    internal class Quadrado : Forma
    {
        public double Lado { get; set; }
        public override double Area => this.Lado * this.Lado;
    }
}
