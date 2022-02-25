//Napisz funkcję, która posiada jeden parametr będący rokiem. Ma ona zwracać wartość 1, jeśli
//rok jest przestępny i 0 w pozostałych przypadkach. Napisz program testujący utworzoną
//funkcję.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static int year(int a)
        {
            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0) return 1;
            else return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1 -> rok jest przestępny");
            Console.WriteLine("0 -> rok nie jest przestępny");
            Console.WriteLine("Rok jest {0}",year(1950));
            Console.ReadKey(true);
        }
    }
}
