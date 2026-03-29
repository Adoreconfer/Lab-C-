using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Class
{
    class Uczen : Osoba
    {
        public string Szkola { get; private set; }
        public bool MozeSamWracacDoDomu { get; private set; }

        public Uczen(Osoba osoba,string szkola, bool mozeSamWracacDoDomu) : base(osoba.FirstName, osoba.LastName, osoba.Pesel)
        {
            Szkola = szkola;
            MozeSamWracacDoDomu = mozeSamWracacDoDomu;
        }

        public void SetSchool(string school) { 
            Szkola = school;
        }

        public void ChangeSchool(string school)
        {
            Szkola = school;
        }

        public void SetCanGoHomeAlone(bool _bool)
        {
            MozeSamWracacDoDomu = _bool;
        }

        public override string GetEducationInfo()
        {
            return $"Szkoła: {Szkola}";
        }

        public override string GetFullName()
        {
            return $"Uczeń: {FirstName} {LastName}";
        }

        public override bool CanGoAloneToHome() {
            if (GetAge() >= 12)
            {
                return true;
            }
            return false;
        }
    }
}
