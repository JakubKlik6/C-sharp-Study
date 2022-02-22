using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, H;
            Console.Write("Podaj długość boku a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj długość boku b= ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj długość wysokośći H= ");
            H = Convert.ToDouble(Console.ReadLine());      
            Console.WriteLine("Objętość prostopadłościanu wynosi {0}",a*b*H);       
            Console.WriteLine("Pole prostopadłościany wynosi {0}",(2*a*b)+(2*b*H)+(2*a*H));    
            Console.ReadKey(true);      

        }


    }
}
