using System.Diagnostics.Metrics;

namespace LAB6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader("test.txt"))
            {
                var line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }
    }
}