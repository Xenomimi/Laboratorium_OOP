namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaPrzyklad jakisObiekt = new KlasaPrzyklad();
            try
            {
                jakisObiekt.CanThrowException("Instrukcja 1");
                jakisObiekt.CanThrowException("Instrukcja 2");
                jakisObiekt.CanThrowException("Instrukcja 3");
                jakisObiekt.CanThrowException("Instrukcja 4");
                jakisObiekt.CanThrowException("Instrukcja 5");
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił wyjątek: " + e.Message);
            }
        }
    }
}