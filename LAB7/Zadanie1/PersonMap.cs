using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public sealed class PersonMap : ClassMap<Person>
	{
		public PersonMap()
		{
			Map(m => m.Imie).Name("Imie");
			Map(m => m.Nazwisko).Name("Nazwisko");
			Map(m => m.Adres.Ulica).Name("Ulica");
			Map(m => m.Adres.NumerDomu).Name("NumerDomu");
			Map(m => m.Adres.KodPocztowy).Name("KodPocztowy");
			Map(m => m.Adres.Miasto).Name("Miasto");
			Map(m => m.Adres.Kraj).Name("Kraj");
			Map(m => m.Pesel).Name("Pesel");
			Map(m => m.Email).Name("Email");
		}
	}
}