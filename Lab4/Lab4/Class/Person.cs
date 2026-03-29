using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Class
{
    public class Person : IPerson
    {
        public string Imie { get;  }
        public string Nazwisko { get;  }
        public List<IPerson> Persons { get; }

        public void ZwrocPelnaNazwe() {
            Console.WriteLine($"{Imie} {Nazwisko}");        
        }
        public Person(string Imie, string Nazwisko) { 
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            Persons = new List<IPerson>();
        }

        public void WypiszOsoby() {
            foreach (IPerson person in Persons) { 
                person.ZwrocPelnaNazwe();
            }
        }
    }
}
