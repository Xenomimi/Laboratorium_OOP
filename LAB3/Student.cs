using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Student : Person
    {
        private string nrAlbumu;
        public string NrAlbumu { get { return nrAlbumu; } set { nrAlbumu = value; } }

        // : base() to lista inicjalizacyjna
        public Student(string name, int age, string nrAlbumu) : base(name, age)
        {
            this.nrAlbumu = nrAlbumu;
        }
    }
}
