using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Zadanie5
{
	public class FilePersonRepository : IPersonRepository
	{
		private readonly string _filePath;

		public FilePersonRepository(string filePath)
		{
			_filePath = filePath;
		}

		public void AddPerson(Person person)
		{
			var newLine = JsonConvert.SerializeObject(person);
			File.AppendAllText(_filePath, newLine + Environment.NewLine);
		}

		public Person GetPerson(string id)
		{
			var lines = File.ReadAllLines(_filePath);
			foreach (var line in lines)
			{
				var person = JsonConvert.DeserializeObject<Person>(line);
				if (person != null && person.Id == id)
				{
					return person;
				}
			}
			return null;
		}

		public List<Person> GetAllPeople()
		{
			var people = new List<Person>();
			var lines = File.ReadAllLines(_filePath);

			foreach (var line in lines)
			{
				var person = JsonConvert.DeserializeObject<Person>(line);
				if (person != null)
				{
					people.Add(person);
				}
			}
			return people;
		}
	}
}
