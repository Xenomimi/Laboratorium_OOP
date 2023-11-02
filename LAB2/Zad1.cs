namespace LAB2
{
    internal class Zad1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Zadanie 1 ===");

            Licz obiekt1 = new Licz(5);
            Licz obiekt2 = new Licz(10);
            // Zmiana wartości na obiekcie 'dodawanie'
            Console.WriteLine("Operacje na obiekcie obiekt1: ");
            //Console.WriteLine(obiekt1.value);
            obiekt1.Wyswietl();
            obiekt1.Dodaj(250);
            //Console.WriteLine(obiekt1.value);
            obiekt1.Wyswietl();
            obiekt1.Odejmij(42);
            //Console.WriteLine(obiekt1.value);
            obiekt1.Wyswietl();
            Console.WriteLine("Operacje na obiekcie obiekt2: ");
            //Console.WriteLine(obiekt2.value);
            obiekt2.Wyswietl();
            obiekt2.Dodaj(1000);
            //Console.WriteLine(obiekt2.value);
            obiekt2.Wyswietl();
            obiekt2.Odejmij(1);
            //Console.WriteLine(obiekt2.value);
            obiekt2.Wyswietl();

            Console.WriteLine("=== Zadanie 2 ===");

            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Sumator sumator = new Sumator(tab);
            Console.WriteLine("Funkcja Suma(): ");
            Console.WriteLine(sumator.Suma());
            Console.WriteLine("Funkcja SumaPodziel2(): ");
            Console.WriteLine(sumator.SumaPodziel2());
            Console.WriteLine("Funkcja IleElementow(): ");
            Console.WriteLine(sumator.IleElementow());
            sumator.Wyswietl();
            sumator.Wyswietl_zakres(3, 7);

            Console.WriteLine("\n" + "=== Zadanie 3 ===");

            Daty mojaData = new Daty();
            Console.WriteLine("Bieżąca data: " + mojaData.PobierzBiezacaDate());
            mojaData.PrzesunWprzodOTydzien();
            Console.WriteLine("Data po przesunięciu o tydzień w przód: " + mojaData.PobierzBiezacaDate());
            mojaData.PrzesunWsteczOTydzien();
            Console.WriteLine("Data po przesunięciu o tydzień wstecz: " + mojaData.PobierzBiezacaDate());

            Console.WriteLine("\n" + "=== Zadanie 4 ===");

            Liczba liczba = new Liczba("2");
            Console.WriteLine("Liczba: " + liczba.ToString());
            liczba.PomnozPrzez(6);
            Console.WriteLine("Liczba po mnożeniu przez 5: " + liczba.ToString());
            int silnia = liczba.Silnia();
            Console.WriteLine("Silnia liczby: " + silnia);
        }
    }
}