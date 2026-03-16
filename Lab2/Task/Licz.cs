using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Task
{
    public class Licz
    {
        private double value;

        public Licz(double value) {
            this.value = value;
        }

        public void Dodaj(double liczba) {
            value += liczba;
        }

        public void Odejmij(double liczba)
        {
            value -= liczba;
        }

        public void view() { 
            Console.WriteLine("Liczba = " + value);
        }
    }
}
