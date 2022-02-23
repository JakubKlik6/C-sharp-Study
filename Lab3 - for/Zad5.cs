//Napisz program znajdujący wszystkie trójki liczb pitagorejskich z zadanego przedziału. Np.: dla przedziału[3, 5] mamy jedną trójkę: 3, 4, 5(bo 3 ^ 2 + 4 ^ 2 = 5 ^ 2).


using System;

namespace Programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a,b,c,d,p,k;
            Console.Write("Podaj początkową wartość przedziału: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj końcową wartość przedziału: ");
            k = Convert.ToInt32(Console.ReadLine());

            for (a = p; a <= k; a++)		
                for (b = a + 1; b <= k; b++)		
                    for (c = b + 1; c <= k; c++)		
                        if (a * a + b * b == c * c)		
                            Console.WriteLine("{0} {1} {2}", a, b, c);		

            Console.ReadKey(true);
        }
    }
}
 
