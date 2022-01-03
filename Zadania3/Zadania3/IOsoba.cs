using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania3
{
    interface IOsoba
    {
        String Imie { get; set; }

        String Nazwisko { get; set; }

        String ZwrocPelnaNazwe();

        void WypiszOsoby();

        void PosortujOsobyPoNazwisku();

    }
}
