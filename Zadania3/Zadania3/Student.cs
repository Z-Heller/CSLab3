using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania3
{
    class Student : IStudent
    {
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public String Uczelnia { get; set; }
        public String Kierunek { get; set; }
        public String Rok { get; set; }
        public String Semestr { get; set; }

        public Student()
        {
        }

        public Student(string imie, string nazwisko, string uczelnia, string kierunek, string rok, string semestr)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Uczelnia = uczelnia;
            Kierunek = kierunek;
            Rok = rok;
            Semestr = semestr;
        }

        public String ZwrocPelnaNazwe()
        {
            return this.Imie + " " + this.Nazwisko;
        }

        public List<Osoba> ListaOsob = new List<Osoba>();

        public void WypiszOsoby()
        {
            for (int i = 0; i < ListaOsob.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + ListaOsob[i].ZwrocPelnaNazwe());
            }
        }

        public void PosortujOsobyPoNazwisku()
        {
            ListaOsob.Sort((x, y) => x.Nazwisko.CompareTo(y.Nazwisko));
        }

        public string WypiszPelnaNazweIUczelnie()
        {
            return (this.Imie + " " + this.Nazwisko + " " + this.Uczelnia + " " + this.Kierunek + " " + this.Rok + " rok " + this.Semestr + " semestr");
        }


    }
}

