//Napisz funkcję posiadającą dwa argumenty: p, q – długości przekątnych deltoidu. Funkcja ma
//zwracać pole deltoidu dla zadanych argumentów. Napisz program testujący utworzoną
//funkcję.
//Wskazówka: P=p*q/2.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static int field(int p, int q)
        {
            int P;
            P = (p * q) / 2;
            return P;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pole deltoidu wynosi: {0}",field(3,4));
            Console.ReadKey(true);
        } 
    }
}
