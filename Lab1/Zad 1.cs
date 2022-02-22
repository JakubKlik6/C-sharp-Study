using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.Write("Podaj numer wyrazu ciągu n: ");  
            n = Convert.ToDouble(Console.ReadLine());       // prosumy użytkownika o podanie numeru wyrazu ciągu n
            Console.WriteLine("Wartość ciągu a(n)=3n-1 dla n = {0}, wynosi {1}",n,3*n-1);       //obliczamy wartość ciągu dla podanego n, wypisujemy na tablice
            Console.ReadKey(true);      //pauza



        }

            
    }
}
 
