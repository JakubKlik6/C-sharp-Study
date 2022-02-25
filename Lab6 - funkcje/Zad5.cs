//Napisać funkcję o nazwie NWW zwracającą wartość najmniejszej wspólnej wielokrotności dla
//jej dwóch argumentów będących liczbami naturalnymi.
//Napisz program testujący utworzoną funkcję.
//Wskazówka: NWW(a,b)=a*b/NWD(a,b).


using System;

namespace ConsoleApp1
{
    class Program
    {
        static int NWW(int a,int b)
        {

            int x = a, y = b, dzielnik;

            while (x != y)
            {

                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }

            dzielnik = a*b/x;
            return dzielnik;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("NWW wynosi: {0}",NWW(8,4));
            Console.ReadKey(true);
        }
    }
}
