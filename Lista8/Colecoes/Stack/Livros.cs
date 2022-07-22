using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Livros
    {
        public string Titulo { get; set; }

        public Livros(string titulo)
        {
            Titulo = titulo;
        }

        public override string ToString()
        {
            return $"{Titulo}";
        }
    }
}
