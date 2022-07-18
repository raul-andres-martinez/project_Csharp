using System;

namespace CalculadoraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 1;
            int sb = 2;
            int d = 3;
            int m = 4;
            int off = 5;
            int v = 1;
            Console.WriteLine($"Digite LIGAR para ligar");
            string on = Console.ReadLine();
            while (true)
            {
                if (on == "LIGAR")
                {
                    Console.WriteLine($"\r\nDigite {s} para somar, {sb} para subtrair, {d} para dividir, {m} para multiplicar e {off} para desligar");
                    int x = Int32.Parse(Console.ReadLine());

                    if (x == 1)
                    {
                        Console.WriteLine("\r\nInforme dois valores para somar: ");
                        Console.WriteLine("\r\nValor 1 ");
                        int v1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\r\nValor 2 ");
                        int v2 = Int32.Parse(Console.ReadLine());
                        int resultadoS = Soma(v1, v2);
                        Console.WriteLine($"\r\nA soma dos dois números é {resultadoS}");

                    }
                    if (x == 2)
                    {
                        Console.WriteLine("\r\nInforme dois valores para subtrair: ");
                        Console.WriteLine("\r\nValor 1 ");
                        int v1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\r\nValor 2 ");
                        int v2 = Int32.Parse(Console.ReadLine());
                        int resultadoS = Subtracao(v1, v2);
                        Console.WriteLine($"\r\nA subtração dos dois números é {resultadoS}");
                    }
                    if (x == 3)
                    {
                        try { 
                        Console.WriteLine("\r\nInforme dois valores para multiplicar: ");
                        Console.WriteLine("\r\nValor 1 ");
                        int dividendo = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\r\nValor 2 ");
                        int divisor = Int32.Parse(Console.ReadLine());
                        int resultadoS = (Divisao(dividendo, divisor));
                        Console.WriteLine($"\r\nA multiplicação dos dois números é {resultadoS}");
                        }
                        catch (Exception o)
                        {
                            Console.WriteLine($"Erro: {o}");
                        }
                    }
                    if (x == 4)
                    {
                        Console.WriteLine("\r\nInforme dois valores para multiplicar: ");
                        Console.WriteLine("\r\nValor 1 ");
                        int v1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\r\nValor 2 ");
                        int v2 = Int32.Parse(Console.ReadLine());
                        int resultadoS = Multiplicacao(v1, v2);
                        Console.WriteLine($"\r\nA multiplicação dos dois números é {resultadoS}");
                    }
                    if (x == 5)
                    {
                        Console.WriteLine("\r\nCalculadora desligada!");
                        break;
                    }
                }else if (on != "LIGAR")
                {
                    Console.WriteLine("Comando não reconhecido, digite LIGAR!");
                    break;
                }
            }
            int Soma(int v1, int v2)
            {
                return v1 + v2;
            }
            int Subtracao(int v1, int v2)
            {
                return v1 - v2;
            }
            int Divisao(int dividendo, int divisor)
            {
                if (notZero(divisor)) throw new Exception("Divisor deve ser diferente de 0!");

                return dividendo/divisor;

                bool notZero(int divisor)
                {
                    if (divisor == 0) return true;

                    return false;
                }
                 
            }
            int Multiplicacao(int v1, int v2)
            {
                return v1 * v2;
            }
        }

    }
}