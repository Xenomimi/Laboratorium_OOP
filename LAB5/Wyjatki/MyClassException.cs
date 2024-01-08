using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    public class MyClassException : ApplicationException
    {
        public MyClassException(string text) : base(text)
        {

        }
    }
}
