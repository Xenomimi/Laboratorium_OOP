using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Zadanie1
{
    internal class Reader : Person
    {
        private Book[] readBooks;

        public Reader(Book[] readBooks, string FirstName, string LastName, int Wiek) : base(FirstName, LastName, Wiek)
        {
            this.readBooks = readBooks;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Wiek = Wiek;
        }

        public Book[] ReadBooks {
            get { return readBooks; }
            set { }
        }

        public new void View()
        {
            base.View();
            ViewBook();
        }

        public void ViewBook()
        {
            foreach (Book book in readBooks)
            {
                Console.WriteLine($"Tytuł {book.Title} \t Autor: {book.Author.FirstName} {book.Author.LastName}");
            }
        }
    }
}
