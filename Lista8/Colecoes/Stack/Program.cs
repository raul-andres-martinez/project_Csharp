using System;
using System.Collections.Generic;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Livros> livros = new Stack<Livros>();
            livros.Push(new Livros("Harry Potter"));
            livros.Push(new Livros("Senhor dos Anéis"));
            livros.Push(new Livros("Jogos Vorazes"));

            Console.WriteLine("\nPrimeiro livro: " + livros.Peek());
            livros.Pop();
            Console.WriteLine($"\nA pilha possui {livros.Count} livros");

            foreach(Livros livro in livros)
            {
                Console.WriteLine(livro);
            }
        }
    }
}
