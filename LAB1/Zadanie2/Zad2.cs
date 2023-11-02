namespace Zadanie2
{
    internal class Zad2
    {
        static void Menu()
        {
            while (true)
            {
                View();
                int c = InputInt();
                switch (c)
                {
                    case 1: Console.Clear(); Console.WriteLine("Suma"); Suma(); break;
                    case 2: Console.Clear(); Console.WriteLine("Różnica"); Roznica(); break;
                    case 3: Console.Clear(); Console.WriteLine("Iloczyn"); Iloczyn(); break;
                    case 4: Console.Clear(); Console.WriteLine("Iloraz"); Iloraz(); break;
                    case 5: Console.Clear(); Console.WriteLine("Potega"); Potega(); break;
                    case 6: Console.Clear(); Console.WriteLine("Pierwiastek"); Pierwiastek(); break;
                    case 7: Console.Clear(); Console.WriteLine("Funkcje"); Funkcje(); break;
                    case 8: Console.Clear(); Console.WriteLine("Wyjście"); Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Niepoprawny znak! Spróbuj jeszcze raz :)");
                        break;
                }
            }
        }

        static void View()
        {
            Console.WriteLine("=== Kalkulator \t===");
            Console.WriteLine("=== 1. Suma ===");
            Console.WriteLine("=== 2. Różnica ===");
            Console.WriteLine("=== 3. Iloczyn ===");
            Console.WriteLine("=== 4. Iloraz ===");
            Console.WriteLine("=== 5. Potęgowanie ===");
            Console.WriteLine("=== 6. Pierwiastek kwadratowy ===");
            Console.WriteLine("=== 7. Funkcje trygonometryczne ===");
            Console.WriteLine("=== 8. Wyjście ===");
            Console.WriteLine("\n\n Twój wybór: ");
        }

        static int InputInt()
        {
            int choise = Convert.ToInt32(Console.ReadLine());
            return choise;
        }

        static void Suma()
        {
            Console.WriteLine("Podaj x: ");
            int x = InputInt();
            Console.WriteLine("Podaj y: ");
            int y = InputInt();

            int suma = x + y;

            Console.WriteLine($"{x} + {y} = {suma}");
        }

        static void Roznica()
        {
            Console.WriteLine("Podaj x: ");
            int x = InputInt();
            Console.WriteLine("Podaj y: ");
            int y = InputInt();

            int roznica = x - y;

            Console.WriteLine($"{x} - {y} = {roznica}");
        }

        static void Iloczyn()
        {
            Console.WriteLine("Podaj x: ");
            int x = InputInt();
            Console.WriteLine("Podaj y: ");
            int y = InputInt();

            int iloczyn = x * y;

            Console.WriteLine($"{x} * {y} = {iloczyn}");
        }

        static void Iloraz()
        {
            Console.WriteLine("Podaj x: ");
            int x = InputInt();
            Console.WriteLine("Podaj y: ");
            int y = InputInt();

            if (y == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0!");
            }
            else
            {
                float dziel = x / y;
                Console.WriteLine($"{x} / {y} = {dziel}");
            }
        }

        static void Potega()
        {
            Console.WriteLine("Podaj x: ");
            double x = InputInt();
            Console.WriteLine("Podaj n: ");
            double n = InputInt();

            double wynik = Math.Pow(x, n);

            Console.WriteLine($"{x}^{n} = {wynik}");
        }

        static void Pierwiastek()
        {
            // Pierwiastek
            Console.WriteLine("Podaj liczbe do pierwiastkowania");
            double x = InputInt();

            double wynik = Math.Sqrt(x);

            Console.WriteLine($"Pierwiastek z {x} = {wynik}");

        }

        static void Funkcje()
        {
            Console.WriteLine("Podaj x: ");
            int x = InputInt();

            double rad = x * Math.PI / 180;

            double wynik = Math.Sin(rad);

            Console.WriteLine($"Sinus kata alfa = {wynik}");
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}