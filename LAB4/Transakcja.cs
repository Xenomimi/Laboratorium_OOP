using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Transakcja : ITransakcje
    {
        int ilosc = 2;
        public int PoliczIlosc()
        {
            return ilosc;
        }

        public void WypiszDane()
        {
            Console.WriteLine(ilosc);
        }
    }
}
