//Napisz program obliczający wartość n!(n silnia, n != 1 * 2 *…*n) dla wczytanej z klawiatury
//liczby naturalnej n.Użyj pętli while.Np.: dla n = 5 wypisz wynik 5 != 120.

using System;

namespace Programowanie
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i = 1, iloczyn = 1;
            Console.Write("Podaj liczbę: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (++i <= n) 
            {
                iloczyn *= i;
            }
            Console.WriteLine("{0}! = {1}",n,iloczyn);

            Console.ReadKey(true);

        }
    }
}
 
