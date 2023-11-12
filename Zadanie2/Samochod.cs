using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Samochod
    {
        private string Marka;
        private string Model;
        private string Nadwozie;
        private string Kolor;
        private int RokProdukcji;
        private int Przebieg;

        public Samochod()
        {
            Console.Write("Podaj markę samochodu:");
            Marka = Console.ReadLine();

            Console.Write("Podaj model samochodu:");
            Model = Console.ReadLine();

            Console.Write("Podaj rodzaj nadwozia samochodu:");
            Nadwozie = Console.ReadLine();

            Console.Write("Podaj kolor samochodu:");
            Kolor = Console.ReadLine();

            Console.Write("Podaj rok produkcji samochodu:");
            RokProdukcji = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("Podaj przebieg samochodu (musi być nieujemny):");
                Przebieg = Convert.ToInt32(Console.ReadLine());
            } while (Przebieg <= 0);
        }
        public Samochod(string Marka, string Model, string Nadwozie, string Kolor, int RokProdukcji, int Przebieg)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Nadwozie= Nadwozie;
            this.Kolor = Kolor;
            this.RokProdukcji= RokProdukcji;
            this.Przebieg= Przebieg;
        }
        public void View()
        {
            Console.WriteLine($"Marka:{Marka}\nModel:{Model}\nNadwozie:{Nadwozie}\nKolor:{Kolor}\nRok produkcji:{RokProdukcji}\nPrzebieg:{Przebieg}");
        }
    }
}
