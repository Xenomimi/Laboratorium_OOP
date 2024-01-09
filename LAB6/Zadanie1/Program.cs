namespace Zadanie1
{
    internal class Program
    {
        // Napisz program pozwalający na zapisanie do pliku o wskazanej nazwie, nr albumu osoby, która
        // napisała program
        static void Main(string[] args)
        {
            StreamWriter sw;

            Console.Write("Proszę podac nazwe pliku: ");
            string nazwa = Console.ReadLine();
            string path = nazwa + ".txt";
            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("Plik zostal utworzony");
            }
            else
            {
                //dopisywanie tesktu do pliku
                sw = new StreamWriter(path, true);
                Console.WriteLine("Podaj teskt: ");
                string text = Console.ReadLine();
                //zapisanie do pliku
                sw.WriteLine(text);
                //zamkniecie pliku
                sw.Close();
            }


        }
    }
}