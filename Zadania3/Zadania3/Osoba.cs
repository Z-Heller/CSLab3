using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania3
{
    class Osoba : IOsoba
    {
        public String Imie { get; set; }
        public String Nazwisko { get; set; }

        public Osoba()
        {
        }

        public Osoba(String Imie, String Nazwisko)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
        }

        public String ZwrocPelnaNazwe()
        {
            return this.Imie + " " + this.Nazwisko;
        }

        public List<Osoba> ListaOsob = new List<Osoba>();

        public void WypiszOsoby()
        {
            for(int i=0; i<ListaOsob.Count; i++)
            {
                Console.WriteLine((i + 1) + ". "+ListaOsob[i].ZwrocPelnaNazwe());
            }
        }

        public void PosortujOsobyPoNazwisku()
        {
            ListaOsob.Sort((x, y) => x.Nazwisko.CompareTo(y.Nazwisko));
        }

    }
}
