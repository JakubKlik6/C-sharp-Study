using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, delta;      //wczytujemy dane
            Console.Write("Podaj odcinek a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj odcinek b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj odcinek c: ");
            c = Convert.ToDouble(Console.ReadLine());
            delta = ((b * b) - 4 * a * c);      //Obliczamy deltę
            if (delta > 0)      //Jeżeli delta > 0 to wypisujemy 2 miejsca zerowe
                Console.WriteLine("Podana funkcja posiada dwa miejsca zerowe mz1= {0} oraz mz2= {1}", (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a));
            else if (delta == 0)        //Jeżeli delta < 0 to wypisujemy 1 miejsce zerowe
                Console.WriteLine("Podana funkcja posiada jedno miejsce zerowe mz0= {0}", -b/(2*a));
            else   // w innym przypadku funkcja nie posiada miejsc zerowych
                Console.WriteLine("Podana funcja nie posiada miejsc zerowych");

            Console.ReadKey(true);      //pauza
        }


    }
}
