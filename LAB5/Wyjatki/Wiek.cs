using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    public class Wiek
    {
        int wiek = 0;
        public void CheckAge(int a)
        {
            wiek = a;
            if (wiek < 0)
                throw (new MyClassException("Wiek nie moze byc liczba mniejsza od zera"));
            else Console.WriteLine("Wiek = {0}", wiek);
        }
    }
}
