using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Person
    {
        private string firstName, lastName;
        private int wiek;

        public string FirstName { 
            get { return firstName; } 
            set { } 
        }
        public string LastName
        {
            get { return lastName; }
            set { }
        }
        public int Wiek
        {
            get { return wiek; }
            set { }
        }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            wiek = age;
        }

        public void View()
        {
            Console.WriteLine($"Imie: {firstName}" + $"\tNazwisko: {lastName}" + $"\tWiek: {wiek}");
        }
    }
}
