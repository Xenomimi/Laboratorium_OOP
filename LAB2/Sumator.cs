using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    // Zadanie 2
    internal class Sumator
    {
        // Publiczne pole liczby będące tablicą liczb
        // z później zmienioną widocznością na private

        private int[] liczby;

        public Sumator(int[] liczby)
        {
            this.liczby = liczby;
        }

        // Metoda Suma zwracająca sumę liczb z pola liczby
        public int Suma()
        {
            int suma = 0;
            foreach (var item in liczby)
            {
                suma += item;
            }
            return suma;
        }

        // Metoda SumaPodziel2 zwracająca sumę liczb z tablicy, które są podzielne przez 2
        public int SumaPodziel2()
        {
            int suma_p_2 = 0;
            foreach (var item in liczby)
            {
                if (item % 2 == 0)
                {
                    suma_p_2 += item;
                }
            }
            return suma_p_2;
        }

        // Metoda IleElementow zwracająca liczbę elementów na w tablicy 
        public int IleElementow()
        {
            return liczby.Length;
        }

        // Metoda Wyswietl wypisując wszystkie elementy tablicy 
        public void Wyswietl()
        {
            Console.WriteLine("Wyświetlenie elementów tablicy: ");
            foreach (var item in liczby)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        // Metoda Wyswietl_zakres, która przyjmuje zakres i wypisuje
        // liczby z tablicy pomiedzy przekazanym zakresem
        public void Wyswietl_zakres(int lowIndex, int highIndex) 
        {
            Console.WriteLine($"Liczby z zakresu od {lowIndex} do {highIndex} (indeksy): ");
            for (int i = 0; i < liczby.Length; i++)
            {
                if (i >= lowIndex && i <= highIndex)
                {
                    Console.Write(liczby[i] + ", ");
                }
            }
        }
    }
}
