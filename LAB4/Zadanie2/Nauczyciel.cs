using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Nauczyciel : Uczen
    {
        public string TytulNaukowy { get; set; }
        public List<Uczen> PodwladniUczniowie { get; set; }

        // Nie używam argumentu (Datetime dateToCheck) jak w treści zadania, ponieważ
        // wiek ucznia możemy określać na podstawie numeru PESEL
        public void WhichStudentCanGoHomeAlone()
        {
            Console.WriteLine("Pan {0} {1} powiedział, że...", TytulNaukowy, GetFullName());
            foreach (Uczen uczen in PodwladniUczniowie)
            {
                // Na początku sprawdzamy czy uczeń ma odpowiedni wiek
                if (uczen.GetAge() >= 12)
                    Console.WriteLine(uczen.GetFullName());
                // Następnie czy ma pozwolenie
                // Jeżeli uczeń ma pozwolenie, to może sam wracać do domu
                else if (uczen.CanGoAloneToHome())
                    Console.WriteLine(uczen.GetFullName());
            }
            Console.WriteLine("...mogą sami wracać do domu.");
        }
    }
}
