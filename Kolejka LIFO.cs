using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Stack stos = new Stack();       //tworzymy stos

            for (int i = 0; i < 10; i++) stos.Push(i);  //umieszczenie elementu na stosie

            Console.WriteLine("Stos posiada {0} elementów",stos.Count);

            while (stos.Count > 0) Console.WriteLine(stos.Pop());      //zdejmowanie elementu ze stosu

            Console.ReadKey(true);
        }
    }
}
