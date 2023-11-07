using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Person
    {
        private string firstName, lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void View()
        {
            Console.WriteLine($"Imie: {firstName}" + $"\tNazwisko: {lastName}" + $"\tWiek: {age}");
        }
    }
}
