//Dany jest ciąg rekurencyjny: �
//𝑎1 = 1
//𝑎𝑛+1 = (𝑎𝑛)**2 − 3
//Wczytaj od użytkownika liczbę całkowitą n i wypisz na ekranie wartość ciągu 𝑎𝑛.

using System;

namespace ConsoleApp1
{

    class Program
    {
     
        static long str(int n)
        {
            int i = 2;
            if (n == 1) return 1;
            else while (i < n)
                {
                    n = i * i - 3;
                }
            return str(n - 1) * str(n - 1) - 3;
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj liczbę: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0) Console.WriteLine("Błędne dane");
            else Console.WriteLine("Dla n = {0}, wartość ciągu an wynosi: {1}",n,str(n));

            Console.ReadKey(true);
        }


    }
}
