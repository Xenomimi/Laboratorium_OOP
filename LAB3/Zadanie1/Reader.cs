using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Reader : Person
    {
        Book[] readBooks = new Book[]
        {
                new Book("Nadniemnem", , new DateTime(2023, 11, 07)),
                new Book("Anaruk", people[1], new DateTime(2022, 03, 07)),
                new Book("Wesele", people[2], new DateTime(2021, 01, 13)),
        };

        public Reader(Book readBooks) : base(firstName, lastName, age)
        {
            
        }

        public void ViewBook()
        {
            foreach (Book book in books) 
            {
                Console.WriteLine(book);
            }
        }
    }
}
