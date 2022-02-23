// Napisz program obliczający sumę cyfr dla wczytanej z klawiatury liczby naturalnej.
// Użyj pętli while.Np.: Dla liczby = 1342 trzeba obliczyć sumę 1 + 3 + 4 + 2.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i = 0, suma = 0, iloczyn = 0;
            Console.Write("Podaj liczbę naturalną: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (++i <= n)
            {
                iloczyn = n % 10;
                suma += iloczyn;
                n = n / 10;

                if (n == 1)
                    suma += 1;
                else continue;
            }
            Console.WriteLine("Suma cyfr podanej liczby wynosi: {0}", suma);

            Console.ReadKey(true);
        }
    }
}
