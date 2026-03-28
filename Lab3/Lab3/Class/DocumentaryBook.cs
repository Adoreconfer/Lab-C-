using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Class
{
    public class DocumentaryBook : Book
    {
        public int Year { get; private set; }

        public DocumentaryBook(Book book, int year) : base(book.Title, book.Author, book.Data)
        {
            Year = year;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine("Rok: " + Year);
        }
    }
}
