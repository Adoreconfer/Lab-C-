using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Class
{
    class Reviewer : Reader
    {
        public Reviewer(Reader reader, List<Book> books) : base(new Person(reader.FirstName, reader.LastName, reader.Wiek), reader.Books)
        {
            this.Books = books;
        }

        public void Wypisz()
        {
            foreach (var book in Books)
            {
                Random rand = new Random();
                Console.WriteLine(book.Title + " ocena: " + rand.Next(11));
            }
        }

        public override void View()
        {
            Console.Write("Recenzenta: " + FirstName + " " + LastName + "\n");
            ViewBook();
        }
    
    }
}
