//Zadanie 1
//Napisać program wczytujący trzy długości odcinków i wypisujący na ekranie informację czy da
//się z tych odcinków zbudować trójkąt, czy też nie.
//Wskazówka: Z trzech odcinków można zbudować trójkąt, jeżeli suma długości każdych dwóch
//odcinków jest większa od długości trzeciego odcinka.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;
            Console.Write("Podaj odcinek a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj odcinek b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj odcinek c: ");
            c = Convert.ToDouble(Console.ReadLine());
            
            if ((a+b>c) && (a+c>b) && (c+b>a))
                Console.WriteLine("Z podanych odcinków da się zbudować trójkąt");
            else
                Console.WriteLine("Z podanych odcników nie da się zbudować trójkąta");

            Console.ReadKey(true); 
        }
    }
}
