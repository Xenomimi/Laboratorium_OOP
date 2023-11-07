namespace LAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jan", 23, "w63220");
            Console.WriteLine(student.Name);
            Console.WriteLine(student.NrAlbumu);
            Console.WriteLine(student.Age);

            student.Name = "Janina";
            student.Age = 30;

            Console.WriteLine(student.Name);
        }
    }
}