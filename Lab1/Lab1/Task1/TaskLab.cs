using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

namespace Lab1.Task1
{
    internal class TaskLab
    {
        /// <summary>
        /// Metoda urushomienia dla zadań
        /// </summary>
        /// <remarks>
        /// Autor: Diana Vaida
        /// data: 02.03.2026
        /// środowisko: .net10
        /// </remarks>    
        public void Run() {
            int wybor = inputInt("Podaj numer zadania [1-5]");
            switch (wybor)
            {
                case 1:
                    rownanieKw();
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
        ///Metoda obliczająca wyróżnik delta i pierwiastki trójmianu kwadratowego
        /// </summary>
        /// 
        private void rownanieKw() {
            Console.WriteLine("Rozwiązanie równania kwadratowego: ax^2 + bx + c = 0");

            double a = inputDouble("podaj współczynnik a: ");
            double b = inputDouble("podaj współczynnik b: ");
            double c = inputDouble("podaj współczynnik c: ");

            if (a == 0) {
                Console.WriteLine("To nie jest równaie kwadratowe");
            }

            double delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"Równanie ma dwa pierwiastki rzeczywiste\nx1 = {x1:F2}, x2 = {x2:F2}"); // F2 - wyświetlenie liczby do 2 miejsc
            }
            else if (delta == 0) {
                double x = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x = {x:F2}");
            }
            else
            {
                Console.WriteLine("Nie ma rozwiązanie w liczbach reczywistych");
            }
        }

        ///<summary>
        ///Metoda która pobiera string usera i wykonuje konwersje na double. Wymusza poprawne podanie liczby
        /// </summary>

        private double inputDouble(string prompt) {
            double liczba;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out liczba)) { 
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

        private double LosujLiczbeOdUzytkownika()
        {
            Console.Write("Podaj dolną granicę przedziału (min): ");
            double min = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj górną granicę przedziału (max): ");
            double max = Convert.ToDouble(Console.ReadLine());

            if (min > max)
            {
                double temp = min;
                min = max;
                max = temp;
                Console.WriteLine($"Zamieniono granice. Nowy przedział: [{min}, {max}]");
            }

            Random rng = new Random();
            double wynik = min + rng.NextDouble() * (max - min);

            Console.WriteLine($"Wylosowana liczba: {wynik:F1}");
            return wynik;
        }

        /// <summary> 
        /// Losuje tablicę n liczb double z przedziału [min, max]. 
        /// </summary> 
        private double[] LosujTabliceDouble(int n, double min, double max)
        {
            var rng = new Random();   // opcjonalnie: nowy Random(seed) dla powtarzalności
            double[] arr = new double[n];

            double zakres = max - min;
            for (int i = 0; i < n; i++)
            {
                // NextDouble() -> [0,1), skalujemy do [min, max] 
                arr[i] = Math.Round(min + rng.NextDouble() * zakres, 2);
            }
            return arr;
        }

        /// <summary>
        /// Napisz program umożliwiający wprowadzanie 10-ciu liczb. Dla wprowadzonych liczb wykonaj odpowiednie algorytmy
        /// oblicz sumę elementów tablicy, 
        /// oblicz iloczyn elementów tablicy,
        /// wyznacz wartość średnią, 
        /// wyznacz wartość minimalną, 
        /// wyznacz wartość maksymalną.
        /// </summary>
        private void Task2()
        {
            double sum = 0;
            double iloczyn = 1;
            double max = 0;
            double min = 0;

            for (int i = 0; i < 10; i++)
            {
                double n = inputDouble($"liczba{i+1} = ");
                if (i == 0) {
                    max = min = n;
                }
                sum += n;
                iloczyn *= n;
                max  = (n > max) ? n : max;
                min  = (n < min) ? n : min;
            }

            Console.WriteLine($"Suma = {sum}\nIloczyn = {iloczyn}\nŚrednia = {sum/10}\nMin = {min}\nMax = {max}");
        }

        /// <summary>
        /// Napisz program wyświetlający liczby od 20-0, z wyłączeniem liczb {2,6,9,15,19}. Do realizacji zadania wyłączenia użyj instrukcji continue;
        /// </summary>
        private void Task3()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (checkWyj(i))
                {
                    continue;
                }
                else {
                    Console.Write(i+" ");
                }

            }
        }

        private bool checkWyj(int i) {
            int[] wyjatki = { 2, 6, 9, 15, 19 };
            foreach (int elem in wyjatki)
            {
                if (i == elem) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Napisz program, który w nieskończoność pyta użytkownika o liczby całkowite. Pętla nieskończona powinna się zakończyć gdy użytkownik wprowadzi liczbę mniejszą od zera.
        /// </summary>
        private void Task4() {
            while (true) {
                int liczba = inputInt("Podaj liczbe: ");
                if (liczba < 0) {
                    break;
                }
            }
        }

        private void printTab(double[] tab) {
            foreach (double elem in tab) {
                Console.Write(elem +" ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Napisz program umożliwiający wprowadzanie n liczb oraz sortujący te liczby metodą bąbelkową lub wstawiania
        /// </summary>
        private void Task5()
        {
            int n = inputInt("Podaj rozmiar tablicy = ");
            double[] tablica = LosujTabliceDouble(n, 0, 50);
            printTab(tablica);
            for (int i = 0; i < tablica.Length; i++) {
                for (int j = 0; j < tablica.Length - i - 1; j++) {
                    if (tablica[j] > tablica[j + 1]) {
                        double temp = tablica[j];
                        tablica[j] = tablica[j+1];
                        tablica[j+1] = temp;
                    }
                }
            }
            printTab(tablica);
        }
    }
}
