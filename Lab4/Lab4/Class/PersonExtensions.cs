using System;
using System.Collections.Generic;

namespace Lab4.Class
{
    public static class PersonExtensions
    {
        public static void WypiszOsoby(this List<IPerson> osoby)
        {
            foreach (var osoba in osoby)
            {
                osoba.ZwrocPelnaNazwe();
            }
        }

        public static void WypiszOsoby(this List<IStudent> studenci)
        {
            foreach (var student in studenci)
                Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
        }

        public static void PosortujOsobyPoNazwisku(this List<IPerson> osoby)
        {
            osoby.Sort((a, b) => string.Compare(a.Nazwisko, b.Nazwisko, StringComparison.OrdinalIgnoreCase));

        }
    }
}
