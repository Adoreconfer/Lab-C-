using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Class
{
    class Nauczyciel : Uczen
    {
        public string TytulNaukowy { get; private set; }
        public List<Uczen> PodwladniUczniowie { get; private set; }

        public Nauczyciel(Uczen uczen, string TytulNaukowy, List<Uczen> PodwladniUczniowie) : base (new Osoba(uczen.FirstName, uczen.LastName, uczen.Pesel), uczen.Szkola, uczen.MozeSamWracacDoDomu)
        {
            this.TytulNaukowy = TytulNaukowy;
            this.PodwladniUczniowie = PodwladniUczniowie;
        }

        public void WhichStudentCanGoHomeAlone() {
            foreach (Uczen u in PodwladniUczniowie) {
                if (u.CanGoAloneToHome()) {
                    Console.WriteLine(u.LastName);
                }
            }
        }
    }
}
