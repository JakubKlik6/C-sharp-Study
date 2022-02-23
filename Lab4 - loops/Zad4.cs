//Napisać program sumujący kolejne liczby całkowite podawane przez użytkownika, aż do
//napotkania zera. Wypisz otrzymaną sumę na ekranie.Użyj pętli do -while.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, suma = 0;

            do
            {
                Console.Write("Podaj liczbę różną od zera (zero przerwie program): ");
                n = Convert.ToInt32(Console.ReadLine());

                suma += n;

            } while (n != 0);

            Console.WriteLine("Suma podanych liczb wynosi: {0}",suma);

            Console.ReadKey(true);
        }
    }
}
