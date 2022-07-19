using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animais gato = new Animais(Categoria.MAMIFERO, "Erin", "Gato", 2);
            Animais iguana = new Animais(Categoria.REPTIL, "Ana", "Iguana", 7);
            Animais tartaruga = new Animais(Categoria.ANFIBIO, "Leonardo", "Tartaruga", 1);
            Animais cachorro = new Animais(Categoria.MAMIFERO, "Rex", "Cachorro", 6);

            Console.WriteLine(gato.ToString());
            Console.WriteLine(iguana.ToString());
            Console.WriteLine(tartaruga.ToString());
            Console.WriteLine(cachorro.ToString());
        }
    }
}