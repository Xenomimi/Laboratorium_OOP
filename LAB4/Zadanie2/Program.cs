namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Janek ma 13 lat wiec może sam wracać do domu
            Uczen uczen1 = new Uczen();
            uczen1.SetFirstName("Jan");
            uczen1.SetLastName("Kowalski");
            uczen1.SetPesel("10301333819");
            uczen1.SetSchool("ZSEl");
            uczen1.SetCanGoHomeAlone(false);

            // Monika ma 11 lat, ale ma pozwolenie, wiec może sama wracać do domu
            Uczen uczen2 = new Uczen();
            uczen2.SetFirstName("Monika");
            uczen2.SetLastName("Nowak");
            uczen2.SetPesel("12311457286");
            uczen2.SetSchool("ZSEl");
            uczen2.SetCanGoHomeAlone(true);

            // Adam ma 11 lat, ale nie ma pozwolenia, wiec nie może sama wracać do domu
            Uczen uczen3 = new Uczen();
            uczen3.SetFirstName("Adam");
            uczen3.SetLastName("Marczak");
            uczen3.SetPesel("12251376995");
            uczen3.SetSchool("ZSEl");
            uczen3.SetCanGoHomeAlone(false);

            // Tworzymy nauczyciela

            Nauczyciel nauczyciel = new Nauczyciel();
            nauczyciel.SetFirstName("Marian");
            nauczyciel.SetLastName("Nowakowski");
            nauczyciel.SetPesel("45081312345");
            nauczyciel.SetSchool("ZSEl");
            nauczyciel.SetCanGoHomeAlone(true);
            nauczyciel.TytulNaukowy = "prof.";

            //Dodajemy uczniów do listy uczniów podwładnych nauczyciela

            nauczyciel.PodwladniUczniowie = new List<Uczen>();
            nauczyciel.PodwladniUczniowie.Add(uczen1);
            nauczyciel.PodwladniUczniowie.Add(uczen2);
            nauczyciel.PodwladniUczniowie.Add(uczen3);

            // Wyświetlamy listę uczniów, którzy mogą sami wracać do domu

            nauczyciel.WhichStudentCanGoHomeAlone();
        }
    }
}