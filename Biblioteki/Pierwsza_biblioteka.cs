using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            skok:
            double a;
            Console.Write("Podaj a > 0: ");
            a = Convert.ToDouble(Console.ReadLine());

            if (a > 0) Console.WriteLine("Pole kwadratu wynosi: {0}",Pierwsza_biblioteka.Pole.Kwadrat(a));    //Odwołanie się do biblioteki
            else goto skok;

            Console.ReadKey(true);
        }
    }
}
