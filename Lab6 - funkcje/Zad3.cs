//Napisać funkcję, która posiada trzy argumenty będące współczynnikami a, b, c funkcji
//kwadratowej 𝑦 = 𝑎𝑥2 + 𝑏𝑥 + 𝑐. Funkcja ma zwracać ilość pierwiastków zadanej funkcji
//kwadratowej. Napisz program testujący utworzoną funkcję.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static int math(int a, int b, int c)
        {
            int delta;
            delta = (b * b) - 4 * a * c;
            if (delta > 0) return 2;
            else if (delta == 0) return 1;
            else return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Funkcja posiada {0} pierwiastki/ów",math(1,6,2));
            Console.ReadKey(true);
        }
    }
}
