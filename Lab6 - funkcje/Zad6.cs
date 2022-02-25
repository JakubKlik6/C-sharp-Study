//Napisz funkcję o nazwie czy_kw, która stwierdza, czy zadana jako parametr liczba całkowita
//jest kwadratem pewnej liczby całkowitej. Liczby będące kwadratami liczb całkowitych to 1, 4,
//9, 16, 25, itd. Wartością funkcji ma być jeden, jeśli liczba spełnia warunek lub zero w
//przeciwnym przypadku. Napisz program testujący utworzoną funkcję czy_kw.
//Proszę nie korzystać z funkcji matematycznej Math.Sqrt().

using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Czy_kw(int n)

        {
            for (int i = 1; i > 0; i++)
            {
                if (n == i * i) break;
                else continue;
            }
            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Jeżeli podana liczba jest kwadratem pewnej liczby całkowitej, wyświetli się poniżej:");
            Console.WriteLine("{0}", Czy_kw(13));

            Console.ReadKey(true);      //pauza
        }
    }
}
