using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Task
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public string Imie {
            get { return imie; }
            set
            {
                if (value.Length >= 2)
                {
                    imie = value;
                }
                else {
                    imie = "";
                }
            }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (value.Length >= 2)
                {
                    nazwisko = value;
                }
                else
                {
                    nazwisko = "";
                }
            }
        }

        public int Wiek { 
            get { return wiek; }
            set {
                if (value > 0)
                {
                    wiek = value;
                }
                else { 
                    wiek = 0;
                }
            }
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Imie: " + imie + ", nazwisko: " + nazwisko + ", wiek: " + wiek + "\n");
        }

    }
}
