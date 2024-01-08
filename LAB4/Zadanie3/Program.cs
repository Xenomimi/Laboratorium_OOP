using System.Collections.Generic;

namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 3a
            Osoba osoba1 = new Osoba { Imie = "Jan", Nazwisko = "Kowalski" };
            Osoba osoba2 = new Osoba { Imie = "Anna", Nazwisko = "Nowak" };
            Osoba osoba3 = new Osoba { Imie = "Łukasz", Nazwisko = "Malinowski" };

            List<Osoba> listaOsob = new List<Osoba>();
            listaOsob.Add(osoba1);
            listaOsob.Add(osoba2);
            listaOsob.Add(osoba3);

            // Zadanie 3b
            List<IOsoba> listaOsob2 = new List<IOsoba>();
            listaOsob2.Add(osoba1);
            listaOsob2.Add(osoba2);
            listaOsob2.Add(osoba3);

            StudentWSIiZ student1 = new StudentWSIiZ { 
                Imie = "Janina", 
                Nazwisko = "Kowalska", 
                Uczelnia = "WSIiZ", 
                Kierunek = "IID", 
                Rok = 2021, 
                Semestr = 3, 
                CzyStypendium = true 
            };
            StudentWSIiZ student2 = new StudentWSIiZ { 
                Imie = "Olga", 
                Nazwisko = "Kapusta", 
                Uczelnia = "WSIiZ", 
                Kierunek = "ZD", 
                Rok = 2020, 
                Semestr = 4, 
                CzyStypendium = true 
            };
            Student student3 = new Student { 
                Uczelnia = "PW", 
                Kierunek = "MD", 
                Rok = 2022, 
                Semestr = 3 
            };
            Student student4 = new Student { 
                Uczelnia = "UW", 
                Kierunek = "ZD", 
                Rok = 2020, 
                Semestr = 4 
            };

            listaOsob2.Add(student1);
            listaOsob2.Add(student2);
            listaOsob2.Add(student3);
            listaOsob2.Add(student4);

            listaOsob2.WypiszOsoby();
        }
    }
}