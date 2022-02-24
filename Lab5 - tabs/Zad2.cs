//Napisać program wczytujący ciąg n (1<=n<=1000) liczb naturalnych i wypisujący na ekranie
//wszystkie parzyste liczby w kolejności niemalejącej. Do wypisywania elementów tablicy użyj
//pętli foreach.
//Wskazówka: Posortuj wczytane liczby, a następnie z tablicy wypisz tylko liczby parzyste.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab;
            int n;

            do
            {
                Console.Write("Podaj liczbę: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while ((n <= 0) || (n > 1000));

            tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(tab);
            foreach (int num in tab)
                if (num % 2 == 0)
                    Console.WriteLine("{0} ",num);
        }
    }
}
