//Napisać program, który będzie umożliwiał użytkownikowi obliczanie objętości różnych brył.
//Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia objętości kuli,
//dla 2 – objętości stożka, dla 3 – objętości walca, dla 4 – objętości prostopadłościanu,
//a dla 5 – objętości sześcianu. Program powinien pytać użytkownika, którą objętość chce
//obliczyć aż do momentu, kiedy użytkownik wpisze 0 (zero). Użyj pętli do-while.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int choose;
            double a, b, c;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Objętość kuli");
                Console.WriteLine("2 - Objętość stożka");
                Console.WriteLine("3 - Objętość walca");
                Console.WriteLine("4 - Objętość prostopadłościanu");
                Console.WriteLine("5 - Objętość sześcianu");
                Console.WriteLine("0 - zakończ program");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Podaj promień koła: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Objętość koła o promieniu r = {0} wynosi: {1}", a, (2 * Math.PI * a));
                        break;
                    case 2:
                        Console.Write("Podaj promień stożka: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj wysokość stożka: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Objętość stożka o promieniu {0} i wysokości {1} wynosi {2}", a, b, ((1 / 3) * Math.PI * a * a * b)   );
                        break;
                    case 3:
                        Console.Write("Podaj promień walca: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj wysokość walca: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Objętość walca o promieniu {0} i wysokości {1} wynosi {2}", a, b, (Math.PI * a * a * b));
                        break;
                    case 4:
                        Console.Write("Podaj bok prostopadłościanu: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj drugi bok prostopadłościanu: ");
                        c = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj wysokość prostopadłościanu: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Objętość prostopadłościanu o o bokach {0},{1} i wysokości {2} wynosi {3}", a, c, b, (a * b * c));
                        break;
                    case 5:
                        Console.Write("Podaj bok sześcianu: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Objętość sześcianu o boku {0} wynosi {1}", a, a * a * a);
                        break;

                    default:
                        Console.WriteLine("Błąd: nieznany wybór!!");
                        break;

                }
            } while (choose != 0);

            Console.ReadKey(true);
        }
    }
}
