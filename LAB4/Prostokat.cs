using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Prostokat : Figura
    {
        double a = 3, b = 5;
        public override double Obwod()
        {
            return (2 * a ) + (2 * b);
        }

        public override double Pole()
        {
            return a * b;
        }

        public void View()
        {
            Console.WriteLine($"Pole prostokata: {Pole()} Obwód prostokata: {Obwod()}");
        }
    }
}
