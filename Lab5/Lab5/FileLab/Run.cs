using Lab5.Task;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lab5.FileLab
{
    internal class Run
    {
        public void runSystem() {

            string fileTxt = "contacts.txt";
            string fileJson = "contacts.json";
            string filePopulationJson = "db.json";

            TxtContactRepository txtContactRepository = new TxtContactRepository(fileTxt);
            JsonContactRepository jsonContactRepository = new JsonContactRepository(fileJson);

            JsonPopulationRepository jsonPopulationRepository = new JsonPopulationRepository(filePopulationJson);

            List<Contact> contacts = new List<Contact>();
            List<Population> populations = new List<Population>();

            populations = jsonPopulationRepository.GetPopulation();

            bool exit = false;
            int value;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Zadanie 1");
                Console.WriteLine("--- System zarządzania kontami ---");
                Console.WriteLine("1. Dodaj kontakt");
                Console.WriteLine("2. Wyświetl kontakt");
                Console.WriteLine("3. Zapisz kontakty do TXT");
                Console.WriteLine("4. Odczytaj kontakty z TXT");
                Console.WriteLine("5. Zapisz kontakty do JSON");
                Console.WriteLine("6. Odczytaj kontakty z JSON");
                Console.WriteLine();
                Console.WriteLine("Zadanie 2");
                Console.WriteLine("7. Ile wynosi różnica populacji pomiędzy rokiem 1970 a 2000 dla Indii");
                Console.WriteLine("8. Ile wynosi różnica populacji pomiędzy rokiem 1965 a 2010 dla USA");
                Console.WriteLine("9. Ile wynosi różnica populacji pomiędzy rokiem 1980 a 2018 dla Chin");
                Console.WriteLine("10. Wyświetl populację dla wybranego kraju i roku");
                Console.WriteLine("11. Różnica populacji dla wybranego kraju i zakresu lat");
                Console.WriteLine("12. Procentowy wzrost populacji rok-do-roku dla kraju");
                Console.WriteLine("0. Wyjście");

                Console.WriteLine("Wybierz opcję: ");

                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        AddContact(contacts);
                        break;
                    case "2":
                        ViewContact(contacts);
                        break;
                    case "3":
                        txtContactRepository.Save(contacts);
                        Console.WriteLine("Dane zostały zapisane do pliku TXT");
                        Pause();
                        break;
                    case "4":
                        contacts = txtContactRepository.GetContacts();
                        Console.WriteLine("Dane zostały odczytane z pliku TXT");
                        Pause();
                        break;
                    case "5":
                        jsonContactRepository.Save(contacts);
                        Console.WriteLine("Dane zostały zapisane do pliku JSON");
                        Pause();
                        break;
                    case "6":
                        contacts = jsonContactRepository.GetContacts();
                        Console.WriteLine("Dane zostały odczytane z pliku JSON");
                        Pause();
                        break;
                    case "7":
                        value = populationValue(populations, "2000", "India") - populationValue(populations, "1970", "India");
                        Console.WriteLine(value);
                        Pause();
                        break;
                    case "8":
                        value = populationValue(populations, "2010", "United States") - populationValue(populations, "1965", "United States");
                        Console.WriteLine(value);
                        Pause();
                        break;
                    case "9":
                        value = populationValue(populations, "2018", "China") - populationValue(populations, "1980", "China");
                        Console.WriteLine(value);
                        Pause();
                        break;
                    case "10":
                        ShowPopulation(populations);
                        Pause();
                        break;
                    case "11":
                        ShowPopulationDifference(populations);
                        break;
                    case "12":
                        ShowPopulationGrowth(populations);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja!");
                        Pause();
                        break;
                }
            }
        
        }

        private void ShowPopulationGrowth(List<Population> populations)
        {
            Console.Clear();
            Console.WriteLine("Podaj kraj:");
            string country = Console.ReadLine();

            Console.WriteLine("Podaj rok końcowy (wzrost będzie liczony względem roku poprzedniego):");
            string year = Console.ReadLine();

            int current = populationValue(populations, year, country);
            int previous = populationValue(populations, (Int32.Parse(year) - 1).ToString(), country);

            if (current == 0 || previous == 0)
            {
                Console.WriteLine("Brak danych dla podanego kraju lub lat.");
            }
            else
            {
                double growth = ((double)(current - previous) / previous) * 100.0;
                Console.WriteLine($"Wzrost populacji w {country} w roku {year} względem {Int32.Parse(year) - 1}: {growth:F2}%");
            }

            Pause();
        }


        private void ShowPopulationDifference(List<Population> populations)
        {
            Console.Clear();
            Console.WriteLine("Podaj kraj:");
            string country = Console.ReadLine();

            Console.WriteLine("Podaj rok początkowy:");
            string yearStart = Console.ReadLine();

            Console.WriteLine("Podaj rok końcowy:");
            string yearEnd = Console.ReadLine();

            int start = populationValue(populations, yearStart, country);
            int end = populationValue(populations, yearEnd, country);

            if (start == 0 || end == 0)
            {
                Console.WriteLine("Brak danych dla podanych lat lub kraju.");
            }
            else
            {
                Console.WriteLine($"Różnica populacji w {country} między {yearStart} a {yearEnd}: {end - start}");
            }

            Pause();
        }


        private void ShowPopulation(List<Population> populations)
        {
            Console.Clear();
            Console.WriteLine("Podaj kraj:");
            string country = Console.ReadLine();

            Console.WriteLine("Podaj rok:");
            string year = Console.ReadLine();

            var pop = populations.FirstOrDefault(p => p.country.value == country && p.date == year);

            if (pop == null || pop.value == null)
            {
                Console.WriteLine("Brak danych.");
            }
            else
            {
                Console.WriteLine($"Populacja {country} w roku {year}: {pop.value}");
            }
        }


        public int populationValue(List<Population> populations, string _date, string _country)
        {
            foreach (Population p in populations)
            {
                if (p.date == _date && p.country.value == _country)
                {
                    if (int.TryParse(p.value, out int result))
                        return result;
                }
            }
            return 0;
        }

        private void ViewContact(List<Contact> contacts)
        {
            Console.Clear();
            foreach (Contact contact in contacts) {
                Console.WriteLine(contact.ToString());
            }
            Pause();
        }

        private void AddContact(List<Contact> contacts)
        {
            Console.Clear();
            Console.WriteLine("---- Dodawanie kontaktów ----");

            int id = GenerateId(contacts);

            Console.WriteLine("Podaj imię i nazwisko");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj email");
            string email = Console.ReadLine();


            Contact contact = new Contact(id, name, email);

            contacts.Add(contact);

            Console.WriteLine("Kontakt został dodany. ");
            Pause();
        }

        private int GenerateId(List<Contact> contacts)
        {
           if(contacts.Count == 0) return 1;

           return contacts.Max(c => c.Id) + 1;
        }

        private void Pause() {
            Console.WriteLine();    
            Console.WriteLine("Naciśnij Enter");
            Console.ReadLine();
        }
    }
}
