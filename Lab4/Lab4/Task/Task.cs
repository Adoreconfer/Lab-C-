using Lab4.Class;

namespace Lab4.Task
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
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
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
            List<Shape> shapes = new List<Shape>();

            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();
            Circle circle = new Circle();

            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Add(circle);

            foreach (Shape shape in shapes) {
                shape.Draw();
            }
        }

        ///<summary>
        /// Zadanie 2
        /// </summary>
        private void Task2() {
            Osoba o1 = new Osoba("Jan", "Kowalski", "04211312345");
            Osoba o2 = new Osoba("Anna", "Nowak", "09251567890");

            Uczen u1 = new Uczen(o1, "SP nr 5", true);
            Uczen u2 = new Uczen(o2, "SP nr 5", false);

            List<Uczen> listaUczniow = new List<Uczen>() { u1, u2 };

            Uczen nauczycielOsoba = new Uczen(new Osoba("Marek", "Zielinski", "80010112345"), "SP nr 5", true);

            Nauczyciel n1 = new Nauczyciel(nauczycielOsoba, "mgr", listaUczniow);

            n1.WhichStudentCanGoHomeAlone();
        }

        ///<summary>
        /// Zadanie 3
        /// </summary>
        private void Task3()
        {
            List<IPerson> lista = new List<IPerson>(){
                new Person("Jan", "Kowalski"),
                new Person("Anna","Nowak")
            };

            lista.WypiszOsoby();
            lista.PosortujOsobyPoNazwisku();

            var student = new Student("Jan", "Kowalski", "WSIiZ", "4IID-P", 2018, 2);

            Console.WriteLine(student.WypiszPelnaNazweIUczelnie());

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
