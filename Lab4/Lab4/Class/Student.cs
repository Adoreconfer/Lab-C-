using System;
using System.Collections.Generic;

namespace Lab4.Class
{
    public class Student : Person, IStudent
    {
        public string Uczelnia { get; }
        public string Kierunek { get; }
        public int Rok { get; }
        public int Semestr { get; }

        public Student(
            string imie,
            string nazwisko,
            string uczelnia,
            string kierunek,
            int rok,
            int semestr
        ) : base(imie, nazwisko)
        {
            Uczelnia = uczelnia;
            Kierunek = kierunek;
            Rok = rok;
            Semestr = semestr;
        }

        public string WypiszPelnaNazweIUczelnie()
        {
            return $"{Imie} {Nazwisko} – {Kierunek} {Rok} {Uczelnia}";
        }
    }
}
