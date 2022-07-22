using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, string cidade, int idade)
        {
            Nome = nome;
            Cidade = cidade;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"{Nome} | {Cidade} | {Idade} anos";

        }
    }
}
