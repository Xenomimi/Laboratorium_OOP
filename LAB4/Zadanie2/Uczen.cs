using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Uczen
    {
        public string Szkola { get; set; }

        public bool MozeSamWracacDoDomu { get; set; }

        public void SetSchool(string szkola)
        {
            this.Szkola = szkola;
        }
         
        public void ChangeSchool(string szkola)
        {
            this.Szkola = szkola;
        }

        public void SetCanGoHomeAlone(string mozeSamWracacDoDomu)
        {
            this.MozeSamWracacDoDomu = mozeSamWracacDoDomu;
        }
    }
}
