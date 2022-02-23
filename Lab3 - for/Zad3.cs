//Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury. Użyj pętli for. Oto wydruk dla wysokości h=6:
1
2 4
3 6 9
4 8 12 16
5 10 15 20 25 
6 12 18 24 30 36

using System;

namespace Programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.Write("Podaj wysokość h= ");
            n = Convert.ToInt32(Console.ReadLine());		
            for (i = 1; i <= n; i++)		
            {
                for (j = 1; j <= i; j++)		
                    Console.Write("{0} ", i * j);	
                Console.WriteLine("");
            }
            Console.ReadKey(true);		
        }
    }
}
 
