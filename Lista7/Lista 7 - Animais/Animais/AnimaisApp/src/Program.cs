using System;

namespace AnimaisApp.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o nome do cachorro: ");
            string cachorro = Console.ReadLine();


            Animal rex = new Cachorro();
            Console.WriteLine($"{cachorro} é {rex.Tamanho()}, de cor {rex.Cor()} e gosta de {rex.Comportamento()}");

            Console.WriteLine("Escolha o nome do elefante: ");
            string elefante = Console.ReadLine();

            Animal dumbo = new Elefante();
            Console.WriteLine($"{elefante} é {dumbo.Tamanho()}, de cor {dumbo.Cor()} e gosta de {dumbo.Comportamento()}");

            Console.WriteLine("Escolha o nome do gato: ");
            string gato = Console.ReadLine();


            Animal frajola = new Gato();
            Console.WriteLine($"{gato} é {frajola.Tamanho()}, de cor {frajola.Cor()} e gosta de {frajola.Comportamento()}");
        }
    }
}
