using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
	public class Person
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string id, string name, int age)
		{
			Id = id;
			Name = name;
			Age = age;
		}
	}
}
