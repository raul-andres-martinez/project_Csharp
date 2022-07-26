using System;

namespace Formas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu escolha = Menu.Quadrado;
            while ((escolha = GetEscolha()) != Menu.Sair)
            {
                Forma forma = null;
                switch (escolha)
                {
                    case Menu.Quadrado:
                        forma = CriaQuadrado();
                        break;
                    case Menu.Retangulo:
                        forma = CriaRetangulo();
                        break;
                    case Menu.Triangulo:
                        forma = CriaTriangulo();
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"A área do {escolha} é {forma.Area}");
                Console.WriteLine();
            }
            Environment.Exit(0);    
        }
        public enum Menu
        {
            Sair = 0,
            Quadrado = 1,
            Retangulo = 2,
            Triangulo = 3,
        }

        public static Menu GetEscolha()
        {
            Console.WriteLine("Escolha uma figura para calcular a área: ");
            Console.WriteLine("{0} - Quadrado", (int)Menu.Quadrado);
            Console.WriteLine("{0} - Retângulo", (int)Menu.Retangulo);
            Console.WriteLine("{0} - Triângulo", (int)Menu.Triangulo);
            Console.WriteLine("{0} - Sair", (int)Menu.Sair);
            Console.Write("Escolha: ");
            string valor = Console.ReadLine();
            Menu escolha;
            if (!Enum.TryParse(valor, out escolha) || !Enum.IsDefined(typeof(Menu), escolha))
            {
                Console.WriteLine("ERRO: Opção inválida");
                return GetEscolha();
            }
            return escolha;
        }

        private static double GetDouble(string prompt)
        {
            bool Valido = false;
            double valor = 0;
            while (!Valido)
            {
                Console.Write(prompt);
                Valido = double.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }
        private static Quadrado CriaQuadrado()
        {
            double lado = GetDouble("Lado do Quadrado: ");
            return new Quadrado() { Lado = lado };

        }
        private static Retangulo CriaRetangulo()
        {
            double valorBase = GetDouble("Valor da base: ");
            double valorAltura = GetDouble("Valor da altura: ");
            return new Retangulo()
            {
                Base = valorBase,
                Altura = valorAltura,
            };

        }
        private static Triangulo CriaTriangulo()
        {
            double valorBase = GetDouble("Valor da base: ");
            double valorAltura = GetDouble("Valor da altura: ");
            return new Triangulo()
            {
                Base = valorBase,
                Altura = valorAltura,
            };
        }

    }       
}
