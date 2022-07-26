using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaisApp
{
    public abstract class Animais
    {
        public string Especie { get; }
        public string Nome { get; set; }
        public int Idade { get; set; }        
        public string Cor { get; set; }

        public void Som() { } 

        public void Comportamento () { }

        protected Animais(string especie, string nome, int idade, string cor, string som, string comportamento)
        {
            Especie = especie;
            Nome = nome;
            Idade = idade;
            Cor = cor;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Espécie: {Especie} | Idade: {Idade} | Cor: {Cor}";
        }
    }
    
}    

