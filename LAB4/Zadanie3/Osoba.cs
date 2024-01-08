using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class Osoba : IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string ZwrocPelnaNazwe()
        {
            return Imie + " " + Nazwisko;
        }
    }
}
