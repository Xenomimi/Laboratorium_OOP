using System;

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
                new Book("Nadniemnem", people[0], new DateOnly(2023, 11, 07)),
                new Book("Anaruk", people[1], new DateOnly(2022, 03, 07)),
                new Book("Wesele", people[2], new DateOnly(2021, 01, 13)),
                new Book("Dziady III", people[3], new DateOnly(2021, 07, 17))
            };

            Book[] tabBook1 = { books[0], books[1] };
            Book[] tabBook2 = { books[1], books[2] };

            Reader[] readers = new Reader[]
            {
                new Reader(tabBook1, people[0].FirstName, people[0].LastName, people[0].Wiek),
                new Reader(tabBook2, people[1].FirstName, people[1].LastName, people[1].Wiek)
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
            Console.WriteLine("\nCzytelnicy: ");
            foreach (var reader in readers)
            {
                reader.ViewBook();
            }

            Console.WriteLine($"\nZadanie 1c:");
            readers[0].View();


        }
    }
}