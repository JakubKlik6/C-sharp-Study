// Wczytaj liczbę naturalną n (n>4). Narysuj na ekranie ze znaków X kontur trójkąta prostokątnego jak na poniższym przykładzie.


using System;

namespace Programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, k;
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > 4)

                for (i = 0; i <= n; i++)
                {
                    for (j = 0; j <= n - i; j++) Console.Write(" ");
                    for (k = 0; k <= n - j; k++)  Console.Write("X");
                    Console.WriteLine(" ");
                }
            else Console.WriteLine("Podano niepoprawną wartość");

            Console.ReadKey(true);		
        }


    }
}
 
