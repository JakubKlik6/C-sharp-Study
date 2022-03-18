//Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
//Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur 
//umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
//Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.


using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        public struct Student
        {
            public string name, surname;
            public byte[] grade;
        }

        static void Main(string[] args)
        {
            Student[] students;     //deklaracja zmiennej typu struct            
            int n, i, j, how_many_grades;

            Console.Write("Number of students: ");
            n = Convert.ToInt32(Console.ReadLine());        //wczytuje liczbe uczniów

            students = new Student[n];      //przydzielam pamięć dla tab struktur

            for (i = 0; i < n; i++)
            {
                Console.Write("Student name {0}: ",i+1);        //imie
                students[i].name = Console.ReadLine();
                Console.Write("Student surname {0}: ",i+1);     //nazwisko
                students[i].surname = Console.ReadLine();
                Console.Write("How many grades have {0} {1} :",students[i].name, students[i].surname);        //wczytuje liczbe ocen ucznia
                how_many_grades = Convert.ToInt32(Console.ReadLine());

                students[i].grade = new byte[how_many_grades];       //przydzielam pamięc tablicy dla ocen

                for (j = 0; j < how_many_grades; j++)       //wczytuej oceny ucznia
                {
                    Console.Write("Grade number {0}: ",j+1);
                    students[i].grade[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine();        //pusta linia
            }

            for (i = 0; i < n; i++)     //wypisuje dane uczniów na ekranie
            {
                Console.WriteLine("{0}. {1} {2}: ",i+1,students[i].name,students[i].surname);    
                foreach(byte o in students[i].grade)        //wypisuje oceny uczniów
                    Console.Write("{0}, ",o);
                Console.WriteLine("");      //nowy wiersz
            }
            Console.ReadKey(true);
        }
    }
}
