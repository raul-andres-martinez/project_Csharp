using System;

namespace TabuadaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Informe o número para a tabuada: ");
            int number = Int32.Parse(Console.ReadLine());

            for (x = 1; x <= 10; x++)
            {
                int result = number * x;
                Console.WriteLine("\r\n" + number + " X " + x + " = " + result);
 
            } 

        }
    }
}
