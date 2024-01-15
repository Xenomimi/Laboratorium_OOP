using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
	public class Population
	{
		private List<CountryData> DanePanstw { get; set; }

		public Population(List<CountryData> dane)
		{
			DanePanstw = dane;
		}

		public void GetPopulationDifference(string country, string year1, string year2)
		{
            // Zwraca różnicę populacji między dwoma latami dla danego kraju
			long wynik1 = GetPopulationForYear(country, year1);
			long wynik2 = GetPopulationForYear(country, year2);
			long wynik = wynik2 - wynik1;
			Console.WriteLine($"Różnica populacji między {year1} a {year2} dla kraju {country} wynosi {wynik}");
        }

		public long GetPopulationForYear(string country, string year)
		{
			// Zwraca populację dla danego kraju w danym roku
			long wynik = Convert.ToInt64(DanePanstw.FirstOrDefault(x => x.Country.Value == country && x.Date == year).Value);
			return wynik;
		}
		public double GetAnnualPopulationGrowthPercentage(string country, string year)
		{
			// Oblicza roczny wzrost procentowy populacji w danym roku w stosunku do poprzedniego roku
			// Wzrost procentowy = (populacja w roku bieżącym - populacja w roku poprzednim) / populacja w roku poprzednim * 100

			// Populacja w roku bieżacym
			long pop_bz = GetPopulationForYear(country, year);
			// Populacja w roku poprzednim
			long pop_pop = GetPopulationForYear(country, (Convert.ToInt32(year) - 1).ToString());
			double wynik = ((double)(pop_bz - pop_pop) / pop_pop) * 100;
			return wynik;
		}
	}
}
