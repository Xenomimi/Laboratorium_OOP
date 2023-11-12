namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamochodOsobowy samochodOsobowy = new SamochodOsobowy();

            Samochod samochod1 = new Samochod();

            Samochod samochod2 = new Samochod("Opel", "Astra", "Combi", "Czerwony", 1995, 20000);

            Console.Clear();

            Console.WriteLine("samochodOsobowy: ");

            samochodOsobowy.View();

            Console.WriteLine();

            Console.WriteLine("samochod1: ");

            samochod1.View();

            Console.WriteLine();

            Console.WriteLine("samochod2: ");

            samochod2.View();
        }
    }
}