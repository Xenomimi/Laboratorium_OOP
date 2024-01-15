namespace Zadanie5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Stworzenie kilku obiektów typu Person
			var person1 = new Person("1", "Jan", 20);
			var person2 = new Person("2", "Anna", 30);
			var person3 = new Person("3", "Piotr", 40);

			// Stworzenie repozytorium
			var repo = new FilePersonRepository("people.txt");

			// Dodanie obiektów do repozytorium
			repo.AddPerson(person1);
			repo.AddPerson(person2);
			repo.AddPerson(person3);

            // Pobranie obiektu z repozytorium
            Console.WriteLine("Pobrano osobę o ID 2: \n");
            var person = repo.GetPerson("2");
			Console.WriteLine(person.Name + "\n");

            // Pobranie wszystkich obiektów z repozytorium
            Console.WriteLine("Pobranie wszystkich obiektów z repozytorium:");
            var people = repo.GetAllPeople();
			foreach (var p in people)
			{
				Console.WriteLine($"ID: {p.Id} Imie: {p.Name} Wiek: {p.Age}");
			}
		}
	}
}