using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Daty
    {
        private DateTime data;

        public Daty()
        {
            data = DateTime.Now;
        }

        public DateTime PobierzBiezacaDate()
        {
            return data;
        }

        public void PrzesunWprzodOTydzien()
        {
            data = data.AddDays(7);
        }

        public void PrzesunWsteczOTydzien()
        {
            data = data.AddDays(-7);
        }
    }
}
