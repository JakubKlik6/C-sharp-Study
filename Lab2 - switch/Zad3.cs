//Zadanie 3
//Napisać program wczytujący liczbę arabską od 1 do 1 000 000 i wypisujący na ekranie słownie
//Wczytaną liczbę.
//Np.: wejście=105, wyjście=sto pięć


using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            Console.Write("Podaj liczbę arabską od 1 do 1 000 000: ");
            a = Convert.ToInt32(Console.ReadLine());
          
            if (a >= 900000)  { a -= 900000; Console.Write("dziewięćset tysięcy "); }
            if (a >= 800000) { a -= 800000; Console.Write("osiemset tysięcy "); }
            if (a >= 700000) { a -= 700000; Console.Write("siedemset tysięcy "); }
            if (a >= 600000) { a -= 600000; Console.Write("sześćset tysięcy "); }
            if (a >= 500000) { a -= 500000; Console.Write("pięćset tysięcy "); }
            if (a >= 400000) { a -= 400000; Console.Write("czterysta tysięcy "); }
            if (a >= 300000) { a -= 300000; Console.Write("trzysta tysięcy "); }
            if (a >= 200000) { a -= 200000; Console.Write("dwieście tysięcy "); }
            if (a >= 100000) { a -= 100000; Console.Write("sto tysięcy "); }
            
            if (a >= 90000) { a -= 90000; Console.Write("dziewięćdziesiąt tysięcy "); }
            if (a >= 80000) { a -= 80000; Console.Write("osiemdziesiąt tysięcy "); }
            if (a >= 70000) { a -= 70000; Console.Write("siedemdziesiąt tysięcy "); }
            if (a >= 60000) { a -= 60000; Console.Write("sześćdziesiąt tysięcy "); }
            if (a >= 50000) { a -= 50000; Console.Write("pięćdziesiąt tysięcy "); }
            if (a >= 40000) { a -= 40000; Console.Write("czterdzieści tysięcy "); }
            if (a >= 30000) { a -= 30000; Console.Write("trzydzieści tysięcy "); }
            if (a >= 20000) { a -= 20000; Console.Write("dwadzieścia tysięcy "); }
            if (a >= 10000) { a -= 10000; Console.Write("dziesięć tysięcy "); }
           
            if (a >= 9000) { a -= 9000; Console.Write("dziewięć tysięcy "); }
            if (a >= 8000) { a -= 8000; Console.Write("osiem tysięcy "); }
            if (a >= 7000) { a -= 7000; Console.Write("siedem tysięcy "); }
            if (a >= 6000) { a -= 6000; Console.Write("sześć tysięcy "); }
            if (a >= 5000) { a -= 5000; Console.Write("pięć tysięcy "); }
            if (a >= 4000) { a -= 4000; Console.Write("cztery tysiące "); }
            if (a >= 3000) { a -= 3000; Console.Write("trzy tysiące "); }
            if (a >= 2000) { a -= 2000; Console.Write("dwa tysiące "); }
            if (a >= 1000) { a -= 1000; Console.Write("tysiąc "); }
           
            if (a >= 900) { a -= 900; Console.Write("dziewięćset "); }
            if (a >= 800) { a -= 800; Console.Write("osiemset "); }
            if (a >= 700) { a -= 700; Console.Write("siedemset "); }
            if (a >= 600) { a -= 600; Console.Write("sześćset "); }
            if (a >= 500) { a -= 500; Console.Write("pięćset "); }
            if (a >= 400) { a -= 400; Console.Write("czterysta "); }
            if (a >= 300) { a -= 300; Console.Write("trzysta "); }
            if (a >= 200) { a -= 200; Console.Write("dwieście "); }
            if (a >= 100) { a -= 100; Console.Write("sto "); }
           
            if (a >= 90) { a -= 90; Console.Write("dziewięćdziesiąt "); }
            if (a >= 80) { a -= 80; Console.Write("osiemdziesiąt "); }
            if (a >= 70) { a -= 70; Console.Write("siedemdziesiąt "); }
            if (a >= 60) { a -= 60; Console.Write("sześćdziesiąt "); }
            if (a >= 50) { a -= 50; Console.Write("pięćdziesiąt "); }
            if (a >= 40) { a -= 40; Console.Write("czterdzieści "); }
            if (a >= 30) { a -= 30; Console.Write("trzydzieści "); }
            if (a >= 20) { a -= 20; Console.Write("dwadzieścia "); }
            if (a >= 10) { a -= 10; Console.Write("dziesięć "); }
            
            if (a >= 9) { a -= 9; Console.Write("dziewięć"); }
            if (a >= 8) { a -= 8; Console.Write("osiem"); }
            if (a >= 7) { a -= 7; Console.Write("siedem"); }    
            if (a >= 6) { a -= 6; Console.Write("sześć"); }
            if (a >= 5) { a -= 5; Console.Write("pięć"); }
            if (a >= 4) { a -= 4; Console.Write("cztery"); }
            if (a >= 3) { a -= 3; Console.Write("trzy"); }
            if (a >= 2) { a -= 2; Console.Write("dwa"); }
            if (a >= 1) { a -= 1; Console.Write("jeden"); }


            Console.ReadKey(true); 
        }


    }
}
