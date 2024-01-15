using System.IO;
using static System.Net.WebRequestMethods;

namespace Zadanie3
{
    internal class Program
    {
        // Napisz program wczytujący listę peseli z pliku pesels.txt, a następnie zaimplementuj funkcję
        // sprawdzającą, ile jest żeńskich peseli we wczytanym zbiorze.Plik pesel.txt należy wygenerować z
        // użyciem generatora pesel.

        static void Main(string[] args)
        {
            string path = @"__tutaj_pelna_sciezka_do_pliku__";
            StreamReader sr = System.IO.File.OpenText(path);
            string outputText = "";
            int i = 1; // licznik do linijek tekstu
            int k = 0; // licznik kobiet
            Console.WriteLine("\nZawartosc pliku:");
            //petla do wyśweitlania tekstu
            while ((outputText = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + ". " + outputText);
                if (outputText[outputText.Length - 1] % 2 == 0)
                {
                    k++;
                }
            }
            Console.WriteLine($"Znaleziono {k} kobiet.");
            sr.Close();
        }
    }
}