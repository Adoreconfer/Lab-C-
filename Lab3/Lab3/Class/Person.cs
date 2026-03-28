using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Class
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Wiek { get; private set; }

        public Person(string FirstName, string LastName, int Wiek)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Wiek = Wiek;
        }

        public override string? ToString()
        {
            return "Autor: " + FirstName + " " + LastName;
        }

        public virtual void View()
        {
            Console.WriteLine(ToString());
        }
    }
}
