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

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            foreach (Uczen uczen in PodwladniUczniowie)
            {
                if (uczen.MozeSamWracacDoDomu == true)
                {
                    Console.WriteLine(uczen);
                }
            }
        }
    }
}
