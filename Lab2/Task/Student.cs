using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab2.Task
{
    public class Student
    {
        private string imie;
        private string nazwisko;
        private List<double> oceny = new List<double>();

        public Student(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public double SredniaOcen() { 
            double sum = 0;

            for (int i = 0; i < oceny.Count; i++) { 
                sum += oceny[i];
            }

            return sum/oceny.Count;

        }
        public void DodajOcene(int ocena) {
            oceny.Add(ocena);
        }

        public void view() {
            Console.Write("Imię: " + imie + ", nazwisko: " + nazwisko + ", Oceny: ");
            foreach (int ocena in oceny) {
                Console.Write(ocena + ", ");
            }
            Console.Write("Średnia: " + SredniaOcen());
        }
    }   
}
