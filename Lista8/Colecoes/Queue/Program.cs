using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("Jorge", "Capadocia", 47));
            pessoas.Enqueue(new Pessoa("Murilo", "São Paulo", 25));
            pessoas.Enqueue(new Pessoa("Peter", "Mississipi", 56));
            pessoas.Enqueue(new Pessoa("Pablo", "Madrid", 61));
            pessoas.Enqueue(new Pessoa("Nathalia", "São Petersburgo", 16));

            Console.WriteLine("O primeiro da fila é " + pessoas.Dequeue());
            pessoas.Peek();
            Console.WriteLine($"{pessoas.Count} na fila");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }

        }
    }
}
