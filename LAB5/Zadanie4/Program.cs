namespace Zadanie4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				// Tworzenie oryginalnego obiektu
				MojaKlasa original = new MojaKlasa();
				original.Number = 42;
				original.Text = "Hello, world!";

				// Wyświetlanie wartości oryginalnego obiektu
				Console.WriteLine("Oryginalny obiekt:");
				Console.WriteLine($"Number: {original.Number}, Text: {original.Text}");

				// Tworzenie kopii
				MojaKlasa copy = MojaKlasa.Copy(original);

				// Wyświetlanie wartości skopiowanego obiektu
				Console.WriteLine("\nSkopiowany obiekt:");
				Console.WriteLine($"Number: {copy.Number}, Text: {copy.Text}");
			}
			catch (ArgumentNullException ex)
			{
				Console.WriteLine($"Wystąpił błąd: {ex.Message}");
			}

			// Zachowanie otwartego okna konsoli
			Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
			Console.ReadKey();
		}
	}
}