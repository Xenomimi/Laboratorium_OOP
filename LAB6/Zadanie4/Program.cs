using System.Numerics;
using Newtonsoft.Json;

namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wczytanie pliku JSON
            string countrySerialized = File.ReadAllText(@"C:\Users\ezesl\source\repos\SerializeExample\playerSerialized.json");

            //odtworzenie info o panstwie na podstawie pliku do obiektu
            Country country = JsonConvert.DeserializeObject<Country>(countrySerialized);

            Console.WriteLine(country);
        }
    }
}