namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RandomlyThrowException();
            }
            catch (CustomException1 e)
            {
                Console.WriteLine("Złapano CustomException1: " + e.Message);
            }
            catch (CustomException2 e)
            {
                Console.WriteLine("Złapano CustomException2: " + e.Message);
            }
            catch (CustomException3 e)
            {
                Console.WriteLine("Złapano CustomException3: " + e.Message);
            }
        }
        static void RandomlyThrowException()
        {
            Random random = new Random();
            int choice = random.Next(1, 4);

            switch (choice)
            {
                case 1:
                    throw new CustomException1("To jest CustomException1.");
                case 2:
                    throw new CustomException2("To jest CustomException2.");
                case 3:
                    throw new CustomException3("To jest CustomException3.");
                default:
                    throw new InvalidOperationException("Nieoczekiwany błąd.");
            }
        }
    }
}