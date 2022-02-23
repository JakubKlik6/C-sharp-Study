//Napisz program obliczający sumę n początkowych liczb nieparzystych. Liczbę n należy pobrać od użytkownika. 
//Przykładowo dla n = 3 należy obliczyć sumę 1 + 3 + 5. Do obliczenia wartości sumy użyj pętli for.

using System;

namespace Programowanie
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i, suma = 0, k = 1;
            Console.Write("Podaj n=");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                suma += k;
                k = k + 2;
            }
            Console.WriteLine("{0}", suma);
            Console.ReadKey();
        }
    }
}
 
