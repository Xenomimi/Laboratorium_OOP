using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public static class OsobaExtension
    {
        // Zadanie 3c
        public static void WypiszOsoby(this List<IOsoba> listaOsob)
        {
            foreach (var osoba in listaOsob)
            {
                // Zadanie 3e
                if (osoba is StudentWSIiZ studentWSIiZ)
                {
                    Console.WriteLine(studentWSIiZ.WypiszPelnaNazweIUczelnie());
                }
                else
                {
                    Console.WriteLine(osoba.ZwrocPelnaNazwe());
                }
            }
        }

        public static void PosortujOsobyPoNazwisku(this List<IOsoba> listaOsob)
        {
            listaOsob.Sort((x, y) => x.Nazwisko.CompareTo(y.Nazwisko));
        }
    }
}
