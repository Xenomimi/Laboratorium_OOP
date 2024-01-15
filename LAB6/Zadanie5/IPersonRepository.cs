using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
	public interface IPersonRepository
	{
		void AddPerson(Person person);
		Person GetPerson(string id);
		List<Person> GetAllPeople();
	}
}
