using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Animals
    {
        public string Especie { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animals(string especie, string nome, int idade)
        {
            Especie = especie;
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"\nNome do animal: {Nome}" +
                   $"\nEspécie: {Especie}" +
                   $"\nIdade: {Idade}" +
                   "\n";
        }
    }
}
