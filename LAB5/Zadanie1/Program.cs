using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dlugosc(null);
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił wyjątek: " + e.Message);
                Console.WriteLine("Ślad stosu:");
                Console.WriteLine(e.StackTrace);

                // Ponowne zgłoszenie wyjątku z dołączeniem jako przyczyny
                throw new Exception("Nowy wyjątek z oryginalnym wyjątkiem jako przyczyną", e);
            }
        }

        static void Dlugosc(string napis)
        {
            // Ta linia zgłosi wyjątek NullReferenceException, jeśli napis jest null
            Console.WriteLine("Długość napisu: " + napis.Length);
        }
    }
}