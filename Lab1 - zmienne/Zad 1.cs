//Zadanie 1
//Dany jest ciąg arytmetyczny a(n)=3n-1. Napisać program wczytujący numer wyrazu ciągu (n) i
//wypisujący na ekranie jego wartość.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj numer wyrazu ciągu n: ");  
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Wartość ciągu a(n)=3n-1 dla n = {0}, wynosi {1}",n,3*n-1);   
            
            Console.ReadKey(true);     



        }

            
    }
}
