using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Class
{
    public class Book
    {
        public string Title { get; private set; }
        public Person Author { get; private set; }
        public string Data { get; private set; }

        public Book(string Title, Person Author, string Data){ 
            this.Title = Title;
            this.Data = Data;
            this.Author = Author;
        }

        public override string? ToString()
        {
            return Author.ToString() + ", tytuł: " + Title + ", data wydania: " + Data;
        }

        public virtual void View() {
            Console.WriteLine(ToString());
        }
    }
}
