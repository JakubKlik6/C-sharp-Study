//Napisz program drukujący na ekranie kolejne liczby naturalne podzielne przez 7. Ilość liczb wczytaj z klawiatury.Użyj pętli for. Oto wydruk dla ile = 6: 0,7,14,21

using System;

namespace Programowanie
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.Write("Podaj ilość nieparzystych liczb naturalnych: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++) Console.Write("{0} ", i * 7);

            Console.ReadKey(true);

        }

        
    }
}
 
