using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    public abstract class Osoba
    {
        protected string Imie;

        protected string Nazwisko;

        protected string Pesel;

        public abstract void SetFirstName(string imie);

        public abstract void SetLastName(string nazwisko);

        public abstract void SetPesel(string pesel);

        public abstract int GetAge();

        public abstract char GetGender();

        public abstract string GetEducationInfo();

        public abstract string GetFullName();

        public abstract bool CanGoAloneToHome();

    }
}
