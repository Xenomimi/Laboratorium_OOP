namespace Wyjatki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wiek age = new Wiek();

            try
            {
                age.CheckAge(-12);
            }
            catch (MyClassException e)
            {
                Console.WriteLine("Mój wyjatek: {0}", e.Message);
            }
        }
    }
}