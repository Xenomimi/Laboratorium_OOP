namespace LAB4
{
    internal class Program
    {
        // Polimorfizm statyczny - łaczenie metody z obiektem w trakcie kompilacji (przeciazenie metod i operatorów)
        // Polimorfizm dynamiczny - tworzenie klasy abs i jest on implementowana w klasach pochodnych
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.animalSound();
            dog.animalSound();

            // Klasa abstrakcyjna nie istnieje, nie można utworzyć jej instancji
            //Figura figura = new Figura();

            Kwadrat kwadrat = new Kwadrat();
            Prostokat prostokat = new Prostokat();

            kwadrat.View();
            prostokat.View();

            // Użycie metody z klasy abstrakcyjej
            kwadrat.view();
            prostokat.view();

            // Użycie interfejsów
            Transakcja transakcja = new Transakcja();

            transakcja.PoliczIlosc();
            transakcja.WypiszDane();
        }
    }
}