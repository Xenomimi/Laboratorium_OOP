using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    // Zadanie 1
    internal class Licz
    {
        // Publiczne pole 'value'
        private int value;

        // Konstruktor z jednym parametrem
        public Licz(int value)
        {
            this.value = value;
        }

        public void Dodaj(int value)
        {
            this.value += value;
        }

        public void Odejmij(int value)
        {
            this.value -= value;
        }

        //  Funkcja wypisująca stan obiektu (pole value)
        public void Wyswietl()
        {
            Console.WriteLine($"Wartość pola value = {value}");
        }
    }
}
