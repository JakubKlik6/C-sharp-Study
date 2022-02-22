using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Podaj a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b= ");
            b = Convert.ToInt32(Console.ReadLine());        //Prosimy o podanie wartości a oraz b
            Console.WriteLine("Suma kwadratów liczb a i b wynosi {0}",(a*a)+(b*b));     //Obliczamy sumę kwadratów dla podanego a oraz b
            Console.ReadKey(true);      //pauza

        }

            
    }
}
