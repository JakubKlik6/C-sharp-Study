//Napisać funkcję o nazwie NWD zwracającą wartość największego wspólnego dzielnika dla jej
//dwóch argumentów będących liczbami naturalnymi.
//Napisz program testujący utworzoną funkcję.


using System;

namespace ConsoleApp1
{
    class Program
    {
        static int NWD(int a, int b)
        {
            int x = a, y = b,nd;

            while (x != y)
            {

                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            nd = x;
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("NWD wynosi: {0}",NWD(8,4));
            Console.ReadKey(true);
        }

    }
}
