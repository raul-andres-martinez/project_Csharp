using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animals> animais = new List<Animals>();

            animais.Add(new Animals("Cachorro", "Rex", 5));
            animais.Add(new Animals("Papagaio", "Quito", 1));
            animais.Add(new Animals("Gato", "Frajola", 3));
            animais.Add(new Animals("Tartaruga", "Billy", 32));

            animais.Insert(1, new Animals("Golfinho", "Willy", 22));
            animais.RemoveAt(animais.Count - 1);
            animais.RemoveAt(1);

            foreach (Animals animal in animais)
            {
                Console.Write(animal);
            }

        }
    }
}
