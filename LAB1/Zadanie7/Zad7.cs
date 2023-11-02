using System.Numerics;

namespace Zadanie7
{
    internal class Zad7
    {

        static void Wyswietl_tablice(int[] tablica)
        {
            foreach (int element in tablica)
            {
                Console.Write(element + " ");
                Console.WriteLine("");
            }
        }

        static void Sortowanie_babelkowe(int[] tablica)
        {
            int n = tablica.Length;
            bool zamiana;

            do
            {
                zamiana = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int temp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = temp;
                        zamiana = true;
                    }
                }
            } while (zamiana);
            Console.WriteLine("Sortowanie bąbelkowe: ");
            Wyswietl_tablice(tablica);
        }

        static void Sortowanie_przez_wstawianie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 1; i < n; i++)
            {
                int aktualnyElement = tablica[i];
                int j = i - 1;

                while (j >= 0 && tablica[j] > aktualnyElement)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                }

                tablica[j + 1] = aktualnyElement;
            }
            Console.WriteLine("Sortowanie przez wstawianie: ");
            Wyswietl_tablice(tablica);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę podać ilość liczb do przekazania: ");
            int a = (int)Convert.ToInt64(Console.ReadLine());


            int[] tab = new int[a];
            for (int i = 0; i < a; i++) 
            {
                tab[i] = (int)Convert.ToInt64(Console.ReadLine());
                Console.Clear();
            }

            Sortowanie_babelkowe(tab);
            Sortowanie_przez_wstawianie(tab);

        }
    }
}