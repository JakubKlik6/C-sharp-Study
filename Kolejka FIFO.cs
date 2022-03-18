using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Queue kolejka = new Queue();        //tworzymy kolejkę

            for (int i = 0; i < 10; i++)
                kolejka.Enqueue(i);         //dodanie elementu do kolejki
            Console.WriteLine("Kolejka posiada {0} elementów",kolejka.Count);
            while(kolejka.Count > 0)
                Console.WriteLine(kolejka.Dequeue());           //pobranie elementu z kolejki

            Console.ReadKey(true);
        }
    }
}
