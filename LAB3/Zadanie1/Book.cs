using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Book
    {
        private string title;
        Person author;
        private DateTime datePublication;
        

        public Book(string title, Person author, DateTime datePublication) 
        {
            this.title = title;
            this.author = author;
            this.datePublication = datePublication;
        }

        public void View()
        {
            Console.WriteLine($"\nTytuł: {title}" + $"\nAuthor:"); author.View();
            //author.View();
            Console.WriteLine($"Data wydania: " + $"{datePublication.ToShortDateString()}\n");
        }
    }
}
