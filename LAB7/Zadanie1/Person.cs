using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class Person
	{
		public string Imie { get; set; }
		public string Nazwisko { get; set; }
		public Adres Adres { get; set; }
		public long Pesel { get; set; }
		public string Email { get; set; }
	}
}