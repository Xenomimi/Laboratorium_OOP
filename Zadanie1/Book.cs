using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Book
    {
        private string title;
        private Person author;
        private DateOnly datePublication;


        public Book(string title, Person author, DateOnly datePublication)
        {
            this.title = title;
            this.author = author;
            this.datePublication = datePublication;
        }

        public string Title { 
            get { return title; }
            set { } 
        }

        public Person Author {
            get { return author; }
            set { }
        }

        public void View()
        {
            Console.WriteLine($"\nTytuł: {title}" + $"\nAuthor: {author.FirstName} {author.LastName} Wiek: {author.Wiek}");
            Console.WriteLine($"Data wydania: " + $"{datePublication.ToShortDateString()}\n");
        }
    }
}
