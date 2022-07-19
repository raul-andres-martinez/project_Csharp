using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animais
    {
        public Categoria Classe { get; set; }

        public string Nome { get; set; }

        public string Especie { get; set; }

        public int Idade { get; set; }

        public Animais(Categoria classe, string nome, string especie, int idade)
        {
            Classe = classe;
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"\nNome do animal: {Nome}" +
                   $"\nClasse: {Classe}" +
                   $"\nEspécie: {Especie}" +
                   $"\nIdade: {Idade}";
        }
    }


    public enum Categoria
    {
        REPTIL,
        MAMIFERO,
        ANFIBIO,
    }
}