using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Object obj = new Object();
            Car car = new Car();
            Bike bike = new Bike();
            obj.Add(car);
            obj.Add(bike);
            obj.Notify();
            obj.Remove(bike);
            Console.WriteLine("Велик удален");
            obj.Notify();
            Console.ReadKey();
        }
    }
}
