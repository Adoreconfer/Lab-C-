namespace Lab5.Task
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
            int wybor = inputInt("Podaj numer zadania [1-3]");
            switch (wybor)
            {
                case 1:
                    Task1();
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
