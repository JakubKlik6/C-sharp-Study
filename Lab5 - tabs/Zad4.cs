//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
//informację ile liczb jest dodatnich, ujemnych i równych zero.


using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab;
            int n,dodatnie,ujemne,zero;

            do
            {
                Console.Write("Podaj ilość: ");
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
            dodatnie = 0;
            ujemne = 0;
            zero = 0;

            for (int i = 0; i < n; i++)
            {
                if (tab[i] < 0)
                    ujemne += 1;
                else if (tab[i] > 0)
                    dodatnie += 1;
                else if (tab[i] == 0)
                    zero += 1;

            }
            Console.WriteLine("Liczb dodatnich jest {0}", dodatnie);
            Console.WriteLine("Liczb ujemnych jest {0}", ujemne);
            Console.WriteLine("Zer jest {0}", zero);

            Console.ReadKey(true);

        }
    }
}
