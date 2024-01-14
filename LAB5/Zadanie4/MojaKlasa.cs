using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
	public class MojaKlasa
	{
		public int Number { get; set; }
		public string Text { get; set; }
		public static MojaKlasa Copy(MojaKlasa original)
		{
			if (original == null)
			{
				throw new ArgumentNullException("original", "Obiekt do skopiowania nie może być null.");
			}

			MojaKlasa copy = new MojaKlasa();
			copy.Number = original.Number;
			copy.Text = original.Text;
			// Skopiuj wszystkie inne pola lub właściwości

			return copy;
		}
	}
}
