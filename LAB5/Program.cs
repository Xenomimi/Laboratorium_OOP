namespace LAB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poczatek = (int)DniTygodnia.Poniedzialek;
            int koniec = (int)DniTygodnia.Niedziela;

            string value = DniTygodnia.Convertible.ToString();

            Console.WriteLine("Poniedzialek {0}", poczatek);
            Console.WriteLine("Niedziela {0}", koniec);


            // Wyświetlanie wartosci enum
            foreach (int item in Enum.GetValues(typeof(DniTygodnia)))
            {
                Console.WriteLine(item);
            }

            // Wyswietlanie nazw enum
            foreach (string item in Enum.GetNames(typeof(DniTygodnia)))
            {
                Console.WriteLine(item);
            }
        }

        // Domyślnie typ wyliczeniowy jest traktowany jako liczby całkowite
        enum DniTygodnia
        {
            // Można ustawić wartosc domyślną na początku
            Poniedzialek = 1,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela,
            Convertible
        }

        enum Typ1 : byte
        {
            Poniedzialek = 1,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }
    }
}