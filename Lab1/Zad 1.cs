using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.Write("Podaj numer wyrazu ciągu n: ");  
            n = Convert.ToDouble(Console.ReadLine());       
            Console.WriteLine("Wartość ciągu a(n)=3n-1 dla n = {0}, wynosi {1}",n,3*n-1);      
            Console.ReadKey(true);      



        }

            
    }
}
 
