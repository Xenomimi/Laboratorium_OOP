namespace Zadanie4
{
    internal class Zad4
    {
        static double[] doubles = new double[10];
        static void Menu()
        {
            while (true)
            {
                View();
                int c = InputInt();
                switch (c)
                {
                    case 1: Console.Clear(); Console.WriteLine("Uzupełnianie elementów tablicy"); Uzupelnienie(); break;
                    case 2: Console.Clear(); Console.WriteLine("Suma elementów tablicy"); Suma_el(); break;
                    case 3: Console.Clear(); Console.WriteLine("Iloczyn elementów tablicy"); Iloczyn_el(); break;
                    case 4: Console.Clear(); Console.WriteLine("Wyznaczanie wartości średniej"); Srednia(); break;
                    case 5: Console.Clear(); Console.WriteLine("Wyznaczanie wartości minimalnej"); Minimalna(); break;
                    case 6: Console.Clear(); Console.WriteLine("Wyznaczanie wartości maksymalnej"); Maksymalna(); break;
                    case 7: Console.Clear(); Console.WriteLine("Wyjście"); Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Niepoprawny znak! Spróbuj jeszcze raz :)");
                        break;
                }
            }
        }

        static void View()
        {
            Console.WriteLine("=== 1. Uzupełnianie elementów tablicy ===");
            Console.WriteLine("=== 2. Suma elementów tablicy ===");
            Console.WriteLine("=== 3. Iloczyn elementów tablicy ===");
            Console.WriteLine("=== 4. Wyznaczanie wartości średniej ===");
            Console.WriteLine("=== 5. Wyznaczanie wartości minimalnej ===");
            Console.WriteLine("=== 6. Wyznaczanie wartości maksymalnej ===");
            Console.WriteLine("=== 7. Wyjście ===");
            Console.WriteLine("\n\n Twój wybór: ");
        }
        static int InputInt()
        {
            int choise = Convert.ToInt32(Console.ReadLine());
            return choise;
        }

        static void Uzupelnienie()
        {
            int licznik = 10;

            for (int i = 0; i < doubles.Length; i++)
            {
                Console.WriteLine($"Proszę podać {licznik} liczb rzeczywistych.");

                string liczba = Console.ReadLine();

                doubles[i] = Convert.ToDouble(liczba);

                Console.Clear();

                licznik--;
            }
        }

        static void Suma_el()
        {
            double suma = 0;

            foreach (var item in doubles)
            {
                suma += item;
            }

            Console.WriteLine($"Suma = {suma}");
        }

        static void Iloczyn_el()
        {
            double iloczyn = 1;

            foreach (var item in doubles)
            {
                iloczyn *= item;
            }

            Console.WriteLine($"Iloczyn elementów tablicy = {iloczyn}");
        }

        static void Srednia()
        {
            double suma = 0;

            foreach (var item in doubles)
            {
                suma += item;
            }

            Console.WriteLine($"Średnia wartości w tablicy = {suma / doubles.Length}");
        }

        static void Minimalna()
        {
            double min = doubles[0];
            for (int i = 0; i < doubles.Length; i++)
            {
                if (doubles[i] < min)
                {
                    min = doubles[i];
                }
            }

            Console.WriteLine($"Minimalna wartość w tablicy = {min}");
        }

        static void Maksymalna()
        {
            double max = doubles[0];
            for (int i = 0; i < doubles.Length; i++)
            {
                if (doubles[i] > max)
                {
                    max = doubles[i];
                }
            }

            Console.WriteLine($"Maksymalna wartość w tablicy = {max}");
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}