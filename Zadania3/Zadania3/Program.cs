using System;
using System.Collections.Generic;

namespace Zadania3
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            Osoba os1 = new Osoba("Adam", "Kowalski");
            Osoba os2 = new Osoba("Jan", "Nowak");
            Osoba os3 = new Osoba("Agata", "Wilk");
            Osoba os4 = new Osoba("Joanna", "Maj");

            osoba.ListaOsob.Add(os1);
            osoba.ListaOsob.Add(os2);
            osoba.ListaOsob.Add(os3);
            osoba.ListaOsob.Add(os4);

            osoba.WypiszOsoby();

            osoba.PosortujOsobyPoNazwisku();
            Console.WriteLine("\nPo posortowaniu: ");
            osoba.WypiszOsoby();

            StudentUR sur1 = new StudentUR("Anna", "Nowak", " UR", "Informatyka", "II", "3");
            StudentUR sur2 = new StudentUR("Nikodem", "Kwiatkowski", " UR", "Turystyka", "III", "5");
            StudentUR sur3 = new StudentUR("Wiktoria", "Majewska", " UR", "Lekarski", "I", "1");
            StudentUR sur4 = new StudentUR("Maciej", "Nowak", " UR", "Prawo", "I", "2");
            StudentUR sur5 = new StudentUR("Anna", "Grabowska", " UR", "Turystyka", "I", "1");

            StudentUR stud = new StudentUR();

            stud.ListaOsob.Add(sur1);
            stud.ListaOsob.Add(sur2);
            stud.ListaOsob.Add(sur3);
            stud.ListaOsob.Add(sur4);
            stud.ListaOsob.Add(sur5);

            Console.WriteLine("\nStudenci: ");
            stud.WypiszOsoby();
        }
    }
}
