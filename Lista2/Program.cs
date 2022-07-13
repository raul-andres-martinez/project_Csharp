using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: ");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            float height = float.Parse(Console.ReadLine());

            float imc = weight / (height * height);

            Console.WriteLine("\r\nVocê pesa " + weight + "kg");
            Console.WriteLine("\r\nVocê mede " + height + "m");
            Console.WriteLine("\r\nSeu imc é " + Math.Round(imc, 2));

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (imc >= 18.5 && imc <= 24.9) 
            {
                Console.WriteLine("Você está com o peso normal");
            }
            else if (imc >= 25 && imc <= 29.9){
                Console.WriteLine("Você está acima do peso.");
            }
            else if (imc >= 30 && imc <= 34.9){
                Console.WriteLine("Você está com obesidade grau 1");
            }
            else if (imc >= 35 && imc <= 39.9){
                Console.WriteLine("Você está com obesidade grau 2");
            }
            else if (imc >= 40){
                Console.WriteLine("Você está com obesidade mórbida");
            }
        }
    }
}
