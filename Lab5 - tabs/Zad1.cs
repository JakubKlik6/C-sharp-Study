//8.Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych i wypisujący na ekranie
//najmniejszą i największą wczytaną liczbę.


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
            while (n <= 0 || n > 1000);

            tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]: ",i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(tab);
            Console.WriteLine("Min wynosi {0}", tab[0]);
            Console.WriteLine("Max wynosi {0}",tab[tab.Length -1]);

            Console.ReadKey(true);

        }
    }
}
