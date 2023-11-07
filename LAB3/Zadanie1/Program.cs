namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person ("Jan", "Nowak", 34),
                new Person ("Marek", "Nowakowski", 52),
                new Person ("Marija", "Nowak", 27),
                new Person ("Adam", "Mickiewicz", 77)
            };

            Book[] books = new Book[]
            {
                new Book("Nadniemnem", people[0], new DateTime(2023, 11, 07)),
                new Book("Anaruk", people[1], new DateTime(2022, 03, 07)),
                new Book("Wesele", people[2], new DateTime(2021, 01, 13)),
                new Book("Dziady III", people[3], new DateTime(2021, 07, 17))
            };

            Console.WriteLine("Dostępne osoby: ");
            foreach (Person item in people)
            {
                item.View();
            }
            Console.WriteLine("\nDostępne książki: ");
            for (int i = 0; i < books.Length; i++)
            {
                books[i].View();
            }
        }
    }
}