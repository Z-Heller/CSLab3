using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania3
{
    interface IStudent : IOsoba
    {
        String Uczelnia { get; set; }
        String Kierunek { get; set; }
        String Rok { get; set; }
        String Semestr { get; set; }


    }
}
