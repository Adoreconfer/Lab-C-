using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Class
{
    public class AdventureBook : Book
    {
        public string WorldName { get; private set; }

        public AdventureBook(Book book, string worldName): base(book.Title, book.Author, book.Data)
        {
            WorldName = worldName;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine("Nazwa świata: " + WorldName);
        }
    }
}
