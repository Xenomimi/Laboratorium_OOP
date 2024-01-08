using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    public class CustomException2 : Exception
    {
        public CustomException2(string text) : base(text)
        {

        }
    }
}
