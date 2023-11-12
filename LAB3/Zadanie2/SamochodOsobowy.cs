using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class SamochodOsobowy : Samochod
    {
        private float Waga;
        private float PojemnoscSilnika;
        private int IloscOsob;

        public SamochodOsobowy()
        {
            do
            {
                Console.Write("Podaj wage samochodu (musi być z przedziału 2t - 4,5t):");
                Waga = (float)Convert.ToDouble(Console.ReadLine());
            } while (Waga < 2 || Waga > 4.5);

            do
            {
                Console.Write("Podaj pojemność silnika samochodu (musi być z przedziału 0.8L - 3.0L):");
                PojemnoscSilnika = (float)Convert.ToDouble(Console.ReadLine());
            } while (PojemnoscSilnika < 0.8 || PojemnoscSilnika > 3.0);

            do
            {
                Console.Write("Podaj maksymalną liczbę osób w samochodzie:");
                IloscOsob = Convert.ToInt32((Console.ReadLine()));
            } while (IloscOsob <= 0);
        }

        public new void View()
        {
            Console.WriteLine($"Waga:{Waga}\nPojemność Silnika:{PojemnoscSilnika}\nMaksymalna ilość osób w samochodzie:{IloscOsob}");
        }
    }
}
