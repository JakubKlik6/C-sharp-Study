using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.Write("Podaj wartośc r= ");
            r = Convert.ToDouble(Console.ReadLine());       //Prosimy użytkownika o podanie promienia
            Console.WriteLine("Pole koła o promieniu {0} wynosi {1}",r, Math.PI*r*r);       //obliczamy pole koła i wypisujemy wynik
            Console.WriteLine("Obwód koła o promieniu {0} wynosi {1}", r, 2*Math.PI*r);     //Obliczamy obwód koła i wypisujemy wynik
            Console.ReadKey(true);      //wynik

        }

            
    }
}
