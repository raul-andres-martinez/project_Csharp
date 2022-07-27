using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaisApp
{
    abstract class Animal
    {
        public abstract string Comportamento();
        public abstract string Tamanho();
        public abstract string Cor();

        public string Nome { get; set; }



    }
    class Cachorro : Animal
    {
        public override string Comportamento() => "comer o sofá";
        public override string Tamanho() => "médio";

        public override string Cor() => "caramelo";

    }

    class Elefante : Animal
    {
        public override string Comportamento() => "brincar na lama";
        public override string Tamanho() => "grande";

        public override string Cor() => "cinza";

    }

    class Gato : Animal
    {
        public override string Comportamento() => "arranhar o sofá";
        public override string Tamanho() => "pequeno";
        public override string Cor() => "branco";
    }
}

