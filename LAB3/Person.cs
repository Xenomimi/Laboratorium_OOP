using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Person
    {
        private string name;

        private int age;

        public string Name { get { return name; } set { name = value; } }

        public int Age { get { return age; } set { age = value; } }

        // Kontruktor nie jest dziedziczony
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
