using Lab3.Class;

namespace Lab3.Task
{
    internal class TaskLab
    {
        /// <summary>
        /// Metoda urushomienia dla zadań
        /// </summary>
        /// <remarks>
        /// Autor: Diana Vaida
        /// data: 23.03.2026
        /// środowisko: .net10
        /// </remarks>    
        public void Run()
        {
            int wybor = inputInt("Podaj numer zadania [1-2]");
            switch (wybor)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                default:
                    Console.WriteLine("Nie ma takiego zadania");
                    break;
            }
        }

        ///<summary>
        /// Zadanie 1
        /// </summary>
        private void Task1() {
            Console.WriteLine("a");
            Person person = new Person("Adam", "Mickiewicz", 56);
            Book book = new Book("Dziady 1", person, "1860 r.");
            Book book1 = new Book("Dziady 2", person, "1823 r.");
            Book book2 = new Book("Dziady 3", person, "1832 r.");
            book.View();
            person.View();

            Console.WriteLine("b");
            List<Book> books = new List<Book>();
            books.Add(book);
            books.Add(book1);
            books.Add(book2);
            Reader reader = new Reader(new Person("Jan", "Kowalski", 12), books);
            reader.ViewBook();

            Console.WriteLine();
            
            List<Book> books1 = new List<Book>();
            books1.Add(book);
            books1.Add(book1);
            Reader reader1 = new Reader(new Person("Anna", "Nowak", 10), books1);
            reader1.ViewBook();

            Console.WriteLine();

            Console.WriteLine("c");
            reader1.View();

            Console.WriteLine("\nd");
            Person o = new Reader(person, books);
            o.View();

            Console.WriteLine("\nf");
            Reviewer reviewer = new Reviewer(reader, books1);
            reviewer.View();

            Console.WriteLine("\ng");
            List<Person> persons = new List<Person>();
            persons.Add(reader);
            persons.Add(reviewer);
            foreach (Person p in persons) {
                p.View();
            }

            reviewer.Wypisz();

            Console.WriteLine("\nj");
            Book doc = new DocumentaryBook(book1, 1800);
            Book adv = new AdventureBook(book1, "Ziemia");
            doc.View();
            adv.View();
        }

        ///<summary>
        /// Zadanie 2
        /// </summary>
        private void Task2() {
            Samochod auto1 = new Samochod("Toyota", "Corolla", "Sedan", "Srebrny", 2020, 2019, 84500);
            Samochod auto2 = new Samochod("Toyota", "Corolla", 2020);
            Samochod osobowy1 = new SamochodOsobowy(auto1, 2f, 0.4f, 4);
            
            auto1.View();
            auto2.View();
            osobowy1.View();
        }

        ///<summary>
        ///Metoda która pobiera string usera i wykonuje konwersje na double. Wymusza poprawne podanie liczby
        /// </summary>
        private double inputDouble(string prompt)
        {
            double liczba;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out liczba))
                {
                    return liczba;
                }
                Console.Write("Błędna wartość, podaj poprawną liczbę!");
            }

        }

        ///<summary>
        ///Metoda która pobiera string usera i wykonuje konwersje na int. Wymusza poprawne podanie liczby
        /// </summary>
        private int inputInt(string prompt)
        {
            int liczba;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out liczba))
                {
                    return liczba;
                }
                Console.Write("Błędna wartość, podaj poprawną liczbę!");
            }

        }
    }
}
