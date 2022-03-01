//3. Zaimplementuj funkcję rekurencyjną zadaną wzorem:
//𝑓(𝑛) = �
//𝑛 𝑑𝑙𝑎 𝑛 < 1
//1 𝑑𝑙𝑎 𝑛 = 1


using System;

namespace ConsoleApp1
{
    class Program
    {
     static int function(int n)
        {
            if (n < 0) return n;
            else if (n == 1) return 1;
            else return 2 * function(n - 1) + 1;
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj wartość funkcji f(n): ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dla f({0}) funkcja przyjmuje wartość: {1}",n,function(n));

            Console.ReadKey(true);

        }
    }
}
