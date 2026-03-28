using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Class
{
    class SamochodOsobowy : Samochod
    {
        private float _waga;
        public float Waga {
            get { return _waga; }
            private set {
                if (value > 2 && value < 4.5)
                {
                    _waga = value;
                }
                else {
                    _waga = 2;
                }
            }
        }

        private float _pojemnosc;
        public float Pojemnosc
        {
            get { return _pojemnosc; }
            private set
            {
                if (value > 0.3 && value < 0.8)
                {
                    _pojemnosc = value;
                }
                else {
                    _pojemnosc = 0.3F;
                }
            }
        }

        public int IloscOsob { get; private set; }

        public SamochodOsobowy(Samochod samochod, float Waga, float Pojemnosc, int IloscOsob) 
            : base(samochod.Marka, samochod.Model, samochod.Nadwozie, samochod.Kolor, samochod.Rok, samochod.RokProdukcji, samochod.Przebieg) 
        { 
            this.Waga = Waga;
            this.Pojemnosc = Pojemnosc;
            this.IloscOsob = IloscOsob;
        }

        public override void View()
        { 
            base.View();
            Console.Write($"Waga = {Waga}, Pojemność silnika = {Pojemnosc}, Ilość osób = {IloscOsob}");
        }

    }
}
