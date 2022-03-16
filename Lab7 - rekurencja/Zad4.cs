//Dany jest ciąg rekurencyjny: �
//𝑎1 = 1
//𝑎𝑛+1 = (𝑎𝑛)**2 − 3
//Wczytaj od użytkownika liczbę całkowitą n i wypisz na ekranie wartość ciągu 𝑎𝑛.

using System;

namespace ConsoleApp1
{
    class Brudnopis
    {
        static int ciag(int n)
        
            {
                int i, wyraz = 0;
            if (n == 1) return 1;
            else if (n == 2) return -2;
            else for (i = 2; i <= n; i++)           
                {
                    wyraz = (i - 1) * (i - 1) - 3;          //przy pomocy pętli for liczymy każdy poprzedni wyraz ciągu
                    if (i == n) return wyraz;
                }
            return ciag(wyraz - 1) * ciag(wyraz - 1) - 3;           
            }


        static void Main(string[] args)
        {
            skok:
            int n;
            Console.Write("Podaj liczbę n: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0) goto skok;
            else Console.WriteLine("Dla n = {0}, wartość ciągu an wynosi: {1}", n, ciag(n));

            Console.ReadKey(true);
        }
    }
}
