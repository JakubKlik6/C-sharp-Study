//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
//sumę kwadratów wczytanych liczb.


using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab;
            int n, suma = 0;

            do
            {
                Console.Write("Podaj ilość: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while ((n <= 0) || (n > 1000));

            tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]: ",i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
                suma += tab[i] * tab[i];
            }
            Console.WriteLine("Suma wczytanych liczb wynosi: {0}",suma);
        }
    }
}
