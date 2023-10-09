using System;
using System.IO;
using Newtonsoft.Json;

namespace jsonSerialization
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1, "Toyota", 6000);
            Car car1 = new Car(2, "Moskvich", 8000);
            File.WriteAllText("car.json", JsonSerial.JsonSerializeObject(car1));
            Console.WriteLine("Успешно");
            Console.ReadKey();
        }
    }
}
