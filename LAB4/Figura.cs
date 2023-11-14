using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    abstract class Figura
    {
        public abstract double Pole();
        public abstract double Obwod();

        public void view()
        {
            Console.WriteLine("Metoda z klasy abs figura");
        }
    }
}
