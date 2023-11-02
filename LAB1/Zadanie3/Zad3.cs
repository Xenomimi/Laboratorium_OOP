using System;
using System.Runtime.InteropServices;

namespace Zadanie3
{
    internal class Zad3
    {
        static double[] doubles = new double[10];
        static void Menu()
        {
            do
            {
                View();
                int c = InputInt();
                if (c == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Uzupełnianie tablicy ");
                    Uzupelnienie();
                }
                else if (c == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Wyświetlanie tablicy od pierwszego do ostatniego indeksu.");
                    Desc();
                }
                else if (c == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Wyświetlanie tablicy od ostatniego do pierwszego indeksu.");
                    Asc();
                }
                else if (c == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Wyświetlanie elementów o nieparzystych indeksach.");
                    Parzyste_Ind();
                }
                else if (c == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Wyświetlanie elementów o parzystych indeksach.");
                    Nieparzyste_Ind();
                }
                else if (c == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Wyjście");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Niepoprawny znak! Spróbuj jeszcze raz :)");
                }
            } while (true);
        }

        static void View()
        {
            Console.WriteLine("=== 1. Uzupełnianie tablicy ===");
            Console.WriteLine("=== 2. Wyświetlanie tablicy od pierwszego do ostatniego indeksu. ===");
            Console.WriteLine("=== 3. Wyświetlanie tablicy od ostatniego do pierwszego indeksu. ===");
            Console.WriteLine("=== 4. Wyświetlanie elementów o nieparzystych indeksach. ===");
            Console.WriteLine("=== 5. Wyświetlanie elementów o parzystych indeksach. ===");
            Console.WriteLine("=== 6. Wyjście ===");
            Console.WriteLine("\n\n Twój wybór: ");
        }
        static int InputInt()
        {
            int choise = Convert.ToInt32(Console.ReadLine());
            return choise;
        }

        static void Uzupelnienie()
        {
            int licznik = 10;

            for (int i = 0; i < doubles.Length; i++)
            {
                Console.WriteLine($"Proszę podać {licznik} liczb rzeczywistych.");

                string liczba = Console.ReadLine();

                doubles[i] = Convert.ToDouble(liczba);

                Console.Clear();

                licznik--;
            }
        }
        
        static void Desc()
        {
            Console.WriteLine("Wyświetlanie tablicy od pierwszego do ostatniego indeksu.");

            foreach (var item in doubles)
            {
                Console.WriteLine(item);
            }
        }

        static void Asc() 
        {
            Console.WriteLine("Wyświetlanie tablicy od ostatniego do pierwszego indeksu.");

            for (int i = doubles.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(doubles[i]);
            }
        }

        static void Parzyste_Ind()
        {
            Console.WriteLine("Wyświetlanie elementów o nieparzystych indeksach.");

            for (int i = 0; i < doubles.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(doubles[i]);
                }
            }
        }

        static void Nieparzyste_Ind()
        {
            Console.WriteLine("Wyświetlanie elementów o parzystych indeksach.");

            for (int i = 0; i < doubles.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(doubles[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}    