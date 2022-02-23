//Zadanie 2
//Dana jest funkcja kwadratowa f(x)=ax^2+bx+c. Napisać program wczytujący współczynniki
//funkcji kwadratowej (a, b, c) i wypisujący na ekranie jej miejsca zerowe lub informację o ich
//braku.
//Wskazówka: Zbadaj deltę, wyznacz miejsca zerowe

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, delta;     
            Console.Write("Podaj odcinek a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj odcinek b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj odcinek c: ");
            c = Convert.ToDouble(Console.ReadLine());
            
            delta = ((b * b) - 4 * a * c);  
            
            if (delta > 0)    
                Console.WriteLine("Podana funkcja posiada dwa miejsca zerowe mz1= {0} oraz mz2= {1}", (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a));
            else if (delta == 0)      
                Console.WriteLine("Podana funkcja posiada jedno miejsce zerowe mz0= {0}", -b/(2*a));
            else  
                Console.WriteLine("Podana funcja nie posiada miejsc zerowych");

            Console.ReadKey(true);    
        }


    }
}
