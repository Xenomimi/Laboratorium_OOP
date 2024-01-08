using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class Student : IStudent
    {
        // Zadanie 3d
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }

        public string WypiszPelnaNazweIUczelnie()
        {
            // Przykład: Jan Kowalski – 4IID-P 2018 WSIiZ
            return $"{ZwrocPelnaNazwe()} – {Semestr}{Kierunek} {Rok} {Uczelnia}";
        }
    }
}
