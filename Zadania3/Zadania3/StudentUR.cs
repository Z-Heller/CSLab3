using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania3
{
    class StudentUR : Student
    {

        public StudentUR(string imie, string nazwisko, string uczelnia, string kierunek, string rok, string semestr) : base(imie, nazwisko, uczelnia, kierunek, rok, semestr)
        {
        }

        public StudentUR()
        {
        }

        public new List<StudentUR> ListaOsob = new List<StudentUR>();

        public new void WypiszOsoby()
        {
            for (int i = 0; i < ListaOsob.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + ListaOsob[i].WypiszPelnaNazweIUczelnie());
            }
        }


    }

}
