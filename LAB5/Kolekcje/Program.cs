using System.Collections;

namespace Kolekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            array.Add(23);
            array.Add(24);
            array.Add(25);
            array.Add(26);
            array.Add(27);

            array.Sort();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Hashtable ht = new Hashtable();

            ht.Add("w12345", "Jan Kowalski");
            ht.Add("w12346", "Janina Kowalska");
            ht.Add("w12347", "Adam Nowak");

            if (ht.ContainsKey("w12345"))
            {
                Console.WriteLine($"Wartość klucza: {ht["w12345"]}");
                Console.WriteLine($"Wartość klucza: {ht["w12346"]}");
                Console.WriteLine($"Wartość klucza: {ht["w12347"]}");
            }

            if (ht.ContainsValue("Adan Nowak"))
            {
                Console.WriteLine("Adam Nowak należy do kolekcji");
            }
            else
            {
                Console.WriteLine("Nie należy do kolekcji");
            }

            ICollection key = ht.Keys;

            foreach (string item in key)
            {
                Console.WriteLine($"Klucz: {item} Wartosc: {ht[item]}");
            }


            Stack stos = new Stack();

            stos.Push(12);
            stos.Push(12);
            stos.Push(12);
            stos.Push(12);

            stos.Pop();
        }
    }
}