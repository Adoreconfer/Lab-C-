using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Class
{
    class Osoba
    {
        public string FirstName;
        public string LastName;
        public string Pesel;
        private int Age;
        private string Gender;

        public Osoba(string FirstName, string LastName, string Pesel)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Pesel = Pesel;
            Age = GetAge();
            Gender = GetGender();
        }

        public void SetFirstName(string FirstName) { this.FirstName = FirstName; }

        public void SetLastName(string LastName) { this.LastName = LastName; }
        public void SetPesel(string Pesel) { this.Pesel = Pesel; }

        public int GetAge() {
            int year = Int32.Parse(Pesel.Substring(0, 2));
            int month = Int32.Parse(Pesel.Substring(2, 2));
            if (month > 0 && month < 13) {
                year += 1900;
            }
            else if (month > 20 && month < 33) {
                year += 2000;
            }
            else if (month > 40 && month < 53)
            {
                year += 2100;
            }
            else if (month > 60 && month < 73)
            {
                year += 2200;
            }
            else if (month > 80 && month < 93)
            {
                year += 1800;
            }
            
            return DateTime.Now.Year - year;
        }
        public string GetGender() {
            char gender = Pesel[10];
            if (gender % 2 == 0)
            {
                return "K";
            }
            else {
                return "M";
            }
        }

        public virtual string GetEducationInfo()
        {
            return "Brak danych o edukacji";
        }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public virtual bool CanGoAloneToHome()
        {
            return false;
        }


        public void View() {
            Console.WriteLine($"Imie: {FirstName}, Nazwisko: {LastName}, Age: {GetAge()}, Pełeć: {GetGender()}");
        }
    }
}
