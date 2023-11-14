using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Kwadrat : Figura
    {
        double a = 4;
        public override double Obwod()
        {
            return 4 * a;
        }

        public override double Pole()
        {
            return a * a;
        }
        public void View()
        {
            Console.WriteLine($"Pole kwadratu: {Pole()} Obwód kwadratu: {Obwod()}");
        }
    }
}
