using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Class
{
    public class Reader : Person
    {
        public List<Book> Books = new List<Book>();

        public Reader(Person person, List<Book> books): base(person.FirstName, person.LastName, person.Wiek)
        {
            this.Books = books;
        }

        public void ViewBook() {
            foreach (var book in Books)
            {
                Console.WriteLine(book.Title);
            }
        }

        public override void View(){
            Console.Write("Czytelnik: " + FirstName + " " + LastName + "\n");
            ViewBook();
        }
    }
}
