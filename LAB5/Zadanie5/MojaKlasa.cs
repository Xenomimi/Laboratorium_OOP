using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
	public class MojaKlasa : ICloneable
	{
		public int Number { get; set; }
		public string Text { get; set; }

		public object Clone()
		{
			// MemberwiseClone() wykonuje płytką kopię
			return this.MemberwiseClone();
		}
	}
}
