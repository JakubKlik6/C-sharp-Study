//Napisz funkcję, która wyznacza n-ty wyraz ciągu Fibonacciego zadany przez argument wywołania funkcji wartości liczby naturalnej.
//Utwórz wersję rekurencyjną tej funkcji.Napisz program testowy wykorzystujący napisaną funkcję.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static long Fb(long a)       //def funkcji rekurencyjnej
        {
            if (a == 0) return 0;
            else if (a == 1) return 1;
            else return Fb(a - 1) + Fb(a - 2);  
        }

        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj n-ty wyraz ciągu: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a < 0) Console.Write("Błędne dane");
            else Console.WriteLine("{0}-wyraz ciągu wynosi {1}",a,Fb(a));

            Console.ReadKey(true);
        }
    }
}
