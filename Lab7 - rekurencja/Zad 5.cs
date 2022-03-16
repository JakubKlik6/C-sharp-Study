//Zaimplementuj wersję rekurencyjną algorytmu Euklidesa umożliwiającego obliczenie 
//największego wspólnego dzielnika. Przetestuj utworzoną funkcję rekurencyjną.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static int euk(int a, int b)
        {
            if (b == 0) return a;
            else return euk(b, a % b);
        }

        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Największy wspólny dzielnich podanych liczb wynosi: {0}",euk(a,b));

            Console.ReadKey(true);
        }
    }
}
