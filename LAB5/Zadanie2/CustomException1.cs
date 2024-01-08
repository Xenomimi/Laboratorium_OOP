using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    public class CustomException1 : Exception
    {
        public CustomException1(string text) : base(text)
        {

        }
    }
}
