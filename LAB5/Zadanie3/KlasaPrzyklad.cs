using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class KlasaPrzyklad
    {
        public void CanThrowException(string id)
        {
            if (new Random().Next(5) == 0)
            {
                throw new Exception("Wyjątek zgłoszony w: " + id);
            }
        }
    }
}
