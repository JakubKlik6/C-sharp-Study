//Napisz funkcję, która oblicza wartość silni z zadanej przez argument wywołania funkcji wartości liczby naturalnej.Utwórz wersję rekurencyjną tej funkcji.
//Napisz program testowy wykorzystujący napisaną funkcję

using System;

namespace ConsoleApp1
{
    class Program
    {
        static long silnia(int a)       //def funkcji rekurencyjnej
        {
            if (a == 0) return 1;
            else return a * silnia(a - 1);
        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Podaj liczbę: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}!={1}",n,silnia(n));
            } 
            while (n > 0);
        }
    }
}
