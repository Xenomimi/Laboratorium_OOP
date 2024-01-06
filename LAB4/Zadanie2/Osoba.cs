using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    public abstract class Osoba
    {
        private string Imie;

        private string Nazwisko;

        private string Pesel;

        public abstract void SetFirstName(string imie);

        public abstract void SetLastName(string nazwisko);

        public abstract void SetPesel(string pesel);

        public int GetAge(string pesel)
        {
            int year, month, day;

            // Pobranie roku, miesiąca i dnia z numeru PESEL
            year = Int32.Parse(pesel.Substring(0, 2));
            month = Int32.Parse(pesel.Substring(2, 2));
            day = Int32.Parse(pesel.Substring(4, 2));

            // Dodanie odpowiedniej liczby lat w zależności od stulecia
            if (month > 80 && month <= 92)
            {
                year += 1800;
                month -= 80;
            }
            else if (month > 0 && month <= 12)
            {
                year += 1900;
            }
            else if (month > 20 && month <= 32)
            {
                year += 2000;
                month -= 20;
            }
            else if (month > 40 && month <= 52)
            {
                year += 2100;
                month -= 40;
            }
            else if (month > 60 && month <= 72)
            {
                year += 2200;
                month -= 60;
            }

            // Obliczenie wieku
            int currentYear = DateTime.Now.Year;
            int age = currentYear - year;

            // Poprawka wieku w przypadku, gdy jeszcze nie był urodzony w pełnym bieżącym roku
            if (month > DateTime.Now.Month || (month == DateTime.Now.Month && day > DateTime.Now.Day))
            {
                age--;
            }

            return age;
        }

        public char GetGender(string pesel) 
        {
            int genderDigit = Int32.Parse(pesel.Substring(9, 1));

            return (genderDigit % 2 == 0) ? 'K' : 'M';
        }

        public abstract void GetEducationInfo();

        public abstract void GetFullName();

        public abstract bool CanGoHomeAlone();

    }
}
