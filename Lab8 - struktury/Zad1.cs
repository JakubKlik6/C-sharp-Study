//Zdefiniuj strukturę o nazwie Osoba posiadającą trzy pola: imie, nazwisko i rok_urodzenia. 
//Zadeklaruj zmienną typu strukturalnego o nazwie o, wczytaj do niej wszystkie wartości pól od 
//użytkownika i wypisz wszystkie pobrane wartości pól na ekranie.


using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    { 
        public struct Osoba
        {
            public string Imie, Nazwisko;
            public int rok_urodzenia;
        }

        static void Main(string[] args)
        {
            Osoba o;
            Console.Write("Podaj imię: ");
            o.Imie = Console.ReadLine();
            Console.Write("Podaj Nazwisko: ");
            o.Nazwisko = Console.ReadLine();
            Console.Write("Podaj rok urodzenia: ");
            o.rok_urodzenia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nazywasz się {0} {1} i urodziłeś się w {2} roku",o.Imie,o.Nazwisko,o.rok_urodzenia);

            Console.ReadKey(true);
        }
    }
}
