using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace Lab2.Task
{
    internal class TaskLab
    {
        /// <summary>
        /// Metoda urushomienia dla zadań
        /// </summary>
        /// <remarks>
        /// Autor: Diana Vaida
        /// data: 16.03.2026
        /// środowisko: .net10
        /// </remarks>    
        public void Run()
        {
            int wybor = inputInt("Podaj numer zadania [1-5]");
            switch (wybor)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
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
            Osoba osoba = new Osoba("Jan", "Kowalski", 23);
            osoba.WyswietlInformacje();
        }

        ///<summary>
        /// Zadanie 2
        /// </summary>
        private void Task2()
        {
            BankAccount account = new BankAccount("Jan Kowalski", 1000);
            account.Wplata(500);
            account.Wyplata(200);
            Console.WriteLine($"Saldo: {account.Saldo}");
        }

        ///<summary>
        /// Zadanie 3
        /// </summary>
        private void Task3()
        {
            Student student = new Student("Jan", "Kowalski");
            student.DodajOcene(2);
            student.DodajOcene(5);
            student.view();
        }

        ///<summary>
        /// Zadanie 4
        /// </summary>
        private void Task4()
        {
            Licz licz = new Licz(5);
            licz.Dodaj(3);
            licz.Odejmij(2);
            licz.view();

            Licz licz1 = new Licz(3);
            licz.Dodaj(3);
            licz.Odejmij(2);
            licz.view();
        }

        ///<summary>
        /// Zadanie 5
        /// </summary>
        private void Task5()
        {
            Sumator sumator = new Sumator([1,23,34,3,5]);
            sumator.printRange(0, 4);
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
