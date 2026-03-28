using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Class
{
    class Samochod
    {
        public string Marka { get; private set; }
        public string Model { get; private set; }
        public string Nadwozie { get; private set; }
        public string Kolor { get; private set; }
        public int Rok { get; private set; }
        public int RokProdukcji { get; private set; }
        private int _przebieg;
        public int Przebieg
        {
            get { return _przebieg; }

            private set
            {
                if (value > -1)
                    _przebieg = value;
                else
                    _przebieg = 0;
            }
        }


        public Samochod(string Marka, string Model, string Nadwozie, string Kolor, int Rok, int RokProdukcji, int Przebieg) {
            this.Marka = Marka;
            this.Model = Model;
            this.Nadwozie = Nadwozie;
            this.Kolor = Kolor;
            this.Rok = Rok;
            this.RokProdukcji = RokProdukcji;
            this.Przebieg = Przebieg;
        }

        public Samochod(string Marka, string Model, int Rok) {
            this.Marka = Marka;
            this.Model = Model;
            this.Rok = Rok;
        }

        public virtual void View() {
            Console.WriteLine($"Marka = {Marka}, Model = {Model}, Nadwozie = {Nadwozie}, Kolor = {Kolor}, Rok produkcji = {RokProdukcji}, Przebieg = {Przebieg}");         
        }

    }
}
