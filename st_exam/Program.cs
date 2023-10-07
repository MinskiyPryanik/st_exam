using System;
using System.IO;

namespace st_exam
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            string jsonPath = @"C:\Users\Антон\Desktop\PersonJson.json";
            string json = File.ReadAllText(jsonPath);
            var person = json.Deserialize<Person>();

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.City);
            Console.WriteLine(person.Money);
            Console.WriteLine(person.Card);
            Console.WriteLine(person.Card + person.Money);
            Console.ReadKey();
        }
    }
}
