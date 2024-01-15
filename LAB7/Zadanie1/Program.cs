using CsvHelper;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Zadanie1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Menu();
		}
		static void Menu()
		{
			string file = "database.csv";

			while (true)
			{
				ViewMenu();
				int c = InputInt();
				switch (c)
				{
					case 1:
						{
							// Wyświetl dane
							Console.Clear();
							Console.WriteLine("Wyświetlanie danych z bazy: ");
							ReadAndDisplayDataFromCsv(file);
							break;
						}
					case 2:
						{
							// Dodaj osobę
							Console.Clear();
							WriteDataToCsv(file);
							break;
						}
					case 3:
						{
							// Modyfikuj osobę
							Console.Clear();
							ModifyPersonInCsv(file);
							break;
						}
					case 4:
						{
							// Usuń osobę
							Console.Clear();
							DeletePersonInCsv(file);
							break;
						}
					case 5:
						{
							// Wyjście z programu
							Environment.Exit(0);
							break;
						}
					default:
						{
							// Nieznana opcja
							Console.WriteLine("Proszę podać poprawną opcję.");
							break;
						}
				}
			}
		}
		static void ViewMenu()
		{
			Console.WriteLine("Dostępne opcje w programie:");
			Console.WriteLine("1. Wyświetl dane");
			Console.WriteLine("2. Dodaj osobę");
			Console.WriteLine("3. Modyfikuj osobę");
			Console.WriteLine("4. Usuń osobę");
			Console.WriteLine("5. Wyjście z programu");
		}
		static int InputInt()
		{
			int choise = Convert.ToInt32(Console.ReadLine());
			return choise;
		}

		static void WriteDataToCsv(string filePath)
		{
			do
			{
				Person person = new Person();
				Console.Write("Podaj imie: ");
				person.Imie = Console.ReadLine();
				Console.Write("Podaj nazwisko: ");
				person.Nazwisko = Console.ReadLine();
				Console.Write("Podaj pesel: ");
				person.Pesel = Convert.ToInt64(Console.ReadLine());
				Console.Write("Podaj email: ");
				person.Email = Console.ReadLine();
				Console.Write("Podaj ulicę: ");
				person.Adres = new Adres();
				person.Adres.Ulica = Console.ReadLine();
				Console.Write("Podaj numer domu: ");
				person.Adres.NumerDomu = Console.ReadLine();
				Console.Write("Podaj numer mieszkania: ");
				person.Adres.NumerMieszkania = Console.ReadLine();
				Console.Write("Podaj kod pocztowy: ");
				person.Adres.KodPocztowy = Console.ReadLine();
				Console.Write("Podaj miasto: ");
				person.Adres.Miasto = Console.ReadLine();
				Console.Write("Podaj kraj: ");
				person.Adres.Kraj = Console.ReadLine();

				if (IsValidPesel(person.Pesel) && !CzyJakakolwiekWartoscJestNull(person) && CheckEmail(person.Email))
				{
					Console.Clear();
					if (IsCsvFileEmpty(filePath))
					{
						using (var writer = new StreamWriter(filePath))
						using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
						{
							csv.WriteHeader<Person>();
						}
					}

					using (var stream = new FileStream(filePath, FileMode.Append))
					using (var writer = new StreamWriter(stream))
					using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
					{
						csv.WriteRecord(person);
						writer.WriteLine();
					}

					Console.WriteLine("Dane zapisane do pliku CSV.\n");
					break;
				}
				else
				{
					Console.WriteLine("Niepoprawne dane.");
				}
			} while (true);
		}

		static void ReadAndDisplayDataFromCsv(string filePath)
		{
			try
			{
				// Sprawdź, czy plik istnieje
				if (!File.Exists(filePath))
				{
					// Jeżeli nie, utwórz nowy plik
					using (var stream = File.Create(filePath))
					{
						Console.WriteLine("Utworzono nowy plik CSV.");
					}
					if (IsCsvFileEmpty(filePath))
					{
						using (var writer = new StreamWriter(filePath))
						using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
						{
							csv.WriteHeader<Person>();
						}
					}
				}

				// Kontynuuj odczyt danych z pliku
				using (var reader = new StreamReader(filePath))
				using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
				{
					csv.Context.RegisterClassMap<PersonMap>();
					var records = csv.GetRecords<Person>().ToList();

					Console.WriteLine("\nDane odczytane z pliku CSV:");
					foreach (var person in records)
					{
						Console.WriteLine($"Imię: {person.Imie}\nNazwisko: {person.Nazwisko}\n");
					}
				}
				Console.WriteLine();
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Nie znaleziono danych w pliku.");
			}
			catch (FileNotFoundException)
			{
				Console.WriteLine("Nie znaleziono pliku.");
			}
			catch (Exception e)
			{
				Console.WriteLine($"Wystąpił błąd: {e.Message}");
			}
		}

		static void ModifyPersonInCsv(string filePath)
		{
			Console.Write("Podaj PESEL osoby do modyfikacji: ");

			if (!long.TryParse(Console.ReadLine(), out long pesel))
			{
				Console.WriteLine("Niepoprawny PESEL.");
				return;
			}

			var records = new List<Person>();

			// Sprawdź, czy plik istnieje
			if (!File.Exists(filePath))
			{
				// Jeżeli nie, utwórz nowy plik
				using (var stream = File.Create(filePath))
				{
					Console.WriteLine("Brak dostępu do modyfikowania. Powód: Brak pliku");
					Console.WriteLine("Utworzono nowy plik CSV.");
				}
				if (IsCsvFileEmpty(filePath))
				{
					using (var writer = new StreamWriter(filePath))
					using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
					{
						csv.WriteHeader<Person>();
					}
				}
			}
			else
			{
				using (var reader = new StreamReader(filePath))
				using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
				{
					csv.Context.RegisterClassMap<PersonMap>();
					records = csv.GetRecords<Person>().ToList();
				}

				var person = records.FirstOrDefault(p => p.Pesel == pesel);

				if (person == null)
				{
					Console.WriteLine("Nie znaleziono osoby o podanym PESELu.");
					return;
				}
				else
				{
					Console.Write("Podaj nowe imię (pozostaw puste, aby nie zmieniać): ");
					var newImie = Console.ReadLine();
					if (!string.IsNullOrEmpty(newImie))
					{
						person.Imie = newImie;
					}
					Console.Write("Podaj nowe nazwisko (pozostaw puste, aby nie zmieniać): ");
					var newNazwisko = Console.ReadLine();
					if (!string.IsNullOrEmpty(newNazwisko))
					{
						person.Nazwisko = newNazwisko;
					}
					Console.Write("Podaj nowy email (pozostaw puste, aby nie zmieniać): ");
					var newEmail = Console.ReadLine();
					if (!string.IsNullOrEmpty(newEmail))
					{
						person.Email = newEmail;
					}
					Console.Write("Podaj nową ulicę (pozostaw puste, aby nie zmieniać): ");
					var newUlica = Console.ReadLine();
					if (!string.IsNullOrEmpty(newUlica))
					{
						person.Adres.Ulica = newUlica;
					}
					Console.Write("Podaj nowy numer domu (pozostaw puste, aby nie zmieniać): ");
					var newNumerDomu = Console.ReadLine();
					if (!string.IsNullOrEmpty(newNumerDomu))
					{
						person.Adres.NumerDomu = newNumerDomu;
					}
					Console.Write("Podaj nowy numer mieszkania (pozostaw puste, aby nie zmieniać): ");
					var newNumerMieszkania = Console.ReadLine();
					if (!string.IsNullOrEmpty(newNumerMieszkania))
					{
						person.Adres.NumerMieszkania = newNumerMieszkania;
					}
					Console.Write("Podaj nowy kod pocztowy (pozostaw puste, aby nie zmieniać): ");
					var newKodPocztowy = Console.ReadLine();
					if (!string.IsNullOrEmpty(newKodPocztowy))
					{
						person.Adres.KodPocztowy = newKodPocztowy;
					}
					Console.Write("Podaj nowe miasto (pozostaw puste, aby nie zmieniać): ");
					var newMiasto = Console.ReadLine();
					if (!string.IsNullOrEmpty(newMiasto))
					{
						person.Adres.Miasto = newMiasto;
					}
					Console.Write("Podaj nowy kraj (pozostaw puste, aby nie zmieniać): ");
					var newKraj = Console.ReadLine();
					if (!string.IsNullOrEmpty(newKraj))
					{
						person.Adres.Kraj = newKraj;
					}

					// Nadpisz listę osób w pliku CSV

					if (IsValidPesel(person.Pesel) && CheckEmail(person.Email))
					{
						using (var writer = new StreamWriter(filePath))
						using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
						{
							csv.Context.RegisterClassMap<PersonMap>();
							csv.WriteRecords(records);
						}
						Console.WriteLine("Dane zostały zmodyfikowane.");
					}
					else
					{
						Console.WriteLine("Niepoprawne dane.");
					}
				}
			}
		}

		static void DeletePersonInCsv(string filePath)
		{
			Console.Write("Podaj PESEL osoby do modyfikacji: ");

			if (!long.TryParse(Console.ReadLine(), out long pesel))
			{
				Console.WriteLine("Niepoprawny PESEL.");
				return;
			}

			var records = new List<Person>();

			if (!File.Exists(filePath))
			{
				// Jeżeli nie, utwórz nowy plik
				using (var stream = File.Create(filePath))
				{
					Console.WriteLine("Brak dostępu do usuwania. Powód: Brak pliku");
                    Console.WriteLine("Utworzono nowy plik CSV.");
                }
				if (IsCsvFileEmpty(filePath))
				{
					using (var writer = new StreamWriter(filePath))
					using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
					{
						csv.WriteHeader<Person>();
					}
				}
			}
			else
			{
				using (var reader = new StreamReader(filePath))
				using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
				{
					csv.Context.RegisterClassMap<PersonMap>();
					records = csv.GetRecords<Person>().ToList();
				}

				var person = records.FirstOrDefault(p => p.Pesel == pesel);

				records.Remove(person);

				if (person == null)
				{
					Console.WriteLine("Nie znaleziono osoby o podanym PESELu.");
					return;
				}
				else
				{
					// Nadpisz listę osób w pliku CSV
					using (var writer = new StreamWriter(filePath))
					using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
					{
						csv.Context.RegisterClassMap<PersonMap>();
						csv.WriteRecords(records);
					}
					Console.WriteLine("Użytkownik został usunięty.");
				}
			}
		}
		static bool CzyJakakolwiekWartoscJestNull(object obiekt)
		{
			foreach (PropertyInfo property in obiekt.GetType().GetProperties())
			{
				if (property.GetValue(obiekt) == null)
				{
					return true;
				}
			}
			return false;
		}

		static bool IsValidPesel(long pesel)
		{
			if (pesel.ToString().Length != 11)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		static bool CheckEmail(string email)
		{
			if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") || email != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool IsCsvFileEmpty(string filePath)
		{
			if (File.Exists(filePath))
			{
				long fileSize = new FileInfo(filePath).Length;

				return fileSize == 0;
			}
			else
			{
				return true;
			}
		}
	}
}