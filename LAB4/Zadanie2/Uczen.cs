using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Uczen : Osoba
    {
        protected string Szkola { get; set; }
        protected bool MozeSamWracacDoDomu { get; set; }

        public void SetSchool(string szkola)
        {
            Szkola = szkola;
        }
         
        public void ChangeSchool(string szkola)
        {
            Szkola = szkola;
        }

        public void SetCanGoHomeAlone(bool mozeSamWracacDoDomu)
        {
            MozeSamWracacDoDomu = mozeSamWracacDoDomu;
        }

        public override void SetFirstName(string imie)
        {
            Imie = imie;
        }

        public override void SetLastName(string nazwisko)
        {
            Nazwisko = nazwisko;
        }

        public override void SetPesel(string pesel)
        {
            Pesel = pesel;
        }

        public override int GetAge()
        {
            int year, month, day;

            // Pobranie roku, miesiąca i dnia z numeru PESEL
            year = Int32.Parse(Pesel.Substring(0, 2));
            month = Int32.Parse(Pesel.Substring(2, 2));
            day = Int32.Parse(Pesel.Substring(4, 2));

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

        public override char GetGender()
        {
            int genderDigit = Int32.Parse(Pesel.Substring(9, 1));

            return (genderDigit % 2 == 0) ? 'K' : 'M';
        }

        public override string GetEducationInfo()
        {
            return Szkola;
        }

        public override string GetFullName()
        {
            return Imie + " " + Nazwisko;
        }

        public override bool CanGoAloneToHome()
        {
            return MozeSamWracacDoDomu;
        }
    }
}
