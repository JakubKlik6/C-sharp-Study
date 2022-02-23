//8. Napisz program stwierdzający, czy zadana liczba n jest pierwsza. Użyj pętli while.


using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int i = 1, n, suma = 1;
            Console.Write("Podaj liczbę: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 2) Console.WriteLine("Podana liczba jest pierwsza");
            else
            {
                while (++i <= n)
                {
                    if (n % i == 0)
                        suma += i;
                }

                if (suma == n + 1) Console.WriteLine("Podana liczba jest pierwsza");
                else Console.WriteLine("Podana liczba nie jest pierwsza");
            }
            Console.ReadKey(true);
        }
    }
}
