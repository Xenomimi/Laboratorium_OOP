using System.Numerics;
using Newtonsoft.Json;

namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wczytanie pliku JSON
            string countrySerialized = File.ReadAllText(@"D:\Users\micha\Desktop\LAB_OOP\LAB6\Zadanie4\db.json");

            //odtworzenie info o panstwie na podstawie pliku do obiektu
            List<CountryData> countries = JsonConvert.DeserializeObject<List<CountryData>>(countrySerialized);

            // Przekazanie danych do klasy Population
            Population population = new Population(countries);

            population.GetPopulationDifference("India", "1970", "2000");
            population.GetPopulationDifference("United States", "1965", "2010");
            population.GetPopulationDifference("China", "1970", "2000");

            // Wybranie przez użytkownika kraju i roku i wyświetlenie populacji
            Console.WriteLine("\nWybranie przez użytkownika kraju i roku i wyświetlenie populacji.");
            Console.Write("Podaj kraj: ");
            string country = Console.ReadLine();
            Console.Write("Podaj rok: ");
            string year = Console.ReadLine();
            Console.WriteLine($"Populacja dla kraju {country} w roku {year} wynosi {population.GetPopulationForYear(country, year)} \n");

            // Wybranie przez użytkownika kraju oraz dwóch lat i wyświetlenie różnicy populacji
            Console.WriteLine("Wybranie przez użytkownika kraju oraz dwóch lat i wyświetlenie różnicy populacji");
            Console.Write("Podaj kraj: ");
            string country2 = Console.ReadLine();
            Console.Write("Podaj rok 1: ");
            string year1 = Console.ReadLine();
            Console.Write("Podaj rok 2: ");
            string year2 = Console.ReadLine();
            population.GetPopulationDifference(country2, year1, year2);
            Console.WriteLine();

            // Wybranie przez użytkownika kraju i roku i wyświetlenie rocznego wzrostu procentowego populacji
            Console.WriteLine("Wybranie przez użytkownika kraju i roku i wyświetlenie rocznego wzrostu procentowego populacji");
            Console.Write("Podaj kraj: ");
            string country3 = Console.ReadLine();
            Console.Write("Podaj rok: ");
            string year3 = Console.ReadLine();
            double wynik = population.GetAnnualPopulationGrowthPercentage(country3, year3);
            Console.WriteLine($"Roczny wzrost procentowy populacji dla kraju {country3} w roku {year3} wynosi {wynik}% \n");
        }
    }
}