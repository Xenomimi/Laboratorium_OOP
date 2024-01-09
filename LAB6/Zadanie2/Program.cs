namespace Zadanie2
{
    internal class Program
    {
        // Napisz program pozwalający na wczytanie zawartości pliku o wskazanej nazwie
        static void Main(string[] args)
        {
            Console.Write("Podaj nazwe pliku do wczytania: ");
            string nazwa = Console.ReadLine();
            if (File.Exists(nazwa))
            {
                string content = File.ReadAllText(nazwa);
                Console.WriteLine("Zawartość pliku:");
                Console.WriteLine(content);
            }
        }
    }
}