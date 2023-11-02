namespace Zadanie6
{
    internal class Zad6
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Podaj liczbę całkowitą: ");

                int a = (int)Convert.ToInt64(Console.ReadLine());

                if (a < 0)
                {
                    Console.WriteLine("Podano liczbę mniejszą od zera! Koniec programu.");
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}